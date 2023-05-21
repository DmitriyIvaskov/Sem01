int i = 1;
bool not = true;

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

while (i <= number)
{
    if (i % 2 != 1)
    {
        Console.Write(i + ", ");
        not = false;
    }
    i++;
}

if (not)
{
    Console.WriteLine("нет чётных чисел");
}