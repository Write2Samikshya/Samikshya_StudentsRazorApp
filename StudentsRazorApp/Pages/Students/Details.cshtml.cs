using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentsRazorApp.Models;
using StudentsRazorApp.Services;

namespace StudentsRazorApp.Pages.Students
{
    public class DetailsModel : PageModel
    {
        private readonly IstudentsRepo _istudentsrepo;

        public Student StudentsPropertyDetails { get; set; }
        public DetailsModel(IstudentsRepo istudentsRepo)
        {
           this._istudentsrepo = istudentsRepo;
        }
        public void OnGet(int ID)
        {
            StudentsPropertyDetails = _istudentsrepo.GetallStudentsbyID(ID);

        }
    }
}
