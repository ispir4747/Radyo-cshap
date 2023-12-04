using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radyo_cshap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //karadniz radyo
           // axWindowsMediaPlayer1.URL = "http://yayin.liderhost.net:8028/;";
            //90 lar radyo
          //  axWindowsMediaPlayer1.URL = "http://37.247.98.8/stream/166/";
            //baba radyo
           // axWindowsMediaPlayer1.URL = "\thttp://37.247.98.7:80/;stream.mp3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://yayin.liderhost.net:8028/;";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "\thttp://37.247.98.7:80/;stream.mp3";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://37.247.98.8/stream/166/";
        }
    }
}
