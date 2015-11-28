using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.varliklar
{
    class personel_turu
    {

        Int32 id;
        String tur_adi;

        public personel_turu()
        {
            this.id = 0;
            this.tur_adi = "";
        }

        public Int32 _id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
            public String _tur_adi
            {
            get
            {
                return tur_adi;
            }
            set
            {
                tur_adi = value;    
            }
         }
    }
}
