namespace SplitIt;

public static class Split
{
    
    public static string It(string text, int limit)
    {
        if (string.IsNullOrEmpty(text))
            throw new ArgumentNullException(nameof(text), "Text should not be null or empty.");

        return text;
    }
}