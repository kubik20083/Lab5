﻿//Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
Console.WriteLine("Задайте размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
ArrayNumbers(numbers);
PrintArray(numbers);
int sum = 0;

for (int a = 0; a < numbers.Length; a = a + 2)
    sum = sum + numbers[a];

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {sum}");

void ArrayNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1, 100);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}