using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_map.entities
{
    public class Student : CommunityMember
    {
        public string StudentID { get; set; }
        public string career { get; set; }
        public int AdmissionYear { get; set; }
        public int Semester { get; set; }
        public string academicStatus { get; set; }
    }
}
