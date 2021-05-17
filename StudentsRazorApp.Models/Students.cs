using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsRazorApp.Models
{
   public  class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string studentphoto { get; set; }
        public Branch? StudentBranches { get; set; }

    }
}
