namespace ElectricCar
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.enterf2 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButtoncard = new System.Windows.Forms.RadioButton();
            this.radioButtonaccount = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.enterf2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.radioButtoncard);
            this.groupBox1.Controls.Add(this.radioButtonaccount);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(262, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // enterf2
            // 
            this.enterf2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.enterf2.Location = new System.Drawing.Point(587, 341);
            this.enterf2.Name = "enterf2";
            this.enterf2.Size = new System.Drawing.Size(143, 60);
            this.enterf2.TabIndex = 9;
            this.enterf2.Text = "Enter";
            this.enterf2.UseVisualStyleBackColor = true;
            this.enterf2.Click += new System.EventHandler(this.enterf2_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(6, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 50);
            this.button2.TabIndex = 8;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButtoncard
            // 
            this.radioButtoncard.AutoSize = true;
            this.radioButtoncard.Location = new System.Drawing.Point(142, 230);
            this.radioButtoncard.Name = "radioButtoncard";
            this.radioButtoncard.Size = new System.Drawing.Size(446, 49);
            this.radioButtoncard.TabIndex = 1;
            this.radioButtoncard.TabStop = true;
            this.radioButtoncard.Text = "Pay With Conatctleass Card";
            this.radioButtoncard.UseVisualStyleBackColor = true;
            // 
            // radioButtonaccount
            // 
            this.radioButtonaccount.AutoSize = true;
            this.radioButtonaccount.Location = new System.Drawing.Point(142, 122);
            this.radioButtonaccount.Name = "radioButtonaccount";
            this.radioButtonaccount.Size = new System.Drawing.Size(304, 49);
            this.radioButtonaccount.TabIndex = 0;
            this.radioButtonaccount.TabStop = true;
            this.radioButtonaccount.Text = "Pay With Account";
            this.radioButtonaccount.UseVisualStyleBackColor = true;
            this.radioButtonaccount.CheckedChanged += new System.EventHandler(this.radioButtonaccount_CheckedChanged);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 564);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtoncard;
        private System.Windows.Forms.RadioButton radioButtonaccount;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button enterf2;
    }
}