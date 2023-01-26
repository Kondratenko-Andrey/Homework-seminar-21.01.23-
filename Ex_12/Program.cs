// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

void FilArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(10);
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

for (int i = 0; i < arr.Length / 2; i++)
{
    Console.WriteLine($"Произведение элементов arr[{i}] и arr[{arr.Length-1-i}] равно: " + (arr[i] * arr[arr.Length-1-i]));
}