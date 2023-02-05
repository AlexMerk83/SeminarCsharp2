bool isWork = true;

while (isWork)
{
    System.Console.WriteLine();
    System.Console.WriteLine("1 - Task 09: Max digit of a random number between 10 and 99");
    System.Console.WriteLine("2 - Task 11: First and last digits of a random 3-digit number");
    System.Console.WriteLine("0 - Exit");
    System.Console.Write("Enter a number of task: ");

    if (int.TryParse(Console.ReadLine(), out int taskNo))
    {
        System.Console.WriteLine();

        switch (taskNo)
            {
                case 1: // Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
                {
                    int num = new Random().Next(10, 100);

                    System.Console.WriteLine($"Random number: {num}");

                    int maxDigit = num % 10;

                    while (num > 0)
                    {
                        if (num % 10 > maxDigit) maxDigit = num % 10;
                        num /= 10;     
                    }

                    System.Console.WriteLine($"Max digit: {maxDigit}");

                    break;
                }
 
                case 2: // Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
                {
                    int num = new Random().Next(100, 1000);

                    System.Console.WriteLine($"Random number: {num}");

                    int res = num / 100 * 10 + num % 10;

                    System.Console.WriteLine($"Number without second digit: {res}");

                    break;
                }
 
                case 0:
                {
                    isWork = false;
                    break;
                }
            }
    }

}