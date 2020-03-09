using Admin_Control_Panel.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
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

        private async void Create_A_Bt_Click(object sender, EventArgs e)
        {
            string author = textBox1.Text;
            string authoredDate = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
            string subject = textBox2.Text;
            string description = textBox3.Text;

            var obj = new Dictionary<string, string>
            {
                { "author", author },
                { "authored_date", authoredDate },
                { "subject", subject },
                { "description", description }
            };
            string json = JsonConvert.SerializeObject(obj);

            var uri = new Uri(string.Format(ApiClient.uriBase + "add-announcement/", string.Empty));
            try
            {
                var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await ApiClient.httpClient.PostAsync(uri, httpContent);

                if(response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Announcement created.");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                }
                else if(response.StatusCode == System.Net.HttpStatusCode.Found)
                {
                    MessageBox.Show("Announcment already exists.");
                }
                else
                {
                    MessageBox.Show("Error. Form_Annc.cs Create_A_Bt_Click() try1");
                }
            }
            catch
            {
                MessageBox.Show("Error. Form_Annc.cs Create_A_Bt_Click() catch1");
            }
        }
    }
}
