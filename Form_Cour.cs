using Admin_Control_Panel.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;


namespace Admin_Control_Panel
{
    public partial class Form_Cour : Form
    {
        public Form_Cour()
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
            string name = textBox1.Text;
            string number = textBox2.Text;
            int credits = 0;
            bool wasSuccessful = int.TryParse(textBox3.Text, out credits);
            if(!wasSuccessful)
            {
                MessageBox.Show("Please use an integer value for credit field.");
                return;
            }
            string prerequisites = textBox4.Text;
            string availability = textBox5.Text;
            string description = textBox6.Text;

            var obj = new 
            {
                name,
                number,
                credits,
                prerequisites,
                availability,
                description
            };
            string json = JsonConvert.SerializeObject(obj);

            var uri = new Uri(string.Format(ApiClient.uriBase + "add-course/", string.Empty));
            try
            {
                var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await ApiClient.httpClient.PostAsync(uri, httpContent);

                if(response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Course created.");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                }
                else if(response.StatusCode == System.Net.HttpStatusCode.Found)
                {
                    MessageBox.Show("Course already exists.");
                }
                else
                {
                    MessageBox.Show("Error. Form_Cour.cs Submit_AR_bt_Click() try1");
                }
            }
            catch
            {
                MessageBox.Show("Error. Form_Cour.cs Submit_AR_bt_Click() catch1");
            }
        }
    }
}
