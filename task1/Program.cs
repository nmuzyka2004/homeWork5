/* Задайте массив заполненный случайными положительными трёхзначными 
числами. Напишите программу, которая покажет количество чётных чисел 
в массиве.
[345, 897, 568, 234] -> 2

*/

int GetNumber (string message)
{
    int result;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else 
        {
            Console.WriteLine("Ввели не число или некорректное число");
        }
    }
    return result;
}


int[] InitArray (int dimension)
{
    Random rnd = new Random();
    int[] arr = new int[dimension];
    for (int i = 0; i < dimension; i++)
    {
        arr[i] = rnd.Next(100, 1000);    
    }
    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int CountNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}


int sizeArray = GetNumber("Введите размерность массива");
int[] array = InitArray(sizeArray);
PrintArray(array);
int count = CountNumber(array);
Console.WriteLine($"Количество четных чисел в массиве равно {count}");

