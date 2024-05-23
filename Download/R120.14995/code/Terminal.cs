#region Credits
/* 
 * Hex logging utility with automated scripting.</p>
 * by N Diep
*/
#endregion

#region Namespace Inclusions
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogTerminal.Properties;
// User Added Namespace
using MyUtilities;
using SerialInterface;
using TextBox = System.Windows.Forms.TextBox;
#endregion

namespace LogTerminal
{


    public partial class FrmTerminal : Form
    {
        #region Delegates
        #endregion // Delegates

        #region Local Variables
        public static string TraceClass;
        public const string TraceAppName = "SerialPortApp";
        #endregion // Local Variables

        #region Classes
        // Create an instance of classes
        public SerialConnect _serialConnect;
        public MySharedData _sharedData;
        readonly MyVar _myVar = new MyVar();
        readonly MyUi _myUi = new MyUi();
        readonly MyForms _myForms = new MyForms();

        // Keep track of child window instance
        private FormSerialLogWindow _serialLogWindowInstance; 
        private FormSerialSettings _serialSettingsInstance;
        public FormSerialAutomate _serialAutomateInstance;
        public FormSerialTestChallenge _serialTestChallengeInstance;
        private FormSerialUtilities _serialUtilitiesInstance;
        private FormSerialInfo _serialInfoInstance;
        public TVRemote _tvRemoteForm;
        private AboutBox _aboutBoxForm;
        #endregion // Classes

        #region Constructor
        public FrmTerminal()
        {
            TraceClass = GetType().Name; // Assign the class name to the static variable
            // Build the form
            InitializeComponent();

            // Initialize the shared data object or delegates for Child form
            _sharedData = new MySharedData
            {
                SystemAppName = TraceAppName
            };

            _serialConnect = new SerialConnect
            {
                CurrentDataMode = DataMode.Hex
            };

            InitializeChildForms();
            _serialSettingsInstance.Show(); // Show this as default screen

            // Restore the users settings
            InitializeCOMPortValues();
            _serialConnect.NewRxData += RxData;

            // Initialize Key Press Events
            KeyPreview = true;
            KeyDown += MainForm_KeyDown;

            // Enable/disable controls based on the current state
            EnableControls();
            // If Release build, hide Debug UI.
            InitializeReleaseUI();
        }
        #endregion // Constructor

        #region Local Properties
        #endregion // Local Properties

        #region Local Methods

        /// <summary> Hide all Debug UI</summary>
        private void InitializeReleaseUI()
        {
#if !DEBUG
            tsbtnRSLKRobot.Visible = false;
            TsbtnClearConsole.Visible = false;
            BtnSideCapture.Visible = false;
            BtnTestHide.Visible = false;
#endif
        }

        public void InitializeChildForms()
        {
            // SERIAL SETTINGS
            if (_serialSettingsInstance == null || _serialSettingsInstance.IsDisposed)
                _serialSettingsInstance = new FormSerialSettings(this, Connect, Disconnect, InitializeCOMPortValues, _serialConnect.SetRTS, _serialConnect.GetRTS, _serialConnect.GetCTS);
            _myForms.InitializeSingleInstanceForm(this, _serialSettingsInstance);

            // LOG WINDOW
            if (_serialLogWindowInstance == null || _serialLogWindowInstance.IsDisposed)
                _serialLogWindowInstance = new FormSerialLogWindow(this, _sharedData, SetDataMode, TxData);
            _myForms.InitializeSingleInstanceForm(this, _serialLogWindowInstance); 

            // AUTOMATION / SCRIPTING
            if (_serialAutomateInstance == null || _serialAutomateInstance.IsDisposed)
                _serialAutomateInstance = new FormSerialAutomate(this, _sharedData, ConnectState, SerialAutomateActive, TraceAppMsg, TxData);
            _myForms.InitializeSingleInstanceForm(this, _serialAutomateInstance); 

            // CHALLENGE TEST
            if (_serialTestChallengeInstance == null || _serialTestChallengeInstance.IsDisposed)
                _serialTestChallengeInstance = new FormSerialTestChallenge(this, _sharedData, ConnectState, SerialTestActive, TraceAppMsg, TxData);
            _myForms.InitializeSingleInstanceForm(this, _serialTestChallengeInstance); 

            // INFO
            if (_serialInfoInstance == null || _serialInfoInstance.IsDisposed)
                _serialInfoInstance = new FormSerialInfo(this);
            _myForms.InitializeSingleInstanceForm(this, _serialInfoInstance); 

            // UTILITIES
            if (_serialUtilitiesInstance == null || _serialUtilitiesInstance.IsDisposed)
                _serialUtilitiesInstance = new FormSerialUtilities(this);
            _myForms.InitializeSingleInstanceForm(this, _serialUtilitiesInstance); 
            
            
            // TV REMOTE
            if (_tvRemoteForm == null || _tvRemoteForm.IsDisposed)
                _tvRemoteForm = new TVRemote(this);
            _myForms.InitializeSingleInstanceForm(this, _tvRemoteForm); 

            // ABOUT THIS APP
            _myForms.InitializeSingleInstanceForm(this, _aboutBoxForm); 
        }

        /// <summary> Enable/Disable controls based on the app's serial port state. </summary>
        public void EnableControls()
        {
            _myUi.InvokeIfRequired(_tvRemoteForm, () => { _tvRemoteForm.FormEnable = _serialConnect.IsOpen;});

            tsbtnConnect.Checked = _serialConnect.IsOpen;
            tsbtnDisconnect.Checked = !_serialConnect.IsOpen;

            _myUi.InvokeIfRequired(_serialSettingsInstance, () => { _serialSettingsInstance.FormEnable = _serialConnect.IsOpen; });
            _myUi.InvokeIfRequired(_serialAutomateInstance, () => { _serialAutomateInstance.FormEnable = _serialConnect.IsOpen; });
            _myUi.InvokeIfRequired(_serialTestChallengeInstance, () => { _serialTestChallengeInstance.FormEnable = _serialConnect.IsOpen; });
            _myUi.InvokeIfRequired(_serialLogWindowInstance, () => { _serialLogWindowInstance.FormEnable = _serialConnect.IsOpen; });
        }

        public void DisableControls()
        {
            _myUi.InvokeIfRequired(_tvRemoteForm, () => { _tvRemoteForm.FormEnable = false; });

            _myUi.InvokeIfRequired(_serialSettingsInstance, () => { _serialSettingsInstance.FormEnable = false; });
            _myUi.InvokeIfRequired(_serialAutomateInstance, () => { _serialAutomateInstance.FormEnable = false; });
            _myUi.InvokeIfRequired(_serialTestChallengeInstance, () => { _serialTestChallengeInstance.FormEnable = false; });
            _myUi.InvokeIfRequired(_serialLogWindowInstance, () => { _serialLogWindowInstance.FormEnable = false; });
        }

        public void SerialAutomateActive()
        {
            _myUi.InvokeIfRequired(_serialTestChallengeInstance, () => { _serialTestChallengeInstance.ChallengeEnableCheckbox.Checked = false; });
        }

        public void SerialTestActive()
        {
            _myUi.InvokeIfRequired(_serialAutomateInstance, () => { _serialAutomateInstance.ScriptEnableCheckbox.Checked = false; });
            _myUi.InvokeIfRequired(_serialAutomateInstance, () => { _serialAutomateInstance.AutoReplyEnableCheckbox.Checked = false; });
        }

        /// <summary> Save the user's settings. </summary>
        public void SaveCOMSettings()
        {
            if (_myVar.StringtoInt(_serialSettingsInstance.ExtCmbBaudRate.Text) != -1 ||
                    _myVar.StringtoInt(_serialSettingsInstance.ExtCmbDataBits.Text) != -1 ||
                    _serialSettingsInstance.ExtCmbParity.Text != "" ||
                    _serialSettingsInstance.ExtCmbStopBits.Text != "" ||
                     _serialSettingsInstance.ExtCmbPortName.Text != ""
                    )
            {
                Settings.Default.BaudRate = int.Parse(_serialSettingsInstance.ExtCmbBaudRate.Text);
                Settings.Default.DataBits = int.Parse(_serialSettingsInstance.ExtCmbDataBits.Text);
                Settings.Default.Parity = (Parity)Enum.Parse(typeof(Parity), _serialSettingsInstance.ExtCmbParity.Text);
                Settings.Default.StopBits = (StopBits)Enum.Parse(typeof(StopBits), _serialSettingsInstance.ExtCmbStopBits.Text);
                Settings.Default.PortName = _serialSettingsInstance.ExtCmbPortName.Text;
                Settings.Default.Save();
            }
        }

        /// <summary> Populate the form's COM Ports with default settings. </summary>
        public void InitializeCOMPortValues()
        {
            // Populate COM Name, Parity and Stop Bits
            _myUi.InvokeIfRequired(_serialSettingsInstance, () =>
            {
                _serialSettingsInstance.ExtCmbPortName.Items.Clear();
                foreach (string s in SerialPort.GetPortNames())
                {
                    _serialSettingsInstance.ExtCmbPortName.Items.Add(s);
                }
                _serialSettingsInstance.ExtCmbParity.Items.Clear();
                _serialSettingsInstance.ExtCmbParity.Items.AddRange(Enum.GetNames(typeof(Parity)));
                _serialSettingsInstance.ExtCmbStopBits.Items.Clear();
                _serialSettingsInstance.ExtCmbStopBits.Items.AddRange(Enum.GetNames(typeof(StopBits)));

                if (_serialSettingsInstance.ExtCmbPortName.Items.Contains(Settings.Default.PortName))
                {
                    _serialSettingsInstance.ExtCmbPortName.SelectedItem = Settings.Default.PortName;
                    try
                    {
                        _serialSettingsInstance.ExtCmbBaudRate.SelectedItem = Settings.Default.BaudRate.ToString();
                        _serialSettingsInstance.ExtCmbParity.SelectedItem = Settings.Default.Parity.ToString();
                        _serialSettingsInstance.ExtCmbDataBits.SelectedItem = Settings.Default.DataBits.ToString();
                        _serialSettingsInstance.ExtCmbStopBits.SelectedItem = Settings.Default.StopBits.ToString();
                    }
                    catch (Exception ex)
                    {
                        Trace.WriteLine($"Unable to load COM Port Default Settings : {ex}");
                    }
                }
                else if (_serialSettingsInstance.ExtCmbPortName.Items.Count > 0)
                {
                    _serialSettingsInstance.ExtCmbPortName.SelectedItem = null;
                    _serialSettingsInstance.ExtCmbBaudRate.SelectedItem = null;
                    _serialSettingsInstance.ExtCmbParity.SelectedItem = null;
                    _serialSettingsInstance.ExtCmbDataBits.SelectedItem = null;
                    _serialSettingsInstance.ExtCmbStopBits.SelectedItem = null;
                }
                else
                {
                    MessageBox.Show(this, "There are no COM Ports detected on this computer.\nPlease install a COM Port and restart this app.", "No COM Ports Installed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            });
        }

        public void Connect()
        {
            _serialConnect.COMConnect(  _serialSettingsInstance.ExtCmbBaudRate.Text,
                                        _serialSettingsInstance.ExtCmbDataBits.Text,
                                        _serialSettingsInstance.ExtCmbParity.Text,
                                        _serialSettingsInstance.ExtCmbStopBits.Text,
                                        _serialSettingsInstance.ExtCmbPortName.Text);
            _serialConnect.CurrentDataMode = DataMode.Hex;

            tsslConnectionStatus.Text = $"Connected : {_serialSettingsInstance.ExtCmbPortName.Text}";
            // Change the state of the form's controls
            EnableControls();
        }

        public bool ConnectState()
        {
            return _serialConnect.IsOpen;
        }

        public void Disconnect()
        {
            DisableControls();
            _serialConnect.COMDisconnect();
            tsslConnectionStatus.Text = $"Disconnected";
            tsbtnConnect.Checked = _serialConnect.IsOpen;
            tsbtnDisconnect.Checked = !_serialConnect.IsOpen;
        }

        public void SetDataMode (DataMode mode)
        {
            _serialConnect.CurrentDataMode = mode;
        }

        /// <summary> Send data</summary>
        public void TxData(string strdata)
        {
            Trace.WriteLine($"Sending data: {strdata}");
            if (!_serialConnect.TxData(strdata))
            {
                LogTx(LogMsgType.Error,
                strdata,
                $"{TraceAppName}: Error Transmit Aborted : PortStatus='{_serialConnect.IsOpen}' Mode='{_serialConnect.CurrentDataMode}' Data='{strdata}'");
            }
            else
            {
                LogTx(LogMsgType.Outgoing,
                strdata,
                $"{TraceAppName}: DataMode='{_serialConnect.CurrentDataMode}'");
                Trace.WriteLine($"{TraceClass} : {MethodBase.GetCurrentMethod().Name} : {strdata}");
            }
        }

        public void RxData(object sender, SerialDataEventArgs e)
        {
            var dataString = Encoding.ASCII.GetString(e._data);
            var dataBytes = e._data;

            // Determain which mode (string or binary) the user is in
            if (_serialConnect.CurrentDataMode == DataMode.Text || _serialLogWindowInstance.AsciiCheckbox.Checked)
            {
                LogRx(LogMsgType.Incoming, dataString, $"{TraceAppName} : DataMode='Text'");
            }
            else
            {
                if (_serialTestChallengeInstance.ChallengeEnableCheckbox.Checked)
                {
                    var oldSerialData = _sharedData.RxBuffer;
                    _sharedData.RxBuffer = oldSerialData + " " + _myVar.ByteArrayToHexString(dataBytes);
                    _sharedData.RxBuffer = _sharedData.RxBuffer.Trim();
                }

                LogRx(LogMsgType.Incoming, _myVar.ByteArrayToHexString(dataBytes), $"{TraceAppName} : DataMode='Hex'");
                Trace.WriteLine($"{TraceClass} : {MethodBase.GetCurrentMethod().Name} : {_myVar.ByteArrayToHexString(dataBytes)}");

                // This access child form UI
                if (_serialAutomateInstance.AutoReplyEnableCheckbox.Checked)
                {
                    _ = _serialAutomateInstance.ProcessAutoReplyAsync(_myVar.ByteArrayToHexString(dataBytes));
                }

                // Check if the form is null or has been closed
                if (_tvRemoteForm != null && !_tvRemoteForm.IsDisposed)
                {
                    _tvRemoteForm.SendTVRemoteAck(_myVar.ByteArrayToHexString(dataBytes));
                }
            }

        }

        /// <summary> Log Tx data to the terminal window. </summary>
        /// <param name="msgtype"> The type of message to be written. </param>
        /// <param name="data"> The string containing the data to be shown. </param>
        /// <param name="msg"> The string containing the message to be shown. </param>
        /// 
        public void LogTx(LogMsgType msgtype, string data, string msg)
        {
            _myUi.InvokeIfRequired(_serialLogWindowInstance, () => _serialLogWindowInstance.LogTx(msgtype, data, msg));
        }

        /// <summary> Log Rx data to the terminal window. </summary>
        /// <param name="msgtype"> The type of message to be written. </param>
        /// <param name="data"> The string containing the data to be shown. </param>
        /// <param name="msg"> The string containing the message to be shown. </param>
        public void LogRx(LogMsgType msgtype, string data, string msg)
        {
            _myUi.InvokeIfRequired(_serialLogWindowInstance, () => _serialLogWindowInstance.LogRx(msgtype, data, msg));
        }

        /// <summary> Log system message to the terminal window. </summary>
        /// <param name="msgtype"> The type of message to be written. </param>
        /// <param name="data"> The string containing the data to be shown. </param>
        /// <param name="msg"> The string containing the message to be shown. </param>
        public void LogMsg(LogMsgType msgtype, string data, string msg)
        {
            _myUi.InvokeIfRequired(_serialLogWindowInstance, () => _serialLogWindowInstance.LogMsg(msgtype, data, msg));
        }

        /// <summary> Wrapper to forward log messages
        /// </summary>
        public void TraceAppMsg(string data, string msg)
        {
            _myUi.InvokeIfRequired(_serialLogWindowInstance, () => _serialLogWindowInstance.LogMsg(LogMsgType.MsgFromApp, data, string.Format($"{msg}")));
#if DEBUG
            Trace.WriteLine($"{TraceClass} : {data} : {msg}");
#endif
        }

        /// <summary> Open Window Tv Remote</summary>
        private void OpenWindowTVRemote()
        {
            if (_tvRemoteForm == null || _tvRemoteForm.IsDisposed)
            {
                _tvRemoteForm = new TVRemote(this);
            }
            _myForms.OpenSingleInstanceForm(this, _tvRemoteForm); // Use the modified method
        }

        /// <summary> Open Window About Box</summary>
        private void OpenWindowAboutBox()
        {
            // Check if the form is null or has been closed
            if (_aboutBoxForm == null || _aboutBoxForm.IsDisposed)
            {
                _aboutBoxForm = new AboutBox
                {
                    TopMost = true // Set the form to always be on top
                };
                _aboutBoxForm.Show();
            }
            else
            {
                // If the form is already open, bring it to the front
                _aboutBoxForm.BringToFront();
            }
        }

#endregion

        #region Event Handlers

        #region Event Handlers > Main Form
        private void FrmTerminal_Load(object sender, EventArgs e)
        {
        }

        private void FrmTerminal_Shown(object sender, EventArgs e)
        {
            _serialConnect.CurrentDataMode = DataMode.Hex;
        }

        private void FrmTerminal_FormClosing(object sender, FormClosingEventArgs e)
        {
            // The form is closing, save the user's preferences
            SaveCOMSettings();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.Enter) // Check if Alt+Enter key combination is pressed
            {
                Trace.WriteLine($"\n"); // Used for debugging. Put a space in Trace messages
            }
        }

        #endregion // Event Handlers > Main Form

        #region Events Handlers > Tool Strip Menu Item 
        private void TsmiFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TsmiAbout_Click(object sender, EventArgs e)
        {
            OpenWindowAboutBox();
        }

        #endregion // Events Handlers > Tool Strip Menu Item 

        #region Event Handlers > Tool Strip Button Click
        private void TsbtnTVControls_Click(object sender, EventArgs e)
        {
#if DEBUG
            Trace.WriteLine($"{TraceClass} : {MethodBase.GetCurrentMethod().Name}");
#endif
            OpenWindowTVRemote();
        }

        private void TsbtnConnect_Click(object sender, EventArgs e)
        {
#if DEBUG
            Trace.WriteLine($"{TraceClass} : {MethodBase.GetCurrentMethod().Name}");
#endif
            Connect();
        }

        private void TsbtnDisconnect_Click(object sender, EventArgs e)
        {
#if DEBUG
            Trace.WriteLine($"{TraceClass} : {MethodBase.GetCurrentMethod().Name}");
#endif
            Disconnect();
        }

        /// <summary> Add space for Console / Trace Writeline</summary>
        private void TsbtnClearConsole_Click(object sender, EventArgs e)
        {
            Trace.WriteLine($"\n\n"); // Used for debugging, add space in console for readability.
        }

        #endregion // Event Handlers > Tool Strip Button Click

        #region Event Handlers > Form Change
        private void TimerScript_Tick(object sender, EventArgs e)
        {
        }
        #endregion // Event Handlers > Form Change

        #region Events Handlers > Form Button Click
        private void BtnUtilTraceAddSpace_Click(object sender, EventArgs e)
        {
            Trace.WriteLine($"\n\n"); // Used for debugging, add space in console for readability.
        }

        private void BtnLogWindow_Click(object sender, EventArgs e)
        {
            if (_serialLogWindowInstance == null || _serialLogWindowInstance.IsDisposed)
            {
                _serialLogWindowInstance = new FormSerialLogWindow(this, _sharedData, SetDataMode, TxData);
            }
            _myForms.OpenSingleInstanceForm(this, _serialLogWindowInstance); // Use the modified method
        }

        private void BtnSideSettings_Click(object sender, EventArgs e)
        {
            if (_serialSettingsInstance == null || _serialSettingsInstance.IsDisposed)
            {
                _serialSettingsInstance = new FormSerialSettings(this, Connect, Disconnect, InitializeCOMPortValues, _serialConnect.SetRTS, _serialConnect.GetRTS, _serialConnect.GetCTS);
            }
            _myForms.OpenSingleInstanceForm(this, _serialSettingsInstance); // Use the modified method
            
        }

        private void BtnSideAutomate_Click(object sender, EventArgs e)
        {
            if (_serialAutomateInstance == null || _serialAutomateInstance.IsDisposed)
            {
                _serialAutomateInstance = new FormSerialAutomate(this, _sharedData, ConnectState, SerialAutomateActive, TraceAppMsg, TxData);
            }
            _myForms.OpenSingleInstanceForm(this, _serialAutomateInstance); // Use the modified method
        }

        private void BtnSideTesting_Click(object sender, EventArgs e)
        {
            if (_serialTestChallengeInstance == null || _serialTestChallengeInstance.IsDisposed)
            {
                _serialTestChallengeInstance = new FormSerialTestChallenge(this, _sharedData,ConnectState, SerialTestActive, TraceAppMsg, TxData);
            }
            _myForms.OpenSingleInstanceForm(this, _serialTestChallengeInstance); // Use the modified method
        }

        private void BtnSideUtilities_Click(object sender, EventArgs e)
        {
            if (_serialUtilitiesInstance == null || _serialUtilitiesInstance.IsDisposed)
            {
                _serialUtilitiesInstance = new FormSerialUtilities(this);
            }
            _myForms.OpenSingleInstanceForm(this, _serialUtilitiesInstance); // Use the modified method
        }

        private void BtnSideInfo_Click(object sender, EventArgs e)
        {
            if (_serialInfoInstance == null || _serialInfoInstance.IsDisposed)
            {
                _serialInfoInstance = new FormSerialInfo(this);
            }
            _myForms.OpenSingleInstanceForm(this, _serialInfoInstance); // Use the modified method
        }

        private void BtnTestHide_Click(object sender, EventArgs e)
        {
        }
        #endregion // Events Handlers > Form Button Click

        #endregion // Event Handlers
    }
}
