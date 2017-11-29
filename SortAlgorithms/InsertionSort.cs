namespace SortAlgorithms
{
    public class InsertionSort
    {
        public static long[] Sort(long[] srcList)
        {
            for (int index = 1; index < srcList.Length; index++)
            {

                long temp = srcList[index];
                int aux = index - 1;

                while ((aux >= 0) && (srcList[aux] > temp))
                {
                    srcList[aux + 1] = srcList[aux];
                    aux--;
                }
                srcList[aux + 1] = temp;
            }
            return srcList;
        }
    }
}