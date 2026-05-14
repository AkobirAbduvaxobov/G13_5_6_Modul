namespace _6_2_dars.Entities;

public class Car
{
    public long CarId { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }
    public decimal Price { get; set; }
    public string EngineNumber { get; set; }
    public string VinNumber { get; set; }
    public string FuelType { get; set; }

    public Person Person { get; set; }
    public long PersonId { get; set; }

    //public ICollection<Parking> Parkings { get; set; }
    public ICollection<CarParking> CarParkings { get; set; }
}
