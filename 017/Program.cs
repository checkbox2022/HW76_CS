// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

System.Console.WriteLine("Введите число от 1 до 7");
int a = Convert.ToInt32(Console.ReadLine());
if (a<1||a>7) System.Console.WriteLine("Вы ввели неверное число!");
else
{
    if(a>0&&a<6) System.Console.WriteLine("Введенный Вами день недели НЕ является выходным днем!");
    else System.Console.WriteLine("Введенный Вами день недели является выходным днем!");
}
