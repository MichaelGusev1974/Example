// Задача: улучшить показатели продления подписок
/*Вам было предложено добавить функцию в программное обеспечение компании. Эта функция призвана повысить частоту обновления 
подписок на программное обеспечение. Ваша задача — сделать так, чтобы при входе пользователя в программную систему ему 
отображалось сообщение о скором окончании срока действия подписки и необходимости ее продления. */
Random random = new Random();
int daysUntilExpiration = random.Next(11);
int discountPercentage = 0;

if(daysUntilExpiration == 0)
{
    Console.Write("Your subscription has expired.");
}
else if(daysUntilExpiration == 1)
{
    Console.Write("Your subscription expires within a day! ");
    discountPercentage = 20;
}
else if(daysUntilExpiration <= 5)
{
  Console.Write($"Your subscription expires in {daysUntilExpiration} days. ");
   discountPercentage = 10; 
}
else if(daysUntilExpiration <= 10)
{
  Console.WriteLine("Your subscription will expire soon. Renew now!");  
}
if (discountPercentage > 0)
{
  Console.WriteLine($"Renew now and save {discountPercentage}%");  
}
