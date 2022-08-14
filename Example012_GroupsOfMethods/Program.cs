// 1 Вид метода

 void Method1()
 {
     Console.WriteLine("Автор Гусев Михаил Викторович");
 }
//Method1();

// 2 Вид метода

 void Method2(string msg)
 {
     Console.WriteLine(msg);
 }
//Method2("Текст сообщения");
// 2.1 Вид метода с именованными аргументами
void Method21(string msg, int count)
 {
     int i = 0;
    
     while(i < count)
     {
     Console.WriteLine(msg);
    i++; //Увеличение счетчика называют инкриментом, уменьшение декриментом.
     }
 }
//Method21("Текст сообщения", 4);
//Method21(msg:"Текст сообщения", count: 4); Можем явно указываь, какому аргументу какое значение можем присвоить.
//Method21(count: 4, msg:"Текст сообщения"); Если явно указываем - не обязательно указывать по порядку.

// 3 вид метода

// Если метод что-то возвращает, мы обязательно должны указать тип данных, которого мы ожидаем.
int Method3()
{
    return DateTime.Now.Year;
}
int Year = Method3();
//Console.WriteLine(Year);

// 4 вид метода 

// string Method4(int count, string text)// Если нажать правой кнопкой мыши и нажать и нажать rename, во всем методе поменяется имя аргумента.
// {
//     int i = 0;
//     string result = string.Empty;// string.Empty - означает пустая строка.
//     while(i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// Цикл for (int i = 0; i < 10; i++)

 string Method4(int count, string text)// Все основные составляющие цикла while собрали в одной строке
 {
     string result = string.Empty;
     for (int i = 0; i < count; i++)
     {
         result = result + text;   
     }
     return result;
 }
String res = Method4(10, "z");
Console.WriteLine(res);