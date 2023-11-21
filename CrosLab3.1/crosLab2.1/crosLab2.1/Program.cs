//using System;
//using System.IO;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        // Читання даних з файлу INPUT.TXT
//        string[] inputLines = File.ReadAllLines("INPUT.TXT");


//        int N = int.Parse(inputLines[0]);


//        int[] talkativenessLevels = inputLines[1].Split(' ').Select(int.Parse).ToArray();

//        // Сортування рівнів балакучості
//        Array.Sort(talkativenessLevels);

//        // Обчислення мінімальної балакучості
//        int minGroupChattiness = talkativenessLevels[N - 1] - talkativenessLevels[0];

//        // Запис результату в файл OUTPUT.TXT
//        File.WriteAllText("OUTPUT.TXT", minGroupChattiness.ToString());
//    }
//}

using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Читання даних з файлу
        string[] lines = File.ReadAllLines("INPUT.TXT");
        int n = int.Parse(lines[0]);
        int[] talkativeness = lines[1].Split(' ').Select(int.Parse).ToArray();

        // Сортування балакучості
        Array.Sort(talkativeness);

        // Знаходження мінімальної балакучості розбиття
        int minMaxDifference = talkativeness[n - 1] - talkativeness[0];

        // Запис результату в файл
        File.WriteAllText("OUTPUT.TXT", minMaxDifference.ToString());
    }
}





