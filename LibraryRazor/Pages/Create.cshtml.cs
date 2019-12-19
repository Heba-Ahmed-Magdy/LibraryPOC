using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Books.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibraryRazor
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Book Book { get; set; }
        public ApiLibraryClient apiLibraryClient = new ApiLibraryClient();

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
                return Page();
            var book=await apiLibraryClient.CreateBook(Book);
            return RedirectToPage("Index");

        }

    }
}