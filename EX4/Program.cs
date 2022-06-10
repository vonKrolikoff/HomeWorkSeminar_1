Console.WriteLine("Находим все чётные числа от 1 до N:");

Console.WriteLine("Введите числo N - ");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);

int res = 2;

while (res < number)
{
    Console.Write(res + " ");
    res = res + 2;
}