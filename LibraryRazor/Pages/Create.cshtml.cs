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

        public async Task<IActionResult> PostAsync()
        {
            if (!ModelState.IsValid)
                return Page();


        }

    }
}