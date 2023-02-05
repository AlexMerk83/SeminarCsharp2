// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

int num = new Random().Next(10, 100);

System.Console.WriteLine(num);

int maxDigit = num % 10;

while (num > 0)
{
    if (num % 10 > maxDigit) maxDigit = num % 10;
    num /= 10;     
}

System.Console.WriteLine(maxDigit);