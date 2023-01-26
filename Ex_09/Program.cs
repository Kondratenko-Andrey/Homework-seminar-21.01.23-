// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

void FilArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }

}

void PrintArr(int[] array)
{
    Console.WriteLine("Нам дан массив из 15 элементов:");

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }

    Console.WriteLine();
}

void ChetNechet(int[] array)
{
    int chet_count = 0;
    int nechet_count = 0; 
     
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 1) chet_count++;
        else nechet_count++;
    }

    Console.WriteLine($"В используемом нами массиве кол-во чётных элементов - {chet_count}");
    Console.WriteLine($"                          кол-во нечётных элементов - {nechet_count}");
}

int[] arr = new int[15];

FilArr(arr);
PrintArr(arr);
ChetNechet(arr);