// f(1) = 1;
// f(2) = 1;
// f(3) = (3 - 1) + (3 - 2) = 3
// f(4) = (4 - 1) + (4 - 2) = 5
// f(5) = (5 - 1) + (5 - 2) = 7
// f(n) = (n - 1) + (n - 2)
int Fibonacci(int n)
{
    if (n == 1 || n ==2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n + 1);
}

for(int i = 0; i < 5; i++)
{
Console.WriteLine(Fibonacci(i));
}

