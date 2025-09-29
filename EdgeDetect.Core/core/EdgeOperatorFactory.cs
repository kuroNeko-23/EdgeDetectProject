using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdgeDetect.Core.core
{
    public static class EdgeOperatorFactory
    {
        public static IEdgeOperator GetOperator(string name)
        {
            return name.ToLower() switch
            {
                "sobel" => new SobelOperator(),
                "prewitt" => new PrewittOperator(),
                _ => throw new ArgumentException($"Unknown operator: {name}")
            };
        }
    }

}
