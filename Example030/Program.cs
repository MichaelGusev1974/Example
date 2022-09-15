// Если идентификатор фиктивного заказа начинается с B, выведите этот идентификатор заказа в выходные данные.
string[] inventory = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
foreach (string items in inventory)
{
    if(items.StartsWith("B"))
    {
        Console.WriteLine(items);
    }
}