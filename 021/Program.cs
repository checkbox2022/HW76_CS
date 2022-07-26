// Задать номер четверти, показать диапазоны для возможных координат

System.Console.WriteLine("Введите номер четверти:");
int n = Convert.ToInt32(Console.ReadLine());
if (n==1)System.Console.WriteLine("x>0 & y>0");
if (n==2)System.Console.WriteLine("x<0 & y>0");
if (n==3)System.Console.WriteLine("x<0 & y<0");
if (n==4)System.Console.WriteLine("x>0 & y<0");