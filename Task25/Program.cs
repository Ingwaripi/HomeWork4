// 1Напишите цикл, который принемает на вход два числа(А и B)
// 2Возводит число А в натуральную степень B

Console.Write("Введите певое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int i = 0;
int work = 1;
while (i < num2)
{
    work = num1 * work;
    i++;
}
Console.WriteLine($"{num1} в степени {num2} равна: {work}");