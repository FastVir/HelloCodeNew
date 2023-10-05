
// string[,] table = new string[2, 5];  // 2 - кол-во строк, 5 - кол-во столбцов
// string.Empty;
// table[0,0] table[0,1] table[0,2] table[0,3] table[0,4]
// table[1,0] table[1,1] table[1,2] table[1,3] table[1,4]

// table[1, 2] = "слово";

// for (int row = 0; row < 2; row++)
// {   
//        for (int colums = 0; colums < 5; colums++)
//        {
//             Console.WriteLine($"-{table[row, colums]}-");
//        }
// }



void PrintArray(int[,] matr)
{for (int i = 0; i < matr.GetLength(0); i++)   // matrix.GetLength(0) заменяет конструкцию i < 3, (0) обращение к количеству строк
{
    for (int j = 0; j < matr.GetLength(1); j++) // (1) обращение к количеству столбцов
    {
        Console.Write($"{matr[i,j]} ");
    }
    Console.WriteLine();
}
}

void CreatAraay(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10); // [1, 10)
        }
    }
}

int[,] matrix = new int[3,4];
PrintArray(matrix);
CreatAraay(matrix);
Console.WriteLine();
PrintArray(matrix);
