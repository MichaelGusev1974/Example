// Вычисление числа а в натуральной степени n итеративный способ.
int PowerFor(int a, int n)
{
    int result = 1; 
    for(int i = 1; i <= n; i++)
    result *= a;
    return result;
}
Console.WriteLine(PowerFor(3, 2));
