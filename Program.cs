// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.WriteLine("Введите количество элементов массива");
int length = Convert.ToInt32(Console.ReadLine());
string [] array1 = new string [length];
for (int i = 0; i < length; i++)
{
    Console.WriteLine("Заполните строку массива");
    array1 [i] = Console.ReadLine();
}

Console.Write("Имеющийся массив:");
for (int i = 0; i < length; i++)
{
    Console.Write($"[{array1[i]}]");
}
Console.WriteLine();

Console.Write("Новый массив из строк, длина которых меньше, либо равна 3 символам: ");
string [] array2 = new string [array1.Length];
int count = 0;
int maxLength = 3;
for (int i = 0; i < array1.Length; i++)
{
    if (array1[i].Length <= maxLength)
    {
        array2[count] = array1[i];
        count++;
    }
}
for (int i = 0; i < count; i++)
    {
        Console.Write($"[{array2[i]}]");
    }