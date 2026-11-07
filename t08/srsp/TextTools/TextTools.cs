using System.Text;

public static class TextTools
{
    // 1. Количество слов (лишние пробелы не считаются)
    public static int CountWords(string s)
    {
        if (string.IsNullOrEmpty(s)) return 0;

        int count = 0;
        bool insideWord = false;

        for (int i = 0; i < s.Length; i++)
        {
            if (!char.IsWhiteSpace(s[i]))
            {
                if (!insideWord)
                {
                    count++;
                    insideWord = true;
                }
            }
            else
            {
                insideWord = false;
            }
        }
        return count;
    }

    // 2. Палиндром без учёта регистра и пробелов
    public static bool IsPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s)) return true;

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < s.Length; i++)
        {
            if (!char.IsWhiteSpace(s[i]))
            {
                sb.Append(char.ToUpperInvariant(s[i]));
            }
        }

        string cleaned = sb.ToString();
        for (int i = 0; i < cleaned.Length / 2; i++)
        {
            if (cleaned[i] != cleaned[cleaned.Length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }

    // 3. Инициалы ("Ахметов Ерлан Серикұлы" → "А. Е. С.")
    public static string Initials(string fullName)
    {
        if (string.IsNullOrWhiteSpace(fullName)) return string.Empty;

        StringBuilder sb = new StringBuilder();
        bool newWord = true;

        for (int i = 0; i < fullName.Length; i++)
        {
            char c = fullName[i];
            if (char.IsWhiteSpace(c))
            {
                newWord = true;
            }
            else if (newWord)
            {
                sb.Append(char.ToUpperInvariant(c));
                sb.Append(". ");
                newWord = false;
            }
        }

        if (sb.Length > 0)
        {
            sb.Length--; // Убираем последний лишний пробел
        }

        return sb.ToString();
    }

    // 4. Повторение строки n раз через StringBuilder
    public static string Repeat(string s, int n)
    {
        if (string.IsNullOrEmpty(s) || n <= 0) return string.Empty;

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < n; i++)
        {
            sb.Append(s);
        }
        return sb.ToString();
    }
}
