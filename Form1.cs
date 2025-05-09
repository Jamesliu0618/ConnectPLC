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
			int port = int.Parse(txtPort.Text.Trim());
			string plcType = cmbPlcType.SelectedItem.ToString();
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
			}
			_plcConnector = new PlcConnector(strategy);
			bool result = _plcConnector.Connect(ip, port);
			MessageBox.Show(result ? "連線成功" : "連線失敗");
		}

		private void btnRead_Click(object sender, EventArgs e)
		{
			string address = txtAddress.Text.Trim();
			PlcDataType dataType = (PlcDataType)cmbDataType.SelectedItem;
			object value = _plcConnector.ReadStatus(address, dataType);
			txtResult.Text = value.ToString();
		}

		private void btnWrite_Click(object sender, EventArgs e)
		{
			string address = txtAddress.Text.Trim();
			PlcDataType dataType = (PlcDataType)cmbDataType.SelectedItem;
			object value = txtWriteValue.Text.Trim();
			bool result = _plcConnector.WriteValue(address, value, dataType);
			MessageBox.Show(result ? "寫入成功" : "寫入失敗");
		}
	}
}
