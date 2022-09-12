System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
void PrintMatrix(int [,] matrix)
{    
    for (int i=0;i<matrix.GetLength(0);i++)
        {
            for(int j=0;j<matrix.GetLength(1);j++)
            Console.Write ($"{matrix[i,j]}\t");
            Console.WriteLine();
        }
}
int[,] CreateMatrix(int length, int width, int minimum, int maximum)
{
    int[,] matrix = new int[length, width];
    for(int i=0;i<matrix.GetLength(0);i++)
        for(int j=0;j<matrix.GetLength(1);j++)
            matrix[i,j] = new Random().Next(minimum,maximum);
    return matrix;
}
int [,] BubbleSortLines(int [,] matrix)
{
    for (int i = 0; i <matrix.GetLength(0); i++)
    {
        for (int j = 0; j <matrix.GetLength(1)-1; j++)
        {
            for (int k=0;k<matrix.GetLength(1)-1;k++)
            {
                if (matrix[i,k] < matrix[i,k + 1])
                {
                    int tmp = matrix [i,k];
                    matrix [i,k] = matrix [i,k + 1];
                    matrix [i,k + 1] = tmp;
                }
            }
        }
    }
    return matrix;
}
int [,] matrix = CreateMatrix(5,5,0,20);
PrintMatrix(matrix);
Console.WriteLine();
matrix=BubbleSortLines(matrix);
PrintMatrix(matrix);