using AdventLibrary.Day1;
using Xunit;

namespace Day1Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("1122", 3)]
        [InlineData("1111", 4)]
        [InlineData("1234", 0)]
        [InlineData("91212129", 9)]
        public void CanCalculateSumOfRepeatedNumbers(string input, int expectedSum)
        {
            RepeatedNumberAccumulator accumulator = new RepeatedNumberAccumulator();
            var output = accumulator.Analyse(input);

            Assert.Equal(expectedSum, output);
        }
    }
}
