bool isWork = true;

while (isWork)
{
    System.Console.WriteLine();
    System.Console.WriteLine("1 - Task 09: Max digit of a random number between 10 and 99");
    System.Console.WriteLine("2 - Task 11: First and last digits of a random 3-digit number");
    System.Console.WriteLine("3 - Task 12: Is divisible");
    System.Console.WriteLine("4 - Task 14: Is divisible by 7 and 23");
    System.Console.WriteLine("5 - Task 14.1: Sum of the first 5 numbers divisible by 2 and 3");
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

                case 3: // Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
                        // Если число 2 не кратно числу 1, то программа выводит остаток от деления.
                {
                    System.Console.WriteLine("Enter two numbers: ");

                    if (!(int.TryParse(Console.ReadLine(), out int a) && int.TryParse(Console.ReadLine(), out int b)))
                    {
                        System.Console.WriteLine("Input error");
                        break;
                    }

                    if (a == 0)
                    {
                        System.Console.WriteLine("Cannot be divided by 0");
                        break;
                    }

                    if (b % a == 0) System.Console.WriteLine($"{b} is divisible by {a}");
                    else System.Console.WriteLine($"{b} is not divisible by {a}. The remainder is: {b % a}");

                    break;
                }

                case 4: // Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23. 
                {
                    System.Console.Write("Enter a number: ");

                    if (!int.TryParse(Console.ReadLine(), out int a))
                    {
                        System.Console.WriteLine("Input error");
                        break;
                    }

                    if (a % 7 == 0 && a % 23 == 0) System.Console.WriteLine($"{a} is divisible by 7 and 23");
                    else System.Console.WriteLine($"{a} is not divisible by 7 and 23");

                    break;
                }

                case 5: // Напишите программу, которая выдаёт сумму пяти первых чисел одновременно кратных 2 и 3. 
                {
                    int a = 1,
                        sum = 0,
                        count = 0;

                    while (count < 5)
                    {
                        if (a % 2 == 0 && a % 3 == 0)
                        {
                            System.Console.Write($"{a}, ");
                            sum += a;
                            count++;
                        }
                        a++;
                    }

                    System.Console.WriteLine();
                    System.Console.WriteLine($"Sum of the first 5 numbers divisible by 2 and 3 is {sum}");

                    a = 3;
                    sum = 0;
                    for (int i = 0; i < 5; i++) 
                    {
                        a *= 2;
                        sum += a;
                        System.Console.Write($"{a}, ");
                    }
                    
                    System.Console.WriteLine();
                    System.Console.WriteLine($"Sum of the first 5 numbers divisible by 2 and 3 is {sum}");

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