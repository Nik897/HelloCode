void method1()
{
    System.Console.WriteLine("text");
}

// method1();

void method2(string msg)
{
    System.Console.WriteLine(msg);
}

// method2("next");

void method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        System.Console.WriteLine(msg);
        i++;
    }
}

// method21(msg: "Text", count: 3);
// System.Console.WriteLine();
// method21(count: 2, msg: "Text");

int method3()
{
    return DateTime.Now.Year;
}

int year = method3();
//System.Console.WriteLine(year);

// string method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

string method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result += text;
    }
    return result;
}
string res = method4(5, "1a ");
//System.Console.WriteLine(res);

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         System.Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     System.Console.WriteLine();
// }

// Дан текст. В тексте нужно заменить все пробелы черточками, маленькие буквы "у"
// заменить большими "У", а большие "О" заменить маленькими "о". 

string text = "Однажды в студеную зимнюю пору я из лесу вышел, был сильный мороз";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;

    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

// string newText = Replace(text, ' ', '_');
// System.Console.WriteLine(newText);
// System.Console.WriteLine();

// newText = Replace(newText, 'у', 'У');
// System.Console.WriteLine(newText);
// System.Console.WriteLine();

// newText = Replace(newText, 'О', 'о');
// System.Console.WriteLine(newText);

// ---------------------------------------------------------------------
// Сортирова массива по возрастаню

int[] arr = { 2, 5, 7, 5, 45, 64, 4, 3, 1, 4, 6 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minposition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minposition]) minposition = j;
        }


        int temp = array[i];
        array[i] = array[minposition];
        array[minposition] = temp;
    }
}

void SelectionSortTop(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxposition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxposition]) maxposition = j;
        }


        int temp = array[i];
        array[i] = array[maxposition];
        array[maxposition] = temp;
    }
}

PrintArray(arr);

//SelectionSort (arr);
SelectionSortTop(arr);

PrintArray (arr);