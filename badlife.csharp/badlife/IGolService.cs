namespace badlife
{
    public interface IGolService
    {
        bool[][] Evolve(bool[][] input);

        bool GetOutputCell(bool inputCell, int neighbours);
    }
}