namespace Tyuiu.BarminaSK.Sprint6.Task6.V27
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
            buttonOpen_BSK = new Button();
            buttonDone_BSK = new Button();
            groupBoxCondition_BSK = new GroupBox();
            labelCondition_BSK = new Label();
            panelLeft_BSK = new Panel();
            groupBoxInPut_BSK = new GroupBox();
            textBoxIn_BSK = new TextBox();
            panelFill_BSK = new Panel();
            groupBoxOutPut_BSK = new GroupBox();
            textBoxOut_BSK = new TextBox();
            openFileDialogTask_BSK = new OpenFileDialog();
            toolTipTask_BSK = new ToolTip(components);
            toolTipFile_BSK = new ToolTip(components);
            panelTop_BSK.SuspendLayout();
            groupBoxCondition_BSK.SuspendLayout();
            panelLeft_BSK.SuspendLayout();
            groupBoxInPut_BSK.SuspendLayout();
            panelFill_BSK.SuspendLayout();
            groupBoxOutPut_BSK.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop_BSK
            // 
            panelTop_BSK.Controls.Add(buttonHelp_BSK);
            panelTop_BSK.Controls.Add(buttonOpen_BSK);
            panelTop_BSK.Controls.Add(buttonDone_BSK);
            panelTop_BSK.Controls.Add(groupBoxCondition_BSK);
            panelTop_BSK.Dock = DockStyle.Top;
            panelTop_BSK.Location = new Point(0, 0);
            panelTop_BSK.Name = "panelTop_BSK";
            panelTop_BSK.Size = new Size(1075, 216);
            panelTop_BSK.TabIndex = 0;
            // 
            // buttonHelp_BSK
            // 
            buttonHelp_BSK.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_BSK.Image = Properties.Resources.information;
            buttonHelp_BSK.Location = new Point(969, 19);
            buttonHelp_BSK.Name = "buttonHelp_BSK";
            buttonHelp_BSK.Size = new Size(94, 91);
            buttonHelp_BSK.TabIndex = 3;
            buttonHelp_BSK.UseVisualStyleBackColor = true;
            buttonHelp_BSK.Click += buttonHelp_BSK_Click;
            // 
            // buttonOpen_BSK
            // 
            buttonOpen_BSK.Image = Properties.Resources.page_white_go;
            buttonOpen_BSK.Location = new Point(135, 19);
            buttonOpen_BSK.Name = "buttonOpen_BSK";
            buttonOpen_BSK.Size = new Size(94, 91);
            buttonOpen_BSK.TabIndex = 2;
            toolTipFile_BSK.SetToolTip(buttonOpen_BSK, "Производит поиск в файле вхождений \"Н\"\r\nи конкатенирует строки, в которых находятся эти символы.");
            buttonOpen_BSK.UseVisualStyleBackColor = true;
            buttonOpen_BSK.Click += buttonOpen_BSK_Click;
            // 
            // buttonDone_BSK
            // 
            buttonDone_BSK.Image = Properties.Resources.folder_page_white;
            buttonDone_BSK.Location = new Point(18, 19);
            buttonDone_BSK.Name = "buttonDone_BSK";
            buttonDone_BSK.Size = new Size(96, 91);
            buttonDone_BSK.TabIndex = 1;
            toolTipTask_BSK.SetToolTip(buttonDone_BSK, "Открыть файл.\r\nВыберите нужный файл для обработки.");
            buttonDone_BSK.UseVisualStyleBackColor = true;
            buttonDone_BSK.Click += buttonDone_BSK_Click;
            // 
            // groupBoxCondition_BSK
            // 
            groupBoxCondition_BSK.Controls.Add(labelCondition_BSK);
            groupBoxCondition_BSK.Location = new Point(12, 118);
            groupBoxCondition_BSK.Name = "groupBoxCondition_BSK";
            groupBoxCondition_BSK.Size = new Size(1051, 125);
            groupBoxCondition_BSK.TabIndex = 0;
            groupBoxCondition_BSK.TabStop = false;
            groupBoxCondition_BSK.Text = "Условие";
            // 
            // labelCondition_BSK
            // 
            labelCondition_BSK.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelCondition_BSK.AutoSize = true;
            labelCondition_BSK.Location = new Point(6, 25);
            labelCondition_BSK.Name = "labelCondition_BSK";
            labelCondition_BSK.Size = new Size(997, 63);
            labelCondition_BSK.TabIndex = 0;
            labelCondition_BSK.Text = resources.GetString("labelCondition_BSK.Text");
            // 
            // panelLeft_BSK
            // 
            panelLeft_BSK.Controls.Add(groupBoxInPut_BSK);
            panelLeft_BSK.Dock = DockStyle.Left;
            panelLeft_BSK.Location = new Point(0, 216);
            panelLeft_BSK.Name = "panelLeft_BSK";
            panelLeft_BSK.Size = new Size(507, 515);
            panelLeft_BSK.TabIndex = 1;
            // 
            // groupBoxInPut_BSK
            // 
            groupBoxInPut_BSK.Controls.Add(textBoxIn_BSK);
            groupBoxInPut_BSK.Dock = DockStyle.Fill;
            groupBoxInPut_BSK.Location = new Point(0, 0);
            groupBoxInPut_BSK.Name = "groupBoxInPut_BSK";
            groupBoxInPut_BSK.Size = new Size(507, 515);
            groupBoxInPut_BSK.TabIndex = 0;
            groupBoxInPut_BSK.TabStop = false;
            groupBoxInPut_BSK.Text = "Ввод:";
            // 
            // textBoxIn_BSK
            // 
            textBoxIn_BSK.Dock = DockStyle.Fill;
            textBoxIn_BSK.Location = new Point(3, 25);
            textBoxIn_BSK.Multiline = true;
            textBoxIn_BSK.Name = "textBoxIn_BSK";
            textBoxIn_BSK.ReadOnly = true;
            textBoxIn_BSK.ScrollBars = ScrollBars.Vertical;
            textBoxIn_BSK.Size = new Size(501, 487);
            textBoxIn_BSK.TabIndex = 0;
            // 
            // panelFill_BSK
            // 
            panelFill_BSK.Controls.Add(groupBoxOutPut_BSK);
            panelFill_BSK.Dock = DockStyle.Fill;
            panelFill_BSK.Location = new Point(507, 216);
            panelFill_BSK.Name = "panelFill_BSK";
            panelFill_BSK.Size = new Size(568, 515);
            panelFill_BSK.TabIndex = 2;
            // 
            // groupBoxOutPut_BSK
            // 
            groupBoxOutPut_BSK.Controls.Add(textBoxOut_BSK);
            groupBoxOutPut_BSK.Dock = DockStyle.Fill;
            groupBoxOutPut_BSK.Location = new Point(0, 0);
            groupBoxOutPut_BSK.Name = "groupBoxOutPut_BSK";
            groupBoxOutPut_BSK.Size = new Size(568, 515);
            groupBoxOutPut_BSK.TabIndex = 0;
            groupBoxOutPut_BSK.TabStop = false;
            groupBoxOutPut_BSK.Text = "Вывод:";
            // 
            // textBoxOut_BSK
            // 
            textBoxOut_BSK.Dock = DockStyle.Fill;
            textBoxOut_BSK.Location = new Point(3, 25);
            textBoxOut_BSK.Multiline = true;
            textBoxOut_BSK.Name = "textBoxOut_BSK";
            textBoxOut_BSK.ReadOnly = true;
            textBoxOut_BSK.ScrollBars = ScrollBars.Vertical;
            textBoxOut_BSK.Size = new Size(562, 487);
            textBoxOut_BSK.TabIndex = 0;
            // 
            // openFileDialogTask_BSK
            // 
            openFileDialogTask_BSK.FileName = "openFileDialog1";
            // 
            // toolTipTask_BSK
            // 
            toolTipTask_BSK.ToolTipIcon = ToolTipIcon.Info;
            toolTipTask_BSK.ToolTipTitle = "Подсказка";
            // 
            // toolTipFile_BSK
            // 
            toolTipFile_BSK.ToolTipIcon = ToolTipIcon.Info;
            toolTipFile_BSK.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 731);
            Controls.Add(panelFill_BSK);
            Controls.Add(panelLeft_BSK);
            Controls.Add(panelTop_BSK);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 6 | Вариант 27 | Бармина С.К.";
            Load += FormMain_Load;
            panelTop_BSK.ResumeLayout(false);
            groupBoxCondition_BSK.ResumeLayout(false);
            groupBoxCondition_BSK.PerformLayout();
            panelLeft_BSK.ResumeLayout(false);
            groupBoxInPut_BSK.ResumeLayout(false);
            groupBoxInPut_BSK.PerformLayout();
            panelFill_BSK.ResumeLayout(false);
            groupBoxOutPut_BSK.ResumeLayout(false);
            groupBoxOutPut_BSK.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_BSK;
        private Panel panelLeft_BSK;
        private Panel panelFill_BSK;
        private GroupBox groupBoxCondition_BSK;
        private GroupBox groupBoxInPut_BSK;
        private GroupBox groupBoxOutPut_BSK;
        private Label labelCondition_BSK;
        private TextBox textBoxIn_BSK;
        private TextBox textBoxOut_BSK;
        private Button buttonHelp_BSK;
        private Button buttonOpen_BSK;
        private Button buttonDone_BSK;
        private OpenFileDialog openFileDialogTask_BSK;
        private ToolTip toolTipTask_BSK;
        private ToolTip toolTipFile_BSK;
    }
}
