// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

void InputArray(int[] numbers)
{
    int length = numbers.Length;
    int index = 0;
    while (index < length)
    {
        numbers[index] = new Random().Next(-99, 100);
        index++;
    }
}

void ShowResult(int[] num)
{
    int count = num.Length;
    int position = 0;
    while(position < count)
    {
        System.Console.Write(num[position] + " ");
        position++;
    }
}

int SumNumbers(int[] numb, int sum)
{
    int count = numb.Length;
    int index = 0;
    int Sum = 0;
    while (index < count)
    {
        if (index % 2 != 0) 

        Sum += numb[index];// Sum= Sum + numbers[index]
        index++;
    }
    return Sum;
}

int[] massive = new int[4];

InputArray(massive);
ShowResult(massive);
int pos = SumNumbers(massive, 4);

System.Console.Write("-> " + pos);