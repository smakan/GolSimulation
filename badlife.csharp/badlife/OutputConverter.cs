using System;
using System.Collections.Generic;
using System.Linq;

namespace badlife
{
    public class OutputConverter : IOutputConverter
    {
        public string[] Convert(bool[][] grid)
        {
            IList<string> lines = new List<string>();

            for (int a = 0; a < grid.Length; a++)
            {
                string line = "";
                for (int b = 0; b < grid[0].Length; ++b)
                {
                    if (grid[a][b])
                        line = line + "*";
                    else
                    {
                        line = line + "_";
                    }
                }
                lines.Add(line);
            }

            return lines.ToArray();
        }
    }
}