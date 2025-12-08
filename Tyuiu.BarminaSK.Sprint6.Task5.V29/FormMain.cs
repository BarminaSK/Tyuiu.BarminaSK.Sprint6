using System.IO;
using Tyuiu.BarminaSK.Sprint6.Task5.V29.Lib;
namespace Tyuiu.BarminaSK.Sprint6.Task5.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = @"C:\Users\makar\source\repos\Tyuiu.BarminaSK.Sprint6\Tyuiu.Barminask.Sprint6.Task5.V29\bin\Debug\net8.0-windows\InPutDataFileTask5V29.txt";


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonDone_BSK_Click(object sender, EventArgs e)
        {
            dataGridViewNums_BSK.ColumnCount = 2;
            dataGridViewNums_BSK.Columns[0].Width = 20;
            dataGridViewNums_BSK.Columns[1].Width = 50;

            this.chartDiagramm_BSK.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiagramm_BSK.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiagramm_BSK.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewNums_BSK.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiagramm_BSK.Series[0].Points.AddXY(i, numsMass[i]);
            }

        }

        private void buttonSave_BSK_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_BSK_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Таск 5 выполнила студенка группы ПИНб-25-1 Бармина София Константиновна",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );

        }
    }
}
