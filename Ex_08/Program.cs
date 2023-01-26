// Определить, присутствует ли в заданном массиве, некоторое число

void FilArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(21);
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

void FindNum(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == num)
        {
            Console.WriteLine($"Искомое число {num} присутствует в массиве arr[{i}] = {array[i]}");
            break;
        }
        else if(i == array.Length - 1) Console.WriteLine($"Искомое число {num} в массиве отсутствует");
    }
}

int[] arr = new int[15];
Console.Write("Введите число, наличие которого необходимо проверить в массиве: ");
int find = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine();

Console.WriteLine("Нам дан массив из 15 элементов:");

FilArr(arr);
PrintArr(arr);
FindNum(arr, find);
