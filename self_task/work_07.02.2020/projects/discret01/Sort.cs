using System;

namespace Discret01
{
    class Sort
    {
        public static void Swap (ref int index01, ref int index02)
        {
            int tmp = index01;
            index01 = index02;
            index02 = tmp;
        }
        public static void Bubble(int[] array)
        {
            if (array == null || array.Length < 2)
                return;
            bool swapDetected = false;
            while (true)
            {
                swapDetected = false;
                for (int index = 0; index < array.Length - 1; index++)
                {
                    if (array[index] < array[index + 1])
                    {
                        Swap(ref array[index], ref array[index + 1]);
                        swapDetected = true;
                    }
                }
                if (!swapDetected)
                    break;
            }
        }

        public static void Selection(int[] array)
        {
            if (array == null || array.Length < 2)
                return;
            for (int index =0; index < array.Length; index++)
            {
                int minIndex = index;
                for (int next = index + 1; next < array.Length; next++)
                    if (array[minIndex] < array[next])
                        minIndex = next;
                if(minIndex != index)
                {
                    int tmp = array[index];
                    array[index] = array[minIndex];
                    array[minIndex] = tmp;
                }
            }
        }
    }
}
