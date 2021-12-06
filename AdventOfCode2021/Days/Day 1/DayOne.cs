using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AdventOfCode2021.Helpers;

namespace AdventOfCode2021.Days
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

        public static void SonarSweepAsSlidingMeasurement()
        {
            MethodTimer.StartTimer();
            int largerMeasurements = 0;
            var depthRecordings = File.ReadLines($"{AppDomain.CurrentDomain.BaseDirectory}..\\..\\..\\Days\\Day 1\\depthRecordings.txt").ToList().ConvertAll(int.Parse);

            var items = depthRecordings.Select((item, index) => new
            {
                Item = item,
                PrevItem = index > 0 ? depthRecordings[index - 1] : 0,
                NextItem = index < depthRecordings.Count - 1 ? depthRecordings[index + 1] : 0
            }).ToList();
            
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

                //Console.WriteLine($"{item.PrevItem} \t {item.Item} \t {item.NextItem}");
            }
            
            Console.WriteLine(largerMeasurements);
            Console.WriteLine(MethodTimer.StopTimerAndFetchResults());
        }
    }
}