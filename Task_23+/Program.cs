// Задача 23
// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
//пробую решить задачу через функцию и массив.
Console.Clear();

int CUBE(int a)
{
    int result = 0;
    int[] array = {};
    
    for (int i = 0; i < a; i++)
    {
        result = (i+1)*(i+1)*(i+1);
        array[i] = result;
    }
    return array;//не дает вернуть массив
}

Console.WriteLine("Enter N");
int N = int.Parse(Console.ReadLine()!);

if(N<0)
    return;
int array = CUBE(N);

Console.WriteLine(array);