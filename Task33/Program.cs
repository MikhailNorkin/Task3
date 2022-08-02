/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int a = 0;

void function(int a)
{
    Console.Write($"{a} -> ");
    int res = 0;
    for(int i = 1; i <= a; i++)
    {
        res = i*i*i;
        Console.Write($" {res}");
    }
    Console.WriteLine();
    return;

}

Console.Write($"Введите число: ");
function(int.Parse(Console.ReadLine()));