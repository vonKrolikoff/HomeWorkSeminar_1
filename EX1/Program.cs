Console.WriteLine("Введите первое числo - ");
string input = Console.ReadLine();
int number1 = Convert.ToInt32(input);

Console.WriteLine("Введите второе числo -");
string input1 = Console.ReadLine();
int number2 = Convert.ToInt32(input1);

if (number1 == number2)
{
    Console.WriteLine (number1 + " = " + number2);
}

if (number1 > number2)
{
    Console.WriteLine (number1 + " > " + number2);
}
if (number1 < number2)
{
    Console.WriteLine (number1 + " < " + number2);
}    