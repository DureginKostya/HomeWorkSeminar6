/*Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
Console.Clear();
int[,] getСoefficientsOfPoints(string msg, int row_col)
{    
    int[,] matrix = new int[row_col,row_col];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.WriteLine($"{msg} {i + 1} уравнения: y = k{i + 1} * x + b{i + 1}");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           switch (j)
           {
                case 0:
                {
                    Console.Write($"k{i + 1} = ");
                    break;                    
                }
                case 1:
                {
                    Console.Write($"b{i + 1} = ");
                    break;
                }
           }
           matrix[i,j] = int.Parse(Console.ReadLine()!);           
        }        
    }
    return matrix;
}
double[] getIntersectionPoint(int[,] matrix)
{
    double[] array = new double[matrix.GetLength(0)];
    array[0] = (double)(matrix[1,1] - matrix[0,1]) / (matrix[0,0] - matrix[1,0]);
    array[1] = matrix[0,0] * array[0] + matrix[0,1];
    return array;
}
void showResult(int[,] matrix)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"Прямые уравнений: y = {matrix[0,0]} * x{((matrix[0,1] >= 0)? $" + {matrix[0,1]}" : $" - {-matrix[0,1]}")}  и  y = {matrix[1,0]} * x{((matrix[1,1] >= 0)? $" + {matrix[1,1]}" : $" - {-matrix[1,1]}")}");  
    Console.ResetColor();
    if (matrix[0,0] != matrix[1,0]) // Если равны, то прямые параллельны или совпадают
    {
        double[] array = getIntersectionPoint(matrix);
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"Пересекаются в точке: x = {Math.Round(array[0], 2)} и y = {Math.Round(array[1], 2)}");
        Console.ResetColor();
    }
    else if (matrix[0,1] == matrix[1,1])
         {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Имеют бесконечное множество точек пересечения, лежат друг на друге");
            Console.ResetColor();
         }           
         else    
         {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Не имеют точку пересечения, они параллельные");
            Console.ResetColor();
         }         
}
int[,] coefficients = getСoefficientsOfPoints("Введите коэффициенты", 2);
Console.WriteLine();
showResult(coefficients);


