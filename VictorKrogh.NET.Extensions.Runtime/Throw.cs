namespace VictorKrogh.NET.Extensions.Runtime;

public class Throw
{
    /// <summary>
    /// Throws an exception if <paramref name="obj"/> is null.
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="name"></param>
    /// <exception cref="ArgumentNullException"></exception>
    public static void IfNull(object obj, string name)
    {
        if (obj == null)
        {
            throw new ArgumentNullException(name);
        }
    }
}