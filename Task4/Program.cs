Console.WriteLine("Введите число");

int number = Convert.ToInt32(Console.ReadLine());
int i = 1;
if (i == 1)
{
    i = i + 1;
}

while (i <= number)
{
    Console.WriteLine(i);
    i = i + 2;
}