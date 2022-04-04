/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

void CountOfPositiveNumbers(int amount)
{
    int count = 0;
    Console.WriteLine("Введите числа:");
    for (int i = 0; i < amount; i++)
    {
        Console.Write($"M{1 + i} = ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Количество чисел больше 0 = {count}");
}

Console.Write("Введите количество чисел, М = ");
int userNumbers = Convert.ToInt32(Console.ReadLine());
CountOfPositiveNumbers(userNumbers);
