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
int [,] ChangesRowsToColuns(int [,] matrix)
{
    int [,] newMatrix = new int [matrix.GetLength(0),matrix.GetLength(1)];
    for (int i=0; i<matrix.GetLength(0);i++)
    {
        for (int j=0;j<matrix.GetLength(1);j++)
        {            
            newMatrix[j,i]=matrix[i,j];
        }
    }
    return newMatrix;
}
int row = int.Parse(Console.ReadLine()?? "0");
int column = int.Parse(Console.ReadLine()?? "0");
int [,] matrix = CreateMatrix(row,column,0,20);
if (matrix.GetLength(0)!=matrix.GetLength(1))
{
    Console.WriteLine("Unable to create a table");
}
else
{
    PrintMatrix(matrix);
    Console.WriteLine();
    int [,]matrixFinal=ChangesRowsToColuns(matrix);
    Console.WriteLine();
    PrintMatrix(matrixFinal);
}