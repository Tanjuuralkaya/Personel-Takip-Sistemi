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
using System.Data.SqlTypes;
using System.Data.Sql;

namespace WindowsFormsApplication1
{
    public partial class Yetki_Turu_Listesi : Form
    {

        public Yetki_Turu_Listesi()
        {
            InitializeComponent();
        }
        private void veriBagla(string sc, string tabloAdi)
        {
            

            SqlCommand sorgu = new SqlCommand(sc, veriTabani.baglanti);
            SqlDataAdapter da = new SqlDataAdapter(sorgu);
            DataSet ds = new DataSet();
            da.Fill(ds, tabloAdi);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                veriBagla("select * from Yetki_Turu", "Yetki_Turu");
            }
            catch{}
        }

        private void Yetki_Turu_Listesi_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void verisil()
        {
           
            veriTabani.baglantiKoptuysaAc();
            SqlCommand kmt = new SqlCommand();
            kmt.Connection = veriTabani.baglanti;
            kmt.CommandText = "Delete from yetki_turu where yetki_turu_id ='"+dataGridView1.CurrentRow.Cells[0].Value.ToString()+"'";
            kmt.ExecuteNonQuery();
            veriTabani.baglanti.Close();
            Yetki_Turu_Listesi frm = new Yetki_Turu_Listesi();
            frm.ShowDialog();         
        
        }

        private void button2_Click(object sender, EventArgs e)
        {

            verisil();
        }
    }
}
