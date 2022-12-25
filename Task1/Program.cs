//Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
 //длина которых меньше, либо равна 3 символам. 
 //Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


Console.WriteLine("Введите строки массива через enter: ");

string[] array = new string[5]; // ограничние в 5 слов (элементов массива) 

CreateArray(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();


 void CreateArray(string[] array) // создаем массив из введеных строк
{
   
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
}


void PrintArray(string[] array) // вывод заданного массива
{
    Console.WriteLine("Заданный массив :");
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]},");
    }

    Console.Write("]");
    Console.WriteLine();
}
