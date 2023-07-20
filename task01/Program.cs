// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] Input(string abc) // Записываем массив из строки, преобразуем строковой массив в числовой//На вход принимаем сообщение для пользователя
{
    Console.Write($"{abc} ");
    string[] input = Console.ReadLine()!.Split(',');
    int[] numbers = new int[input.Length];
    for (int i = 0; i < input.Length; i++)
        numbers[i] = Convert.ToInt32(input[i]);

    return numbers;
}

int Summ(int[] array) //Функция находит сумму нечетных элементов массива. На вход принимает массив, на выходе выдает сумму
{
    int summ = 0;
    for (int i = 1; i < array.Length; i += 2)
        summ += array[i];

    return summ;
}

int[] array = Input("Введите числа через запятую(без пробела):");
Console.WriteLine($"Сумма нечетных элементов массива = {Summ(array)}");