﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChartDrawer
{
    public partial class ChartForm : Form
    {

        private PointF[] pointsToDraw;
        private int numberOfPoints = 400;
        private double lowerXLimit = -40;
        private double pointInterval = 0.20f;
        private double defaultMaximumChartValue = 50;
        private int defaultChartScale = 10;
        private Bitmap drawingSurface;
        private Graphics drawingGraphics;

        private int chartScale;

        public ChartForm()
        {
            pointsToDraw = new PointF[numberOfPoints];
            chartScale = defaultChartScale;
            InitializeComponent();
            this.drawingSurface = new Bitmap(panelDrawField.Width, panelDrawField.Height);
            DrawAxes();
        }


        private void buttonDraw_Click(object sender, EventArgs e)
        {
            panelDrawField.Refresh();

            switch (listBoxFunctionSelect.SelectedIndex)
            {
                case 0:
                    DrawSinus();
                    break;
                case 1:
                    DrawCosinus();
                    break;
                case 2:
                    DrawLogarithm();
                    break;
                case 3:
                    DrawCubic();
                    break;
                case 4:
                    DrawExponential();
                    break;
            }



        }

        private void DrawExponential()
        {
            double a;
            double b;

            if (!Double.TryParse(textBoxInput1.Text, out a))
            {
                MessageBox.Show("Wprowadzono niepoprawne dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!Double.TryParse(textBoxInput2.Text, out b))
            {
                MessageBox.Show("Wprowadzono niepoprawne dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            double x = lowerXLimit;



            for (int i = 0; i < pointsToDraw.Length; i++)
            {

                double res = a * Math.Pow(b, x);
                if (res > defaultMaximumChartValue)
                {
                    pointsToDraw[i] = new PointF((float)x, (float)defaultMaximumChartValue);
                }
                else if (res < -defaultMaximumChartValue)
                {
                    pointsToDraw[i] = new PointF((float)x, (float)-defaultMaximumChartValue);
                }
                else
                    pointsToDraw[i] = new PointF((float)x, (float)res);
                x = x + pointInterval;

            }

            DrawFunction();
        }

        private void DrawCubic()
        {

            double a;
            double b;
            double c;
            double d;

            if (!Double.TryParse(textBoxInput1.Text, out a))
            {
                MessageBox.Show("Wprowadzono niepoprawne dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!Double.TryParse(textBoxInput2.Text, out b))
            {
                MessageBox.Show("Wprowadzono niepoprawne dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!Double.TryParse(textBoxInput3.Text, out c))
            {
                MessageBox.Show("Wprowadzono niepoprawne dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!Double.TryParse(textBoxInput4.Text, out d))
            {
                MessageBox.Show("Wprowadzono niepoprawne dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            double x = lowerXLimit;



            for (int i = 0; i < pointsToDraw.Length; i++)
            {
                double res = a * (Math.Pow(x, 3)) + b * (Math.Pow(x, 2)) + c * x + d;
                pointsToDraw[i] = new PointF((float)x, (float)res);
                x = x + pointInterval;

            }

            DrawFunction();
        }

        private void DrawSinus()
        {
            double a;
            double b;

            if (!Double.TryParse(textBoxInput1.Text, out a))
            {
                MessageBox.Show("Wprowadzono niepoprawne dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!Double.TryParse(textBoxInput2.Text, out b))
            {
                MessageBox.Show("Wprowadzono niepoprawne dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            double x = lowerXLimit;

            for (int i = 0; i < pointsToDraw.Length; i++)
            {
                double res = b * Math.Sin(x * a);
                pointsToDraw[i] = new PointF((float)x, (float)res);
                x = x + pointInterval;


            }

            DrawFunction();

        }

        private void DrawFunction()
        {
            this.drawingSurface = new Bitmap(panelDrawField.Width, panelDrawField.Height);
            DrawHelperLines();
            DrawAxes();

            this.drawingGraphics = Graphics.FromImage(this.drawingSurface);
            this.drawingGraphics.SmoothingMode = SmoothingMode.AntiAlias;
            this.drawingGraphics.TranslateTransform(panelDrawField.Width / 2, panelDrawField.Height / 2);
            this.drawingGraphics.ScaleTransform(chartScale, -chartScale);
            this.drawingGraphics.DrawLines(new Pen(Color.Black, 0f), pointsToDraw);
            this.panelDrawField.Invalidate();

        }

        private void DrawCosinus()
        {

            double a;
            double b;

            if (!Double.TryParse(textBoxInput1.Text, out a))
            {
                MessageBox.Show("Wprowadzono niepoprawne dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!Double.TryParse(textBoxInput2.Text, out b))
            {
                MessageBox.Show("Wprowadzono niepoprawne dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            double x = lowerXLimit;

            for (int i = 0; i < pointsToDraw.Length; i++)
            {
                double res = b * Math.Cos(x * a);

                pointsToDraw[i] = new PointF((float)x, (float)res);
                x = x + pointInterval;


            }

            DrawFunction();

        }

        private void DrawLogarithm()
        {

            double a;
            double b;

            if (!Double.TryParse(textBoxInput1.Text, out a))
            {
                MessageBox.Show("Wprowadzono niepoprawne dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!Double.TryParse(textBoxInput2.Text, out b))
            {
                MessageBox.Show("Wprowadzono niepoprawne dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (a <= 0 || a.Equals(1.0))
            {
                MessageBox.Show("Wprowadzono niepoprawne dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            double x = 0.0000001;

            for (int i = 0; i < pointsToDraw.Length; i++)
            {
                double res = b * Math.Log(x, a);
                pointsToDraw[i] = new PointF((float)x, (float)res);
                x = x + pointInterval;


            }

            DrawFunction();
        }

        private void panelDrawField_Paint(object sender, PaintEventArgs e)
        {

            panelDrawField.BackgroundImage = this.drawingSurface;

        }

        private void DrawAxes()
        {
            int width = panelDrawField.Width / 2;
            int height = panelDrawField.Height / 2;


            this.drawingGraphics = Graphics.FromImage(this.drawingSurface);
            this.drawingGraphics.SmoothingMode = SmoothingMode.AntiAlias;
            this.drawingGraphics.TranslateTransform(width, height);

            Pen pen = new Pen(Color.Black, 0.0f);
            pen.EndCap = LineCap.ArrowAnchor;

            this.drawingGraphics.DrawLine(pen, -width, 0, width, 0);
            this.drawingGraphics.DrawLine(pen, 0, height, 0, -height);

        }

        private void listBoxFunctionSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBoxFunctionSelect.SelectedIndex)
            {
                case 0:
                    ShowSinusInput();

                    break;
                case 1:
                    ShowCosinusInput();
                    break;
                case 2:
                    ShowLogarithmInput();
                    break;
                case 3:
                    ShowAlgebraicInput();
                    break;
                case 4:
                    ShowExponentialInput();
                    break;

                default:
                    HideFactorsInput();
                    break;
            }

        }

        private void ShowExponentialInput()
        {
            labelInput1.Visible = true;
            labelInput2.Visible = true;
            labelInput3.Visible = false;
            labelInput4.Visible = false;
            textBoxInput1.Visible = true;
            textBoxInput2.Visible = true;
            textBoxInput3.Visible = false;
            textBoxInput4.Visible = false;
            textBoxFunctionPattern.Visible = true;
            labelFunctionPattern.Visible = true;

            labelInput1.Text = "A";
            labelInput2.Text = "B";

            textBoxFunctionPattern.Text = " A * (B^x)";
        }

        private void HideFactorsInput()
        {
            labelInput1.Visible = false;
            labelInput2.Visible = false;
            labelInput3.Visible = false;
            labelInput4.Visible = false;
            textBoxInput1.Visible = false;
            textBoxInput2.Visible = false;
            textBoxInput3.Visible = false;
            textBoxInput4.Visible = false;
            textBoxFunctionPattern.Visible = false;
            labelFunctionPattern.Visible = false;
        }

        private void ShowLogarithmInput()
        {
            labelInput1.Visible = true;
            labelInput2.Visible = true;
            labelInput3.Visible = false;
            labelInput4.Visible = false;
            textBoxInput1.Visible = true;
            textBoxInput2.Visible = true;
            textBoxInput3.Visible = false;
            textBoxInput4.Visible = false;
            textBoxFunctionPattern.Visible = true;
            labelFunctionPattern.Visible = true;


            labelInput1.Text = "A";
            labelInput2.Text = "B";

            textBoxFunctionPattern.Text = "B Log A x";
        }

        private void ShowSinusInput()
        {
            labelInput1.Visible = true;
            labelInput2.Visible = true;
            labelInput3.Visible = false;
            labelInput4.Visible = false;
            textBoxInput1.Visible = true;
            textBoxInput2.Visible = true;
            textBoxInput3.Visible = false;
            textBoxInput4.Visible = false;
            textBoxFunctionPattern.Visible = true;
            labelFunctionPattern.Visible = true;

            labelInput1.Text = "A";
            labelInput2.Text = "B";

            textBoxFunctionPattern.Text = "A * sin (B*x)";


        }
        private void ShowCosinusInput()
        {
            labelInput1.Visible = true;
            labelInput2.Visible = true;
            labelInput3.Visible = false;
            labelInput4.Visible = false;
            textBoxInput1.Visible = true;
            textBoxInput2.Visible = true;
            textBoxInput3.Visible = false;
            textBoxInput4.Visible = false;
            textBoxFunctionPattern.Visible = true;
            labelFunctionPattern.Visible = true;

            labelInput1.Text = "A";
            labelInput2.Text = "B";

            textBoxFunctionPattern.Text = "A * cos (B*x)";


        }

        private void ShowAlgebraicInput()
        {


            labelInput1.Visible = true;
            labelInput2.Visible = true;
            labelInput3.Visible = true;
            labelInput4.Visible = true;
            textBoxInput1.Visible = true;
            textBoxInput2.Visible = true;
            textBoxInput3.Visible = true;
            textBoxInput4.Visible = true;
            textBoxFunctionPattern.Visible = true;
            labelFunctionPattern.Visible = true;

            labelInput1.Text = "A";
            labelInput2.Text = "B";
            labelInput3.Text = "C";
            labelInput4.Text = "D";

            textBoxFunctionPattern.Text = "A*x^3 + B*x^2 + C*x + D";
        }

        private void DrawHelperLines()
        {
            float width = panelDrawField.Width / 2;
            float height = panelDrawField.Height / 2;

            this.drawingGraphics = Graphics.FromImage(this.drawingSurface);
            this.drawingGraphics.SmoothingMode = SmoothingMode.AntiAlias;
            this.drawingGraphics.TranslateTransform(width, height);
            this.drawingGraphics.ScaleTransform(chartScale, chartScale);

            Pen pen = new Pen(Color.LightGray, 0.0f);

            if (checkedListBoxHelperLines.GetItemChecked(0))
            {
                DrawHelperHorizontalLines(pen, width);
            }
            if (checkedListBoxHelperLines.GetItemChecked(1))
            {
                DrawHelperVerticalLines(pen, height);
            }



        }

        private void DrawHelperHorizontalLines(Pen pen, float width)
        {
            for (float i = 0; i < width; i++)
            {
                this.drawingGraphics.DrawLine(pen, width, i, -width, i);
                this.drawingGraphics.DrawLine(pen, width, -i, -width, -i);
            }
        }

        private void DrawHelperVerticalLines(Pen pen, float height)
        {
            for (float i = 0; i < height; i++)
            {
                this.drawingGraphics.DrawLine(pen, i, height, i, -height);
                this.drawingGraphics.DrawLine(pen, -i, height, -i, -height);

            }
        }

        private void textBoxInput1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownChartScale_ValueChanged(object sender, EventArgs e)
        {
            chartScale = (int)numericUpDownChartScale.Value;
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawingSurface = new Bitmap(panelDrawField.Width, panelDrawField.Height);
            DrawHelperLines();
            DrawAxes();
            panelDrawField.Invalidate();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int width = panelDrawField.Width;
            int height = panelDrawField.Height;


            Bitmap bitmapToSave = new Bitmap(width, height);
            panelDrawField.DrawToBitmap(bitmapToSave, new Rectangle(0, 0, width, height));

            SaveToFile(bitmapToSave);
        }

        private static void SaveToFile(Bitmap bitmapToSave)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp";
            saveFileDialog.Title = "Zapisz obraz jako:";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                System.IO.FileStream fileStream =
                    (System.IO.FileStream)saveFileDialog.OpenFile();
                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        bitmapToSave.Save(fileStream, ImageFormat.Jpeg);
                        break;

                    case 2:
                        bitmapToSave.Save(fileStream, ImageFormat.Bmp);
                        break;
                }

                fileStream.Close();
            }
        }


        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}