using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace ip_logger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        static string getIP()
        {
            using (WebClient webClient = new WebClient())
            {
                return webClient.DownloadString("http://wtfismyip.com/text");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"mr inta told me that ur ipv6 ip thingy ma bob is ({getIP()}");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"lol theres no credits dumbass. just fuck ali... DOIN UR MOM DOIN UR MOM DOIN UR MOM DOIN UR MOM DOIN UR MOM ");

        }
    }
}
