using MetroFramework;
using MetroFramework.Forms;
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

namespace Server
{
    public partial class Chat : MetroForm
    {
        Socket sck;
        EndPoint epLocal, epRemote;
        public Chat()
        {
            InitializeComponent();
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
        }

        private void Chat_Load(object sender, EventArgs e)
        {
            metroTextBox1.Text = getIp();
            metroTextBox3.Text = getIp();
        }

        public string getIp()
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "192.168.1.5";
        }

        public void MessageCallBack(IAsyncResult aresult)
        {
            try
            {
                int size = sck.EndReceiveFrom(aresult,ref epRemote);
                if(size>0)
                {
                    byte[] recvData = new byte[1464];
                    recvData = (byte[])aresult.AsyncState;

                    ASCIIEncoding eEncoding = new ASCIIEncoding();
                    string rcvmssge = eEncoding.GetString(recvData);
                    listBox1.Items.Add("Friend: "+rcvmssge);
                }
                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer,0,buffer.Length,SocketFlags.None,ref epRemote,new AsyncCallback(MessageCallBack),buffer);


            }
            catch(Exception e)
            {
                MetroFramework.MetroMessageBox.Show(this,e.ToString());
            }
        }

        private void send_Click(object sender, EventArgs e)
        {
            try
            {
                ASCIIEncoding enc = new ASCIIEncoding();
                byte[] msg = new byte[1500];
                msg = enc.GetBytes(metroTextBox5.Text);

                sck.Send(msg);

                listBox1.Items.Add("You: "+ metroTextBox5.Text);
                metroTextBox5.Clear();
            }

            catch(Exception exc)
            {
                MetroMessageBox.Show(this,exc.ToString());
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            try
            {
                epLocal = new IPEndPoint(IPAddress.Parse(metroTextBox1.Text),Convert.ToInt32(metroTextBox2.Text));
                sck.Bind(epLocal);

                epRemote = new IPEndPoint(IPAddress.Parse(metroTextBox3.Text), Convert.ToInt32(metroTextBox4.Text));
                sck.Connect(epRemote);

                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

                start.Text = "Connected";
                start.Enabled = false;
                send.Enabled = true;
                metroTextBox5.Focus();

            }
            catch (Exception exc)
            {
                MetroMessageBox.Show(this, exc.ToString());
            }
        }
        
    }
}
