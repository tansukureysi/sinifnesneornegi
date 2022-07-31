using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sınıf_nesne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sınıfı kullanacağımızı programa bildirmek için bir alan tanımladık

            Otomobil oto = new Otomobil();
            //sınıf içerisinde oluşturduğumuz nesnelere ilgili alanları attık
            oto.marka = "Hyundai";
            oto.model = "Getz";
            oto.modelyılı = 2013;
            oto.renk = "Beyaz";
            oto.vitestipi = "Manuel";

            //otomobilde tanımlananların hepsinin burada çalışması için alanı tanımlıyoruz
            string marka = oto.markagetir();

            //ilgili labellara özellikleri yazdırma işlemini yapıyoruz
            label6.Text = oto.marka.ToString();
            label7.Text = oto.model.ToString();
            label8.Text = oto.modelyılı.ToString();
            label9.Text = oto.renk.ToString();
            label10.Text = oto.vitestipi.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();

        }
    }
}
