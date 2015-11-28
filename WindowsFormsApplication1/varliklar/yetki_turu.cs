using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.varliklar
{
    class yetki_turu
    {
        Int32 id;
        string yetki_ismi;


        public yetki_turu()
        {
            this.id = 0;
            this.yetki_ismi = "";
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
        public string _yetki_ismi
        {
            get
            {
                return yetki_ismi;
            }
            set
            {
                yetki_ismi = value;
            }
        }
    }
}
