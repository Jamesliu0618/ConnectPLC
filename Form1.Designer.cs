namespace ConnectPLC
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.txtIp = new System.Windows.Forms.TextBox();
			this.txtPort = new System.Windows.Forms.TextBox();
			this.cmbPlcType = new System.Windows.Forms.ComboBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.cmbDataType = new System.Windows.Forms.ComboBox();
			this.txtResult = new System.Windows.Forms.TextBox();
			this.txtWriteValue = new System.Windows.Forms.TextBox();
			this.btnConnect = new System.Windows.Forms.Button();
			this.btnRead = new System.Windows.Forms.Button();
			this.btnWrite = new System.Windows.Forms.Button();
			this.lblIp = new System.Windows.Forms.Label();
			this.lblPort = new System.Windows.Forms.Label();
			this.lblPlcType = new System.Windows.Forms.Label();
			this.lblAddress = new System.Windows.Forms.Label();
			this.lblDataType = new System.Windows.Forms.Label();
			this.lblResult = new System.Windows.Forms.Label();
			this.lblWriteValue = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtIp
			// 
			this.txtIp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
			this.txtIp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtIp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
			this.txtIp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.txtIp.Location = new System.Drawing.Point(30, 30);
			this.txtIp.Name = "txtIp";
			this.txtIp.Size = new System.Drawing.Size(120, 26);
			this.txtIp.TabIndex = 0;
			// 
			// txtPort
			// 
			this.txtPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
			this.txtPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPort.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
			this.txtPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.txtPort.Location = new System.Drawing.Point(170, 30);
			this.txtPort.Name = "txtPort";
			this.txtPort.Size = new System.Drawing.Size(80, 26);
			this.txtPort.TabIndex = 1;
			// 
			// cmbPlcType
			// 
			this.cmbPlcType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
			this.cmbPlcType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbPlcType.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
			this.cmbPlcType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.cmbPlcType.Items.AddRange(new object[] {
            "Mitsubishi",
            "Siemens",
            "AB",
            "Omron"});
			this.cmbPlcType.Location = new System.Drawing.Point(270, 30);
			this.cmbPlcType.Name = "cmbPlcType";
			this.cmbPlcType.Size = new System.Drawing.Size(120, 27);
			this.cmbPlcType.TabIndex = 2;
			// 
			// txtAddress
			// 
			this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
			this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtAddress.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
			this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.txtAddress.Location = new System.Drawing.Point(30, 80);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(120, 26);
			this.txtAddress.TabIndex = 4;
			// 
			// cmbDataType
			// 
			this.cmbDataType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
			this.cmbDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbDataType.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
			this.cmbDataType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.cmbDataType.Items.AddRange(new object[] {
            ConnectPLC.PlcDataType.Bit,
            ConnectPLC.PlcDataType.Word,
            ConnectPLC.PlcDataType.DWord,
            ConnectPLC.PlcDataType.Float,
            ConnectPLC.PlcDataType.Double,
            ConnectPLC.PlcDataType.String});
			this.cmbDataType.Location = new System.Drawing.Point(170, 80);
			this.cmbDataType.Name = "cmbDataType";
			this.cmbDataType.Size = new System.Drawing.Size(120, 27);
			this.cmbDataType.TabIndex = 5;
			// 
			// txtResult
			// 
			this.txtResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
			this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtResult.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
			this.txtResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.txtResult.Location = new System.Drawing.Point(30, 130);
			this.txtResult.Name = "txtResult";
			this.txtResult.ReadOnly = true;
			this.txtResult.Size = new System.Drawing.Size(250, 26);
			this.txtResult.TabIndex = 7;
			// 
			// txtWriteValue
			// 
			this.txtWriteValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
			this.txtWriteValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtWriteValue.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
			this.txtWriteValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.txtWriteValue.Location = new System.Drawing.Point(300, 130);
			this.txtWriteValue.Name = "txtWriteValue";
			this.txtWriteValue.Size = new System.Drawing.Size(100, 26);
			this.txtWriteValue.TabIndex = 8;
			// 
			// btnConnect
			// 
			this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.btnConnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConnect.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
			this.btnConnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.btnConnect.Location = new System.Drawing.Point(410, 30);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(90, 28);
			this.btnConnect.TabIndex = 3;
			this.btnConnect.Text = "連線";
			this.btnConnect.UseVisualStyleBackColor = false;
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// btnRead
			// 
			this.btnRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(140)))));
			this.btnRead.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(140)))));
			this.btnRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRead.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
			this.btnRead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.btnRead.Location = new System.Drawing.Point(310, 80);
			this.btnRead.Name = "btnRead";
			this.btnRead.Size = new System.Drawing.Size(90, 28);
			this.btnRead.TabIndex = 6;
			this.btnRead.Text = "讀取";
			this.btnRead.UseVisualStyleBackColor = false;
			this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
			// 
			// btnWrite
			// 
			this.btnWrite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
			this.btnWrite.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
			this.btnWrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnWrite.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
			this.btnWrite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.btnWrite.Location = new System.Drawing.Point(410, 130);
			this.btnWrite.Name = "btnWrite";
			this.btnWrite.Size = new System.Drawing.Size(90, 28);
			this.btnWrite.TabIndex = 9;
			this.btnWrite.Text = "寫入";
			this.btnWrite.UseVisualStyleBackColor = false;
			this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
			// 
			// lblIp
			// 
			this.lblIp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
			this.lblIp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.lblIp.Location = new System.Drawing.Point(30, 8);
			this.lblIp.Name = "lblIp";
			this.lblIp.Size = new System.Drawing.Size(80, 20);
			this.lblIp.TabIndex = 0;
			this.lblIp.Text = "IP位址：";
			// 
			// lblPort
			// 
			this.lblPort.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
			this.lblPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.lblPort.Location = new System.Drawing.Point(170, 8);
			this.lblPort.Name = "lblPort";
			this.lblPort.Size = new System.Drawing.Size(60, 20);
			this.lblPort.TabIndex = 1;
			this.lblPort.Text = "Port：";
			// 
			// lblPlcType
			// 
			this.lblPlcType.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
			this.lblPlcType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.lblPlcType.Location = new System.Drawing.Point(270, 8);
			this.lblPlcType.Name = "lblPlcType";
			this.lblPlcType.Size = new System.Drawing.Size(80, 20);
			this.lblPlcType.TabIndex = 2;
			this.lblPlcType.Text = "PLC型號：";
			// 
			// lblAddress
			// 
			this.lblAddress.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
			this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.lblAddress.Location = new System.Drawing.Point(30, 58);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(80, 20);
			this.lblAddress.TabIndex = 3;
			this.lblAddress.Text = "PLC位址：";
			// 
			// lblDataType
			// 
			this.lblDataType.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
			this.lblDataType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.lblDataType.Location = new System.Drawing.Point(170, 58);
			this.lblDataType.Name = "lblDataType";
			this.lblDataType.Size = new System.Drawing.Size(80, 20);
			this.lblDataType.TabIndex = 4;
			this.lblDataType.Text = "資料型態：";
			// 
			// lblResult
			// 
			this.lblResult.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
			this.lblResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.lblResult.Location = new System.Drawing.Point(30, 108);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(90, 20);
			this.lblResult.TabIndex = 5;
			this.lblResult.Text = "讀取結果：";
			// 
			// lblWriteValue
			// 
			this.lblWriteValue.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
			this.lblWriteValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.lblWriteValue.Location = new System.Drawing.Point(300, 108);
			this.lblWriteValue.Name = "lblWriteValue";
			this.lblWriteValue.Size = new System.Drawing.Size(70, 20);
			this.lblWriteValue.TabIndex = 6;
			this.lblWriteValue.Text = "寫入值：";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
			this.ClientSize = new System.Drawing.Size(540, 200);
			this.Controls.Add(this.lblIp);
			this.Controls.Add(this.lblPort);
			this.Controls.Add(this.lblPlcType);
			this.Controls.Add(this.lblAddress);
			this.Controls.Add(this.lblDataType);
			this.Controls.Add(this.lblResult);
			this.Controls.Add(this.lblWriteValue);
			this.Controls.Add(this.txtIp);
			this.Controls.Add(this.txtPort);
			this.Controls.Add(this.cmbPlcType);
			this.Controls.Add(this.btnConnect);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.cmbDataType);
			this.Controls.Add(this.btnRead);
			this.Controls.Add(this.txtResult);
			this.Controls.Add(this.txtWriteValue);
			this.Controls.Add(this.btnWrite);
			this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "PLC 通訊";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtIp;
		private System.Windows.Forms.TextBox txtPort;
		private System.Windows.Forms.ComboBox cmbPlcType;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.ComboBox cmbDataType;
		private System.Windows.Forms.TextBox txtResult;
		private System.Windows.Forms.TextBox txtWriteValue;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.Button btnRead;
		private System.Windows.Forms.Button btnWrite;
		private System.Windows.Forms.Label lblIp;
		private System.Windows.Forms.Label lblPort;
		private System.Windows.Forms.Label lblPlcType;
		private System.Windows.Forms.Label lblAddress;
		private System.Windows.Forms.Label lblDataType;
		private System.Windows.Forms.Label lblResult;
		private System.Windows.Forms.Label lblWriteValue;
	}
}

