using System.Numerics;

namespace AiSDZad1;
public class newtonRecurent
{
    public long counter { get; set; } = 0;
    public BigInteger count(BigInteger n, BigInteger m)
    {
        if (m == 0 || m == n) return 1;
        counter++;
        return count(n - 1, m - 1) + count(n - 1, m);
    }
}
