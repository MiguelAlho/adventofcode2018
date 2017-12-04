namespace AdventLibrary.Day1
{
    public class RepeatedNumberAccumulator
    {
        public int Analyse(string input)
        {
            int accumulated = 0;

            for (int i = 0; i < input.Length-1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    accumulated += input[i] - '0';
                }
            }

            if (input[input.Length - 1] == input[0])
            {
                accumulated += input[0] - '0';
            }

            return accumulated;
        }
    }
}