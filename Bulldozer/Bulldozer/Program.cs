using System;

namespace Bulldozer
{
    class Program
    {
        static void Main(string[] args)
        {
            var man = new Man();
            var cart = new Cart();
            var alien = new Alien();
        }
    }

    public class GeneralObject
    {
        public GeneralObject()
        {
            
        }
        public bool moves { get; set; }
        public string color { get; set; }

    }

    // Man inherits from GeneralObject
    public class Man : GeneralObject
    {
        public Man ()
        {
        }
        public string name { get; set; }
    }

    public class Cart : GeneralObject
    {
        public Cart()
        {
        }
        public string manufacturer { get; set; }
    }

    public class Alien : GeneralObject
    {
        public Alien()
        {
        }
        public string planet { get; set; }
    }
}
