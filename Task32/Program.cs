/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53


int x1 = 0, x2 =0, x3 =0 , y1 =0, y2 = 0, y3 = 0;

Console.WriteLine($"Введите координаты первой точки:"!);
Console.Write($"X1 = "!);
x1 = int.Parse(Console.ReadLine());
Console.Write($"Y1 = "!);
y1 = int.Parse(Console.ReadLine());
Console.WriteLine($"Введите координаты второй точки:"!);
Console.Write($"X2 = "!);
x2 = int.Parse(Console.ReadLine());
Console.Write($"Y2 = "!);
y2 = int.Parse(Console.ReadLine());
Console.WriteLine($"Введите координаты третьей точки:"!);
Console.Write($"X3 = "!);
x3 = int.Parse(Console.ReadLine());
Console.Write($"Y3 = "!);
y3 = int.Parse(Console.ReadLine());
*/

int[] arrayX = new int[3];
int[] arrayY = new int[3];

int[] array
{
    for(int i = 0; i < 3; i++)
    {
        array[i] = int.Parse(Console.ReadLine());
    }
    return;
}



Console.WriteLine($"Введите координаты первой точки:");
Vvod(arrayX);
Console.WriteLine($"Введите координаты второй точки:");
Vvod(arrayY);
Console.WriteLine($"{arrayX[1]-arrayY[1]}");
/*Console.WriteLine(MathF.Sqrt((y1-x1)*(y1-x1)+(y2-x2)*(y2-x2)+(y3-x3)*(y3-x3)));*/