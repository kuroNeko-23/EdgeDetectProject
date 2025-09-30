using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdgeDetect.Core.core
{

    public class EdgeDetector
    {
        private IEdgeOperator _operator;

        public EdgeDetector(IEdgeOperator edgeOperator)
        {
            _operator = edgeOperator;
        }

        public double[,] DetectEdges(byte[,] image)
        {
            int height = image.GetLength(0);
            int width = image.GetLength(1);
            double[,] result = new double[height, width];

            double[,] gx = _operator.KernelGx;
            double[,] gy = _operator.KernelGy;
            int kSize = gx.GetLength(0);
            int kHalf = kSize / 2;

            for (int y = kHalf; y < height - kHalf; y++)
            {
                for (int x = kHalf; x < width - kHalf; x++)
                {
                    double sumX = 0, sumY = 0;

                    for (int ky = -kHalf; ky <= kHalf; ky++)
                    {
                        for (int kx = -kHalf; kx <= kHalf; kx++)
                        {
                            int pixel = image[y + ky, x + kx];
                            sumX += gx[ky + kHalf, kx + kHalf] * pixel;
                            sumY += gy[ky + kHalf, kx + kHalf] * pixel;
                        }
                    }

                    double magnitude = Math.Sqrt(sumX * sumX + sumY * sumY);
                    result[y, x] = magnitude;
                }
            }

            return result;
        }




    }

}
