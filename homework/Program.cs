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
            //     int elementMax = array[0, j];
            //     int count = 0;
                       
            //     if (array[i, j] > elementMax && count < m)
            //     {
            //         elementMax = array[i, j];
            //         array[i, j] = array[m - 1, j];
            //         array[m - 1, j] = elementMax;
            //         count++;
            //     }
            //     else
            //     count = 0;
            //     count++;

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

Task54();
