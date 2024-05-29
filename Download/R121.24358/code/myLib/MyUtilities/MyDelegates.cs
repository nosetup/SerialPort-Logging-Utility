// CLASS TO BRIDGE DIFFERENT FORMS TOGETHER
// NELSON D.

namespace MyUtilities
{
    
    public static class MyDelegates
    {
        
        #region Serial Port Utilities Delegates
        public delegate void ConnectDelegate(); // Connect to Device
        public delegate bool GetConnectStateDelegate(); // Get Connection State
        public delegate void DisconnectDelegate(); // Disconnect Device
        public delegate void Init_COMPortDelegate(); // Initialize COM Port Names
        public delegate bool SetRTSDelegate(bool state); // Set RTS
        public delegate bool GetRTSDelegate(); // Get RTS
        public delegate bool GetCTSDelegate(); // Get CTS

        public delegate void AutomateActiveDelegate(); // Automate State
        public delegate void TestActiveDelegate(); // Test State
        public delegate void FormBusyDelegate(); // Announce Form Active State
        public delegate void TraceAppMsgDelegate(string data, string msg); // Log Data
        public delegate void SetDataModeDelegate(DataMode mode); // Set Data Encoding Mode for Serial Port
        public delegate void TxDataDelegate(string strdata); // Transmit data
        #endregion

        #region Ethernet Utilities Delegates
        public delegate void HostInfo(string ipaddress, string hostname);
        public delegate void ConnectUDPDelegate(string portnumber); // Port Number
        public delegate void TraceTCPMsgDelegate(LogMsgType msgtype, string src, string dest, string msg); // Log Data
        public delegate void TxUDPDataDelegate(string destIP, int destPort, string msg); // Transmit data
        #endregion
    }
}
