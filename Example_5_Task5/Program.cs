/*Задача №7. Напишите программу, которая принимает
 на вход трёхзначное число и на выходе показывает 
 последнюю цифру этого числа.
 456 -> 6
 782 -> 2
 918 -> 8
*/

using System;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.Write("Введите трёхзначное число: ");
double n = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(n % 10); // Чтобы перевести число в десятичную дробь получить число после запятой.
