﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace InsertionSort
{
    class program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[] { 23, 9, 3 };
            int n = 3, i, j, val, flag;

            for (i = 0; i < n; i++)
            {
                val = arr[i];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;
                    }
                    else flag = 1;
                }
            }
            foreach (int ele in arr)
            {
                Console.WriteLine(ele);
            }

           
        }
    }
}
