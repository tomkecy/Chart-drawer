﻿using System;
using System.Drawing;
using System.Windows.Forms;
using ChartDrawer.Abstract;
using ChartDrawer.Concrete;

namespace ChartDrawer
{
    public partial class ChartForm : Form
    {
        #region Private Fields
        private const int DefaultChartScale = 10;
        private Image _functionChartImage;
        

        private int _chartScale;
        private readonly IImageSaveHandler _imageSaveHandler;
        private readonly IChartGenerator _chartGenerator;

        #endregion

        #region Constructors

        public ChartForm()
        {
            _chartScale = DefaultChartScale;
            _imageSaveHandler = new ImageSaveHandler();
            _chartGenerator = new ChartGenerator();

            InitializeComponent();
            this._functionChartImage = _chartGenerator.GetEmptyChart(panelDrawField.Width, panelDrawField.Height, _chartScale);
        }

        #endregion


        private void DrawExponential()
        {
            double factor;
            double functionBase;
            try
            {
                factor = double.Parse(textBoxInput1.Text);
                functionBase = double.Parse(textBoxInput2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Wprowadzono niepoprawne dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            bool horizontalLines = checkedListBoxHelperLines.GetItemChecked(0);
            bool verticalLines = checkedListBoxHelperLines.GetItemChecked(1);

            _functionChartImage = _chartGenerator.GetExponentialFunctionChart(factor, functionBase, panelDrawField.Width,
                    panelDrawField.Height, _chartScale, horizontalLines, verticalLines);
            panelDrawField.Invalidate();

        }

        private void DrawCubic()
        {

            double a;
            double b;
            double c;
            double d;
            try
            {
                a = double.Parse(textBoxInput1.Text);
                b = double.Parse(textBoxInput2.Text);
                c = double.Parse(textBoxInput3.Text);
                d = double.Parse(textBoxInput4.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Wprowadzono niepoprawne dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            bool horizontalLines = checkedListBoxHelperLines.GetItemChecked(0);
            bool verticalLines = checkedListBoxHelperLines.GetItemChecked(1);
            _functionChartImage = _chartGenerator.GetCubicFunctionChart(a, b, c, d, panelDrawField.Width, panelDrawField.Height,
                _chartScale, horizontalLines, verticalLines);
            panelDrawField.Invalidate();
        }

        private void DrawSinus()
        {
            double a;
            double b;

            try
            {
                a = double.Parse(textBoxInput1.Text);
                b = double.Parse(textBoxInput2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Wprowadzono niepoprawne dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            bool horizontalLines = checkedListBoxHelperLines.GetItemChecked(0);
            bool verticalLines = checkedListBoxHelperLines.GetItemChecked(1);
            _functionChartImage = _chartGenerator.GetSineFunctionChart(a, b, panelDrawField.Width, panelDrawField.Height,
                _chartScale, horizontalLines, verticalLines);
            panelDrawField.Invalidate();

        }

        private void DrawCosinus()
        {

            double a;
            double b;

            try
            {
                a = double.Parse(textBoxInput1.Text);
                b = double.Parse(textBoxInput2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Wprowadzono niepoprawne dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            bool horizontalLines = checkedListBoxHelperLines.GetItemChecked(0);
            bool verticalLines = checkedListBoxHelperLines.GetItemChecked(1);
            _functionChartImage = _chartGenerator.GetCosineFunctionChart(a, b, panelDrawField.Width, panelDrawField.Height,
                _chartScale, horizontalLines, verticalLines);
            panelDrawField.Invalidate();
        }

        private void DrawLogarithm()
        {

            double functionBase;
            double factor;
            try
            {
                functionBase = double.Parse(textBoxInput1.Text);
                factor = double.Parse(textBoxInput2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Wprowadzono niepoprawne dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (functionBase <= 0 || functionBase.Equals(1.0))
            {
                MessageBox.Show("Wprowadzono niepoprawne dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            bool horizontalLines = checkedListBoxHelperLines.GetItemChecked(0);
            bool verticalLines = checkedListBoxHelperLines.GetItemChecked(1);
            _functionChartImage = _chartGenerator.GetLogarithmFunctionChart(factor, functionBase, panelDrawField.Width, panelDrawField.Height,
                _chartScale, horizontalLines, verticalLines);
            panelDrawField.Invalidate();
        }


        #region WinformsControls
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
        private void numericUpDownChartScale_ValueChanged(object sender, EventArgs e)
        {
            _chartScale = (int)numericUpDownChartScale.Value;
        }
        private void panelDrawField_Paint(object sender, PaintEventArgs e)
        {

            panelDrawField.BackgroundImage = _functionChartImage;

        }


        #endregion

        #region InputVisibilityHandlers
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

        #endregion

        #region MenuHandlers

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this._functionChartImage = (Bitmap)_chartGenerator.GetEmptyChart(panelDrawField.Width, panelDrawField.Height, _chartScale);
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
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void SaveToFile(Bitmap bitmapToSave)
        {
            _imageSaveHandler.SaveToFile(bitmapToSave);
        }
        #endregion

    }
}