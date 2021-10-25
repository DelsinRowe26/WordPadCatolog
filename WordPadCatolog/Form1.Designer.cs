
namespace WordPadCatolog
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создать = new System.Windows.Forms.ToolStripMenuItem();
            this.открыть = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранить = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКак = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.выход = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.кнСоздать = new System.Windows.Forms.ToolStripButton();
            this.кнОткрыть = new System.Windows.Forms.ToolStripButton();
            this.кнСохранить = new System.Windows.Forms.ToolStripButton();
            this.кнВыход = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.каталогиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалить = new System.Windows.Forms.ToolStripMenuItem();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 88);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(776, 350);
            this.textBox1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.каталогиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создать,
            this.открыть,
            this.сохранить,
            this.сохранитьКак,
            this.toolStripMenuItem1,
            this.выход});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создать
            // 
            this.создать.Name = "создать";
            this.создать.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.создать.Size = new System.Drawing.Size(225, 22);
            this.создать.Text = "Создать";
            this.создать.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // открыть
            // 
            this.открыть.Name = "открыть";
            this.открыть.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открыть.Size = new System.Drawing.Size(225, 22);
            this.открыть.Text = "Открыть";
            this.открыть.Click += new System.EventHandler(this.открыть_Click);
            // 
            // сохранить
            // 
            this.сохранить.Name = "сохранить";
            this.сохранить.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранить.Size = new System.Drawing.Size(225, 22);
            this.сохранить.Text = "Сохранить";
            this.сохранить.Click += new System.EventHandler(this.сохранить_Click);
            // 
            // сохранитьКак
            // 
            this.сохранитьКак.Name = "сохранитьКак";
            this.сохранитьКак.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.сохранитьКак.Size = new System.Drawing.Size(225, 22);
            this.сохранитьКак.Text = "Сохранить как";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(222, 6);
            // 
            // выход
            // 
            this.выход.Name = "выход";
            this.выход.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.выход.Size = new System.Drawing.Size(225, 22);
            this.выход.Text = "Выход";
            this.выход.Click += new System.EventHandler(this.выход_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.кнСоздать,
            this.кнОткрыть,
            this.кнСохранить,
            this.кнВыход});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // кнСоздать
            // 
            this.кнСоздать.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.кнСоздать.Image = ((System.Drawing.Image)(resources.GetObject("кнСоздать.Image")));
            this.кнСоздать.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.кнСоздать.Name = "кнСоздать";
            this.кнСоздать.Size = new System.Drawing.Size(23, 22);
            this.кнСоздать.Text = "Создать";
            this.кнСоздать.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // кнОткрыть
            // 
            this.кнОткрыть.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.кнОткрыть.Image = ((System.Drawing.Image)(resources.GetObject("кнОткрыть.Image")));
            this.кнОткрыть.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.кнОткрыть.Name = "кнОткрыть";
            this.кнОткрыть.Size = new System.Drawing.Size(23, 22);
            this.кнОткрыть.Text = "Открыть";
            this.кнОткрыть.Click += new System.EventHandler(this.открыть_Click);
            // 
            // кнСохранить
            // 
            this.кнСохранить.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.кнСохранить.Image = ((System.Drawing.Image)(resources.GetObject("кнСохранить.Image")));
            this.кнСохранить.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.кнСохранить.Name = "кнСохранить";
            this.кнСохранить.Size = new System.Drawing.Size(23, 22);
            this.кнСохранить.Text = "Сохранить";
            this.кнСохранить.Click += new System.EventHandler(this.сохранить_Click);
            // 
            // кнВыход
            // 
            this.кнВыход.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.кнВыход.Image = ((System.Drawing.Image)(resources.GetObject("кнВыход.Image")));
            this.кнВыход.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.кнВыход.Name = "кнВыход";
            this.кнВыход.Size = new System.Drawing.Size(23, 22);
            this.кнВыход.Text = "Выход";
            this.кнВыход.Click += new System.EventHandler(this.выход_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // каталогиToolStripMenuItem
            // 
            this.каталогиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.удалить});
            this.каталогиToolStripMenuItem.Name = "каталогиToolStripMenuItem";
            this.каталогиToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.каталогиToolStripMenuItem.Text = "Каталоги";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click_1);
            // 
            // удалить
            // 
            this.удалить.Name = "удалить";
            this.удалить.Size = new System.Drawing.Size(180, 22);
            this.удалить.Text = "Удалить";
            this.удалить.Click += new System.EventHandler(this.удалить_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создать;
        private System.Windows.Forms.ToolStripMenuItem открыть;
        private System.Windows.Forms.ToolStripMenuItem сохранить;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКак;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выход;
        private System.Windows.Forms.ToolStripButton кнСоздать;
        private System.Windows.Forms.ToolStripButton кнОткрыть;
        private System.Windows.Forms.ToolStripButton кнСохранить;
        private System.Windows.Forms.ToolStripButton кнВыход;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem каталогиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалить;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
    }
}

