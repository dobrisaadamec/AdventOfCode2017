using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Helpers
{
    public class DataGrid : List<List<int>>
    {
        public static DataGrid LoadArray(string[] input)
        {
            var res = new DataGrid();
            res.AddRange(input.Select(line => line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToList().ConvertAll(int.Parse)));
            return res;
        }

        public IEnumerable<Tuple<int, int>> Pairs()
        {
            foreach (var item in this)
            {
                for (var i = 0; i < item.Count; i++)
                {
                    for (var j = i + 1; j < item.Count; j++)
                    {
                        yield return item[i] > item[j]
                            ? new Tuple<int, int>(item[i], item[j])
                            : new Tuple<int, int>(item[j], item[i]);
                    }
                }
            }
        }
    }
}
