using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace LTM_03_bai2_Client
{
    public partial class Form1 : Form
    {
        Socket server;
        EndPoint remote;
        public Form1()
        {
            InitializeComponent();
        }

        
        private void ButKeo_Click(object sender, EventArgs e)
        {

            txtYourS.Text = "Keo";
            byte[] sendData = Encoding.ASCII.GetBytes("0");
        
            server.SendTo(sendData  , remote);
            byte[] receiveData = new byte[20];
            server.ReceiveFrom(receiveData, ref remote);
            int recv = Convert.ToInt32(Encoding.ASCII.GetString(receiveData));
            if (recv == 0)
                txtserver.Text = "keo";
            else if (recv == 1)
                txtserver.Text = "bao";
            else
                txtserver.Text = "bua";

            if (recv == 0)
                txtYourR.Text = "hoa";
            else if (recv == 1)
                txtYourR.Text = "thang";
            else
                txtYourR.Text = "thua";
        }

        private void ButBao_Click(object sender, EventArgs e)
        {
            txtYourS.Text = "Bao";
            byte[] sendData = Encoding.ASCII.GetBytes("1");

            server.SendTo(sendData, remote);
            byte[] receiveData = new byte[20];
            server.ReceiveFrom(receiveData, ref remote);
            int recv = Convert.ToInt32(Encoding.ASCII.GetString(receiveData));
            if (recv == 0)
                txtserver.Text = "keo";
            else if (recv == 1)
                txtserver.Text = "bao";
            else
                txtserver.Text = "bua";

            if (recv == 0)
                txtYourR.Text = "thua";
            else if (recv == 1)
                txtYourR.Text = "hoa";
            else
                txtYourR.Text = "thang";
        }

        private void ButBua_Click(object sender, EventArgs e)
        {
            txtYourS.Text = "Bua";
            byte[] sendData = Encoding.ASCII.GetBytes("2");

            server.SendTo(sendData, remote);
            byte[] receiveData = new byte[20];
            server.ReceiveFrom(receiveData, ref remote);
            int recv = Convert.ToInt32(Encoding.ASCII.GetString(receiveData));
            if (recv == 0)
                txtserver.Text = "keo";
            else if (recv == 1)
                txtserver.Text = "bao";
            else
                txtserver.Text = "bua";

            if (recv == 0)
                txtYourR.Text = "thang";
            else if (recv == 1)
                txtYourR.Text = "thua";
            else
                txtYourR.Text = "hoa";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 995);
            remote = (EndPoint)ipe;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            server.Close();
        }
    }
}
