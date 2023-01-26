// Найти кубы чисел от 1 до N

Console.Write("Введите число N: ");
int num_N = int.Parse(Console.ReadLine() ?? "0");

while(num_N < 1)
{
    Console.Write("Введите число N >=1: ");
    num_N = int.Parse(Console.ReadLine() ?? "0");
}

Console.WriteLine("Ниже представлены числа от 1 до " + num_N + " в степени 3:");

for(int i = 1; i <= num_N; i++)
{
    Console.WriteLine("Число " + i + " в третьей степени равно: " + Math.Pow(i, 3));
}