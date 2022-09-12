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
int [,] ExchangeOfLines(int [,] matrix)
{
    int [] mean = new int [matrix.GetLength(1)];
    for (int i=0;i<matrix.GetLength(1);i++)
    {
        mean[i]=matrix[0,i];
        matrix[0,i]=matrix[matrix.GetLength(0)-1,i];
        matrix[matrix.GetLength(0)-1,i]=mean[i];
    }
    return matrix;
}
int [,] matrix = CreateMatrix(5,5,0,20);
PrintMatrix(matrix);
Console.WriteLine();
matrix=ExchangeOfLines(matrix);
PrintMatrix(matrix);

