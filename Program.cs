/* Console.WriteLine("Введите номер четверти: ");
int number = int.Parse(Console.ReadLine()!);

switch (number)
{
    case 1:
        Console.WriteLine("x>0, y>0");
        break;
    case 2:
        Console.WriteLine("x<0, y>0");
        break;
    case 3:
        Console.WriteLine("x<0, y<0");
        break;
    case 4:
        Console.WriteLine("x>0, y<0");
        break;
    default:
        Console.WriteLine("Неверный номер четверти");
        break;
}*/

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

/*Console.WriteLine("Введите координату первой точки по оси абсцисс: ");
int ax = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату первой точки по оси ординат: ");
int ay = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату второй точки по оси абсцисс: ");
int bx = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату второй точки по оси ординат: ");
int by = int.Parse(Console.ReadLine()!);

double AB = Math.Sqrt(Math.Pow((bx - ax), 2) + (Math.Pow((by - ay), 2)));

Console.WriteLine($"{AB} - расстояние между точкой с координатами ({ax},{ay}) и точкой с координатами ({bx},{by})");*/

//Напишите программу, которая принимает на вход число (N) и выдаёт квадраты чисел от 1 до N.

/*Console.WriteLine("Введите число больше 1: ");
int N = int.Parse(Console.ReadLine()!);

int i = 1; 

if (N < 1) 
{
    Console.WriteLine("Число не соответствует условию");
}
while (i < N){
    Console.Write($"{i*i}, ");
    i = i + 1;
}
Console.Write($"{N*N}");*/

//Напишите программу, которая принимает на вход шестизначное число (N) и проверяет, является ли оно "счастливым".

/*
Console.WriteLine("Введите шестизначное число: ");
int number = int.Parse(Console.ReadLine()!);

int a = 0;
int b = 0;
int c = 0;
int d = 0;
int e = 0;
int f = 0;


if ((number < 100000) || (number > 999999))
{
    Console.WriteLine($"{number} не является шестизначным числом");
}
else
{
    /*
    a = number / 100000; 
    b = number / 10000 - a * 10; 
    c = number / 1000 - a * 100 - b * 10;  
    d = number / 100 - a * 1000 - b * 100 - c * 10; 
    e = number / 10 - a * 10000 - b * 1000 - c * 100 - d * 10; 
    f = number % 10; 

ИЛИ

*/
/* a = number / 100000;
 b = (number / 10000) % 10; 
 c = (number / 1000) % 10;
 d = (number % 1000) / 100;
 e = (number % 100) / 10;
 f = number % 10;

 //Console.WriteLine($"{a}, {b}, {c}, {d}, {e}, {f}");
}
 if (a + b + c == d + e + f)
 {
     Console.WriteLine($"{number} - счастливое число!");
 }
 else
 {
     Console.WriteLine($"{number} - несчастливое число:(");
 }*/

//СТРОКИ 

/*Console.WriteLine("Введите шестизначное число: ");
string x = Console.ReadLine()!;

if (x.Length == 6){ 
    int a = Convert.ToInt32(x[0] + x[1] + x[2]);
    int b = Convert.ToInt32(x[3] + x[4] + x[5]);
    if (a == b)
    {
        Console.WriteLine($"{x} - счастливое число:)");
    }
    else
    {
        Console.WriteLine($"{x} - несчастливое число:(");
    }
}
else
{
    Console.WriteLine($"{x} - не шестизначное число");
}*/

//--------------------------ДОМАШНЕЕ ЗАДАНИЕ----------------------------

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


