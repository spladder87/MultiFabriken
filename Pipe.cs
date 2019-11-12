using System;
using System.Collections.Generic;

namespace multifabriken
{
    public class Pipe
    {
        public double diameter;
        public double lenght;

        public Pipe()
        {
            Console.WriteLine("Vänligen ange Diameter i cm");
            diameter = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Vänligen ange längden i cm");
            lenght = Convert.ToDouble(Console.ReadLine());
        }

        public static void getPipes(List<Pipe> pipes)
        {
            Console.WriteLine("---Beställda Rör---");
            int count = 1;
            foreach (var pipe in pipes)
            {
                Console.WriteLine("Rör nr: " + count);
                Console.WriteLine("Diameter: " + pipe.diameter);
                Console.WriteLine("Längd: " + pipe.lenght);
                Console.WriteLine("--------------------------");
            }
        }
    }
}