using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Puzzles
{
    public class Day3
    {
        public static int Part1(int input)
        {
            var size = Math.Ceiling(Math.Sqrt(input));
            var center = Math.Ceiling((size - 1) / 2);
            return (int)Math.Max(0, center - 1 + Math.Abs(center - input % size));
        }

        public static int Part2(int input)
        {
            var result = 0;


            return result;
        }

        private class Cell
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int Value { get; set; }
        }
    }

}
