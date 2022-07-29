/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

bool check = false;
int size = 0;
int k = 0;

Console.Write("Введите пятизначное число:");
string userEnter = Console.ReadLine();

check = int.TryParse(userEnter, out size);

if (check)
{
    for (int i = 0; i < 2; i++)
        if (userEnter[i] != userEnter[4-i])
        {
            k = 1;
            break;
        } 
}
else 
{
    Console.WriteLine("Вы ввели не число!");
    return;
}    
if (k==0)
{
    Console.WriteLine($" {userEnter} -> да");
}
else
{
    Console.WriteLine($" {userEnter} -> нет");
}
