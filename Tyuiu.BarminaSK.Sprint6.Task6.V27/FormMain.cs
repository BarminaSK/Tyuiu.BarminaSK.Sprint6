using Tyuiu.BarminaSK.Sprint6.Task6.V27.Lib;

namespace Tyuiu.BarminaSK.Sprint6.Task6.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string openFilePath;
        DataService ds = new DataService();
        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonDone_BSK_Click(object sender, EventArgs e)
        {
            openFileDialogTask_BSK.ShowDialog();
            openFilePath = openFileDialogTask_BSK.FileName;
            textBoxIn_BSK.Text = File.ReadAllText(openFilePath);
            groupBoxInPut_BSK.Text = groupBoxOutPut_BSK.Text + " " + openFileDialogTask_BSK.FileName;
            buttonDone_BSK.Enabled = true;
        }

        private void buttonOpen_BSK_Click(object sender, EventArgs e)
        {
            textBoxOut_BSK.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_BSK_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

    }
}
