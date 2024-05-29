#region Credits
/* 
 * Hex logging utility with automated scripting.</p>
 * Modified by N Diep
 * 
 * Based on SerialPort Terminal by http://coad.net Coad.NET
 * This is written as a demonstation of how to use the SerialPort control that is part of .NET 2.0.</p>
 * Written by http://coad.net/noah Noah Coad
 * 
*/
#endregion


#region Namespace Inclusions
using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyUtilities;
using static System.Windows.Forms.AxHost;
#endregion

namespace SerialInterface
{
    public class SerialConnect
    {
        #region Local Variables
        public static string TraceClass;
        #endregion

        #region Classes
        // The main control for communicating through the RS-232 port
        public SerialPort _comport = new SerialPort();
        readonly MyVar _myVar = new MyVar();
        #endregion // Classes

        #region Subscriptions
        public event EventHandler<SerialDataEventArgs> NewRxData;
        #endregion

        #region Constructor
        public SerialConnect()
        {
            TraceClass = GetType().Name; // Assign the class name to the static variable
        }
        #endregion

        #region Local Properties
        public DataMode _currentDataMode;
        public DataMode CurrentDataMode
        {
            get { return _currentDataMode; }
            set { _currentDataMode = value; }
        }
        public bool IsOpen { get { return _comport.IsOpen; } }
        public int BytesToRead { get { return _comport.BytesToRead; } }

        #endregion

        #region Local Methods

        public bool IsPortAvailable(string portName)
        {
            try
            {
                using (var port = new SerialPort(portName))
                {
                    port.Open();
                    port.Close();
                }
                return true; // If no exception, the port is available
            }
            catch (UnauthorizedAccessException)
            {
                // The port is in use by another process
                return false;
            }
            catch (IOException)
            {
                // The port is in an invalid state or doesn't exist
                return false;
            }
            catch (Exception)
            {
                // Some other error occurred
                return false;
            }
        }

        public void COMConnect(string baudRate, string dataBits, string parity, string stopBits, string portName)
        {
            // If the port is open, close it.
            if (_comport.IsOpen)
            {
                _comport.Close();
            }

            try
            {
                // Set the port's settings
                _comport.BaudRate = int.Parse(baudRate);
                _comport.DataBits = int.Parse(dataBits);
                _comport.StopBits = (StopBits)Enum.Parse(typeof(StopBits), stopBits);
                _comport.Parity = (Parity)Enum.Parse(typeof(Parity), parity);
                _comport.PortName = portName;
                _comport.ReadTimeout = 0;

                // Open the port
                Trace.WriteLine($"{TraceClass} : {MethodBase.GetCurrentMethod().Name} : Serial Port Open : {portName}, {baudRate}, bits={dataBits}, par={parity}, stop={stopBits}");
#if DEBUG
        Trace.WriteLine($"{TraceClass} : {MethodBase.GetCurrentMethod().Name} : Readtimeout : {_comport.ReadTimeout}");
#endif
                _comport.Open();
                _comport.DataReceived += new SerialDataReceivedEventHandler(RxData); // handle rxdata
            }
            catch (UnauthorizedAccessException ex)
            {
                Trace.WriteLine($"{TraceClass} : {MethodBase.GetCurrentMethod().Name} : UnauthorizedAccessException : {ex.Message}");
                MessageBox.Show($"The port {portName} is already in use by another application.", "Port Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ex)
            {
                Trace.WriteLine($"{TraceClass} : {MethodBase.GetCurrentMethod().Name} : IOException : {ex.Message}");
                MessageBox.Show($"An I/O error occurred while trying to open the port {portName}.", "I/O Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                Trace.WriteLine($"{TraceClass} : {MethodBase.GetCurrentMethod().Name} : ArgumentException : {ex.Message}");
                MessageBox.Show($"The settings for the port {portName} are invalid.", "Invalid Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Trace.WriteLine($"{TraceClass} : {MethodBase.GetCurrentMethod().Name} : Exception : {ex.Message}");
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void COMDisconnect()
        {
            // If the port is open, close it.
            if (_comport != null)
            {
                if (_comport.IsOpen)
                {
                    _comport.DataReceived -= RxData;
                    try
                    {
                        _comport.Close();
                    }
                    catch (Exception ex)
                    {
                        // Log or handle the exception appropriately
                        Trace.WriteLine($"{TraceClass} : {MethodBase.GetCurrentMethod().Name} : Error closing serial port: {ex.Message}");
                    }
                }
                 _comport.Dispose();
            }
        }
        /// <summary> Send the user's data</summary>
        public bool TxData(string strdata)
        {
            if (!_comport.IsOpen)
            {
                Trace.WriteLine($"{TraceClass} : {MethodBase.GetCurrentMethod().Name} : Error: Com Port is closed");
                return false;
            }

            if (strdata == null)
            {
                Trace.WriteLine($"{TraceClass} : {MethodBase.GetCurrentMethod().Name} : Error: Input string is null");
                return false; // or throw an exception, log an error, etc.
            }
#if DEBUG
            Trace.WriteLine($"{TraceClass} : {MethodBase.GetCurrentMethod().Name} : DataMode='{CurrentDataMode}'");
#endif

            if (CurrentDataMode == DataMode.Text)
            {

                // Send the user's text straight out the port
                _comport.Write(strdata);
#if DEBUG
                // Convert string to byte array.
                var byteArray = Encoding.ASCII.GetBytes(strdata);
                // Convert each byte to its hexadecimal representation with space between each byte
                var hexString = BitConverter.ToString(byteArray).Replace("-", " ");

                Trace.WriteLine($"{TraceClass} : {MethodBase.GetCurrentMethod().Name} : '{strdata}' : {hexString}");
#endif
                return true;
            }
            else if ((CurrentDataMode == DataMode.Hex))
            {
                try
                {
                    // Convert the user's string of hex digits (ex: B4 CA E2) to a byte array
                    var data = _myVar.HexStringToByteArray(strdata);

                    // Send the binary data out the port
                    if ( data == null ) { return false; }

                    _comport.Write(data, 0, data.Length);
#if DEBUG
                    // Convert each byte to its hexadecimal representation with space between each byte
                    var hexString = BitConverter.ToString(data).Replace("-", " ");

                    Trace.WriteLine($"{TraceClass} : {MethodBase.GetCurrentMethod().Name} : {hexString}");
#endif
                    return true;
                }
                catch (FormatException)
                {
                    // Inform the user if the hex string was not properly formatted
                    Trace.WriteLine($"{TraceClass} : {MethodBase.GetCurrentMethod().Name} : Write Hex Format Error");
                    return false;
                }
            }
            else 
            {
                Trace.WriteLine($"{TraceClass} : {MethodBase.GetCurrentMethod().Name}  : DataMode Error : {CurrentDataMode}");
                return false;
            }
        }

        public int RxCounter = 0;

        private void ReadData()
        {
            if (_comport.IsOpen)
            {
                // Determain which mode (string or binary) the user is in
                if (CurrentDataMode == DataMode.Text)
                {
                    // Read all the data waiting in the buffer
                    var data = _comport.ReadExisting();
#if DEBUG
                    Trace.WriteLine($"{TraceClass} : {MethodBase.GetCurrentMethod().Name} : DataMode='{CurrentDataMode}' Data='{data}'");
#endif
                }
                else
                {
                    // DataMode.Hex Obtain the number of bytes waiting in the port's buffer
                    var bytes = _comport.BytesToRead;

                    // Create a byte array buffer to hold the incoming data
                    var buffer = new byte[bytes];

                    // Read the data from the port and store it in our buffer
                    _comport.Read(buffer, 0, bytes);

                    if (bytes > 0)
                    {
                        // Trim the buffer to the actual number of bytes read
                        Array.Resize(ref buffer, bytes);
#if DEBUG
                        Trace.WriteLine($"{TraceClass} : {MethodBase.GetCurrentMethod().Name} : DataMode={CurrentDataMode} : {_myVar.ByteArrayToHexString(buffer)}");
                        Trace.WriteLine($"{TraceClass} : {MethodBase.GetCurrentMethod().Name} : DataMode={CurrentDataMode} : Rx Counter={RxCounter}");
                        RxCounter++;
#endif

                        // Send data to whoever is interested
                        NewRxData?.Invoke(this, new SerialDataEventArgs(buffer));
                    }
                }
            }
        }

        public async Task RxDataAsync()
        {
            await Task.Run(() => ReadData());
        }

        public void RxData (object sender, SerialDataReceivedEventArgs e)
        {
            ReadData();
        }

        public bool GetCTS () 
        {
            bool status = false;
            if (_comport.IsOpen) status = _comport.CtsHolding;
            Trace.WriteLine($"{TraceClass} : {MethodBase.GetCurrentMethod().Name} : status={status}");
            return status;
        }

        public bool SetRTS (bool state)
        {
            bool status = false;
            if (_comport.IsOpen) 
            {
                _comport.RtsEnable = state;
                status = _comport.RtsEnable;
            }
            Trace.WriteLine($"{TraceClass} : {MethodBase.GetCurrentMethod().Name} : set={state} : status={status}");
            return status;
        }

        public bool GetRTS ()
        {
            bool status = false;
            if (_comport.IsOpen) status = _comport.RtsEnable;
            Trace.WriteLine($"{TraceClass} : {MethodBase.GetCurrentMethod().Name} : status={status}");
            return status;
        }
#endregion

        #region Event Handlers
        #endregion
    }

    /// <summary>
    /// EventArgs used to send bytes recieved on serial port
    /// </summary>
    public class SerialDataEventArgs : EventArgs
    {
        #region Constructor 
        public SerialDataEventArgs(byte[] buffer)
        {
            _data = buffer;
        }
        #endregion // Constructor

        #region Local Properties
        /// <summary>
        /// Byte array containing data from serial port
        /// </summary>
        public byte[] _data;
        #endregion
    }
}
