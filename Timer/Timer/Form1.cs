using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        int sec = 60;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(sec > 0)
            {
                sec = sec - 1;
                timerlabel.Text = sec + " seconds";
            }
            else
            {
                Countdowntimer.Stop();
                timerlabel.Text = "Time is finished!!";
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void strtbtn_Click(object sender, EventArgs e)
        {
        Countdowntimer.Start();
        }

        private void btnstp_Click(object sender, EventArgs e)
        {
            Countdowntimer.Stop();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            sec.ToString();
           // textBox1_TextChanged.Text = sec.ToString();
        }

        private void btnrest_Click(object sender, EventArgs e)
        {

        }

        private void timerlabel(object sender, EventArgs e)
        {

        }
    }
}
