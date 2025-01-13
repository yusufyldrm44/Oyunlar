using Adam_Asmacaa.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adam_Asmacaa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Değişken oluşturma
        int hataSayac = 0;
        int puan = 0;

        // Şehirler ve rastgele şehir seçimi
        string[] kelimeler = { "Şehirler" };
        Random rnd = new Random();
        List<string> secilenKelimeler = new List<string>();
        string kelime = "";
        

        private void Form1_Load(object sender, EventArgs e)
        {
            oyunOlustur();

        }

        // Program başlangıcında oyun oluşturma
        private void oyunOlustur()
        {
            label3.Text = kelimeler[rnd.Next(kelimeler.Length)];
            FileStream fs = new FileStream("Kelimeler/" + label3.Text + ".txt", FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            string yazi = sw.ReadLine();

            while (yazi != null)
            {
                secilenKelimeler.Add(yazi.ToUpper());
                yazi = sw.ReadLine();
            }
            sw.Close();
            fs.Close();
            kelime = secilenKelimeler[rnd.Next(secilenKelimeler.Count)];
            for (int i = 0; i < kelime.Length; i++)
                lbltahmin.Text += "_ ";
        }


       



        private void Oyun(object sender, EventArgs e)
        {
            Button seciliBtn = sender as Button;
            seciliBtn.Enabled = false;
            if (kelime.Contains(seciliBtn.Text) == false)
            {
                hataSayac++;
                // Hata sayısına göre resim değişimi
                if (hataSayac == 1)
                {
                    pictureBox1.Image = Resources._1;
                    label5.Text = (11 - hataSayac).ToString();
                }
                if (hataSayac == 2)
                {
                    pictureBox1.Image = Resources._2;
                    label5.Text = (11 - hataSayac).ToString();
                }
                if (hataSayac == 3)
                {
                    pictureBox1.Image = Resources._3;
                    label5.Text = (11 - hataSayac).ToString();
                }
                if (hataSayac == 4)
                {
                    pictureBox1.Image = Resources._4;
                    label5.Text = (11 - hataSayac).ToString();
                }
                if (hataSayac == 5)
                {
                    pictureBox1.Image = Resources._5;
                    label5.Text = (11 - hataSayac).ToString();
                }
                if (hataSayac == 6)
                {
                    pictureBox1.Image = Resources._6;
                    label5.Text = (11 - hataSayac).ToString();
                }
                if (hataSayac == 7)
                {
                    pictureBox1.Image = Resources._7;
                    label5.Text = (11 - hataSayac).ToString();
                }
                if (hataSayac == 8)
                {
                    pictureBox1.Image = Resources._8;
                    label5.Text = (11 - hataSayac).ToString();
                }
                if (hataSayac == 9)
                {
                    pictureBox1.Image = Resources._9;
                    label5.Text = (11 - hataSayac).ToString();
                }
                if (hataSayac == 10)
                {
                    pictureBox1.Image = Resources._10;
                    label5.Text = (11 - hataSayac).ToString();
                }
                if (hataSayac == 11)
                {
                    pictureBox1.Image = Resources._11;
                    label5.Text = (11 - hataSayac).ToString();
                }



            }
            else
            {
                string text = lbltahmin.Text.Replace(" ", "");
                for (int i = 0; i < kelime.Length; i++)
                    if (kelime[i].ToString() == seciliBtn.Text)
                    {
                        text = ReplaceAt(text, i, 1, seciliBtn.Text);
                        puan += 10;
                    }
                string sonuç = "";
                for (int i = 0; i < text.Length; i++)
                    sonuç += text[i].ToString() + " ";
                lbltahmin.Text = sonuç;
                label7.Text = puan.ToString();
            }

            // Eğer hata sayacı 0 ise oyunu bitir
            if (label5.Text == "0")
            {
                puan -= lbltahmin.Text.Length * 10;
                label7.Text = puan.ToString();
                label7.Text = puan.ToString();
                DialogResult dialogResult = MessageBox.Show("Maalesef Kaybettiniz Kelime: " + kelime + " Tekran Oynamak İstiyor musunuz ?", "Yusuf Yıldırım", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                    oyunBitir();
                else
                    Application.Exit();
            }
            // Eğer kelime bilinirse oyunu bitir
            if (lbltahmin.Text.Replace(" ", "") == kelime)
            {
                puan += lbltahmin.Text.Length * 10;
                DialogResult dialogResult = MessageBox.Show("Tebrikler Kazandınız Kelime: " + kelime + " Tekran Oynamak İstiyor musunuz ?", "Yusuf Yıldırım", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                    oyunBitir();
                else
                    Application.Exit();
            }
        }
        // Oyun bitirme metotu
        private void oyunBitir()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns is Button)
                    ((Button)btns).Enabled = true;
                pictureBox1.Image = null;
                lbltahmin.Text = "";
                label5.Text = "11";
                hataSayac = 0;
                oyunOlustur();

            }
        }
        public string ReplaceAt(string str, int index, int length, string replace)
        {
            return str.Remove(index, Math.Min(length, str.Length - index))
                .Insert(index, replace);
        }














        // Çıkış tuşu
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Mouse kontrolü
        int Move;
        int Mouse_X;
        int Mouse_Y;
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }


        // Harf nesneleri
        private void button2_Click(object sender, EventArgs e)
        {
            Oyun(sender, e);
        }
        
        private void button28_Click(object sender, EventArgs e)
        {
            Oyun(sender, e);
        }
        private void button29_Click(object sender, EventArgs e)
        {
            Oyun(sender, e);
        }
        private void button30_Click(object sender, EventArgs e)
        {
            Oyun(sender, e);
        }
        private void button31_Click(object sender, EventArgs e)
        {
            Oyun(sender, e);
        }
        private void button32_Click(object sender, EventArgs e)
        {
            Oyun(sender, e);
        }
        private void button33_Click(object sender, EventArgs e)
        {
            Oyun(sender, e);
        }
        private void button34_Click(object sender, EventArgs e)
        {
            Oyun(sender, e);
        }
        private void button35_Click(object sender, EventArgs e)
        {
            Oyun(sender, e);
        }
        private void button36_Click(object sender, EventArgs e)
        {
            Oyun(sender, e);
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            Oyun(sender, e);
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            Oyun(sender, e);
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            Oyun(sender, e);
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            Oyun(sender, e);
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            Oyun(sender, e);
        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            Oyun(sender, e);
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            Oyun(sender, e);
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            Oyun(sender, e);
        }

        private void button24_Click_1(object sender, EventArgs e)
        {
            Oyun(sender, e);
        }

        private void button25_Click_1(object sender, EventArgs e)
        {
            Oyun(sender, e);
        }

        private void button26_Click_1(object sender, EventArgs e)
        {
            Oyun(sender, e);
        }

        private void button27_Click_1(object sender, EventArgs e)
        {
            Oyun(sender, e);
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            Oyun(sender, e);
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            Oyun(sender, e);
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            Oyun(sender, e);
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            Oyun(sender, e);
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Oyun(sender, e);
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Oyun(sender, e);
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Oyun(sender, e);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Oyun(sender, e);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Oyun(sender, e);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Oyun(sender, e);
        } 
    }
}
