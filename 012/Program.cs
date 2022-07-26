// Дано целое число из  диапозона  [10, 99]. Показать наибольшую цифру числа
int a = new Random().Next(10,99);
System.Console.WriteLine($"Cлучайно сформированноe число =  {a}");
int b = a/10;
int c = a%10;
if (b<c) System.Console.WriteLine($"В случайно сформированном числе {a} наибольшей цифрой является {c}");
else System.Console.WriteLine($"В случайно сформированном числе наибольшей цифрой является {b}");

/* или
int d = Math.Max(b,c)
System.Console.WriteLine(d) - т.е. без if else*/
