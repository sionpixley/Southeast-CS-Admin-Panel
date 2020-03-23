using Admin_Control_Panel.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;


namespace Admin_Control_Panel
{
    public partial class Course_Edit : Form
    {
        private Course course;
        
        public Course_Edit(Course cour)
        {
            InitializeComponent();
            textBox1.Text = cour.name;
            textBox2.Text = cour.number;
            textBox3.Text = cour.credits.ToString();
            textBox4.Text = cour.prerequisites;
            textBox5.Text = cour.availability;
            textBox6.Text = cour.description;
            course = cour;
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
            Edit_Cour f1 = new Edit_Cour();
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
                MessageBox.Show("Please enter an integer value for the credits field.");
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

            var uri = new Uri(string.Format(ApiClient.uriBase + "edit-course-by-id/" + course.id.ToString() + "/", string.Empty));
            try
            {
                var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await ApiClient.httpClient.PostAsync(uri, httpContent);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Course successfully updated.");
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show("Course does not exist.");
                }
                else
                {
                    MessageBox.Show("Error. Course_Edit.cs Submit_AR_bt_Click() try1");
                }
            }
            catch
            {
                MessageBox.Show("Error. Course_Edit.cs Submit_AR_bt_Click() catch1");
            }
        }
    }
}
