using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MedvedevA.Sprint2.Task0.V15.Lib
{
    public class DataService  
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            res[0] = x == y ;
            res[1] = x != y + 2830;
            res[2] = x < y + 2831;
            res[3] = x > y ;
            res[4] = x <= y ;
            res[5] = x >= y + 8000;
            return res;
        }
    }
}
