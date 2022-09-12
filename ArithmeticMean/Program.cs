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
double [] ArithmeticMeanColumn(int [,] matrix)
{
    double [] mean = new double [matrix.GetLength(1)];
    for (int i=0;i<matrix.GetLength(1);i++)
    {
        mean[i]=0;
        for(int j=0;j<matrix.GetLength(0);j++)
        {
            mean[i]=mean[i]+matrix[j,i];
        }
        mean[i]=mean[i]/matrix.GetLength(0);
    }
 return mean;
}
int [,] matrix = CreateMatrix(5,5,0,20);
PrintMatrix(matrix);
double [] mean = ArithmeticMeanColumn(matrix);
Console.Write ("Arithmetic mean of the column: ");
foreach(var element in mean)
Console.Write ($"{element}, ");
