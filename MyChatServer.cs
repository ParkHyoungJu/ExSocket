using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExSocket
{
    class MyChatServer
    {
        private Dictionary<string, TcpClient> userData = new Dictionary<string, TcpClient>();
        private TcpClient client;
        private NetworkStream stream = default(NetworkStream);
        private string userId;
        private Form1 serverForm;

        public MyChatServer(TcpClient client, Form1 serverForm)
        {
            this.client = client;
            this.serverForm = serverForm;
            this.userId = client.Client.RemoteEndPoint.ToString();

            userData.Add(userId, client);
            serverForm.AddText(string.Format($"[{userId}] connected to server.\r\n"));
            Broadcast(string.Format("{0} joined to server", userId), "Notice");
            Thread refresher = new Thread(Refresh);
            refresher.IsBackground = true;
            refresher.Start();
        }

        private void Refresh()
        {
            while (true)
            {
                if (client == null || !client.Connected) break;

                if (!SocketConnected())
                {
                    serverForm.AddText(string.Format("{0} 클라이언트 퇴장\r\n", userId));
                    serverForm.users.Remove(userId);
                    stream.Close();
                    client.Close();
                    break;
                }
                else if (!serverForm.users.Contains(client.Client.RemoteEndPoint.ToString()))
                {
                    serverForm.users.Add(client.Client.RemoteEndPoint.ToString());
                }

                if (serverForm.sendMsg.Equals("")) continue;

                byte[] bytes = Encoding.Default.GetBytes(string.Format("[Server]:{0}\r\n", serverForm.sendMsg));

                serverForm.AddText(string.Format("[나]: {0}\r\n", serverForm.sendMsg));
                serverForm.sendMsg = "";
                stream.Write(bytes, 0, bytes.Length);
                stream.Flush();
                Thread.Sleep(1000);
            }
        }

        private void Broadcast(string msg, string id)
        {
            foreach(var user in userData)
            {
                TcpClient client = user.Value;
                stream = client.GetStream();
                byte[] buffer = Encoding.Default.GetBytes(string.Format("[{0}]: {1}\r\n", id, msg));
                stream.Write(buffer, 0, buffer.Length);
                stream.Flush();
            }
        }

        private bool Controller(string str)
        {
            bool isControlMsg = true;
            if (str.Equals("/exit"))
            {
                serverForm.users.Remove(userId);
                Broadcast(string.Format($"{userId} exited"), "Notice");
                userData.Remove(userId);
            }
            else
            {
                isControlMsg = false;
            }

            return isControlMsg;
        }

        public void Listen()
        {
            NetworkStream stream = client.GetStream();
            try
            {
                while (true)
                {
                    int bufLength;
                    byte[] buffer = new byte[1024];
                    string str = string.Empty;
                    if (!client.Connected) break;
                    if (!SocketConnected()) break;
                    try
                    {
                        while((bufLength = stream.Read(buffer, 0, buffer.Length)) != 0)
                        {
                            str = Encoding.Default.GetString(buffer, 0, bufLength);
                            serverForm.AddText(string.Format("[{0}]: {1}\r\n", userId, str.Replace("\r\n", "")));
                            // if (!Controller(str)) Broadcast(str, userId);
                        }
                    }
                    catch(IOException e)
                    {
                    }

                }
            }
            catch (SocketException e)
            {
                serverForm.AddText(string.Format("{0} 클라이언트 오류로 인한 퇴장\r\n", userId));
                serverForm.users.Remove(userId);

            }
        }

        private bool SocketConnected()
        {
            IPGlobalProperties ipProperties = IPGlobalProperties.GetIPGlobalProperties();

            TcpConnectionInformation[] tcpConnections = ipProperties.GetActiveTcpConnections();

            foreach (TcpConnectionInformation c in tcpConnections)
            {
                TcpState stateOfConnection = c.State;

                if (c.LocalEndPoint.Equals(client.Client.LocalEndPoint) && c.RemoteEndPoint.Equals(client.Client.RemoteEndPoint))
                {
                    if (stateOfConnection == TcpState.Established)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }

            }

            return false;
        }
    }
}
