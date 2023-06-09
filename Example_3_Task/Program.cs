/*Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда 
5 -> Пятница
*/

Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());
Dictionary<int, string> map = new Dictionary<int, string>()
{
    { 1, "Monday"},
    { 2, "Tuesday"},
    { 3, "Wensday"},
    { 4, "Thursday"},
    { 5, "Friday"},
    { 6, "Saturday"},
    { 7, "Sunday"}
};
if (n > 0 && n < 8)
{
    Console.WriteLine(map[n]);
}
else
{
    Console.WriteLine($"Mistake, there is 7 days in a week.");
}
