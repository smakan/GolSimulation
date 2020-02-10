using System;
using System.IO;

namespace badlife
{
    public class FileReader : IFileReader
    {
        public bool[][] ReadFile(string path)
        {
            var input = new StreamReader(path);
            var all_text = input.ReadToEnd();
            var lines = all_text.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            var world = new bool[lines.Length][];
            for (int x = 0; x < lines.Length; ++x)
            {
                world[x] = new bool[lines[x].Length];
                for (int c = 0; c < lines[x].Length; c++)
                {
                    if (lines[x][c] == '_')
                    {
                        world[x][c] = false;
                    }
                    else if (lines[x][c] == '*')
                    {
                        world[x][c] = true;
                    }
                }
            }

            return world;
        }
    }
}