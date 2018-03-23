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

namespace WP_Server
{
    public partial class Form1 : Form
    {
        Socket server;
        IPEndPoint ipe;
        EndPoint ep;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            ipe = new IPEndPoint(IPAddress.Any, 995);
            server.Bind(ipe);
            ep = ipe;
        }
        private void ButKeo_Click(object sender, EventArgs e)
        {
            txtYourS.Text = "Keo";
            byte[] receiveData = new byte[20];
            server.ReceiveFrom(receiveData, ref ep);
            int recv = Convert.ToInt32(Encoding.ASCII.GetString(receiveData));
            if (recv == 0)
                txtclient.Text = "keo";
            else if (recv == 1)
                txtclient.Text = "bao";
            else
                txtclient.Text = "bua";
            
            if (recv == 0)
                txtYourR.Text = "hoa";
            else if (recv == 1)
                txtYourR.Text = "thang";
            else
                txtYourR.Text = "thua";
            server.SendTo(Encoding.ASCII.GetBytes("0"), ep);
        }
        private void ButBao_Click(object sender, EventArgs e)
        {
            txtYourS.Text = "Bao";
            byte[] receiveData = new byte[20];
            server.ReceiveFrom(receiveData, ref ep);
            int recv = Convert.ToInt32(Encoding.ASCII.GetString(receiveData));
            if (recv == 0)
                txtclient.Text = "keo";
            else if (recv == 1)
                txtclient.Text = "bao";
            else
                txtclient.Text = "bua";
            
            if (recv == 0)
                txtYourR.Text = "thua";
            else if (recv == 1)
                txtYourR.Text = "hoa";
            else
                txtYourR.Text = "thang";
            server.SendTo(Encoding.ASCII.GetBytes("1"), ep);
        }
        private void ButBua_Click(object sender, EventArgs e)
        {
            txtYourS.Text = "Bua";
            byte[] receiveData = new byte[20];
            server.ReceiveFrom(receiveData, ref ep);
            int recv = Convert.ToInt32(Encoding.ASCII.GetString(receiveData));
            if (recv == 0)
                txtclient.Text = "keo";
            else if (recv == 1)
                txtclient.Text = "bao";
            else
                txtclient.Text = "bua";
            if (recv == 0)
                txtYourR.Text = "thang";
            else if (recv == 1)
                txtYourR.Text = "thua";
            else
                txtYourR.Text = "hoa";
            server.SendTo(Encoding.ASCII.GetBytes("2"), ep);

        }
    }
}
