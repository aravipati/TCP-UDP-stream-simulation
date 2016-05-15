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

namespace TCP_UDP_StreamSimmulator
{
    public partial class DataSender : Form
    {
        Thread listenerThread = null;
        Thread dataSenderThread = null;
        TcpListener server = null;
        Socket clientSocket = null;
        int port = 4444;

        public DataSender()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            server = new TcpListener(IPAddress.Any, port);
            server.Start();

            listenerThread = new Thread(TCPlistenerWorker);
            listenerThread.IsBackground = true;
            listenerThread.Start();

            dataSenderThread = new Thread(TCPSenderWorker);
            dataSenderThread.IsBackground = true;
            dataSenderThread.Start();
        }

        private void btnTCP_Click(object sender, EventArgs e)
        {
            var socket = server.AcceptSocket();
        }

        private void btnUDP_Click(object sender, EventArgs e)
        {
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPAddress serverAddr = null;
            int port;
            try
            {
                serverAddr = IPAddress.Parse(txtMobileIP.Text.Trim());
            }
            catch
            {
                MessageBox.Show("Invalid Mobile IP", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMobileIP.Focus();
                return;
            }

            if (int.TryParse(txtMobilePort.Text.Trim(), out port) == false) //invalid integer provided in Mobile Port
            {
                MessageBox.Show("Invalid Mobile Port", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMobilePort.Focus();
                return;
            }
            else if (port > 48653) //http://en.wikipedia.org/wiki/List_of_TCP_and_UDP_port_numbers
            {
                MessageBox.Show("Invalid Mobile Port. Port too big.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMobilePort.Focus();
                return;
            }

            IPEndPoint endPoint = new IPEndPoint(serverAddr, 5000);

            for (int i = 0; i < 1000; i++)
            {
                byte[] send_buffer = new byte[1];
                sock.SendTo(send_buffer, endPoint);
                Thread.Sleep(1);                
            }
        }


        private void TCPlistenerWorker()
        {
            while (true)
            {
                try
                {
                    clientSocket = server.AcceptSocket();
                    lblClient.Invoke((MethodInvoker)(() =>
                       {
                           lblClient.Text = "A Client Connected";
                       }));
                }
                catch
                {
                    Thread.Sleep(10);
                }
            }
        }

        private void TCPSenderWorker()
        {
            byte[] bytesToSend = new byte[1024];
            while (true) //keep sending data to client
            {
                try
                {
                    if (clientSocket != null && chkSendTCPData.Checked == true)
                        clientSocket.Send(bytesToSend);
                    else
                        Thread.Sleep(100); //wait if nothing to do, otherwise CPU usage will go 100%.
                }
                catch //clientSocket is closed
                {
                    lblClient.Invoke((MethodInvoker)(() =>
                    {
                        lblClient.Text = "Client Disconnected.";
                    }));
                    Thread.Sleep(100); //wait if nothing to do, otherwise CPU usage will go 100%.
                }
            }
        }

        private void UdpSenderWorker()
        {

        }
    }
}
