// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] Input(string abc) // Записываем массив из строки, преобразуем строковой массив в числовой//На вход принимаем сообщение для пользователя
{
    Console.Write($"{abc} ");
    string[] input = Console.ReadLine()!.Split(' ');
    double[] numbers = new double[input.Length];
    for (int i = 0; i < input.Length; i++)
        numbers[i] = double.Parse((input[i]));

    return numbers;
}

double Different(double[] array) //Находим разницу между максимальным и минимальным элементом массива (Вход - массив)
{
int minIndex = 0;
int maxIndex = 0;

for(int i = 1; i < array.Length; i++)
{
    if (array[i] < array[minIndex])
    minIndex = i;
    if (array[i] > array[maxIndex])
    maxIndex = i;
}

double diff = array[maxIndex] - array[minIndex];
return diff;
}

double[] array = Input("Введите вещественные числа через пробел (разделитель числа - ,):");
Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {Different(array)}");