using System;
using System.IO;

namespace badlife.csharp.test
{
    using NUnit.Framework;
    
    public class FileReaderFixture
    {
        private IFileReader _reader;

        [SetUp]
        public void Setup()
        {
            _reader = new FileReader();
        }

        [Test]
        public void Test_ReadFile()
        {
            var result = _reader.ReadFile(string.Format("{0}/testInput.txt", GetCurrentPath()));

            var expected = new bool[][]
            {
                new bool[] {false, true, false},
                new bool[] {false, true, false},
                new bool[] {false, true, false}
            };
            Assert.AreEqual(expected, result);
        }

        private string GetCurrentPath()
        {
            return Path.GetDirectoryName(new Uri(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).LocalPath);
        }
    }
}