// По двум заданным числам проверять является ли одно квадратом другого. Используйте подпрограмму.

bool square_number (int a, int b)
{
   return a*a==b || b*b==a; 
}
System.Console.WriteLine("Введите два числа:");
int x=Convert.ToInt32(Console.ReadLine());
int z=Convert.ToInt32(Console.ReadLine());

if(square_number(x,z)) System.Console.WriteLine("Одно из чисел является квадратом другого");
else System.Console.WriteLine("Ни одно из чисел не является квадратом другого");