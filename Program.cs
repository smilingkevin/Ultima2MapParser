using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Media.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Newtonsoft.Json.Linq;

namespace Ultima2MapParser
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string filePath in Directory.GetFiles(@"C:\Users\Kevin\OneDrive\Source\Ultima2MapParser\data\Towns\", "*.gif"))
            {
                string outputName = Path.Combine(Path.GetDirectoryName(filePath), Path.GetFileNameWithoutExtension(filePath) + ".txt");
                var file = new MapFile(filePath);
                File.WriteAllText(outputName, file.CharMap.Collapse("\t", Environment.NewLine));
                Console.WriteLine(Path.GetFileNameWithoutExtension(filePath) + " complete.");
            }

            Console.ReadLine();
        }
    }

    public class MapFile
    {
        public string FilePath { get; set; }
        public string[,] CharMap { get; set; }
        public Dictionary<string, string> TileTypes { get; set; }

        public MapFile(string filePath)
        {
            FilePath = filePath;
            CharMap = new string[64, 64];
            TileTypes = new Dictionary<string, string>();
            JObject map = JObject.Parse(File.ReadAllText("TileHashes.json"));
            foreach (JToken token in map["tiles"].ToArray())
            {
                TileTypes.Add((string)token["hash"], (string)token["tile"]);
            }

            parseTiles(new Bitmap(FilePath));
        }

        private void parseTiles(Bitmap bitmap)
        {
            for (int j = 0; j < 64; j++)
            {
                for (int i = 0; i < 64; i++)
                {
                    if (TileTypes.ContainsKey(bitmap.Clone(new Rectangle(j * 16, i * 16, 16, 16), bitmap.PixelFormat).ShaHash()))
                    {
                        CharMap[i, j] = TileTypes[bitmap.Clone(new Rectangle(j * 16, i * 16, 16, 16), bitmap.PixelFormat).ShaHash()];
                    }
                    else
                    {
                        CharMap[i, j] = "Unknown";
                    }
                }
            }
        }
    }
}
