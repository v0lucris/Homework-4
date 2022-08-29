// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Console.WriteLine("Введите размер массива : ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int [size];
FillArrayRandomNumbers(array);
Console.WriteLine( "Your array : ");
PrintArray(array);

for (int i = 0; i < size / 2; i++)
{
    
    Console.WriteLine($"произведение {i+1} пары чисел равно : {array[i]} * {array[size -1-i]} = {array[i] * array[size - 1- i]}");
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