using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdgeDetect.Core.core
{
    public class SobelOperator : IEdgeOperator
    {
        public double[,] KernelGx { get; } = new double[,] {
        {-1, 0, 1},
        {-2, 0, 2},
        {-1, 0, 1}
    };

        public double[,] KernelGy { get; } = new double[,] {
        { 1,  2,  1},
        { 0,  0,  0},
        {-1, -2, -1}
    };

        public string Name => "sobel";
    }

}
