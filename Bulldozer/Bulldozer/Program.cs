using System;

namespace Bulldozer
{
    class Program
    {
        static void Main(string[] args)
        {
            var dozer = new BullDozer();
            dozer.color = "Yellow";
            dozer.size = "Mini";
            var dozer2 = new BullDozer();
            dozer2.color = "Red";
            dozer2.size = "Large";

            Console.WriteLine("Bulldozer is: " + dozer.color);
        }
    }

    public class BullDozer
    {
        public string color { get; set; }
        public string size { get; set; }
    }
}
