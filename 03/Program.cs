// Программа которая принимает целое число N а на выходе показывает все целые в промежутке -N до N

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int negativeN = N * (-1);

while (negativeN <= N)
{
    Console.WriteLine(negativeN);
    negativeN = negativeN + 1; // или negativeN ++
}