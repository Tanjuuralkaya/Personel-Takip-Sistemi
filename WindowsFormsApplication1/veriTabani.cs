using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace WindowsFormsApplication1
{
   public  class veriTabani
    {
       public static SqlConnection baglanti;

       public static void baglantiTanimla(string bc)
       {
           baglanti = new SqlConnection(bc);
           baglanti.Open();

       }

       public static void baglantiKoptuysaAc()
       {
           if (baglanti.State == ConnectionState.Closed)
               baglanti.Open();  
       }


    }
}
