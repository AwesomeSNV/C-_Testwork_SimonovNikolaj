string[] array;
Console.WriteLine("Введите элементы массива через пробел: ");
string line = Console.ReadLine()!;
array = line.Split(' ');
string[] newArray = new string[array.Length];

Console.WriteLine("Исходный массив: ");
PrintArray(array);
Console.WriteLine("");
SelectionElements(array);
Console.WriteLine("Элементы массива меньше четырех символов: ");
PrintArray(newArray);

//Methods

void PrintArray(string[] array)
{
    foreach(var value in array)
    Console.Write($"{value} ");
}

void SelectionElements(string[] array)
{
    int newSize=0;
    for(int i=0; i < array.Length; i++)
    {
        if(array[i].Length<=3)
        {
            newArray[newSize]=array[i];
            newSize++;
        }
    }
}