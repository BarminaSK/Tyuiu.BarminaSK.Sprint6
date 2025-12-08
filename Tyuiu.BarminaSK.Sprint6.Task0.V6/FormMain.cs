using Tyuiu.BarminaSK.Sprint6.Task0.V6.Lib;

namespace Tyuiu.BarminaSK.Sprint6.Task0.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void textBoxVarX_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                buttonResult_Click_1(sender, e);
                e.Handled = true;
            }
        }

        private void buttonResult_Click_1(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {

                textBoxResult.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(
               "Таск 0 выполнила студентка группы ПИНб-25-1 Бармина София Константиновна",
               "Сообщение",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information
           );
        }

        private void pictureBoxformula_Click(object sender, EventArgs e)
        {

        }
    }
}
