// Собрать строку с числами от а до b, где a <= b рекурсивный способ;
// string NumbersRec(int a, int b)
// {
//     if(a <= b) 
//     return $"{a} " + NumbersRec(a + 1,b);
//     else
//     return string.Empty;
// }
// Console.WriteLine(NumbersRec(1,10));

//Собрать строку с числами от а до b, где a >= b рекурсивный способ;
 string NumbersRec(int a, int b)
 {
     if(a <= b) 
     return  NumbersRec(a + 1,b) + $"{a} ";
     else
     return string.Empty;
 }
 Console.WriteLine(NumbersRec(1,10));