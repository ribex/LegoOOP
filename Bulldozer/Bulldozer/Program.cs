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

    public class Man
    {
        public Man ()
        {
        }
        public bool moves { get; set; }
        public string name { get; set; }
        public string color { get; set; }
    }

    public class Cart
    {
        public Cart()
        {
        }
        public bool moves { get; set; }
        public string manufacturer { get; set; }
        public string color { get; set; }
    }

    public class Alien
    {
        public Alien()
        {
        }
        public bool moves { get; set; }
        public string planet { get; set; }
        public string color { get; set; }
    }
}
