Console.Write("Введите количество строк массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] stringArray = new string[n];
void array(string[] stringArray)
{
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} строку массива ");
        stringArray[i] = Console.ReadLine();
    }
}
string[] symbol(string[] stringArray)
{
    int m = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
            m++;
    }
    string[] rez = new string[m];
    int j = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
        {
            rez[j] = stringArray[i];
            j++;
        }
    }
    return rez;
}
void printArray(string[] stringArray)
{
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.Write($"{stringArray[i]} ");
    }
}
array(stringArray);
printArray(symbol(stringArray));