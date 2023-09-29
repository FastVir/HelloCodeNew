// Вид 1 - Методы которые не принмабт значения и не ничего не возвращают (методы ничего не возвращающие, но при этом принимающие либо не принимающие значения называются void)
// void Method1()
// {
//     Console.WriteLine("Автор...");
// }
// Method1();


// Вид 2  - Методы принимают, но ничего не возвращают
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2(msg:"Текст сообщения");

// void Method2(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }

// // Method2("Text", 4);
// Method2(count: 4, msg: "новый текст");


// Вид 3 - Методы ничего не принимают, но при этом возвращает

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// Console.WriteLine(year);
// System.Threading.Thread.Sleep(5000);
// Console.Clear();

// Вид 4 - Методы которые принимают значения и возвращают

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)  // через цикл while
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string Method4(int count, string text)
// {
//     string result = String.Empty;

//     for (int i = 0; i < count; i++)   // через цикл for
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(10, "asdf");
// Console.WriteLine(res);
// System.Threading.Thread.Sleep(5000);
// Console.Clear();

// Вывод таблицы умножения через цикл в цикле

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <=10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     Console.WriteLine();
//     System.Threading.Thread.Sleep(5000);
//     Console.Clear();
// }

//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.

// Ясна ли задача?


// string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
//                 + "ежели бы вас послали вместо нашего милого Винценгероде,"
//                 + "вы бы взяли приступом согласие прусского короля."
//                 + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012
// s[3] // r


// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);

// Задача по сортировке массива


int[] arr = { 1, 5, 7, 6, 4, 3, 9, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }


        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}


PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);