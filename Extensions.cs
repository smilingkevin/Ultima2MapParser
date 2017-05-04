using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ultima2MapParser
{
    public static class Extensions
    {
        public static string ShaHash(this Image image)
        {
            var bytes = new byte[1];
            bytes = (byte[])(new ImageConverter()).ConvertTo(image, bytes.GetType());

            return Convert.ToBase64String((new SHA256Managed()).ComputeHash(bytes));
        }

        public static string Collapse(this string[,] array, string colDelimiter, string rowDelimiter)
        {
            string output = "";

            for (int j = 0; j < array.GetLength(1); j++)
            {
                output += array[0, j];
                for (int i = 1; i < array.GetLength(0); i++)
                {
                    output += colDelimiter + array[i, j];
                }
                output += rowDelimiter;
            }

            return output;
        }
    }
}
