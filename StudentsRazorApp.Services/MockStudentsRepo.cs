using StudentsRazorApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace StudentsRazorApp.Services
{
    public class MockStudentsRepo : IstudentsRepo
    {
        private readonly List<Student> _StudentsList;

        public MockStudentsRepo()
        {
            _StudentsList = new List<Student>()
            {
                new Student(){StudentID=1, StudentName="Samu1",StudentBranches=Branch.IT,studentphoto="flower1.jpg"},
                new Student(){StudentID=2, StudentName="Samu2",StudentBranches=Branch.CS,studentphoto="flower2.jpg"},
                new Student(){StudentID=3, StudentName="Samu3",StudentBranches=Branch.EEE,studentphoto="flower3.jpg"},
                new Student(){StudentID=4, StudentName="Samu4",StudentBranches=Branch.Electrical,studentphoto="flower4.jpg"},
                new Student(){StudentID=5, StudentName="Samu5",StudentBranches=Branch.ETC}
            };
        }
        public IEnumerable<Student> GetallStudents()
        {
            return _StudentsList;
        }

        public Student GetallStudentsbyID(int ID)
        {
            return _StudentsList.FirstOrDefault(st => st.StudentID == ID);
        }
    }
}
