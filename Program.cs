using System;

namespace HW4
{
    class Program
    {
        static void Swap (ref int a, ref int b)
        { 
            int temp = a;
            a = b;
            b = temp;
        }

        static void ReturnSaveArrey(int[] array, int[] arraysave)
        {
            int i;
            for (i = 0; i < array.Length; i++)
            {
                array[i] = arraysave[i];
            }
        }

        static void WriteArray(int[] array)
        {
            int i;
            for (i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("  ");
        }

        static int GetMinNumber(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length ; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }

            return min;
        }

        static int GetMaxNumber(int[] array)
        {
            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }

            return max;
        }

        static string GetMinNumberIndex(int[] array)
        {
            int min = GetMinNumber(array);
            string minIndex = " ";

            for (int i = 0; i < array.Length ; i++)
            {
                if (min == array[i])
                {
                   minIndex+=" "+ i;
                }
            }

            return minIndex;
        }

        static string GetMaxNumberIndex(int[] array)
        {
            int max = GetMaxNumber(array);
            string maxIndex = "";

            for (int i = 0; i < array.Length ; i++)
            {
                if (max == array[i])
                {
                    maxIndex += " " + i;
                }
            }

            return maxIndex;
        }

        static int GetOddSum(int[] array)
        {
            int oddsum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i%2 !=0)
                {
                    oddsum += array[i];
                }
            }

            return oddsum;
        }

        static void ReverseArray(int[] array)
        {
            for (int i = 0; i < array.Length/2; i++)
            {
                Swap(ref array[i], ref array[array.Length-1 - i]);
            }
        }

        static int GetAmountOddNumbers(int[] array)
        {
            int oddsum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    oddsum ++;
                }
            }

            return oddsum;
        }

        static void SwapHalfArray(int[] array)
        {
            for (int i = 0; i < array.Length/2; i++)
            {
                Swap(ref array[i], ref array[array.Length/2+i]);
            }
        }

        static void SortingBubble(int[] array)
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
        }

        static void SortingInsertion(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int number = array[i];
                int index = i;
                while ((index > 0) && (array[index - 1] > number))
                {
                    Swap(ref array[index - 1], ref array[index]);
                    index--;
                }

                array[index] = number;
            }

        }

        static void Main(string[] args)
        {
            int[] array = new int[10];
            int[] arraysave = new int[10];
            Random random = new Random();
            int i = 0;

            for ( i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 10);
                arraysave[i] = array[i];
            }
            for (i = 0; i < array.Length; i++)
            {
                Console.WriteLine(i + " - " + array[i]);
            }
            Console.WriteLine(" ");

            int min = GetMinNumber(array);
            string minIndex = GetMinNumberIndex(array);
            int max = GetMaxNumber(array);
            string maxIndex = GetMaxNumberIndex(array);
            int oddsum = GetOddSum(array);
            int AmountOddNumbers = GetAmountOddNumbers(array);

            Console.WriteLine("Min"+"  "+min);
            Console.WriteLine("Max" + "  " + max);
            Console.WriteLine("MinIndex" + "  " + minIndex);
            Console.WriteLine("MaxIndex" + "  " + maxIndex);
            Console.WriteLine("OddSum" + "  " + oddsum);
            Console.WriteLine("AmountOddNumbers" + "  " + AmountOddNumbers);
            Console.WriteLine("  ");

            Console.WriteLine("Reverse Array");
            WriteArray(array);
            ReverseArray(array);
            WriteArray(array);
            ReturnSaveArrey(array, arraysave);
            Console.WriteLine("  ");

            Console.WriteLine("SwapHalfArray");
            WriteArray(array);
            SwapHalfArray(array);
            WriteArray(array);
            ReturnSaveArrey(array, arraysave);
            Console.WriteLine("  ");

            Console.WriteLine("SortingBubble");
            WriteArray(array);
            SortingBubble(array);
            WriteArray(array);
            ReturnSaveArrey(array, arraysave);
            Console.WriteLine("  ");

            Console.WriteLine("SortingInsertion");
            WriteArray(array);
            SortingInsertion(array);
            WriteArray(array);
        }
    }
}
