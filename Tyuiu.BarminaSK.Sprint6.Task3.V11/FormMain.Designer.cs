namespace Tyuiu.BarminaSK.Sprint6.Task3.V11
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
            groupBoxCondition_BSK = new GroupBox();
            dataGridViewCondition_BSK = new DataGridView();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            Column15 = new DataGridViewTextBoxColumn();
            labelCondition_BSK = new Label();
            groupBoxResult_BSK = new GroupBox();
            textBoxResult_BSK = new TextBox();
            labelResult_BSK = new Label();
            buttonHelp_BSK = new Button();
            buttonDone_BSK = new Button();
            groupBoxCondition_BSK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCondition_BSK).BeginInit();
            groupBoxResult_BSK.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_BSK
            // 
            groupBoxCondition_BSK.Controls.Add(dataGridViewCondition_BSK);
            groupBoxCondition_BSK.Controls.Add(labelCondition_BSK);
            groupBoxCondition_BSK.Location = new Point(16, 14);
            groupBoxCondition_BSK.Name = "groupBoxCondition_BSK";
            groupBoxCondition_BSK.Size = new Size(542, 424);
            groupBoxCondition_BSK.TabIndex = 0;
            groupBoxCondition_BSK.TabStop = false;
            groupBoxCondition_BSK.Text = "Условие";
            // 
            // dataGridViewCondition_BSK
            // 
            dataGridViewCondition_BSK.AllowUserToAddRows = false;
            dataGridViewCondition_BSK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCondition_BSK.ColumnHeadersVisible = false;
            dataGridViewCondition_BSK.Columns.AddRange(new DataGridViewColumn[] { Column11, Column12, Column13, Column14, Column15 });
            dataGridViewCondition_BSK.Location = new Point(17, 190);
            dataGridViewCondition_BSK.Name = "dataGridViewCondition_BSK";
            dataGridViewCondition_BSK.RowHeadersVisible = false;
            dataGridViewCondition_BSK.RowHeadersWidth = 51;
            dataGridViewCondition_BSK.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewCondition_BSK.Size = new Size(490, 214);
            dataGridViewCondition_BSK.TabIndex = 1;
            dataGridViewCondition_BSK.CellContentClick += dataGridViewCondition_BSK_CellContentClick;
            // 
            // Column11
            // 
            Column11.HeaderText = "";
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            Column11.Width = 60;
            // 
            // Column12
            // 
            Column12.HeaderText = "";
            Column12.MinimumWidth = 6;
            Column12.Name = "Column12";
            Column12.Width = 60;
            // 
            // Column13
            // 
            Column13.HeaderText = "";
            Column13.MinimumWidth = 6;
            Column13.Name = "Column13";
            Column13.Width = 60;
            // 
            // Column14
            // 
            Column14.HeaderText = "";
            Column14.MinimumWidth = 6;
            Column14.Name = "Column14";
            Column14.Width = 60;
            // 
            // Column15
            // 
            Column15.HeaderText = "";
            Column15.MinimumWidth = 6;
            Column15.Name = "Column15";
            Column15.Width = 60;
            // 
            // labelCondition_BSK
            // 
            labelCondition_BSK.AutoSize = true;
            labelCondition_BSK.Location = new Point(17, 30);
            labelCondition_BSK.Name = "labelCondition_BSK";
            labelCondition_BSK.Size = new Size(431, 147);
            labelCondition_BSK.TabIndex = 0;
            labelCondition_BSK.Text = "Дана матрица 5 на 5.\r\n27 -15 14 2 27\r\n-8 14 10 33 0\r\n1 7 -11 -11 23\r\n-13 -20 15 -16 34\r\n-3 1 -1 5 1\r\nВыполнить сортировку по возрастанию в первом столбце.";
            // 
            // groupBoxResult_BSK
            // 
            groupBoxResult_BSK.Controls.Add(textBoxResult_BSK);
            groupBoxResult_BSK.Controls.Add(labelResult_BSK);
            groupBoxResult_BSK.Location = new Point(578, 14);
            groupBoxResult_BSK.Name = "groupBoxResult_BSK";
            groupBoxResult_BSK.Size = new Size(210, 312);
            groupBoxResult_BSK.TabIndex = 1;
            groupBoxResult_BSK.TabStop = false;
            groupBoxResult_BSK.Text = "Вывод данных:";
            // 
            // textBoxResult_BSK
            // 
            textBoxResult_BSK.Location = new Point(14, 60);
            textBoxResult_BSK.Multiline = true;
            textBoxResult_BSK.Name = "textBoxResult_BSK";
            textBoxResult_BSK.ReadOnly = true;
            textBoxResult_BSK.Size = new Size(190, 120);
            textBoxResult_BSK.TabIndex = 1;
            // 
            // labelResult_BSK
            // 
            labelResult_BSK.AutoSize = true;
            labelResult_BSK.Location = new Point(9, 31);
            labelResult_BSK.Name = "labelResult_BSK";
            labelResult_BSK.Size = new Size(83, 21);
            labelResult_BSK.TabIndex = 0;
            labelResult_BSK.Text = "Результат:";
            // 
            // buttonHelp_BSK
            // 
            buttonHelp_BSK.BackColor = SystemColors.ControlLight;
            buttonHelp_BSK.FlatAppearance.BorderColor = Color.RoyalBlue;
            buttonHelp_BSK.FlatAppearance.BorderSize = 2;
            buttonHelp_BSK.FlatStyle = FlatStyle.Flat;
            buttonHelp_BSK.Location = new Point(603, 393);
            buttonHelp_BSK.Name = "buttonHelp_BSK";
            buttonHelp_BSK.Size = new Size(41, 41);
            buttonHelp_BSK.TabIndex = 2;
            buttonHelp_BSK.Text = "?";
            buttonHelp_BSK.UseVisualStyleBackColor = false;
            buttonHelp_BSK.Click += buttonHelp_BSK_Click;
            // 
            // buttonDone_BSK
            // 
            buttonDone_BSK.BackColor = SystemColors.InactiveBorder;
            buttonDone_BSK.Location = new Point(662, 393);
            buttonDone_BSK.Name = "buttonDone_BSK";
            buttonDone_BSK.Size = new Size(126, 41);
            buttonDone_BSK.TabIndex = 3;
            buttonDone_BSK.Text = "Выполнить";
            buttonDone_BSK.UseVisualStyleBackColor = false;
            buttonDone_BSK.Click += buttonDone_BSK_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDone_BSK);
            Controls.Add(buttonHelp_BSK);
            Controls.Add(groupBoxResult_BSK);
            Controls.Add(groupBoxCondition_BSK);
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 11 | Бармина С.К.";
            Load += Form1_Load;
            groupBoxCondition_BSK.ResumeLayout(false);
            groupBoxCondition_BSK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCondition_BSK).EndInit();
            groupBoxResult_BSK.ResumeLayout(false);
            groupBoxResult_BSK.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_BSK;
        private Label labelCondition_BSK;
        private GroupBox groupBoxResult_BSK;
        private Label labelResult_BSK;
        private DataGridView dataGridViewCondition_BSK;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column15;
        private Button buttonHelp_BSK;
        private Button buttonDone_BSK;
        private TextBox textBoxResult_BSK;
    }
}
