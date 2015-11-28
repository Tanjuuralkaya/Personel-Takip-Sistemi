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
    public partial class Personel_Silme_Sayfasi : Form
    {

        List<Int32> per_id;
        public Personel_Silme_Sayfasi()
        {
            InitializeComponent();
            veriCek();
            
        }
        private void veriCek()
        {
            try
            {
                per_id = new List<int>();
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
            }
            catch (Exception e)
            {
                MessageBox.Show("hata: " + e);
                comboBox1.Text = "";
                comboBox1.Items.Clear();
            }
        }
        private int al()
        {
            varliklar.personel_bilgi sonuc = new varliklar.personel_bilgi();
            int secilen = per_id[comboBox1.SelectedIndex];
            sonuc._id = secilen;
            return sonuc._id;
        }

        private void sil()
        {
            try
            {
                varliklar.personel_bilgi nesne = new varliklar.personel_bilgi();
                nesne._id = al();
                veriErisim.Personel_Silme.sil(nesne._id);
                MessageBox.Show("Başarıyla silindi.");
                veriCek();
                comboBox1.Focus();
            }
            catch (Exception t)
            {
                MessageBox.Show("hata :  " + t.Message);

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }  
        private void button1_Click_1(object sender, EventArgs e)
        { 
            sil();
        }

        private void Personel_Silme_Sayfasi_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
