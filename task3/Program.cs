//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
ArrayNumbers(numbers);
Console.WriteLine("массив: ");
PrintArray(numbers);
double min = Double.MaxValue;
double max = Double.MinValue;

for (int a = 0; a < numbers.Length; a++)
{
    if (numbers[a] > max)
    {
        max = numbers[a];
    }
    if (numbers[a] < min)
    {
        min = numbers[a];
    }
}

Console.WriteLine($"Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"{max} - {min} = {max - min}");

void ArrayNumbers(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Random rnd = new Random();
        numbers[i] = rnd.NextDouble() * 100;
     
    }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}