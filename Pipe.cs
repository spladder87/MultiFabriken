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
            Console.WriteLine("V�nligen ange Diameter i cm");
            diameter = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("V�nligen ange l�ngden i cm");
            lenght = Convert.ToDouble(Console.ReadLine());
        }

        public static void getPipes(List<Pipe> pipes)
        {
            Console.WriteLine("---Best�llda R�r---");
            int count = 1;
            foreach (var pipe in pipes)
            {
                Console.WriteLine("R�r nr: " + count);
                Console.WriteLine("Diameter: " + pipe.diameter);
                Console.WriteLine("L�ngd: " + pipe.lenght);
                Console.WriteLine("--------------------------");
            }
        }
    }
}