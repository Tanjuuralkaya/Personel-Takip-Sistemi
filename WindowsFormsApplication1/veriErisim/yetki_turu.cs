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
    class yetki_turu
    {
        public static void ekle(varliklar.yetki_turu eklenecek)
        {
            veriTabani.baglantiKoptuysaAc();
            SqlCommand Comm = new SqlCommand("yetkiTuruEkle", veriTabani.baglanti); //Burada SQL'de oluşturduğumuz procedureun adını yazıyoruz
             Comm.CommandType = CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("@yetki_ismi", SqlDbType.VarChar, 45);  // SqlParameter ile paremetremizi yazıp veri türünü belirtiyoruz
            p1.Value = eklenecek._yetki_ismi;
            Comm.Parameters.Add(p1);
            Comm.ExecuteNonQuery();
        }
    }
}
