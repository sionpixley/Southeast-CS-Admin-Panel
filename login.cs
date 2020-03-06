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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void txtbxUsername_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtbxPassword_TextChanged(object sender, EventArgs e)
        {
            txtbxPassword.PasswordChar = '*';
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string username, password;

            username = txtbxUsername.Text;
            password = txtbxPassword.Text;

            if ((username == "test") && (password == "test"))
            {
                this.Hide();
                Form1 f1 = new Form1();
                f1.ShowDialog();
                this.Close();
            }

            else
            {
                MessageBox.Show("Incorrect Username or Password entered.");
                txtbxUsername.Clear();
                txtbxPassword.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
