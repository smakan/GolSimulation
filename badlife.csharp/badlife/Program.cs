using System;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;
using System.Threading;

namespace badlife
{
    /// <summary>
    /// Implements Conway's Game Of Life badly
    /// https://en.wikipedia.org/wiki/Conway%27s_Game_of_Life on a torus
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            var configuration = new AppConfiguration(ConfigurationManager.AppSettings);

            var simulator = new GolSimulator(
                new FileReader(),
                configuration,
                new GolService(), 
                new OutputConverter());

            simulator.Run();

            Thread.Sleep(10000);
        }
    }
}
