using System.Text;

namespace SplitIt;

public static class Split
{
    public static string SplitIt(this string text, int limit)
    {
        if (string.IsNullOrEmpty(text) || limit <= 0)
            throw new ArgumentNullException(nameof(text), "Text should not be null or empty.");

        return text.SplitText(limit);
    }

    private static string SplitText(this string text, int limit)
    {
        var (result, words) = (new StringBuilder(), text.Split(' '));
        var (currentLine, separator) = (string.Empty, string.Empty);

        foreach (var word in words)
        {
            var next = currentLine + separator + word;
            
            if (next.Length > limit)
            {
                result.AppendLine(currentLine);
                currentLine = string.Empty;
                separator = string.Empty;
            }

            currentLine += separator + word;
            separator = " ";
        }

        result.Append(currentLine);
        return result.ToString();
    }
}