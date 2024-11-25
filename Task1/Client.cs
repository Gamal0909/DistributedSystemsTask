using System;
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
        public Client()
        {
            InitializeComponent();
        }

        private async void Send_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse inputs
                int serverPort = int.Parse(txtServerPort.Text);
                int clientPort = int.Parse(txtClientPortnum.Text);
                string hostname = txtHostName.Text;

                if (string.IsNullOrWhiteSpace(hostname))hostname = "localhost";


                // Initialize UdpClient
                udpClient = new UdpClient(clientPort);

                // Prepare the message
                string message = $"{clientPort}:{hostname}:{txtmsg.Text}";
                byte[] buffer = Encoding.Unicode.GetBytes(message);

                // Send the message
                await udpClient.SendAsync(buffer, buffer.Length, hostname, serverPort);
                WriteLog($"Message sent to server: {message}");

                // Receive server response asynchronously
                var result = await udpClient.ReceiveAsync();
                string serverMessage = Encoding.Unicode.GetString(result.Buffer);
                
                WriteLog($"Server Message: {serverMessage}");
            }
            catch (FormatException)
            {
                WriteLog("Error: Please enter valid port numbers.");
            }
            catch (SocketException ex)
            {
                WriteLog($"Socket error: {ex.Message}");
            }
            catch (Exception ex)
            {
                WriteLog($"Unexpected error: {ex.Message}");
            }
        }

        private void WriteLog(string msg)
        {
            this.BeginInvoke(new MethodInvoker(delegate
            {
                txtLog.AppendText(msg + Environment.NewLine);
            }));
        }
       /*
                    * Issues and Recommendations:
            UI Responsiveness:

            udpClient.Receive(ref endPoint) is a blocking call. If the server doesn't respond immediately, your UI will freeze.
            Fix: Use asynchronous calls to avoid blocking the UI.
            Hardcoded IP Address:

            IPAddress.Parse("192.168.1.0") is hardcoded. This may not always represent the actual server or local IP.
            Fix: Use the server hostname provided in txtHostName.Text.
            Error Handling:

            Parsing integers (int.Parse) or receiving data from the server might throw exceptions if the input or connection fails.
            Fix: Add error handling with try-catch blocks.
            Potential Infinite Loop:

            Send is enabled inside the event handler, which may cause unintended behavior if clicked multiple times.
            Fix: Consider managing the state of the button logically.
        */
    }
}
