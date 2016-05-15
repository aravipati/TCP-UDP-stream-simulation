using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace TCP_UDP_Test
{
    public partial class TCP_UDP_Test : Form
    {
        Thread TcpReader;
        Thread UdpReader;

        UdpClient udpClient = null;
         int totalUdpBytesRead = 0;

        public TCP_UDP_Test()
        {
            InitializeComponent();
        }

        int DataReceivedInLastSecond = 0;

        private void btnTcpConnect_Click(object sender, EventArgs e)
        {
            TcpReader = new Thread(ReadTcpData);
            TcpReader.IsBackground = true;
            TcpReader.Start();

            btnTcpConnect.Enabled = false;
        }

        private void ReadTcpData()
        {
            TcpClient client = new TcpClient();
            client.Connect(new System.Net.IPEndPoint(IPAddress.Parse(txtIP.Text.Trim()), Convert.ToInt32(txtPort.Text.Trim())));

            byte[] receivedByte= new byte[1024];

            int currentSecond = DateTime.Now.Second;

            int DataReceivedInCurrentSecond = 0;

            while(true)
            {
                client.Client.Receive(receivedByte);

                if (currentSecond != DateTime.Now.Second)
                {
                    currentSecond = DateTime.Now.Second;
                    DataReceivedInLastSecond = DataReceivedInCurrentSecond;
                    DataReceivedInCurrentSecond = 0;

                    lblKbps.Invoke((MethodInvoker)(() =>
                    {
                        lblKbps.Text = (DataReceivedInLastSecond / 1024).ToString();
                    }));

                }
                DataReceivedInCurrentSecond += 8 * receivedByte.Length; //1 byte = 8 bit
            }
        }
        private void ReadUdpData()
        {
            udpClient = new UdpClient(13001);
            IPEndPoint ep = new IPEndPoint(IPAddress.Any, 13001);

            totalUdpBytesRead = 0;
            while (true)
            {
                byte[] readBytes = udpClient.Receive(ref ep);
                totalUdpBytesRead += readBytes.Length;

                lblUdpPackets.Invoke((MethodInvoker)(() =>
                {
                    lblUdpPackets.Text = totalUdpBytesRead.ToString();
                }));
            }
        }

        private void btnUDP_Click(object sender, EventArgs e)
        {
            Thread UdpReader = new Thread(ReadUdpData);
            UdpReader.IsBackground = true;
            UdpReader.Start();

            btnUDP.Enabled = false; 
        }

        private void btnResetUdpPacket_Click(object sender, EventArgs e)
        {
            totalUdpBytesRead = 0;

            lblUdpPackets.Invoke((MethodInvoker)(() =>
            {
                lblUdpPackets.Text = totalUdpBytesRead.ToString();
            }));
        }

    }
}
