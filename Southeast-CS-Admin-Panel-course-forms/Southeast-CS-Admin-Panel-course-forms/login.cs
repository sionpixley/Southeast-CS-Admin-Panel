using Admin_Control_Panel.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
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

        private async void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = txtbxUsername.Text;
            string password = txtbxPassword.Text;
            password = ComputeSha256Hash(password);

            var obj = new Dictionary<string, string>
            {
                { "username", username },
                { "passwd", password }
            };
            string json = JsonConvert.SerializeObject(obj);

            var uri = new Uri(string.Format(ApiClient.uriBase + "validate-admin/", string.Empty));
            try
            {
                var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await ApiClient.httpClient.PostAsync(uri, httpContent);

                if(response.IsSuccessStatusCode)
                {
                    this.Hide();
                    Form1 f1 = new Form1();
                    f1.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password.");
                    txtbxUsername.Clear();
                    txtbxPassword.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Error. login.cs btnLogIn_Click() catch1");
            }
        }

        private static string ComputeSha256Hash(string data)
        {
            using(SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(data));
                StringBuilder builder = new StringBuilder();
                for(int i = 0; i < bytes.Length; i += 1)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
