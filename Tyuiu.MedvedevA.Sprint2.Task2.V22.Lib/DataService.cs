using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MedvedevA.Sprint2.Task2.V22.Lib
{
    public class DataService : ISprint2Task2V22
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            return Convert.ToBoolean(Area.array[x, y]);
        }
        public static void PrintArea(int[,] array)
        {
            foreach (int i in Enumerable.Range(0, array.GetLength(0)))
            {
                foreach (int j in Enumerable.Range(0, array.GetLength(1)))
                {
                    if (array[i, j] == 0)
                    {
                        Console.Write("O ");
                    }
                    else if (array[i, j] == 1)
                    {
                        Console.Write("■ ");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("X ");
                        Console.ResetColor();
                    }
                }
                Console.WriteLine();
            }
        }
        public class Area
        {
            public static int[,] array =
            {
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, //1
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, //2
            { 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0 }, //3
            { 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0 }, //4
            { 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 }, //5
            { 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0 }, //6
            { 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0 }, //7
            { 0, 0, 0, 1, 1, 1, 0, 0, 1, 1, 0, 1, 1, 0, 0 }, //8
            { 0, 0, 0, 1, 1, 1, 0, 0, 1, 1, 0, 1, 0, 0, 0 }, //9
            { 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0 }, //10
            { 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0 }, //11
            { 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, //12
            { 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, //13
            { 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 }, //14
        };
        }
    }
    }

