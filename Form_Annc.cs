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
    public partial class Form_Annc : Form
    {
        public Form_Annc()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Home_A_Bt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void Back_A_bt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f1 = new Form2();
            f1.ShowDialog();
            this.Close();
        }
    }
}
