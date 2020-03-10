using System;
using System.Windows.Forms;


namespace Admin_Control_Panel
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void HomeBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void AnncBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Annc fa = new Form_Annc();
            fa.ShowDialog();
            this.Close();
        }

        private void EventBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Event fa = new Form_Event();
            fa.ShowDialog();
            this.Close();
        }

        private void ArticleBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Art fa = new Form_Art();
            fa.ShowDialog();
            this.Close();
        }

        private void ContactBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Con fa = new Form_Con();
            fa.ShowDialog();
            this.Close();
        }
    }
}
