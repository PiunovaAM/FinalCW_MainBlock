//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []



string[] CreateUsersTextArray(int size)
{
    string[] usersArray = new string[size];

    for (int i = 0; i < usersArray.Length; i++)
    {
        Console.Write($"Введите строку {i + 1}: ");
        usersArray[i] = Console.ReadLine()!;
    }
    return usersArray;
}
string[] NewTextArray(string[] newArray)
{
    int newSize = 0;
    string[] newTextArray = new string[newSize];
    int j = 0;
    for (int i = 0; i < newArray.Length; i++)
    {
        if (newArray[i].Length <= 3)
        {
            newSize++;
            Array.Resize(ref newTextArray, newSize);
            newTextArray[j] = newArray[i];
            j++;
        }
    }
    return newTextArray;
}

string[] usersTextArray = CreateUsersTextArray(4);
string[] newTextArray = NewTextArray(usersTextArray);
Console.WriteLine($"[{string.Join(", ", usersTextArray)}] -> [{string.Join(", ", newTextArray)}]");

