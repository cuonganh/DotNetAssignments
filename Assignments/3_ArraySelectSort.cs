using System;

namespace ArraySelectSort
{
    class program
    {
        static void Main(String[] args)
        {
            int tmp = 0;
            int smallest = 0;
            int arrInt = new int[10] { 15, 95, 11, 54, 17, 26, 73, 14, 20, 03 };
            Console.WriteLine("Select sort: ");
            Console.Write("Initial array: ");

            for (int i = 0; i < arrInt.length(); i++)
            {
                Console.Write(arrInt[i] + " ");
            }

            for (int i = 0; i < arrInt.length() - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < arrInt.length(); j++)
                {
                    if (arrInt[smallest] > arrInt[j])
                    {
                        smallest = j;
                    }

                }

                tmp = arrInt[smallest];
                arrInt[smallest] = arrInt[j];
                arrInt[i] = tmp;
            }

            Console.Write("\nSelect sorted Array: ");
            for (int i = 0; i < arr.length(); i++)
            {
                Console.Write(arrInt[i] + " ");
            }

        }
    }
}

/*  Sorting an array means to arrange its elements in increasing order. 
    Write a program to sort an array. Use the "selection sort" algorithm
    */