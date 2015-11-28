using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Personel_Ekleme_Sayfasi : Form
    {
        public Personel_Ekleme_Sayfasi()
        {
            InitializeComponent();
            personelTuruId = new List<int>();
        }
        List<Int32> personelTuruId; 
        private void Personel_Ekleme_Sayfasi_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 pTuru = personelTuruId[comboBox1.SelectedIndex ];
        }
    }
}
