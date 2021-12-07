using System;
using System.IO;
using System.Linq;
using AdventOfCode2021.Helpers;

namespace AdventOfCode2021.Days.Day_2
{
    public class DayTwo
    {
        public static void Dive()
        {
            MethodTimer.StartTimer();
            var instructions = File.ReadLines($"{AppDomain.CurrentDomain.BaseDirectory}..\\..\\..\\Days\\Day 2\\instructions.txt").ToList();

            var depth = 0;
            var horizontalPosition = 0;

            foreach (var instruction in instructions)
            {
                var instructionBreakdown = instruction.Split(" ");

                var direction = instructionBreakdown[0];
                var amount = int.Parse(instructionBreakdown[1]);

                if (direction == "up")
                    depth -= amount;

                if (direction == "down")
                    depth += amount;

                if (direction == "forward")
                    horizontalPosition += amount;
            }

            Console.WriteLine(horizontalPosition * depth);
            Console.WriteLine(MethodTimer.StopTimerAndFetchResults());
        }
    }
}