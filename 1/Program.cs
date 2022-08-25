// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int[] array = new int[5];
int positiveCount = 0;
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите {i}-е число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    if (array[i] > 0) positiveCount++;
}
//Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine($"Положительных чисел в массиве: {positiveCount}.");