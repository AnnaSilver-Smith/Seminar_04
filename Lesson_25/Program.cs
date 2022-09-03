// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Write("Введите переменную A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите переменную B: ");
int b = Convert.ToInt32(Console.ReadLine());
int step = a;
for (int i = 1; i < b; i++)
{
    step = step * a;
}
Console.WriteLine($"{a} в степени {b} -> " + step);