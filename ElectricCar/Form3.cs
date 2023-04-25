using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricCar
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex > 0 && comboBox3.SelectedIndex > 0)
            {
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
            else 
            {
                string info = "Complete the following tasks";
                string cap = "Incomplete form";
                DialogResult r = MessageBox.Show(info, cap);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                for (int i=1; i<=2; i++)
                {
                    comboBox3.Items.Add(i.ToString());
                }
                comboBox3.Items.Add("max");
            }
            else if(radioButton2.Checked)
            {
                for (int i=1; i<=8; i++)
                {
                    comboBox3.Items.Add(i.ToString());
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            for (int i=1; i<=10; i++)
            {
                comboBox1.Items.Add(i.ToString());
            }
            for (int i = 1; i <= 8; i++)
            {
                comboBox3.Items.Add(i.ToString());
            }
        }
    }
}
