using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Action action = GoForward;
action += GoLeft;
action += GoRight;
action();

action = GoForward;
action += GoLeft;
action += delegate ()
{
    Console.WriteLine("우회전");
};
action();

static void GoForward()
{
    Console.WriteLine("직진");
}

static void GoLeft()
{
    Console.WriteLine("좌회전");
}

static void GoRight()
{
    Console.WriteLine("우회전");
}