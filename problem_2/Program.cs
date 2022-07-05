// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет;

void PrintArray(int[,] array)// метод на вывод массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int Input(string output) // Метод на ввод данных в ручную
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

int m = Input("Введите колличество строк m: ");
int n = Input("Введите колличсетво столбцов n: ");

int[,] numbers = new int[m, n];// заполнение массива

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for(int j = 0; j < numbers.GetLength(1); j++)
    {
        numbers[i, j] = new Random().Next(1,10);
              
    }
}

PrintArray(numbers);

Console.WriteLine("Введите двухзначное число для поиска элемента : ");
int pozicion = Convert.ToInt32(Console.ReadLine());

if (pozicion < 10 || pozicion > 99)
        {
            Console.WriteLine("Error(нужно ввести двухзначное число"+")");
        }
        else
        {   
            int n1 = (pozicion / 10) - 1;
            int n2 = (pozicion % 10) - 1; 
            // Console.WriteLine(n1);
            // Console.WriteLine(n2);
            {
                for (int i = 0; i < numbers.GetLength(0); i++)
                {
                    for(int j = 0; j < numbers.GetLength(1); j++)
                    {
                        if ( j == n2 && i == n1 )
                        Console.WriteLine("Значение в массиве по заданным параметрам: " + numbers[i,j]);
                    }
                }
            }
        }
// Console.WriteLine("такого элемента нет "); не могу сообразить куда вставить эту строку