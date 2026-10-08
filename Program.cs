Console.WriteLine("Введите первую сторону ");
double a = double.Parse(Console.ReadLine());

Console.WriteLine("Введите вторую  сторону ");
double b = double.Parse(Console.ReadLine());

Console.WriteLine("Введите третью сторону ");
double c = double.Parse(Console.ReadLine());

double pp = (a+b+c)/2;
Console.WriteLine($"Полупериметр: {pp} ");

Console.WriteLine($"Периметр: {a+b+c} ");
Console.WriteLine($"Площадь по Герону: {Math.Sqrt(pp*(pp-a)*(pp-b)*(pp-c)):F2} ");

