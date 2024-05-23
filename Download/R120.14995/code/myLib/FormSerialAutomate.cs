using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyUtilities;

namespace LogTerminal
{
    public partial class FormSerialAutomate : Form
    {
        #region Delegates
        private readonly MyDelegates.TraceAppMsgDelegate _traceAppMsg;
        private readonly MyDelegates.GetConnectStateDelegate _getConnectState;
        private readonly MyDelegates.AutomateActiveDelegate _serialAutomateActive;
        private readonly MyDelegates.TxDataDelegate _txData;
        #endregion

        #region Local Variables
        public static string TraceClass;
        private enum DgvScriptingColumns { Delay, Tx };
        private enum DgvAutoReplyColumns { Rx, Delay, Tx };
        #endregion

        #region Classes
        // Create an instance of classes
#pragma warning disable
        private static FrmTerminal s_parentForm;
#pragma warning restore
        public MySharedData _sharedData;
        readonly MyDgv _myDgv = new MyDgv();
        #endregion

        #region Constructor
        public FormSerialAutomate(FrmTerminal parent,
            MySharedData mySharedData,
            MyDelegates.GetConnectStateDelegate getConnectState,
            MyDelegates.AutomateActiveDelegate serialAutomateActive,
            MyDelegates.TraceAppMsgDelegate traceAppMsg,
            MyDelegates.TxDataDelegate txData)
        {
            TraceClass = GetType().Name; // Assign the class name to the static variable
            s_parentForm = parent;
            _sharedData = mySharedData;
            _getConnectState = getConnectState;
            _serialAutomateActive = serialAutomateActive;
            _traceAppMsg = traceAppMsg;
            _txData = txData;


            InitializeComponent();
            InitializeScriptDataGridView();
            InitializeAutoReplyDataGridView();
        }
        #endregion // Constructor

        #region Local Properties
        public bool FormEnable
        {
            set
            {
                cbScriptLoop.Enabled = value;
                cbScriptEnable.Checked = false;
                cbScriptEnable.Enabled = value;
                cbAutoReplyEnable.Checked = false;
                cbAutoReplyEnable.Enabled = value;
            }
        }
        public CheckBox ScriptEnableCheckbox
        { 
            get { return cbScriptEnable;  }
            set { cbScriptEnable = value;  } 
        }
        public CheckBox AutoReplyEnableCheckbox
        {
            get { return cbAutoReplyEnable; }
            set { cbAutoReplyEnable = value; } 
        }
        #endregion // Local Properties

        #region Local Methods
        private void InitializeScriptDataGridView()
        {
            // Set up columns
            dgvScripting.ColumnCount = 2;

            // Set column names
            dgvScripting.Columns[(int)DgvScriptingColumns.Delay].Name = "Delay (msec)";
            dgvScripting.Columns[(int)DgvScriptingColumns.Tx].Name = "Tx Data";

            // Set column widths
            dgvScripting.Columns[(int)DgvScriptingColumns.Delay].Width = 50; // Set the width of the first column
            dgvScripting.Columns[(int)DgvScriptingColumns.Delay].Frozen = true; // Make the second column a fixed size
            dgvScripting.Columns[(int)DgvScriptingColumns.Delay].Resizable = DataGridViewTriState.False;
            dgvScripting.Columns[(int)DgvScriptingColumns.Tx].Resizable = DataGridViewTriState.False;
            dgvScripting.Columns[(int)DgvScriptingColumns.Tx].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Allow the third column to fill the remaining space

            // Add a new row and set values in each column
            dgvScripting.Rows.Add("00", "AA 55 66 5F 0D");
        }
        private void InitializeAutoReplyDataGridView()
        {
            // Set up columns
            dgvAutoReply.ColumnCount = 3;

            // Set column names
            dgvAutoReply.Columns[(int)DgvAutoReplyColumns.Rx].Name = "Rx Data";
            dgvAutoReply.Columns[(int)DgvAutoReplyColumns.Delay].Name = "Delay (msec)";
            dgvAutoReply.Columns[(int)DgvAutoReplyColumns.Tx].Name = "Tx Data";

            // Set column widths
            dgvAutoReply.Columns[(int)DgvAutoReplyColumns.Rx].Width = 200; // Set the width of the second column
            dgvAutoReply.Columns[(int)DgvAutoReplyColumns.Rx].Resizable = DataGridViewTriState.False;
            dgvAutoReply.Columns[(int)DgvAutoReplyColumns.Delay].Width = 50; // Set the width of the first column
            dgvAutoReply.Columns[(int)DgvAutoReplyColumns.Delay].Frozen = true; // Make the second column a fixed size
            dgvAutoReply.Columns[(int)DgvAutoReplyColumns.Delay].Resizable = DataGridViewTriState.False;
            dgvAutoReply.Columns[(int)DgvAutoReplyColumns.Tx].Resizable = DataGridViewTriState.False;
            dgvAutoReply.Columns[(int)DgvAutoReplyColumns.Tx].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Allow the third column to fill the remaining space

            // Add a new row and set values in each column
            dgvAutoReply.Rows.Add("AA 55 66 5F 0D", "0", "11 22 33 44 55");
        }

        /// <summary> DataGridView when enabled proceed to start sending list of messages with delays.</summary>
        private async Task ProcessScriptingAsync()
        {
            const int ScriptingDelay = 250;
            var defaultColor = Color.Empty;
            var activeColor = Color.LightSeaGreen;

            if (!_getConnectState())
            {
                cbScriptEnable.Checked = false;
                _traceAppMsg("", $"{_sharedData.SystemAppName}: Unable to Start Task Scripting, Not connected to any device.");
            }

            if (cbScriptEnable.Checked && gbScripting.Enabled && dgvScripting.Rows.Count > 1)
            {
                _serialAutomateActive();
                _traceAppMsg("", "Start Async Task Scripting");
                var dataErrorCounter = 0;
                while (cbScriptEnable.Checked)
                {
                    var continueLoop = true;
                    foreach (DataGridViewRow row in dgvScripting.Rows) // Access data in each cell
                    {
                        var data = row.Cells[(int)DgvScriptingColumns.Tx].Value?.ToString(); // Get data cell
                        // Check if data is not null. This is to avoid looking at the next row which is always empty.
                        if (!string.IsNullOrEmpty(data) && data != "" && _myDgv.VerifyHexStringInCell(row.Cells[(int)DgvScriptingColumns.Tx]))
                        {
                            // Verify data in cell, set invalid data to default
                            row.Cells[(int)DgvScriptingColumns.Delay].Value = _myDgv.VerifyReplaceIntInCell(row.Cells[(int)DgvScriptingColumns.Delay], ScriptingDelay);
                            var delay = _myDgv.VerifyReplaceIntInCell(row.Cells[(int)DgvScriptingColumns.Delay], ScriptingDelay);

                            row.Cells[(int)DgvScriptingColumns.Delay].Style.BackColor = activeColor;
                            await Task.Delay(delay * 1); // Proceed to process the delay
                            row.Cells[(int)DgvScriptingColumns.Delay].Style.BackColor = defaultColor;

                            if (cbScriptEnable.Checked) _txData(data); // Delay could be long, confirm user didn't cancel.
                            else
                            {
                                _traceAppMsg("", "User Cancelled Task");
                                continueLoop = false;
                                break;
                            }
                        }
                        else dataErrorCounter++;
                    }

                    if (!cbScriptLoop.Checked) continueLoop = false;

                    // This is to catch invalid values and allow error exit from while loop if there are error in every dgv row.
                    if (dataErrorCounter >= dgvScripting.RowCount)
                    {
                        _traceAppMsg("", $"Scripting Error Counter ='{dataErrorCounter}'");
                        continueLoop = false;
                    }
                    else dataErrorCounter = 0;

                    if (!continueLoop) // Clean up before exiting
                    {
                        _traceAppMsg("", $"Ending Async Task Scripting");
                        cbScriptEnable.Checked = false; // Unchecked the Enable box
                        break; // Exit the while loop
                    }
                }
            }
            else
            {
                _traceAppMsg("", $"Ending Scripting. No scripts present");
                cbScriptEnable.Checked = false; // Unchecked the Enable box
            }
        }
        /// <summary> DataGridView determine if string exists to send response with delays as needed. </summary>
        // TODO : REVIEW HOW RXBUFFER IS SHARED BETWEEN FORMS.. PERHAPS USE SHARE DATA?
        public async Task ProcessAutoReplyAsync(string rxBuffer)
        {
#if DEBUG
            Trace.WriteLine($"{TraceClass} : {MethodBase.GetCurrentMethod().Name}");
#endif
            const int AutoReplyDelay = 100;
            _serialAutomateActive();
            if (!_getConnectState())
            {
                cbAutoReplyEnable.Checked = false;
                _traceAppMsg("", $"{_sharedData.SystemAppName}: Unable to Start Auto Reply, Not connected to any device.");
            }
            if (cbAutoReplyEnable.Checked)
            {
                foreach (DataGridViewRow row in dgvAutoReply.Rows)
                {
                    // Access data in each cell
                    row.Cells[(int)DgvAutoReplyColumns.Rx].Value = _myDgv.VerifyReplaceHexStringInCell(row.Cells[(int)DgvAutoReplyColumns.Rx], "");
                    row.Cells[(int)DgvAutoReplyColumns.Tx].Value = _myDgv.VerifyReplaceHexStringInCell(row.Cells[(int)DgvAutoReplyColumns.Tx], "");
                    var rxdata = row.Cells[(int)DgvAutoReplyColumns.Rx].Value?.ToString(); // Rx data column
                    var txdata = row.Cells[(int)DgvAutoReplyColumns.Tx].Value?.ToString(); // Tx data column

                    // Confirm Rx/Tx fields are not empty is not null before using them
                    if (!string.IsNullOrEmpty(rxdata) && !string.IsNullOrEmpty(txdata))
                    {
                        // Compare only non-null data
                        if (rxdata == rxBuffer)
                        {
                            row.Cells[(int)DgvAutoReplyColumns.Delay].Value = _myDgv.VerifyReplaceIntInCell(row.Cells[(int)DgvAutoReplyColumns.Delay], AutoReplyDelay);
                            var delay = _myDgv.VerifyReplaceIntInCell(row.Cells[(int)DgvAutoReplyColumns.Delay], AutoReplyDelay);
                            await Task.Delay(delay * 1);
                            if (cbAutoReplyEnable.Checked) // Incase delay is set high, we can abort
                            {
                                _traceAppMsg("", $"Sending Auto Reply for '{txdata}'");
                                _txData(txdata);
                            }
                        }
                    }
                }
            }
        }
        #endregion // Local Methods

        #region Event Handlers > Form Change
        private void FormSerialAutomate_FormClosing(object sender, FormClosingEventArgs e)
        {
            cbScriptEnable.Checked = false;
            cbAutoReplyEnable.Checked = false;
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true; // Cancel the form closing
                Hide(); // Hide the form instead
            }
        }
        private void CbScriptEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (cbScriptEnable.Checked)
            {
                _serialAutomateActive();
                _ = ProcessScriptingAsync();
            }
        }
        private void CbAutoReplyEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAutoReplyEnable.Checked)
            {
                _serialAutomateActive();
                _traceAppMsg("", $"Auto Reply Scripting Enabled");
            }
            else
            {
                _traceAppMsg("", $"Auto Reply Scripting Disabled");
            }
        }
        #endregion // Event Handlers > Form Change

        #region Events Handlers > Tool Strip Menu Item 
        private void TsBtnScriptOpenFile_Click(object sender, EventArgs e)
        {
            _myDgv.OpenTxtFileToDgvDialog(dgvScripting);
        }
        private void TsBtnScriptSaveFile_Click(object sender, EventArgs e)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = saveFileDialog.FileName;
                    _myDgv.SaveDgvToTxtFile(dgvScripting, filePath);
                }
            }
        }
        private void TsBtnAutoReplyOpenFile_Click(object sender, EventArgs e)
        {
            _myDgv.OpenTxtFileToDgvDialog(dgvAutoReply);
        }
        private void TsBtnAutoReplySaveFile_Click(object sender, EventArgs e)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = saveFileDialog.FileName;
                    _myDgv.SaveDgvToTxtFile(dgvAutoReply, filePath);
                }
            }
        }
        #endregion // Events Handlers > Tool Strip Menu Item 
    }
}
