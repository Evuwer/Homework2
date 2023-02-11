//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("a = ");
Console.Write(num1 );
Console.Write(" ");
Console.Write("b = ");
Console.WriteLine(num2 );
if (num1 > num2)
Console.WriteLine($"{num1} больше {num2}");
else
Console.WriteLine($"{num2} больше {num1}");
