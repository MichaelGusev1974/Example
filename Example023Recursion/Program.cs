// Вычисление числа а в натуральной степени n рекурсивный способ.
int PowerFor(int a, int n)
{
    if(n == 0) return 1;
    else return a * PowerFor( a, n -  1);
}
Console.WriteLine(PowerFor(3, 3));
