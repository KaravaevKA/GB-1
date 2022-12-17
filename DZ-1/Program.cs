Console.Write("Введите первое число: ");

int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");

int number2 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if (number1 > number2) max=number1;
if (number1 < number2) max=number2;

Console.Write("max = ");
Console.Write(max);
