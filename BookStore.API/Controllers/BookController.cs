using BookStore.API.Repository;
using BookStore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BookStore.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        //Commited
        private readonly IBookRepository _bookrepository = null;
        public BookController(IBookRepository bookRepository)
        {
            _bookrepository = bookRepository;
        }
        [HttpGet]
        public ActionResult<BookModel> GetAllBooks()
        {
            try
            {
                var data = _bookrepository.GetAllBooks();
                return Ok(data);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet]
        public ActionResult<BookModel> GetBook([FromQuery]int id)
        {
            try
            {
                var data = _bookrepository.GetBookById(id);
                return Ok(data);
            }
            catch (Exception)
            {

                throw;
            }            
        }
        [HttpGet]
        public List<BookModel> SearchBook([FromQuery]string strBookname, [FromQuery]string strAuthorName)
        {
            try
            {
                return _bookrepository.SearchBook(strBookname, strAuthorName);
            }
            catch (Exception)
            {

                throw;
            }            
        }
    }
}
