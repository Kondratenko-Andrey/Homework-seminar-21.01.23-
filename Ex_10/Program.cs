// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

void FilArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(250);
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


int[] arr = new int[123];

FilArr(arr);
PrintArr(arr);

int count = 0;

for (int i = 0; i < 123; i++)
{
    if(arr[i] >= 10 && arr[i] <= 99) count++;
}

Console.WriteLine($"В данном массиве из 123 чисел количество элементов из отрезка [10,99] равно: {count}");
