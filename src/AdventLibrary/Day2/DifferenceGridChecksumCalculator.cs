using System;
using System.Linq;

namespace AdventLibrary.Day2
{
    public class DifferenceGridChecksumCalculator
    {
        public int CalculateFor(string input)
        {
            var accumulated = 0;
            var lines = input.Split(new []{'\n','\r'}, StringSplitOptions.RemoveEmptyEntries);

            foreach (var line in lines)
            {
                var values = line.Split(new []{'\t',' '}, StringSplitOptions.RemoveEmptyEntries)
                                .Select(a => Convert.ToInt32(a));

                var min = 100000;
                var max = 0;

                foreach (var value in values)
                {
                    if (value < min)
                        min = value;
                    if (value > max)
                        max = value;
                }

                accumulated += max - min;
            }

            return accumulated;
        }
    }
}
