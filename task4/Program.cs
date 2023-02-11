//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = Math.Max(num1, Math.Max(num2, num3));
Console.WriteLine($"Максимальое число - {max}");