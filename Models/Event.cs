using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Control_Panel.Models
{
    public class Event
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public string location { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string organization { get; set; }
    }
}
