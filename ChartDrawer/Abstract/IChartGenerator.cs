using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartDrawer.Abstract
{
    interface IChartGenerator
    {
        Image GetExponentialFunctionChart(double factor, double functionBase, int width, int height, int chartScale,
            bool horizontalLines = false, bool verticalLines = false);
        Image GetCubicFunctionChart(double a, double b, double c, double d, int width, int height, int chartScale,
            bool horizontalLines = false, bool verticalLines = false);
        Image GetSineFunctionChart(double factor, double functionBase, int width, int height, int chartScale,
            bool horizontalLines = false, bool verticalLines = false);
        Image GetCosineFunctionChart(double factor, double functionBase, int width, int height, int chartScale,
            bool horizontalLines = false, bool verticalLines = false);
        Image GetLogarithmFunctionChart(double factor, double functionBase, int width, int height, int chartScale,
            bool horizontalLines = false, bool verticalLines = false);
        Image GetEmptyChart(int width, int height, int chartScale, bool horizontalLines = false, bool verticalLines = false);
    }
}
