using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment123.Models
{
    public class Timetable
    {
        public int Id { get; set; }
        public int Subject_ID { get; set; }
        public int Lecture_ID { get; set; }
        public int Room_ID { get; set; }
        public int Student_ID { get; set; }
        public int Time{ get;set; }
        public int Date { get; set; }

    }
}
