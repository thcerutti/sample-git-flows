// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine($"Sum sample: {Sum(1, 2)}");
Console.WriteLine($"Divide sample: {Divide(1, 2)}");
Console.WriteLine($"Multiply sample: {Multiply(1, 2)}");
Console.WriteLine($"Subtract sample: {Subtract(1, 2)}");

static int Sum(int a, int b)
{
    return a + b;
}

static int Subtract(int a, int b)
{
    return a - b;
}

static int Multiply(int a, int b)
{
    return a * b;
}

static decimal Divide(int a, int b)
{
    return a / b;
}