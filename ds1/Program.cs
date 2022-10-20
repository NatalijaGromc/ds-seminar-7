// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int m = 3, n = 4;

float[,] array = CreateArray(m, n);

float[,] CreateArray(int _m, int _n)
{
float[,] _array = new float[_m, _n];
for (int i = 0; i < _m; i++)
{
    for (int j = 0; j < _n; j++)
{
_array[i, j] = (float) new Random().NextDouble()*10;
Console.Write($"{_array[i, j]} ");
}
Console.WriteLine();
}
return _array;
}