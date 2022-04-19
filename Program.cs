/*
//задача 1 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Input first int number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second int number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
    Console.WriteLine(num1 + " is bigger than " + num2);
else
    Console.WriteLine(num2 + " is bigger than " + num1);
*/
//задача 2 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Input first int number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second int number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input третье int number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2 && num1 > num3)
    Console.WriteLine(num1);
if(num2 > num1 && num2 > num3)
    Console.WriteLine(num2);
if(num3 > num1 && num3 > num2)
    Console.WriteLine(num3);
*/

//задача 3 Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Input int num: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0)
    Console.WriteLine("Число четное!");
else
    Console.WriteLine("Число нечетное! :(");
*/
//задача 4 Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Input int num ");
int N = Convert.ToInt32(Console.ReadLine());
int c = 2;

while(c <= N)
{
    Console.Write(c + " ");
    c = c + 2;
}   
