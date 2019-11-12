using System;
using System.Collections.Generic;

namespace multifabriken
{
    public class Candy
    {
        public string flavour;
        public int quantity;

        public Candy()
        {
            Console.WriteLine("V�nligen ange smak");
            flavour = Console.ReadLine();
            Console.WriteLine("V�nligen ange antal i siffror");
            quantity = Convert.ToInt16(Console.ReadLine());
        }

        public static void getCandys(List<Candy> candys)
        {
            Console.WriteLine("---Best�llda Godisar---");
            int count = 1;
            foreach (var candy in candys)
            {
                Console.WriteLine("Godis nr: " + count);
                Console.WriteLine("Smak: " + candy.flavour);
                Console.WriteLine("Antal: " + candy.quantity);
                Console.WriteLine("--------------------------");
            }
        }
    }
}