using Admin_Control_Panel.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;


namespace Admin_Control_Panel
{
    public partial class Edit_Con : Form
    {
        public Edit_Con()
        {
            InitializeComponent();
            getAllContacts();
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
            Contact contact = (Contact)Con_ListBox.SelectedItem;
            Contact_Edit con = new Contact_Edit(contact);
            con.ShowDialog();
            this.Close();
        }

        private async void btn_Delete_Click(object sender, EventArgs e)
        {
            Contact contact = (Contact)Con_ListBox.SelectedItem;

            var uri = new Uri(string.Format(ApiClient.uriBase + "remove-contact-by-id/" + contact.id.ToString() + "/", string.Empty));
            try
            {
                HttpResponseMessage response = await ApiClient.httpClient.DeleteAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    getAllContacts();
                    MessageBox.Show("Contact deleted.");
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show("Contact does not exist.");
                }
                else
                {
                    MessageBox.Show("Error. Edit_Con.cs btn_Delete_Click() try1");
                }
            }
            catch
            {
                MessageBox.Show("Error. Edit_Con.cs btn_Delete_Click() catch1");
            }
        }

        private async void getAllContacts()
        {
            var uri = new Uri(string.Format(ApiClient.uriBase + "get-all-contacts/", string.Empty));
            try
            {
                HttpResponseMessage response = await ApiClient.httpClient.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    Con_ListBox.DataSource = JsonConvert.DeserializeObject<List<Contact>>(content);
                    Con_ListBox.DisplayMember = "name";
                }
                else
                {
                    MessageBox.Show("Error. Edit_Con.cs getAllContacts() try1");
                }
            }
            catch
            {
                MessageBox.Show("Error. Edit_Con.cs getAllContacts() catch1");
            }
        }
    }
}
