/*
// Напишите программу, которая принимает на вход
// пятизначное число и проверяет,  является ли оно палиндромом.



Console.WriteLine("Введите число: ");
string num = Console.ReadLine();
int len = num.Length;

if (len == 5)

    if (num[0] == num[4] && num[1] == num[3])
    Console.WriteLine($"{num} - да");
    else Console.WriteLine($"{num} - нет");
    else
{
    Console.WriteLine("ВЫ ввели не пятизначное число");
}

*/

/*
// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 3D пространстве.


int x1 = Cord("Введите координату X первой точки: ");
int x2 = Cord("Введите координату X второй точки: ");
int y1 = Cord("Введите координату Y первой точки: ");
int y2 = Cord("Введите координату Y второй точки: ");
int z1 = Cord("Введите координату Z первой точки: ");
int z2 = Cord("Введите координату Z второй точки: ");

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Расстояние между точами {length}");

int Cord(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

*/


// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.




int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int number = ReadInt("Введите число N: ");
for (int i = 1; i <= number; i++)
Console.Write($"{i*i*i} ");






