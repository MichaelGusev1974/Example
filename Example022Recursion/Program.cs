// Факториал числа (Факториалом числа называют произведением чисел от 1 до n) рекурсивный способ.
int FactorialRec(int n)
{
    if(n == 1) return 1;               // Factorial 0! = 1;
    else return n * FactorialRec(n-1);
}
Console.WriteLine(FactorialRec(10));
