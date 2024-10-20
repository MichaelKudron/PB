namespace AiSD_zad2_p1;
public class Naive
{
    public int counter = 0;
    public int count(int[] inputValues)
    {
        int bestLength = inputValues.Sum();
        int bestPositon = 0;
        for (int i = 0; i < inputValues.Length; i++)
        {
            int length = 0;
            for (int j = 0; j < inputValues.Length; j++)
            {
                if (i != j)
                {
                    length += Math.Abs(inputValues[i] - inputValues[j]);
                    counter++;

                }
            }
            if (length < bestLength)
            {
                bestPositon = i;
                bestLength = length;
            }
        }
        return bestPositon + 1;
    }
}
