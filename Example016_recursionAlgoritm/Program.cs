//string [,] Table = new string [2, 5];
//String.Empty - константа для инициализации строк.
// Table[0,0](1-ая строка, 1-й столбец) Table[0,1](1-ая строка, 2-й столбец) Table[1,2](2-ая строка, 3-й столбец)
// Table[1,0](2-ая строка, 1-й столбец) Table[1,1](2-ая строка, 2-й столбец) Table[1,2](2-ая строка, 3-й столбец)
// Table[1,2] = "Слово";
// for(int rows = 0; rows < 2; rows++)
// {
//     for(int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{Table[rows,columns]}-");        
//     }
// }

void PrintArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
    for(int j = 0; j < matr.GetLength(1); j++)
        {
         Console.Write($"{matr[i,j]} ");
        }
       Console.WriteLine();   
    }
} 

void FillArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
    for(int j = 0; j < matr.GetLength(1); j++)
        {
         matr[i,j] = new Random().Next(1,10);//[1,10) - полуинтервал!!!
        } 
    }
}

int[,] matrix = new int[3, 4];

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine(); 
PrintArray(matrix);