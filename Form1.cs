using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExSocket
{
    public partial class Form1 : Form
    {
        public string bufferedList;
        public List<string> users = new List<string>();
        public string sendMsg = "";

        private TcpListener server;

        public Form1()
        {
            InitializeComponent();
        }

        public void AddText(string text)
        {
            // 채팅창에 텍스트 붙여넣고 스크롤을 아래로 보낸다.
            consoleTextBox.AppendText(text);
            consoleTextBox.Select(consoleTextBox.Text.Length, 0);
            consoleTextBox.ScrollToCaret();
        }

        private void ControlEnter(object sender, EventArgs e)
        {
            string inputText = controlTextBox.Text;
            Controller(inputText);
            controlTextBox.Text = string.Empty;
            controlTextBox.Focus();
        }

        private void RefreshChatters()
        {
            // 임시 크로스 스레드 해결
            CheckForIllegalCrossThreadCalls = false;
            while (true)
            {
                bufferedList = "**userlist**";
                clientListBox.Items.Clear();
                foreach(string user in users)
                {
                    clientListBox.Items.Add(user);
                    bufferedList += (user + " ");
                }
                Thread.Sleep(1000);
            }
        }

        private void Controller(string s)
        {
            if (string.IsNullOrEmpty(s)) return;
            else
            {
                sendMsg = s;
            }
        }

        private void OpenServer(object serverIp)
        {
            TcpClient client = new TcpClient();
            const int Port = 10203;
            IPEndPoint serverAddr = new IPEndPoint(IPAddress.Parse(serverIp.ToString()), Port);
            server = new TcpListener(serverAddr);
            try
            {
                server.Start();
                this.disconnectToolStripMenuItem.Enabled = true;
            }
            catch (SocketException e)
            {
                MessageBox.Show("올바르지 않은 주소입니다.");
                return;
            }
            AddText(string.Format("Server Opened. [{0}]\r\n", serverAddr.ToString()));

            while (true)
            {
                try
                {
                    client = server.AcceptTcpClient();
                    MyChatServer myChat = new MyChatServer(client, this);
                    Thread serverThread = new Thread(new ThreadStart(myChat.Listen));
                    serverThread.IsBackground = true;
                    serverThread.Start();
                }
                catch (Exception e) { break; }
            }

        }

        private void CloseServer()
        {
            server.Stop();
            AddText("[Server] Closed.\r\n");
            this.disconnectToolStripMenuItem.Enabled = false;
        }

        private void controlTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) ControlEnter(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread refresher = new Thread(RefreshChatters);
            refresher.IsBackground = true;
            refresher.Start();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            ControlEnter(sender, e);
        }

        private void connectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // 연결
            var ipEntry = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName());

            string currentIp = string.Empty;
            foreach(var ip in ipEntry.AddressList)
            {
                if(ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    currentIp = ip.ToString();
                    break;
                }
            }

            if (!currentIp.Equals(""))
            {
                Thread open = new Thread(OpenServer);
                open.IsBackground = true;
                open.Start(currentIp);
            }
            else
            {
                MessageBox.Show("IP를 확인해주세요.");
            }
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 연결해제
            CloseServer();
        }
    }
}
