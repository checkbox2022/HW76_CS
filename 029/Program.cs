// Подсчитать сумму цифр в числе
System.Console.Write("Введите любое число (int): ");
int a = Convert.ToInt32(Console.ReadLine());
int sum=0;
while (a>0)
{
    sum += a%10; // sum = sum + a%10
    a/=10;  // a = a/10
}
System.Console.WriteLine(sum);