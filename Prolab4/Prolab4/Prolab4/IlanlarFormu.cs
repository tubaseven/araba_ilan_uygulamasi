using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prolab4
{
    public partial class IlanlarFormu : Form
    {
        public IlanlarFormu()
        {
            InitializeComponent();
        }

        private void IlanlarFormu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        List<Ilan> ilanlar;
        List<Araba> arabalar;
        List<Sehir> sehirler;
        List<Renk> renkler;
        List<VitesTuru> vitesTurleri;
        List<YakitTuru> yakitTurleri;

        private void IlanlarFormu_Load(object sender, EventArgs e)
        {
            DB_Listele listele = new DB_Listele();

            ilanlar = listele.IlanListele();
            arabalar = listele.ArabaListele();
            sehirler = listele.SehirListele();
            renkler = listele.RenkListele();
            vitesTurleri = listele.VitesTuruListele();
            yakitTurleri = listele.YakitTuruListele();


            //foreach (Ilan ilan in ilanlar)
            //    comboBox_ilanID.Items.Add(ilan.IlanID);

            foreach (Araba araba in arabalar)
                comboBox_araba.Items.Add(araba.Araba_Marka+" / "+araba.Araba_Model);

            foreach (Sehir sehir in sehirler)
                comboBox_sehir.Items.Add(sehir.sehir);

            foreach (Renk renk in renkler)
                comboBox_renk.Items.Add(renk.renk);

            foreach (VitesTuru vitesturu in vitesTurleri)
                comboBox_vitesTuru.Items.Add(vitesturu.Vites_Turu);

            foreach (YakitTuru yakitturu in yakitTurleri)
                comboBox_yakitTuru.Items.Add(yakitturu.Yakit_Turu);
        }
    }
}
