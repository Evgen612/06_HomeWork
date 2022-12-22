// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

void CollNums(string[] listNum)
{
    int count = 0;
    Console.Write("введите список чисел: ");
    foreach(string elem in listNum)
    {
        if(int.Parse(elem) > 0) count++;
        Console.Write($"{elem}");
    }
    Console.WriteLine($"\nКол-во чисел > 0 = {count}");
}

Console.WriteLine("введите список чисел: ");
string[] list = (Console.ReadLine()!).Split(' ', ' ');
CollNums(list);