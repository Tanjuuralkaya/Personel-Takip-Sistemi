using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication1.veriErisim
{
    class personel_ekle
    {
        public static void ekle(varliklar.personel_bilgi eklenecek) 
        {
            veriTabani.baglantiKoptuysaAc();
            SqlCommand com = new SqlCommand("sp_personel_ekle", veriTabani.baglanti);
            com.CommandType = CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("@y_personel_turu_id", SqlDbType.Int);
            SqlParameter p2 = new SqlParameter("@ad", SqlDbType.VarChar,30);
            SqlParameter p3 = new SqlParameter("@soyad", SqlDbType.VarChar, 20);
            SqlParameter p4 = new SqlParameter("@kullanici_sifresi", SqlDbType.VarChar, 20);
            SqlParameter p5 = new SqlParameter("@tc_kimlik_no", SqlDbType.BigInt);
            SqlParameter p6 = new SqlParameter("@cinsiyet", SqlDbType.VarChar,5);
            SqlParameter p7 = new SqlParameter("@email", SqlDbType.VarChar,45);
            SqlParameter p8 = new SqlParameter("@telefon", SqlDbType.Int);
            SqlParameter p9 = new SqlParameter("@gsm", SqlDbType.Int);
            SqlParameter p10 = new SqlParameter("@resim", SqlDbType.VarChar,50);

            p1.Value = eklenecek._y_per_id;
            p2.Value = eklenecek._ad;
            p3.Value = eklenecek._soyad;
            p4.Value = eklenecek._kullanici_sifresi;
            p5.Value = eklenecek._tc_kimlik_no;
            p6.Value = eklenecek._cinsiyet;
            p7.Value = eklenecek._email;
            p8.Value = eklenecek._telefon;
            p9.Value = eklenecek._gsm;
            p10.Value = eklenecek._resim;

            com.Parameters.Add(p1);
            com.Parameters.Add(p2);
            com.Parameters.Add(p3);
            com.Parameters.Add(p4);
            com.Parameters.Add(p5);
            com.Parameters.Add(p6);
            com.Parameters.Add(p7);
            com.Parameters.Add(p8);
            com.Parameters.Add(p9);
            com.Parameters.Add(p10);

            com.ExecuteNonQuery();


        }
    }
}
