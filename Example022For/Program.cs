// Факториал числа (Факториалом числа называют произведением чисел от 1 до n) итеративный способ.
int FactorialFor(int n)
{
    int result = 1; // Factorial 0! = 1;
    for(int i = 1; i <= n; i++)
    result *= i;
    return result;
}
Console.WriteLine(FactorialFor(10));
