namespace Book_day7Assignment.Repository
{
    public interface IBookrepository
    {
        void AddBook(Book book);
        List<Book> GetAllBooks();

        List<Book> GetBooksByAuthor(string Autor);

        List<Book> GetBooksByLang(string lang);

        List<Book> GetBooksByYear(int year);

        void EditBook(Book book);

        void DeleteBook(int bookId);

        Book GetBooksByBookName(string name);

        Book GetBooksById(int id);
    }
}

