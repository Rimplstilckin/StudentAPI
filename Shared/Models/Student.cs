using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string IndexNumber { get; set; }
        public int PointsESPB { get; set; }
        public int StudyYear { get; set; }
        public decimal AverageMark { get; set; }
        public bool IsBudget { get; set; }
    }
}
