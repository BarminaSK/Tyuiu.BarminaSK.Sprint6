namespace Tyuiu.BarminaSK.Sprint6.Task2.V21
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxCondition = new GroupBox();
            pictureBoxCondition = new PictureBox();
            labelCondition2 = new Label();
            labelCondition = new Label();
            groupBoxInPut = new GroupBox();
            textBoxEnd = new TextBox();
            textBoxStart = new TextBox();
            labelEnd = new Label();
            labelStart = new Label();
            groupBoxOutPut = new GroupBox();
            dataGridViewFunction = new DataGridView();
            ColumnX = new DataGridViewTextBoxColumn();
            ColumnY = new DataGridViewTextBoxColumn();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            labelResult = new Label();
            buttonHelp = new Button();
            buttonDone = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            groupBoxCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCondition).BeginInit();
            groupBoxInPut.SuspendLayout();
            groupBoxOutPut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition
            // 
            groupBoxCondition.Controls.Add(pictureBoxCondition);
            groupBoxCondition.Controls.Add(labelCondition2);
            groupBoxCondition.Controls.Add(labelCondition);
            groupBoxCondition.Location = new Point(12, 18);
            groupBoxCondition.Name = "groupBoxCondition";
            groupBoxCondition.Size = new Size(540, 311);
            groupBoxCondition.TabIndex = 0;
            groupBoxCondition.TabStop = false;
            groupBoxCondition.Text = "Условие";
            // 
            // pictureBoxCondition
            // 
            pictureBoxCondition.Image = Properties.Resources.formula;
            pictureBoxCondition.Location = new Point(12, 68);
            pictureBoxCondition.Name = "pictureBoxCondition";
            pictureBoxCondition.Size = new Size(429, 64);
            pictureBoxCondition.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCondition.TabIndex = 2;
            pictureBoxCondition.TabStop = false;
            // 
            // labelCondition2
            // 
            labelCondition2.AutoSize = true;
            labelCondition2.Location = new Point(12, 144);
            labelCondition2.Name = "labelCondition2";
            labelCondition2.Size = new Size(406, 21);
            labelCondition2.TabIndex = 1;
            labelCondition2.Text = "Результат в DataGridView и построить график функции";
            // 
            // labelCondition
            // 
            labelCondition.AutoSize = true;
            labelCondition.Location = new Point(12, 32);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(429, 21);
            labelCondition.TabIndex = 0;
            labelCondition.Text = "Протабулировать данную функцию на данном диапазоне";
            // 
            // groupBoxInPut
            // 
            groupBoxInPut.Controls.Add(textBoxEnd);
            groupBoxInPut.Controls.Add(textBoxStart);
            groupBoxInPut.Controls.Add(labelEnd);
            groupBoxInPut.Controls.Add(labelStart);
            groupBoxInPut.Location = new Point(12, 338);
            groupBoxInPut.Name = "groupBoxInPut";
            groupBoxInPut.Size = new Size(308, 93);
            groupBoxInPut.TabIndex = 0;
            groupBoxInPut.TabStop = false;
            groupBoxInPut.Text = "Ввод данных:";
            // 
            // textBoxEnd
            // 
            textBoxEnd.Location = new Point(159, 51);
            textBoxEnd.Name = "textBoxEnd";
            textBoxEnd.Size = new Size(125, 29);
            textBoxEnd.TabIndex = 3;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(12, 51);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(129, 29);
            textBoxStart.TabIndex = 2;
            // 
            // labelEnd
            // 
            labelEnd.AutoSize = true;
            labelEnd.Location = new Point(159, 27);
            labelEnd.Name = "labelEnd";
            labelEnd.Size = new Size(97, 21);
            labelEnd.TabIndex = 1;
            labelEnd.Text = "Конец шага:";
            // 
            // labelStart
            // 
            labelStart.AutoSize = true;
            labelStart.Location = new Point(12, 27);
            labelStart.Name = "labelStart";
            labelStart.Size = new Size(93, 21);
            labelStart.TabIndex = 0;
            labelStart.Text = "Старт шага:";
            // 
            // groupBoxOutPut
            // 
            groupBoxOutPut.Controls.Add(dataGridViewFunction);
            groupBoxOutPut.Controls.Add(chartFunction);
            groupBoxOutPut.Controls.Add(labelResult);
            groupBoxOutPut.Location = new Point(570, 18);
            groupBoxOutPut.Name = "groupBoxOutPut";
            groupBoxOutPut.Size = new Size(685, 413);
            groupBoxOutPut.TabIndex = 1;
            groupBoxOutPut.TabStop = false;
            groupBoxOutPut.Text = "Вывод данных:";
            // 
            // dataGridViewFunction
            // 
            dataGridViewFunction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction.Columns.AddRange(new DataGridViewColumn[] { ColumnX, ColumnY });
            dataGridViewFunction.Location = new Point(6, 63);
            dataGridViewFunction.Name = "dataGridViewFunction";
            dataGridViewFunction.RowHeadersVisible = false;
            dataGridViewFunction.RowHeadersWidth = 51;
            dataGridViewFunction.Size = new Size(123, 305);
            dataGridViewFunction.TabIndex = 2;
            dataGridViewFunction.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ColumnX
            // 
            ColumnX.HeaderText = "X";
            ColumnX.MinimumWidth = 6;
            ColumnX.Name = "ColumnX";
            ColumnX.Width = 60;
            // 
            // ColumnY
            // 
            ColumnY.HeaderText = "f(X)";
            ColumnY.MinimumWidth = 6;
            ColumnY.Name = "ColumnY";
            ColumnY.Width = 60;
            // 
            // chartFunction
            // 
            chartArea2.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartFunction.Legends.Add(legend2);
            chartFunction.Location = new Point(149, 63);
            chartFunction.Name = "chartFunction";
            chartFunction.RightToLeft = RightToLeft.Yes;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartFunction.Series.Add(series2);
            chartFunction.Size = new Size(423, 305);
            chartFunction.TabIndex = 1;
            chartFunction.Text = "chart1";
            chartFunction.Click += chartFunction_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(6, 32);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(83, 21);
            labelResult.TabIndex = 0;
            labelResult.Text = "Результат:";
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = SystemColors.MenuHighlight;
            buttonHelp.Location = new Point(328, 355);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(102, 58);
            buttonHelp.TabIndex = 2;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(436, 355);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(116, 58);
            buttonDone.TabIndex = 3;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            buttonDone.MouseDown += buttonDone_MouseDown;
            buttonDone.MouseEnter += buttonDone_MouseEnter;
            buttonDone.MouseLeave += buttonDone_MouseLeave;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 444);
            Controls.Add(buttonDone);
            Controls.Add(buttonHelp);
            Controls.Add(groupBoxOutPut);
            Controls.Add(groupBoxInPut);
            Controls.Add(groupBoxCondition);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 21 | Бармина С.К.";
            Load += Form1_Load;
            groupBoxCondition.ResumeLayout(false);
            groupBoxCondition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCondition).EndInit();
            groupBoxInPut.ResumeLayout(false);
            groupBoxInPut.PerformLayout();
            groupBoxOutPut.ResumeLayout(false);
            groupBoxOutPut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition;
        private GroupBox groupBoxInPut;
        private GroupBox groupBoxOutPut;
        private Label labelCondition2;
        private Label labelCondition;
        private Label labelEnd;
        private Label labelStart;
        private Label labelResult;
        private PictureBox pictureBoxCondition;
        private TextBox textBoxEnd;
        private TextBox textBoxStart;
        private Button buttonHelp;
        private Button buttonDone;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private DataGridView dataGridViewFunction;
        private DataGridViewTextBoxColumn ColumnX;
        private DataGridViewTextBoxColumn ColumnY;
    }
}
