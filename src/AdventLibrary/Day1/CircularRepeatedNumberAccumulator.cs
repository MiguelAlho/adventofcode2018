namespace AdventLibrary.Day1
{
    public class CircularRepeatedNumberAccumulator
    {
        public int Analyse(string input)
        {
            int accumulated = 0;
            int halfwaypoint = input.Length / 2;

            //first half
            for (int i = 0; i < halfwaypoint; i++)
            {
                if (input[i] == input[halfwaypoint+i])
                {
                    accumulated += input[i] - '0';
                }
            }
            
            return accumulated * 2;
        }
    }
}