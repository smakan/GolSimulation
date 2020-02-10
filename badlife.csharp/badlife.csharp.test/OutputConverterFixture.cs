using System;
using NUnit.Framework;

namespace badlife.csharp.test
{
    public class OutputConverterFixture
    {
        private IOutputConverter _converter;

        [SetUp]
        public void Setup()
        {
            _converter = new OutputConverter();
        }

        [Test]
        public void Test_Convert()
        {
            var testGrid = new bool[][]
            {
                new bool[] {true, false, false},
                new bool[] {false, true, true}
            };

            var result = _converter.Convert(testGrid);

            var expected = new string[2];
            expected[0] = "*__";
            expected[1] = "_**";

            Assert.AreEqual(expected[0], result[0]);
            Assert.AreEqual(expected[1], result[1]);
        }
    }
}