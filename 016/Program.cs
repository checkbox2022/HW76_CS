﻿// Дано число. Проверить кратно ли оно 7 и 23

int a = Convert.ToInt32(Console.ReadLine());
bool b=a%7==0 && a%23==0; // должно быть кратно и 7 и 23 одновременно
System.Console.WriteLine(b);

// Также можно добавить

if (b)System.Console.WriteLine("Кратно");
else System.Console.WriteLine("Не кратно");