// редактирование текста

string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";


string replace (string text, char oldvalue, char newvalue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldvalue) result = result + $"{newvalue}";
        else result = result + $"{text[i]}";
        
    }

    return result;
}

string newText = replace(text, ' ', '/');
Console.WriteLine(newText);
Console.WriteLine();
newText = replace(newText, 'к', 'К');
Console.WriteLine(newText);