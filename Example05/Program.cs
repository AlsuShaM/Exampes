Console.Write("Введите имя пользователя:");
string username = Console.ReadLine();

if(username.ToLower() == "алсу")
{
    Console.WriteLine("Ура, это же Алсу");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
