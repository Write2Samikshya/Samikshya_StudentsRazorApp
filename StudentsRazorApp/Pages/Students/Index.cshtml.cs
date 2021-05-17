using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentsRazorApp.Services;
using StudentsRazorApp.Models;

namespace StudentsRazorApp.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly IstudentsRepo _istudentsrepo;

        public IEnumerable<Student> StudentProperty { get; set; }
        public IndexModel(IstudentsRepo istudentsRepo)
        {
            this._istudentsrepo = istudentsRepo;
        }
        public void OnGet()
        {
            StudentProperty= _istudentsrepo.GetallStudents();
        }
    }
}
