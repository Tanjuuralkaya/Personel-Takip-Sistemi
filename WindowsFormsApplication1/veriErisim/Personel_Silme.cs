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
    class Personel_Silme
    {
        public static void sil(int silinecek)
        {
            veriTabani.baglantiKoptuysaAc();
            SqlCommand com = new SqlCommand("sp_personel_sil", veriTabani.baglanti);
            com.CommandType = CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("@personel_id", SqlDbType.Int);
            p1.Value = silinecek; 
            com.Parameters.Add(p1);
            com.ExecuteNonQuery();
    
    
    }
    }
}
