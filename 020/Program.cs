// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
System.Console.WriteLine("Введите координаты Х и У:");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());

if (x>0&&y>0)System.Console.WriteLine("I");
if (x<0&&y>0)System.Console.WriteLine("II");
if (x<0&&y<0)System.Console.WriteLine("III");
if (x>0&&y<0)System.Console.WriteLine("IV");