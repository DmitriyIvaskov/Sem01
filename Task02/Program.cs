Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondtNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondtNumber)
{
    Console.WriteLine("Число " + firstNumber + " больше " + secondtNumber);
}
else
{
    Console.WriteLine("Число " + secondtNumber + " больше " + firstNumber);
}