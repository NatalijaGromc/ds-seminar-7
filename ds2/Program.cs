// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int m = 3, n = 4;
int a;

int[,] array = new int[m, n];

for (int i = 0; i < m; i++)
{
for (int j = 0; j < n; j++)
{
array[i, j] = new Random().Next(10);
Console.Write($"{array[i, j]} ");
}
Console.WriteLine();
}

Console.Write($"Введите искомое число: ");
int.TryParse(Console.ReadLine()!, out a);

bool flag = false;
for (int i = 0; i < m; i++)
{
for (int j = 0; j < n; j++)
{
    if (array[i, j] == a)
    {
    Console.WriteLine($"Номер строки и столбца: {i}, {j} ");
    flag = true;
    }
}
}
 if (flag == false)
 {
    Console.WriteLine("Числа нет");
 }