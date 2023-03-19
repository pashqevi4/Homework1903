// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Enter xA");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter yA");
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter zA");
int zA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter xB");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter yB");
int yB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter zB");
int zB = Convert.ToInt32(Console.ReadLine());
double dist = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2));
Console.WriteLine($"The distance between your coordinates {Math.Round(dist, 2)}");