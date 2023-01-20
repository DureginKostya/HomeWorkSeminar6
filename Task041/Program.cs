/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
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
void enterNumber(string msg, int number)
{
    string str = string.Empty;
    int count = 0;    
    for (int i = 0; i < number; i++)
    {
        Console.Write($"Введите число № {i + 1} : ");
        int enterNumber = int.Parse(Console.ReadLine()!);
        if ( enterNumber > 0) 
            count++;
        if (i != number - 1) 
            str += Convert.ToString(enterNumber) + ", ";        
        else 
            str += Convert.ToString(enterNumber) + "]";      
    }  
    Console.Write($"{msg}{str} - ");
    Console.ForegroundColor = ConsoleColor.DarkBlue; 
    Console.WriteLine($"{((count != 0)? $"количество чисел больше 0 равно {count}":"числа больше 0 не вводили" )}");
    Console.ResetColor();
}
int numberUser = getUserData("Введите количество чисел, которое хотите ввести: ");
enterNumber($"Введены числа [", numberUser);