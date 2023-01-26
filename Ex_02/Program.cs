// Найти сумму чисел от 1 до А

Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine()  ?? "0");

int result = 0;

Console.Write("Сумма целых чисел от 1 до А: ");

for(int i = 1; i <= A; i++)
{
    result = result + i;

    if(result ==1) Console.Write(result + " + ");
        else if(i == A) Console.Write(i + " = " + result);
            else Console.Write(i + " + ");
}


