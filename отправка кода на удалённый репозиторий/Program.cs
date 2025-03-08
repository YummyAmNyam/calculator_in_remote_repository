using System;
public class MainClass
{
    public static void Main()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        string c = Console.ReadLine();
        if (c == "+") Console.WriteLine(a + b);
        else if (c == "-") Console.WriteLine(a - b);
        else if (c == "*") Console.WriteLine(a * b);
        else if (c == "/" && b != 0) Console.WriteLine((double)a / b);
        else if (b == 0) Console.WriteLine("На ноль делить нельзя!");
        else Console.WriteLine("Неверная операция");
    }
}
