using System;

namespace MyUtilities
{
    public class MySharedData
    {
        public MySharedData()
        {
        }
        private string _SystemAppName;
        public string SystemAppName
        {
            get { return _SystemAppName; }
            set { _SystemAppName = value; }
        }

        private string _SourceIP;
        public string SourceIP
        {
            get { return _SourceIP; }
            set { _SourceIP = value; }
        }

        private string _SourcePort;
        public string SourcePort
        {
            get { return _SourcePort; }
            set { _SourcePort = value; }
        }

        private string _RxBuffer;
        public string RxBuffer
        {
            get { return _RxBuffer; }
            set { _RxBuffer = value; }
        }

        private string _TxBuffer;
        public string TxBuffer
        {
            get { return _TxBuffer; }
            set { _TxBuffer = value; }
        }

        private byte[] _ByteBuffer;
        public byte[] ByteBuffer
        {
            get { return _ByteBuffer; }
            set { _ByteBuffer = value; }
        }

        private byte[] _RxByteBuffer;
        public byte[] RxByteBuffer
        {
            get { return _RxByteBuffer; }
            set { _RxByteBuffer = value; }
        }

        private byte[] _TxByteBuffer;
        public byte[] TxByteBuffer
        {
            get { return _TxByteBuffer; }
            set { _TxByteBuffer = value; }
        }

    }

}

