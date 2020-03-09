using Admin_Control_Panel.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;


namespace Admin_Control_Panel
{
    public partial class Contact_Edit : Form
    {
        private Contact contact;

        public Contact_Edit(Contact contact)
        {
            InitializeComponent();
            txtbx_Name.Text = contact.name;
            txtbx_Email.Text = contact.email;
            txtbx_Phone.Text = contact.phone;
            txtbx_Office.Text = contact.office;
            this.contact = contact;
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
            Edit_Con e1 = new Edit_Con();
            e1.ShowDialog();
            this.Close();
        }

        private async void btn_Change_Click(object sender, EventArgs e)
        {
            string name = txtbx_Name.Text;
            string email = txtbx_Email.Text;
            string phone = txtbx_Phone.Text;
            string office = txtbx_Office.Text;

            var obj = new Dictionary<string, string>
            {
                { "name", name },
                { "email", email },
                { "phone", phone },
                { "office", office }
            };
            string json = JsonConvert.SerializeObject(obj);

            var uri = new Uri(string.Format(ApiClient.uriBase + "edit-contact-by-id/" + contact.id.ToString() + "/", string.Empty));
            try
            {
                var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await ApiClient.httpClient.PostAsync(uri, httpContent);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Contact successfully updated.");
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show("Contact does not exist.");
                }
                else
                {
                    MessageBox.Show("Error. Contact_Edit.cs btn_Change_Click() try1");
                }
            }
            catch
            {
                MessageBox.Show("Error. Contact_Edit.cs btn_Change_Click() catch1");
            }
        }
    }
}
