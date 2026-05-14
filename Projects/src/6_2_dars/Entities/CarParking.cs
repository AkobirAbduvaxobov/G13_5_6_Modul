namespace _6_2_dars.Entities;

public class CarParking
{
    public long CarParkingId { get; set; }
    public long CarId { get; set; }
    public Car Car { get; set; }
    public long ParkingId { get; set; }
    public Parking Parking { get; set; }
}
