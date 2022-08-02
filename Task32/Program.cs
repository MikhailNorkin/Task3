/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53

*/

int[] arrayX = new int[3];
int[] arrayY = new int[3];

int[] Vvod(int[] array) 
{
    for(int i = 0; i < 3; i++)
    {
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

Console.WriteLine($"Введите координаты первой точки:");
Vvod(arrayX);
Console.WriteLine($"Введите координаты второй точки:");
Vvod(arrayY);
double rez = 0;
rez = MathF.Sqrt((arrayY[0]-arrayX[0])*(arrayY[0]-arrayX[0])+
                +(arrayY[1]-arrayX[1])*(arrayY[1]-arrayX[1])
                +(arrayY[2]-arrayX[2])*(arrayY[2]-arrayX[2]));
Console.WriteLine($"Расстояние между точками равно {rez}");