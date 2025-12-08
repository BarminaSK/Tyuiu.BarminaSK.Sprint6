namespace Tyuiu.BarminaSK.Sprint6.Task5.V29
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
            panelTop_BSK = new Panel();
            buttonSave_BSK = new Button();
            buttonHelp_BSK = new Button();
            buttonDone_BSK = new Button();
            groupBoxCondition_BSK = new GroupBox();
            labelCondition_BSK = new Label();
            panelLeft_BSK = new Panel();
            groupBoxOutPut_BSK = new GroupBox();
            dataGridViewNums_BSK = new DataGridView();
            panelFill_BSK = new Panel();
            chartDiagramm_BSK = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelTop_BSK.SuspendLayout();
            groupBoxCondition_BSK.SuspendLayout();
            panelLeft_BSK.SuspendLayout();
            groupBoxOutPut_BSK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums_BSK).BeginInit();
            panelFill_BSK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartDiagramm_BSK).BeginInit();
            SuspendLayout();
            // 
            // panelTop_BSK
            // 
            panelTop_BSK.Controls.Add(buttonSave_BSK);
            panelTop_BSK.Controls.Add(buttonHelp_BSK);
            panelTop_BSK.Controls.Add(buttonDone_BSK);
            panelTop_BSK.Controls.Add(groupBoxCondition_BSK);
            panelTop_BSK.Dock = DockStyle.Top;
            panelTop_BSK.Location = new Point(0, 0);
            panelTop_BSK.Name = "panelTop_BSK";
            panelTop_BSK.Size = new Size(1112, 155);
            panelTop_BSK.TabIndex = 0;
            // 
            // buttonSave_BSK
            // 
            buttonSave_BSK.BackColor = SystemColors.Highlight;
            buttonSave_BSK.Location = new Point(698, 67);
            buttonSave_BSK.Name = "buttonSave_BSK";
            buttonSave_BSK.Size = new Size(117, 53);
            buttonSave_BSK.TabIndex = 2;
            buttonSave_BSK.Text = "Открыть\r\nфайл";
            buttonSave_BSK.UseVisualStyleBackColor = false;
            buttonSave_BSK.Click += buttonSave_BSK_Click;
            // 
            // buttonHelp_BSK
            // 
            buttonHelp_BSK.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_BSK.BackColor = SystemColors.MenuHighlight;
            buttonHelp_BSK.Location = new Point(986, 67);
            buttonHelp_BSK.Name = "buttonHelp_BSK";
            buttonHelp_BSK.Size = new Size(99, 53);
            buttonHelp_BSK.TabIndex = 3;
            buttonHelp_BSK.Text = "Справка";
            buttonHelp_BSK.UseVisualStyleBackColor = false;
            buttonHelp_BSK.Click += buttonHelp_BSK_Click;
            // 
            // buttonDone_BSK
            // 
            buttonDone_BSK.BackColor = Color.Green;
            buttonDone_BSK.Location = new Point(556, 67);
            buttonDone_BSK.Name = "buttonDone_BSK";
            buttonDone_BSK.Size = new Size(117, 53);
            buttonDone_BSK.TabIndex = 1;
            buttonDone_BSK.Text = "Выполнить";
            buttonDone_BSK.UseVisualStyleBackColor = false;
            buttonDone_BSK.Click += buttonDone_BSK_Click;
            // 
            // groupBoxCondition_BSK
            // 
            groupBoxCondition_BSK.Controls.Add(labelCondition_BSK);
            groupBoxCondition_BSK.Location = new Point(15, 17);
            groupBoxCondition_BSK.Name = "groupBoxCondition_BSK";
            groupBoxCondition_BSK.Size = new Size(509, 125);
            groupBoxCondition_BSK.TabIndex = 0;
            groupBoxCondition_BSK.TabStop = false;
            groupBoxCondition_BSK.Text = "Условие";
            // 
            // labelCondition_BSK
            // 
            labelCondition_BSK.AutoSize = true;
            labelCondition_BSK.Location = new Point(14, 29);
            labelCondition_BSK.Name = "labelCondition_BSK";
            labelCondition_BSK.Size = new Size(473, 63);
            labelCondition_BSK.TabIndex = 0;
            labelCondition_BSK.Text = "Прочитать данные из файла InPutDataFileTask5V29.txt. Вывести в\r\ndataGridView значения больше или равные 10, построить\r\nдиаграмму по этим значениям.";
            // 
            // panelLeft_BSK
            // 
            panelLeft_BSK.Controls.Add(groupBoxOutPut_BSK);
            panelLeft_BSK.Dock = DockStyle.Left;
            panelLeft_BSK.Location = new Point(0, 155);
            panelLeft_BSK.Name = "panelLeft_BSK";
            panelLeft_BSK.Size = new Size(292, 619);
            panelLeft_BSK.TabIndex = 1;
            // 
            // groupBoxOutPut_BSK
            // 
            groupBoxOutPut_BSK.Controls.Add(dataGridViewNums_BSK);
            groupBoxOutPut_BSK.Location = new Point(10, 15);
            groupBoxOutPut_BSK.Name = "groupBoxOutPut_BSK";
            groupBoxOutPut_BSK.Size = new Size(266, 592);
            groupBoxOutPut_BSK.TabIndex = 0;
            groupBoxOutPut_BSK.TabStop = false;
            groupBoxOutPut_BSK.Text = "Вывод данных:";
            // 
            // dataGridViewNums_BSK
            // 
            dataGridViewNums_BSK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNums_BSK.Dock = DockStyle.Fill;
            dataGridViewNums_BSK.Location = new Point(3, 25);
            dataGridViewNums_BSK.Name = "dataGridViewNums_BSK";
            dataGridViewNums_BSK.ReadOnly = true;
            dataGridViewNums_BSK.RowHeadersWidth = 51;
            dataGridViewNums_BSK.ScrollBars = ScrollBars.Vertical;
            dataGridViewNums_BSK.Size = new Size(260, 564);
            dataGridViewNums_BSK.TabIndex = 0;
            // 
            // panelFill_BSK
            // 
            panelFill_BSK.Controls.Add(chartDiagramm_BSK);
            panelFill_BSK.Dock = DockStyle.Fill;
            panelFill_BSK.Location = new Point(292, 155);
            panelFill_BSK.Name = "panelFill_BSK";
            panelFill_BSK.Size = new Size(820, 619);
            panelFill_BSK.TabIndex = 2;
            // 
            // chartDiagramm_BSK
            // 
            chartArea1.Name = "ChartArea1";
            chartDiagramm_BSK.ChartAreas.Add(chartArea1);
            chartDiagramm_BSK.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartDiagramm_BSK.Legends.Add(legend1);
            chartDiagramm_BSK.Location = new Point(0, 0);
            chartDiagramm_BSK.Name = "chartDiagramm_BSK";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDiagramm_BSK.Series.Add(series1);
            chartDiagramm_BSK.Size = new Size(820, 619);
            chartDiagramm_BSK.TabIndex = 0;
            chartDiagramm_BSK.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 774);
            Controls.Add(panelFill_BSK);
            Controls.Add(panelLeft_BSK);
            Controls.Add(panelTop_BSK);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 29 | Бармина С.К.";
            Load += Form1_Load;
            panelTop_BSK.ResumeLayout(false);
            groupBoxCondition_BSK.ResumeLayout(false);
            groupBoxCondition_BSK.PerformLayout();
            panelLeft_BSK.ResumeLayout(false);
            groupBoxOutPut_BSK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums_BSK).EndInit();
            panelFill_BSK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartDiagramm_BSK).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_BSK;
        private GroupBox groupBoxCondition_BSK;
        private Panel panelLeft_BSK;
        private GroupBox groupBoxOutPut_BSK;
        private DataGridView dataGridViewNums_BSK;
        private Panel panelFill_BSK;
        private Button buttonHelp_BSK;
        private Button buttonSave_BSK;
        private Button buttonDone_BSK;
        private Label labelCondition_BSK;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiagramm_BSK;
    }
}
