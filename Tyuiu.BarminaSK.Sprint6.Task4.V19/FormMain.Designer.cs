namespace Tyuiu.BarminaSK.Sprint6.Task4.V19
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            panelTop_BSK = new Panel();
            buttonHelp_BSK = new Button();
            buttonSave_BSK = new Button();
            buttonDone_BSK = new Button();
            groupBoxInPut_BSK = new GroupBox();
            textBoxEnd_BSK = new TextBox();
            textBoxStart_BSK = new TextBox();
            labelEnd_BSK = new Label();
            labelStart_BSK = new Label();
            groupBoxCondition_BSK = new GroupBox();
            pictureBoxCondition_BSK = new PictureBox();
            labelCondition_BSK = new Label();
            panelLeft_BSK = new Panel();
            groupBoxOutPut_BSK = new GroupBox();
            textBoxResult_BSK = new TextBox();
            panelFill_BSK = new Panel();
            chartFunction_BSK = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelTop_BSK.SuspendLayout();
            groupBoxInPut_BSK.SuspendLayout();
            groupBoxCondition_BSK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCondition_BSK).BeginInit();
            panelLeft_BSK.SuspendLayout();
            groupBoxOutPut_BSK.SuspendLayout();
            panelFill_BSK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_BSK).BeginInit();
            SuspendLayout();
            // 
            // panelTop_BSK
            // 
            panelTop_BSK.Controls.Add(buttonHelp_BSK);
            panelTop_BSK.Controls.Add(buttonSave_BSK);
            panelTop_BSK.Controls.Add(buttonDone_BSK);
            panelTop_BSK.Controls.Add(groupBoxInPut_BSK);
            panelTop_BSK.Controls.Add(groupBoxCondition_BSK);
            panelTop_BSK.Dock = DockStyle.Top;
            panelTop_BSK.Location = new Point(0, 0);
            panelTop_BSK.Name = "panelTop_BSK";
            panelTop_BSK.Size = new Size(1271, 194);
            panelTop_BSK.TabIndex = 0;
            // 
            // buttonHelp_BSK
            // 
            buttonHelp_BSK.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_BSK.BackColor = Color.DodgerBlue;
            buttonHelp_BSK.Location = new Point(1151, 63);
            buttonHelp_BSK.Name = "buttonHelp_BSK";
            buttonHelp_BSK.Size = new Size(108, 48);
            buttonHelp_BSK.TabIndex = 3;
            buttonHelp_BSK.Text = "Справка";
            buttonHelp_BSK.UseVisualStyleBackColor = false;
            buttonHelp_BSK.Click += buttonHelp_BSK_Click;
            // 
            // buttonSave_BSK
            // 
            buttonSave_BSK.BackColor = SystemColors.MenuHighlight;
            buttonSave_BSK.Location = new Point(1003, 63);
            buttonSave_BSK.Name = "buttonSave_BSK";
            buttonSave_BSK.Size = new Size(124, 48);
            buttonSave_BSK.TabIndex = 2;
            buttonSave_BSK.Text = "Сохранить";
            buttonSave_BSK.UseVisualStyleBackColor = false;
            buttonSave_BSK.Click += buttonSave_BSK_Click;
            // 
            // buttonDone_BSK
            // 
            buttonDone_BSK.BackColor = Color.Green;
            buttonDone_BSK.Location = new Point(879, 63);
            buttonDone_BSK.Name = "buttonDone_BSK";
            buttonDone_BSK.Size = new Size(118, 48);
            buttonDone_BSK.TabIndex = 1;
            buttonDone_BSK.Text = "Выполнить";
            buttonDone_BSK.UseVisualStyleBackColor = false;
            buttonDone_BSK.Click += buttonDone_BSK_Click;
            // 
            // groupBoxInPut_BSK
            // 
            groupBoxInPut_BSK.Controls.Add(textBoxEnd_BSK);
            groupBoxInPut_BSK.Controls.Add(textBoxStart_BSK);
            groupBoxInPut_BSK.Controls.Add(labelEnd_BSK);
            groupBoxInPut_BSK.Controls.Add(labelStart_BSK);
            groupBoxInPut_BSK.Location = new Point(585, 32);
            groupBoxInPut_BSK.Name = "groupBoxInPut_BSK";
            groupBoxInPut_BSK.Size = new Size(278, 110);
            groupBoxInPut_BSK.TabIndex = 0;
            groupBoxInPut_BSK.TabStop = false;
            groupBoxInPut_BSK.Text = "Ввод данных:";
            // 
            // textBoxEnd_BSK
            // 
            textBoxEnd_BSK.Location = new Point(140, 60);
            textBoxEnd_BSK.Name = "textBoxEnd_BSK";
            textBoxEnd_BSK.Size = new Size(125, 29);
            textBoxEnd_BSK.TabIndex = 3;
            // 
            // textBoxStart_BSK
            // 
            textBoxStart_BSK.Location = new Point(0, 60);
            textBoxStart_BSK.Name = "textBoxStart_BSK";
            textBoxStart_BSK.Size = new Size(125, 29);
            textBoxStart_BSK.TabIndex = 2;
            // 
            // labelEnd_BSK
            // 
            labelEnd_BSK.AutoSize = true;
            labelEnd_BSK.Location = new Point(140, 31);
            labelEnd_BSK.Name = "labelEnd_BSK";
            labelEnd_BSK.Size = new Size(97, 21);
            labelEnd_BSK.TabIndex = 1;
            labelEnd_BSK.Text = "Конец шага:";
            // 
            // labelStart_BSK
            // 
            labelStart_BSK.AutoSize = true;
            labelStart_BSK.Location = new Point(6, 31);
            labelStart_BSK.Name = "labelStart_BSK";
            labelStart_BSK.Size = new Size(93, 21);
            labelStart_BSK.TabIndex = 0;
            labelStart_BSK.Text = "Старт шага:";
            // 
            // groupBoxCondition_BSK
            // 
            groupBoxCondition_BSK.Controls.Add(pictureBoxCondition_BSK);
            groupBoxCondition_BSK.Controls.Add(labelCondition_BSK);
            groupBoxCondition_BSK.Dock = DockStyle.Top;
            groupBoxCondition_BSK.Location = new Point(0, 0);
            groupBoxCondition_BSK.Name = "groupBoxCondition_BSK";
            groupBoxCondition_BSK.Size = new Size(1271, 177);
            groupBoxCondition_BSK.TabIndex = 0;
            groupBoxCondition_BSK.TabStop = false;
            groupBoxCondition_BSK.Text = "Условие";
            // 
            // pictureBoxCondition_BSK
            // 
            pictureBoxCondition_BSK.Image = Properties.Resources.Formula;
            pictureBoxCondition_BSK.Location = new Point(9, 60);
            pictureBoxCondition_BSK.Name = "pictureBoxCondition_BSK";
            pictureBoxCondition_BSK.Size = new Size(327, 65);
            pictureBoxCondition_BSK.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCondition_BSK.TabIndex = 0;
            pictureBoxCondition_BSK.TabStop = false;
            // 
            // labelCondition_BSK
            // 
            labelCondition_BSK.AutoSize = true;
            labelCondition_BSK.Location = new Point(9, 25);
            labelCondition_BSK.Name = "labelCondition_BSK";
            labelCondition_BSK.Size = new Size(555, 147);
            labelCondition_BSK.TabIndex = 0;
            labelCondition_BSK.Text = "Протабулировать данную функцию на заданном диапазоне.\r\n\r\n\r\n\r\n\r\nРезультат вывести в TextBox, построить график функции и сохранить в файл\r\nOutPutFileTask4.txt по нажатию кнопки.";
            // 
            // panelLeft_BSK
            // 
            panelLeft_BSK.Controls.Add(groupBoxOutPut_BSK);
            panelLeft_BSK.Dock = DockStyle.Left;
            panelLeft_BSK.Location = new Point(0, 194);
            panelLeft_BSK.Name = "panelLeft_BSK";
            panelLeft_BSK.Size = new Size(293, 709);
            panelLeft_BSK.TabIndex = 1;
            // 
            // groupBoxOutPut_BSK
            // 
            groupBoxOutPut_BSK.Controls.Add(textBoxResult_BSK);
            groupBoxOutPut_BSK.Dock = DockStyle.Fill;
            groupBoxOutPut_BSK.Location = new Point(0, 0);
            groupBoxOutPut_BSK.Name = "groupBoxOutPut_BSK";
            groupBoxOutPut_BSK.Size = new Size(293, 709);
            groupBoxOutPut_BSK.TabIndex = 0;
            groupBoxOutPut_BSK.TabStop = false;
            groupBoxOutPut_BSK.Text = "Вывод:";
            // 
            // textBoxResult_BSK
            // 
            textBoxResult_BSK.Dock = DockStyle.Fill;
            textBoxResult_BSK.Location = new Point(3, 25);
            textBoxResult_BSK.Multiline = true;
            textBoxResult_BSK.Name = "textBoxResult_BSK";
            textBoxResult_BSK.ScrollBars = ScrollBars.Vertical;
            textBoxResult_BSK.Size = new Size(287, 681);
            textBoxResult_BSK.TabIndex = 0;
            // 
            // panelFill_BSK
            // 
            panelFill_BSK.Controls.Add(chartFunction_BSK);
            panelFill_BSK.Dock = DockStyle.Fill;
            panelFill_BSK.Location = new Point(293, 194);
            panelFill_BSK.Name = "panelFill_BSK";
            panelFill_BSK.Size = new Size(978, 709);
            panelFill_BSK.TabIndex = 2;
            // 
            // chartFunction_BSK
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_BSK.ChartAreas.Add(chartArea1);
            chartFunction_BSK.Dock = DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartFunction_BSK.Legends.Add(legend1);
            chartFunction_BSK.Location = new Point(0, 0);
            chartFunction_BSK.Name = "chartFunction_BSK";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "График данной функции";
            chartFunction_BSK.Series.Add(series1);
            chartFunction_BSK.Size = new Size(978, 709);
            chartFunction_BSK.TabIndex = 0;
            chartFunction_BSK.Text = "График данной функции";
            title1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            title1.ForeColor = Color.MediumBlue;
            title1.Name = "TitleChart_BSK";
            title1.Text = "График функции (5*х + 2,5)/(sin(x) - 2) + 2";
            chartFunction_BSK.Titles.Add(title1);
            chartFunction_BSK.Click += chartFunction_BSK_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1271, 903);
            Controls.Add(panelFill_BSK);
            Controls.Add(panelLeft_BSK);
            Controls.Add(panelTop_BSK);
            MinimumSize = new Size(800, 450);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 19 | Бармина С.К.";
            Load += Form1_Load;
            panelTop_BSK.ResumeLayout(false);
            groupBoxInPut_BSK.ResumeLayout(false);
            groupBoxInPut_BSK.PerformLayout();
            groupBoxCondition_BSK.ResumeLayout(false);
            groupBoxCondition_BSK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCondition_BSK).EndInit();
            panelLeft_BSK.ResumeLayout(false);
            groupBoxOutPut_BSK.ResumeLayout(false);
            groupBoxOutPut_BSK.PerformLayout();
            panelFill_BSK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_BSK).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_BSK;
        private GroupBox groupBoxCondition_BSK;
        private Panel panelLeft_BSK;
        private GroupBox groupBoxOutPut_BSK;
        private Panel panelFill_BSK;
        private GroupBox groupBoxInPut_BSK;
        private Label labelCondition_BSK;
        private PictureBox pictureBoxCondition_BSK;
        private TextBox textBoxEnd_BSK;
        private TextBox textBoxStart_BSK;
        private Label labelEnd_BSK;
        private Label labelStart_BSK;
        private Button buttonHelp_BSK;
        private Button buttonSave_BSK;
        private Button buttonDone_BSK;
        private TextBox textBoxResult_BSK;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_BSK;
    }
}
