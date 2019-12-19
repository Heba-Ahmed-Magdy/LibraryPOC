using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Books.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibraryRazor.Pages.Shared
{
    public class EditModel : PageModel
    {
        private ApiLibraryClient ApiLibraryClient = new ApiLibraryClient();
        [BindProperty]
        public Book Book { get;  set; }

        public async Task OnGet(int Id)
        {
             Book = await ApiLibraryClient.GetBook(Id);
        }
        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
                return Page();
            Book = await ApiLibraryClient.UpdateBook(Book);
            return RedirectToPage("index");
        }
    }
}