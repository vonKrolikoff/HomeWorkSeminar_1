Console.WriteLine("Проверка четности числа:");

Console.WriteLine("Введите числo - ");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);

if (number % 2 == 0)
{
    Console.WriteLine("Число " + number + " является четным");
}
else
{
    Console.WriteLine("Число " + number + " является нечетным");
}