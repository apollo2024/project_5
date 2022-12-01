// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
var array = FillArray(12);
Print(array);
Console.WriteLine();
Console.WriteLine($"sum of the counable numbers:{SumNum(array)}");
int SumNum(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
         if (i % 2 == 1)
        {
            sum += array[i];
        }
    }
    return sum;
}
int[] FillArray(int length)
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-10, 10);
    }
    return array;
}
void Print(int[] array)
{
    foreach(var item in array)
    {
        System.Console.Write($"{item}, ");
    }
}
