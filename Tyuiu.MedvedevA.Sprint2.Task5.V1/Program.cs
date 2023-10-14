using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MedvedevA.Sprint2.Task5.V1.Lib;

namespace Tyuiu.MedvedevA.Sprint2.Task5.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int value;

            Console.WriteLine("Введите месяц: ");
            value = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Резултьтат: " + ds.FindMonthDaysCount(value));
            Console.ReadKey();
        }
    }
}
