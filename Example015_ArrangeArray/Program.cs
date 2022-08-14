// 1. Найти позицию минимального элемента в неотсортированной части массива
// 2. Произвести обмен этого значения с первой неотсортированной позиции
// 3. Повторять, пока есть неотсортированные элементы

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array) // Метод, печатающий наш массив.
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}  
void SelectionSort(int[] array)
{
   for(int i = 0; i < array.Length - 1; i++) // array.Length - 1 потому, что во внутреннем цикле счетчик  начинает с i + 1.
    {
    int minPosition = i;
        for (int j  = i + 1; j < array.Length; j++) // i+1 потому, что первый элемент найден во внешнем цикле  и записан в переменную minPosition.                                                      
        {                                           
            if(array[j] < array[minPosition]) minPosition = j;
        }
    int temporary = array[i];        // Классическая замена переменных
    array[i] = array[minPosition];
    array[minPosition] = temporary; //  через третью переменную (а,в,с).
   } 
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
