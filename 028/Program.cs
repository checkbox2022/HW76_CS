// Определить количество цифр в числе. Сделать подпрограмму.

System.Console.Write("Введите любое число: ");
int a = Convert.ToInt32(Console.ReadLine());
int CountNumbers (int x)
{
    if (x==0) return 1;
int count=0;
while (x!=0)
{
    x/=10;
    count++;
}
return count;
}
System.Console.WriteLine(CountNumbers(a));