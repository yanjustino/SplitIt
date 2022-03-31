namespace SplitIt;

public static class Split
{
    public static string SplitIt(this string text, int limit)
    {
        if (string.IsNullOrEmpty(text) || limit <= 0)
            throw new ArgumentNullException(nameof(text), "Text should not be null or empty.");

        return text;
    }
}