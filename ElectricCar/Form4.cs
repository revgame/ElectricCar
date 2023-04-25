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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void enterf2_Click(object sender, EventArgs e)
        {
            if (radioButtonaccount.Checked)
            {
                Form6 f6 = new Form6();
                f6.Show();
                this.Hide();
            }
            else if(radioButtoncard.Checked)
            {
                Form5 f5 = new Form5();
                f5.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void radioButtonaccount_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
