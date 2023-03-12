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

static void Task58()
{
    /*Задача 58: Задайте две матрицы. Напишите программу, которая
    будет находить произведение двух матриц.
    Например, даны 2 матрицы:
    2 4 | 3 4
    3 2 | 3 3
    Результирующая матрица будет:
    18 20
    15 18
    
    Матрицы A и B могут быть перемножены, если они совместимы в том смысле, 
    что число столбцов матрицы A равно числу строк B.*/

    System.Console.WriteLine("первая матрица");
    int[,] firstArray = TwoRandomArray();
    System.Console.WriteLine("\n");
    

    System.Console.WriteLine("вторая матрица");
    int[,] secondArray = TwoRandomArray();
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

    //проверка на правило//
    void Rules(int[,] firstArray, int[,] secondArray)
    {
        
                    if (firstArray.GetLength(0) != secondArray.GetLength(1))
                    System.Console.Write("матрицы не могут быть перемножены");
                    else
                    MultiplyArray(firstArray, secondArray);
        
    }
    Rules(firstArray, secondArray);

    int[,] MultiplyArray(int[,] firstArray, int[,] secondArray)
    {
        int[,] resultArray = new int[firstArray.GetLength(0), secondArray.GetLength(1)];
        
        int sum = 0;
        int c = 0; //count
        for (int i = 0; i < firstArray.GetLength(0); i++)
        {
            for (int j = 0; j < secondArray.GetLength(1); j++)
            {
                sum += firstArray[i, c] * secondArray[c, j];  
                resultArray[i, j] = sum;

            }

            

        }
        

        return resultArray;

    }
    
    void ShowDuoArray(int[,] resultArray) 
    {
        Console.WriteLine();
        for (int i = 0; i < resultArray.GetLength(0); i++)
        {
            Console.WriteLine();
            for (int j = 0; j < resultArray.GetLength(1); j++)
                {
                    Console.Write(resultArray[i, j] + " ");
                }
        }
    }
    ShowDuoArray(MultiplyArray(firstArray, secondArray));
    
}

static void Task60()
{
    /*Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
    Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
    Массив размером 2 x 2 x 2
    66(0,0,0) 25(0,1,0)
    34(1,0,0) 41(1,1,0)
    27(0,0,1) 90(0,1,1)
    26(1,0,1) 55(1,1,1)*/
   // Random random = new Random();
    int[,,] array =  new int[2, 2, 2];

    void FillArray(int[,,] array)
    {
        Random random = new Random();
        
        
        for ( int i = 0; i < array.GetLength(0); i++)
        {
            Console.WriteLine();
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {   
                    array[i, j, k] = random.Next(10,100);
                    Console.Write($"{array[i, j, k] + " "} ({i} {j} {k}) ");
                }
                Console.WriteLine();
            }

        }
        
    }
    FillArray(array);
     

     
   /* void UniqueElements(int[,,] array)
    { 
        int tmp = array[0, 0, 0];
        int l = 0; //count
        Random random = new Random();

        for ( int i = 0; i < array.GetLength(0); i++)
        {
            Console.WriteLine();
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {   
                    foreach (int el in array)
                    {
                       if( array[i, j, k] == array[i, j, k])
                       {
                        array[i, j, k] = random.Next(10,100);
                        l++;
                       }
                       else
                    Console.Write($"{array[i, j, k] + " "} ({i} {j} {k}) ");

                    }
                    
                    

                    
                }
                Console.WriteLine();
            }

        }
      
        
        
    }
    UniqueElements(array);*/
}
Task60();
