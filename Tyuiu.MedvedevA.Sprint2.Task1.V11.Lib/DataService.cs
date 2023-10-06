﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MedvedevA.Sprint2.Task1.V11.Lib
{
    public class DataService : ISprint2Task1V11
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a > b) | (c > b);
            res[1] = (a + 2 > b) & (c > b);
            res[2] = (a > b) || (c < b);
            res[3] = (a + 2 > b) && (c > b);
            res[4] = (!res[0]);
            res[5] = (a > b) ^ (c > b);
            return res;
           
        }
    }
}