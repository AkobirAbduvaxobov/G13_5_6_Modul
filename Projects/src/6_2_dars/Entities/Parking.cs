namespace _6_2_dars.Entities;

public class Parking
{
    public long ParkingId { get; set; }
    public string Location { get; set; }
    public string ParkingName { get; set; }
    public long Floor { get; set; }

    //public ICollection<Car> Cars { get; set; }
    public ICollection<CarParking> CarParkings { get; set; }
}
