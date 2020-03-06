using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Control_Panel.Models
{
    public class Announcement
    {
        public int id { get; set; }
        public string author { get; set; }
        public DateTime authored_date { get; set; }
        public string subject { get; set; }
        public string description { get; set; }
    }
}
