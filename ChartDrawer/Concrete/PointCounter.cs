using System;
using System.Drawing;
using ChartDrawer.Abstract;

namespace ChartDrawer.Concrete
{
    class PointCounter : IPointCounter
    {
        private const double LowerXLimit = -40;
        private const int NumberOfPoints = 400;
        private const double DefaultMaximumChartValue = 50;
        private const double PointInterval = 0.20;

        public PointF[] EvaluateCosinePoints(double factor, double functionBase)
        {
            double x = LowerXLimit;
            PointF[] pointsToDraw = new PointF[NumberOfPoints];
            for (int i = 0; i < pointsToDraw.Length; i++)
            {
                double res = factor * Math.Cos(x * functionBase);
                pointsToDraw[i] = new PointF((float)x, (float)res);
                x = x + PointInterval;
            }
            return pointsToDraw;
        }

        public PointF[] EvaluateCubicPoints(double a, double b, double c, double d)
        {
            double x = LowerXLimit;
            PointF[] pointsToDraw = new PointF[NumberOfPoints];
            for (int i = 0; i < pointsToDraw.Length; i++)
            {
                double res = a * (Math.Pow(x, 3)) + b * (Math.Pow(x, 2)) + c * x + d;
                pointsToDraw[i] = new PointF((float)x, (float)res);
                x = x + PointInterval;
            }
            return pointsToDraw;
        }

        public PointF[] EvaluateExponentialPoints(double factor, double functionBase)
        {
            PointF[] pointsToDraw = new PointF[NumberOfPoints];
            double x = LowerXLimit;
            for (int i = 0; i < pointsToDraw.Length; i++)
            {

                double res = factor * Math.Pow(functionBase, x);

                if (res > DefaultMaximumChartValue)
                {
                    pointsToDraw[i] = new PointF((float)x, (float)DefaultMaximumChartValue);
                }
                else if (res < -DefaultMaximumChartValue)
                {
                    pointsToDraw[i] = new PointF((float)x, (float)-DefaultMaximumChartValue);
                }
                else
                    pointsToDraw[i] = new PointF((float)x, (float)res);
                x = x + PointInterval;

            }

            return pointsToDraw;
        }

        public PointF[] EvaluateLogarithmPoints(double factor, double functionBase)
        {
            double x = 0.0000001;
            PointF[] pointsToDraw = new PointF[NumberOfPoints];
            for (int i = 0; i < pointsToDraw.Length; i++)
            {
                double res = factor * Math.Log(x, functionBase);
                pointsToDraw[i] = new PointF((float)x, (float)res);
                x = x + PointInterval;
            }
            return pointsToDraw;
        }

        public PointF[] EvaluateSinePoints(double factor, double functionBase)
        {
            double x = LowerXLimit;
            PointF[] pointsToDraw = new PointF[NumberOfPoints];
            for (int i = 0; i < pointsToDraw.Length; i++)
            {
                double res = factor * Math.Sin(x * functionBase);
                pointsToDraw[i] = new PointF((float)x, (float)res);
                x = x + PointInterval;
            }
            return pointsToDraw;
        }
    }
}