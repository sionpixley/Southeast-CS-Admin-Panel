using Admin_Control_Panel.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;


namespace Admin_Control_Panel
{
    public partial class Edit_Annc : Form
    {
        public Edit_Annc()
        {
            InitializeComponent();
            getAllAnnouncements();
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
            Announcement announcement = (Announcement)Ann_ListBox.SelectedItem;
            Announcement_Edit e1 = new Announcement_Edit(announcement);
            e1.ShowDialog();
            this.Close();
        }

        private async void btn_Delete_Click(object sender, EventArgs e)
        {
            Announcement announcement = (Announcement)Ann_ListBox.SelectedItem;

            var uri = new Uri(string.Format(ApiClient.uriBase + "remove-announcement-by-id/" + announcement.id.ToString() + "/", string.Empty));
            try
            {
                HttpResponseMessage response = await ApiClient.httpClient.DeleteAsync(uri);

                if(response.IsSuccessStatusCode)
                {
                    getAllAnnouncements();
                    MessageBox.Show("Announcement deleted.");
                }
                else if(response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show("Announcement does not exist.");
                }
                else
                {
                    MessageBox.Show("Error. Edit_Annc.cs btn_Delete_Click() try1");
                }
            }
            catch
            {
                MessageBox.Show("Error. Edit_Annc.cs btn_Delete_Click() catch1");
            }
        }

        private async void getAllAnnouncements()
        {
            var uri = new Uri(string.Format(ApiClient.uriBase + "get-all-announcements/", string.Empty));
            try
            {
                HttpResponseMessage response = await ApiClient.httpClient.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    Ann_ListBox.DataSource = JsonConvert.DeserializeObject<List<Announcement>>(content);
                    Ann_ListBox.DisplayMember = "subject";
                }
                else
                {
                    MessageBox.Show("Error. Edit_Annc.cs getAllAnnouncements() try1");
                }
            }
            catch
            {
                MessageBox.Show("Error. Edit_Annc.cs getAllAnnouncements() catch1");
            }
        }
    }
}
