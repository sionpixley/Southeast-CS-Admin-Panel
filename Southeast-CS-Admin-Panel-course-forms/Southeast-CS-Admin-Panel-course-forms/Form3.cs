using System;
using System.Windows.Forms;


namespace Admin_Control_Panel
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }



        private void AnncBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edit_Annc annc = new Edit_Annc();
            annc.ShowDialog();
            this.Close();
        }

        private void EventEditBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edit_Event eve = new Edit_Event();
            eve.ShowDialog();
            this.Close();
        }

        private void ArticleBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edit_Art art = new Edit_Art();
            art.ShowDialog();
            this.Close();
        }

        private void ContactBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edit_Con con = new Edit_Con();
            con.ShowDialog();
            this.Close();
        }

        private void HomeBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }
    }    
}
