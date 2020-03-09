using Admin_Control_Panel.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;


namespace Admin_Control_Panel
{
    public partial class Form_Con : Form
    {
        public Form_Con()
        {
            InitializeComponent();
        }

        private void Home_C_bt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void Back_C_bt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f1 = new Form2();
            f1.ShowDialog();
            this.Close();
        }

        private async void Submit_C_bt_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string email = textBox4.Text;
            string phone = textBox3.Text;
            string office = textBox2.Text;

            var obj = new Dictionary<string, string>
            {
                { "name", name },
                { "email", email },
                { "phone", phone },
                { "office", office }
            };
            string json = JsonConvert.SerializeObject(obj);

            var uri = new Uri(string.Format(ApiClient.uriBase + "add-contact/", string.Empty));
            try
            {
                var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await ApiClient.httpClient.PostAsync(uri, httpContent);

                if(response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Contact created.");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                }
                else if(response.StatusCode == System.Net.HttpStatusCode.Found)
                {
                    MessageBox.Show("Contact already exists.");
                }
                else
                {
                    MessageBox.Show("Error. Form_Con.cs Submit_C_bt_Click() try1");
                }
            }
            catch
            {
                MessageBox.Show("Error. Form_Con.cs Submit_C_bt_Click() catch1");
            }
        }
    }
}
