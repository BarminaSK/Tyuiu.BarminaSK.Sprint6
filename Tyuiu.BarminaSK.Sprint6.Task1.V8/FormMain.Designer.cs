namespace Tyuiu.BarminaSK.Sprint6.Task1.V8
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
            groupBoxCondition = new GroupBox();
            pictureBoxFormula = new PictureBox();
            labelCondition2 = new Label();
            labelCondition = new Label();
            groupBoxInPut = new GroupBox();
            labelEnd = new Label();
            labelStart = new Label();
            textBoxEnd = new TextBox();
            textBoxStart = new TextBox();
            groupBoxOutPut = new GroupBox();
            textBoxResult = new TextBox();
            labelResult = new Label();
            buttonHelp = new Button();
            buttonEnter = new Button();
            groupBoxCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).BeginInit();
            groupBoxInPut.SuspendLayout();
            groupBoxOutPut.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition
            // 
            groupBoxCondition.Controls.Add(pictureBoxFormula);
            groupBoxCondition.Controls.Add(labelCondition2);
            groupBoxCondition.Controls.Add(labelCondition);
            groupBoxCondition.Location = new Point(14, 14);
            groupBoxCondition.Name = "groupBoxCondition";
            groupBoxCondition.Size = new Size(582, 367);
            groupBoxCondition.TabIndex = 0;
            groupBoxCondition.TabStop = false;
            groupBoxCondition.Text = "Условие";
            // 
            // pictureBoxFormula
            // 
            pictureBoxFormula.Image = Properties.Resources.formula;
            pictureBoxFormula.Location = new Point(11, 53);
            pictureBoxFormula.Name = "pictureBoxFormula";
            pictureBoxFormula.Size = new Size(438, 58);
            pictureBoxFormula.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFormula.TabIndex = 2;
            pictureBoxFormula.TabStop = false;
            // 
            // labelCondition2
            // 
            labelCondition2.AutoSize = true;
            labelCondition2.Location = new Point(11, 114);
            labelCondition2.Name = "labelCondition2";
            labelCondition2.Size = new Size(261, 21);
            labelCondition2.TabIndex = 1;
            labelCondition2.Text = "Результат вывести в виде таблицы.";
            // 
            // labelCondition
            // 
            labelCondition.AutoSize = true;
            labelCondition.Location = new Point(11, 29);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(451, 21);
            labelCondition.TabIndex = 0;
            labelCondition.Text = "Протабулировать данную функцию на заданном диапазоне. ";
            // 
            // groupBoxInPut
            // 
            groupBoxInPut.Controls.Add(labelEnd);
            groupBoxInPut.Controls.Add(labelStart);
            groupBoxInPut.Controls.Add(textBoxEnd);
            groupBoxInPut.Controls.Add(textBoxStart);
            groupBoxInPut.Location = new Point(14, 387);
            groupBoxInPut.Name = "groupBoxInPut";
            groupBoxInPut.Size = new Size(292, 98);
            groupBoxInPut.TabIndex = 1;
            groupBoxInPut.TabStop = false;
            groupBoxInPut.Text = "Ввод данных:";
            // 
            // labelEnd
            // 
            labelEnd.AutoSize = true;
            labelEnd.Location = new Point(154, 25);
            labelEnd.Name = "labelEnd";
            labelEnd.Size = new Size(97, 21);
            labelEnd.TabIndex = 3;
            labelEnd.Text = "Конец шага:";
            // 
            // labelStart
            // 
            labelStart.AutoSize = true;
            labelStart.Location = new Point(11, 25);
            labelStart.Name = "labelStart";
            labelStart.Size = new Size(93, 21);
            labelStart.TabIndex = 2;
            labelStart.Text = "Старт шага:";
            // 
            // textBoxEnd
            // 
            textBoxEnd.Location = new Point(154, 55);
            textBoxEnd.Name = "textBoxEnd";
            textBoxEnd.Size = new Size(125, 29);
            textBoxEnd.TabIndex = 1;
            textBoxEnd.TextChanged += textBoxEnd_TextChanged;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(11, 55);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(125, 29);
            textBoxStart.TabIndex = 0;
            textBoxStart.TextChanged += textBoxStart_TextChanged;
            // 
            // groupBoxOutPut
            // 
            groupBoxOutPut.Controls.Add(textBoxResult);
            groupBoxOutPut.Controls.Add(labelResult);
            groupBoxOutPut.Location = new Point(627, 14);
            groupBoxOutPut.Name = "groupBoxOutPut";
            groupBoxOutPut.Size = new Size(346, 471);
            groupBoxOutPut.TabIndex = 2;
            groupBoxOutPut.TabStop = false;
            groupBoxOutPut.Text = "Вывод данных:";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(16, 64);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(324, 393);
            textBoxResult.TabIndex = 1;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(6, 29);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(83, 21);
            labelResult.TabIndex = 0;
            labelResult.Text = "Результат:";
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = SystemColors.MenuHighlight;
            buttonHelp.Location = new Point(312, 400);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(133, 81);
            buttonHelp.TabIndex = 3;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonEnter
            // 
            buttonEnter.BackColor = Color.Green;
            buttonEnter.Location = new Point(451, 400);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(145, 81);
            buttonEnter.TabIndex = 4;
            buttonEnter.Text = "Выполнить";
            buttonEnter.UseVisualStyleBackColor = false;
            buttonEnter.Click += buttonEnter_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 490);
            Controls.Add(buttonEnter);
            Controls.Add(buttonHelp);
            Controls.Add(groupBoxOutPut);
            Controls.Add(groupBoxInPut);
            Controls.Add(groupBoxCondition);
            Name = "FormMain";
            Text = "Спринт6 | Таск1 | Вариант 8 | Бармина С.К.";
            Load += FormMain_Load;
            groupBoxCondition.ResumeLayout(false);
            groupBoxCondition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).EndInit();
            groupBoxInPut.ResumeLayout(false);
            groupBoxInPut.PerformLayout();
            groupBoxOutPut.ResumeLayout(false);
            groupBoxOutPut.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition;
        private TextBox textBoxStart;
        private GroupBox groupBoxInPut;
        private GroupBox groupBoxOutPut;
        private Label labelCondition2;
        private Label labelCondition;
        private Label labelEnd;
        private Label labelStart;
        private TextBox textBoxEnd;
        private Label labelResult;
        private Button buttonHelp;
        private Button buttonEnter;
        private PictureBox pictureBoxFormula;
        private TextBox textBoxResult;
    }
}
