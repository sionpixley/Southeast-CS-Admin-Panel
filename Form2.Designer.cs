namespace Admin_Control_Panel
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
            this.label1 = new System.Windows.Forms.Label();
            this.AnncBt = new System.Windows.Forms.Button();
            this.EventBt = new System.Windows.Forms.Button();
            this.ArticleBt = new System.Windows.Forms.Button();
            this.ContactBt = new System.Windows.Forms.Button();
            this.HomeBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click on specified button to create";
            // 
            // AnncBt
            // 
            this.AnncBt.Location = new System.Drawing.Point(71, 180);
            this.AnncBt.Name = "AnncBt";
            this.AnncBt.Size = new System.Drawing.Size(242, 50);
            this.AnncBt.TabIndex = 1;
            this.AnncBt.Text = "Announcement";
            this.AnncBt.UseVisualStyleBackColor = true;
            this.AnncBt.Click += new System.EventHandler(this.AnncBt_Click);
            // 
            // EventBt
            // 
            this.EventBt.Location = new System.Drawing.Point(359, 180);
            this.EventBt.Name = "EventBt";
            this.EventBt.Size = new System.Drawing.Size(159, 50);
            this.EventBt.TabIndex = 2;
            this.EventBt.Text = "Event";
            this.EventBt.UseVisualStyleBackColor = true;
            this.EventBt.Click += new System.EventHandler(this.EventBt_Click);
            // 
            // ArticleBt
            // 
            this.ArticleBt.Location = new System.Drawing.Point(568, 180);
            this.ArticleBt.Name = "ArticleBt";
            this.ArticleBt.Size = new System.Drawing.Size(159, 50);
            this.ArticleBt.TabIndex = 3;
            this.ArticleBt.Text = "Article";
            this.ArticleBt.UseVisualStyleBackColor = true;
            this.ArticleBt.Click += new System.EventHandler(this.ArticleBt_Click);
            // 
            // ContactBt
            // 
            this.ContactBt.Location = new System.Drawing.Point(772, 180);
            this.ContactBt.Name = "ContactBt";
            this.ContactBt.Size = new System.Drawing.Size(159, 50);
            this.ContactBt.TabIndex = 4;
            this.ContactBt.Text = "Contact";
            this.ContactBt.UseVisualStyleBackColor = true;
            this.ContactBt.Click += new System.EventHandler(this.ContactBt_Click);
            // 
            // HomeBt
            // 
            this.HomeBt.Location = new System.Drawing.Point(458, 375);
            this.HomeBt.Name = "HomeBt";
            this.HomeBt.Size = new System.Drawing.Size(156, 50);
            this.HomeBt.TabIndex = 5;
            this.HomeBt.Text = "Home";
            this.HomeBt.UseVisualStyleBackColor = true;
            this.HomeBt.Click += new System.EventHandler(this.HomeBt_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 477);
            this.Controls.Add(this.HomeBt);
            this.Controls.Add(this.ContactBt);
            this.Controls.Add(this.ArticleBt);
            this.Controls.Add(this.EventBt);
            this.Controls.Add(this.AnncBt);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AnncBt;
        private System.Windows.Forms.Button EventBt;
        private System.Windows.Forms.Button ArticleBt;
        private System.Windows.Forms.Button ContactBt;
        private System.Windows.Forms.Button HomeBt;
    }
}