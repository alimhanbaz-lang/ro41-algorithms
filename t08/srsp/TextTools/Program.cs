using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== ТЕСТИРОВАНИЕ TextTools ===");

        // Тесты CountWords
        RunTestCount("", 0);
        RunTestCount("    ", 0);
        RunTestCount(" a  b ", 2);
        RunTestCount("А роза упала на лапу Азора", 6);
        RunTestCount("Ахметов Ерлан", 2);

        // Тесты IsPalindrome
        RunTestPal("", true);
        RunTestPal("    ", true);
        RunTestPal("А роза упала на лапу Азора", true);
        RunTestPal("Ахметов Ерлан", false);

        // Тесты Initials
        RunTestInit("Ахметов Ерлан Серикұлы", "А. Е. С.");
        RunTestInit("Ахметов Ерлан", "А. Е.");
        RunTestInit("", "");

        // Тесты Repeat
        RunTestRep("abc", 3, "abcabcabc");
        RunTestRep("", 5, "");
        RunTestRep("test", 0, "");
    }

    static void RunTestCount(string input, int expected)
    {
        int actual = TextTools.CountWords(input);
        PrintResult($"CountWords(\"{input}\")", expected, actual);
    }

    static void RunTestPal(string input, bool expected)
    {
        bool actual = TextTools.IsPalindrome(input);
        PrintResult($"IsPalindrome(\"{input}\")", expected, actual);
    }

    static void RunTestInit(string input, string expected)
    {
        string actual = TextTools.Initials(input);
        PrintResult($"Initials(\"{input}\")", expected, actual);
    }

    static void RunTestRep(string s, int n, string expected)
    {
        string actual = TextTools.Repeat(s, n);
        PrintResult($"Repeat(\"{s}\", {n})", expected, actual);
    }

    static void PrintResult<T>(string testName, T expected, T actual)
    {
        bool pass = Equals(expected, actual);
        string status = pass ? "OK" : "FAIL";
        Console.WriteLine($"{testName} | Ожидание: \"{expected}\" | Факт: \"{actual}\" | [{status}]");
    }
}
