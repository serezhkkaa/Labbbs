using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        string inputPath = "INPUT.TXT";
        string outputPath = "OUTPUT.TXT";

        string input = File.ReadAllText(inputPath).Trim();
        Stack<char> path = new Stack<char>();
        int x = 0, y = 0;
        Dictionary<(int, int), char> positions = new Dictionary<(int, int), char>();

        foreach (char direction in input)
        {
            if (path.Count > 0 && IsOppositeDirection(path.Peek(), direction))
            {
                // Remove the opposite direction (e.g., N and S are opposites)
                path.Pop();
                switch (direction)
                {
                    case 'N': y--; break;
                    case 'E': x--; break;
                    case 'S': y++; break;
                    case 'W': x++; break;
                }
            }
            else
            {
                path.Push(direction);
                switch (direction)
                {
                    case 'N': y++; break;
                    case 'E': x++; break;
                    case 'S': y--; break;
                    case 'W': x--; break;
                }
            }
        }

        string outputPathReversed = GetReversedPath(path);
        File.WriteAllText(outputPath, outputPathReversed);
    }

    static bool IsOppositeDirection(char a, char b)
    {
        return (a == 'N' && b == 'S') || (a == 'S' && b == 'N') ||
               (a == 'E' && b == 'W') || (a == 'W' && b == 'E');
    }

    static string GetReversedPath(Stack<char> path)
    {
        StringBuilder reversedPath = new StringBuilder();
        foreach (char direction in path)
        {
            switch (direction)
            {
                case 'N': reversedPath.Append('S'); break;
                case 'E': reversedPath.Append('W'); break;
                case 'S': reversedPath.Append('N'); break;
                case 'W': reversedPath.Append('E'); break;
            }
        }
        return ReverseString(reversedPath.ToString());
    }

    static string ReverseString(string s)
    {
        char[] array = s.ToCharArray();
        Array.Reverse(array);
        return new String(array);
    }
}
