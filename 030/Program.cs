// Написать программу вычисления произведения чисел от 1 до N

System.Console.Write("Введите любое число (int): ");
int a = Convert.ToInt32(Console.ReadLine());
int prod=1;
for(int i = 1;i<=a;i++)
{
    prod*=i;
}
System.Console.WriteLine(prod);
