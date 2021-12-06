using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AdventOfCode2021.Helpers;

namespace AdventOfCode2021.Days.Day_1
{
    public static class DayOne
    {
        public static void SonarSweep()
        {
            MethodTimer.StartTimer();
            int largerMeasurements = 0;
            var depthRecordings = File.ReadLines($"{AppDomain.CurrentDomain.BaseDirectory}..\\..\\..\\Days\\Day 1\\depthRecordings.txt").ToList().ConvertAll(int.Parse);
            
            var previousDepth = 0;
            foreach (var depth in depthRecordings)
            {
                if (previousDepth != 0 && depth > previousDepth)
                    largerMeasurements += 1;

                previousDepth = depth;
            }
            
            Console.WriteLine(largerMeasurements);
            Console.WriteLine(MethodTimer.StopTimerAndFetchResults());
        }

        //Attempt using a for loop to calculate sums then iterate over those results.
        public static void SonarSweepAsSlidingMeasurement()
        {
            MethodTimer.StartTimer();
            int largerMeasurements = 0;
            var depthRecordings = File.ReadLines($"{AppDomain.CurrentDomain.BaseDirectory}..\\..\\..\\Days\\Day 1\\depthRecordings.txt").ToList().ConvertAll(int.Parse);
            
            var items = new List<DepthGroup>();
            for (var i = 0; i < depthRecordings.Count; i++)
            {
                items.Add(new DepthGroup
                {
                    Item = depthRecordings[i],
                    PrevItem = i > 0 ? depthRecordings[i - 1] : 0,
                    NextItem = i < depthRecordings.Count - 1 ? depthRecordings[i + 1] : 0
                });
            }

            items.RemoveAt(0);
            items.RemoveAt(items.Count -1);

            var previousSum = 0;
            foreach (var item in items)
            {
                var sum = item.PrevItem + item.Item + item.NextItem;

                if (previousSum != 0 && sum > previousSum)
                {
                    largerMeasurements += 1;
                }

                previousSum = sum;
            }
            
            Console.WriteLine(largerMeasurements);
            Console.WriteLine(MethodTimer.StopTimerAndFetchResults());
        }

        //attempt adding the sums up based on index (devised by the bman)
        public static void SimplerApproach()
        {
            MethodTimer.StartTimer();
            int largerMeasurements = 0;
            var depthRecordings = File.ReadLines($"{AppDomain.CurrentDomain.BaseDirectory}..\\..\\..\\Days\\Day 1\\depthRecordings.txt").ToList().ConvertAll(int.Parse);
            
            for (var i = 0; i < depthRecordings.Count; i++)
            {
                if (i + 4 > depthRecordings.Count)
                    break;

                var currentDepth = depthRecordings[i] + depthRecordings[i + 1] + depthRecordings[i + 2];
                var nextDepth = depthRecordings[i + 1] + depthRecordings[i + 2] + depthRecordings[i + 3];

                if (nextDepth > currentDepth)
                    largerMeasurements += 1;
            }
            
            Console.WriteLine(largerMeasurements);
            Console.WriteLine(MethodTimer.StopTimerAndFetchResults());
        }

        private class DepthGroup
        {
            public int Item { get; set; }
            public int PrevItem { get; set; }
            public int NextItem { get; set; }
        }
    }
}