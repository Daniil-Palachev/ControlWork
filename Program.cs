
Console.Clear();
string[] arrayStart = new string[5] { "Moscow", "Res", "Tip", "world", "Pit" };
Console.WriteLine(String.Join(",", arrayStart));
ThreeSymbols(arrayStart);

void ThreeSymbols(string[] arrayStart)
{
    int count = 0;
    string[] arrayEnd = new string[arrayStart.Length];
    for (int i = 0; i < arrayStart.Length; i++)
    {
        if (arrayStart[i].Length <= 3)
        {
            arrayEnd[count] = arrayStart[i];
            count++;
        }
    }
    Console.WriteLine(String.Join(",", arrayEnd));
}






