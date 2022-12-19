/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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
        arr[i] = rnd.Next(-99, 100);    
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

int GetSummNegNumber(int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0)
        {
            summ += array[i];
        }
    }
    return summ;
}


int sizeArray = GetNumber("Введите размерность массива");
int[] array = InitArray(sizeArray);
PrintArray(array);
int summ = GetSummNegNumber(array);
Console.WriteLine($"Сумма нечетных чисел массива равна {summ}");

