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

namespace Task1
{
    public partial class Client : Form
    {
        UdpClient udpClient;
        IPEndPoint endPoint;
        public Client()
        {
            InitializeComponent();
        }

        private void txtServerPort_TextChanged(object sender, EventArgs e)
        {

        }

        private void Client_Load(object sender, EventArgs e)
        {

        }

        private void Send_Click(object sender, EventArgs e)
        {
            int serverport=int.Parse(txtServerPort.Text);
            int clientport=int.Parse(txtClientPortnum.Text);
            string hostname = txtHostName.Text;
            udpClient = new UdpClient(clientport);

            string msg=clientport+":"+hostname+":"+txtmsg.Text;
            byte[] buffer =Encoding.Unicode.GetBytes(msg);
            udpClient.Send(buffer,buffer.Length,hostname,serverport);
            IPAddress iPAddress = IPAddress.Parse("192.168.1.0");
            endPoint = new IPEndPoint(iPAddress, 0);
            buffer=udpClient.Receive(ref endPoint);
            msg =Encoding.Unicode.GetString(buffer);
            WriteLog(msg);
        }
        private void WriteLog(string msg)
        {
            this.BeginInvoke(new MethodInvoker(delegate { txtLog.AppendText("Server Said : " + msg + Environment.NewLine); }));
        }
    }
}
