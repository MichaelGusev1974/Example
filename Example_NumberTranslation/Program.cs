Console.Write("Введите  число: ");
int n; 
n = Convert.ToInt32(Console.ReadLine());

while (n  >  0)
{
    Console.Write(n%2);  

    n = n / 2;
}
 