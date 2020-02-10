namespace badlife
{
    public class GolService : IGolService
    {
        public bool[][] Evolve(bool[][] input)
        {
            int neighbours = 0;
            var rows = input.Length;
            var cols = input[0].Length;
            bool[][] output = new bool[rows][];

            for (var g = 0; g < input.Length; ++g)
            {
                output[g] = new bool[input[0].Length];
                for (var k = 0; k < input[0].Length; ++k)
                {
                    // check how many alive neighbours for input[g][k]
                    if (input[g - 1 < 0 ? rows - 1 : g - 1][k - 1 < 0 ? cols - 1 : k - 1]) neighbours++;
                    if (input[g - 1 < 0 ? rows - 1 : g - 1][k]) neighbours++;
                    if (input[g - 1 < 0 ? rows - 1 : g - 1][k + 1 == cols ? 0 : k + 1]) neighbours++;

                    if (input[g][k - 1 < 0 ? cols - 1 : k - 1]) neighbours++;
                    if (input[g][k + 1 == cols ? 0 : k + 1]) neighbours++;

                    if (input[g + 1 == rows ? 0 : g + 1][k - 1 < 0 ? cols - 1 : k - 1]) neighbours++;
                    if (input[g + 1 == rows ? 0 : g + 1][k]) neighbours++;
                    if (input[g + 1 == rows ? 0 : g + 1][k + 1 == cols ? 0 : k + 1]) neighbours++;

                    // apply the rules for Game Of Life (GOL)
                    output[g][k] = GetOutputCell(input[g][k], neighbours);
                    
                    neighbours = 0;
                }
            }

            return output;
        }

        public bool GetOutputCell(bool inputCell, int neighbours)
        {
            bool outputCell = (inputCell && (neighbours == 2 || neighbours == 3)) || (!inputCell && neighbours == 3);

            return outputCell;
        }
    }
}