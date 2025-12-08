using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;
using Tyuiu.BarminaSK.Sprint6.Task2.V21.Lib;

namespace Tyuiu.BarminaSK.Sprint6.Task2.V21
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
        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart.Text);
                int stopStep = Convert.ToInt32(textBoxEnd.Text);
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                //double[] valueArray;
                //valueArray = new double[len];
                double[] valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chartFunction.Titles.Add("График данной функции");

                this.chartFunction.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
               "Таск 2 выполнила студентка группы ПИНб-25-1 Бармина София Константиновна",
               "Сообщение",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information
           );
        }

        private void chartFunction_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.Red;
        }

        private void buttonDone_MouseLeave(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.Green;
        }

        private void buttonDone_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone.BackColor = Color.Blue;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}