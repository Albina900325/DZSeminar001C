Console.WriteLine("введите числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
int min = b;
if (a > b) max = a;
if (a > b) min = b;
if (a < b) max = b;
if (a < b) min = a;
Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min= ");
Console.WriteLine(min);