namespace Backoffice.Helpers;

public static class StringArrayConverter
{
    public static string[] ConvertFromString(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            return Array.Empty<string>();

        return value.Split(',');
    }

    public static string ConvertToString(string[] array)
    {
        if (array == null || array.Length == 0)
            return string.Empty;

        return string.Join(",", array);
    }
}
