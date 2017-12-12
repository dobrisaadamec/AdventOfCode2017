using AdventOfCode.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Puzzles
{
    public class Day2
    {
        public static int Part1(string[] input)
        {
            var result = 0;
            foreach (var line in input)
            {
                var numbers = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToList();
                var rowResult = numbers.Max() - numbers.Min();
                result += rowResult;
            }
            return result;

            //smršavljena verzija
            //var grid = DataGrid.LoadArray(input);
            //return grid.Sum(item => item.Max() - item.Min());
        }

        public static int Part2(string[] input)
        {
            var result = 0;
            foreach (var line in input)
            {
                var numbers = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToList();
                foreach (var multiplier in numbers)
                {
                    foreach (var divider in numbers)
                    {
                        if (multiplier == divider) continue;
                        if (multiplier % divider == 0)
                        {
                            result += (multiplier / divider);
                        }
                    }
                }
            }
            return result;

            //smršavljena verzija
            //var grid = DataGrid.LoadArray(input);
            //return grid.Pairs().Where(x => x.Item1 % x.Item2 == 0).Sum(item => item.Item1 / item.Item2);
        }
    }
    
}
