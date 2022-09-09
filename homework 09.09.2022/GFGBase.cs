﻿using System;

namespace homework_09._09._2022
{
    public class GFGBase
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