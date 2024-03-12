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
        public MonForm()
        {
            InitializeComponent();
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
            Console.WriteLine("C'est le deuxième bouton, bonne pioche !");
        }
    }
}
