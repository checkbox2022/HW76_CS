// Программа проверяет пятизначное число на палиндромом.

System.Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a/10000==a%10&&a/1000%10==a/10%10) System.Console.WriteLine("True");
else System.Console.WriteLine("False");



