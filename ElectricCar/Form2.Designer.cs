namespace ElectricCar
{
    partial class Form2
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
            this.backf2 = new System.Windows.Forms.Button();
            this.enterf2 = new System.Windows.Forms.Button();
            this.textBoxpin = new System.Windows.Forms.TextBox();
            this.textBoxvrm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.backf2);
            this.groupBox1.Controls.Add(this.enterf2);
            this.groupBox1.Controls.Add(this.textBoxpin);
            this.groupBox1.Controls.Add(this.textBoxvrm);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(201, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // backf2
            // 
            this.backf2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backf2.Location = new System.Drawing.Point(0, 20);
            this.backf2.Name = "backf2";
            this.backf2.Size = new System.Drawing.Size(122, 50);
            this.backf2.TabIndex = 5;
            this.backf2.Text = "Back";
            this.backf2.UseVisualStyleBackColor = true;
            this.backf2.Click += new System.EventHandler(this.backf2_Click);
            // 
            // enterf2
            // 
            this.enterf2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.enterf2.Location = new System.Drawing.Point(595, 361);
            this.enterf2.Name = "enterf2";
            this.enterf2.Size = new System.Drawing.Size(143, 49);
            this.enterf2.TabIndex = 4;
            this.enterf2.Text = "Enter";
            this.enterf2.UseVisualStyleBackColor = true;
            this.enterf2.Click += new System.EventHandler(this.enterf2_Click);
            // 
            // textBoxpin
            // 
            this.textBoxpin.Location = new System.Drawing.Point(271, 234);
            this.textBoxpin.Name = "textBoxpin";
            this.textBoxpin.Size = new System.Drawing.Size(238, 46);
            this.textBoxpin.TabIndex = 3;
            this.textBoxpin.TextChanged += new System.EventHandler(this.textBoxpin_TextChanged);
            // 
            // textBoxvrm
            // 
            this.textBoxvrm.Location = new System.Drawing.Point(271, 137);
            this.textBoxvrm.Name = "textBoxvrm";
            this.textBoxvrm.Size = new System.Drawing.Size(238, 46);
            this.textBoxvrm.TabIndex = 2;
            this.textBoxvrm.TextChanged += new System.EventHandler(this.textBoxvrm_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "PIN :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "VRM :";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 577);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button backf2;
        public System.Windows.Forms.Button enterf2;
        public System.Windows.Forms.TextBox textBoxpin;
        public System.Windows.Forms.TextBox textBoxvrm;
    }
}