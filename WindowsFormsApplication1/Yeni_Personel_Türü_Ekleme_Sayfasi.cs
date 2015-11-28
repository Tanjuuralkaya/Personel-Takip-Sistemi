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
    public partial class Yeni_Personel_Türü_Ekleme_Sayfasi : Form
    {
        private void vericek()
        {
            try
            {
                veriTabani.baglantiKoptuysaAc();
                SqlCommand sorgu = new SqlCommand("select * from personel_turu", veriTabani.baglanti);
                SqlDataAdapter da = new SqlDataAdapter(sorgu);
                DataSet ds = new DataSet();
                da.Fill(ds, "personel_turu");
                DataTable dt = ds.Tables[0];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    comboBox1.Items.Add(dt.Rows[i][1]);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("hata : " + e);
            }
        }
        public Yeni_Personel_Türü_Ekleme_Sayfasi()
        {
            InitializeComponent();
            vericek();
        }

        private varliklar.personel_turu al()
        {
            varliklar.personel_turu sonuc = new varliklar.personel_turu();
            sonuc._tur_adi = textBox1.Text;
            sonuc._id = 0;
            return sonuc;
        }

        private void kaydet()
        {
            try 
                {
                    varliklar.personel_turu yeni = al();
                    veriErisim.personel_turu_ekle.ekle(yeni);
                    MessageBox.Show("Başarıyla eklendi");
                    textBox1.Text = "";
                    textBox1.Focus();
                    comboBox1.Refresh();
                }catch (Exception A)
                {
                    MessageBox.Show("HATA : " + A.Message);
                }
        }
         
    
        private void Personel_Ekleme_Sayfasi_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kaydet();
            vericek();
        }
    }
}
