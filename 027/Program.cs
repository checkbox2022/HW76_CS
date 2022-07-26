// Возведите число А в натуральную степень B используя цикл

System.Console.Write("Введите число, которое вы хотите возвести в степень: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Укажите степень для введеного числа : ");
int b = Convert.ToInt32(Console.ReadLine());
int res=1;
for (int i = 0; i<b;i++)
{  
    res=res*a;
}
System.Console.WriteLine(res);