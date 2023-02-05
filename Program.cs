// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


Console.Write("Введите колличество чисел :");
int num = int.Parse(Console.ReadLine()!);

int[] nums = new int[num];
int count = 0;

for (int i = 0; i < num; i++)
{
    nums[i] = int.Parse(Console.ReadLine()!);
    if (nums[i] > 0)
    {
        count++;
    }
}

Console.WriteLine(count);
















