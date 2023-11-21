using System;
using System.IO;

class Program
{
    static void Main()
    {
        string inputPath = "INPUT.TXT";
        string outputPath = "OUTPUT.TXT";

        string input = File.ReadAllText(inputPath).Trim();
        int x = 0, y = 0; // координати Тезея

        foreach (char direction in input)
        {
            switch (direction)
            {
                case 'N': y++; break;
                case 'E': x++; break;
                case 'S': y--; break;
                case 'W': x--; break;
            }
        }

        string outputPathReversed = GetReversedPath(x, y);
        File.WriteAllText(outputPath, outputPathReversed);
    }

    static string GetReversedPath(int x, int y)
    {
        string path = "";
        // рухатися на північ або південь
        if (y > 0)
        {
            path += new String('S', y); // якщо Тезей північніше початку
        }
        else if (y < 0)
        {
            path += new String('N', -y); // якщо Тезей південніше початку
        }

        // рухатися на схід або захід
        if (x > 0)
        {
            path += new String('W', x); // якщо Тезей східніше початку
        }
        else if (x < 0)
        {
            path += new String('E', -x); // якщо Тезей західніше початку
        }

        return path;
    }
}
