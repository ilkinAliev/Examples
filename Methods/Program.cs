// методы

// 1 вид (ничего не принимают, ничего не выдают)

void Method1()
{
    Console.WriteLine("Автор Илкин Алиев");
}
//Пример
//Method1();


// вид 2 (принимают аргументы, ничего не возвращают)

void Method2(string msg)
{
    Console.WriteLine(msg);
}

//Method2("текст метода №2");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++; //инкримент - увеличение на 1, декримент - уменьшение на 1
    }
}

//Method21("text", 5);
//Method21(count: 5, msg: "text");


// вид 3 (что-то возвраают, но ничего не принимают)
int Method3()
{
    return DateTime.Now.Year;
}

//int Year = Method3();
//Console.WriteLine(Year);


// вид 4 (что-то принимают, что-то возвращают)

string Method4(int count, string text)
{
    int i = 0;
    string result = string.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
//string res = Method4(4, "ab");
//Console.WriteLine(res);


// цикл for
string Method41(int count, string text)
{   string result = string.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method41(4, "ab");
Console.WriteLine(res);