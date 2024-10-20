using System.Numerics;

namespace AiSDZad1;
public class NewtonProduction
{
    public long counter { get; set; } = 0;
    public BigInteger count(int n, int m)
    {
        BigInteger value = 1;
        for (long i = 1; i <= m; i++)
        {
            counter++;
            value = BigInteger.Multiply(value, (n - i + 1));
            value = value / i;
        }
        return value;
    }
}
