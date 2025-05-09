using System;

namespace ConnectPLC
{
    // PLC 指令組裝與解析工具類別
    public static class PlcCommandBuilder
    {
        // 組裝讀取指令
        public static byte[] BuildReadCommand(string address, PlcDataType dataType)
        {
            // TODO: 根據PLC協議組裝讀取指令
            // 這裡僅示意，實際需依PLC協議格式實作
            return new byte[] { 0x01, 0x02 }; // 範例
        }

        // 解析讀取回應
        public static object ParseReadResponse(byte[] response, PlcDataType dataType)
        {
            // TODO: 根據PLC協議解析回傳資料
            // 這裡僅示意，實際需依PLC協議格式實作
            switch (dataType)
            {
                case PlcDataType.Bit:
                    return (response.Length > 0 && response[0] != 0);
                case PlcDataType.Word:
                    return response.Length >= 2 ? BitConverter.ToUInt16(response, 0) : (ushort)0;
                case PlcDataType.DWord:
                    return response.Length >= 4 ? BitConverter.ToUInt32(response, 0) : (uint)0;
                case PlcDataType.Float:
                    return response.Length >= 4 ? BitConverter.ToSingle(response, 0) : 0.0f;
                case PlcDataType.Double:
                    return response.Length >= 8 ? BitConverter.ToDouble(response, 0) : 0.0;
                case PlcDataType.String:
                    return System.Text.Encoding.ASCII.GetString(response);
                default:
                    throw new NotSupportedException();
            }
        }

        // 組裝寫入指令
        public static byte[] BuildWriteCommand(string address, object value, PlcDataType dataType)
        {
            // TODO: 根據PLC協議組裝寫入指令
            // 這裡僅示意，實際需依PLC協議格式實作
            return new byte[] { 0x03, 0x04 }; // 範例
        }

        // 解析寫入回應
        public static bool ParseWriteResponse(byte[] response)
        {
            // TODO: 根據PLC協議解析寫入回應
            // 這裡僅示意，實際需依PLC協議格式實作
            return response.Length > 0 && response[0] == 0x00; // 假設0x00代表成功
        }
    }
}
