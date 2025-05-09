using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
	}
}
