
int InputInt(string message)
{
    Console.Write($"{message}> ");
    int value;
    if (int.TryParse(Console.ReadLine(), out value))
    {
        return value;
    }
    Console.WriteLine("You enter not number");
    Environment.Exit(1);
    return 0;
}

string[] GenerateArray (int size)
   {
    string[] stringArray = new string[size];
	for(int i = 0; i < stringArray.Length; i++)
	{
        Console.WriteLine($"Enter element on index {i}");
	    Console.Write("> ");
        stringArray[i] = Console.ReadLine();
	}
    return stringArray;
   }

void ShowArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length - 1; i++)
    {
         Console.Write($"{array[i]}, ");         
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.Write(" ]");
}

string[] CreateNewArray(string[] array)
{
    int count = 0; 
    
    string[] newArray = new string[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
       if(array[i].Length <= 3)
        {
            newArray[count] = array[i];
            count++;
        }
    }
    return newArray;
 }

int size = InputInt("Enter size array:");
string[] array = GenerateArray(size);
string[] newArray = CreateNewArray(array);
Console.WriteLine();
Console.WriteLine("New array with less than 3 symbols");
ShowArray(newArray);