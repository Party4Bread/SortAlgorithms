using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms
{
    public static class BubbleSort
    {
        public static long[] Sort(long[] srcList)
        {
            long temp = 0;
            for (int write = 0; write < srcList.Length; write++)
            {
                for (int sort = 0; sort < srcList.Length - 1; sort++)
                {
                    if (srcList[sort] > srcList[sort + 1])
                    {
                        (srcList[sort],srcList[sort + 1]) = (srcList[sort + 1],srcList[sort]);
                    }
                }
            }
            return srcList;
        }
    }
}
