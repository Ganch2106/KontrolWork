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