// Программа приветствия взависимости от имени пользователя
Console.WriteLine("Введите Ваше имя? ");
string username = Console.ReadLine();
if (username.ToLower() == "маша")
{
  Console.WriteLine ("Ура, это же Маша! Пять рублей и наша!)");
}
else
{
  Console.WriteLine("Привет, {0}!", username);
}