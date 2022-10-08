//--------------------------ДОМАШНЕЕ ЗАДАНИЕ-------------------------------------------------------------------------------------------------------

//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 

/*Console.WriteLine("Введите пятизначное число: ");
string x = Console.ReadLine()!;

if (x.Length == 5)
{
    int a = Convert.ToInt32(x[0]);
    int b = Convert.ToInt32(x[4]);
    int c = Convert.ToInt32(x[1]);
    int d = Convert.ToInt32(x[3]);
    if ((a == b) && (c == d))
    {
    Console.WriteLine($"{x} является палиндромом");
    }
    else
    {
    Console.WriteLine($"{x} не является палиндромом");
    }
}
else
{
    Console.WriteLine($"{x} не является пятизначным числом");
}*/

//Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*Console.WriteLine("Введите координату первой точки по оси абсцисс: ");
int xa = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату первой точки по оси ординат: ");
int ya = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату первой точки по оси аппликат: ");
int za = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату второй точки по оси абсцисс: ");
int xb = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату второй точки по оси ординат: ");
int yb = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату второй точки по оси аппликат: ");
int zb = int.Parse(Console.ReadLine()!);

double ab = Math.Sqrt(Math.Pow((xb - xa), 2) + (Math.Pow((yb - ya), 2)) + (Math.Pow((zb - za), 2)));

Console.WriteLine($"{ab} - расстояние между точкой с координатами ({xa},{ya},{za}) и точкой с координатами ({xb},{yb},{zb})");

Console.WriteLine($"{ab:f2} - округлённый вариант");*/

//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*Console.WriteLine("Введите число больше 1: ");
int N = int.Parse(Console.ReadLine()!);

int i = 1; 

if (N < 1) 
{
    Console.WriteLine("Число не соответствует условию");
}
while (i < N){
    Console.Write($"{i*i*i}, ");
    i = i + 1;
}
Console.Write($"{N*N*N}");*/


