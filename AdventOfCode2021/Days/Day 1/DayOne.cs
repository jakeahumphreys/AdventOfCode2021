using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2021.Days
{
    public static class DayOne
    {
        public static void SonarSweep()
        {
            int largerMeasurements = 0;
            var depthRecordings = File.ReadLines($"{AppDomain.CurrentDomain.BaseDirectory}..\\..\\..\\Days\\Day 1\\depthRecordings.txt").ToList();

            var previousDepth = 0;
            foreach (var depth in depthRecordings)
            {
                var depthAsInt = int.Parse(depth);
                
                if (previousDepth != 0 && depthAsInt > previousDepth)
                {
                    largerMeasurements += 1;
                }
                
                previousDepth = depthAsInt;
            }
            
            Console.WriteLine(largerMeasurements);
        }
    }
}