using Admin_Control_Panel.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;


namespace Admin_Control_Panel
{
    public partial class Article_Edit : Form
    {
        private Article art;

        public Article_Edit(Article article)
        {
            InitializeComponent();
            txtbx_Heading.Text = article.subject;
            txtbx_GenInfo.Text = article.description;
            art = article;
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
            Edit_Art e1 = new Edit_Art();
            e1.ShowDialog();
            this.Close();
        }

        private async void btn_Change_Click(object sender, EventArgs e)
        {
            string subject = txtbx_Heading.Text;
            string description = txtbx_GenInfo.Text;

            var obj = new Dictionary<string, string>
            {
                { "subject", subject },
                { "description", description }
            };
            string json = JsonConvert.SerializeObject(obj);

            var uri = new Uri(string.Format(ApiClient.uriBase + "edit-article-by-id/" + art.id.ToString() + "/", string.Empty));
            try
            {
                var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await ApiClient.httpClient.PostAsync(uri, httpContent);

                if(response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Article updated.");
                }
                else if(response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show("Article does not exist.");
                }
                else
                {
                    MessageBox.Show("Error. Article_Edit.cs btn_Change_Click() try1");
                }
            }
            catch
            {
                MessageBox.Show("Error. Article_Edit.cs btn_Change_Click() catch1");
            }
        }

        private void txtbx_GenInfo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
