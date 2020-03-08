using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_Control_Panel
{
    public partial class Article_Edit : Form
    {
        public Article_Edit()
        {
            InitializeComponent();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edit_Art e1 = new Edit_Art();
            e1.ShowDialog();
            this.Close();
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {

        }
    }
}
