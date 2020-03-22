using System.Net.Http;


namespace Admin_Control_Panel.Models
{
    public static class ApiClient
    {
        public static HttpClient httpClient = new HttpClient();
        public static string uriBase = "http://192.168.1.8:8000/";
    }
}
