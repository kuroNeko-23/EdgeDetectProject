using EdgeDetect.Core;
using EdgeDetect.Core.core;
using Xunit;

namespace EdgeDetect.Tests
{
    public class EdgeDetectionSimpleImageTests
    {
        [Fact]
        public void DetectEdges_FindsVerticalEdge_InSyntheticImage()
        {
            int height = 10;
            int width = 10;
            byte[,] testImage = new byte[height, width];

            // Left half = 0, Right half = 255
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    testImage[y, x] = (x < width / 2) ? (byte)0 : (byte)255;
                }
            }

            var detector = new EdgeDetector(EdgeOperatorFactory.GetOperator("sobel"));
            var result = detector.DetectEdges(testImage);

            // Expect strong edges near the center
            double centerValue = result[5, width / 2];
            Assert.True(centerValue > 100, "Edge should be detected at center");
        }
    }
}
