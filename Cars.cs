using System;
using System.Collections.Generic;

namespace multifabriken
{
    public class Cars
    {
        public string licenseNumber;
        public string colour;
        public string carModel;

        public Cars()
        {
            Console.WriteLine("Please enter License Number");
            licenseNumber = Console.ReadLine();
            Console.WriteLine("Please enter Cars Colour");
            colour = Console.ReadLine();
            Console.WriteLine("Please enter Car Model");
            carModel = Console.ReadLine();

        }
        public static void getCars(List<Cars> cars)
        {
            Console.WriteLine("---Beställda Bilar---");
            int count = 1;
            foreach (var car in cars)
            {
                Console.WriteLine("Bil nr: " + count);
                Console.WriteLine("Regnr: " + car.licenseNumber);
                Console.WriteLine("Färg: " + car.colour);
                Console.WriteLine("Modell: " + car.carModel);
                Console.WriteLine("--------------------------");
            }
        }
    }
}