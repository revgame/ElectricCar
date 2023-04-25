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
    public partial class Form2 : Form
    {
         String vrm;
         String pin;
        public Form2()
        {
            InitializeComponent();
        }

        private void enterf2_Click(object sender, EventArgs e)
        {
            vrm = this.textBoxvrm.Text.ToString();
            pin = this.textBoxpin.Text.ToString();

            if (textBoxvrm.Text.Length == 7 && textBoxpin.Text.Length == 4)
            {
                Form3 f3 = new Form3();
                f3.Show();
                this.Visible = false;
            }
            else if(textBoxvrm.Text.Length == 0)
            {
                string message = "You did not enter a vrm";
                string caption = "Error Detected";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons, icon);
                if(result == System.Windows.Forms.DialogResult.OK)
                {
                   
                }
            }
            else if (textBoxpin.Text.Length == 0)
            {
                string message = "You did not enter a pin";
                string caption = "Error Detected";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons, icon);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    
                }
            }
        }

        private void backf2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void textBoxvrm_TextChanged(object sender, EventArgs e)
        {
            if (textBoxvrm.Text.Length > 7)
            {
                string message = "VRM can only be 7 characters";
                string caption = "Error Detected";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons, icon);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    
                }
            }
        }

        private void textBoxpin_TextChanged(object sender, EventArgs e)
        {
            if (textBoxpin.Text.Length > 4 )
            {
                string message = "Only Enter 4 numbers for your PIN";
                string caption = "Error Detected";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons, icon);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    
                }
            }
        }
    }
}
