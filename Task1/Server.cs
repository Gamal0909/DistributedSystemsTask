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
                string receivedMessage = Encoding.Unicode.GetString(buffer);

                // Log the raw message for debugging
                WriteLog($"Received raw message: {receivedMessage}");

                // Split the message into parts
                string[] msg = receivedMessage.Split(':');

                // Ensure the message has at least three parts
                if (msg.Length < 3)
                {
                    WriteLog("Invalid message format. Expected: 'port hostname message'.");
                    continue; // Skip processing this message
                }

                // Extract the message components
                string clientPort = msg[0];
                string hostName = msg[1];
                string clientMessage = string.Join(" ", msg.Skip(2)); // Combine the remaining parts

                // Log the extracted components
                WriteLog($"Client at Port: {clientPort}");
                WriteLog($"Host: {hostName}");
                WriteLog($"Message: {clientMessage}");

                // Respond to the client
                string serverResponse = txtServerMessage.Text; // Take response from the server's textbox
                if (string.IsNullOrWhiteSpace(serverResponse))
                {
                    serverResponse = "Default Server Response"; // Fallback message
                }

                byte[] responseBuffer = Encoding.Unicode.GetBytes(serverResponse);
                server.Send(responseBuffer, responseBuffer.Length, hostName, int.Parse(clientPort));
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void New_Click(object sender, EventArgs e)
        {
            Client clientForm = new Client();
            clientForm.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
