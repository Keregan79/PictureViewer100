using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewerKuksheva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();//закрыть форму
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)// если выделено
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;//рисунок растянут
            else// иначе
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;//рисунок в натуральную величину
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)// если цвет выбран пользователем
                pictureBox1.BackColor = colorDialog1.Color;// устанавливается цвет фона указанный пользователем
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;// рисунок очищен
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)// если выбран рисунок пользователем
            {
                pictureBox1.Load(openFileDialog1.FileName);// загружается рисунок выбранный пользователем
            }
        }

        private void растянутьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void нормалToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }
    }
}
