using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Puzzles
{
    public class Day1
    {
        public static int Part1(string input)
        {
            var result = 0;
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == input[i - 1])
                {
                    result += (int)Char.GetNumericValue(input[i]);
                }
                ////zadnji kao prvi
                if (i == input.Length - 1 && input[0] == input[i])
                {
                    result += (int)Char.GetNumericValue(input[i]);
                }
            }
            return result;
        }

        public static int Part2(string input)
        {
            var result = 0;
            var half = input.Length / 2;

            for (int i = 0; i < input.Length; i++)
            {
                //Console.WriteLine(captcha[i]);
                var offset = (i + half) % input.Length;
                if (input[i] == input[offset])
                {
                    result += (int)Char.GetNumericValue(input[i]);
                }
               
            }

            return result;
        }
    }
    
}
