/* Целочисленный тип - это тип данных с простым значением, который может содержать целые числа.
Существуют подписанные и неподписанные типы данных. Целочисленные типы со знаком используют один бит для сохранения положительного 
или отрицательного значения. MaxValueMinValueСвойства и числовых типов данных можно использовать для оценки того, может ли число 
соответствовать данному типу данных. Тип с плавающей запятой - это простой тип данных значений, который может содержать дробные числа.
Выбор правильного типа с плавающей запятой для вашего приложения требует, чтобы вы учитывали не только максимальные и минимальные значения, 
которые он может содержать. Вы также должны учитывать, сколько значений может быть сохранено после запятой, как хранятся числа и как их внутреннее 
хранилище влияет на результат математических операций. Значения с плавающей запятой иногда могут быть представлены с использованием "E нотации", 
когда числа становятся особенно большими. Существует фундаментальное различие в том, как компилятор и среда выполнения 
обрабатывают decimalв отличие от float или double, особенно при определении того, какая точность необходима для математических операций.*/

 Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
 Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
 Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");
 Console.WriteLine("");
 Console.WriteLine("Unsigned integral types:");

 Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
 Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
 Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
 Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

/*Ссылочные типы

Ссылочные типы включают массивы, классы и строки. Ссылочные типы обрабатываются иначе, чем типы значений, в отношении способа 
сохранения значений при выполнении приложения.
В этом упражнении мы узнаем, чем ссылочные типы отличаются от типов значений, и как использовать newоператор для связывания переменной 
со значением в памяти компьютера.
Чем ссылочные типы отличаются от типов значений
Переменная типа значения будет хранить свои значения непосредственно в области хранения, называемой стеком. 
Стек - это память, выделенная для кода, который в данный момент выполняется на процессоре 
(также известный как фрейм стека или фрейм активации). По завершении выполнения фрейма стека значения в стеке удаляются.

Переменная ссылочного типа будет хранить свои значения в отдельной области памяти, называемой кучей. 
Куча - это область памяти, которая используется многими приложениями, запущенными в операционной системе одновременно. 
Среда выполнения .NET взаимодействует с операционной системой, чтобы определить, какие адреса памяти доступны, и запрашивает адрес,
 по которому она может хранить значение. Среда выполнения .NET сохраняет значение, а затем возвращает адрес памяти переменной. 
 Когда ваш код использует переменную, среда выполнения .NET беспрепятственно ищет адрес, сохраненный в переменной, 
 и извлекает значение, которое там хранится.*/

 //Определите переменную ссылочного типа

 //int[] data;

 //На данный момент dataэто просто переменная, которая может содержать ссылку или, скорее, адрес памяти значения в куче. 
 //Поскольку оно не указывает на адрес памяти, оно называется нулевой ссылкой.

//Создайте экземпляр int массива, используя new ключевое слово

//data = new int[3];

/*newКлючевое слово сообщает среде выполнения .NET создать экземпляр intarray, а затем координирует его с операционной системой 
для сохранения в памяти. Среда выполнения .NET соответствует требованиям и возвращает адрес памяти нового intмассива. 
Наконец, адрес памяти сохраняется в переменных данных. Элементы intмассива по умолчанию имеют значение0, 
потому что это значение по умолчанию для an int.*/

/*Две строки кода  обычно сокращаются до одной строки кода для объявления переменной и 
создания нового экземпляра intмассива.*/

int[] data = new int[3];

/*Почему строковый тип данных C # отличается?
Тип string данных также является ссылочным типом. Вам может быть интересно, почему мы не используем new оператор при объявлении строки.
Это исключительно удобство, предоставляемое разработчиками C #. Поскольку stringтип данных используется так часто, мы можем использовать этот формат:*/

string shortenedString = "Hello World!";
Console.WriteLine(shortenedString);

/*Однако за кулисами создается новый экземпляр System.String и инициализируется "Hello World!".
Типы значений могут содержать меньшие значения и хранятся в стеке. Ссылочные типы могут содержать большие значения, 
и новый экземпляр ссылочного типа создается с помощью newоператора. Переменные ссылочного типа содержат ссылку (адрес памяти) на 
фактическое значение, хранящееся в куче.
Ссылочные типы включают массивы, строки и классы.*/

/*Если вы сомневаетесь, придерживайтесь основ.Хотя мы рассмотрели несколько соображений, которые часто приводят 
к рассмотрению множества различных типов данных, в начале работы вам следует предпочесть подмножество базовых типов 
данных для простоты, в том числе:

int для большинства целых чисел
decimal для чисел, представляющих деньги
bool для значений true или false
string для буквенно-цифрового значения
Выберите специальные сложные типы для особых ситуаций.Не изобретайте заново типы данных, если они уже существуют для определенной цели.

byte для работы с закодированными данными, поступающими из других компьютерных систем или использующими другие наборы символов.
double для работы с геометрическими или научными целями. doubleчасто используется при создании игр, связанных с движением.
System.StringBuilder для построения одной строки из множества литералов или других переменных.
System.DateTime для определенного значения даты и времени.
System.TimeSpan в течение нескольких лет / месяцев / дней / часов / минут / секунд / миллисекунд.

При выборе типов данных для вашего кода необходимо учитывать несколько соображений. 
Однако, хотя вы должны быть осторожны и продумывать свой выбор, если вы будете придерживаться некоторых основных типов, 
таких как int, decimal, string, и bool, скорее всего, все будет в порядке.