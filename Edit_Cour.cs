using Admin_Control_Panel.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;


namespace Admin_Control_Panel
{
    public partial class Edit_Cour : Form
    {
        public Edit_Cour()
        {
            InitializeComponent();
            getAllCourses();
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
            Course course = (Course)Art_ListBox.SelectedItem;
            Course_Edit art = new Course_Edit(course);
            art.ShowDialog();
            this.Close();
        }

        private async void btn_Delete_Click(object sender, EventArgs e)
        {
            Course announcement = (Course)Art_ListBox.SelectedItem;

            var uri = new Uri(string.Format(ApiClient.uriBase + "remove-course-by-id/" + announcement.id.ToString() + "/", string.Empty));
            try
            {
                HttpResponseMessage response = await ApiClient.httpClient.DeleteAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    getAllCourses();
                    MessageBox.Show("Course deleted.");
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show("Course does not exist.");
                }
                else
                {
                    MessageBox.Show("Error. Edit_Cour.cs btn_Delete_Click() try1");
                }
            }
            catch
            {
                MessageBox.Show("Error. Edit_Cour.cs btn_Delete_Click() catch1");
            }
        }

        private async void getAllCourses()
        {
            var uri = new Uri(string.Format(ApiClient.uriBase + "get-all-courses/", string.Empty));
            try
            {
                HttpResponseMessage response = await ApiClient.httpClient.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    Art_ListBox.DataSource = JsonConvert.DeserializeObject<List<Course>>(content);
                    Art_ListBox.DisplayMember = "name";
                }
                else
                {
                    MessageBox.Show("Error. Edit_Cour.cs getAllCourses() try1");
                }
            }
            catch
            {
                MessageBox.Show("Error. Edit_Cour.cs getAllCourses() catch1");
            }
        }
    }
}
