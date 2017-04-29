namespace ChartDrawer
{
    partial class ChartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDraw = new System.Windows.Forms.Button();
            this.listBoxFunctionSelect = new System.Windows.Forms.ListBox();
            this.panelDrawField = new System.Windows.Forms.Panel();
            this.textBoxInput1 = new System.Windows.Forms.TextBox();
            this.textBoxInput2 = new System.Windows.Forms.TextBox();
            this.textBoxInput3 = new System.Windows.Forms.TextBox();
            this.textBoxInput4 = new System.Windows.Forms.TextBox();
            this.labelInput1 = new System.Windows.Forms.Label();
            this.labelInput2 = new System.Windows.Forms.Label();
            this.labelInput3 = new System.Windows.Forms.Label();
            this.labelInput4 = new System.Windows.Forms.Label();
            this.checkedListBoxHelperLines = new System.Windows.Forms.CheckedListBox();
            this.labelHelperLines = new System.Windows.Forms.Label();
            this.labelFunctionSelect = new System.Windows.Forms.Label();
            this.textBoxFunctionPattern = new System.Windows.Forms.TextBox();
            this.labelFunctionPattern = new System.Windows.Forms.Label();
            this.numericUpDownChartScale = new System.Windows.Forms.NumericUpDown();
            this.labelChartScale = new System.Windows.Forms.Label();
            this.menuStripWindowMenu = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChartScale)).BeginInit();
            this.menuStripWindowMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDraw
            // 
            this.buttonDraw.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonDraw.Location = new System.Drawing.Point(532, 366);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(242, 38);
            this.buttonDraw.TabIndex = 2;
            this.buttonDraw.Text = "Rysuj!";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // listBoxFunctionSelect
            // 
            this.listBoxFunctionSelect.FormattingEnabled = true;
            this.listBoxFunctionSelect.Items.AddRange(new object[] {
            "Sinus",
            "Cosinus",
            "Logarytm",
            "Sześcienna",
            "Wykładnicza"});
            this.listBoxFunctionSelect.Location = new System.Drawing.Point(529, 56);
            this.listBoxFunctionSelect.Name = "listBoxFunctionSelect";
            this.listBoxFunctionSelect.Size = new System.Drawing.Size(120, 82);
            this.listBoxFunctionSelect.TabIndex = 3;
            this.listBoxFunctionSelect.SelectedIndexChanged += new System.EventHandler(this.listBoxFunctionSelect_SelectedIndexChanged);
            // 
            // panelDrawField
            // 
            this.panelDrawField.BackColor = System.Drawing.Color.White;
            this.panelDrawField.Location = new System.Drawing.Point(17, 42);
            this.panelDrawField.Name = "panelDrawField";
            this.panelDrawField.Size = new System.Drawing.Size(506, 519);
            this.panelDrawField.TabIndex = 4;
            this.panelDrawField.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDrawField_Paint);
            // 
            // textBoxInput1
            // 
            this.textBoxInput1.Location = new System.Drawing.Point(567, 245);
            this.textBoxInput1.Name = "textBoxInput1";
            this.textBoxInput1.Size = new System.Drawing.Size(82, 20);
            this.textBoxInput1.TabIndex = 5;
            this.textBoxInput1.Visible = false;
            // 
            // textBoxInput2
            // 
            this.textBoxInput2.Location = new System.Drawing.Point(567, 271);
            this.textBoxInput2.Name = "textBoxInput2";
            this.textBoxInput2.Size = new System.Drawing.Size(82, 20);
            this.textBoxInput2.TabIndex = 6;
            this.textBoxInput2.Visible = false;
            // 
            // textBoxInput3
            // 
            this.textBoxInput3.Location = new System.Drawing.Point(567, 297);
            this.textBoxInput3.Name = "textBoxInput3";
            this.textBoxInput3.Size = new System.Drawing.Size(82, 20);
            this.textBoxInput3.TabIndex = 7;
            this.textBoxInput3.Visible = false;
            // 
            // textBoxInput4
            // 
            this.textBoxInput4.Location = new System.Drawing.Point(567, 323);
            this.textBoxInput4.Name = "textBoxInput4";
            this.textBoxInput4.Size = new System.Drawing.Size(82, 20);
            this.textBoxInput4.TabIndex = 8;
            this.textBoxInput4.Visible = false;
            // 
            // labelInput1
            // 
            this.labelInput1.AutoSize = true;
            this.labelInput1.Location = new System.Drawing.Point(529, 252);
            this.labelInput1.Name = "labelInput1";
            this.labelInput1.Size = new System.Drawing.Size(35, 13);
            this.labelInput1.TabIndex = 9;
            this.labelInput1.Text = "label1";
            this.labelInput1.Visible = false;
            // 
            // labelInput2
            // 
            this.labelInput2.AutoSize = true;
            this.labelInput2.Location = new System.Drawing.Point(529, 278);
            this.labelInput2.Name = "labelInput2";
            this.labelInput2.Size = new System.Drawing.Size(35, 13);
            this.labelInput2.TabIndex = 10;
            this.labelInput2.Text = "label2";
            this.labelInput2.Visible = false;
            // 
            // labelInput3
            // 
            this.labelInput3.AutoSize = true;
            this.labelInput3.Location = new System.Drawing.Point(529, 304);
            this.labelInput3.Name = "labelInput3";
            this.labelInput3.Size = new System.Drawing.Size(35, 13);
            this.labelInput3.TabIndex = 11;
            this.labelInput3.Text = "label3";
            this.labelInput3.Visible = false;
            // 
            // labelInput4
            // 
            this.labelInput4.AutoSize = true;
            this.labelInput4.Location = new System.Drawing.Point(529, 330);
            this.labelInput4.Name = "labelInput4";
            this.labelInput4.Size = new System.Drawing.Size(35, 13);
            this.labelInput4.TabIndex = 12;
            this.labelInput4.Text = "label4";
            this.labelInput4.Visible = false;
            // 
            // checkedListBoxHelperLines
            // 
            this.checkedListBoxHelperLines.FormattingEnabled = true;
            this.checkedListBoxHelperLines.Items.AddRange(new object[] {
            "Poziome",
            "Pionowe"});
            this.checkedListBoxHelperLines.Location = new System.Drawing.Point(655, 56);
            this.checkedListBoxHelperLines.Name = "checkedListBoxHelperLines";
            this.checkedListBoxHelperLines.Size = new System.Drawing.Size(120, 49);
            this.checkedListBoxHelperLines.TabIndex = 13;
            // 
            // labelHelperLines
            // 
            this.labelHelperLines.AutoSize = true;
            this.labelHelperLines.Location = new System.Drawing.Point(653, 40);
            this.labelHelperLines.Name = "labelHelperLines";
            this.labelHelperLines.Size = new System.Drawing.Size(89, 13);
            this.labelHelperLines.TabIndex = 14;
            this.labelHelperLines.Text = "Linie pomocnicze";
            // 
            // labelFunctionSelect
            // 
            this.labelFunctionSelect.AutoSize = true;
            this.labelFunctionSelect.Location = new System.Drawing.Point(533, 40);
            this.labelFunctionSelect.Name = "labelFunctionSelect";
            this.labelFunctionSelect.Size = new System.Drawing.Size(83, 13);
            this.labelFunctionSelect.TabIndex = 15;
            this.labelFunctionSelect.Text = "Wybierz funkcję";
            // 
            // textBoxFunctionPattern
            // 
            this.textBoxFunctionPattern.Location = new System.Drawing.Point(607, 211);
            this.textBoxFunctionPattern.Name = "textBoxFunctionPattern";
            this.textBoxFunctionPattern.ReadOnly = true;
            this.textBoxFunctionPattern.Size = new System.Drawing.Size(167, 20);
            this.textBoxFunctionPattern.TabIndex = 16;
            this.textBoxFunctionPattern.Visible = false;
            // 
            // labelFunctionPattern
            // 
            this.labelFunctionPattern.AutoSize = true;
            this.labelFunctionPattern.Location = new System.Drawing.Point(526, 214);
            this.labelFunctionPattern.Name = "labelFunctionPattern";
            this.labelFunctionPattern.Size = new System.Drawing.Size(72, 13);
            this.labelFunctionPattern.TabIndex = 17;
            this.labelFunctionPattern.Text = "Wzór funkcji: ";
            this.labelFunctionPattern.Visible = false;
            // 
            // numericUpDownChartScale
            // 
            this.numericUpDownChartScale.Location = new System.Drawing.Point(529, 177);
            this.numericUpDownChartScale.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownChartScale.Name = "numericUpDownChartScale";
            this.numericUpDownChartScale.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownChartScale.TabIndex = 18;
            this.numericUpDownChartScale.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownChartScale.ValueChanged += new System.EventHandler(this.numericUpDownChartScale_ValueChanged);
            // 
            // labelChartScale
            // 
            this.labelChartScale.AutoSize = true;
            this.labelChartScale.Location = new System.Drawing.Point(529, 157);
            this.labelChartScale.Name = "labelChartScale";
            this.labelChartScale.Size = new System.Drawing.Size(72, 13);
            this.labelChartScale.TabIndex = 19;
            this.labelChartScale.Text = "Powiększenie";
            // 
            // menuStripWindowMenu
            // 
            this.menuStripWindowMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem});
            this.menuStripWindowMenu.Location = new System.Drawing.Point(0, 0);
            this.menuStripWindowMenu.Name = "menuStripWindowMenu";
            this.menuStripWindowMenu.Size = new System.Drawing.Size(782, 24);
            this.menuStripWindowMenu.TabIndex = 20;
            this.menuStripWindowMenu.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.plikToolStripMenuItem.Text = "Menu";
            // 
            // ClearToolStripMenuItem
            // 
            this.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem";
            this.ClearToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.ClearToolStripMenuItem.Text = "Wyczyść";
            this.ClearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveToolStripMenuItem.Text = "Zapisz wykres...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.closeToolStripMenuItem.Text = "Zamknij";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // ChartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 588);
            this.Controls.Add(this.labelChartScale);
            this.Controls.Add(this.numericUpDownChartScale);
            this.Controls.Add(this.labelFunctionPattern);
            this.Controls.Add(this.textBoxFunctionPattern);
            this.Controls.Add(this.labelFunctionSelect);
            this.Controls.Add(this.labelHelperLines);
            this.Controls.Add(this.checkedListBoxHelperLines);
            this.Controls.Add(this.labelInput4);
            this.Controls.Add(this.labelInput3);
            this.Controls.Add(this.labelInput2);
            this.Controls.Add(this.labelInput1);
            this.Controls.Add(this.textBoxInput4);
            this.Controls.Add(this.textBoxInput3);
            this.Controls.Add(this.textBoxInput2);
            this.Controls.Add(this.textBoxInput1);
            this.Controls.Add(this.panelDrawField);
            this.Controls.Add(this.listBoxFunctionSelect);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.menuStripWindowMenu);
            this.MainMenuStrip = this.menuStripWindowMenu;
            this.Name = "ChartWindow";
            this.Text = "Wykresy";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChartScale)).EndInit();
            this.menuStripWindowMenu.ResumeLayout(false);
            this.menuStripWindowMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.ListBox listBoxFunctionSelect;
        private System.Windows.Forms.Panel panelDrawField;
        private System.Windows.Forms.TextBox textBoxInput1;
        private System.Windows.Forms.TextBox textBoxInput2;
        private System.Windows.Forms.TextBox textBoxInput3;
        private System.Windows.Forms.TextBox textBoxInput4;
        private System.Windows.Forms.Label labelInput1;
        private System.Windows.Forms.Label labelInput2;
        private System.Windows.Forms.Label labelInput3;
        private System.Windows.Forms.Label labelInput4;
        private System.Windows.Forms.CheckedListBox checkedListBoxHelperLines;
        private System.Windows.Forms.Label labelHelperLines;
        private System.Windows.Forms.Label labelFunctionSelect;
        private System.Windows.Forms.TextBox textBoxFunctionPattern;
        private System.Windows.Forms.Label labelFunctionPattern;
        private System.Windows.Forms.NumericUpDown numericUpDownChartScale;
        private System.Windows.Forms.Label labelChartScale;
        private System.Windows.Forms.MenuStrip menuStripWindowMenu;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearToolStripMenuItem;
    }
}