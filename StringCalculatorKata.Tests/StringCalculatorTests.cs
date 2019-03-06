using Xunit;

namespace StringCalculatorKata.Tests
{
    public class StringCalculatorTests
    {
        private StringCalculator underTest;

        public StringCalculatorTests()
        {
            underTest = new StringCalculator();
        }

        [Fact]
        public void Add_Returns_0_For_Empty_String()
        {
            var result = underTest.Add("");

            Assert.Equal(0, result);
        }

        [Theory()]
        [InlineData("1", 1)]
        [InlineData("2", 2)]
        public void Add_Returns_Epected_Output(string input, int expected)
        {
            var result = underTest.Add(input);

            Assert.Equal(expected, result);
        }
    }
}

