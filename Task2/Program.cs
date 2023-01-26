// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y)
int kord;
kord = Convert.ToInt32(Console.ReadLine());
if (kord == 1)
Console.WriteLine("x>0, y>0");
if (kord == 2)
Console.WriteLine("x<0, y>0");
if (kord == 3)
Console.WriteLine("x<0, y<0");
if (kord == 4)
Console.WriteLine("x>0, y<0");