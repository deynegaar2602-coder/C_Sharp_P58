
using System.Text;

namespace C_Sharp_P58             // Простори імен групують класи
{
    internal class Program        // Весь код групується у класах (методах)
    {                             // Поза класами код не створюється
        static void Main(string[] args)     // Першим запускаєтсья даний метод
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("Платформа Microsoft.Net та мова програмування C#");
            //new Intro.VarsTypes().Run();    // Видаляти об'єкти немає потреби,
            // за це відповідає окремий модуль платформи - GC Garbage Collector
            //new Intro.Arrays().Run();
            new Intro.Strings().Run();
        }
    }
}

/*
 Платформа Microsoft .Net та мова програмування C#
 C# (C-Sharp) - мова 4 покоління (4GL), що базується на платформі .NET
 Загальна ідея:
 Програма мовою C# компілюється (транслюється) до проміжної мови MSIL
 (Microsoft Intermediate Langusge), схожою на Асемблер.
 Цей файл з проміжним кодом є виконавчим (.exe) і опрацьовується платформою,
 яка "на льоту" (just in time, JIT) докомпільовує його до процесного коду,
 який реально виконується.

 JScript-----\         |    |
 VisualBasics-\        |.NET|
 C# (text) --> MSIL -->| JIT| --> CPU
 F# ----------/        | CLR|
 C++.NET-----/         |    |
                      Managed   Unmanaged

 Така схема виконання дозволяє збирати мову програмування придатною
 для різних операційних платформ (Windows, Linux, Mac, Android, тощо)
 для яких випускаються різні збірки .NET, які приймаються однакові програми.

 IDE (Integrated Development Equipment - устаткування розробника)
  Microsoft Visual Studio
  Jetbrains Rider
  Mono
  VS Code

 CLR - Common Language Runtime - середовище виконання (спільне для різних мов)
 JIT - Just In Time Compiller - компілятор виконання (перетворювач IL коду до процесорного)
 FCL - Framework Class Library - набір бібліотек класів для використання у програмах .NET


*/