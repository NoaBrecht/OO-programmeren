using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef_01
{
    internal class ExceptionHandling
    {
        public static void ToonSubmenu()
        {
            Console.WriteLine("");
            DemonstreerFoutafhandelingWeekdagenZonderException();
            
        }
        private static void DemonstreerFoutafhandelingWeekdagenZonderException()
        {
            string[] arr = new string[5];
            arr[0] = "Vrijdag";
            arr[1] = "Maandag";
            arr[2] = "Dinsdag";
            arr[3] = "Woensdag";
            arr[4] = "Donderdag";

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(arr[i].ToString());
            }
        }
    }
}
