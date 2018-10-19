using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypotenuse
{
    class Program
    {
        static void Main(string[] args)
        {

            double kenar_1 = 0, kenar_2 = 0, Hipotenüs = 0;
            Console.Write("1. Dik Kenarı Giriniz = ");
            kenar_1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2. Dik Kenarı Giriniz = ");
            kenar_2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hipotenüs = " + (Hipotenüs = Math.Pow(((Math.Pow(kenar_1, 2)) + (Math.Pow(kenar_2, 2))), 0.5)));



        }
    }
}
