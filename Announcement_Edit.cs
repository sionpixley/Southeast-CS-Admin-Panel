using Admin_Control_Panel.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;


namespace Admin_Control_Panel
{
    public partial class Announcement_Edit : Form
    {
        private Announcement ann;

        public Announcement_Edit(Announcement announcement)
        {
            InitializeComponent();
            txtbx_Name.Text = announcement.author;
            txtbx_Heading.Text = announcement.subject;
            txtbx_GenInfo.Text = announcement.description;
            ann = announcement;
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edit_Annc e1 = new Edit_Annc();
            e1.ShowDialog();
            this.Close();
        }

        private async void btn_Change_Click(object sender, EventArgs e)
        {
            string author = txtbx_Name.Text;
            string subject = txtbx_Heading.Text;
            string description = txtbx_GenInfo.Text;
            string authoredDate = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");

            var obj = new Dictionary<string, string>
            {
                { "author", author },
                { "authored_date", authoredDate },
                { "subject", subject },
                { "description", description }
            };
            string json = JsonConvert.SerializeObject(obj);

            var uri = new Uri(string.Format(ApiClient.uriBase + "edit-announcement-by-id/" + ann.id.ToString() + "/", string.Empty));
            try
            {
                var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await ApiClient.httpClient.PostAsync(uri, httpContent);

                if(response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Announcement successfully updated.");
                }
                else if(response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show("Announcement does not exist.");
                }
                else
                {
                    MessageBox.Show("Error. Announcement_Edit.cs btn_Change_Click() try1");
                }
            }
            catch
            {
                MessageBox.Show("Error. Announcement_Edit.cs btn_Change_Click() catch1");
            }
        }
    }
}
