using System.Numerics;

namespace AiSDZad1;
public class newtonv1
{
    public long counter { get; set; }
    public BigInteger count(int n, int m)
    {
        var Factorial = new factorial();
        var value = BigInteger.Divide(Factorial.count(n), BigInteger.Multiply(Factorial.count(m), Factorial.count(n - m)));
        counter = Factorial.counter;
        return value;
    }
}
