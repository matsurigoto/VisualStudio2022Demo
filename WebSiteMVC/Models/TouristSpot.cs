namespace WebSiteMVC.Models
{
    public class TouristSpot
    {
        // string Name, double DistanceFromHotel, bool hasParkingLot and Constructor
        public string Name { get; set; }
        public double DistanceFromHotel { get; set; }
        public bool HasParkingLot { get; set; }

        public TouristSpot(string name, double distanceFromHotel, bool hasParkingLot)
        {
            Name = name;
            DistanceFromHotel = distanceFromHotel;
            HasParkingLot = hasParkingLot;
        }
    }
}
