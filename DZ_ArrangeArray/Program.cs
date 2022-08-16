
// 1. Найти позицию максимального элемента в неотсортированной части массива
// 2. Произвести обмен этого значения с первой неотсортированной позиции
// 3. Повторять, пока есть неотсортированные элементы

int[] massiv = {18, 15, 14, 4, 32, 21, 16, 6, 7, 11, 1, 12, 31, 64, 87, 54, 20, 112, 44, 183, 147};

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
        for(int i = 0; i < array.Length - 1 ; i++) // Length - 1 потому, что первый элемент есть, он макс. и сортировка идет со второго.
         {
         int IndexElementMax = i;
             for (int j  = i + 1 ; j < array.Length; j++) //  i + 1 потому, что максимальное значение определено и записано в элемент с первым [0] индексом                                                     
             {                                           
                 if(array[j] > array[IndexElementMax]) IndexElementMax = j;
             }
         int a = array[i];   // В переменную "а" записываем значение первого элемента массива.
         array[i] = array[IndexElementMax]; // Присваиваем первому элементу  максимальное значение
         array[IndexElementMax] = a; // В переменную "а" записываем максимальное значение 
        } 
    }

PrintArray(massiv);
 SelectionSort(massiv);

 PrintArray(massiv);