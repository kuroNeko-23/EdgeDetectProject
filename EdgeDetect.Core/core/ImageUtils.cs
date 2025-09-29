using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace EdgeDetect.Core
{
    public static class ImageUtils
    {
        public static byte[,] LoadGrayscaleAsByteArray(string path)
        {
            using Image<Rgba32> image = Image.Load<Rgba32>(path);
            int width = image.Width;
            int height = image.Height;
            byte[,] result = new byte[height, width];

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Rgba32 pixel = image[x, y];  // <-- Access pixel directly
                    byte gray = (byte)(0.3 * pixel.R + 0.59 * pixel.G + 0.11 * pixel.B);
                    result[y, x] = gray;
                }
            }

            return result;
        }
    }
}


