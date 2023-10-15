using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MedvedevA.Sprint2.Task7.V12.Lib;

namespace Tyuiu.MedvedevA.Sprint2.Task7.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


           
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            bool res = ds.CheckDotInShadedArea(x, y);
            if (res == true)
            {
                Console.WriteLine("Точка входит в указанную область!");
            }
            else
            {
                Console.WriteLine("Точка НЕ входит в указанную область!");
            }
            Console.ReadLine();
        }
    }
}
