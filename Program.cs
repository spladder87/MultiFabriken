using System;
using System.Collections.Generic;
using System.Linq;

namespace multifabriken
{

    class Program
    {
        static void Main(string[] args)
        {
            List<string> menu = new List<string>();
            menu.Add("Beställ en bil");
            menu.Add("Beställ en godis");
            menu.Add("Beställ ett rör");
            menu.Add("Beställ Havre mjölk");
            menu.Add("Lista alla beställningar");
            menu.Add("Avsluta Programmet");
            List<Cars> cars = new List<Cars>();
            List<Candy> candy = new List<Candy>();
            List<Pipe> pipe = new List<Pipe>();
            List<OatMilk> oatMilk = new List<OatMilk>();


            bool running = true;

            while (running)
            {
                Console.WriteLine("\nVälkommen till Multifabriken");
                int count = 0;
                foreach (string menuItem in menu)
                {
                    count++;
                    Console.WriteLine($"[{count}]: {menuItem}");

                }
                Console.WriteLine("Välj:");

                string menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        Cars newCar = new Cars();
                        cars.Add(newCar);
                        break;
                    case "2":
                        Candy newCandy = new Candy();
                        candy.Add(newCandy);
                        break;
                    case "3":
                        Pipe newPipe = new Pipe();
                        pipe.Add(newPipe);
                        break;
                    case "4":
                        OatMilk newOatMilk = new OatMilk();
                        oatMilk.Add(newOatMilk);
                        break;
                    case "5":
                        if(cars.Any()){Cars.getCars(cars);}
                        if(candy.Any()){Candy.getCandys(candy);}
                        if(pipe.Any()){Pipe.getPipes(pipe);}
                        if(oatMilk.Any()){OatMilk.getOatMilks(oatMilk);}
                        break;
                    case "6":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Ange en siffra mellan 1-6");
                        break;


                }

            }

        }
    }
}
