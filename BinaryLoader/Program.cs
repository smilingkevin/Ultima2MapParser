using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryLoader
{
    class Program
    {
        static void Main(string[] args)
        {
            int letter = 97;
            string output = "";
            Dictionary<int, char> Letters = new Dictionary<int, char>();

            foreach (string filePath in Directory.GetFiles(@"D:\Program Files (x86)\GOG Galaxy\Games\Ultima 2\", "map*."))
            {
                output = "";
                FileStream stream = new FileStream(filePath, FileMode.Open);
                for (int i = 0; i < stream.Length; i++)
                {
                    int temp = stream.ReadByte();
                    if (!Letters.ContainsKey(temp))
                    {
                        Letters.Add(temp, (char)letter);
                        letter++;
                    }
                    output += Letters[temp];

                    if ((i + 1) % 64 == 0)
                    {
                        output += Environment.NewLine;
                    }
                }

                Console.WriteLine(Path.GetFileNameWithoutExtension(filePath));
                Console.WriteLine(output);
            }
            Console.Read();
        }
    }
}
