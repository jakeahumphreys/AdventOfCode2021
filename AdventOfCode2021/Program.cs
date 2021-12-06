using System;
using AdventOfCode2021.Days;

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
                case "1":
                    DayOne.SonarSweep();
                    break;
            }
        }
    }
}