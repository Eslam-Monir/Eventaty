using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    public class Events
    {
        public int id;
        public string name;
        public string description;
        public string date;
        public string time;
        public int attendee_limit;
        //TODO
        public string categories;
        public string location;
        public int status;
 
      public Events(int id, string name, string date, string time, int attendee_limit, string description, string categories, string location, int status)
        {
    
            this.id = id;
            this.name = name;
            this.date = date;
            this.time = time;
            this.attendee_limit = attendee_limit;
            this.description = description;
            this.categories = categories;
            this.location = location;
            this.status = status;
        }

    }
}
