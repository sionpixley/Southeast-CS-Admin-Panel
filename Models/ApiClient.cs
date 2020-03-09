using System.Net.Http;


namespace Admin_Control_Panel.Models
{
    public static class ApiClient
    {
        public static HttpClient httpClient = new HttpClient();
        public static string uriBase = "http://10.91.91.127:8000/";
    }
}
