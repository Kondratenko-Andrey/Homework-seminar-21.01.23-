// Написать программу вычисления произведения чисел от 1 до N

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine() ?? "0");

int result = 1;

while (N < 1)
{
    Console.Write("Число N введено некорректно. Введите число N >= 1: ");
    N = int.Parse(Console.ReadLine() ?? "0");
}

for (int i = 1; i <= N; i++)
{
    result = result * i;
    Console.WriteLine($"i = {i}; result = {result}");

}

Console.Write($"Произведение чисел от 1 до введённого Вами числа {N} равно: {result}");
