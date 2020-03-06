namespace Admin_Control_Panel
{
    partial class Form1
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
            this.CreateRb = new System.Windows.Forms.RadioButton();
            this.Editrb = new System.Windows.Forms.RadioButton();
            this.ContBT = new System.Windows.Forms.Button();
            this.Exitbt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(942, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to ACP (Admin Control Panel)";
            // 
            // CreateRb
            // 
            this.CreateRb.AutoSize = true;
            this.CreateRb.Location = new System.Drawing.Point(328, 207);
            this.CreateRb.Name = "CreateRb";
            this.CreateRb.Size = new System.Drawing.Size(137, 36);
            this.CreateRb.TabIndex = 1;
            this.CreateRb.TabStop = true;
            this.CreateRb.Text = "Create";
            this.CreateRb.UseVisualStyleBackColor = true;
            // 
            // Editrb
            // 
            this.Editrb.AutoSize = true;
            this.Editrb.Location = new System.Drawing.Point(854, 207);
            this.Editrb.Name = "Editrb";
            this.Editrb.Size = new System.Drawing.Size(193, 36);
            this.Editrb.TabIndex = 2;
            this.Editrb.TabStop = true;
            this.Editrb.Text = "Edit/Delete";
            this.Editrb.UseVisualStyleBackColor = true;
            // 
            // ContBT
            // 
            this.ContBT.Location = new System.Drawing.Point(441, 377);
            this.ContBT.Name = "ContBT";
            this.ContBT.Size = new System.Drawing.Size(213, 45);
            this.ContBT.TabIndex = 3;
            this.ContBT.Text = "Continue";
            this.ContBT.UseVisualStyleBackColor = true;
            this.ContBT.Click += new System.EventHandler(this.ContBT_Click);
            // 
            // Exitbt
            // 
            this.Exitbt.Location = new System.Drawing.Point(737, 377);
            this.Exitbt.Name = "Exitbt";
            this.Exitbt.Size = new System.Drawing.Size(170, 45);
            this.Exitbt.TabIndex = 4;
            this.Exitbt.Text = "Exit";
            this.Exitbt.UseVisualStyleBackColor = true;
            this.Exitbt.Click += new System.EventHandler(this.Exitbt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 470);
            this.Controls.Add(this.Exitbt);
            this.Controls.Add(this.ContBT);
            this.Controls.Add(this.Editrb);
            this.Controls.Add(this.CreateRb);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton CreateRb;
        private System.Windows.Forms.RadioButton Editrb;
        private System.Windows.Forms.Button ContBT;
        private System.Windows.Forms.Button Exitbt;
    }
}

