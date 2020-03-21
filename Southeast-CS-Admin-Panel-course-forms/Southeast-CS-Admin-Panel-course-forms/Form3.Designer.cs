namespace Admin_Control_Panel
{
    partial class Form3
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
            this.HomeBt = new System.Windows.Forms.Button();
            this.ContactBt = new System.Windows.Forms.Button();
            this.ArticleBt = new System.Windows.Forms.Button();
            this.EventEditBt = new System.Windows.Forms.Button();
            this.AnncBt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HomeBt
            // 
            this.HomeBt.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.HomeBt.Location = new System.Drawing.Point(192, 187);
            this.HomeBt.Margin = new System.Windows.Forms.Padding(1);
            this.HomeBt.Name = "HomeBt";
            this.HomeBt.Size = new System.Drawing.Size(172, 47);
            this.HomeBt.TabIndex = 11;
            this.HomeBt.Text = "Home";
            this.HomeBt.UseVisualStyleBackColor = true;
            this.HomeBt.Click += new System.EventHandler(this.HomeBt_Click);
            // 
            // ContactBt
            // 
            this.ContactBt.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.ContactBt.Location = new System.Drawing.Point(311, 124);
            this.ContactBt.Margin = new System.Windows.Forms.Padding(1);
            this.ContactBt.Name = "ContactBt";
            this.ContactBt.Size = new System.Drawing.Size(172, 47);
            this.ContactBt.TabIndex = 10;
            this.ContactBt.Text = "Contact";
            this.ContactBt.UseVisualStyleBackColor = true;
            this.ContactBt.Click += new System.EventHandler(this.ContactBt_Click);
            // 
            // ArticleBt
            // 
            this.ArticleBt.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.ArticleBt.Location = new System.Drawing.Point(311, 63);
            this.ArticleBt.Margin = new System.Windows.Forms.Padding(1);
            this.ArticleBt.Name = "ArticleBt";
            this.ArticleBt.Size = new System.Drawing.Size(172, 47);
            this.ArticleBt.TabIndex = 9;
            this.ArticleBt.Text = "Courses";
            this.ArticleBt.UseVisualStyleBackColor = true;
            this.ArticleBt.Click += new System.EventHandler(this.ArticleBt_Click);
            // 
            // EventEditBt
            // 
            this.EventEditBt.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.EventEditBt.Location = new System.Drawing.Point(59, 124);
            this.EventEditBt.Margin = new System.Windows.Forms.Padding(1);
            this.EventEditBt.Name = "EventEditBt";
            this.EventEditBt.Size = new System.Drawing.Size(172, 47);
            this.EventEditBt.TabIndex = 8;
            this.EventEditBt.Text = "Event";
            this.EventEditBt.UseVisualStyleBackColor = true;
            this.EventEditBt.Click += new System.EventHandler(this.EventEditBt_Click);
            // 
            // AnncBt
            // 
            this.AnncBt.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.AnncBt.Location = new System.Drawing.Point(59, 63);
            this.AnncBt.Margin = new System.Windows.Forms.Padding(1);
            this.AnncBt.Name = "AnncBt";
            this.AnncBt.Size = new System.Drawing.Size(172, 47);
            this.AnncBt.TabIndex = 7;
            this.AnncBt.Text = "Announcement";
            this.AnncBt.UseVisualStyleBackColor = true;
            this.AnncBt.Click += new System.EventHandler(this.AnncBt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 15.9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Click on specified button to edit section";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 246);
            this.Controls.Add(this.HomeBt);
            this.Controls.Add(this.ContactBt);
            this.Controls.Add(this.ArticleBt);
            this.Controls.Add(this.EventEditBt);
            this.Controls.Add(this.AnncBt);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form3";
            this.Text = "Editing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HomeBt;
        private System.Windows.Forms.Button ContactBt;
        private System.Windows.Forms.Button ArticleBt;
        private System.Windows.Forms.Button EventEditBt;
        private System.Windows.Forms.Button AnncBt;
        private System.Windows.Forms.Label label1;
    }
}