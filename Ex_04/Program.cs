// Подсчитать сумму цифр в числе

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine() ?? "0");
int sum = 0;

while(num != 0)
{
sum = sum + num % 10;
num = num / 10;
}

Console.Write("Сумма цифр введённого Вами числа равна: " + sum);
