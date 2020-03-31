using System;

namespace ArraySelectSort
{
    class program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Select sort: ");
            int rd = 0;
            int n = 0;
            int tmp = 0;
            int smallest = 0;
            int[] arrInt;
            // int arrInt = new int[10] { 15, 95, 11, 54, 17, 26, 73, 14, 20, 03 };

            Console.WriteLine("Input N = ");
            try{
               n = Int16.Parse(Console.ReadLine()); 
            }catch(Exception e){
                Console.WriteLine(e.Message);
            }
            
            arrInt = new int[n];
            Random rd = new Random();

            Console.Write("Initial array: ");
            for (int i = 0; i < arrInt.Length(); i++)
            {
                arrInt[i] = rd.Next(1, 100);
            }

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
