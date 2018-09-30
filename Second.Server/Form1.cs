using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Second.Server
{
    public partial class Server : Form
    {
        private static readonly string FileName = Path.GetDirectoryName(Environment.CurrentDirectory) + "\\Repo.txt";

        private TcpListener listener;
        private Socket socket;
        private NetworkStream ns;

        public Server()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IPHostEntry IpHost = Dns.GetHostEntry("localhost");
            IPAddress IpAddr = IpHost.AddressList[0];
            
            listener = new TcpListener(IpAddr, 8080);
            listener.Start();
            socket = listener.AcceptSocket();
            while (true)
            {
                if (socket.Connected)
                {
                    ns = new NetworkStream(socket);
                    ThreadClass threadClass = new ThreadClass();
                    threadClass.Start(ns, FileName);
                    Thread.Sleep(3000);
                }
            }
        }
    }
}
