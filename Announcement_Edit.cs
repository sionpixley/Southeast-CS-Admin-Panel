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
    public partial class Announcement_Edit : Form
    {
        public Announcement_Edit()
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
            Edit_Annc e1 = new Edit_Annc();
            e1.ShowDialog();
            this.Close();
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {

        }

        private void Announcement_Edit_Load(object sender, EventArgs e)
        {
            
        }
    }
}
