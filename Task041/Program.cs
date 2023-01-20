/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
Console.Clear();
int getUserData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}
int[] enterNumber(int number)
{
    int[] array = new int[number];
    for (int i = 0; i < number; i++)
    {
        Console.Write($"Введите число №{i + 1} : ");
        array[i] = int.Parse(Console.ReadLine()!);
    }
    Console.WriteLine();
    return array;
}
void printArrayAndNumbersPositive(string msg, int[] array)
{
    int count = 0;
    Console.Write($"{msg}");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}]");
        if (array[i] > 0) count++;
    }
    Console.WriteLine($" - {((count != 0)? $"количество чисел больше 0 равно {count}" : "числа больше 0 не вводили")}");
}
int numberUser = getUserData("Введите количество чисел, которое хотите ввести: ");
int[] numbersArray = enterNumber(numberUser);
printArrayAndNumbersPositive($"Введены следующие числа [", numbersArray);