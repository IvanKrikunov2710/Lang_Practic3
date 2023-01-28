string[] output = { "x > 0, y > 0", "x < 0, y > 0", "x < 0, y < 0", "x > 0, y < 0"};
int number = Convert.ToInt32(Console.ReadLine());
// 1,2,3,4
// 0,1,2,3
if (number < 5 && number > 0)
    Console.WriteLine(output[number - 1]);
else
    Console.WriteLine("input incorrect");