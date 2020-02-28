namespace Admin_Control_Panel
{
    partial class Form_Annc
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Create_A_Bt = new System.Windows.Forms.Button();
            this.Home_A_Bt = new System.Windows.Forms.Button();
            this.Back_A_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Annc. Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Author Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Heading";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gen. Info";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(255, 173);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 38);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(255, 258);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(282, 38);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(255, 337);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(282, 38);
            this.textBox3.TabIndex = 6;
            // 
            // Create_A_Bt
            // 
            this.Create_A_Bt.Location = new System.Drawing.Point(255, 430);
            this.Create_A_Bt.Name = "Create_A_Bt";
            this.Create_A_Bt.Size = new System.Drawing.Size(145, 58);
            this.Create_A_Bt.TabIndex = 7;
            this.Create_A_Bt.Text = "Create";
            this.Create_A_Bt.UseVisualStyleBackColor = true;
            // 
            // Home_A_Bt
            // 
            this.Home_A_Bt.Location = new System.Drawing.Point(255, 595);
            this.Home_A_Bt.Name = "Home_A_Bt";
            this.Home_A_Bt.Size = new System.Drawing.Size(145, 58);
            this.Home_A_Bt.TabIndex = 8;
            this.Home_A_Bt.Text = "Home";
            this.Home_A_Bt.UseVisualStyleBackColor = true;
            this.Home_A_Bt.Click += new System.EventHandler(this.Home_A_Bt_Click);
            // 
            // Back_A_bt
            // 
            this.Back_A_bt.Location = new System.Drawing.Point(497, 595);
            this.Back_A_bt.Name = "Back_A_bt";
            this.Back_A_bt.Size = new System.Drawing.Size(139, 58);
            this.Back_A_bt.TabIndex = 9;
            this.Back_A_bt.Text = "Back";
            this.Back_A_bt.UseVisualStyleBackColor = true;
            this.Back_A_bt.Click += new System.EventHandler(this.Back_A_bt_Click);
            // 
            // Form_Annc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 699);
            this.Controls.Add(this.Back_A_bt);
            this.Controls.Add(this.Home_A_Bt);
            this.Controls.Add(this.Create_A_Bt);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Annc";
            this.Text = "Form_Annc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Create_A_Bt;
        private System.Windows.Forms.Button Home_A_Bt;
        private System.Windows.Forms.Button Back_A_bt;
    }
}