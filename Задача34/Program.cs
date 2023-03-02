// Задайте массив заполненный случайными положительными 
// трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

void InputArray(int[] numbers)
{
    int length = numbers.Length;
    int index = 0;
    while (index < length)
    {
        numbers[index] = new Random().Next(100, 1000);
        index++;
    }
}

void ShowResult(int[] num)
{
    int count = num.Length;
    int ind = 0;
    while(ind < count)
    {
        System.Console.Write(num[ind] + " ");
        ind++;
    }
}

int EvenNumbers(int[] numbers, int even)
{
    int count = numbers.Length;
    int index = 0;
    int position = 0;
    int result = 0;
    while (index < count)
    {
        if (numbers[index] % 2 == 0)
        {
            result= result + 1;
        }
        index++;//index= index + index
    }
    System.Console.WriteLine($"-> {result}");
    return position;
}

int[] massive = new int[7];

InputArray(massive);
ShowResult(massive);
int pos = EvenNumbers(massive, 7);