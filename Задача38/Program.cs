// Задайте массив вещественных чисел. Найдите разницу между максимальным
//  и минимальным элементов массива.

// [3 7 22 2 78] -> 76


int[] arrayResult = new int[5];
int[] GetArray()
{
    int[] array = new int[5];
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 101);
    return array;
}
int resultArray(int[] array)
{

    int maxNumber = array[0];
    int minNumber = array[0];
    int result = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maxNumber)
            maxNumber = array[i];
        if (array[i] < minNumber)
            minNumber = array[i];
    }
    result = maxNumber - minNumber;
    System.Console.WriteLine($"Разница --> {result}  " );
    return maxNumber - minNumber;
}

void PrintResult(int[] array)
{

    System.Console.WriteLine($"{String.Join(" ", array)}");

}

arrayResult = GetArray();
resultArray(arrayResult);
PrintResult(arrayResult);