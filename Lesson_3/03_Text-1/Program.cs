﻿// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
Console.Clear();

// string s = "qwerty"
//             012345
// s [3]     // = r

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
+ "ежели бы вас послали вместо нашего милого Винценгероде,"
+ "вы бы взяли приступом согласие прусского короля."
+ "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    
    int L = text.Length;
    for (int i = 0; i < L; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}"; 
        else result = result + $"{text[i]}";
    }
    
    return result;
}

string newText = Replace(text, ' ', '_');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(text, 'С', 'с');
Console.WriteLine(newText);
Console.WriteLine();