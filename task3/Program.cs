// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Enter Your Number");
int N = Convert.ToInt32(Console.ReadLine());
double a = 0;
for (int i = 1; i <= N; i++)
{
    if(i == N)
    {
        a = Math.Pow(i, 3);
        Console.Write($"{a}");
    }
    else
    {
        a = Math.Pow(i, 3);
        Console.Write($"{a}, ");
    }
}
