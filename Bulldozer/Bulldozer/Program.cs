using System;

namespace Bulldozer
{
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car();
            car1.Color = "Red";
            car1.Manufacturer = "Toyota";

            Console.WriteLine("car1 is " + car1.Color + " and is made by " + car1.Manufacturer);

            var saloonCar1 = new SaloonCar(2);
            var saloonCar2 = new SaloonCar(3, "Nissan");
            var saloonCar3 = new SaloonCar(4, "Ford", "Purple");

            Console.WriteLine("saloonCar1 has " + saloonCar1.NumberOfSeats + " seats");
            Console.WriteLine("saloonCar2 has " + saloonCar2.NumberOfSeats + " seats and is made by " + saloonCar2.Manufacturer);
            Console.WriteLine("saloonCar3 has " + saloonCar3.NumberOfSeats + " seats, is made by " + saloonCar3.Manufacturer + ", and is the color " + saloonCar3.Color);
        }
    }

}
