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
int [] SumOfRow(int [,] matrix)
{
    int [] numbers = new int [matrix.GetLength(0)];
    for (int i=0;i<matrix.GetLength(0);i++)
    {   
        int value = 0;
        for(int j=0;j<matrix.GetLength(1);j++)
        {
            value=value+matrix[i,j];
        }
     numbers[i]=value;
    }
 return numbers;
}
int TheLargestNuber(int [] array)
{   
    int min=array[0];
    int index=-1;
    for (int i=0;i<array.Length;i++)
    {
        if (array[i]<=min)
        {
            min=array[i];
            index=i+1;
        } 
    }
    return index;
}
int [,] matrix = CreateMatrix(3,6,-10,20);
PrintMatrix(matrix);
int [] number = SumOfRow(matrix);
int result=TheLargestNuber(number);
Console.Write ($"The row with the smallest sum of elements: {result}");
