using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercises
{
    internal class DateTimeExersices
    {
        public static void ShowSubmenu()
        {
            Console.WriteLine("Uit te voeren oefening?");
            Console.WriteLine("1. H10-Clock");
            Console.WriteLine("2. H10-Birthday");
            Console.WriteLine("3. ");
            Console.WriteLine("4. ");
            Console.WriteLine("5. ");
            Console.WriteLine("6. ");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:H10_Clock();
                    break;
                case 2:
                    H10_Birthday();
                    break;
                default:
                    Console.WriteLine("Foutieve optie");
                    break;
            }
        }
        public static void H10_Clock()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()}");
                System.Threading.Thread.Sleep(1000);
            }
        }
        public static void H10_Birthday()
        {
            Console.Clear();
            Console.WriteLine("Geef je geboortedatum in");
            DateTime date = Convert.ToDateTime(Console.ReadLine());

        }

    }
}
