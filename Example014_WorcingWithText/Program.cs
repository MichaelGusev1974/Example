// Работа с текстом
// дан текст. В тексте нужно все пробелы заменить черточками, маленькие буквы "к" заменить
// большими "К", и маленькие "с" заменить большими "С".

string text = " - Я думаю, сказал князь, улыбаясь, - что, ежели бы вас послали вместо "
            +"нашего милого Винценгероде, вы бы взяли приступом согласие прусского короля."
            +"Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty" если нужно обратится к конкретному символу строки мы используем индекс.
//             012345
// s[3] = r
//Char представляет тип символьного значения и содержит одно символьное значение Unicode.
// Он имеет размер 2 байта. Это встроенный тип значения в C#

string Replase(string text, char oldValue, char newValue)
{
    string result = string.Empty; // инициализация пустой строки.
    int length = text.Length;   // в переменную length определили длину текста.

    for(int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replase(text, ' ', '|'); // Заменили пробелы черточками.
Console.WriteLine(newText);
Console.WriteLine(); // Интервал
newText = Replase(newText, 'к', 'К'); // Заменили "к" на "К"
Console.WriteLine(newText);
Console.WriteLine(); // Интервал
newText = Replase(newText, 'с', 'С'); // Заменили "c" на "C"
Console.WriteLine(newText);





