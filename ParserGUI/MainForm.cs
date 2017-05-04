using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParserGUI
{
    public partial class MainForm : Form
    {
        public string filePath;
        public enum MapTileType { Water, Grass, Forest, Mountains, Moongate, Town, Village, Castle, Dungeon, Tower, Swamp, Sign, Plane, Ship }
        public string[] TileTypes = new string[] { "", "Water", "Grass", "Forest", "Mountains", "Moongate", "Town", "Village", "Castle", "Dungeon", "Tower", "Swamp", "Sign", "Plane", "Ship" };
        public string[,] MapTiles = new string[64, 64];
        public Dictionary<string, string> IdentifiedTiles = new Dictionary<string, string>();

        public int XPos = 0;
        public int YPos = 0;

        public MainForm()
        {
            InitializeComponent();
            SetStatus("Ready to load map.");
            TileTypeList.Items.AddRange(TileTypes);

            JObject map = JObject.Parse(File.ReadAllText("TileHashes.json"));
            foreach (JToken token in map["tiles"].ToArray())
            {
                IdentifiedTiles.Add((string)token["hash"], (string)token["tile"]);
            }
        }

        private void loadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            filePath = openFileDialog1.FileName;
            MapImage.Image = Image.FromFile(filePath);
            XPos = 0;
            YPos = 0;
            MapImage.Invalidate();
            MapImage.Update();
            MapImage.Refresh();
            Application.DoEvents();
            SetStatus("Map Loaded.");
            ParseMap();
        }

        private void ParseMap()
        {
            Bitmap bitmap = (Bitmap)MapImage.Image;

            for (int j = YPos; j < 64; j++)
            {
                for (int i = XPos; i < 64; i++)
                {
                    var image = bitmap.Clone(new Rectangle(i * 16, j * 16, 16, 16), bitmap.PixelFormat);
                    var hash = image.ShaHash();

                    if (IdentifiedTiles.Keys.Contains(hash))
                    {
                        MapTiles[i, j] = IdentifiedTiles[hash];
                    }
                    else
                    {
                        TileImage.Image = image;
                        SetButton.Enabled = true;
                        TileTypeList.SelectedIndex = 1;
                        YPos = j;
                        XPos = i;
                        SetStatus("Unknown Tile Found.");
                        return;
                    }
                }
                XPos = 0;
                SetStatus("Map Loading.... Row " + j + "/64");
            }

            SetStatus("Load complete.");
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            SetButton.Enabled = false;
            IdentifiedTiles.Add(TileImage.Image.ShaHash(), TileTypeList.Text);
            OutputText.Text += "{ \"hash\": \"" + TileImage.Image.ShaHash() + "\", \"tile\": \"" + TileTypeList.Text + "\" },\r\n";
            ParseMap();
        }

        private void SetStatus(string status)
        {
            toolStripStatusLabel1.Text = status;
            toolStripStatusLabel1.Invalidate();
            Application.DoEvents();
        }
    }
}
