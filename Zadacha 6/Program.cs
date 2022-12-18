Console.WriteLine("Введите число: ");

int Number = Convert.ToInt32(Console.ReadLine());

if (Number % 2 == 0) 
{
    Console.WriteLine("Да, число четное");
}
else Console.WriteLine("Нет, число нечетное");