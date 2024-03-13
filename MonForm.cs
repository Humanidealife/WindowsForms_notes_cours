using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_notes_cours
{
    public partial class MonForm : Form
    {
        int sec = 0;
        bool activation = false;
        public MonForm()
        {
            InitializeComponent();
            //timer1.Stop();
        }

        private void buttonTest_1_Click(object sender, EventArgs e)
        {
            string str1 = "Ceci est mon premier bouton";
            label1.Text = str1;
            label1.ForeColor = Color.Coral;
            label1.BackColor = Color.DarkBlue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label1.Text = textBox1.Text;
            string[] tableau = textBox1.Lines;
            foreach (string item in tableau)
            {
                Console.WriteLine(item);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec++;
            label2.Text = sec.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //timer1.Start();
            activation = !activation;
            timer1.Enabled = activation;
        }
    }
}
