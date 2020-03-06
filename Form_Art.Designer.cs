namespace Admin_Control_Panel
{
    partial class Form_Art
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Submit_AR_bt = new System.Windows.Forms.Button();
            this.Back_AR_bt = new System.Windows.Forms.Button();
            this.Home_AR_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Article Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gen. Info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Heading";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(230, 123);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 38);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(230, 220);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(215, 38);
            this.textBox2.TabIndex = 4;
            // 
            // Submit_AR_bt
            // 
            this.Submit_AR_bt.Location = new System.Drawing.Point(44, 376);
            this.Submit_AR_bt.Name = "Submit_AR_bt";
            this.Submit_AR_bt.Size = new System.Drawing.Size(131, 43);
            this.Submit_AR_bt.TabIndex = 5;
            this.Submit_AR_bt.Text = "Submit";
            this.Submit_AR_bt.UseVisualStyleBackColor = true;
            // 
            // Back_AR_bt
            // 
            this.Back_AR_bt.Location = new System.Drawing.Point(771, 376);
            this.Back_AR_bt.Name = "Back_AR_bt";
            this.Back_AR_bt.Size = new System.Drawing.Size(131, 52);
            this.Back_AR_bt.TabIndex = 6;
            this.Back_AR_bt.Text = "Back";
            this.Back_AR_bt.UseVisualStyleBackColor = true;
            this.Back_AR_bt.Click += new System.EventHandler(this.Back_AR_bt_Click);
            // 
            // Home_AR_bt
            // 
            this.Home_AR_bt.Location = new System.Drawing.Point(580, 376);
            this.Home_AR_bt.Name = "Home_AR_bt";
            this.Home_AR_bt.Size = new System.Drawing.Size(131, 52);
            this.Home_AR_bt.TabIndex = 7;
            this.Home_AR_bt.Text = "Home";
            this.Home_AR_bt.UseVisualStyleBackColor = true;
            this.Home_AR_bt.Click += new System.EventHandler(this.Home_AR_bt_Click);
            // 
            // Form_Art
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 481);
            this.Controls.Add(this.Home_AR_bt);
            this.Controls.Add(this.Back_AR_bt);
            this.Controls.Add(this.Submit_AR_bt);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Art";
            this.Text = "Form_Art";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Submit_AR_bt;
        private System.Windows.Forms.Button Back_AR_bt;
        private System.Windows.Forms.Button Home_AR_bt;
    }
}