using System;
using System.Linq;

namespace AdventLibrary.Day2
{
    public class EvenlyDivisibleGridChecksumCalculator
    {
        public int CalculateFor(string input)
        {
            var accumulated = 0;
            var lines = input.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var line in lines)
            {
                var values = line
                    .Split(new[] { '\t', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(a => Convert.ToInt32((string) a))
                    .ToArray();


                for (int i = 0; i < values.Length; i++)
                {
                    for (int j = 0; j < values.Length; j++)
                    {
                        if (i != j
                            && values[i] >= values[j]
                            && values[i] % values[j] == 0)
                        {
                            accumulated += values[i] / values[j];
                        }
                    }
                }
            }

            return accumulated;
        }
    }
}