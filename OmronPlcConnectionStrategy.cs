using System;
using System.Net.Sockets;
using ConnectPLC;

namespace ConnectPLC
{
    // Omron PLC連接策略
    public class OmronPlcConnectionStrategy : IConnectionStrategy
    {
        public bool IsConnected { get; private set; }
        private TcpClient _client;
        private NetworkStream _stream;

        public bool Connect(string ip, int port)
        {
            // Omron PLC連線邏輯（以TCP為例）
            try
            {
                _client = new TcpClient();
                _client.Connect(ip, port);
                _stream = _client.GetStream();
                IsConnected = true;
            }
            catch
            {
                IsConnected = false;
            }
            return IsConnected;
        }
        public void Disconnect()
        {
            // Omron PLC斷線邏輯
            if (_stream != null)
                _stream.Close();
            if (_client != null)
                _client.Close();
            IsConnected = false;
        }
        public bool SendData(byte[] data)
        {
            // Omron PLC傳送資料邏輯
            if (!IsConnected || _stream == null) return false;
            try
            {
                _stream.Write(data, 0, data.Length);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public byte[] ReceiveData()
        {
            // Omron PLC接收資料邏輯
            if (!IsConnected || _stream == null) return new byte[0];
            try
            {
                byte[] buffer = new byte[256];
                int bytesRead = _stream.Read(buffer, 0, buffer.Length);
                byte[] result = new byte[bytesRead];
                Array.Copy(buffer, result, bytesRead);
                return result;
            }
            catch
            {
                return new byte[0];
            }
        }
        public object ReadStatus(string address, PlcDataType dataType)
        {
            byte[] command = PlcCommandBuilder.BuildReadCommand(address, dataType);
            if (!SendData(command))
                throw new Exception("PLC資料傳送失敗");
            byte[] response = ReceiveData();
            return PlcCommandBuilder.ParseReadResponse(response, dataType);
        }
        public bool WriteValue(string address, object value, PlcDataType dataType)
        {
            byte[] command = PlcCommandBuilder.BuildWriteCommand(address, value, dataType);
            if (!SendData(command))
                return false;
            byte[] response = ReceiveData();
            return PlcCommandBuilder.ParseWriteResponse(response);
        }
    }
}
