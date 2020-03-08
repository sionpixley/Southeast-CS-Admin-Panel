namespace Admin_Control_Panel
{
    partial class Article_Edit
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
            this.btn_Home = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Change = new System.Windows.Forms.Button();
            this.txtbx_GenInfo = new System.Windows.Forms.TextBox();
            this.txtbx_Heading = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Home
            // 
            this.btn_Home.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Home.Location = new System.Drawing.Point(12, 110);
            this.btn_Home.Margin = new System.Windows.Forms.Padding(1);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(78, 34);
            this.btn_Home.TabIndex = 15;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = true;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Back.Location = new System.Drawing.Point(102, 110);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(1);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(78, 34);
            this.btn_Back.TabIndex = 14;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Change
            // 
            this.btn_Change.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Change.Location = new System.Drawing.Point(196, 110);
            this.btn_Change.Margin = new System.Windows.Forms.Padding(1);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(78, 34);
            this.btn_Change.TabIndex = 13;
            this.btn_Change.Text = "Change";
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // txtbx_GenInfo
            // 
            this.txtbx_GenInfo.Location = new System.Drawing.Point(111, 78);
            this.txtbx_GenInfo.Margin = new System.Windows.Forms.Padding(1);
            this.txtbx_GenInfo.Name = "txtbx_GenInfo";
            this.txtbx_GenInfo.Size = new System.Drawing.Size(142, 20);
            this.txtbx_GenInfo.TabIndex = 12;
            // 
            // txtbx_Heading
            // 
            this.txtbx_Heading.Location = new System.Drawing.Point(111, 48);
            this.txtbx_Heading.Margin = new System.Windows.Forms.Padding(1);
            this.txtbx_Heading.Name = "txtbx_Heading";
            this.txtbx_Heading.Size = new System.Drawing.Size(142, 20);
            this.txtbx_Heading.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(35, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Heading:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(26, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Gen. Info:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 15.9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(58, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Edit Article Info";
            // 
            // Article_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 152);
            this.Controls.Add(this.btn_Home);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.txtbx_GenInfo);
            this.Controls.Add(this.txtbx_Heading);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Article_Edit";
            this.Text = "Article_Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.TextBox txtbx_GenInfo;
        private System.Windows.Forms.TextBox txtbx_Heading;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}