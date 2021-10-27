
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("Смартфоны", 8);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("Планшеты", 4);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("Компьютеры", 7);
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("Видеокарта", 0);
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("VR очки", 2);
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("Процессор", 3);
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("Материнская плата", 5);
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem("Наушники", 6);
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem("Мышка", 1);
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Узел7");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Узел0", new System.Windows.Forms.TreeNode[] {
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Узел8");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Узел1", new System.Windows.Forms.TreeNode[] {
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Узел9");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Узел2", new System.Windows.Forms.TreeNode[] {
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Узел6");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Узел3", new System.Windows.Forms.TreeNode[] {
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Узел5");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Узел4", new System.Windows.Forms.TreeNode[] {
            treeNode19});
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создать = new System.Windows.Forms.ToolStripMenuItem();
            this.открыть = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранить = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКак = new System.Windows.Forms.ToolStripMenuItem();
            this.списки = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.выход = new System.Windows.Forms.ToolStripMenuItem();
            this.каталогиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалить = new System.Windows.Forms.ToolStripMenuItem();
            this.проектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.кнСоздать = new System.Windows.Forms.ToolStripButton();
            this.кнОткрыть = new System.Windows.Forms.ToolStripButton();
            this.кнСохранить = new System.Windows.Forms.ToolStripButton();
            this.кнВыход = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.открытьКартинку = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.каталогиToolStripMenuItem,
            this.проектToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1205, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создать,
            this.открыть,
            this.открытьКартинку,
            this.сохранить,
            this.сохранитьКак,
            this.списки,
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
            // списки
            // 
            this.списки.Name = "списки";
            this.списки.Size = new System.Drawing.Size(225, 22);
            this.списки.Text = "Списки";
            this.списки.Click += new System.EventHandler(this.списки_Click);
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
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click_1);
            // 
            // удалить
            // 
            this.удалить.Name = "удалить";
            this.удалить.Size = new System.Drawing.Size(118, 22);
            this.удалить.Text = "Удалить";
            this.удалить.Click += new System.EventHandler(this.удалить_Click);
            // 
            // проектToolStripMenuItem
            // 
            this.проектToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.проектToolStripMenuItem.Name = "проектToolStripMenuItem";
            this.проектToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.проектToolStripMenuItem.Text = "Проект";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.кнСоздать,
            this.кнОткрыть,
            this.кнСохранить,
            this.кнВыход});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1205, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // кнСоздать
            // 
            this.кнСоздать.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.кнСоздать.Image = ((System.Drawing.Image)(resources.GetObject("кнСоздать.Image")));
            this.кнСоздать.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.кнСоздать.Name = "кнСоздать";
            this.кнСоздать.Size = new System.Drawing.Size(24, 24);
            this.кнСоздать.Text = "Создать";
            this.кнСоздать.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // кнОткрыть
            // 
            this.кнОткрыть.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.кнОткрыть.Image = ((System.Drawing.Image)(resources.GetObject("кнОткрыть.Image")));
            this.кнОткрыть.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.кнОткрыть.Name = "кнОткрыть";
            this.кнОткрыть.Size = new System.Drawing.Size(24, 24);
            this.кнОткрыть.Text = "Открыть";
            this.кнОткрыть.Click += new System.EventHandler(this.открыть_Click);
            // 
            // кнСохранить
            // 
            this.кнСохранить.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.кнСохранить.Image = ((System.Drawing.Image)(resources.GetObject("кнСохранить.Image")));
            this.кнСохранить.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.кнСохранить.Name = "кнСохранить";
            this.кнСохранить.Size = new System.Drawing.Size(24, 24);
            this.кнСохранить.Text = "Сохранить";
            this.кнСохранить.Click += new System.EventHandler(this.сохранить_Click);
            // 
            // кнВыход
            // 
            this.кнВыход.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.кнВыход.Image = ((System.Drawing.Image)(resources.GetObject("кнВыход.Image")));
            this.кнВыход.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.кнВыход.Name = "кнВыход";
            this.кнВыход.Size = new System.Drawing.Size(24, 24);
            this.кнВыход.Text = "Выход";
            this.кнВыход.Click += new System.EventHandler(this.выход_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 625);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1205, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(43, 17);
            this.toolStripStatusLabel1.Text = "Статус";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(807, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(386, 337);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16,
            listViewItem17,
            listViewItem18});
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(807, 511);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(386, 101);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "02-big.jpg");
            this.imageList1.Images.SetKeyName(1, "010-photo-big.png");
            this.imageList1.Images.SetKeyName(2, "14hq.jpg");
            this.imageList1.Images.SetKeyName(3, "87d5a23419dd6eb7292e0ee4fb80e6bc423b22cadda1c5fe340d8ed2ace16da4.jpg");
            this.imageList1.Images.SetKeyName(4, "1771262.jpg");
            this.imageList1.Images.SetKeyName(5, "Best-gaming-motherboard-Asus-ROG-Strix-Z390-E-Gaming-900x507-660x372.jpg");
            this.imageList1.Images.SetKeyName(6, "fa87ce643cb64962f20e0f28d200f728.jpg");
            this.imageList1.Images.SetKeyName(7, "IMG5925b.jpg");
            this.imageList1.Images.SetKeyName(8, "XmDgLewcs8Y.jpg");
            // 
            // treeView1
            // 
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(12, 431);
            this.treeView1.Name = "treeView1";
            treeNode11.Name = "Узел7";
            treeNode11.Text = "Узел7";
            treeNode12.Name = "Узел0";
            treeNode12.Text = "Узел0";
            treeNode13.Name = "Узел8";
            treeNode13.Text = "Узел8";
            treeNode14.Name = "Узел1";
            treeNode14.Text = "Узел1";
            treeNode15.Name = "Узел9";
            treeNode15.Text = "Узел9";
            treeNode16.Name = "Узел2";
            treeNode16.Text = "Узел2";
            treeNode17.Name = "Узел6";
            treeNode17.Text = "Узел6";
            treeNode18.Name = "Узел3";
            treeNode18.Text = "Узел3";
            treeNode19.Name = "Узел5";
            treeNode19.Text = "Узел5";
            treeNode20.Name = "Узел4";
            treeNode20.Text = "Узел4";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode14,
            treeNode16,
            treeNode18,
            treeNode20});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(776, 181);
            this.treeView1.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 65);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 360);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 334);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "WordPad";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 334);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Редактор картинок";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-4, -3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(776, 337);
            this.textBox1.TabIndex = 2;
            // 
            // открытьКартинку
            // 
            this.открытьКартинку.Name = "открытьКартинку";
            this.открытьКартинку.Size = new System.Drawing.Size(225, 22);
            this.открытьКартинку.Text = "Открыть картинку";
            this.открытьКартинку.Click += new System.EventHandler(this.открытьКартинку_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(765, 334);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 647);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.ToolStripMenuItem проектToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripMenuItem списки;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem открытьКартинку;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

