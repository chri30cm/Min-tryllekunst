using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunctionLibrary;

namespace SmartMenuLibrary
{
    public class Bindings
    {
        public static void Callid(string menu_id)
        {
            // Checker hvilken metoder der skal kaldes
            if (menu_id == "menu1")
            {
                Console.WriteLine(Functions.DoThis());
            }
            else if (menu_id == "menu2")
            {
                Console.WriteLine(Functions.DoThat());
            }
            else if (menu_id == "menu3")
            {
                Console.Write("Enter: ");
                string line = Console.ReadLine();
                Console.WriteLine(Functions.DoSomething(line));
            }
            else if (menu_id == "menu4")
            {
                Console.WriteLine(Functions.GetTheAnswerToLifeTheUniverseAndEverything());
            }
        }
    }
}  