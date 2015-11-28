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
    public partial class Personel_Bilgisi_Düzenleme_Sayfasi : Form
    {
       
        List<Int32> turIdler, per_id;
        private void vericek()
        {
            try
            {
                per_id = new List<int>();
                turIdler = new List<int>();
                veriTabani.baglantiKoptuysaAc();

                SqlCommand sorgu = new SqlCommand("select * from personel", veriTabani.baglanti);
                SqlDataAdapter da = new SqlDataAdapter(sorgu);
                DataSet ds = new DataSet();
                da.Fill(ds, "personel");
                DataTable dt = ds.Tables[0];

                comboBox1.Text = "";
                comboBox1.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    comboBox1.Items.Add(dt.Rows[i][2].ToString() + " " + dt.Rows[i][3].ToString());
                    per_id.Add(Convert.ToInt32(dt.Rows[i][0]));
                }

                SqlCommand sorgu1 = new SqlCommand("select * from personel_turu", veriTabani.baglanti);
                SqlDataAdapter da1 = new SqlDataAdapter(sorgu1);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1, "personel_turu");

                DataTable dt1 = ds1.Tables[0];

                comboBox2.Text = "";
                comboBox2.Items.Clear();
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    comboBox2.Items.Add(dt1.Rows[i][1]);
                    turIdler.Add(Convert.ToInt32(dt1.Rows[i][0]));
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("hata: " + e);
                comboBox1.Text = "";
                comboBox1.Items.Clear();
                comboBox2.Text = "";
                comboBox2.Items.Clear();
            }
        }


        public Personel_Bilgisi_Düzenleme_Sayfasi()
        {
            InitializeComponent();
            vericek();

        }
    
        private varliklar.personel_bilgi al()
        {
            varliklar.personel_bilgi sonuc = new varliklar.personel_bilgi();
            int secilen = per_id[comboBox1.SelectedIndex];
            sonuc._id = secilen;
            int secilen1 = turIdler[comboBox2.SelectedIndex];
            sonuc._y_per_id = secilen1;
            sonuc._ad = textBox1.Text;
            sonuc._soyad = textBox2.Text;
            sonuc._kullanici_sifresi = textBox3.Text;
            sonuc._tc_kimlik_no = Int32.Parse(textBox4.Text);
            sonuc._cinsiyet = textBox5.Text;
            sonuc._email = textBox6.Text;
            sonuc._telefon = Int32.Parse(textBox7.Text);
            sonuc._gsm = Int32.Parse(textBox8.Text);
            sonuc._resim = textBox9.Text;
            return sonuc;

        }

        private void kaydet()
        {
            try
            {
                varliklar.personel_bilgi nesne = new varliklar.personel_bilgi();
                nesne = al();
                veriErisim.personel_bilgisi_düzenleme.düzenle(nesne);
                MessageBox.Show("Başarıyla düzenlendi.");
                comboBox1.Refresh();
                comboBox1.Focus();
            }
            catch (Exception t)
            {
                MessageBox.Show(t.ToString());
                MessageBox.Show("hata :  " + t.Message);

            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Personel_Bilgisi_Düzenleme_Sayfasi_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kaydet();
            vericek();
        }
    }
}
