using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using MyLibrary;

namespace WordPadCatolog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            открыть.Click += открыть_Click;
            сохранить.Click += сохранить_Click;
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            listView1.SmallImageList = imageList1;
        }
        /*private static async Task AppendLineToFile(string path, string line)
        {
            Encoding.GetEncoding("windows-1251");
            if (string.IsNullOrWhiteSpace("note.txt")) //проверяем, что имя файла не пустое
                throw new ArgumentOutOfRangeException(nameof(path), "note.txt", "Was null or whitespace.");

            if (!File.Exists("note.txt"))
                throw new FileNotFoundException("File not found.", nameof(path));

            using (var file = File.Open("note.txt", FileMode.Append, FileAccess.Write))
            using (var writer = new StreamWriter(file))
            {
                await writer.WriteLineAsync(line);
                await writer.FlushAsync();// Асинхронно очищает все буферы
            }
        }*/

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Encoding.GetEncoding("windows-1251");
            // выведем содержимое файла целиком
            Class1.AppendLineToFile("note.txt", DateTime.Now + " создан файл");
            /*using (FileStream fstream = new FileStream($"note.txt", FileMode.Append))
            {
                // преобразуем строку в байты
                byte[] array = System.Text.Encoding.Default.GetBytes(DateTime.Now + " - создан файл\n");
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
            }*/
        }

        private void сохранить_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(filename, textBox1.Text);
            MessageBox.Show("Файл сохранен");
            Encoding.GetEncoding("windows-1251");
            // выведем содержимое файла целиком
            Class1.AppendLineToFile("note.txt", DateTime.Now + " создан файл");
            /*using (FileStream fstream = new FileStream($"note.txt", FileMode.Append))
            {
                // преобразуем строку в байты
                byte[] array = System.Text.Encoding.Default.GetBytes(DateTime.Now + " - Файл сохранен\n");
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
            }*/
        }
        /*static async void создатьToolStripMenuItem_Click(FileStream fstream)
        {
            
        }*/

        private void открыть_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку
            string fileText = System.IO.File.ReadAllText(filename);
            textBox1.Text = fileText;
            MessageBox.Show("Файл открыт");
            using (FileStream fstream = new FileStream($"note.txt", FileMode.Append))
            {
                // преобразуем строку в байты
                byte[] array = System.Text.Encoding.Default.GetBytes(DateTime.Now + " - Файл открыт\n");
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
            }
            toolStripStatusLabel1.Text = " Файл открыт: " + filename;
            pictureBox1.Image = Image.FromFile("1604090_a14a5.gif");
        }

        private void выход_Click(object sender, EventArgs e)
        {
            this.Close();
            using (FileStream fstream = new FileStream($"note.txt", FileMode.Append))
            {
                // преобразуем строку в байты
                byte[] array = System.Text.Encoding.Default.GetBytes(DateTime.Now + " - Выход осуществлен\n");
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
            }
        }

        private void создатьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string path = @"C:\SomeDir";
            string subpath = @"program\avalon";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            dirInfo.CreateSubdirectory(subpath);
            Encoding.GetEncoding("windows-1251");
            // выведем содержимое файла целиком
            Class1.AppendLineToFile("note.txt", DateTime.Now + " создан каталог");
            /*using (FileStream fstream = new FileStream($"note.txt", FileMode.Append))
            {
                // преобразуем строку в байты
                byte[] array = System.Text.Encoding.Default.GetBytes(DateTime.Now + " - создан каталог\n");
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
            }*/
        }

        private void удалить_Click(object sender, EventArgs e)
        {
            string dirName = @"C:\SomeDir";

            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(dirName);
                dirInfo.Delete(true);
                MessageBox.Show("Каталог удален");
                using (FileStream fstream = new FileStream($"note.txt", FileMode.Append))
                {
                    // преобразуем строку в байты
                    byte[] array = System.Text.Encoding.Default.GetBytes(DateTime.Now + " - каталог удален\n");
                    // запись массива байтов в файл
                    fstream.Write(array, 0, array.Length);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 prAbout = new Form2();
            prAbout.Show();
            textBox1.Text = File.ReadAllText("note.txt");
            Encoding.GetEncoding("windows-1251");
            // выведем содержимое файла целиком
            Class1.AppendLineToFile("note.txt", DateTime.Now + " запущена вторая форма");
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("XOsX.gif");
        }

        private void списки_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;
            // получаем все файлы
            string[] files = Directory.GetFiles(path);
            // перебор полученных файлов
            foreach (string file in files)
            {
                ListViewItem lvi = new ListViewItem();
                // установка названия файла
                lvi.Text = file.Remove(0, file.LastIndexOf('\\') + 1);
                lvi.ImageIndex = 0; // установка картинки для файла
                // добавляем элемент в ListView
                listView1.Items.Add(lvi);
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void открытьКартинку_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку
            pictureBox2.Image = Image.FromFile(filename); 
            MessageBox.Show("Файл открыт");
            toolStripStatusLabel1.Text = "Файл открыт: " + filename;
        }
    }
}
