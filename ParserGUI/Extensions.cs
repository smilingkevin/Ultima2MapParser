using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ParserGUI
{
    public static class Extensions
    {
        public static string ShaHash(this Image image)
        {
            var bytes = new byte[1];
            bytes = (byte[])(new ImageConverter()).ConvertTo(image, bytes.GetType());

            return Convert.ToBase64String((new SHA256Managed()).ComputeHash(bytes));
        }
    }
}
