using System;
using System.Collections.Generic;
using System.Windows.Forms;
using InterfaceDriver;
using RadioButton = System.Windows.Forms.RadioButton;
using GroupBox = System.Windows.Forms.GroupBox;
using MyUtilities;
using SerialInterface;
using System.Diagnostics;
using System.IO.Ports;
using System.Reflection;

namespace LogTerminal
{
    #region Public Enumerations
    public enum RemoteMfg
    {
        sampleTVRem,
        Mfg_LG,
        Mfg_Samsung
    }
     #endregion


    public partial class TVRemote : Form
    {
        private static FrmTerminal s_parentForm;
        private Dictionary<RadioButton, RemoteMfg> _tvRadioButtons;

        #region Local Variables
        public const string TraceAppName = "SerialPortApp";
        public static string TraceClass;
        #endregion

        #region Constructor
        public TVRemote(FrmTerminal parent)
        {
            TraceClass = GetType().Name; // Assign the class name to the static variable
            InitializeComponent();
            InitializeTVRadioButtons();
            s_parentForm = parent;
        }

        public bool FormEnable // Expose the GroupBox
        {
            get { return gbTVController.Enabled; }
            set { gbTVController.Enabled = value; }
        }

        public RadioButton RadioEmulator 
        {
            get { return rbModeEmulator; }
        }

        #endregion

        #region Local Methods

        private void InitializeTVRadioButtons()
        {
            _tvRadioButtons = new Dictionary<RadioButton, RemoteMfg>
            {
                { rbMfgLG, RemoteMfg.Mfg_LG },
                { rbMfgSamsung, RemoteMfg.Mfg_Samsung }
                // Add more TV manufacturers if needed
            };
        }



        /// <summary>
        /// Send the TV remote command code based on the selected mfg radiobutton and command name.
        /// </summary>
        public void SendTVRemoteCommand(string commandName)
        {
            foreach (var radioButton in _tvRadioButtons.Keys)
            {
                if (radioButton.Checked)
                {
                    // Get the selected TV manufacturer
                    var selectedTV = _tvRadioButtons[radioButton];

                    var tvCmds = new SerialDriverTV("00", "FF");
                    // Send the corresponding TV command based on the selected command name along with meaningful Log Message
                    SendTVData(tvCmds.GetCmdCodeByName(selectedTV.ToString(), commandName) ,
                        "Controller Sending : " 
                        + selectedTV.ToString() 
                        + " " 
                        + tvCmds.GetCmdNameByCode(tvCmds.GetCmdCodeByName(selectedTV.ToString(), commandName)));
                    break; // Break out of the loop after finding the selected TV
                }
            }
        }
        /// <summary>
        /// Send the TV remote cmd ack based on the specified remote and command name.
        /// </summary>
        public void SendTVRemoteAck(string rxCmdCode)
        {
            if (rbModeEmulator.Checked)
            {
                var tvCmds = new SerialDriverTV("00", "FF");
                var ackdata = tvCmds.GetCmdAckByCode(rxCmdCode);
                if (ackdata != "") 
                {
                    // Process Incoming data, determine to respond with ACK and include meaningful Log Message.
                    SendTVData(ackdata, 
                        "Emulator Sending Ack : " 
                        + tvCmds.GetCmdMfgByCode(rxCmdCode) 
                        + " " 
                        + tvCmds.GetCmdNameByCode(rxCmdCode)); // Log a meaningful ACK Message
                }

            }
            
        }

        /// <summary> 
        /// Modified from Terminal SendData.
        /// Identifies command name based on code sent then display in log.
        /// </summary>
        private void SendTVData(string txtTVData, string datamessage)
        {
            s_parentForm._serialConnect.CurrentDataMode = DataMode.Hex;

            // Send the user's text straight out the port
            s_parentForm.TxData(txtTVData);

            // Show in the terminal window the user's text
#if DEBUG
            Trace.WriteLine($"{TraceClass} : {MethodBase.GetCurrentMethod().Name} : TxData : {txtTVData} : {datamessage}");
#endif
            s_parentForm.LogTx(LogMsgType.Outgoing, "", datamessage); // Only log the message the data will be log when transmitted.
        }
        private void BtnPwrOn_Click(object sender, EventArgs e)
        {
#if DEBUG
            Trace.WriteLine($"{TraceClass} : {MethodBase.GetCurrentMethod().Name}");
#endif
            SendTVRemoteCommand("PowerOn");
        }
        private void BtnPwrOff_Click(object sender, EventArgs e)
        {
#if DEBUG
            Trace.WriteLine($"{TraceClass} : {MethodBase.GetCurrentMethod().Name}");
#endif
            SendTVRemoteCommand( "PowerOff");
        }
        private void BtnVolUp_Click(object sender, EventArgs e)
        {
#if DEBUG
            Trace.WriteLine($"{TraceClass} : {MethodBase.GetCurrentMethod().Name}");
#endif
            SendTVRemoteCommand("VolUp");
        }
        private void BtnVolDn_Click(object sender, EventArgs e)
        {
#if DEBUG
            Trace.WriteLine($"{TraceClass} : {MethodBase.GetCurrentMethod().Name}");
#endif
            SendTVRemoteCommand("VolDown");
        }
        private void BtnMute_Click(object sender, EventArgs e)
        {
#if DEBUG
            Trace.WriteLine($"{TraceClass} : {MethodBase.GetCurrentMethod().Name}");
#endif
            SendTVRemoteCommand("VolMute");
        }
        private void BtnSelHDMI1_Click(object sender, EventArgs e)
        {
#if DEBUG
            Trace.WriteLine($"{TraceClass} : {MethodBase.GetCurrentMethod().Name}");
#endif
            SendTVRemoteCommand("SrcHDMI1");
        }
        private void BtnSelHDMI2_Click(object sender, EventArgs e)
        {
#if DEBUG
            Trace.WriteLine($"{TraceClass} : {MethodBase.GetCurrentMethod().Name}");
#endif
            SendTVRemoteCommand("SrcHDMI2");
        }
        private void BtnSelHDMI3_Click(object sender, EventArgs e)
        {
#if DEBUG
            Trace.WriteLine($"{TraceClass} : {MethodBase.GetCurrentMethod().Name}");
#endif
            SendTVRemoteCommand("SrcHDMI3");
        }
        private void BtnSelAnalog_Click(object sender, EventArgs e)
        {
#if DEBUG
            Trace.WriteLine($"{TraceClass} : {MethodBase.GetCurrentMethod().Name}");
#endif
            SendTVRemoteCommand("SrcAnalog");
        }
#endregion

        #region Event Handlers > Form Change
        private void TVRemote_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Handle the Close button click here
                e.Cancel = true; // Cancel the form closing
                Hide(); // Hide the form instead
            }
        }
        #endregion // Event Handlers > Form Change
    }
}
