using _6_1_dars_ef_core.Data;
using _6_1_dars_ef_core.Dtos;
using _6_1_dars_ef_core.Entities;
using Microsoft.EntityFrameworkCore;

namespace _6_1_dars_ef_core.Services;

public class BookService : IBookService
{
    private readonly AppDbContext _context;

    public BookService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<long> AddAsync(BookCreateDto bookCreateDto)
    {
        var book = new Book()
        {
            Author = bookCreateDto.Author,
            Name = bookCreateDto.Name,
            Price = bookCreateDto.Price
        };

        await _context.Books.AddAsync(book);
        await _context.SaveChangesAsync();

        return book.BookId; 
    }

    public async Task<List<BookDto>> GetAllAsync()
    {
        var books = await _context.Books.ToListAsync();
        return books.Select(b => new BookDto()
        {
            Author = b.Author,
            BookId = b.BookId,
            Name = b.Name,
            Price = b.Price
        }).ToList();
    }
}
