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
        var sb = new StringBuilder();
        var tokens = text.Split(' ');
        var line = string.Empty;
        var sep = string.Empty;

        for (var i = 0; i < tokens.Length; i++)
        {
            var next = line + sep + tokens[i];
            if (next.Length > limit)
            {
                sb.AppendLine(line);
                line = string.Empty;
                sep = string.Empty;
            }
            
            line += sep + tokens[i];
            sep = " ";
        }

        sb.Append(line);
        
        return sb.ToString();

    }
}