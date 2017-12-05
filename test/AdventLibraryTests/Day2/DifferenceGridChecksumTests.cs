using AdventLibrary.Day2;
using Xunit;

namespace AdventLibraryTests.Day2
{
    public class DifferenceGridChecksumTests
    {
        [Fact]
        public void CanCalculateGridChecksum()
        {
            var input = @"
5 1 9 5
7 5 3
2 4 6 8
";
            DifferenceGridChecksumCalculator checksumCalculator = new DifferenceGridChecksumCalculator();
            int output = checksumCalculator.CalculateFor(input);

            Assert.Equal(18, output);
        }
    }
}
