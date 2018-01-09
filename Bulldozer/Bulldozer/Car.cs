namespace Bulldozer
{
    public class Car
    {
        public Car()
        {

        }

        public string Color { get; set; }
        public string Manufacturer { get; set; }
    }

    // inheritance
    public class SaloonCar : Car
    {
        public int NumberOfSeats { get; set; }

        // polymorphism
        public SaloonCar(int numberOfSeats)
        {
            this.NumberOfSeats = numberOfSeats;
        }

        public SaloonCar(int numberOfSeats, string manufacturer)
        {
            this.NumberOfSeats = numberOfSeats;
            this.Manufacturer = manufacturer;
        }

        public SaloonCar(int numberOfSeats, string manufacturer, string color)
        {
            this.NumberOfSeats = numberOfSeats;
            this.Manufacturer = manufacturer;
            this.Color = color;
        }
    }


}