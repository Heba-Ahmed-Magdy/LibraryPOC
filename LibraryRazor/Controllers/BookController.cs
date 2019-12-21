using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LibraryRazor.Controllers
{
    public class BookController : Controller
    {
        private ApiLibraryClient apiLibrary = new ApiLibraryClient(); 
        [HttpPost]
        public async Task Remove(int id)
        {
            await apiLibrary.RemoveBook(id);
        }
    }
}