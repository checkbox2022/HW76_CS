// Найти сумму чисел от 1 до А

System.Console.Write("Введите число от 1 до А: ");
int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 1;i<=a;i++)
{
    sum = sum+i;
}
System.Console.WriteLine(sum);