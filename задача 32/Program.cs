// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
var array = FillArray(12);
Print(array);
Console.WriteLine();
Console.WriteLine($"sum of the counable numbers:{SumArr(array)}");
int SumArr(int[] array)
{
    int sum = 0;
    foreach(var item in array)
    {
        if (item %2 ==0 )
        {
            sum += 1;
        }
    }
    return sum;
}
int[] FillArray(int length)
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(0, 1000);
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