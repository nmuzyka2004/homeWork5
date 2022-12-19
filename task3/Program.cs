/* Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
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


double[] InitArray (int dimension)
{
    Random rnd = new Random();
    double[] arr = new double[dimension];
    for (int i = 0; i < dimension; i++)
    {
        arr[i] = rnd.Next(-99, 100);    
    }
    return arr;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

double GetMaxNumber(double[] array)
{
    double maxNumber = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maxNumber)
        {
            maxNumber = array[i];
        }
    }
    return maxNumber;
}

double GetMinNumber(double[] array)
{
    double minNumber = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minNumber)
        {
            minNumber = array[i];
        }
    }
    return minNumber;
}

int sizeArray = GetNumber("Введите размерность массива");
double[] array = InitArray(sizeArray);
PrintArray(array);
double max = GetMaxNumber(array);
double min = GetMinNumber(array);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {max - min}");

