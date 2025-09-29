using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdgeDetect.Core.core
{
    public class PrewittOperator : IEdgeOperator
    {
        // Horizontal kernel (detects vertical edges)
        public double[,] KernelGx { get; } = new double[,]
        {
            { -1, 0, 1 },
            { -1, 0, 1 },
            { -1, 0, 1 }
        };

        // Vertical kernel (detects horizontal edges)
        public double[,] KernelGy { get; } = new double[,]
        {
            {  1,  1,  1 },
            {  0,  0,  0 },
            { -1, -1, -1 }
        };

        // Name of the operator
        public string Name => "prewitt";
    }
}

