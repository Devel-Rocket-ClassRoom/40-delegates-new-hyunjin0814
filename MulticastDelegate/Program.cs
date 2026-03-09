using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Action<string> print = PrintOriginal;
string text = "Hello World";

Console.WriteLine("=== 문자열 처리 파이프라인 ===");
Console.WriteLine();

Console.WriteLine("--- 단계 1: 원본 출력만 ---");
print(text);
Console.WriteLine();

Console.WriteLine("--- 단계 2: 대문자 추가 ---");
print += PrintUpper;
print(text);
Console.WriteLine();

Console.WriteLine("--- 단계 3: 소문자, 길이 추가 ---");
print += PrintLower;
print += PrintLength;
print(text);
Console.WriteLine();

Console.WriteLine("--- 단계 4: 대문자 제거 ---");
print -= PrintUpper;
print(text);

static void PrintOriginal(string s)
{
    Console.WriteLine($"원본: {s}");
}
static void PrintUpper(string s)
{
    Console.WriteLine($"대문자: {s.ToUpper()}");
}
static void PrintLower(string s)
{
    Console.WriteLine($"소문자: {s.ToLower()}");
}
static void PrintLength(string s)
{
    Console.WriteLine($"길이: {s.Length}");
}