namespace ConnectPLC
{
    // PLC連接策略介面
    public interface IConnectionStrategy
    {
        bool Connect(string ip, int port);
        void Disconnect();
        bool SendData(byte[] data);
        byte[] ReceiveData();
        bool IsConnected { get; }

        // 讀取狀態
        object ReadStatus(string address, PlcDataType dataType);
        // 寫入各種類型
        bool WriteValue(string address, object value, PlcDataType dataType);
    }

    // PLC資料型態列舉
    public enum PlcDataType
    {
        Bit,
        Word,
        DWord,
        Float,
        Double,
        String
    }
}
