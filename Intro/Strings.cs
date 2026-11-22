
using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_P58.Intro
{
    /// <summary>
    /// Рядки, робота з рядками
    /// </summary>
    internal class Strings
    {
        public void Run()
        {
            string str = "";
            Random rnd = new();
            const Int32 N = 10;
            for (int i = 0; i < N; i++)
            {
                str += (char)rnd.Next(32, 127);
            }
            Console.WriteLine(str);
            // Більш ефективний алгоритм формування рядків
            StringBuilder sb = new();                   // StringBuilder схожий на зв'язаний список -
            for (int i = 0; i < N; i++)                 // він накопичує різні складові і потім
            {                                           // поєднує їх в рядок за один раз
                sb.Append( (char)rnd.Next(32, 127) );   // (формуючи один об'єкт - рядок).
            }
            str = sb.ToString();
            Console.WriteLine(str);

            // Альтернатива (в даній задачі) - масив символів
            char[] chars = new char[N];
            for (int i = 0;i < N; i++)
            {
                chars[i] = (char)rnd.Next(32, 127); 
            }
            str = new String(chars);
            Console.WriteLine(str);
            Console.WriteLine(chars.ToString());
            Console.WriteLine("------------------------------");
            // slices
            str = "Hello world!";
            Console.WriteLine(str[1]);                  // один симовл за індексом.
            Console.WriteLine(str[1..10]);              // slices - від індекса 1 (включно) до індекса 10 (не включно)
            Console.WriteLine(str[..10]);               // скорочена форма "від початку" (від 0 да 10)
            Console.WriteLine(str[1..]);                // скорочена форма "до кінця" (від 1 да кінця)
            Console.WriteLine(str[..^1]);                // відлік від кінця ^1 - перший від кінця (-1)
            // interpolation - включення до рядка значень змінних:
            // перед рядком сставимо символ "$", в середині змінні або вирази
            // змінні або вирази у {}
            Console.WriteLine($"Випадкове значення {rnd.Next()}");

            Console.WriteLine($"{str[..10]}{str[11..]}");

            Console.WriteLine($"{str[..9]}**{str[9..]}");

        }
    }
}

/* 
 Рядки у C# належать до незмінюваних типів (Immutable).
 Це означає, що змінити об'єкт не можна, можна лише збудувати інший об'єкт,
 беручі інший за джерело даних.
 -- всі операції з рядками призводять до створення нових рядків (як об'єктів)
 Зокрема, це робить неефективним циклічне додавання символів до рядка
 str = ""
 str += "1" - попереднє значення "" стає "сміттям"
 str += "2" - у смітті вже 2 об'єкти: "" та "1"
 str += "3" - "", "1", "12"
 ...
 str += "10": "", "1", "12", "123", ... "123456789" - 10 кинутих рядків загальним розміром 
                                        45 символів (N*(N-1)/2) - N^2 
 Якщо додавати 100 символів, то "сміття" стане ~ 5000 символів.
 Якщо 1000, то 500к.
   
*/