using AdventLibrary.Day1;
using Xunit;

namespace AdventLibraryTests.Day1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("1212", 6)]
        [InlineData("1221", 0)]
        [InlineData("123425", 4)]
        [InlineData("123123", 12)]
        [InlineData("12131415", 4)]
        public void CanCalculateSumOfRepeatedNumbers(string input, int expectedSum)
        {
            CircularRepeatedNumberAccumulator accumulator = new CircularRepeatedNumberAccumulator();
            var output = accumulator.Analyse(input);

            Assert.Equal(expectedSum, output);
        }
    }
}
