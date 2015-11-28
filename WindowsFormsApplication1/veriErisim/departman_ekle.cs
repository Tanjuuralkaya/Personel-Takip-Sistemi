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
    class departman_ekle
    {
        public static void ekle(varliklar.departman eklenecek)
        {
            veriTabani.baglantiKoptuysaAc();
            SqlCommand com = new SqlCommand("sp_departman_ekle", veriTabani.baglanti);
            com.CommandType = CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("@departman_ismi", SqlDbType.VarChar, 25);
            p1.Value = eklenecek._departman_ismi;
            com.Parameters.Add(p1);
            com.ExecuteNonQuery();
        }
    }
}
