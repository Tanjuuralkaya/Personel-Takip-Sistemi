using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace WindowsFormsApplication1.veriErisim
{
    class personel_turu_ekle
    {

        public static void ekle(varliklar.personel_turu eklenecek)
        {
            veriTabani.baglantiKoptuysaAc();
            SqlCommand com = new SqlCommand("sp_personel_turu_ekle", veriTabani.baglanti);
            com.CommandType = CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("@tur_ismi", SqlDbType.VarChar, 25);
            p1.Value = eklenecek._tur_adi;
            com.Parameters.Add(p1);
            com.ExecuteNonQuery();
        }
    }
}
