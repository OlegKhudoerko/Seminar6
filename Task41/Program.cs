// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] array = new int[5];
int size = array.Length;
int sumPositive = 0;

for (int i = 0; i < size; i++)
{
    Console.Write($"Введите {i + 1}-ое число = ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    if (array[i] > 0) sumPositive += array[i];
}
Console.WriteLine($"\n{string.Join(", ", array)} -> {sumPositive}\n");