// В этой задаче вы реализуете бизнес-правила, которые ограничивают доступ пользователей на основе их разрешений и их уровня. 
//Пользователю будет отображаться другое сообщение в зависимости от его разрешений и уровня.

string permission = "Admin | Manager";
int level = 1;
if (permission.Contains("Admin"))
{
    if(level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
       Console.WriteLine("Welcome, Admin user."); 
    }
}
else if (permission.Contains("Manager"))
{
   if(level >= 20)
   {
       Console.WriteLine("Contact an Admin for access.");
   } 
   else
   {
      Console.WriteLine("You do not have sufficient privileges."); 
   }
}
else
{
     Console.WriteLine("You do not have sufficient privileges.");
} 
