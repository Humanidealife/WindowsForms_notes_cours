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

        private void button3_Click(object sender, EventArgs e)
        {
            /*comboBox1.Items.Add(textBox2.Text);
            comboBox1.Items.Add("Elément 1");
            comboBox1.Items.Add("Elément 2");
            comboBox1.Items.Add("Elément 3");
            comboBox1.Items.Add("Elément 4");*/
            comboBox1.Sorted = true;
            string[] tab = { "Brice", "Anna", "Zoe", "Cédric" };
            comboBox1.Items.AddRange(tab);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //comboBox1.Items.Clear();
            //comboBox1.Items.RemoveAt(1);
            //comboBox1.Items.Remove("Elément 2");
            /*label3.Text = comboBox1.Items.Count.ToString();

            if(comboBox1.Items.Contains("Elément 1"))
            {
                label2.Text = " cet élément est bien dans la comboBox";
            }
            else
            {
                label2.Text = "cet élément n'est pas dans la comboBox";
            }

            label3.Text = comboBox1.SelectedIndex.ToString();
            label3.Text = comboBox1.SelectedItem.ToString();*/
            label3.Text = comboBox1.Items[2].ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = 80;
            numericUpDown1.Minimum = -55;
            numericUpDown1.Increment = 7;
            label4.Text = numericUpDown1.Value.ToString();
            numericUpDown1.Value = 42;
        }
    }
}
