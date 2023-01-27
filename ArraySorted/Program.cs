

string[] ArraySort(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    string[] sortedArray = new string[count];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            sortedArray[j] = array[i];
            j++;
        }
    }
    return sortedArray;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($" '{array[i]}' , ");
    }
    Console.Write($" '{array[array.Length - 1]}'");
}

string[] givenArray = { "hello", "2", "world", ";-)", "1234", "123", "-2" };
PrintArray(ArraySort(givenArray));
