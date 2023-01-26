// Возведите число А в натуральную степень B используя цикл

Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите натуральное число В: ");
int B = int.Parse(Console.ReadLine() ?? "0");

int result = A;

while(B < 1)
{
    Console.Write("Число В введено некорректно, оно должно быть целым и больше нуля. Введите натуральное число В: ");
    B = int.Parse(Console.ReadLine() ?? "0");
}

for(int i = 1; i < B; i++)
{
    result = result * A;
}

Console.Write("Число " + A + ", возведенное в степень " + B + " равно: " + result);