/*Задача №1. Напишите программу, которая на вход 
принимает два числа и проверяет, является ли первое
 число квадратом второго.
a = 25, b = 5 -> да 
a = 2, b = 10 -> нет 
a = 9, b = -3 -> да 
a = -3 b = 9 -> нет
*/
Console.Write("Input number 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2 * number2)
{
    Console.Write($"Yes, {number1} is a square of {number2}.");
}
else
{
    Console.Write($"No, {number1} is not a square of {number2}.");
}