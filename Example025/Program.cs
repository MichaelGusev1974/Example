//Написание в редакторе .NET кода для преобразования заданного значения температуры по шкале Фаренгейта в градусы по Цельсию.
int fahrenheit = 94;
decimal celsius = (fahrenheit - 32) * (5m / 9);
Console.WriteLine("The temperature is " + celsius + " Celsius.");