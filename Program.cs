string [] CreateArrray(int size)
{
    string [] array = new string [size];
    for (int i = 0; i<size; i++)
    {
        Console.WriteLine("Enter array element");
        array[i] = Convert.ToString(Console.ReadLine());
    }
    return array;
    Console.WriteLine();
}

void ShowArray(string [] array)
{
   for (int i = 0; i<array.Length; i++)
    {
        Console.Write($" \"{array[i]}\" ");
    } 
}



Console.WriteLine("Enter array size");
int size = Convert.ToInt32(Console.ReadLine());
string [] myarray = CreateArrray(size);
ShowArray(myarray);