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
			this.SuspendLayout();
			// 
			// txtIp
			// 
			this.txtIp.Location = new System.Drawing.Point(20, 20);
			this.txtIp.Name = "txtIp";
			this.txtIp.Size = new System.Drawing.Size(120, 22);
			this.txtIp.TabIndex = 0;
			// 
			// txtPort
			// 
			this.txtPort.Location = new System.Drawing.Point(150, 20);
			this.txtPort.Name = "txtPort";
			this.txtPort.Size = new System.Drawing.Size(60, 22);
			this.txtPort.TabIndex = 1;
			// 
			// cmbPlcType
			// 
			this.cmbPlcType.FormattingEnabled = true;
			this.cmbPlcType.Items.AddRange(new object[] {
            "Mitsubishi",
            "Siemens",
            "AB",
            "Omron"});
			this.cmbPlcType.Location = new System.Drawing.Point(220, 20);
			this.cmbPlcType.Name = "cmbPlcType";
			this.cmbPlcType.Size = new System.Drawing.Size(100, 22);
			this.cmbPlcType.TabIndex = 2;
			this.cmbPlcType.SelectedIndex = 0;
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(20, 60);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(120, 22);
			this.txtAddress.TabIndex = 3;
			// 
			// cmbDataType
			// 
			this.cmbDataType.FormattingEnabled = true;
			this.cmbDataType.Items.AddRange(new object[] {
            "Bit",
            "Word",
            "DWord",
            "Float",
            "Double",
            "String"});
			this.cmbDataType.Location = new System.Drawing.Point(150, 60);
			this.cmbDataType.Name = "cmbDataType";
			this.cmbDataType.Size = new System.Drawing.Size(100, 22);
			this.cmbDataType.TabIndex = 4;
			this.cmbDataType.SelectedIndex = 0;
			// 
			// txtResult
			// 
			this.txtResult.Location = new System.Drawing.Point(20, 100);
			this.txtResult.Name = "txtResult";
			this.txtResult.ReadOnly = true;
			this.txtResult.Size = new System.Drawing.Size(200, 22);
			this.txtResult.TabIndex = 5;
			// 
			// txtWriteValue
			// 
			this.txtWriteValue.Location = new System.Drawing.Point(230, 100);
			this.txtWriteValue.Name = "txtWriteValue";
			this.txtWriteValue.Size = new System.Drawing.Size(90, 22);
			this.txtWriteValue.TabIndex = 6;
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(340, 20);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(80, 22);
			this.btnConnect.TabIndex = 7;
			this.btnConnect.Text = "連線";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// btnRead
			// 
			this.btnRead.Location = new System.Drawing.Point(340, 60);
			this.btnRead.Name = "btnRead";
			this.btnRead.Size = new System.Drawing.Size(80, 22);
			this.btnRead.TabIndex = 8;
			this.btnRead.Text = "讀取";
			this.btnRead.UseVisualStyleBackColor = true;
			this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
			// 
			// btnWrite
			// 
			this.btnWrite.Location = new System.Drawing.Point(340, 100);
			this.btnWrite.Name = "btnWrite";
			this.btnWrite.Size = new System.Drawing.Size(80, 22);
			this.btnWrite.TabIndex = 9;
			this.btnWrite.Text = "寫入";
			this.btnWrite.UseVisualStyleBackColor = true;
			this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(562, 333);
			this.Controls.Add(this.btnWrite);
			this.Controls.Add(this.btnRead);
			this.Controls.Add(this.btnConnect);
			this.Controls.Add(this.txtWriteValue);
			this.Controls.Add(this.txtResult);
			this.Controls.Add(this.cmbDataType);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.cmbPlcType);
			this.Controls.Add(this.txtPort);
			this.Controls.Add(this.txtIp);
			this.Name = "Form1";
			this.Text = "Form1";
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
	}
}

