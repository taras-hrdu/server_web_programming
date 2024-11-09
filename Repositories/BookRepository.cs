using System;
using AppOrmEntity.Context;
using AppOrmEntity.Models;
using System.Linq;
using System.Collections.Generic;

namespace AppOrmEntity.Repositories;

public class BookRepository : IBookRepository
{
    private readonly AppDbContext _context;

    public BookRepository(AppDbContext context)
    {
        _context = context;
    }

    public Book GetBookById(int id)
    {
        return _context.Books.FirstOrDefault(b => b.IdBook == id);
    }

    public IEnumerable<Book> GetAllBooks()
    {
        return _context.Books.ToList();
    }

    public void AddBook(Book book)
    {
        _context.Books.Add(book);
        _context.SaveChanges();
    }

    public void UpdateBook(Book book)
    {
        _context.Books.Update(book);
        _context.SaveChanges();
    }

    public void DeleteBook(int id)
    {
        var book = _context.Books.FirstOrDefault(x => x.IdBook == id);
        if (book != null)
        {
            _context.Books.Remove(book);
            _context.SaveChanges();
        }
    }
}
