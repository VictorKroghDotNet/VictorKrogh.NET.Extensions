namespace VictorKrogh.NET.Extensions.Runtime;

public static class Throw
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

    /// <summary>
    /// Throws an exception if <paramref name="obj"/> is null or only contains whitespaces.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="name"></param>
    /// <exception cref="ArgumentNullException"></exception>
    public static void IfNullOrWhitespace(string? value, string name)
    {
        if (value == null)
        {
            throw new ArgumentNullException(name);
        }

        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentNullException(name);
        }
    }
}