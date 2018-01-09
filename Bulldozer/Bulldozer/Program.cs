﻿using System;

namespace Bulldozer
{
    class Program
    {
        static void Main(string[] args)
        {
            var dozer1 = new BullDozer("Yellow", "Mini");
            var dozer2 = new BullDozer("Red", "Large");


            Console.WriteLine("Bulldozer 1 is: " + dozer1.color);
            Console.WriteLine("Bulldozer 2 is: " + dozer2.color);
        }
    }

    public class BullDozer
    {
        public BullDozer (string _color, string _size)
        {
            this.color = _color;
            this.size = _size;
        }

        public string color { get; set; }
        public string size { get; set; }
    }
}
