namespace Tyuiu.BarminaSK.Sprint6.Task7.V23
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelTop_BSK = new Panel();
            buttonHelp_BSK = new Button();
            buttonSave_BSK = new Button();
            buttonDone_BSK = new Button();
            buttonOpen_BSK = new Button();
            groupBoxCondition_BSK = new GroupBox();
            labelCondition_BSK = new Label();
            panelLeft_BSK = new Panel();
            groupBoxIn_BSK = new GroupBox();
            dataGridViewIn_BSK = new DataGridView();
            panelFill_BSK = new Panel();
            groupBoxOut_BSK = new GroupBox();
            splitter1 = new Splitter();
            dataGridViewOut_BSK = new DataGridView();
            openFileDialogTask_BSK = new OpenFileDialog();
            saveFileDialogMatrix_BSK = new SaveFileDialog();
            toolTipOpen_BSK = new ToolTip(components);
            toolTipDone_BSK = new ToolTip(components);
            toolTipSave_BSK = new ToolTip(components);
            toolTipHelp_BSK = new ToolTip(components);
            panelTop_BSK.SuspendLayout();
            groupBoxCondition_BSK.SuspendLayout();
            panelLeft_BSK.SuspendLayout();
            groupBoxIn_BSK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_BSK).BeginInit();
            panelFill_BSK.SuspendLayout();
            groupBoxOut_BSK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_BSK).BeginInit();
            SuspendLayout();
            // 
            // panelTop_BSK
            // 
            panelTop_BSK.Controls.Add(buttonHelp_BSK);
            panelTop_BSK.Controls.Add(buttonSave_BSK);
            panelTop_BSK.Controls.Add(buttonDone_BSK);
            panelTop_BSK.Controls.Add(buttonOpen_BSK);
            panelTop_BSK.Controls.Add(groupBoxCondition_BSK);
            panelTop_BSK.Dock = DockStyle.Top;
            panelTop_BSK.Location = new Point(0, 0);
            panelTop_BSK.Name = "panelTop_BSK";
            panelTop_BSK.Size = new Size(1060, 191);
            panelTop_BSK.TabIndex = 0;
            // 
            // buttonHelp_BSK
            // 
            buttonHelp_BSK.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_BSK.Image = Properties.Resources.information;
            buttonHelp_BSK.Location = new Point(972, 12);
            buttonHelp_BSK.Name = "buttonHelp_BSK";
            buttonHelp_BSK.Size = new Size(76, 70);
            buttonHelp_BSK.TabIndex = 4;
            toolTipHelp_BSK.SetToolTip(buttonHelp_BSK, "Сведение о программе");
            buttonHelp_BSK.UseVisualStyleBackColor = true;
            buttonHelp_BSK.Click += buttonHelp_BSK_Click;
            // 
            // buttonSave_BSK
            // 
            buttonSave_BSK.Image = Properties.Resources.page_save;
            buttonSave_BSK.Location = new Point(198, 12);
            buttonSave_BSK.Name = "buttonSave_BSK";
            buttonSave_BSK.Size = new Size(76, 70);
            buttonSave_BSK.TabIndex = 3;
            toolTipSave_BSK.SetToolTip(buttonSave_BSK, "Сохранить обработанные данные в файл в формате CSV");
            buttonSave_BSK.UseVisualStyleBackColor = true;
            buttonSave_BSK.Click += buttonSave_BSK_Click;
            // 
            // buttonDone_BSK
            // 
            buttonDone_BSK.Image = Properties.Resources.page_white_go;
            buttonDone_BSK.Location = new Point(106, 12);
            buttonDone_BSK.Name = "buttonDone_BSK";
            buttonDone_BSK.Size = new Size(75, 70);
            buttonDone_BSK.TabIndex = 2;
            toolTipDone_BSK.SetToolTip(buttonDone_BSK, "Выполнить обработку данных");
            buttonDone_BSK.UseVisualStyleBackColor = true;
            buttonDone_BSK.Click += buttonDone_BSK_Click;
            // 
            // buttonOpen_BSK
            // 
            buttonOpen_BSK.Image = Properties.Resources.folder_page_white;
            buttonOpen_BSK.Location = new Point(15, 12);
            buttonOpen_BSK.Name = "buttonOpen_BSK";
            buttonOpen_BSK.Size = new Size(75, 70);
            buttonOpen_BSK.TabIndex = 1;
            toolTipOpen_BSK.SetToolTip(buttonOpen_BSK, "Открыть файл для обработки в формате CSV\r\n");
            buttonOpen_BSK.UseVisualStyleBackColor = true;
            buttonOpen_BSK.Click += buttonOpen_BSK_Click;
            // 
            // groupBoxCondition_BSK
            // 
            groupBoxCondition_BSK.Controls.Add(labelCondition_BSK);
            groupBoxCondition_BSK.Location = new Point(12, 88);
            groupBoxCondition_BSK.Name = "groupBoxCondition_BSK";
            groupBoxCondition_BSK.Size = new Size(1036, 100);
            groupBoxCondition_BSK.TabIndex = 0;
            groupBoxCondition_BSK.TabStop = false;
            groupBoxCondition_BSK.Text = "Условие";
            // 
            // labelCondition_BSK
            // 
            labelCondition_BSK.AutoSize = true;
            labelCondition_BSK.Dock = DockStyle.Fill;
            labelCondition_BSK.Location = new Point(3, 25);
            labelCondition_BSK.Name = "labelCondition_BSK";
            labelCondition_BSK.Size = new Size(970, 63);
            labelCondition_BSK.TabIndex = 0;
            labelCondition_BSK.Text = resources.GetString("labelCondition_BSK.Text");
            // 
            // panelLeft_BSK
            // 
            panelLeft_BSK.Controls.Add(groupBoxIn_BSK);
            panelLeft_BSK.Dock = DockStyle.Left;
            panelLeft_BSK.Location = new Point(0, 191);
            panelLeft_BSK.Name = "panelLeft_BSK";
            panelLeft_BSK.Size = new Size(514, 505);
            panelLeft_BSK.TabIndex = 1;
            // 
            // groupBoxIn_BSK
            // 
            groupBoxIn_BSK.Controls.Add(dataGridViewIn_BSK);
            groupBoxIn_BSK.Dock = DockStyle.Fill;
            groupBoxIn_BSK.Location = new Point(0, 0);
            groupBoxIn_BSK.Name = "groupBoxIn_BSK";
            groupBoxIn_BSK.Size = new Size(514, 505);
            groupBoxIn_BSK.TabIndex = 0;
            groupBoxIn_BSK.TabStop = false;
            groupBoxIn_BSK.Text = "Ввод:";
            // 
            // dataGridViewIn_BSK
            // 
            dataGridViewIn_BSK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_BSK.ColumnHeadersVisible = false;
            dataGridViewIn_BSK.Dock = DockStyle.Fill;
            dataGridViewIn_BSK.Location = new Point(3, 25);
            dataGridViewIn_BSK.Name = "dataGridViewIn_BSK";
            dataGridViewIn_BSK.RowHeadersVisible = false;
            dataGridViewIn_BSK.RowHeadersWidth = 51;
            dataGridViewIn_BSK.Size = new Size(508, 477);
            dataGridViewIn_BSK.TabIndex = 0;
            // 
            // panelFill_BSK
            // 
            panelFill_BSK.Controls.Add(groupBoxOut_BSK);
            panelFill_BSK.Dock = DockStyle.Fill;
            panelFill_BSK.Location = new Point(514, 191);
            panelFill_BSK.Name = "panelFill_BSK";
            panelFill_BSK.Size = new Size(546, 505);
            panelFill_BSK.TabIndex = 2;
            // 
            // groupBoxOut_BSK
            // 
            groupBoxOut_BSK.Controls.Add(splitter1);
            groupBoxOut_BSK.Controls.Add(dataGridViewOut_BSK);
            groupBoxOut_BSK.Dock = DockStyle.Fill;
            groupBoxOut_BSK.Location = new Point(0, 0);
            groupBoxOut_BSK.Name = "groupBoxOut_BSK";
            groupBoxOut_BSK.Size = new Size(546, 505);
            groupBoxOut_BSK.TabIndex = 0;
            groupBoxOut_BSK.TabStop = false;
            groupBoxOut_BSK.Text = "Вывод:";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(3, 25);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 477);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // dataGridViewOut_BSK
            // 
            dataGridViewOut_BSK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_BSK.ColumnHeadersVisible = false;
            dataGridViewOut_BSK.Dock = DockStyle.Fill;
            dataGridViewOut_BSK.Location = new Point(3, 25);
            dataGridViewOut_BSK.Name = "dataGridViewOut_BSK";
            dataGridViewOut_BSK.RowHeadersVisible = false;
            dataGridViewOut_BSK.RowHeadersWidth = 51;
            dataGridViewOut_BSK.Size = new Size(540, 477);
            dataGridViewOut_BSK.TabIndex = 0;
            // 
            // openFileDialogTask_BSK
            // 
            openFileDialogTask_BSK.FileName = "openFileDialog1";
            // 
            // toolTipOpen_BSK
            // 
            toolTipOpen_BSK.IsBalloon = true;
            toolTipOpen_BSK.ToolTipIcon = ToolTipIcon.Info;
            toolTipOpen_BSK.ToolTipTitle = "Открыть файл";
            // 
            // toolTipDone_BSK
            // 
            toolTipDone_BSK.IsBalloon = true;
            toolTipDone_BSK.ToolTipIcon = ToolTipIcon.Info;
            toolTipDone_BSK.ToolTipTitle = "Выполнить";
            // 
            // toolTipSave_BSK
            // 
            toolTipSave_BSK.IsBalloon = true;
            toolTipSave_BSK.ToolTipIcon = ToolTipIcon.Info;
            toolTipSave_BSK.ToolTipTitle = "Сохранить в файл";
            // 
            // toolTipHelp_BSK
            // 
            toolTipHelp_BSK.IsBalloon = true;
            toolTipHelp_BSK.ToolTipIcon = ToolTipIcon.Info;
            toolTipHelp_BSK.ToolTipTitle = "Справка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 696);
            Controls.Add(panelFill_BSK);
            Controls.Add(panelLeft_BSK);
            Controls.Add(panelTop_BSK);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 23 | Бармина С.К.";
            Load += FormMain_Load;
            panelTop_BSK.ResumeLayout(false);
            groupBoxCondition_BSK.ResumeLayout(false);
            groupBoxCondition_BSK.PerformLayout();
            panelLeft_BSK.ResumeLayout(false);
            groupBoxIn_BSK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_BSK).EndInit();
            panelFill_BSK.ResumeLayout(false);
            groupBoxOut_BSK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_BSK).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_BSK;
        private Panel panelLeft_BSK;
        private Panel panelFill_BSK;
        private GroupBox groupBoxCondition_BSK;
        private Label labelCondition_BSK;
        private GroupBox groupBoxIn_BSK;
        private GroupBox groupBoxOut_BSK;
        private Button buttonHelp_BSK;
        private Button buttonSave_BSK;
        private Button buttonDone_BSK;
        private Button buttonOpen_BSK;
        private OpenFileDialog openFileDialogTask_BSK;
        private SaveFileDialog saveFileDialogMatrix_BSK;
        private DataGridView dataGridViewIn_BSK;
        private DataGridView dataGridViewOut_BSK;
        private ToolTip toolTipOpen_BSK;
        private ToolTip toolTipDone_BSK;
        private ToolTip toolTipSave_BSK;
        private ToolTip toolTipHelp_BSK;
        private Splitter splitter1;
    }
}
