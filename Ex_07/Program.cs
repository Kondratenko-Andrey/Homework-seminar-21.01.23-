//Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

void FilArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(2);
    }

}

void PrintArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }

    Console.WriteLine();
}

int[] arr = new int[8];

FilArr(arr);
PrintArr(arr);