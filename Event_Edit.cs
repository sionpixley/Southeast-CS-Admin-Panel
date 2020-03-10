using Admin_Control_Panel.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;


namespace Admin_Control_Panel
{
    public partial class Event_Edit : Form
    {
        private Event @event;

        public Event_Edit(Event _event)
        {
            InitializeComponent();
            txtbx_Name.Text = _event.name;
            txtbx_Location.Text = _event.location;
            txtbx_GenInfo.Text = _event.description;
            txtbx_Organization.Text = _event.organization;
            dtp_Date.Value = _event.date;
            @event = _event;
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
            Edit_Event e1 = new Edit_Event();
            e1.ShowDialog();
            this.Close();
        }

        private async void btn_Change_Click(object sender, EventArgs e)
        {
            string name = txtbx_Name.Text;
            string location = txtbx_Location.Text;
            string date = dtp_Date.Value.ToString("yyyy-MM-ddTHH:mm:ss");
            string description = txtbx_GenInfo.Text;
            string organization = txtbx_Organization.Text;

            var obj = new Dictionary<string, string>
            {
                { "name", name },
                { "location", location },
                { "date", date },
                { "description", description },
                { "organization", organization }
            };
            string json = JsonConvert.SerializeObject(obj);

            var uri = new Uri(string.Format(ApiClient.uriBase + "edit-event-by-id/" + @event.id.ToString() + "/", string.Empty));
            try
            {
                var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await ApiClient.httpClient.PostAsync(uri, httpContent);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Event successfully updated.");
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show("Event does not exist.");
                }
                else
                {
                    MessageBox.Show("Error. Event_Edit.cs btn_Change_Click() try1");
                }
            }
            catch
            {
                MessageBox.Show("Error. Event_Edit.cs btn_Change_Click() catch1");
            }
        }
    }
}
