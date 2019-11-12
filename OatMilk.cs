using System;
using System.Collections.Generic;

namespace multifabriken
{
    public class OatMilk
    {
        public int fatContent;
        public int litre;

        public OatMilk()
        {
            Console.WriteLine("V�nligen ange fetthalt");
            fatContent = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("V�nligen ange volymen i liter");
            litre = Convert.ToInt16(Console.ReadLine());
        }
        public static void getOatMilks(List<OatMilk> oatmilk)
        {

            Console.WriteLine("---Best�llda Havremj�lk---");
            int count = 1;
            foreach (var oatmilks in oatmilk)
            {
                Console.WriteLine("Havremj�lk nr: " + count);
                Console.WriteLine("Fetthalt: " + oatmilks.fatContent);
                Console.WriteLine("Liter: " + oatmilks.litre);
                Console.WriteLine("--------------------------");
            }

        }
    }
}