using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR_OP_1
{
    class Program
    {
        static string inputPath = "Input.txt";

        static List<int> ParseNumbers(string inputPath)
        {
            int lines = NumberOfLines(inputPath);
            StreamReader sr = new StreamReader(inputPath);
            List<int> numbers = new List<int>();
            for (int i = 0; i < lines; i++)
            {
                string line = sr.ReadLine();
                foreach (var number in line.Split( new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    numbers.Add(int.Parse(number));
                }
            }
            return numbers;
        }

        static int NumberOfLines(string Path)
        {
            int count = 0;
            using (StreamReader sr = new StreamReader(Path))
            {
                while (sr.ReadLine() != null)
                    count++;
            }
            return count;
        }

        static void SaveToFiles(List<int> numbers)
        {
            foreach (var number in numbers)
            {
                string path = number.ToString() + ".txt";
                using (StreamWriter sw = new StreamWriter(path))
                {
                    CheckExistence(path);
                    sw.WriteLine(NumberConverter.Convert(number));
                }
            }
        }

        static void CheckExistence(string path)
        {
            if (!File.Exists(path))
                File.Create(path);
        }

        static void Main(string[] args)
        {
            var numbers = ParseNumbers(inputPath);
            SaveToFiles(numbers);
        }
    }
}
