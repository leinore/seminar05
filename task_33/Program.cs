// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.

int[] FillArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-9, 10);
    }
    return arr;
}

Console.Write("Введите длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(num);

Console.WriteLine(string.Join(",", array));

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool isOk = false;
for (int i = 0; i < array.Length; i++)
{
    if (number == array[i])
    {
        isOk = true;
        break;
    }
}
if (isOk)
{
    Console.WriteLine("Элемент найден");
}
else
{
    Console.WriteLine("Элемент не найден");
}