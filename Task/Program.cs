void PrintArray(string[] arr) // печать для проверки задания
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + "   ");
    }
}
string[] array = { "hello", "2", "world", ":-)" };
string[] newArray = new string[array.Length - 1];
int n = 0;
for (int step = 0; step < array.Length; step++)
{
    if (array[step].Length <= 3)
    {
        newArray[n] = array[step];
        n++;
    }
}
PrintArray(newArray);