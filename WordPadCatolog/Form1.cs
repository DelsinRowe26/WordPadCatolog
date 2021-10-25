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
        }
        private static async Task AppendLineToFile(string path, string line)
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
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Encoding.GetEncoding("windows-1251");
            // выведем содержимое файла целиком
            AppendLineToFile("note.txt", DateTime.Now + " создан файл");
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
            using (FileStream fstream = new FileStream($"note.txt", FileMode.Append))
            {
                // преобразуем строку в байты
                byte[] array = System.Text.Encoding.Default.GetBytes(DateTime.Now + " - Файл сохранен\n");
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
            }
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
            AppendLineToFile("note.txt", DateTime.Now + " создан каталог");
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
       
    }
}
