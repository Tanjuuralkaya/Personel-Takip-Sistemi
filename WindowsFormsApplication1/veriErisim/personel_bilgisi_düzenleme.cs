using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Windows.Forms;

namespace WindowsFormsApplication1.veriErisim
{
    class personel_bilgisi_düzenleme
    {
        public static void düzenle(varliklar.personel_bilgi düzenlenecek)
        {
            veriTabani.baglantiKoptuysaAc();
            SqlCommand com = new SqlCommand("sp_personel_bilgi_duzenle", veriTabani.baglanti);
            com.CommandType = CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("@personel_id", SqlDbType.Int);
            SqlParameter p2 = new SqlParameter("@y_personel_turu_id", SqlDbType.Int);
            SqlParameter p3 = new SqlParameter("@ad", SqlDbType.VarChar, 30);
            SqlParameter p4 = new SqlParameter("@soyad", SqlDbType.VarChar, 20);
            SqlParameter p5 = new SqlParameter("@kullanici_sifresi", SqlDbType.VarChar, 20);
            SqlParameter p6 = new SqlParameter("@tc_kimlik_no", SqlDbType.BigInt);
            SqlParameter p7 = new SqlParameter("@cinsiyet", SqlDbType.VarChar, 5);
            SqlParameter p8 = new SqlParameter("@email", SqlDbType.VarChar, 45);
            SqlParameter p9 = new SqlParameter("@telefon", SqlDbType.Int);
            SqlParameter p10 = new SqlParameter("@gsm", SqlDbType.Int);
            SqlParameter p11 = new SqlParameter("@resim", SqlDbType.VarChar, 50);

            p1.Value = düzenlenecek._id;
            p2.Value = düzenlenecek._y_per_id;
            p3.Value = düzenlenecek._ad;
            p4.Value = düzenlenecek._soyad;
            p5.Value = düzenlenecek._kullanici_sifresi;
            p6.Value = düzenlenecek._tc_kimlik_no;
            p7.Value = düzenlenecek._cinsiyet;
            p8.Value = düzenlenecek._email;
            p9.Value = düzenlenecek._telefon;
            p10.Value = düzenlenecek._gsm;
            p11.Value = düzenlenecek._resim;

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
            com.Parameters.Add(p11);

            com.ExecuteNonQuery();
        }
    }
}
