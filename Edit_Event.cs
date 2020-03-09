using Admin_Control_Panel.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;


namespace Admin_Control_Panel
{
    public partial class Edit_Event : Form
    {
        public Edit_Event()
        {
            InitializeComponent();
            getAllEvents();
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
            Event _event = (Event)Event_ListBox.SelectedItem;
            Event_Edit eve = new Event_Edit(_event);
            eve.ShowDialog();
            this.Close();
        }

        private async void btn_Delete_Click(object sender, EventArgs e)
        {
            Event evt = (Event)Event_ListBox.SelectedItem;

            var uri = new Uri(string.Format(ApiClient.uriBase + "remove-event-by-id/" + evt.id.ToString() + "/", string.Empty));
            try
            {
                HttpResponseMessage response = await ApiClient.httpClient.DeleteAsync(uri);

                if(response.IsSuccessStatusCode)
                {
                    getAllEvents();
                    MessageBox.Show("Event deleted.");
                }
                else if(response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show("Event does not exist.");
                }
                else
                {
                    MessageBox.Show("Error. Edit_Event.cs btn_Delete_Click() try1");
                }
            }
            catch
            {
                MessageBox.Show("Error. Edit_Event.cs btn_Delete_Click() catch1");
            }
        }

        private async void getAllEvents()
        {
            var uri = new Uri(string.Format(ApiClient.uriBase + "get-all-events/", string.Empty));
            try
            {
                HttpResponseMessage response = await ApiClient.httpClient.GetAsync(uri);

                if(response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    Event_ListBox.DataSource = JsonConvert.DeserializeObject<List<Event>>(content);
                    Event_ListBox.DisplayMember = "name";
                }
                else
                {
                    MessageBox.Show("Error. Edit_Event.cs getAllEvents() try1");
                }
            }
            catch
            {
                MessageBox.Show("Error. Edit_Event.cs getAllEvents() catch1");
            }
        }
    }
}
