using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sorusayi = 0, dogsayi = 0, yansayi = 0 ;

        private void btnB_Click(object sender, EventArgs e)
        {
            label2.Text = btnB.Text;
            if (label2.Text == label1.Text)
            {
                dogsayi++;
                lbldogsayi.Text = dogsayi.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yansayi++;
                lblyansayi.Text = yansayi.ToString();
                pictureBox2.Visible = true;
            }
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnsira.Enabled = true;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            label2.Text = btnC.Text;
            if (label2.Text == label1.Text)
            {
                dogsayi++;
                lbldogsayi.Text = dogsayi.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yansayi++;
                lblyansayi.Text = yansayi.ToString();
                pictureBox2.Visible = true;
            }
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnsira.Enabled = true;

        }

        private void btnD_Click(object sender, EventArgs e)
        {
            label2.Text = btnD.Text;
            if (label2.Text == label1.Text)
            {
                dogsayi++;
                lbldogsayi.Text = dogsayi.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yansayi++;
                lblyansayi.Text = yansayi.ToString();
                pictureBox2.Visible = true;
            }
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnsira.Enabled = true;
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            label2.Text = btnA.Text;
            if (label2.Text == label1.Text)
            {
                dogsayi++;
                lbldogsayi.Text = dogsayi.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yansayi++;
                lblyansayi.Text = yansayi.ToString();
                pictureBox2.Visible = true;
            }
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnsira.Enabled = true;

        }

        private void btnsira_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnsira.Enabled = false;

            sorusayi++;
            lblsorusayi.Text = sorusayi.ToString();

            if (sorusayi==1)
            {
                richTextBox1.Text = "Fatih Sultan Mehmet Kaçıncı Padişahtır ?";
                btnA.Text = "4";
                btnB.Text = "7";
                btnC.Text = "9";
                btnD.Text = "13";
                label1.Text = "7";
            }
            if (sorusayi==2)
            {
                richTextBox1.Text = "Kanuni Sultan Süleyman Hangi Padişahın Oğludur ?";
                btnA.Text = "Fatih Sultan Mehmet";
                btnB.Text = "Yıldırım Beyazıt";
                btnC.Text = "Yavuz Sultan Selim";
                btnD.Text = "Mehmet Çelebi";
                label1.Text = "Yavuz Sultan Selim";
            }
            if (sorusayi==3)
            {
                richTextBox1.Text = "Preveze Deniz Savaşı Hangi Yılda Yapıldı ?";
                btnA.Text = "1538";
                btnB.Text = "1457";
                btnC.Text = "1666";
                btnD.Text = "1350";
                label1.Text = "1538";
                btnsira.Text = "SONUCLAR";
            }
            if (sorusayi==4)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnsira.Enabled = false;

                MessageBox.Show("Doğru : " + dogsayi + "\n" + " Yanlış : " + yansayi + "\n" + " Tebrikler!!!" );
            }

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
        }
    }
}
