// Сумма чисел от 1 до n итеративный способ;
int SumRec(int n)
{
    if(n == 0) return 0;
    else return n + SumRec(n-1);
}
Console.WriteLine(SumRec(10));
