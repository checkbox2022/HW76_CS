// Вывести на экран кубы чисел от 1 до N

System.Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
for (int x = 1;x<=a;x++)
    {
        System.Console.Write($"|{x}^3|\t"); // горизонтальная строка с |N|
    } 
System.Console.WriteLine("");    
for (int z = 1; z<=a; z++)
    {
        int b = Convert.ToInt32(Math.Pow(z,3));
        System.Console.Write($" {b} \t");
    }