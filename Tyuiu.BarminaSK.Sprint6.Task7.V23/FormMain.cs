using Tyuiu.BarminaSK.Sprint6.Task7.V23.Lib;

namespace Tyuiu.BarminaSK.Sprint6.Task7.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_BSK.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_BSK.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }

            return arrayValues;
        }

        private void buttonOpen_BSK_Click(object sender, EventArgs e)
        {
            openFileDialogTask_BSK.ShowDialog();
            openFilePath = openFileDialogTask_BSK.FileName;

            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewIn_BSK.ColumnCount = columns;
            dataGridViewIn_BSK.RowCount = rows;
            dataGridViewOut_BSK.ColumnCount = columns;
            dataGridViewOut_BSK.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn_BSK.Columns[i].Width = 35;
                dataGridViewOut_BSK.Columns[i].Width = 35;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewIn_BSK.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_BSK.Enabled = true;
        }

        private void buttonDone_BSK_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOut_BSK.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSave_BSK.Enabled = true;
        }

        private void buttonSave_BSK_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_BSK.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_BSK.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_BSK.ShowDialog();

            string path = saveFileDialogMatrix_BSK.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut_BSK.RowCount;
            int columns = dataGridViewOut_BSK.ColumnCount;

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOut_BSK.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_BSK.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonHelp_BSK_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
