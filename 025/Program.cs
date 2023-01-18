// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число В: ");
int b = Convert.ToInt32(Console.ReadLine());

int degree(int deg)
{
    int step = 0;
    step = Convert.ToInt32(Math.Pow(a, b));
    return step;
}

Console.WriteLine($"Число А, возведенное в степень числа В равно {degree(a)} ");