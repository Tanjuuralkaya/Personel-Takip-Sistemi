using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Yetki_Turu_Ekleme_Sayfasi : Form
    {

        public Yetki_Turu_Ekleme_Sayfasi()
        {
            InitializeComponent();
        }
        private varliklar.yetki_turu al()
        {
            varliklar.yetki_turu sonuc = new varliklar.yetki_turu();
            sonuc._yetki_ismi = textBox1.Text;
            sonuc._id = 0;
            return sonuc;
        }
        private void kaydet()
        {
            try
            {
                varliklar.yetki_turu yeni = al();
                veriErisim.yetki_turu_ekle.ekle(yeni);
                MessageBox.Show("Başarıyla eklendi");
                textBox1.Text = "";
                textBox1.Focus();
            }
            catch (Exception A)
            {
                MessageBox.Show("HATA : " + A.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            kaydet();
        }

        private void Yetki_Turu_Ekleme_Sayfasi_Load(object sender, EventArgs e)
        {

        }

        private void pERSONELVTDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
