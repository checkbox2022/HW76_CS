// Таблица умножения от 1 до N (случайно сделал не то задание <<<< получилось так)
System.Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
  for (int x = 1;x<=a;x++)
    {
        System.Console.Write($"\t|{x}|"); // горизонтальная строка с |N|
    }
    System.Console.WriteLine("");
for (int i = 1;i<=a;i++)
{
    System.Console.Write($"|{i}|\t"); // вертикальная строка с |N|
    for (int z = 1; z<=a; z++)
    {
        int b = z*i;
        System.Console.Write($" {b}\t");
    }
    System.Console.WriteLine("");
}