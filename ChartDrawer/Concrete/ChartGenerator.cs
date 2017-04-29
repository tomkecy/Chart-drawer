using System.Drawing;
using System.Drawing.Drawing2D;
using ChartDrawer.Abstract;

namespace ChartDrawer.Concrete
{
    class ChartGenerator : IChartGenerator
    {
        private readonly IPointCounter _pointCounter = new PointCounter();

        public Image GetExponentialFunctionChart(double factor, double functionBase, int width, int height, int chartScale, 
            bool horizontalLines = false, bool verticalLines = false)
        {
            PointF[] functionPoints = _pointCounter.EvaluateExponentialPoints(factor, functionBase);
            Image chartBitmap = new Bitmap(width, height);

            return DrawFunctionChart(chartBitmap, functionPoints, chartScale, horizontalLines, verticalLines);
        }

        public Image GetCubicFunctionChart(double a, double b, double c, double d, int width, int height, int chartScale,
            bool horizontalLines = false, bool verticalLines = false)
        {
            PointF[] functionPoints = _pointCounter.EvaluateCubicPoints(a, b, c, d);
            Image chartBitmap = new Bitmap(width, height);

            return DrawFunctionChart(chartBitmap, functionPoints, chartScale, horizontalLines, verticalLines);

        }

        public Image GetSineFunctionChart(double factor, double functionBase, int width, int height, int chartScale,
            bool horizontalLines = false, bool verticalLines = false)
        {
            PointF[] functionPoints = _pointCounter.EvaluateSinePoints(factor, functionBase);
            Image chartBitmap = new Bitmap(width, height);

            return DrawFunctionChart(chartBitmap, functionPoints, chartScale, horizontalLines, verticalLines);
        }

        public Image GetCosineFunctionChart(double factor, double functionBase, int width, int height, int chartScale,
            bool horizontalLines = false, bool verticalLines = false)
        {
            PointF[] functionPoints = _pointCounter.EvaluateCosinePoints(factor, functionBase);
            Image chartBitmap = new Bitmap(width, height);

            return DrawFunctionChart(chartBitmap, functionPoints, chartScale, horizontalLines, verticalLines);
        }

        public Image GetLogarithmFunctionChart(double factor, double functionBase, int width, int height, int chartScale,
            bool horizontalLines = false, bool verticalLines = false)
        {
            PointF[] functionPoints = _pointCounter.EvaluateLogarithmPoints(factor, functionBase);
            Image chartBitmap = new Bitmap(width, height);

            return DrawFunctionChart(chartBitmap, functionPoints, chartScale, horizontalLines, verticalLines);

        }
        public Image GetEmptyChart(int width, int height, int chartScale, bool horizontalLines = false, bool verticalLines = false)
        {
            Image chartBitmap = new Bitmap(width, height);
            DrawHelperLines(chartBitmap, chartScale, horizontalLines, verticalLines);
            DrawAxes(chartBitmap, width/2.0f, height/2.0f);
            return chartBitmap;
        }
        #region PrivateMethods

        private static Image DrawFunctionChart(Image drawingSurface, PointF[] pointsToDraw, int chartScale, bool horizontalLines = false, bool verticalLines = false)
        {
            float translateX = drawingSurface.Width/2.0f;
            float translateY = drawingSurface.Height/2.0f;
            DrawHelperLines(drawingSurface, chartScale, horizontalLines, verticalLines);
            DrawAxes(drawingSurface, translateX, translateY);

            using (var drawingGraphics = Graphics.FromImage(drawingSurface))
            {
                drawingGraphics.SmoothingMode = SmoothingMode.AntiAlias;
                drawingGraphics.TranslateTransform(translateX, translateY);
                drawingGraphics.ScaleTransform(chartScale, -chartScale);
                drawingGraphics.DrawLines(new Pen(Color.Black, 0f), pointsToDraw);
            }
               
            return drawingSurface;
        }

        private static void DrawAxes(Image drawingSurface, float translateX, float translateY)
        {
            using (var drawingGraphics = Graphics.FromImage(drawingSurface))
            {
                drawingGraphics.SmoothingMode = SmoothingMode.AntiAlias;
                drawingGraphics.TranslateTransform(translateX, translateY);

                Pen pen = new Pen(Color.Black, 0.0f);
                pen.EndCap = LineCap.ArrowAnchor;

                drawingGraphics.DrawLine(pen, -translateX, 0, translateX, 0);
                drawingGraphics.DrawLine(pen, 0, translateY, 0, -translateY);
            }  
        }
        private static void DrawHelperLines(Image drawingSurface, int chartScale, bool horizontalLines = false, bool verticalLines = false)
        {
            float width = drawingSurface.Width / 2.0f;
            float height = drawingSurface.Height / 2.0f;

            using (var drawingGraphics = Graphics.FromImage(drawingSurface))
            {
                drawingGraphics.SmoothingMode = SmoothingMode.AntiAlias;
                drawingGraphics.TranslateTransform(width, height);
                drawingGraphics.ScaleTransform(chartScale, chartScale);

                var pen = new Pen(Color.LightGray, 0.0f);

                if (horizontalLines)
                {
                    DrawHelperHorizontalLines(pen, width, drawingGraphics);
                }
                if (verticalLines)
                {
                    DrawHelperVerticalLines(pen, height, drawingGraphics);
                }
            }
        }

        private static void DrawHelperHorizontalLines(Pen pen, float width, Graphics drawingGraphics)
        {
            for (float i = 0; i < width; i++)
            {
                drawingGraphics.DrawLine(pen, width, i, -width, i);
                drawingGraphics.DrawLine(pen, width, -i, -width, -i);
            }
        }

        private static void DrawHelperVerticalLines(Pen pen, float height, Graphics drawingGraphics)
        {
            for (float i = 0; i < height; i++)
            {
                drawingGraphics.DrawLine(pen, i, height, i, -height);
                drawingGraphics.DrawLine(pen, -i, height, -i, -height);
            }
        }
        
        #endregion

    }
}
