
using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_P58.Intro
{
    /// <summary>
    /// Масиви, багатомірні масиви, цикли.
    /// </summary>
    internal class Arrays
    {
        public void Run()
        {
            Console.WriteLine("Масиви, багатомірні масиви, цикли.");
            // На відміну від C++, масиви є об'єктами, які "обслуговуть"
            // послідовне однотипне сховище постійного розміру.
            int[] arr1 = new int[10];   // Базові 
            int[] arr2 = { 1, 2, 3 };   // Форми
            int[] arr3 = [1, 2, 3];     // Новий синтаксис (collection expression)
            foreach(int x  in arr1)     // Цикл ітератор - аналог for(int x : arr1)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
            //                    Наявність .Length додатково свідчить, що arr - це об'єкт.
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }
            Console.WriteLine();

            // Багатомірні масиви поділяються на дві групи:
            // 2D (multi - D) - "прямокутні" масиви, в яких по всіх вимірах однакові блоки
            // ******
            // ******
            // ******
            // Jagged - "рвані" масиви (масиви масивів), в яких по кожному виміру можуть бути 
            // різні довжини елементів.
            // *******
            // ***
            // ****
            int[,] arr2d1 = new int[3, 4]
            {
                {1,2,3,4},
                {2,3,4,5},
                {3,4,5,6}
            };
            int[,,] arr3d =
            {
                {{1,2}, {3,4}, {5,6}},
                {{1,2}, {3,4}, {5,6}},
                {{1,2}, {3,4}, {5,6}}
            };
            for (int i = 0; i < 3; i++) { 
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr2d1[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("==============================");
            // Jagged arrays
            int[][] jarr = new int[4][];
            jarr[0] = new int[2] { 1, 2 };
            jarr[1] = new int[4] { 1, 2, 3, 4 };
            jarr[2] = new int[3] { 1, 2, 3 };
            jarr[3] = new int[5] { 1, 2, 3, 4, 5 };
            foreach (int[] a in jarr) 
            {
                foreach (int x in a)
                {
                    Console.Write(x + " ");
                }
                Console.WriteLine();
            }
            Random rnd1 = new Random();     // Базовий синтаксис (повний)
            Random rnd2 = new();            // Новий синтаксис - якщо зазначено тип, то в new можна не повторювати
            var rnd3 = new Random();        // Автоматичне знаяення типу (var)

            Console.WriteLine(rnd1.Next(0, 100));
        }
    }
}