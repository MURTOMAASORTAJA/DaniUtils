namespace DaniUtils;
public static class StringTools
{
    /// <summary>
    /// Returns the same as text.Split(delimiter)[0] would.
    /// </summary>
    public static string GetFirstHalf(this string text, string delimiter = ":")
    {
        if (string.IsNullOrEmpty(text) || !text.Contains(delimiter))
        {
            return "";
        }

        return text.Split(delimiter)[0];
    }

    /// <summary>
    /// Returns everything after the first occurrence of the delimiter.
    /// </summary>
    public static string GetOtherHalf(this string text, string delimiter = ":")
    {
        if (string.IsNullOrEmpty(text) || !text.Contains(delimiter))
        {
            return "";
        }

        var firsthalf = GetFirstHalf(text);
        return text.Substring(firsthalf.Length + delimiter.Length, text.Length - firsthalf.Length - delimiter.Length);
    }
}
