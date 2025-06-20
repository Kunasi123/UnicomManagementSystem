using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment123.Models
{
    public class Marks
    {
        public int ID {  get; set; }
        public int Exam_Id { get; set; }
        public int Student_ID { get; set; }
        
     
        public int Score { get; set; }
        public int Subject_ID { get; set; }
    }
}
