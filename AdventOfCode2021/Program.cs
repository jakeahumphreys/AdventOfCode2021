using System;
using AdventOfCode2021.Days.Day_1;
using AdventOfCode2021.Days.Day_2;
using AdventOfCode2021.Days.Day_3;

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
                    DayTwo.DayTwoPartOne();
                    break;
                case "2.2":
                    DayTwo.DayTwoPartTwo();
                    break;
                case "3.1":
                    DayThree.DayThreePartOne();
                    break;
            }
        }
    }
}