using System;

// README.md를 읽고 아래에 코드를 작성하세요.
SayDelegate say = Hello;
say();
say.Invoke();

SayDelegate say2 = Hi;
SayDelegate say3 = new SayDelegate(Hi);
say2();
say3();

GetAreaDelegate pointer = GetArea;
Console.WriteLine(pointer(10));
Console.WriteLine(pointer.Invoke(10));

MathOperation pow = Math.Pow;
Console.WriteLine(pow(2, 10));

Transformer t = Calculator.Square;
Console.WriteLine(t(5));

ProgressReporter p = WriteToConsole;
p += WriteToFile;

for (int i = 0; i <= 100; i += 25)
{
    p(i);
    Console.WriteLine();
}

RunnerCall(Go);
Console.WriteLine();
RunnerCall(Back);

Action greet = () => Console.WriteLine("안녕하세요!");
greet();

Action<string> print = (msg) => Console.WriteLine(msg);
print("Hello, Action!");

Action<string, int> printRepeat = (msg, count) =>
{
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(msg);
    }
};
printRepeat("반복", 3);

Func<int> getNumber = () => 42;
Console.WriteLine(getNumber());

Func<int, int> square = (x) => x * x;
Console.WriteLine(square(5));

Func<int, int, int> add = (a, b) => a + b;
Console.WriteLine(add(3, 7));

Func<int, int, string> addToString = (a, b) => (a + b).ToString();
Console.WriteLine(addToString(3, 5));

Predicate<int> isEven = (x) => x % 2 == 0;
Predicate<int> isPositive = (x) => x > 0;

Console.WriteLine(isEven(4));
Console.WriteLine(isEven(7));
Console.WriteLine(isPositive(5));
Console.WriteLine(isPositive(-3));

SayDelegate say4 = delegate ()
{
    Console.WriteLine("반갑습니다");
};

say4();

static void Hello()
{
    Console.WriteLine("Hello Delegate");
}

static void Hi()
{
    Console.WriteLine("안녕하세요.");
}

static void WriteToConsole(int percent)
{
    Console.WriteLine($"진행률: {percent}%");
}

static void WriteToFile(int percent)
{
    Console.WriteLine($"[파일 기록] {percent}%");
}

static void Go()
{
    Console.WriteLine("직진");
}

static void Back()
{
    Console.WriteLine("후진");
}

static void RunnerCall(Runner runner)
{
    Console.WriteLine("=== 실행 시작 ===");
    runner();
    Console.WriteLine("=== 실행 종료 ===");
}

static double GetArea(int r) => 3.14 * r * r;

delegate void SayDelegate();

delegate double GetAreaDelegate(int i);

delegate double MathOperation(double x, double y);

delegate int Transformer(int i);

delegate void ProgressReporter(int i);

delegate void Runner();