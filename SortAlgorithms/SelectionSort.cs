using System.Runtime.CompilerServices;

namespace SortAlgorithms
{
    public static class SelectionSort
    {
        public static long[] Sort(long[] srcList)
        {
            for (int i = 0; i<srcList.Length-1; i++)
            {
                int indexMin = i;
                for (int j = i+1; j < srcList.Length; j++)
                {
                    if (srcList[indexMin] > srcList[j])
                    {
                        indexMin = j;
                    }
                }
                (srcList[indexMin], srcList[i]) = (srcList[i], srcList[indexMin]);
            }
            return srcList;
        }
    }
}