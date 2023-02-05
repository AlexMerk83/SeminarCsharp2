bool isWork = true;

while (isWork)
{
    System.Console.WriteLine();
    System.Console.WriteLine("1 - Task 1: Max digit of a random number between 10 and 99");
    System.Console.WriteLine("2 - Task : ");
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
                case 0:
                {
                    isWork = false;
                    break;
                }
            }
    }

}