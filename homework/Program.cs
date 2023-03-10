static void Task54()
{
    /*Задача 54: Задайте двумерный массив. Напишите программу, 
    которая упорядочит по убыванию элементы каждой строки двумерного массива.
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    В итоге получается вот такой массив:
    7 4 2 1
    9 5 3 2
    8 4 4 2*/

    int[,] array = TwoRandomArray();
    System.Console.WriteLine("\n");

    int[,] TwoRandomArray()
    {
        Console.WriteLine("Введите количество строк двумерного массива: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов двумерного массива: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] array = new int[m, n];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.WriteLine();
            for (int j = 0; j < array.GetLength(1); j++)
            {
            array[i, j] = new Random().Next(1, 11);
            Console.Write(array[i, j] + " ");
            }
        }
    return array;
    }

    int[,] ChangedArray(int[,] array)
    {
        int m = array.GetLength(0);
        int n = array.GetLength(1);
        
        for (int i = 0; i < array.GetLength(0); i++)
        {
            
            for (int j = 0; j < array.GetLength(1); j++)
            {
            
                 for (int k = 0; k < array.GetLength(1) - 1; k++)
                {
                if (array[i, k] < array[i, k + 1])
                    {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                                            
                    }
                       
                }
            }

        }        
        return array;

    }
    

    void ReadArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                System.Console.Write(String.Join($" ", array[i, j]));
                }
                System.Console.WriteLine();
            }
    }
    ReadArray(ChangedArray(array));
}

static void Task56()
{
    /*Задача 56: Задайте прямоугольный двумерный массив. 
    Напишите программу, которая будет находить строку с наименьшей суммой элементов.
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    5 2 6 7
    Программа считает сумму элементов в каждой строке и 
    выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

    int[,] array = TwoRandomArray();
    System.Console.WriteLine("\n");

    int[,] TwoRandomArray()
    {
        Console.WriteLine("Введите количество строк двумерного массива: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов двумерного массива: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] array = new int[m, n];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.WriteLine();
            for (int j = 0; j < array.GetLength(1); j++)
            {
            array[i, j] = new Random().Next(1, 11);
            Console.Write(array[i, j] + " ");
            }
        }
    return array;
    }

    int SumStringElements(int[,] array, int i)
    {
        int sumString = array[i,0];
        for (int j = 1; j < array.GetLength(1); j++)
        {
            sumString += array[i,j];
        }
        return sumString;
    }

        int minSumString = 0;
        int sumString = SumStringElements(array, 0);
        for (int i = 1; i < array.GetLength(0); i++)
        {
            int tmp = SumStringElements(array, i);
            if (sumString > tmp)
            {
                sumString = tmp;
                minSumString = i;
            }
        }

        Console.WriteLine($"{minSumString+1} - строкa с наименьшей суммой элементов (сумма равна {sumString})");

}
Task56();
