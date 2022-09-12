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
(int,int)? SearchPosition(int [,] matrix, int value)
{    
    for (int i=0;i<matrix.GetLength(0);i++)
        for(int j=0;j<matrix.GetLength(1);j++)
            if(matrix[i,j]==value) return (i,j);
        return null;    

}
int [,] matrix = CreateMatrix(5,5,-10,10);
PrintMatrix(matrix);
Console.Write("Enter element to find: ");
int value = int.Parse(Console.ReadLine() ?? "0");
(int,int)? position = SearchPosition(matrix,value);
Console.WriteLine(position == null 
    ? "Element not found" 
    : $"Position of element: ({position.Value.Item1},{position.Value.Item2})");