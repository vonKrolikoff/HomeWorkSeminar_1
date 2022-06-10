Console.WriteLine("Находим максимальное из трех чисел:");

Console.WriteLine("Введите первое числo - ");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);

Console.WriteLine("Введите второе числo -");
string input1 = Console.ReadLine();
int number1 = Convert.ToInt32(input1);

Console.WriteLine("Введите третье числo - ");
string input2 = Console.ReadLine();
int number2 = Convert.ToInt32(input2);

int max = number;

if (number1 > max) max = number1;
if (number2 > max) max = number2;

Console.WriteLine("Максимальное число - " + max);