using System;

namespace badlife
{
    public class GolSimulator : IGolSimulator
    {
        private readonly IFileReader _fileReader;
        private readonly IConfiguration _configuration;
        private readonly IGolService _service;
        private readonly IOutputConverter _converter;

        public GolSimulator(
            IFileReader fileReader,
            IConfiguration configuration,
            IGolService service,
            IOutputConverter converter)
        {
            _fileReader = fileReader;
            _configuration = configuration;
            _service = service;
            _converter = converter;
        }

        public void Run()
        {
            var input = _fileReader.ReadFile(_configuration.InputPath);

            var output = _service.Evolve(input);

            var lines = _converter.Convert(output);
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}