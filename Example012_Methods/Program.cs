Console.Clear();

// void Method1()
// {
//     Console.WriteLine("Author ...");
// }

// Method1();

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }

// Method2("Text of the message");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }

// Method21(msg: "Text of the message", count: 4);

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();

// Console.WriteLine(year);

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

        while (i < count)
        {
            result = result + text;
            i++;
        }
        return result;
}

string res = Method4(10, "qwertyText");
Console.WriteLine(res);