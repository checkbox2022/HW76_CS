﻿// Удалить вторую цифру целого числа с конца (правого края) введенного с клавиатуры.
System.Console.Write("Введите число: ");
int a=Convert.ToInt32(Console.ReadLine());
int b=a%10; // получаем крайнюю цифру
int c=a/100; // делим на 100, чтобы отбросить крайнюю и предпосл. цифру, т.к. обе из них пойдут в остаток (24573/100=245.73)
System.Console.WriteLine(c*10+b); /* с*10 для того чтобы 245.73 привести к 2450 (т.к. это int) 
и после прибавить 3 (т.к. это b - остаток от a)*/