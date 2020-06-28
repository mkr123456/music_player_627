using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                textBox1.Text = openFileDialog1.FileName;

            }
            Player.URL = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.play();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.pause();

        }
        private void button4_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.stop();
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Player.Ctlcontrols.play();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Player.Ctlcontrols.stop();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}


