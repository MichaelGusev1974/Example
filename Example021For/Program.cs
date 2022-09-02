// Сумма чисел от 1 до n итеративный способ;
int SumFor(int n)
{
    int result = 0;
    for(int i = 1; i <= n; i++)
    result +=i;
    return result;
}
Console.WriteLine(SumFor(10));
