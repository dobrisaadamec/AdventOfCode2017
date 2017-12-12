using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AdventOfCode.Helpers
{
    public class Data
    {
        public static string[] GetPuzzleData(string day)
        {
            string dataPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"../../Data"));
            dataPath += "\\" + day + ".txt";

            string[] lines = System.IO.File.ReadAllLines(dataPath);
            return lines;
        }
    }
}
