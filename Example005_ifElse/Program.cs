Console.Write("Введите имя пользоавателя: ");
string username = Console.ReadLine();

if (username.ToLower() == "masha")
{
    Console.WriteLine("Привет, это же МАША!!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
    
