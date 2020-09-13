using System;
using Xunit;
using Xunit.Abstractions;
using TelCo.ColorCoder;
namespace Manual.Tests
{
    public class ColorCodeTest
    {

        #region Methods
        private readonly ITestOutputHelper _output;

        public ColorCodeTest(ITestOutputHelper output)
        {
            this._output = output;
        }
        #endregion
        [Fact]
        public void ManualCorrectness()
        {
            string manual = ColorCodeData.manualToString();
            _output.WriteLine(manual);
            Assert.True(Test.CheckManualLength(manual));
            Assert.True(Test.CheckManual(manual));
        }
    }
}