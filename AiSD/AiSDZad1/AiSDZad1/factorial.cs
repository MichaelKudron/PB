using System.Numerics;

namespace AiSDZad1;
public class factorial
{
    public long counter { get; set; }
    public BigInteger count(int n)
    {
        BigInteger value = n--;
        while (n > 0)
        {
            value = BigInteger.Multiply(value, n);
            counter++;
            n--;
        }
        return value;
    }
}
