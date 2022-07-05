// : Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int m = Input("Введите m: ");
int n = Input("Введите n: ");

int[,] numbers = new int[m, n];
// int[,] newNumbers = new int[m, n];

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        numbers[i, j] = new Random().Next(1, 10);
    }
}

PrintArray(numbers);
Console.WriteLine();

for (int i = 0; i < numbers.GetLength(1); i++)
{
    double sum = 0;
    double sredAref = 0;
    for (int j = 0; j < numbers.GetLength(0); j++)
    {
       sum += numbers[j,i];
       sredAref = sum / numbers.GetLength(0);

    }
    //Console.WriteLine("Сумма "+(i+1)+" равно: "+ sum);
    Console.WriteLine("Cреднее арифметическое элементов в "+(i+1) +"столбце равно: "+ sredAref);
}
 Console.WriteLine();





