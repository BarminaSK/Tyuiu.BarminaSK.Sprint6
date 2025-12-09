namespace Tyuiu.BarminaSK.Sprint6.Task7.V23
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBoxPhoto_BSK = new PictureBox();
            labelInfo_BSK = new Label();
            buttonOK_BSK = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto_BSK).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxPhoto_BSK
            // 
            pictureBoxPhoto_BSK.Image = Properties.Resources.Photo;
            pictureBoxPhoto_BSK.Location = new Point(12, 31);
            pictureBoxPhoto_BSK.Name = "pictureBoxPhoto_BSK";
            pictureBoxPhoto_BSK.Size = new Size(172, 233);
            pictureBoxPhoto_BSK.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPhoto_BSK.TabIndex = 0;
            pictureBoxPhoto_BSK.TabStop = false;
            // 
            // labelInfo_BSK
            // 
            labelInfo_BSK.AutoSize = true;
            labelInfo_BSK.Location = new Point(201, 31);
            labelInfo_BSK.Name = "labelInfo_BSK";
            labelInfo_BSK.Size = new Size(394, 189);
            labelInfo_BSK.TabIndex = 1;
            labelInfo_BSK.Text = resources.GetString("labelInfo_BSK.Text");
            // 
            // buttonOK_BSK
            // 
            buttonOK_BSK.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            buttonOK_BSK.FlatAppearance.BorderSize = 2;
            buttonOK_BSK.FlatStyle = FlatStyle.Flat;
            buttonOK_BSK.Location = new Point(491, 236);
            buttonOK_BSK.Name = "buttonOK_BSK";
            buttonOK_BSK.Size = new Size(104, 33);
            buttonOK_BSK.TabIndex = 2;
            buttonOK_BSK.Text = "ОК";
            buttonOK_BSK.UseVisualStyleBackColor = true;
            buttonOK_BSK.Click += buttonOK_BSK_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 281);
            Controls.Add(buttonOK_BSK);
            Controls.Add(labelInfo_BSK);
            Controls.Add(pictureBoxPhoto_BSK);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto_BSK).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxPhoto_BSK;
        private Label labelInfo_BSK;
        private Button buttonOK_BSK;
    }
}