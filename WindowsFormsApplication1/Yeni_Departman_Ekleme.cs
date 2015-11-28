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
    public partial class Yeni_Departman_Ekleme : Form
    {

        private void vericek()
        {
            try
            {
                veriTabani.baglantiKoptuysaAc();
                SqlCommand sorgu = new SqlCommand("select * from departman", veriTabani.baglanti);
                SqlDataAdapter da = new SqlDataAdapter(sorgu);
                DataSet ds = new DataSet();
                da.Fill(ds, "departman");
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
        public Yeni_Departman_Ekleme()
        {
            InitializeComponent();
            vericek();
        }

        private varliklar.departman al()
        {
            varliklar.departman sonuc = new varliklar.departman();
            sonuc._departman_ismi = textBox1.Text;
            sonuc._id = 0;
            return sonuc;
        }

        private void kaydet()
        {
            try
            {
                varliklar.departman yeni = al();
                veriErisim.departman_ekle.ekle(yeni);
                MessageBox.Show("Başarıyla eklendi");
                textBox1.Text = "";
                textBox1.Focus();
                comboBox1.Refresh();
            }catch (Exception A)
                {
                    MessageBox.Show("HATA : " + A.Message);
                }
            
        }
        private void Yeni_Departman_Ekleme_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kaydet();
            vericek();
        }
    }
}
