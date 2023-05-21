// на вход два числа, является ли первое квадртаом 2го?
// a = 25 b = 5 -> да
// a = 2 b = 10 -> нет
// a = 9 b = -3 -> да
// a = -3 b = 9 -> нет
Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondtNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber == secondtNumber * secondtNumber)
{
    Console.WriteLine("Число " + firstNumber + " является квадратом числа " + secondtNumber);
}
else 
{
    Console.WriteLine("Число " + firstNumber + " НЕ является квадратом числа " + secondtNumber);
}