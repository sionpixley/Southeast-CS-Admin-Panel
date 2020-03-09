using Admin_Control_Panel.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;


namespace Admin_Control_Panel
{
    public partial class Form_Art : Form
    {
        public Form_Art()
        {
            InitializeComponent();
        }

        private void Home_AR_bt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void Back_AR_bt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f1 = new Form2();
            f1.ShowDialog();
            this.Close();
        }

        private async void Submit_AR_bt_Click(object sender, EventArgs e)
        {
            string subject = textBox1.Text;
            string description = textBox2.Text;

            var obj = new Dictionary<string, string>
            {
                { "subject", subject },
                { "description", description }
            };
            string json = JsonConvert.SerializeObject(obj);

            var uri = new Uri(string.Format(ApiClient.uriBase + "add-article/", string.Empty));
            try
            {
                var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await ApiClient.httpClient.PostAsync(uri, httpContent);

                if(response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Article created.");
                    textBox1.Clear();
                    textBox2.Clear();
                }
                else if(response.StatusCode == System.Net.HttpStatusCode.Found)
                {
                    MessageBox.Show("Article already exists.");
                }
                else
                {
                    MessageBox.Show("Error. Form_Art.cs Submit_AR_bt_Click() try1");
                }
            }
            catch
            {
                MessageBox.Show("Error. Form_Art.cs Submit_AR_bt_Click() catch1");
            }
        }
    }
}
