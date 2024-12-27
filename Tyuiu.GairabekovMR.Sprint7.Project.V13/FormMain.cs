using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GairabekovMR.Sprint7.Project.V13.Lib;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace Tyuiu.GairabekovMR.Sprint7.Project.V13
{
    public partial class FormMain_GMR : Form
    {
        WMPLib.WindowsMediaPlayer music = new WMPLib.WindowsMediaPlayer();
        bool isPlaying = false;
        bool button = false;
        public FormMain_GMR()
        {
            InitializeComponent();
            music.URL = @"C:\Users\wackko\source\repos\Tyuiu.GairabekovMR.Sprint7\Music and massive\ListSongs.mp3";
            music.settings.volume = 10;
            music.controls.play();

            openFileDialogTask_GMR.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_GMR.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static int rows;
        static string path;
        static int columns;
        DataService ds = new DataService();
        public static string[,] LoadFromFileData(string path)
        {
            string filedata = File.ReadAllText(path);
            filedata = filedata.Replace('\n', '\r');
            string[] lines = filedata.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            string[,] array = new string[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_str = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = line_str[j];
                }
            }
            return array;
        }
        
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormHelp_GMR help = new FormHelp_GMR();
            help.ShowDialog();
        }

        private void buttonNotes_Click(object sender, EventArgs e)
        {
            try
            {
                buttonAdd_GMR.Visible = false;
                buttonDelete_GMR.Visible = false;
                textBoxCapital_GMR.Visible = false;
                textBoxCountry_GMR.Visible = false;
                textBoxDel_GMR.Visible = false;
                textBoxEcoClass_GMR.Visible = false;
                textBoxS_GMR.Visible = false;
                buttonDone_GMR.Visible = false;
                buttonChange_GMR.Visible = false;
                buttonSearch_GMR.Visible = false;
                buttonSort_GMR.Visible = false;
                textBoxSort_GMR.Visible = false;
                labelCapital_GMR.Visible = false;
                labelColumn_GMR.Visible = false;
                labelCountry_GMR.Visible = false;
                labelEcoClass_GMR.Visible = false;
                labelS_GMR.Visible = false;
                labelRow_GMR.Visible = false;
                labelSearch_GMR.Visible = false;
                textBoxSearch_GMR.Visible = false;
                dataGridViewFile_GMR.Visible = false;
                buttonLoadFile_GMR.Enabled = false;
                buttonSaveFile_GMR.Enabled = false;
                panelChoose_GMR.Visible = true;
                textBoxNotice_GMR.Visible = true;
                labelText_GMR.Visible = true;
            }
            catch
            {
                MessageBox.Show("Ошибка при открытии раздела", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            FormAbout_GMR form = new FormAbout_GMR();
            form.ShowDialog();
        }
        private void buttonLoadFile_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogTask_GMR.ShowDialog();
                path = openFileDialogTask_GMR.FileName;

                string[,] array = new string[rows, columns];

                array = LoadFromFileData(path);

                dataGridViewFile_GMR.ColumnCount = columns;
                dataGridViewFile_GMR.RowCount = rows;

                for (int i = 0; i < columns; i++)
                {
                    dataGridViewFile_GMR.Columns[i].Width = 65;
                }
                dataGridViewFile_GMR.Columns[2].Width = 100;
                dataGridViewFile_GMR.Columns[3].Width = 95;
                dataGridViewFile_GMR.Columns[0].HeaderText = "Страна";
                dataGridViewFile_GMR.Columns[1].HeaderText = "Столица";
                dataGridViewFile_GMR.Columns[2].HeaderText = "Экон.Положение";
                dataGridViewFile_GMR.Columns[3].HeaderText = "Площадь терр.";

                buttonDone_GMR.Enabled = true;
                buttonSaveFile_GMR.Enabled = true;
                buttonChange_GMR.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Ошибка при открытии файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            addRow(textBoxCountry_GMR.Text, textBoxCapital_GMR.Text, textBoxEcoClass_GMR.Text, textBoxS_GMR.Text);
            try
            {
                int c = Convert.ToInt32(textBoxS_GMR.Text);
                addRow(textBoxCountry_GMR.Text, textBoxCapital_GMR.Text, textBoxEcoClass_GMR.Text, textBoxS_GMR.Text);
            }
            catch
            {
                MessageBox.Show("Введите корректные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addRow(string textBoxCountry, string textBoxCapital, string textBoxEcoClass, string textBoxS)
        {
            try
            {
                String[] row = { textBoxCountry, textBoxCapital, textBoxEcoClass, textBoxS };
                dataGridViewFile_GMR.Rows.Add(row);
            }
            catch
            {
                MessageBox.Show("Введены не все данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialogMatrix_GMR.FileName = "OutPutFileT.csv";
                saveFileDialogMatrix_GMR.InitialDirectory = Directory.GetCurrentDirectory();
                saveFileDialogMatrix_GMR.ShowDialog();

                string path = saveFileDialogMatrix_GMR.FileName;
                FileInfo fileinfo = new FileInfo(path);
                bool fileex = fileinfo.Exists;

                if (fileex)
                    File.Delete(path);
                int rows = dataGridViewFile_GMR.RowCount;
                int columns = dataGridViewFile_GMR.ColumnCount;

                string str = "";
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (j != columns - 1)
                            str += dataGridViewFile_GMR.Rows[i].Cells[j].Value + ";";
                        else
                            str += dataGridViewFile_GMR.Rows[i].Cells[j].Value;
                    }
                    File.AppendAllText(path, str + Environment.NewLine);
                    str = "";
                }
            }
            catch
            {
                MessageBox.Show("Ошибка сохранения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(textBoxSort_GMR.Text);
                int[] array = new int[rows];
                if ((n == 2) || (n == 3))
                {
                    MessageBox.Show("Данный столбец несортируем", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dataGridViewFile_GMR.Sort(dataGridViewFile_GMR.Columns[2], ListSortDirection.Descending);
            }
            catch
            {
                MessageBox.Show("Ошибка сортировки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (button)
            {
                buttonAdd_GMR.Visible = false;
                buttonDelete_GMR.Visible = false;
                textBoxCapital_GMR.Visible = false;
                textBoxCountry_GMR.Visible = false;
                textBoxDel_GMR.Visible = false;
                textBoxEcoClass_GMR.Visible = false;
                textBoxS_GMR.Visible = false;
                buttonDone_GMR.Enabled = true;
            }
            else
            {
                buttonAdd_GMR.Visible = true;
                buttonDelete_GMR.Visible = true;
                textBoxCapital_GMR.Visible = true;
                textBoxCountry_GMR.Visible = true;
                textBoxDel_GMR.Visible = true;
                textBoxEcoClass_GMR.Visible = true;
                textBoxS_GMR.Visible = true;
                buttonDone_GMR.Enabled = false;
            }
            button = !button;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            dataGridViewFile_GMR.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                string searchValue = textBoxSearch_GMR.Text;
                int num_col = Convert.ToInt32(textBoxSort_GMR.Text);
                foreach (DataGridViewRow row in dataGridViewFile_GMR.Rows)
                {
                    if (row.Cells[num_col].Value.ToString().Equals(searchValue))
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка поиска. Возможно вы не ввели номер столбца", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                string[,] array = new string[rows, columns];

                array = LoadFromFileData(path);

                dataGridViewFile_GMR.ColumnCount = columns;
                dataGridViewFile_GMR.RowCount = rows;

                for (int i = 0; i < columns; i++)
                {
                    dataGridViewFile_GMR.Columns[i].Width = 65;
                }
                dataGridViewFile_GMR.Columns[2].Width = 100;
                dataGridViewFile_GMR.Columns[3].Width = 95;
                dataGridViewFile_GMR.Columns[0].HeaderText = "Страна";
                dataGridViewFile_GMR.Columns[1].HeaderText = "Столица";
                dataGridViewFile_GMR.Columns[2].HeaderText = "Экон.Положение";
                dataGridViewFile_GMR.Columns[3].HeaderText = "Площадь терр.";
                for (int i = 0; i < dataGridViewFile_GMR.RowCount; i++)
                {
                    dataGridViewFile_GMR.Rows[i].HeaderCell.Value = i.ToString();
                }
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewFile_GMR.Rows[i].Cells[j].Value = array[i, j];
                    }
                }
                buttonSearch_GMR.Enabled = true;
                buttonSort_GMR.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Неполадки в обработке файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int row_index = Convert.ToInt32(textBoxDel_GMR.Text);
                dataGridViewFile_GMR.Rows.RemoveAt(row_index);
                dataGridViewFile_GMR.Refresh();
            }
            catch
            {
                MessageBox.Show("Вы пытаетесь удалить весь список или несуществующую строку. Не надо так делать.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMusic_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                music.controls.stop();
                buttonMusic_GMR.BackColor = Color.LimeGreen;
            }
            else
            {
                music.controls.play();
                buttonMusic_GMR.BackColor = Color.FromArgb(192, 255, 192);
            }

            isPlaying = !isPlaying;
        }

        private void comboBoxChoose_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxChoose_GMR.SelectedIndex == 0)
            {
                textBoxNotice_GMR.Text = "Россия - крупнейшее в мире государство, занимающее 1/8 часть суши и расположенное на северо-востоке Евразии. Россия — страна с многовековой историей, богатым культурным наследием и щедрой природой. В России можно найти почти всё то, что встречает путешественник по отдельности в той или иной стране — солнечные пляжи субтропиков и снежные горные вершины, бескрайние степи и глухие леса, бурные реки и тёплые моря.";
            }
            else if (comboBoxChoose_GMR.SelectedIndex == 1)
            {
                textBoxNotice_GMR.Text = "США - одно из крупнейших и влиятельнейших государств современного мира. Оно находится в Северной Америке и является четвертым по территории после России, Канады и Китая. Соединенные Штаты Америки – это многоликая и разнообразная страна, которая внесла весомый вклад в мировую культуру и науку. Она способна предложить путешественникам почти все, чем богат современный мир или природа: от чудес Гранд каньона, Великих озер, гор и тихоокеанского побережья до мегаполисов Нью-Йорка, Лас-Вегаса и Майами.";
            }
            else if (comboBoxChoose_GMR.SelectedIndex == 2)
            {
                textBoxNotice_GMR.Text = "Индия не место для труса. Представляя собой постоянный вызов для ума и тела, она основательно потрясает весь ваш организм. Она волнует, истощает и приводит в ярость. Вы скоро обнаружите, что это земля, где реалии повседневной жизни преобладают над тайнами популярного мифа. Вместо широко известного и часто неправильно понимаемого мистицизма древних религий Индия в действительности может предложить совсем другое чудо: богатство ее народов и ландшафтов";
            }
            else if (comboBoxChoose_GMR.SelectedIndex == 3)
            {
                textBoxNotice_GMR.Text = "Пакистан лежит в северо-западной части Южной Азии и граничит с Афганистаном, Индией, Ираном и Китаем, а также имеет прямой выход к побережью Аравийского моря. \n С туристической точки зрения Пакистан представляет собой неизведанную древнюю землю, где на протяжении многих тысячелетий постоянно сменялись цивилизации, культура и религия.Причем каждый район страны интересен по своему и имеет свои отличительные черты и уникальные достопримечательности, от национальных парков до древних руин.";
            }
            else if (comboBoxChoose_GMR.SelectedIndex == 4)
            {
                textBoxNotice_GMR.Text = "Нигер — крупнейшее государство Западной Африки (площадь 1 267 000 км²), в далеком прошлом — один из крупнейших очагов африканской культуры, входивший в состав древних государств Африки с VII по XVIII века. С начала XX века — владение Франции, с 1960 года — независимое государство. Официальный язык — французский. Большая часть страны расположена в крупнейшей пустыне мира Сахаре и представляет собой выровненное плато высотой 200-500 м над уровнем моря с возвышающимся в центральной части останцовым плато Аир (от 700–800 м в западной части до 1900 м в центре). На востоке плато круто обрывается к огромной песчаной пустыне Тенере (занимающей почти треть территории страны).";
            }
            else
            {
                MessageBox.Show("Примечания к такой стране нет.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonStats_Click(object sender, EventArgs e)
        {
            try
            {
                buttonAdd_GMR.Visible = false;
                buttonDelete_GMR.Visible = false;
                textBoxCapital_GMR.Visible = false;
                textBoxCountry_GMR.Visible = false;
                textBoxDel_GMR.Visible = false;
                textBoxEcoClass_GMR.Visible = false;
                textBoxS_GMR.Visible = false;
                buttonDone_GMR.Visible = true;
                buttonChange_GMR.Visible = true;
                buttonSearch_GMR.Visible = true;
                buttonSort_GMR.Visible = true;
                textBoxSort_GMR.Visible = true;
                labelCapital_GMR.Visible = true;
                labelColumn_GMR.Visible = true;
                labelCountry_GMR.Visible = true;
                labelEcoClass_GMR.Visible = true;
                labelS_GMR.Visible = true;
                labelRow_GMR.Visible = true;
                labelSearch_GMR.Visible = true;
                textBoxSearch_GMR.Visible = true;
                dataGridViewFile_GMR.Visible = true;
                buttonLoadFile_GMR.Enabled = true;
                buttonSaveFile_GMR.Enabled = false;
                panelChoose_GMR.Visible = false;
                textBoxNotice_GMR.Visible = false;
                labelText_GMR.Visible = false;
            }
            catch
            {
                MessageBox.Show("Ошибка при открытии раздела", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormMain_GMR_Load(object sender, EventArgs e)
        {

        }
    }
}
