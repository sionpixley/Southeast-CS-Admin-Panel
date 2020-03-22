namespace Admin_Control_Panel.Models
{
    public class Course
    {
        public int id { get; set; }
        public string name { get; set; }
        public string number { get; set; }
        public int credits { get; set; }
        public string prerequisites { get; set; }
        public string availability { get; set; }
        public string description { get; set; }
    }
}
