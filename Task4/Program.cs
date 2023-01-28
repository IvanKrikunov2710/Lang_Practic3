double x = 0, y = 0, x1 = 0, y1 = 0, ab = 0;
x = Convert.ToDouble(Console.ReadLine());
y = Convert.ToDouble(Console.ReadLine());
x1 = Convert.ToDouble(Console.ReadLine());
y1 = Convert.ToDouble(Console.ReadLine());
ab=Math.Sqrt((x1-x)*(x1-x) + (y1-y)*(y1-y));
Console.WriteLine(ab);