using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                veriTabani.baglantiTanimla("Data Source=URALKAYA\\SQLSERVERTANJU; Database=PERSONELVT; User Id = sa; Password=12369874");

            }
            catch
            {
                MessageBox.Show("baglanmadı");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Yetki_Turu_Ekleme_Sayfasi sayfa = new Yetki_Turu_Ekleme_Sayfasi();
            sayfa.ShowDialog();
        }
       
  
        private void button2_Click_1(object sender, EventArgs e)
        {
            Yeni_Personel_Ekleme_Sayfasi sayfa = new Yeni_Personel_Ekleme_Sayfasi();
            sayfa.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Yeni_Personel_Türü_Ekleme_Sayfasi sayfa = new Yeni_Personel_Türü_Ekleme_Sayfasi();
            sayfa.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Yeni_Departman_Ekleme sayfa = new Yeni_Departman_Ekleme();
            sayfa.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Personel_Bilgisi_Düzenleme_Sayfasi sayfa = new Personel_Bilgisi_Düzenleme_Sayfasi();
            sayfa.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Personel_Silme_Sayfasi sayfa = new Personel_Silme_Sayfasi();
            sayfa.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            Yetki_Turu_Listesi liste = new Yetki_Turu_Listesi();
            liste.ShowDialog();
            
        }
    }
}
