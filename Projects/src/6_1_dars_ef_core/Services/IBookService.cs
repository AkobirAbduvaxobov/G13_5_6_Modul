using _6_1_dars_ef_core.Dtos;

namespace _6_1_dars_ef_core.Services;

public interface IBookService
{
    Task<long> AddAsync(BookCreateDto bookCreateDto);
    Task<List<BookDto>> GetAllAsync();
}