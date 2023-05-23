// 23. Программа, которая задает прямоугольный двумерный массив и находит строку с наименьшей
// суммой элементов.


void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void MinSumRow(int[,] array)
{
    int MinRowSum=0;
    int MinSumRowIndex=0;
    int SumRow=0;

    for (int i = 0; i < array.GetLength(1); i++)
    {
        MinRowSum=array[0,i]+MinRowSum;
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            SumRow=array[i,j]+SumRow;
            if (SumRow<MinRowSum)
            {
                MinRowSum=SumRow;
                MinSumRowIndex=i;
            }
            SumRow=0;
        }
        Console.Write($"{minSumRowIndex+1} это строка с минимальной суммой");
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} | ");
        }
        System.Console.WriteLine();
    }
}

int[,] array = new int[2, 4];
CreateArray(array);
MinSumRow(array);
PrintArray(array);
Console.WriteLine("Строка с минимальной суммой в ряде найдена.");
