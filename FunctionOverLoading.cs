using System;

public class Function
{
    
    static int Func(int i)
    {
        return i;
    }
    
    static char Func(char c)
    {
        return c;
    }
    
    static string Func(string s)
    {
        return s;
    }

    static double Func(double d)
    {
        return d;
    }
    
    public static void Main()
    {

        int intResult = Func(5);
        char charResult = Func('A');
        string stringResult = Func("Hello");
        double doubleResult = Func(5.5);

        Console.WriteLine("Result from integer function: " + intResult);
        Console.WriteLine("Result from character function: " + charResult);
        Console.WriteLine("Result from string function: " + stringResult);
        Console.WriteLine("Result from double function: " + doubleResult);
    }
}
