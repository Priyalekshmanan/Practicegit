using static Book_day7Assignment.Repository.Bookrepository;

namespace Book_day7Assignment.Repository
{
    public class Bookrepository
    {
        public class BookRepository : IBookrepository
        {
            public static List<Book> books = new List<Book>();
            //{
            //    //new Book{BookId=3245, BookName="Riya", Price=678.90,Author=" ",Language=" ",ReleaseDate='1/1/2000' },
            //    //    new Book{BookId=3245, BookName="Riya", Price=678.90,Author=" ",Language=" ",ReleaseDate='1/1/2000' },
            //};
            public void AddBook(Book book)
            {
                try
                {
                    books.Add(book);

                }
                catch (Exception)
                {

                    throw;
                }
            }

            public void DeleteBook(int bookId)
            {
                try
                {
                    foreach (var item in books)
                    {
                        if (item.BookId == bookId)
                        {
                            books.Remove(item);
                        }
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }

            public void EditBook(Book book)
            {
                try
                {
                    Book existing = null;
                    foreach (var item in books)
                    {
                        if (book.BookId == item.BookId)
                        {
                            existing = item;
                            break;


                        }
                    }
                    if (existing != null)
                    {
                        existing.Price = book.Price;
                        existing.ReleaseDate = book.ReleaseDate;
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }

            public List<Book> GetAllBooks()
            {
                try
                {
                    return books;
                }
                catch (Exception)
                {

                    throw;
                }
            }

            public List<Book> GetBooksByAuthor(string Autor)
            {
                try
                {
                    List<Book> getbookByAuthor = new List<Book>();
                    foreach (var item in books)
                    {
                        if (item.Author == Autor)
                            getbookByAuthor.Add(item);
                    }
                    return getbookByAuthor;
                }
                catch (Exception)
                {

                    throw;
                }
            }

            public List<Book> GetBooksByLang(string lang)
            {
                try
                {
                    List<Book> getbookBylang = new List<Book>();
                    foreach (var item in books)
                    {
                        if (item.Language == lang)
                            getbookBylang.Add(item);
                    }
                    return getbookBylang;
                }
                catch (Exception)
                {

                    throw;
                }
            }

            public List<Book> GetBooksByYear(int year)
            {
                try
                {

                    List<Book> bookyear = new List<Book>();
                    foreach (var item in books)
                    {
                        if (item.ReleaseDate.Year == year)
                            bookyear.Add(item);
                    }
                    return bookyear;
                }
                catch (Exception)
                {

                    throw;
                }
            }

            public Book GetBooksById(int id)
            {
                foreach (var book in books)
                {
                    if (book.BookId == id)
                    {
                        return book;
                    }
                }
                return null; // No matching book found
            }

            public Book GetBooksByBookName(string name)
            {
                foreach (var book in books)
                {
                    if (book.BookName == name)
                    {
                        return book;
                    }
                }
                return null; // No book with the specified name found
            }


        }
    }
}
