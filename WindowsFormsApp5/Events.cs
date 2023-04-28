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
        public int location;
        public int status;
        public int PO_id;

        public Events(int id, string name, string date, string time, int attendee_limit, string description, string categories, int location, int status, int PO_id)
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
            this.PO_id = PO_id;
        }

    }
}
