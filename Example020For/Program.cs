// Собрать строку с числами от а до b, где a <= b итеративный способ;
// string NumbersFor(int a, int b)
// {
//     string result = string.Empty;
//     for(int i = a; i <= b; i++)
//     {
//         result += $"{i} ";
//     }
//     return result;
// }
// Console.WriteLine(NumbersFor(1,10));

// Собрать строку с числами от а до b, где a >= b итеративный способ;
string NumbersFor(int a, int b)
{
    string result = string.Empty;
    for(int i = a; i >= b; i--)
    {
        result += $"{i} ";
    }
    return result;
}
Console.WriteLine(NumbersFor(10,1));