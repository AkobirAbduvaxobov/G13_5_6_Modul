using System.ComponentModel.DataAnnotations;

namespace _6_2_dars.Entities;

public class Person
{
    public long PersonId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public DateTime BirthDate { get; set; }
    public bool IsMarried { get; set; }

    public Passport Passport { get; set; }
    public ICollection<Car> Cars { get; set; }
}
