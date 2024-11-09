using AppOrmEntity.Models;
namespace AppOrmEntity.Repositories;

public interface IBookRepository
{
    Book GetBookById(int id); 
    IEnumerable<Book> GetAllBooks();
    void AddBook(Book book);       
    void UpdateBook(Book book);    
    void DeleteBook(int id);       
}
