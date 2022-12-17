// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < 10)
                Console.Write(" " + 0 + arr[i, j] + " ");
            else
                Console.Write(" " + arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = new int[4, 4];
int i = 0;
int j = 0;
int tempJ = 0;
int tempI = 0;
int count = 1;
for (int index = 0; index < matrix.GetLength(1); index++)
{
    for (j = index; j < matrix.GetLength(1); j++)
    {
        if (matrix[tempI, j] == 0)
        {
            matrix[i + index, j] = count;
            count++;
            tempJ = j;
        }
        else break;
    }
    for (i = index + 1; i < matrix.GetLength(0); i++)
    {
        if (matrix[i, tempJ] == 0)
        {
            matrix[i, tempJ] = count;
            count++;
            tempI = i;
        }
        else break;
    }
    for (j = tempJ - 1; j >= 0; j--)
    {
        if (matrix[tempI, j] == 0)
        {
            matrix[tempI, j] = count;
            count++;
            tempJ = j;
        }
        else break;
    }
    for (i = tempI - 1; i >= 0; i--)
    {
        if (matrix[i, tempJ] == 0)
        {
            matrix[i, tempJ] = count;
            count++;
            tempI = i;
        }
        else break;
    }    

}
PrintMatrix(matrix);
