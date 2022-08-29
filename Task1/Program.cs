// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int size = 123;
int[] array = new int[size];
FillArrayRandomNumbers(array);
Console.WriteLine(" You array : ");
PrintArray(array);

int count = 0;
for (int i = 0; i < size; i++)
{
    if (array[i] >= 10 && array[i] <= 99)
    count++;
    
}
Console.WriteLine($"количество элементов из отрезка [10,99] : {count}");
void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1,100);
    }
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] +" ");
    }
    Console.Write("]");
    Console.WriteLine();
}