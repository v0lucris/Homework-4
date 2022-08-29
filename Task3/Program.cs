// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
Console.WriteLine("Введите размер массива : ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double [size];
FillArrayRandomNumbers(array);
Console.WriteLine( "Your array : ");
PrintArray(array);
double max = array[0];
double min = array[0];
for (int i = 0; i < size ; i++)
{
    if (array[i]>max)
    {
        max = array[i];
    }
}
Console.WriteLine($"Максимальный элемент : {max}");
for (int i = 0; i < size ; i++)
{
    if (array[i]<min)
    {
        min = array[i];
    }
}
Console.WriteLine($"Минимальный элемент : {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементами равна : {max} - {min} = {max - min} ");

void FillArrayRandomNumbers(double[] array)
{
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1,100);
    }
}

void PrintArray(double[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i] +" ");
    }
    Console.Write("]");
    Console.WriteLine();
}