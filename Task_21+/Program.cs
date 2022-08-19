// Задача 21
// Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 3D 
//пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
//Пробую написать программу, в которой нужно один раз 
//вводить все координаты точки.
Console.Clear();

Console.WriteLine("Введите координаты первой точки с пробелами между цифрами. Типа \nx y z");
string xyz = Console.ReadLine()!;
//Console.WriteLine(xyz);

char[] XYZ = new char[xyz.Length];

int i=0;
//Console.WriteLine(XYZ);
int[] x1 = new int[]{};

if(Char.IsWhiteSpace(xyz, i))
{
     Console.WriteLine("Error");
 }
 else
 {
     x1[i] = ;
     Console.WriteLine(x1);
 }

