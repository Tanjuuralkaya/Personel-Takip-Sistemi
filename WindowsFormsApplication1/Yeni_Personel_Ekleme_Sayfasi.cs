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
    public partial class Yeni_Personel_Ekleme_Sayfasi : Form
    {
        List<Int32> turIdler;
        private void vericek()
        {
            try
            {
                turIdler = new List<int>();
                veriTabani.baglantiKoptuysaAc();
                SqlCommand sorgu = new SqlCommand("select * from personel_turu", veriTabani.baglanti);
                SqlDataAdapter da = new SqlDataAdapter(sorgu);
                DataSet ds = new DataSet();
                da.Fill(ds, "personel_turu");

                DataTable dt = ds.Tables[0];

                comboBox1.Text = "";
                comboBox1.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    comboBox1.Items.Add(dt.Rows[i][1]);
                    turIdler.Add(Convert.ToInt32(dt.Rows[i][0]));
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("hata: " + e);
                comboBox1.Text = "";
                comboBox1.Items.Clear();
            }
        }
        public Yeni_Personel_Ekleme_Sayfasi()
        {
            InitializeComponent();
            vericek();
            
        }

        private  varliklar.personel_bilgi  al()
        {
            varliklar.personel_bilgi sonuc = new varliklar.personel_bilgi();
             
            int secilen = turIdler[comboBox1.SelectedIndex];
            sonuc._y_per_id = secilen;
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
                varliklar.personel_bilgi nesne =new varliklar.personel_bilgi();
                nesne =al();
                veriErisim.personel_ekle.ekle(nesne);
                MessageBox.Show("basarıyla eklendı");
                textBox1.Text= "";
                textBox1.Focus();
            }  
            catch (Exception t)
		{
            MessageBox.Show(t.ToString());
		    MessageBox.Show("hata :  " + t.Message);
		
	    }
        }
        private void Yeni_Personel_Ekleme_Sayfasi_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            kaydet();
            vericek();
        }
    }
}
