using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _6_2_dars.Entities;

public class Passport
{
    public long PassportId { get; set; }
    public string SeriaNumber { get; set; }
    public string Color { get; set; }
    public Person Person { get; set; }
    public long PersonId { get; set; }
}
