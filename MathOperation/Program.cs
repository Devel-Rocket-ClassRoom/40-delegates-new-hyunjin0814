using System;

// README.md를 읽고 코드를 작성하세요.
MathOp add = Add;
MathOp sub = Subtract;
MathOp mul = Multiplb;
MathOp div = Divide;

Console.WriteLine("=== 사칙연산 대리자 ===");
Console.WriteLine("\n[덧셈]");
Console.WriteLine($"20 + 4 = {add(20, 4)}");

Console.WriteLine("\n[뺄셈]");
Console.WriteLine($"20 - 4 = {sub(20, 4)}");

Console.WriteLine("\n[곱셈]");
Console.WriteLine($"20 * 4 = {mul(20, 4)}");

Console.WriteLine("\n[나눗셈]");
Console.WriteLine($"20 / 4 = {div(20, 4)}");

static int Add(int a, int b) => a + b;
static int Subtract(int a, int b) => a - b;
static int Multiplb(int a, int b) => a * b;
static int Divide(int a, int b) => a / b;

delegate int MathOp(int a, int b);