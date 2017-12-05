using AdventLibrary.Day2;
using Xunit;

namespace AdventLibraryTests.Day2
{
    public class EvenlyDivisibleGridChecksumTests
    {
        [Fact]
        public void CanCalculateGridChecksum()
        {
            var input = @"
5 9 2 8
9 4 7 3
3 8 6 5
";
            EvenlyDivisibleGridChecksumCalculator checksumCalculator = new EvenlyDivisibleGridChecksumCalculator();
            int output = checksumCalculator.CalculateFor(input);

            Assert.Equal(9, output);
        }
    }
}