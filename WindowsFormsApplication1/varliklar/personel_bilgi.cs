using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.varliklar
{
    class personel_bilgi
    {
        Int32 id;
        Int32 y_per_id;
        String ad;
        String soyad;
        String kullanici_sifresi;
        Int32 tc_kimlik_no;
        String cinsiyet;
        String email;
        Int32 telefon;
        Int32 gsm;
        String resim;

        public personel_bilgi()
        {
            this.id = 0;
            this.y_per_id = 0;
            this.ad = "";
            this.soyad = "";
            this.kullanici_sifresi = "";
            this.tc_kimlik_no = 0;
            this.cinsiyet = "";
            this.email = "";
            this.telefon = 0;
            this.gsm = 0;
            this.resim = "";
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

        public Int32 _y_per_id
        {
            get
            {
                return y_per_id;
            }
            set
            {
                y_per_id = value ;
            }
        }
        public String _ad
        {
            get
            {
                return ad;
            }
            set
            {
                ad = value;
            }
        }

        public String _soyad
        {
            get
            {
                return soyad;
            }
            set
            {
                soyad = value;
            }
        }

        public String _kullanici_sifresi
        {
            get
            {
                return kullanici_sifresi;
            }
            set
            {
                kullanici_sifresi = value;
            }
        }

        public Int32 _tc_kimlik_no
        {
            get
            {
                return tc_kimlik_no;
            }

            set
            {
                tc_kimlik_no = value;
            }
        }

        public String _cinsiyet
        {
            get
            {
                return cinsiyet;
            }
            set
            {
                cinsiyet = value;
            }
        }

        public String _email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public Int32 _telefon
        {
            get
            {
                return telefon;
            }
            set
            {
                telefon = value;
            }
        }

        public Int32 _gsm
        {
            get
            {
                return gsm;
            }
            set
            {
                gsm = value;
            }
        }

        public String _resim
        {
            get
            {
                return resim;
            }
            set
            {
                resim = value;
            }
        }

    }
}
