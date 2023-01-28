/*double x = 0, y = 0, x1 = 0, y1 = 0, ab = 0;
x = Convert.ToDouble(Console.ReadLine());
y = Convert.ToDouble(Console.ReadLine());
x1 = Convert.ToDouble(Console.ReadLine());
y1 = Convert.ToDouble(Console.ReadLine());
ab=Math.Sqrt((x1-x)*(x1-x) + (y1-y)*(y1-y));
Console.WriteLine(ab);*/

double ab = 0;
double [] point = new double[4];
for (int i = 0; i < point.Length; i++)
    point[i] = Convert.ToDouble(Console.ReadLine());
    ab = Math.Sqrt((point[0]-point[2])*(point[0]-point[2])+(point[1]-point[3])*(point[1]-point[3]));
    Console.WriteLine(ab);