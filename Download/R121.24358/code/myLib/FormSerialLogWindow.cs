using System;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MyUtilities;
using SerialInterface;

namespace LogTerminal
{
    public partial class FormSerialLogWindow : Form
    {
        #region Delegates
        private readonly MyDelegates.SetDataModeDelegate _setDataMode;
        private readonly MyDelegates.TxDataDelegate _txData;
        #endregion

        #region Local Variables
        public static string TraceClass;
        private int _dgvLoglineCounter = 1; // Line number that is printed in dgv log window. Tracked by this Counter.
        private bool _keyHandled = false;
        private readonly Color[] _logMsgTypeColor = { Color.DarkSlateGray, Color.Black, Color.Blue, Color.Black, Color.Orange, Color.Red }; // Various colors for logging info
        #endregion // Local Variables

        #region Classes
        // Create an instance of classes
#pragma warning disable
        private static FrmTerminal s_parentForm;
#pragma warning restore
        public MySharedData _sharedData;
        readonly MyDgv _myDgv = new MyDgv();
        readonly MyUi _myUi = new MyUi();
        #endregion // Classes

        #region Constructor
        public FormSerialLogWindow (FrmTerminal parent,
            MySharedData mySharedData,
            MyDelegates.SetDataModeDelegate setDataMode,
            MyDelegates.TxDataDelegate txData)
        {
            TraceClass = GetType().Name; // Assign the class name to the static variable
            s_parentForm = parent;
            _sharedData = mySharedData;
            _txData = txData;
            _setDataMode = setDataMode;

            InitializeComponent();

            InitializeDataGridView();

            // Initialize Events
            TbAnalyzeHexData.GotFocus += TbAnalyzeHexData_GotFocus;
            TbAnalyzeHexData.KeyPress += TbAnalyzeHexData_KeyPress;
            TbSendHex.KeyDown += TbSendHex_KeyDown;
            TbSendHex.KeyPress += TbSendHex_KeyPress;
            TbSendAscii.KeyDown += TbSendAscii_KeyDown;
            TbSendAscii.KeyPress += TbSendAscii_KeyPress;
            this.FormClosing += Form_FormClosing;
        }
        #endregion // Constructor

        #region Local Properties
        public bool FormEnable
        {
            set
            {
                btnSendHex.Enabled = value;
                btnSendAscii.Enabled = value;
            }
        }
        public CheckBox AsciiCheckbox
        {
            get { return cbConvertAscii; }
            set { cbConvertAscii = value; }
        }
        #endregion // Local Properties

        #region Local Methods
        private void InitializeDataGridView()
        {
            // Set up columns
            _dgvLoglineCounter = 1;
            dgvLogWindow.ColumnCount = 5;

            // Set column names
            dgvLogWindow.Columns[0].Name = "#";
            dgvLogWindow.Columns[1].Name = "HH:MM:SS";
            dgvLogWindow.Columns[2].Name = "<->";
            dgvLogWindow.Columns[3].Name = "Data";
            dgvLogWindow.Columns[4].Name = "Message";

            // Set up Column Type
            dgvLogWindow.Columns[0].SortMode = DataGridViewColumnSortMode.Automatic;
            dgvLogWindow.Columns[0].ValueType = typeof(int);
            dgvLogWindow.Columns[0].DefaultCellStyle.Format = "N0"; // Specify the numeric format if needed

            // Set column widths and make the second column fixed size
            dgvLogWindow.Columns[0].Width = 50; // Set the width of the first column
            dgvLogWindow.Columns[0].Frozen = true; // Make the second column a fixed size
            dgvLogWindow.Columns[0].Resizable = DataGridViewTriState.False;
            dgvLogWindow.Columns[1].Width = 75; // Set the width of the first column
            dgvLogWindow.Columns[1].Frozen = true; // Make the second column a fixed size
            dgvLogWindow.Columns[1].Resizable = DataGridViewTriState.False;
            dgvLogWindow.Columns[2].Width = 25; // Set the width of the second column
            dgvLogWindow.Columns[2].Frozen = true; // Make the second column a fixed size
            dgvLogWindow.Columns[2].Resizable = DataGridViewTriState.False;
            dgvLogWindow.Columns[3].Width = 250; // Set the width of the second column
            dgvLogWindow.Columns[3].Frozen = true; // Make the second column a fixed size
            dgvLogWindow.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Allow the third column to fill the remaining space

            // Add a row with sample values
            TraceAppMsg("", string.Format($"{_sharedData.SystemAppName}: Started at {DateTime.Now} "));

#if DEBUG
            TraceAppMsg("", "***** DEBUG BUILD *****");
#endif

        }

        /// <summary> DataGridView Add data to a new row/record</summary>
        public void AddRowToDataGridView(DataGridView dataGridView, string logMode, string logData, string logMessage)
        {
            _myUi.InvokeIfRequired(dgvLogWindow, () =>
            {
                if (!dgvLogWindow.IsDisposed || dgvLogWindow != null && dgvLogWindow.ColumnCount != 0)
                {
                    // Add a new row and set values in each column
                    dataGridView.Rows.Add(_dgvLoglineCounter.ToString(), DateTime.Now.ToString("hh:mm:ss tt"),
                                          logMode, logData, logMessage);
                    _dgvLoglineCounter++;

                    if (cbTermAutoScroll.Checked)
                    {
                        _myDgv.ScrollToLastRecord(dataGridView);
                    }
                }
            });
        }
        /// <summary> Log Tx data to the terminal window. </summary>
        /// <param name="msgtype"> The type of message to be written. </param>
        /// <param name="data"> The string containing the data to be shown. </param>
        /// <param name="msg"> The string containing the message to be shown. </param>
        /// 
        public void LogTx(LogMsgType msgtype, string data, string msg)
        {
            AddRowToDataGridView(dgvLogWindow, "Tx", data, msg);
            _myDgv.SetFontColorForLastRow(dgvLogWindow, _logMsgTypeColor[(int)msgtype]);
        }
        /// <summary> Log Rx data to the terminal window. </summary>
        /// <param name="msgtype"> The type of message to be written. </param>
        /// <param name="data"> The string containing the data to be shown. </param>
        /// <param name="msg"> The string containing the message to be shown. </param>
        public void LogRx(LogMsgType msgtype, string data, string msg)
        {
            // Uses InvokeIfRequired to ensure this method is called on the UI thread
            if (!cbTermPauseRX.Checked)
            {
                _myUi.InvokeIfRequired(dgvLogWindow, () => AddRowToDataGridView(dgvLogWindow, "Rx", data, msg));
                // Use InvokeIfRequired for SetFontColorForLastRow if it accesses UI controls
                _myUi.InvokeIfRequired(dgvLogWindow, () => _myDgv.SetFontColorForLastRow(dgvLogWindow, _logMsgTypeColor[(int)msgtype]));
            }
        }
        /// <summary> Log system message to the terminal window. </summary>
        /// <param name="msgtype"> The type of message to be written. </param>
        /// <param name="data"> The string containing the data to be shown. </param>
        /// <param name="msg"> The string containing the message to be shown. </param>
        public void LogMsg(LogMsgType msgtype, string data, string msg)
        {
            AddRowToDataGridView(dgvLogWindow, "--", data, msg);
            _myDgv.SetFontColorForLastRow(dgvLogWindow, _logMsgTypeColor[(int)msgtype]);
        }
        /// <summary> Wrapper to log messages
        /// </summary>
        public void TraceAppMsg(string data, string msg)
        {
            LogMsg(LogMsgType.MsgFromApp, data, string.Format($"{msg}"));
            Trace.WriteLine($"{TraceClass} : {data} : {msg}");
        }

        #endregion

        #region Event Handlers

        #region Event Handlers > Form Change

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true; // Cancel the form closing
                Hide(); // Hide the form instead
            }
        }

        private void TbAnalyzeHexData_GotFocus(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() => (sender as TextBox).SelectAll()));
        }
        private void TbAnalyzeHexData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Handle Enter key press
                e.Handled = true;

                // Trigger the button click event (send the message)
                BtnAnalyzeHexDataSearch_Click(sender, e);
            }
        }
        private void TbSendHex_KeyDown(object sender, KeyEventArgs e)
        {
            // If the user presses [ENTER], send the data now
            if (_keyHandled = e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                // Trigger the button click event (send the message)
                BtnSendHex_Click(sender, e);
            }
        }
        private void TbSendHex_KeyPress(object sender, KeyPressEventArgs e)
        { e.Handled = _keyHandled; }
        private void TbSendAscii_KeyDown(object sender, KeyEventArgs e)
        {
            // If the user presses [ENTER], send the data now
            if (_keyHandled = e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                // Trigger the button click event (send the message)
                BtnSendAscii_Click(sender, e);
            }
        }
        private void TbSendAscii_KeyPress(object sender, KeyPressEventArgs e)
        { 
            e.Handled = _keyHandled; 
        }

        #endregion // Event Handlers > Form Change

        #region Events Handlers > Form Button Click

        private void BtnAnalyzeHexDataSearch_Click(object sender, EventArgs e)
        {
#if DEBUG
            Trace.WriteLine($"{TraceClass} : {MethodBase.GetCurrentMethod().Name}");
#endif
            // Search in 2nd Column
            _myDgv.SearchAndShowResults(dgvLogWindow, 3, TbAnalyzeHexData.Text);
        }

        private void BtnAnalyzeHexDataShowAll_Click(object sender, EventArgs e)
        {
#if DEBUG
            Trace.WriteLine($"{TraceClass} : {MethodBase.GetCurrentMethod().Name}");
#endif
            _myDgv.UnhideAllRows(dgvLogWindow);
        }

        private void TsbtnLogOpen_Click(object sender, EventArgs e)
        {
#if DEBUG
            Trace.WriteLine($"{TraceClass} : {MethodBase.GetCurrentMethod().Name}");
#endif
            _myDgv.OpenTxtFileToDgvDialog(dgvLogWindow);
        }

        private void TsbtnLogSaveAs_Click(object sender, EventArgs e)
        {
#if DEBUG
            Trace.WriteLine($"{TraceClass} : {MethodBase.GetCurrentMethod().Name}");
#endif
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = saveFileDialog.FileName;
                    _myDgv.SaveDgvToTxtFile(dgvLogWindow, filePath);
                }
            }
        }

        private void BtnSendHex_Click(object sender, EventArgs e)
        {
#if DEBUG
            Trace.WriteLine($"{TraceClass} : {MethodBase.GetCurrentMethod().Name}");
#endif
            _setDataMode(DataMode.Hex);
            _txData(TbSendHex.Text);
        }


        private void BtnSendAscii_Click(object sender, EventArgs e)
        {
#if DEBUG
            Trace.WriteLine($"{TraceClass} : {MethodBase.GetCurrentMethod().Name}");
#endif
            _setDataMode(DataMode.Text);
            _txData(TbSendAscii.Text);
            _setDataMode(DataMode.Hex);
        }

        private void BtnDelSelRow_Click(object sender, EventArgs e)
        {
#if DEBUG
            Trace.WriteLine($"{TraceClass} : {MethodBase.GetCurrentMethod().Name}");
#endif
            // Delete selected rows in dgvLogWindow
            _myDgv.DeleteSelectedRows(dgvLogWindow);
        }

        private void BtnTermClearAll_Click(object sender, EventArgs e)
        {
#if DEBUG
            Trace.WriteLine($"{TraceClass} : {MethodBase.GetCurrentMethod().Name}");
#endif
            // Clear all rows and columns
            dgvLogWindow.Rows.Clear();
        }

        private void BtnTermReset_Click(object sender, EventArgs e)
        {
#if DEBUG
            Trace.WriteLine($"{TraceClass} : {MethodBase.GetCurrentMethod().Name}");
#endif
            dgvLogWindow.Rows.Clear();
            LogMsg(LogMsgType.MsgFromApp, "", $"{_sharedData.SystemAppName}: Resetting Log...");
            InitializeDataGridView();
        }
#endregion // Events Handlers > Form Button Click

#endregion // Event Handlers
    }
}
