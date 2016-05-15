namespace TCP_UDP_StreamSimmulator
{
    partial class DataSender
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUDP = new System.Windows.Forms.Button();
            this.grpTCP = new System.Windows.Forms.GroupBox();
            this.chkSendTCPData = new System.Windows.Forms.CheckBox();
            this.grpUDP = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMobileIP = new System.Windows.Forms.TextBox();
            this.txtMobilePort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.grpTCP.SuspendLayout();
            this.grpUDP.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUDP
            // 
            this.btnUDP.Location = new System.Drawing.Point(106, 85);
            this.btnUDP.Name = "btnUDP";
            this.btnUDP.Size = new System.Drawing.Size(131, 36);
            this.btnUDP.TabIndex = 2;
            this.btnUDP.Text = "Send UDP Packets";
            this.btnUDP.UseVisualStyleBackColor = true;
            this.btnUDP.Click += new System.EventHandler(this.btnUDP_Click);
            // 
            // grpTCP
            // 
            this.grpTCP.Controls.Add(this.lblClient);
            this.grpTCP.Controls.Add(this.chkSendTCPData);
            this.grpTCP.Location = new System.Drawing.Point(28, 12);
            this.grpTCP.Name = "grpTCP";
            this.grpTCP.Size = new System.Drawing.Size(244, 100);
            this.grpTCP.TabIndex = 3;
            this.grpTCP.TabStop = false;
            this.grpTCP.Text = "TCP";
            // 
            // chkSendTCPData
            // 
            this.chkSendTCPData.AutoSize = true;
            this.chkSendTCPData.Location = new System.Drawing.Point(6, 43);
            this.chkSendTCPData.Name = "chkSendTCPData";
            this.chkSendTCPData.Size = new System.Drawing.Size(201, 17);
            this.chkSendTCPData.TabIndex = 0;
            this.chkSendTCPData.Text = "Send TCP Data To Connected Client";
            this.chkSendTCPData.UseVisualStyleBackColor = true;
            // 
            // grpUDP
            // 
            this.grpUDP.Controls.Add(this.txtMobilePort);
            this.grpUDP.Controls.Add(this.label2);
            this.grpUDP.Controls.Add(this.txtMobileIP);
            this.grpUDP.Controls.Add(this.label1);
            this.grpUDP.Controls.Add(this.btnUDP);
            this.grpUDP.Location = new System.Drawing.Point(28, 141);
            this.grpUDP.Name = "grpUDP";
            this.grpUDP.Size = new System.Drawing.Size(244, 138);
            this.grpUDP.TabIndex = 4;
            this.grpUDP.TabStop = false;
            this.grpUDP.Text = "UDP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mobile IP";
            // 
            // txtMobileIP
            // 
            this.txtMobileIP.Location = new System.Drawing.Point(65, 31);
            this.txtMobileIP.Name = "txtMobileIP";
            this.txtMobileIP.Size = new System.Drawing.Size(173, 20);
            this.txtMobileIP.TabIndex = 4;
            // 
            // txtMobilePort
            // 
            this.txtMobilePort.Location = new System.Drawing.Point(64, 59);
            this.txtMobilePort.Name = "txtMobilePort";
            this.txtMobilePort.Size = new System.Drawing.Size(173, 20);
            this.txtMobilePort.TabIndex = 6;
            this.txtMobilePort.Text = "13001";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mobile Port";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(7, 16);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(105, 13);
            this.lblClient.TabIndex = 1;
            this.lblClient.Text = "No Client Connected";
            // 
            // DataSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 291);
            this.Controls.Add(this.grpUDP);
            this.Controls.Add(this.grpTCP);
            this.Name = "DataSender";
            this.Text = "TCP/UDP Stream Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpTCP.ResumeLayout(false);
            this.grpTCP.PerformLayout();
            this.grpUDP.ResumeLayout(false);
            this.grpUDP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUDP;
        private System.Windows.Forms.GroupBox grpTCP;
        private System.Windows.Forms.GroupBox grpUDP;
        private System.Windows.Forms.CheckBox chkSendTCPData;
        private System.Windows.Forms.TextBox txtMobilePort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMobileIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClient;
    }
}

