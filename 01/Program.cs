// Напиште программу на выходе дает квадрат числа:

Console.Write("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine()); // Переменная number - целое число (int) = 5
// Конвертировали в ToInt32 - это целые числа 32ух разрядные 
int result = number * number; // Если набэр = 5 то ресалт 5 * 5 = 25 (это епрвый способ)

double resultPartTwo = Math.Pow(number, 2); // набер возводиться во 2 стпень Math.Pow(число, степень)

Console.WriteLine("Число " + number + " в квадртае:" + result);
Console.WriteLine("Число " + number + " в квадртае:" + resultPartTwo);