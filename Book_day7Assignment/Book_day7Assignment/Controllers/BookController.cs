using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Book_day7Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository bookRepository;
        public BookController()
        {
            bookRepository = new BookRepository();
        }
        //end points
        [HttpPost("AddBook")] // to add new book
        public IActionResult Add(Book book)
        {
            try
            {
                bookRepository.AddBook(book);
                return StatusCode(200, book);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpGet, Route("GetAllBooks")]  // to get all books
        public IActionResult GetAll()
        {
            try
            {
                List<Book> books = bookRepository.GetAllBooks();
                return StatusCode(200, books);
            }
            catch (Exception)
            {

                throw;
            }

        }

        [HttpGet("getBookByAuthor/{author}")] // to get all books by author
        public IActionResult GetBookByAuthor(string author)
        {
            try
            {
                return StatusCode(200, bookRepository.GetBooksByAuthor(author));
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }

        [HttpGet("getBookByLanguage/{lang}")]  // to get all books by language
        public IActionResult GetBookByLanguage(string lang)
        {
            try
            {
                return StatusCode(200, bookRepository.GetBooksByLang(lang));
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }

        [HttpGet("getBookbyyear/{year}")]
        public IActionResult GetBookByYear(int year)
        {
            try
            {
                return StatusCode(200, bookRepository.GetBooksByYear(year));

            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }


        [HttpPut("EditBook")] // Upadte book
        public IActionResult EditBook(Book book)
        {
            try
            {
                bookRepository.EditBook(book);
                return StatusCode(200, book);

            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }

        [HttpDelete("DeleteBook/{id}")] // delete book
        public IActionResult Delete(int id)
        {
            try
            {
                bookRepository.DeleteBook(id);
                return StatusCode(200, "Book deleted");
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpGet("GetbyBookId/{id}")] // get book by id
        public IActionResult getbybookid(int id)
        {
            try
            {
                var book = bookRepository.GetBooksById(id);
                if (book != null)
                {
                    return StatusCode(200, book); // Return the fetched book
                }
                return StatusCode(404, "Book not found"); // Handle the case when book is not found
            }
            catch (Exception ex)
            {
                return StatusCode(501, ex);
            }
        }

        [HttpGet("getbyBookName/{name}")] // get book by name
        public IActionResult getbybookname(string name)
        {
            try
            {
                var book = bookRepository.GetBooksByBookName(name);
                if (book != null)
                {
                    return StatusCode(200, book); // Return the fetched book
                }
                return StatusCode(404, "Book not found"); // Handle the case when book is not found
            }
            catch (Exception ex)
            {
                return StatusCode(501, ex);
            }
        }
    }
}
