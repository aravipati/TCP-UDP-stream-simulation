namespace TCP_UDP_Test
{
    partial class TCP_UDP_Test
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
            this.btnTcpConnect = new System.Windows.Forms.Button();
            this.grpTCP = new System.Windows.Forms.GroupBox();
            this.lblKbps = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnUDP = new System.Windows.Forms.Button();
            this.grpUDP = new System.Windows.Forms.GroupBox();
            this.lblUdpPackets = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnResetUdpPacket = new System.Windows.Forms.Button();
            this.grpTCP.SuspendLayout();
            this.grpUDP.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTcpConnect
            // 
            this.btnTcpConnect.Location = new System.Drawing.Point(51, 71);
            this.btnTcpConnect.Name = "btnTcpConnect";
            this.btnTcpConnect.Size = new System.Drawing.Size(100, 23);
            this.btnTcpConnect.TabIndex = 0;
            this.btnTcpConnect.Text = "Connect To TCP";
            this.btnTcpConnect.UseVisualStyleBackColor = true;
            this.btnTcpConnect.Click += new System.EventHandler(this.btnTcpConnect_Click);
            // 
            // grpTCP
            // 
            this.grpTCP.Controls.Add(this.lblKbps);
            this.grpTCP.Controls.Add(this.label3);
            this.grpTCP.Controls.Add(this.label2);
            this.grpTCP.Controls.Add(this.label1);
            this.grpTCP.Controls.Add(this.txtPort);
            this.grpTCP.Controls.Add(this.txtIP);
            this.grpTCP.Controls.Add(this.btnTcpConnect);
            this.grpTCP.Location = new System.Drawing.Point(26, 24);
            this.grpTCP.Name = "grpTCP";
            this.grpTCP.Size = new System.Drawing.Size(297, 134);
            this.grpTCP.TabIndex = 1;
            this.grpTCP.TabStop = false;
            this.grpTCP.Text = "TCP";
            // 
            // lblKbps
            // 
            this.lblKbps.AutoSize = true;
            this.lblKbps.Location = new System.Drawing.Point(148, 115);
            this.lblKbps.Name = "lblKbps";
            this.lblKbps.Size = new System.Drawing.Size(13, 13);
            this.lblKbps.TabIndex = 6;
            this.lblKbps.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Second bit rate (Kbps)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(51, 45);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 20);
            this.txtPort.TabIndex = 2;
            this.txtPort.Text = "13000";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(51, 19);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 20);
            this.txtIP.TabIndex = 1;
            this.txtIP.Text = "127.0.0.1";
            // 
            // btnUDP
            // 
            this.btnUDP.Location = new System.Drawing.Point(6, 29);
            this.btnUDP.Name = "btnUDP";
            this.btnUDP.Size = new System.Drawing.Size(117, 23);
            this.btnUDP.TabIndex = 2;
            this.btnUDP.Text = "Start Receiving UDP Data";
            this.btnUDP.UseVisualStyleBackColor = true;
            this.btnUDP.Click += new System.EventHandler(this.btnUDP_Click);
            // 
            // grpUDP
            // 
            this.grpUDP.Controls.Add(this.btnResetUdpPacket);
            this.grpUDP.Controls.Add(this.lblUdpPackets);
            this.grpUDP.Controls.Add(this.label5);
            this.grpUDP.Controls.Add(this.btnUDP);
            this.grpUDP.Location = new System.Drawing.Point(26, 188);
            this.grpUDP.Name = "grpUDP";
            this.grpUDP.Size = new System.Drawing.Size(297, 100);
            this.grpUDP.TabIndex = 3;
            this.grpUDP.TabStop = false;
            this.grpUDP.Text = "UDP";
            // 
            // lblUdpPackets
            // 
            this.lblUdpPackets.AutoSize = true;
            this.lblUdpPackets.Location = new System.Drawing.Point(152, 68);
            this.lblUdpPackets.Name = "lblUdpPackets";
            this.lblUdpPackets.Size = new System.Drawing.Size(13, 13);
            this.lblUdpPackets.TabIndex = 8;
            this.lblUdpPackets.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Number of Packets Received";
            // 
            // btnResetUdpPacket
            // 
            this.btnResetUdpPacket.Location = new System.Drawing.Point(208, 63);
            this.btnResetUdpPacket.Name = "btnResetUdpPacket";
            this.btnResetUdpPacket.Size = new System.Drawing.Size(60, 23);
            this.btnResetUdpPacket.TabIndex = 9;
            this.btnResetUdpPacket.Text = "Reset";
            this.btnResetUdpPacket.UseVisualStyleBackColor = true;
            this.btnResetUdpPacket.Click += new System.EventHandler(this.btnResetUdpPacket_Click);
            // 
            // TCP_UDP_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 307);
            this.Controls.Add(this.grpUDP);
            this.Controls.Add(this.grpTCP);
            this.Name = "TCP_UDP_Test";
            this.Text = "TCP/UDP Test Listener";
            this.grpTCP.ResumeLayout(false);
            this.grpTCP.PerformLayout();
            this.grpUDP.ResumeLayout(false);
            this.grpUDP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTcpConnect;
        private System.Windows.Forms.GroupBox grpTCP;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKbps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUDP;
        private System.Windows.Forms.GroupBox grpUDP;
        private System.Windows.Forms.Label lblUdpPackets;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnResetUdpPacket;
    }
}

