Console.WriteLine("Введите 1 число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.Write("max = ");
    Console.WriteLine(number1);
    Console.Write("min = ");
    Console.WriteLine(number2);
}
else if (number2 > number1)
{
    Console.Write("max = ");
    Console.WriteLine(number2);
    Console.Write("min = ");
    Console.WriteLine(number1);
}