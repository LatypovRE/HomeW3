Console.WriteLine("Введите координаты точки А");
Console.WriteLine("Введите координаты точки А по оси X");
int XpointA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки А по оси Y");
int YpointA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки А по оси Z");
int ZpointA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
Console.WriteLine("Введите координаты точки B по оси X");
int XpointB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B по оси Y");
int YpointB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B по оси Z");
int ZpointB = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt ((XpointA - XpointB)* (XpointA - XpointB) + (YpointA - YpointB) * (YpointA - YpointB) + (ZpointA - ZpointB)*(ZpointA -ZpointB));

Console.WriteLine("Растояние между точками А и B в 3D равняется"  + Math.Round(result,2));

