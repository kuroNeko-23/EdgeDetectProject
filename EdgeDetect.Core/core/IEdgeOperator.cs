using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdgeDetect.Core.core
{
    public interface IEdgeOperator
    {
        double[,] KernelGx { get; }
        double[,] KernelGy { get; }
        string Name { get; }
    }
}
