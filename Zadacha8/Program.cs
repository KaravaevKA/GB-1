Console.WriteLine("Введите число");

int Number = Convert.ToInt32(Console.ReadLine());

int Count = 1;

while (Count <= Number)
{
    if (Count % 2 == 0)
    {
        Console.WriteLine(Count);
    }
    Count++;
}