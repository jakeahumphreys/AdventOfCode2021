using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using JsonConverter = System.Text.Json.Serialization.JsonConverter;

namespace AdventOfCode2021.Days.Day_3
{
    public static class DayThree
    {
        public static void DayThreePartOne()
        {
            var diagnosticReports = File.ReadLines($"{AppDomain.CurrentDomain.BaseDirectory}..\\..\\..\\Days\\Day 3\\diagnosticReport.txt").ToList();


            var gammaValues = "";
            var epsilonValues = "";

            for (var column = 0; column < 12; column++)
            {
                var zerosInColumn = 0;
                var onesInColumn = 0;
                
                var bitsInColumn = new List<int>();
                
                foreach (var report in diagnosticReports)
                {
                    var reportBits = report.ToCharArray();
                    bitsInColumn.Add(Convert.ToInt32(char.GetNumericValue(reportBits[column])));
                }

                foreach(var bit in bitsInColumn)
                {
                    if (bit == 0)
                        zerosInColumn += 1;
                    
                    if (bit == 1)
                        onesInColumn += 1;
                }

                if (zerosInColumn > onesInColumn)
                {
                    gammaValues += 0;
                    epsilonValues += 1;
                }
                else
                {
                    gammaValues += 1;
                    epsilonValues += 0;
                }
            }

            var gammaAsInteger = Convert.ToInt32(gammaValues, 2);
            var epsilonAsInteger = Convert.ToInt32(epsilonValues, 2);
            
            Console.WriteLine(gammaAsInteger * epsilonAsInteger);
        }
    }
}