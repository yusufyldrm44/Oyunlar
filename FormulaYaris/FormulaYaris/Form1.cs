using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
2.OYUNCULU ARABA YARIŞ OYUNU 
1.OYUNCU(SOLDAKİ ARABA) YUKARI OK TUŞUYLA
2.OYUNCU(SAĞDAKİ ARABA) AŞAĞI OK TUŞUYLA HAREKET ETTİRİYOR
KAZANAN MESSAGEBOX İLE UYARILIYOR
*/



namespace FormulaYaris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            int x1 = pictureBox1.Location.X;
            int y1 = pictureBox1.Location.Y;

            int x2 = pictureBox2.Location.X;
            int y2 = pictureBox2.Location.Y;

            if(e.KeyCode == Keys.Up) y1 -= 5;
            if (e.KeyCode == Keys.Down) y2 -= 5;

            pictureBox1.Location = new Point(x1, y1);
            pictureBox2.Location = new Point(x2, y2);

            if(y1<50)
            {
                MessageBox.Show("Tebrikler Beetle Kazandı");
                pictureBox1.Location = new Point(50, 420);
                pictureBox2.Location = new Point(250, 420);
            }
            if (y2 < 50)
            {
                MessageBox.Show("Tebrikler Ferrari Kazandı");
                pictureBox1.Location = new Point(50, 420);
                pictureBox2.Location = new Point(250, 420);
            }

        }
    }
}
