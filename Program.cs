string [] CreateArrray(int size)
{
    string [] array = new string [size];
    for (int i = 0; i<size; i++)
    {
        Console.WriteLine("Enter array element:");
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

string [] NewArrayLess3Symbol(string [] myarray)
{
    int count = 0;
    for(int i = 0; i<myarray.Length; i++)
    {
        string a = myarray[i];
        if (a.Length<=3)
        count++;
    }

    string [] array = new string [count];
    for (int i = 0, j = 0; i<myarray.Length; i++)
    {
        string a = myarray[i];
        if (a.Length<=3)
        {
            array[j] = myarray[i];
            j++;
        }
    }
    return array;
}

Console.WriteLine("Enter array size:");
int size = Convert.ToInt32(Console.ReadLine());
string [] myarray = CreateArrray(size);
ShowArray(myarray);
Console.WriteLine();
string [] newarray = NewArrayLess3Symbol(myarray);
ShowArray(newarray);