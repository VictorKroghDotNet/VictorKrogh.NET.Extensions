namespace VictorKrogh.NET.Extensions.Runtime;

public class Throw
{
    public static void IfNull(object obj, string name)
    {
        if (obj == null)
        {
            throw new ArgumentNullException(name);
        }
    }
}