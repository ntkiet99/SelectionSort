using System;

namespace ThuatToanD1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 7;
            int[] arr = new int[n];
            string input;
            Console.WriteLine("\t Thuat toan Insertion Sort");
            Console.WriteLine("Nhap du kieu: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap lan {0}: ", i + 1);
                input = Console.ReadLine();
                arr[i] = int.Parse(input);
            }
            Console.WriteLine("\nThuat toan:");
            Console.WriteLine("Lan {0}: " , 1);
            PrintArray(arr);
            int temp, smallest;
            for (int i = 0; i < n - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[smallest])
                    {
                        smallest = j;
                    }
                }
                temp = arr[smallest];
                arr[smallest] = arr[i];
                arr[i] = temp;
                Console.WriteLine("Lan {0}:" , i + 2);
                PrintArray(arr);
            }
            Console.Write("\nKet qua cuoi: ");
            PrintArray(arr);
            Console.ReadKey();
        }

        static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
