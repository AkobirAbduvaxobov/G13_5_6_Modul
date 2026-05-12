using _6_1_dars_ef_core.Dtos;
using _6_1_dars_ef_core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _6_1_dars_ef_core.Controllers;

[Route("api/books")]
[ApiController]
public class BooksController : ControllerBase
{
    private readonly IBookService _bookService;

    public BooksController(IBookService bookService)
    {
        _bookService = bookService;
    }

    [HttpPost]
    public async Task<long> AddAsync(BookCreateDto bookCreateDto)
    {
        var id = await _bookService.AddAsync(bookCreateDto);
        return id;
    }

    [HttpGet]
    public async Task<List<BookDto>> GetAllAsync()
    {
        var books = await _bookService.GetAllAsync();
        return books;
    }
}