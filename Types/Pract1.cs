
using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_P58.Types
{
    internal class Pract1
    {
        public void Start()
        {
            //StartTask1();
            //StartTask2();
            StartTask3();
            City city = new()
            {
                Name = "Niko",
                Country = "UA",
                Citizens = 500_000,
                PhonePrefix = "+380512",
                Districts = ["Central", "Ingul"]
            };
        }

        class City
        {
            public String Name { get; set; } = "The City";
            public String Country { get; set; } = "The Country";
            public long Citizens { get; set; } = 100_000_000;
            public String PhonePrefix { get; set; } = "+380";
            public String[] Districts { get; set; } = ["Tairovo", "Poscot"];
        }

        private void StartTask3()
        {
            Console.Write("Task 3: Enter number: ");
            Random rnd = new();
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                arr[i] = rnd.Next(100);
            }
            Console.WriteLine($"Data: {String.Join(',', arr)}");
            Console.WriteLine("+/- to sort ASC/DESC ");
            ConsoleKeyInfo c = Console.ReadKey(true);
            if (c.KeyChar == '+')
            {
                Console.WriteLine($"ASC: {String.Join(',', SortAsc(arr))}");
            }
            else
            {
                Console.WriteLine($"DESC: {String.Join(',', SortDesc(arr))}");
            }
        }

        int[] SortAsc(int[] arr)
        {
            arr.Sort();
            return arr;
        }
        int[] SortDesc(int[] arr)
        {
            arr.Sort();
            return arr;
        }

        private void StartTask2()
        {
            Console.Write("Task 2: Enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(IsFibonacci(num) ? "Yes" : "No");
        }
        private bool IsFibonacci(int num)
        {
            // 1 1 Fn = Fn - 1 + Fn - 2
            // 1 1 2 3 5 8 13 21 ...
            long a = 1, b = 1;
            do
            {
                if (b == num) return true;
                (a, b) = (b, a + b);
            } while (b <= num);
            return false;
        }

        private void StartTask1()
        {
            Console.Write("Task 1: Enter range from: ");
            int rangeFrom = Convert.ToInt32(Console.ReadLine());
            Console.Write("Task 1: Enter range to: ");
            int rangeTo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" Product: {Task1(rangeFrom, rangeTo)}");
        }

        private long Task1(int rangeFrom, int rangeTo)
        {
            long res = 1;
            for(int i = Math.Min(rangeFrom, rangeTo); i <= Math.Max(rangeFrom,rangeTo); ++i)
            {
                res *= i;
            }
            return res;
        }
    }
}