using StudentsRazorApp.Models;
using System;
using System.Collections.Generic;

namespace StudentsRazorApp.Services
{
    public interface IstudentsRepo
    {
        IEnumerable<Student> GetallStudents();
        Student GetallStudentsbyID(int ID);
    }
}
