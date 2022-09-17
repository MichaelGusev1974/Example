// string value1 = " a";
// string value2 = "A ";
// Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());
// Console.WriteLine("a" != "a");
// Console.WriteLine("a" != "A");
// Console.WriteLine(1 != 2);

// string myValue = "a";
// Console.WriteLine(myValue != "a");
// Console.WriteLine(1 > 2);
// Console.WriteLine(1 < 2);
// Console.WriteLine(1 >= 1);
// Console.WriteLine(1 <= 1);
string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(pangram.Contains("fox"));
// Console.WriteLine(pangram.Contains("cow"));
Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow"));
/*Существует много различных типов выражений, которые вычисляют либо trueили false.
Оцените равенство с помощью ==оператора.
Оценка равенства строк требует, чтобы вы учитывали возможность того, что строки имеют разные регистры и начальные или конечные пробелы. В зависимости от вашей ситуации используйте ToLower()вспомогательные методы или ToUpper()и вспомогательный метод, Trim()чтобы повысить вероятность того, что две строки равны.
Вычислите неравенство с помощью !=оператора.
Вычисляйте операции больше, меньше и аналогичные операции, используя операторы сравнения, такие как >, <, >=, и <=.
Если метод возвращает bool, вы можете использовать его как логическое выражение.
Используйте оператор логического отрицания !для вычисления противоположности заданному выражению.*/