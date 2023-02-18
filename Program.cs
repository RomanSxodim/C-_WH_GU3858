
/*

// Задача: Написать программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.

Console.Write("Введите первое число " );
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число " );
int num2 = Convert.ToInt32(Console.ReadLine());


if (num1 > num2)
{
    Console.WriteLine("Число " + num1 + " больше, чем число " + num2);
}
else
{
    Console.WriteLine("Число " + num2 + " больше, чем число " + num1);
}


*/

/*

// Задача : Написать программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число " );
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число " );
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число " );
int num3 = Convert.ToInt32(Console.ReadLine());


if (num1 > num2)
{
    if (num1 > num3)
    {
       Console.WriteLine("Число " + num1 + " максимальное из чисел: " + num1 + ", "+ num3 + " и " + num2); 
    }
    else 
    {
        Console.WriteLine("Число " + num3 + " максимальное из чисел: " + num3 + ", " + num2 + " и " + num1); 
    }
}
else
{
    if (num2 > num3)
    {
        Console.WriteLine("Число " + num2 + " максимальное из чисел: " + num2 + ", " + num3 + " и " + num1); 
    }
    else 
    {
        Console.WriteLine("Число " + num3 + " максимальное из чисел: "  + num3 + ", " + num2 + " и " + num1); 
    }
}

*/


/*

//Задача: Написать программу, которая на вход принимает число и выдаёт,
//  является ли число чётным (делится ли оно на два без остатка).


Console.Write("Введите число " );
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = num1 % 2;
if (num2 == 0)
    {
       Console.WriteLine("Число " + num1 + " является четным"); 
    }
    else 
    {
        Console.WriteLine("Число " + num1 + " является не четным "); 
    }

*/


// Задача 8: Написать программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число " );
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = 2; 
if (num1 == 1)
    {
      Console.WriteLine("Число " + num1 + " не имеет в своем составе четных чисел"); 
    }
    else 
       
while(num1 >= num2)
{
    Console.Write(num2 + " ");
    num2 += 2;
}





