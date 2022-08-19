// Задача 23
// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Clear();

Console.WriteLine("Enter N");
int N = int.Parse(Console.ReadLine()!);


int index = 0;
int result = 0;
    
while(index < N)
{
    result = (index+1)*(index+1)*(index+1);
    Console.WriteLine(result);
    index++;
}