using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Books.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace LibraryRazor.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<Book> books { get; set; }

        private ApiLibraryClient apiLibraryClient = new ApiLibraryClient();

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public async Task OnGet()
        {
             books =(List<Book>) await apiLibraryClient.GetBooks();
        }
    }
}
