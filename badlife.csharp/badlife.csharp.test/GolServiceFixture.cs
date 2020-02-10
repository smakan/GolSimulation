using System;
using System.Diagnostics.Eventing.Reader;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace badlife.csharp.test
{
    public class GolServiceFixture
    {
        private IGolService _service;

        [SetUp]
        public void Setup()
        {
            _service = new GolService();
        }

        [Test]
        public void Test_Evolve()
        {
            var testInput = new bool[][]
            {
                new bool[] {false, false, false, false, false},
                new bool[] {false, false, true, false, false},
                new bool[] {false, true, true, true, false},
                new bool[] {false, false, true, false, false},
                new bool[] {false, false, false, false, false}
            };

            var result = _service.Evolve(testInput);

            var expected = new bool[][]
            {
                new bool[] {false, false, false, false, false},
                new bool[] {false, true, true, true, false},
                new bool[] {false, true, false, true, false},
                new bool[] {false, true, true, true, false},
                new bool[] {false, false, false, false, false}
            };
            Assert.AreEqual(expected, result);
        }

        [TestCase(true, 1, false)]
        [TestCase(true, 4, false)]
        [TestCase(true, 2, true)]
        [TestCase(true, 3, true)]
        [TestCase(false, 3, true)]
        [TestCase(false, 5, false)]
        public void Test_GetOutputCell(bool inputCell, int aliveNeighbours, bool expectedOutputCell)
        {
            var result = _service.GetOutputCell(inputCell, aliveNeighbours);

            Assert.AreEqual(expectedOutputCell, result);
        }
    }
}
