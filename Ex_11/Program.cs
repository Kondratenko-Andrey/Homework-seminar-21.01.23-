// Найти сумму чисел одномерного массива стоящих на нечетной позиции

void FilArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(20);
    }

}

void PrintArr(int[] array)
{
    Console.WriteLine($"Нам дан массив из {array.Length} элементов:");

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }

    Console.WriteLine();
}


int[] arr = new int[15];

FilArr(arr);
PrintArr(arr);

int sum = 0;

for (int i = 0; i < arr.Length; i++)
{
    if(i % 2 == 1) sum = sum + arr[i];
}

Console.WriteLine($"В данном массиве сумма чисел стоящих на нечетной позиции равна: {sum}");