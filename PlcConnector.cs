namespace ConnectPLC
{
    // PLC連接管理類別，採用策略模式
    public class PlcConnector
    {
        private IConnectionStrategy _strategy;
        public PlcConnector(IConnectionStrategy strategy)
        {
            _strategy = strategy;
        }
        public void SetStrategy(IConnectionStrategy strategy)
        {
            _strategy = strategy;
        }
        public bool Connect(string ip, int port) => _strategy.Connect(ip, port);
        public void Disconnect() => _strategy.Disconnect();
        public bool SendData(byte[] data) => _strategy.SendData(data);
        public byte[] ReceiveData() => _strategy.ReceiveData();
        public bool IsConnected => _strategy.IsConnected;
        public object ReadStatus(string address, PlcDataType dataType) => _strategy.ReadStatus(address, dataType);
        public bool WriteValue(string address, object value, PlcDataType dataType) => _strategy.WriteValue(address, value, dataType);
    }
}
