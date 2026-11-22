
using System;                      // using - using namespace
using System.Collections.Generic;  // не як include
using System.Text;

namespace C_Sharp_P58.Intro        // namespace може вкладатись (через ".")
{                                  // традиційно за іменем директорії
    // документуючий коментар - починається "///"
    /// <summary>
    /// Змінні та типи даних
    /// </summary>

    internal class VarsTypes // CapitalCamelCase - рекомендований стиль
    {
        public void Run()   // public - повторюється з кожним методом
        {
            Console.WriteLine("Змінні та типи даних");
            /* 
             У C#, на відміну від C++, суттєво змінюється поняття типу даних.
             Тип даних - це об'єкт, що містить інформацію про склад типу.
             Цей об'єкт можна одержувати під час роботи коду, діставати
             інформацію про його склад. Такі дії називають "рефлексією".

             Типи даних поділяються на дві великі групи:
             - за значенням (ValueTypes)
             - за посиланням (Reference Types)
             Відмінність між ними схожа на статичні та динамічні об'єкти у C++
            */
            int x = 10;  // псевдоним типу: int = System.int32
            System.Int32 y = x;
            // Value Types реалізуються структурами (struct)
            // для цих типів одразу задаються значення (x = 10)
            // змінні цих типів не можуть мати null, без значення набувають
            // спецівльного значення "default"
            int w;              // Ці два оголошення - суть
            int v = default;    // одне і те саме

            object obj1 = new Object();  // Reference Types - семантика переносу
            Object obj2 = obj1;          // obj2 це друге (з obj) посилання на єдиний об'єкт
            // зміни, внесині через будь - яку змінну (obj2 чи obj1), матимуть однаковий ефект
            // і відіб'ються на спільному об'єкті
            // Reference Types реалізуються класами (class)
            // для цих типів потрібне створення об'єкту (частіше за все new)
            // Без об'єкта змінні цих типів мають значення null
            object obj3 = default;
            object obj4 = null;
            object obj5;

            // Тим не менш, обидві групи типів походять від єдиного нащадка Object,
            // що призводить до того, що вони мають певний перелік спільних методів
            // зокрема, ToString(), який відповідає за рядкове подання об'єкту.

            double d = Convert.ToDouble(x);
            string str = "Привіт ";
            byte b = 10;
            short s = 100;
            long lng;
            char c = 'a';

            Console.Write("Ім'я: ");
            String Line = Console.ReadLine()!;
            Console.WriteLine(str + Line);

            Console.Write("Вік: ");
            Line = Console.ReadLine()!;
            b = Convert.ToByte(Line);
            Console.WriteLine("Ваш вік " + b);
            if (b <= 10)
            {
                Console.WriteLine("Child");
            }
            else if (b > 10 && b <= 19)
            {
                Console.WriteLine("Tennager");
            }
            else if (b > 10 && b <= 60)
            {
                Console.WriteLine("Adult");
            }
            else
            {
                Console.WriteLine("Old");
            }

        }
    }
}