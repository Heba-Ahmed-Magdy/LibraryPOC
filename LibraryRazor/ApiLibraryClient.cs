using Books.API.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LibraryRazor
{
    public class ApiLibraryClient
    {
        #region [Fields]
        private readonly HttpClient _httpClient;
        #endregion
        #region [Ctor]
        public ApiLibraryClient()
        { 
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:44367");
        }
        #endregion

        #region [Methods]
        public async Task<IEnumerable<Book>> GetBooks()
        {
            var response = await _httpClient.GetAsync("api/books");
            var content = await response.Content.ReadAsStringAsync();
            var books = JsonConvert.DeserializeObject<IEnumerable<Book>>(content);
             return books;
        }
        public async Task<Book> GetBook(int Id)
        {
            var response = await _httpClient.GetAsync($"api/books/{Id}");
            var content = await response.Content.ReadAsStringAsync();
            var book = JsonConvert.DeserializeObject<Book>(content);
            return book;
        }
        public async Task<Book> CreateBook(Book book)
        {
            var response =await _httpClient.PostAsync("api/books",
                new StringContent(JsonConvert.SerializeObject(book),Encoding.UTF8,"application/Json"));
            var content=await response.Content.ReadAsStringAsync();
             book = JsonConvert.DeserializeObject<Book>(content);
            return book;
        }

        #endregion

    }
}
