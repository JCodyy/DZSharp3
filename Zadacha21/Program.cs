// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите координаты ");

int x1 = ReadInt("x1 =  ");
int y1 = ReadInt("y1 =  ");
int z1 = ReadInt("z1 =  ");
int x2 = ReadInt("x2 =  ");
int y2 = ReadInt("y2 =  ");
int z2 = ReadInt("z2 =  ");

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Длинна отрезка {length}");




int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}