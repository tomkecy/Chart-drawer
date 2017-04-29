using System.Drawing;

namespace ChartDrawer.Abstract
{
    interface IPointCounter
    {
        PointF[] EvaluateSinePoints(double factor, double functionBase);
        PointF[] EvaluateCosinePoints(double factor, double functionBase);
        PointF[] EvaluateLogarithmPoints(double factor, double functionBase);
        PointF[] EvaluateCubicPoints(double a, double b, double c, double d);
        PointF[] EvaluateExponentialPoints(double factor, double functionBase);
    }
}