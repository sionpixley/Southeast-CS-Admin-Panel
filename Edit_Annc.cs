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
    public partial class Edit_Annc : Form
    {
        public Edit_Annc()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
            this.Close();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Annc annc = new Form_Annc();
            annc.ShowDialog();
            this.Close();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }
    }
}
