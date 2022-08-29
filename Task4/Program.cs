// Определить, присутствует ли в заданном массиве, некоторое число
Console.WriteLine("Введите некоторое число : ");
int temp = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер массива : ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int [size];
FillArrayRandomNumbers(array);
Console.WriteLine( "Your array : ");
PrintArray(array);


for (int i = 0; i < size / 2; i++)
{
    if (array[i] == temp)
    Console.WriteLine($"Некоторое число {temp} в массиве ПРИСУТСТВУЕТ");
    else 
    Console.WriteLine($"Некоторое число {temp} в массиве НЕ присутствует");
    break;
}
 
   
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
    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i] +" ");
    }
    Console.Write("]");
    Console.WriteLine();
}
