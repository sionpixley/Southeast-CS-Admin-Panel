using System;
using System.Windows.Forms;


namespace Admin_Control_Panel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ContBT_Click(object sender, EventArgs e)
        {
            if(CreateRb.Checked)
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
                this.Close();
            }
            else
            {
                this.Hide();
                Form3 f3 = new Form3();
                f3.ShowDialog();
                this.Close();
            }
        }

        private void Exitbt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
