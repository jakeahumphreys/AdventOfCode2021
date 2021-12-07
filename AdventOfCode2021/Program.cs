using System;
using AdventOfCode2021.Days.Day_1;
using AdventOfCode2021.Days.Day_2;

namespace AdventOfCode2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a day to run.");

            var input = Console.ReadLine();

            switch (input)
            {
                case "1.1":
                    DayOne.SonarSweep();
                    break;
                case "1.2":
                    DayOne.SimplerApproach();
                    break;
                case "2.1":
                    DayTwo.Dive();
                    break;
            }
        }
    }
}