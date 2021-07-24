using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.API.Repository
{
    public interface IBookRepository
    {
        public List<BookModel> GetAllBooks();
        public BookModel GetBookById(int Id);
        public List<BookModel> SearchBook(string bookName, string author);
    }
}
