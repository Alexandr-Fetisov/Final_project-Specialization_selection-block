
Console.Clear();
int n = 3;
string[] array1 = new string[6] {"Ok","123","hello", "8", "world", ":-)"};
string[] array2 = new string[array1.Length];
void SecondArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if(array1[i].Length <= n)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{   Console.Write("[   ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}
SecondArray(array1, array2);
PrintArray(array2);
