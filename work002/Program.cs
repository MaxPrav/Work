Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number);

if (numberText.Length > 2)
{
    Console.WriteLine("Третья цифра -> " +numberText[2]);
}
else 
{
    Console.WriteLine("Третьей цифры нет");
}