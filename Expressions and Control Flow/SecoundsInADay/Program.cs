﻿using System;

namespace SecoundsInADay
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;

            // Write a program that prints the remaining seconds (as an integer) from a
            // day if the current time is represented by the variables above

            int secondsPerMinute = 60;
            int minutesPerHour = 60;

            int allMinutes = secondsPerMinute * currentMinutes;
            int allHourse = (minutesPerHour * currentHours) * secondsPerMinute ;

            int totallSeconds = allHourse + allMinutes + currentSeconds;

            Console.WriteLine($"all togheter are equal to:{ totallSeconds } Seconds! ");
        }
    }
}

