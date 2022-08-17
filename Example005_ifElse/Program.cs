Console.Write("Введите имя пользователя: ");
string userName = Console.ReadLine();

if (userName.ToLower() == "nik")
{
    Console.WriteLine("Ура, это же Nik!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(userName);
}