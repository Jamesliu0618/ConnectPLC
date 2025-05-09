using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConnectPLC;

namespace ConnectPLC
{
	public partial class Form1 : Form
	{
		private PlcConnector _plcConnector;

		public Form1()
		{
			InitializeComponent();

			// 預設使用Mitsubishi PLC策略
			_plcConnector = new PlcConnector(new MitsubishiPlcConnectionStrategy());
			// 若要切換Siemens PLC策略：
			// _plcConnector.SetStrategy(new SiemensPlcConnectionStrategy());
		}

		private void btnConnect_Click(object sender, EventArgs e)
		{
			string ip = txtIp.Text.Trim();
			string portText = txtPort.Text.Trim();
			string plcType = cmbPlcType.SelectedItem?.ToString();

			if (string.IsNullOrWhiteSpace(ip))
			{
				MessageBox.Show("請輸入IP位址");
				return;
			}
			if (!System.Net.IPAddress.TryParse(ip, out _))
			{
				MessageBox.Show("IP格式錯誤");
				return;
			}
			if (string.IsNullOrWhiteSpace(portText) || !int.TryParse(portText, out int port) || port < 1 || port > 65535)
			{
				MessageBox.Show("請輸入正確的Port (1-65535)");
				return;
			}
			if (string.IsNullOrWhiteSpace(plcType))
			{
				MessageBox.Show("請選擇PLC型號");
				return;
			}
			IConnectionStrategy strategy = null;
			switch (plcType)
			{
				case "Mitsubishi":
					strategy = new MitsubishiPlcConnectionStrategy();
					break;
				case "Siemens":
					strategy = new SiemensPlcConnectionStrategy();
					break;
				case "AB":
					strategy = new ABPlcConnectionStrategy();
					break;
				case "Omron":
					strategy = new OmronPlcConnectionStrategy();
					break;
				default:
					MessageBox.Show("不支援的PLC型號");
					return;
			}
			_plcConnector = new PlcConnector(strategy);
			bool result = _plcConnector.Connect(ip, port);
			MessageBox.Show(result ? "連線成功" : "連線失敗");
		}

		private void btnRead_Click(object sender, EventArgs e)
		{
			if (_plcConnector == null || !_plcConnector.IsConnected)
			{
				MessageBox.Show("請先連線PLC");
				return;
			}
			string address = txtAddress.Text.Trim();
			if (string.IsNullOrWhiteSpace(address))
			{
				MessageBox.Show("請輸入PLC位址");
				return;
			}
			if (cmbDataType.SelectedItem == null)
			{
				MessageBox.Show("請選擇資料型態");
				return;
			}
			PlcDataType dataType = (PlcDataType)cmbDataType.SelectedItem;
			try
			{
				object value = _plcConnector.ReadStatus(address, dataType);
				txtResult.Text = value?.ToString() ?? string.Empty;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"讀取失敗：{ex.Message}");
			}
		}

		private void btnWrite_Click(object sender, EventArgs e)
		{
			if (_plcConnector == null || !_plcConnector.IsConnected)
			{
				MessageBox.Show("請先連線PLC");
				return;
			}
			string address = txtAddress.Text.Trim();
			if (string.IsNullOrWhiteSpace(address))
			{
				MessageBox.Show("請輸入PLC位址");
				return;
			}
			if (cmbDataType.SelectedItem == null)
			{
				MessageBox.Show("請選擇資料型態");
				return;
			}
			string valueText = txtWriteValue.Text.Trim();
			if (string.IsNullOrWhiteSpace(valueText))
			{
				MessageBox.Show("請輸入寫入值");
				return;
			}
			PlcDataType dataType = (PlcDataType)cmbDataType.SelectedItem;
			object value = valueText;
			try
			{
				bool result = _plcConnector.WriteValue(address, value, dataType);
				MessageBox.Show(result ? "寫入成功" : "寫入失敗");
			}
			catch (Exception ex)
			{
				MessageBox.Show($"寫入失敗：{ex.Message}");
			}
		}
	}
}
