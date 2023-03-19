// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Enter Your Number");
int x = Convert.ToInt32(Console.ReadLine());
int a = x / 1000;
int b = x % 100;
if((a % 10 == b / 10) && (a / 10 == b % 10))
    Console.WriteLine("Your number is a palindrome");
else
    Console.WriteLine("Your number is not a palindrome");