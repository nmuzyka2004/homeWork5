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


(double, double) GetMaxMinNumber(double[] array)
{
    double maxNumber = array[0];
    double minNumber = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maxNumber)
        {
            maxNumber = array[i];
        }
        else
        {
            if (array[i] < minNumber)
            {
                minNumber = array[i];
            }
        }
    }
    return (maxNumber, minNumber);
}

int sizeArray = GetNumber("Введите размерность массива");
double[] arr = InitArray(sizeArray);
PrintArray(arr);
(double max, double min) = GetMaxMinNumber(arr);
Console.WriteLine($"Разница между максимальным ({max}) и минимальным ({min}) элементами массива: {max - min}");

