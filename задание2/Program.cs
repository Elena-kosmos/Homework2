Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string numtext = Convert.ToString(num);
if(numtext.Length>2)
{
    Console.WriteLine("третья цифра" + numtext[2]);
}
else 
{
  Console.WriteLine("нет 3 цифры");  
}



