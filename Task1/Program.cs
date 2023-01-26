int[] points = new int[2];

for (int i = 0; i < points.Length; i++)
{
    points[i] = Convert.ToInt32(Console.ReadLine());
}
// points[0] - x, points[1] - y. [[,y]]
if (points[0] > 0 && points[1] > 0)
Console.WriteLine("1");
if (points[0] < 0 && points[1] > 0)
Console.WriteLine("2");
if (points[0] < 0 && points[1] < 0)
Console.WriteLine("3");
if (points[0] > 0 && points[1] < 0)
Console.WriteLine("4");
