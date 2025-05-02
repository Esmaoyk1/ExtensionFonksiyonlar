using System.Globalization;

//Static class içinde olmalı

//Static metot olarak tanımlanmalı

//İlk parametre this keyword'ü ile işaretlenmeli

class Program
{
    static void Main(string[] args)
    {
        char[] dizi = "Merhaba".ConvertToChars();

        foreach (var item in dizi)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("**********************");

        string text = "hello world";
        Console.WriteLine(text.ToTitleCase());


    }
}

public static class Extensions
{
    public static char[] ConvertToChars(this string text)
    {
        char[] chars = new char[text.Length];
        for (int i = 0; i < chars.Length; i++)
        {
            chars[i] = text[i];
        }
        return chars;
    }
}

public static class StringExtensions
{
    public static string ToTitleCase(this string str)
    {
        return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
    }
}