using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.varliklar
{
    class departman
    {
        Int32 id;
        String departman_ismi;

            public departman()
            {
                this.id = 0;
                this.departman_ismi = "";
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

            public String _departman_ismi
            {
                get
                {
                    return departman_ismi;
                }
                set 
                {
                    departman_ismi = value;
                }
            }
    }
}
