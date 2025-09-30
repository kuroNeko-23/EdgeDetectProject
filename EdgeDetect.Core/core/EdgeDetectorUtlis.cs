using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdgeDetect.Core
{
    public static class EdgeDetectorUtils
    {
        public static byte[,] NormalizeToByteArray(double[,] data)
        {
            int height = data.GetLength(0);
            int width = data.GetLength(1);

            byte[,] result = new byte[height, width];

            // Find min & max values
            double min = double.MaxValue;
            double max = double.MinValue;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (data[y, x] < min) min = data[y, x];
                    if (data[y, x] > max) max = data[y, x];
                }
            }

            double range = max - min;
            if (range == 0) range = 1; // prevent divide by zero

            // Normalize each value to 0–255
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    double normalized = (data[y, x] - min) / range;
                    result[y, x] = (byte)(normalized * 255);
                }
            }

            return result;
        }
    }
}

