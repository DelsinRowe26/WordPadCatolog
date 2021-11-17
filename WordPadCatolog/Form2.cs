using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;

namespace WordPadCatolog
{
    public partial class Form2 : Form
    {
        Point moveStart;
        public Form2()
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.Green;
            Button button1 = new Button
            {
                Location = new Point
                {
                    X = this.Width / 3,
                    Y = this.Height / 3
                }
            };
            this.Load += Form2_Load;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async void Form2_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            // создаем эллипс с высотой и шириной формы
            myPath.AddEllipse(0, 0, this.Width, this.Height);
            // создаем с помощью элипса ту область формы, которую мы хотим видеть
            Region myRegion = new Region(myPath);
            // устанавливаем видимую область
            this.Region = myRegion;
        }
        private void Form2_Paint(object sender, PaintEventArgs e) 
        { 
        }
    }
}
