using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyUtilities;
using SerialInterface;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LogTerminal
{
    public partial class FormSerialSettings : Form
    {
        #region Delegates
        private readonly MyDelegates.ConnectDelegate _connect;
        private readonly MyDelegates.DisconnectDelegate _disconnect;
        private readonly MyDelegates.Init_COMPortDelegate _iniCOMPortNames;
        private readonly MyDelegates.SetRTSDelegate _setRTS;
        private readonly MyDelegates.GetRTSDelegate _getRTS;
        private readonly MyDelegates.GetCTSDelegate _getCTS;
        #endregion

        #region Local Variables
        public static string TraceClass;
        private int _previousBaudRate; // Field to store the previous valid baud rate
        private int _previousDataBits; // Field to store the previous valid databits
        #endregion

        #region Classes
        // Create an instance of classes
#pragma warning disable
        private static FrmTerminal s_parentForm;
#pragma warning restore

        #endregion // Classes

        #region Constructor

        public FormSerialSettings(FrmTerminal parent,
                    MyDelegates.ConnectDelegate connect,
                    MyDelegates.DisconnectDelegate disconnect,
                    MyDelegates.Init_COMPortDelegate iniCOMPortNames,
                    MyDelegates.SetRTSDelegate setRTS,
                    MyDelegates.GetRTSDelegate getRTS,
                    MyDelegates.GetCTSDelegate getCTS
            )
        {
            TraceClass = GetType().Name; // Assign the class name to the static variable
            s_parentForm = parent;
            _connect = connect;
            _disconnect = disconnect;
            _iniCOMPortNames = iniCOMPortNames;
            _setRTS = setRTS;
            _getRTS = getRTS;
            _getCTS = getCTS;
            InitializeComponent();

            this.FormClosing += Form_FormClosing;
        }

        #endregion // Constructor

        #region Local Properties
        public bool FormEnable
        {
            get { return gbPortSettings.Enabled; }
            set 
            { 
                gbPortSettings.Enabled = !value;
                BtnConnect.Enabled = !value;
                BtnRefresh.Enabled = !value;

                gbUtilSerialPort.Enabled = value;
                BtnDisconnect.Enabled = value;
            }
        }
        public System.Windows.Forms.ComboBox ExtCmbPortName
        {
            get { return cmbPortName; }
            set { cmbPortName = value; }
        }
        public System.Windows.Forms.ComboBox ExtCmbBaudRate
        {
            get { return cmbBaudRate; }
            set { cmbBaudRate = value; }
        }
        public System.Windows.Forms.ComboBox ExtCmbParity
        {
            get { return cmbParity; }
            set { cmbParity = value; }
        }
        public System.Windows.Forms.ComboBox ExtCmbDataBits
        {
            get { return cmbDataBits; }
            set { cmbDataBits = value; }
        }
        public System.Windows.Forms.ComboBox ExtCmbStopBits
        {
            get { return cmbStopBits; }
            set { cmbStopBits = value; }
        }
        #endregion // Local Properties

        #region Event Handlers > Form Change
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true; // Cancel the form closing
                Hide(); // Hide the form instead
            }
        }

        private void CmbBaudRate_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(cmbBaudRate.Text, out var baudRate))
            {
                cmbBaudRate.Text = _previousBaudRate.ToString();
                e.Cancel = true;
            }
            else
            {
                _previousBaudRate = baudRate;
            }
        }
        private void CmbBaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            int.TryParse(cmbBaudRate.Text, out _previousBaudRate);
        }
        private void CmbDataBits_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(cmbDataBits.Text, out var dataBits))
            {
                cmbDataBits.Text = _previousDataBits.ToString();
                e.Cancel = true;
            }
            else
            {
                _previousDataBits = dataBits;
            }
        }
        private void CmbDataBits_SelectedIndexChanged(object sender, EventArgs e)
        {
            int.TryParse(cmbDataBits.Text, out _previousDataBits);
        }
        #endregion

        #region Events Handlers > Form Button Click
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            _connect();
        }
        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            _disconnect();
        }
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            _iniCOMPortNames();
        }
        private void BtnUtilSerialSetRTS_Click(object sender, EventArgs e)
        {
           _setRTS(cbUtilSerialSetRTS.Checked);
        }
        private void BtnUtilSerialGetRTS_Click(object sender, EventArgs e)
        {
            cbUtilSerialSetRTS.Checked = _getRTS();
        }
        private void BtnUtilSerialGetCTS_Click(object sender, EventArgs e)
        {
            cbUtilSerialGetCTS.Checked = _getCTS();
        }
        #endregion // Events Handlers > Form Button Click
    }
}
