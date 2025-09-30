using EdgeDetect.Core;
using EdgeDetect.Core.core;
using System;

namespace EdgeDetect.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("Usage: dotnet run -- <operator> <input> <output>");
                return;
            }

            string operatorName = args[0];
            string inputPath = args[1];
            string outputPath = args[2];

            // Select operator
            IEdgeOperator edgeOperator = EdgeOperatorFactory.GetOperator(operatorName);

            // Load image
            byte[,] imageData = ImageUtils.LoadGrayscaleAsByteArray(inputPath);

            // Detect edges
            EdgeDetector detector = new EdgeDetector(edgeOperator);
            double[,] edgeData = detector.DetectEdges(imageData);

            // Convert to byte array (0-255)
            byte[,] edgeDataAsBytes = EdgeDetectorUtils.NormalizeToByteArray(edgeData);

            // Save result
            ImageUtils.SaveByteArrayAsImage(edgeDataAsBytes, outputPath);

            Console.WriteLine($"Edge detection completed: {outputPath}");
        }
    }
}
