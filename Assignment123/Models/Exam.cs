using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment123.Models
{
    public class Exam
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public DateTime  startTime { get; set; }
        public DateTime endTime { get; set; }
        public int Subject_ID { get; set; }
    }
}
