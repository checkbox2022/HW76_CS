// Найти расстояние между точками в пространстве 2D. Теорема Пифагора с^2=a^2+b^2

double Distance (double a1, double b1, double a2, double b2)
{
    return Math.Sqrt(Math.Pow(a2-a1,2)+Math.Pow(b2-b1,2)); /* Math.Sqrt вычисление квадратного корня;
    Math.Pow(значение, степень) - возводит значение в необходимую степень */
}

double x1=0, y1=0, x2 = 10, y2 = 10;
System.Console.WriteLine(Distance(x1,y1,x2,y2));
