var array = FillArray(10);
Print(array);
double min = MinNum(array);
double max = MaxNum(array);
System.Console.WriteLine();
System.Console.WriteLine($"min namber is -> {MinNum(array)}");
System.Console.WriteLine($"max namber is -> {MaxNum(array)}");
System.Console.WriteLine("the difference between max number and min number is -> "+(max - min));


double MinNum(double[] array)
{
    min = array[0];
    int i = 0;
    while(i < array.Length - 1)
    {
        if(array[i] < min)
        {
            min = array[i];
        }
        i++;
    }

    return min;
}


double MaxNum(double[] array)
{
    max = array[0];
    int i = 0;
    while(i < array.Length - 1)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
        i++;
    }

    return max;
}


double[] FillArray(int length)
{
    double[] array = new double[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().NextDouble()*(10);
    }
    return array;
}

void Print(double[] array)
{
    foreach(var item in array)
    {
        Console.Write($"{item}, ");
    }
}
