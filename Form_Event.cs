using Admin_Control_Panel.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;


namespace Admin_Control_Panel
{
    public partial class Form_Event : Form
    {
        public Form_Event()
        {
            InitializeComponent();
        }

        private void Home_E_bt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void Back_E_bt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f1 = new Form2();
            f1.ShowDialog();
            this.Close();
        }

        private async void SubmitButton_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string location = textBox4.Text;
            string date = dateTimePicker1.Value.ToString("yyyy-MM-ddTHH:mm:ss");
            string description = textBox2.Text;
            string organization = textBox3.Text;

            var obj = new Dictionary<string, string>
            {
                { "date", date },
                { "location", location },
                { "name", name },
                { "description", description },
                { "organization", organization }
            };
            string json = JsonConvert.SerializeObject(obj);

            var uri = new Uri(string.Format(ApiClient.uriBase + "add-event/", string.Empty));
            try
            {
                var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await ApiClient.httpClient.PostAsync(uri, httpContent);

                if(response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Event created.");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                }
                else if(response.StatusCode == System.Net.HttpStatusCode.Found)
                {
                    MessageBox.Show("Event already exists.");
                }
                else
                {
                    MessageBox.Show("Error. Form_Event.cs SubmitButton_Click() try1");
                }
            }
            catch
            {
                MessageBox.Show("Error. Form_Event.cs SubmitButton_Click() catch1");
            }
        }
    }
}
