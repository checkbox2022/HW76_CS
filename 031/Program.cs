// Показать кубы чисел, заканчивающихся на четную цифру

System.Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("");    
for (int z = 1; z<=a; z++)
    {
        int b = Convert.ToInt32(Math.Pow(z,3));
        if (b%2==0)
        {
            System.Console.Write($" {b} \t");
        }
    }