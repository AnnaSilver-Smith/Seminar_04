// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write($"{a} = ");
int sum = 0;
while (a > 0)
{
    int num = a % 10;
    sum = sum + num;
    a = a / 10;
}
Console.WriteLine(sum);