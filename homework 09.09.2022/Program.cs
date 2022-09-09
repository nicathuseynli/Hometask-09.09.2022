using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;

namespace homework_09._09._2022
{
    public class GFG
    {
        public static void Main(string[] args)
        {

        
            #region task 6

            static bool checkYear(int year)
            {
                // If a year is multiple of 400,
                // then it is a leap year
                if (year % 400 == 0)
                    return true;

                // Else If a year is multiple of 100,
                // then it is not a leap year
                if (year % 100 == 0)
                    return false;

                // Else If a year is multiple of 4,
                // then it is a leap year
                if (year % 4 == 0)
                    return true;
                return false;
            }

            // Driver method
              static void Main()
            {
                int year = 2000;
                Console.Write(checkYear(year) ? "Leap Year" :
                                         "Not a Leap Year");
            }
        }
    }
}
#endregion
#region Task 4
namespace CSharpExercises.Exercises.LINQ
{
    class Task4
    {
        public static void Main()
        {
            List<int> numbers = new List<int> { 78, -9, 0, 23, 54, 21, 7, 86 };

            var top5 = numbers.OrderByDescending(x => x).Take(5);

            foreach (var number in top5)
            {
                Console.Write($"{number} "); // 86,78,54,23,21
            }
        }
    }
}
#endregion
#region Task 1
internal class Task
{
    static void Main(string[] args)
    {
        Thread thread = Thread.CurrentThread;
        var secThread = new Thread(Method2);
        secThread.Start();
        Method1();
    }
    static void Method1()
    {
        for(int i = 0; i < 100; i++)
        {
            Console.WriteLine("Method1" + i);
            Thread.Sleep(150);
        }
    }
    static void Method2()
    {
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine("Method2" + i);
            Thread.Sleep(150);
        }
    }
}
#endregion
#region Task 2
public class Task2
{
    static async Task Main()
    {
        string Url = "https://catfact.ninja/fact";
        HttpClient http = new HttpClient();
        Console.WriteLine("Show me some facts");
        bool IsNext;
        do
        {
            var strignResult = await http.GetStringAsync(Url);
            Console.WriteLine(strignResult);
            IsNext = bool.Parse(Console.ReadLine());

        }while (IsNext);
    }
}
#endregion