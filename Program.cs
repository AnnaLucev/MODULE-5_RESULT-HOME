// Написать программу, которая из имеющегося массива строк сформирует  массив из строй, длина которых
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно
// массивами.
// ["hello", "2", "world",":)"]   ----- ["2", ":)"]
// ["1234", "1567", "-2","computer science"]   ----- ["2"]
// ["Russia", "Denmark", "Kazan"]   ----- []

Console.Clear();
string[] arr = new string[] {"hello", "2", "world", ":)"};   // ручной ввод элементов массива
string[] arr1 = new string[] {"1234", "1567", "-2", "computer science"}; 
string[] arr2 = new string[] {"Russia", "Denmark", "Kazan"}; 

Console.Write("Пример 1:");    ThreeSymbolElemArray(arr); 
Console.WriteLine();
Console.Write("Пример 2:");    ThreeSymbolElemArray(arr1); 
Console.WriteLine();
Console.Write("Пример 3:");    ThreeSymbolElemArray(arr2); 

void ThreeSymbolElemArray(string[] arr)     // итоговая функция выполнения задачи
{
    string[] arrNew = ThreeSymbolElem(arr); 
    Console.WriteLine();
    Console.WriteLine($"Исходный массив:        [ {String.Join(",  ", arr)} ]");  
    Console.WriteLine($"Массив с элементами < 4 символов:   [ {String.Join(",  ", arrNew)} ]"); 
}

string[] ThreeSymbolElem(string[] arr)   // функция вывода массива с тремя и менее символами в элементах
{
    string[] arrNew = new string[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 4)   
            arrNew = arrNew.Append(arr[i]).ToArray();
    }
    return arrNew;  
}

    
// string[]  PrintArray()      // ввод массива из N элементов
// {
//     Console.WriteLine("Введите количество элементов в массиве: ");
//     int countElements = int.Parse(Console.ReadLine());
//     string[] arr = new string[countElements];
    
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"Введите элемент массива с индексом {i}:\t ");
//         arr[i] = Convert.ToString(Console.ReadLine());
//     }
//     Console.WriteLine($"Вывод (печать) массива:   ");
//     string array = String.Join(", ", arr);
//     return arr;
// }