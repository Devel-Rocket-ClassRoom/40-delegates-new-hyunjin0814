using System;

// README.md를 읽고 코드를 작성하세요.

Console.WriteLine("=== 문자열 가공기 ===");
Console.WriteLine();

Console.WriteLine($"원본: Hello World");
Console.WriteLine();

Console.WriteLine("[대문자 변환]");
ProcessAndPrint("Hello World", ToUpperCase);
Console.WriteLine();

Console.WriteLine("[소문자 변환]");
ProcessAndPrint("Hello World", ToLowerCase);
Console.WriteLine();

Console.WriteLine("[괄호 추가]");
ProcessAndPrint("Hello World", AddBrackets);
Console.WriteLine();

Console.WriteLine("[문자열 뒤집기]");
ProcessAndPrint("Hello World", Reverse);

static string ToUpperCase(string s) => s.ToUpper();
static string ToLowerCase(string s) => s.ToLower();
static string AddBrackets(string s) => $"[{s}]";
static string Reverse(string s)
{
    char[] c = s.ToCharArray();

    for (int i = 0; i < c.Length / 2; i++)
    {
        char temp = c[i];
        c[i] = c[c.Length - 1 - i];
        c[c.Length - 1 - i] = temp;
    }

    return new string(c);
}

static void ProcessAndPrint(string input, StringProcessor processor)
{
    Console.WriteLine(processor(input));
}

delegate string StringProcessor(string s);