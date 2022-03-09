using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieC
{
    public class Visitor
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Date { get; set; }
        public string Hour { get; set; }
        public string Minute { get; set; }
        public string MeetingPerson { get; set; }
        public string MeetingAim { get; set; }

        public Visitor(string Name, string Surname, string Mobile, string Email, string Date, string Hour, string Minute, string MeetingPerson, string MeetingAim)
        {
            

        }

    }

}
