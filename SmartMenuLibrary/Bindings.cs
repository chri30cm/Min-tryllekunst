using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunctionLibrary;
using CalculatorLibrary;

namespace SmartMenuLibrary
{
    public class Bindings
    {
        public static void Callid(string menu_id)
        {
            if (menu_id == "menu1")
            {
                Console.WriteLine("Enter first number:");
                string lineadd = Console.ReadLine();
                Console.WriteLine("Enter second number;");
                string lineadd2 = Console.ReadLine();
                double.TryParse(lineadd, out double r);
                double.TryParse(lineadd2, out double r2);
                Console.WriteLine(Calculator.Add(r, r2));
            }
            else if (menu_id == "menu2")
            {
                Console.WriteLine("Enter first number:");
                string linesub = Console.ReadLine();
                Console.WriteLine("Enter second number:");
                string linesub2 = Console.ReadLine();
                double.TryParse(linesub, out double r);
                double.TryParse(linesub2, out double r2);
                Console.WriteLine(Calculator.Subtract(r, r2));
            }
            else if (menu_id == "menu3")
            {
                Console.WriteLine("Enter first number:");
                string linemulti = Console.ReadLine();
                Console.WriteLine("Enter second number:");
                string linemulti2 = Console.ReadLine();
                double.TryParse(linemulti, out double r);
                double.TryParse(linemulti2, out double r2);
                Console.WriteLine(Calculator.Multiply(r, r2));
            }
            else if (menu_id == "menu4")
            {
                Console.WriteLine("Enter first number:");
                string linediv = Console.ReadLine();
                Console.WriteLine("Enter second number:");
                string linediv2 = Console.ReadLine();
                double.TryParse(linediv, out double r);
                double.TryParse(linediv2, out double r2);
                Console.WriteLine(Calculator.Divide(r, r2));
            }


            else if (menu_id == "menu5")
            {
                List<double> numbers = new List<double>();
          
                while (double.TryParse(Console.ReadLine(), out double r) != false)
                {
                    numbers.Add(r);
                }

                Console.WriteLine(Calculator.Sum(numbers));
            }
        }
    }
}  