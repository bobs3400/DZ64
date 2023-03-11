using System;
using static System.Console;
Clear();
Write("Введите число N: ");
int n = int.Parse(ReadLine()!);
WriteLine();
WriteLine(PrintNumbers(n));

string PrintNumbers(int n)
{
    if(n == 1)
    {
        //WriteLine(n);
        return n.ToString();
    }
    string s = n.ToString() + ", " + PrintNumbers(n - 1);
    //WriteLine(s);
    return s;
}