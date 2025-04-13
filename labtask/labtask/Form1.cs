using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labtask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sec = 90;
        private void timerlabel_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (sec > 0)
            {
                sec = sec - 1;
                timerlabel.Text = sec + " Seconds";
            }
            else
            {
                timer.Stop();
                timerlabel.Text = "Time is Up!!";
            }
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            timer.Stop();
            sec = 90;
            timerlabel.Text = sec + " Seconds";
        }

        private void Stop_button_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}