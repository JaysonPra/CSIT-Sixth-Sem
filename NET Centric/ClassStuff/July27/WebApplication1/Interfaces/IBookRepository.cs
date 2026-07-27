using WebApplication1.Models;

namespace WebApplication1.Interfaces;

public interface IBookRepository
{
    public int AddBook(Book book);
    public int UpdateBook(Book book);
    public List<Book> GetAllBooks();
    public Book GetSingleBook(int id);
    public int DeleteBook(int id);
}