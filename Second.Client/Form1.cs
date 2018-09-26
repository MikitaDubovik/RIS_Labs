using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Second.Client
{
    public partial class Client : Form
    {
        private static readonly IPHostEntry IpHost = Dns.GetHostEntry("localhost");
        private static readonly IPAddress IpAddr = IpHost.AddressList[0];
        private readonly TcpClient _tcpClient = new TcpClient(IpAddr.ToString(), 8080);
        private readonly ASCIIEncoding _ae = new ASCIIEncoding();

        public Client()
        {
            InitializeComponent();
            NameItem.Enabled = false;
            Price.Enabled = false;
            Taste.Enabled = false;
            listBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var command = SetCommand();

            NetworkStream ns = _tcpClient.GetStream();

            string res = SetResult(command + "|");

            var sent = _ae.GetBytes(res);
            var received = new byte[256];
            ns.Write(sent, 0, sent.Length);
            ns.Read(received, 0, received.Length);
            richTextBox1.Text = _ae.GetString(received);
            var status = $"=>Command sent: {command} data";
            listBox1.Items.Add(status);
        }

        private string SetCommand()
        {
            var command = string.Empty;
            if (printRadioButton.Checked)
            {
                command = "print";
            }

            if (addRadioButton.Checked)
            {
                command = "add";
            }

            if (deleteRadioButton.Checked)
            {
                command = "del";
            }

            if (updateRadioButton.Checked)
            {
                command = "up";
            }

            if (searchRadioButton.Checked)
            {
                command = "search";
            }

            return command;
        }

        private string SetResult(string command)
        {
            string res = command;

            if (addRadioButton.Checked)
            {
                res += NameItem.Text + " " + Price.Text + " " + Taste.Text;
            }

            if (deleteRadioButton.Checked)
            {
                res += NameItem.Text;
            }

            if (updateRadioButton.Checked)
            {
                res += richTextBox1.Text + " " + NameItem.Text + " " + Price.Text + " " + Taste.Text;
            }

            if (searchRadioButton.Checked)
            {
                res += NameItem.Text;
            }

            return res;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Visible = checkBox1.Checked;
        }

        private void addRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
            NameItem.Enabled = true;
            Price.Enabled = true;
            Taste.Enabled = true;
        }

        private void deleteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
            NameItem.Enabled = true;
            Price.Enabled = false;
            Taste.Enabled = false;
        }

        private void updateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
            NameItem.Enabled = true;
            Price.Enabled = true;
            Taste.Enabled = true;
        }

        private void searchRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
            NameItem.Enabled = true;
            Price.Enabled = false;
            Taste.Enabled = false;
        }

        private void printRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
            NameItem.Enabled = false;
            Price.Enabled = false;
            Taste.Enabled = false;
        }
    }
}
