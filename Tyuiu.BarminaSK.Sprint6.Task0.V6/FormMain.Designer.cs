namespace Tyuiu.BarminaSK.Sprint6.Task0.V6
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxInput = new GroupBox();
            textBoxVarX = new TextBox();
            labelVarX = new Label();
            buttonResult = new Button();
            groupBoxOutput = new GroupBox();
            textBoxResult = new TextBox();
            labelResult = new Label();
            buttonHelp = new Button();
            groupBoxCondition = new GroupBox();
            pictureBoxformula = new PictureBox();
            labelCondition = new Label();
            groupBoxInput.SuspendLayout();
            groupBoxOutput.SuspendLayout();
            groupBoxCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxformula).BeginInit();
            SuspendLayout();
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(textBoxVarX);
            groupBoxInput.Controls.Add(labelVarX);
            groupBoxInput.Location = new Point(27, 300);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(350, 80);
            groupBoxInput.TabIndex = 1;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод данных";
            // 
            // textBoxVarX
            // 
            textBoxVarX.Location = new Point(10, 42);
            textBoxVarX.Name = "textBoxVarX";
            textBoxVarX.Size = new Size(100, 22);
            textBoxVarX.TabIndex = 1;
            textBoxVarX.KeyPress += textBoxVarX_KeyPress_1;
            // 
            // labelVarX
            // 
            labelVarX.AutoSize = true;
            labelVarX.Location = new Point(7, 22);
            labelVarX.Name = "labelVarX";
            labelVarX.Size = new Size(103, 16);
            labelVarX.TabIndex = 0;
            labelVarX.Text = "Переменная X:";
            // 
            // buttonResult
            // 
            buttonResult.BackColor = Color.LightCyan;
            buttonResult.ForeColor = Color.Black;
            buttonResult.Location = new Point(622, 386);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(126, 33);
            buttonResult.TabIndex = 2;
            buttonResult.Text = "Выполнить";
            buttonResult.UseVisualStyleBackColor = false;
            buttonResult.Click += buttonResult_Click_1;
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(textBoxResult);
            groupBoxOutput.Controls.Add(labelResult);
            groupBoxOutput.Location = new Point(398, 300);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(350, 80);
            groupBoxOutput.TabIndex = 3;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод данных";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(19, 41);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(100, 22);
            textBoxResult.TabIndex = 1;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(16, 21);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(80, 16);
            labelResult.TabIndex = 0;
            labelResult.Text = "Результат:";
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(575, 386);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(41, 33);
            buttonHelp.TabIndex = 4;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click_1;
            // 
            // groupBoxCondition
            // 
            groupBoxCondition.Controls.Add(pictureBoxformula);
            groupBoxCondition.Controls.Add(labelCondition);
            groupBoxCondition.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxCondition.Location = new Point(27, 28);
            groupBoxCondition.Name = "groupBoxCondition";
            groupBoxCondition.Size = new Size(721, 253);
            groupBoxCondition.TabIndex = 5;
            groupBoxCondition.TabStop = false;
            groupBoxCondition.Text = "Условие";
            // 
            // pictureBoxformula
            // 
            pictureBoxformula.Image = Properties.Resources.formula;
            pictureBoxformula.Location = new Point(390, 22);
            pictureBoxformula.Name = "pictureBoxformula";
            pictureBoxformula.Size = new Size(246, 131);
            pictureBoxformula.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxformula.TabIndex = 1;
            pictureBoxformula.TabStop = false;
            pictureBoxformula.Click += pictureBoxformula_Click;
            // 
            // labelCondition
            // 
            labelCondition.AutoSize = true;
            labelCondition.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelCondition.Location = new Point(10, 22);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(257, 18);
            labelCondition.TabIndex = 0;
            labelCondition.Text = "Вычислить выражение по формуле";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxCondition);
            Controls.Add(buttonHelp);
            Controls.Add(groupBoxOutput);
            Controls.Add(buttonResult);
            Controls.Add(groupBoxInput);
            Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 0 | Вариант 6 | Бармина С.К.";
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            groupBoxOutput.ResumeLayout(false);
            groupBoxOutput.PerformLayout();
            groupBoxCondition.ResumeLayout(false);
            groupBoxCondition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxformula).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.TextBox textBoxVarX;
        private System.Windows.Forms.Label labelVarX;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.GroupBox groupBoxCondition;
        private System.Windows.Forms.Label labelCondition;
        private PictureBox pictureBoxformula;
    }
}
