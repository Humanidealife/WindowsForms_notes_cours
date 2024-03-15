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
        int progress = 0;
        
        
        public MonForm()
        {
            InitializeComponent();
            LoadItems();
            radioButton2.Checked = true;
            button10.Text = "Augmenter 10";
            label10.Text = "Volume : " + trackBar1.Value;

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

        private void button6_Click(object sender, EventArgs e)
        {
            //label5.Text = dateTimePicker1.Value.ToString();
            dateTimePicker1.MinDate = new DateTime(2014, 01, 31);
            dateTimePicker1.MaxDate = new DateTime(2222, 12, 31);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value;
            label5.Text = date.ToString("d");
            //label5.Text = dateTimePicker1.Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Add(textBox3.Text);
            //listBox1.Items.Remove("Ligne : 5");
            //listBox1.Items.RemoveAt(0);

            //label6.Text = listBox1.Items.Count.ToString();

            //listBox1.Items.Insert(0, "Nouvelle Ligne");
            //listBox1.Items.Clear();
            //string[] tableau1 = { "A", "B", "C" };
            //listBox1.Items.AddRange(tableau1);

            //label6.Text = listBox1.Items.IndexOf("Ligne : 3").ToString();

            //On dimensionne le tableau avec la longeur de listBox1
            //string[] tableau2 = new string[listBox1.Items.Count];
            //Onn copie les élements de listBox1 dans le tableau
            //listBox1.Items.CopyTo(tableau2, 0);

            //foreach (string item in tableau2)
            //{
            //   label6.Text += item + "\n";
            //}

            //listBox1.SetSelected(2, true);
            //Console.WriteLine("-------------------------------");
            label6.Text = "";
            foreach (var item in listBox1.SelectedItems)
            {
                label6.Text += " " + item + "\n";
            }


        }

        private void LoadItems()
        {
            for (int i = 0; i < 20; i++)
            {
                listBox1.Items.Add("Ligne : " + i);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //label6.Text = listBox1.SelectedItem.ToString();
            //label6.Text = listBox1.SelectedIndex.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progress++;
            if(progress <= progressBar1.Maximum)
            {
                progressBar1.Value = progress;
                label7.Text = progressBar1.Value + "/" + progressBar1.Maximum;
            }

            if (progressBar1.Value >70)
            {
                progressBar1.ForeColor = Color.Coral;
            }

            if (progressBar1.Value >90)
            {
                progressBar1.ForeColor = Color.Red;
            }

        }

        private void MonForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //if (radioButton1.Checked) label8.Text = radioButton1.Text;
            //if (radioButton2.Checked) label8.Text = radioButton2.Text;
            //if (radioButton3.Checked) label8.Text = radioButton3.Text;
            //!!cette façon est plus automatique et dynamique que d'écrire une ligne de code par bouton
            //lié avec la fonction isChecked.
            label8.Text = isChecked(groupBox1);
        }
        //une méthode (fonction) qui renvoie le nom du bouton qui a été checké dans le groupe de boutons
        string isChecked(Control container)
        {
            foreach(var item in container.Controls)
            {
                RadioButton rb = item as RadioButton;
                if (rb.Checked) return rb.Text;
            }
            return null;
        }

        
        private void button9_Click(object sender, EventArgs e)
        {
            //une façon pas dynamique
            /*List<string> ListeLangages = new List<string>();
            label9.Text = "";
            if (checkBox1.Checked) ListeLangages.Add(checkBox1.Text);
            if (checkBox2.Checked) ListeLangages.Add(checkBox2.Text);
            if (checkBox3.Checked) ListeLangages.Add(checkBox3.Text);
            if (checkBox4.Checked) ListeLangages.Add(checkBox4.Text);

            foreach (var item in ListeLangages)
            {
                label9.Text += item + "\n";
            }*/
            //une façon dynamique avvec la focntion isChecked2
            /*label9.Text = "";
            label9.Text = isChecked2(groupBox2);*/

            label9.Text = checkBox2.CheckState.ToString();

        }

        string isChecked2(Control container)
        {
            string str = null;
            foreach (var item in container.Controls)
            {
                CheckBox cb = item as CheckBox;
                if (cb.Checked) str += cb.Text + "\n";
            }
            return str;
        }
        
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
           
            label10.Text ="Volume : " + trackBar1.Value;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            trackBar1.Value += 10;
            label10.Text = "Volume : " + trackBar1.Value;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string initiale = textBox4.Text;
            string nom = textBox5.Text;
            string prenom = textBox6.Text;

            ListViewItem item = new ListViewItem(initiale);
            //ListViewItem item = new ListViewItem(new string[] { initiale, nom, preom});
            //Ou encore
            //ListViewItem item = new ListViewItem();
            //item.Text = initiale;
            item.SubItems.Add(nom);
            item.SubItems.Add(prenom);

            listView1.Items.Add(item);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            /*label14.Text = listView1.Items[0].Text + " " +
                listView1.Items[0].SubItems[1].Text + " " +
                listView1.Items[0].SubItems[2].Text;*/
            /*label14.Text = "";
            foreach (ListViewItem itemRow in listView1.Items)
            {
                for (int i = 0; i < itemRow.SubItems.Count; i++)
                {
                    string str = itemRow.SubItems[i].Text;
                    label14.Text += str + " ";
                }
            }*/
            label14.Text = "";
            ListView.SelectedListViewItemCollection selection = listView1.SelectedItems;

            foreach (ListViewItem item in selection)
            {
                label14.Text += item.Text + " " + item.SubItems[1].Text + " " + item.SubItems[2].Text;
            }


        }

        private void button13_Click(object sender, EventArgs e)
        {
            listView1.Items.Remove(listView1.SelectedItems[0]);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //listView2.View = View.SmallIcon;
            listView2.LargeImageList = imageList1;
            listView2.View = View.LargeIcon;
            listView2.Items.Add("0", 0);
            listView2.Items.Add("9", 2);
            listView2.Items.Add("11", 3);
            listView2.Items.Add("15", 1);
        }
    }
}
