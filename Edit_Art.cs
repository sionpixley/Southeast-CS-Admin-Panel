using Admin_Control_Panel.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;


namespace Admin_Control_Panel
{
    public partial class Edit_Art : Form
    {
        public Edit_Art()
        {
            InitializeComponent();
            getAllArticles();
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
            Article article = (Article)Art_ListBox.SelectedItem;
            Article_Edit art = new Article_Edit(article);
            art.ShowDialog();
            this.Close();
        }

        private async void btn_Delete_Click(object sender, EventArgs e)
        {
            Article announcement = (Article)Art_ListBox.SelectedItem;

            var uri = new Uri(string.Format(ApiClient.uriBase + "remove-article-by-id/" + announcement.id.ToString() + "/", string.Empty));
            try
            {
                HttpResponseMessage response = await ApiClient.httpClient.DeleteAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    getAllArticles();
                    MessageBox.Show("Article deleted.");
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show("Article does not exist.");
                }
                else
                {
                    MessageBox.Show("Error. Edit_Art.cs btn_Delete_Click() try1");
                }
            }
            catch
            {
                MessageBox.Show("Error. Edit_Art.cs btn_Delete_Click() catch1");
            }
        }

        private async void getAllArticles()
        {
            var uri = new Uri(string.Format(ApiClient.uriBase + "get-all-articles/", string.Empty));
            try
            {
                HttpResponseMessage response = await ApiClient.httpClient.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    Art_ListBox.DataSource = JsonConvert.DeserializeObject<List<Article>>(content);
                    Art_ListBox.DisplayMember = "subject";
                }
                else
                {
                    MessageBox.Show("Error. Edit_Art.cs getAllArticles() try1");
                }
            }
            catch
            {
                MessageBox.Show("Error. Edit_Art.cs getAllArticles() catch1");
            }
        }
    }
}
