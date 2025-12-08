using Tyuiu.BarminaSK.Sprint6.Task4.V19.Lib;

namespace Tyuiu.BarminaSK.Sprint6.Task4.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        DataService ds = new DataService(); 
        private void buttonDone_BSK_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_BSK.Text);
                int stopStep = Convert.ToInt32(textBoxEnd_BSK.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_BSK.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_BSK.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_BSK.Text = "";

                chartFunction_BSK.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_BSK.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_BSK.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_BSK_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxResult_BSK.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_BSK_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
               "Таск 4 выполнила студентка группы ПИНб-25-1 Бармина София Константиновна",
               "Сообщение",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);
        }

        private void chartFunction_BSK_Click(object sender, EventArgs e)
        {

        }
    }
}
