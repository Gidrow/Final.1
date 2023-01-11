// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
//  Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []



string[] array1 = new string[5] {"AB33", "12", "12345", "Hello World!", "GiT"};
string[] array2 = new string[array1.Length];
void Selected(string[] array1, string[] array2)
{
    int count = 0;
    
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Console.WriteLine();
Selected(array1, array2);

Console.WriteLine("Первый массив:");
PrintArray(array1);
Console.WriteLine();

Console.WriteLine("Второй массив с элементами не превышающие 3 знаков:");
PrintArray(array2);
Console.WriteLine();