using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Task1
{
    public partial class Server : Form
    {
        UdpClient server;
        IPEndPoint endPoint;
        public Server()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Server_Load(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            server = new UdpClient(int.Parse(txtServerPort.Text));
            IPAddress ipAddress = IPAddress.Parse("192.168.1.20");
            endPoint = new IPEndPoint(ipAddress, 0);
            WriteLog("Server Started........");
            Thread thread = new Thread(new ThreadStart(ServerStart));
            thread.Start();
            Start.Enabled = false;
        }

        private void WriteLog(string msg)
        {
            MethodInvoker invoker = new MethodInvoker(delegate { txtLog.AppendText(msg + Environment.NewLine); });
            this.BeginInvoke(invoker);
        }

        private void ServerStart()
        {
            while (true)
            {
                byte[] buffer = server.Receive(ref endPoint);
                string[] msg = Encoding.Unicode.GetString(buffer).Split(' ');
                WriteLog("Client at Port :" + msg[0]);
                WriteLog("at host :" + msg[1]);
                WriteLog("need :" + msg[2]);

                buffer = Encoding.Unicode.GetBytes(DateTime.Now.ToString());
                server.Send(buffer, buffer.Length, msg[1], int.Parse(msg[0]));
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void New_Click(object sender, EventArgs e)
        {
            Client clientForm=new Client();
            clientForm.Show();
        }
    }
}
