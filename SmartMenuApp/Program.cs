using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartMenuLibrary;

namespace SmartMenuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Run();
        }

        private void Run()
        {
            SmartMenu menu = new SmartMenu();
            Console.WriteLine("For Dansk: Tryk 1");
            Console.WriteLine("For English: Press 2");

            int.TryParse(Console.ReadLine(), out int r);
            if (r != 1 && r != 2)
            {
                Console.WriteLine("det indtastede input findes ikke.");
                Console.ReadLine();
            }
            else
            {
                menu.Load(menu.ChooseLanguage(r));
                menu.Activate();
            }
        }
    }
}
