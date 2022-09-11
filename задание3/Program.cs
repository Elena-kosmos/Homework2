Console.Write("ведите цифру,обозначающую день недели ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
if(dayNumber == 6 || dayNumber ==7) Console.Write("выходной");
else if (dayNumber<1 || dayNumber>7) Console.Write("это не день недели");
else Console.Write("это будни");