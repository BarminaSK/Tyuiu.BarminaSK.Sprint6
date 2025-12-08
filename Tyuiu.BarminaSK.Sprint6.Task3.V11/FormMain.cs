using System.Text;
using System.Windows.Forms;
using Tyuiu.BarminaSK.Sprint6.Task3.V11.Lib;

namespace Tyuiu.BarminaSK.Sprint6.Task3.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        
        private void Form1_Load(object sender, EventArgs e)
        {
            FillDataGridViewWithMatrix();
        }

        private void dataGridViewCondition_BSK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void FillDataGridViewWithMatrix()
        {
            dataGridViewCondition_BSK.Rows.Clear();
            dataGridViewCondition_BSK.Rows.Add("27", "-15", "14", "2", "27");
            dataGridViewCondition_BSK.Rows.Add("-8", "14", "-10", "33", "0");
            dataGridViewCondition_BSK.Rows.Add("1", "7", "-11", "-11", "23");
            dataGridViewCondition_BSK.Rows.Add("-13", "-20", "15", "-16", "34");
            dataGridViewCondition_BSK.Rows.Add("-3", "1", "-1", "5", "1");
        }

        private void buttonDone_BSK_Click(object sender, EventArgs e)
        {
            try
            {
                int[,] matrix = ds.GetInitialMatrix();
                int[,] sortedMatrix = ds.Calculate(matrix);

                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        sb.Append(sortedMatrix[i, j]);
                        if (j < 4) sb.Append(" ");
                    }
                    sb.AppendLine();
                }

                textBoxResult_BSK.Text = sb.ToString().Trim();
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_BSK_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
               "Таск 2 выполнила студентка группы ПИНб-25-1 Бармина София Константиновна",
               "Сообщение",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information
           );
        }
    }
}
