// Показать кубы чисел, заканчивающихся на четную цифру

void FilArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(10);
    }

}

void PrintArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

Console.WriteLine("Нам дан массив из 15 элементов:");

int[] arr = new int[15];
FilArr(arr);
PrintArr(arr);

Console.WriteLine();
Console.WriteLine("Ниже приведены значение элементов, заканчивающихся на чётную цифру, в третьей степени");

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0)
    {
        Console.WriteLine($"arr[{i}] = {arr[i]}, arr[{i}] в третьей степени равно: {Math.Pow(arr[i], 3)}");
    }
}