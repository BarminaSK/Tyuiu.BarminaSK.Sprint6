using Tyuiu.BarminaSK.Sprint6.Task1.V8.Lib;

namespace Tyuiu.BarminaSK.Sprint6.Task1.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart.Text);
                int stopStep = Convert.ToInt32(textBoxEnd.Text);
                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult.Text = "";
                textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
                textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1,7:f2}  |", startStep, valueArray[i]);
                    textBoxResult.AppendText(strLine + Environment.NewLine);

                    startStep++;
                }

                textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);
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
               "Таск 1 выполнила студентка группы ПИНб-25-1 Бармина София Константиновна",
               "Сообщение",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information
           );
        }

        private void textBoxStart_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEnd_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }
    }
}
