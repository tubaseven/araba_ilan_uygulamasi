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
    public partial class SecimFormu : Form
    {
        public SecimFormu()
        {
            InitializeComponent();
        }

        private void Secim_Load(object sender, EventArgs e)
        {
            //DB_Ekle db_islemler = new DB_Ekle();

            //Ilan ilan = new Ilan()
            //{
            //    Ilan_Adi = "Acil Satılık Araba 2",
            //    Ilan_ArabaID = 3,
            //    Ilan_Fiyat = 35000,
            //    Ilan_Km = 4500,
            //    Ilan_SehirID = 1,
            //    Ilan_Tarih = DateTime.Now
            //};
            
            //bool result = db_islemler.IlanEkle(ilan);
            //if (result)
            //    MessageBox.Show("İLAN EKLENDİ", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //else
            //    MessageBox.Show("İLAN EKLENEMEDİ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);




            //DB_Sil db_islemler = new DB_Sil();
            //Renk renk = new Renk() { RenkID = 11 };
            //bool result = db_islemler.RenkSil(renk);
            //if (result)
            //    MessageBox.Show("Renk Silindi", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //else
            //    MessageBox.Show("Renk Silinemedi", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            
                        
            
            
            //DB_Guncelle db_islemler = new DB_Guncelle();
            //Ilan ilan = new Ilan()
            //{
            //    IlanID=1,
            //    Ilan_Adi = "Temiz Araba",
            //    Ilan_ArabaID = 3,
            //    Ilan_Fiyat = 35000,
            //    Ilan_Km = 22222,
            //    Ilan_SehirID = 1,
            //    Ilan_Tarih = DateTime.Now
            //};

            //bool result = db_islemler.IlanGuncelle(ilan);
            //if (result)
            //    MessageBox.Show("İLAN Guncellendi", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //else
            //    MessageBox.Show("İLAN Guncellenemedi", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);




            //DB_Listele db_islemler = new DB_Listele();
            
            //List<Araba> result = db_islemler.ArabaListele();
            //if (result != null)
            //{
            //    foreach (Araba araba in result)
            //    {
            //        MessageBox.Show(araba.Araba_Marka+"--"+araba.Araba_Model);
            //    }
            //}
            //else
            //    MessageBox.Show("Renk Silinemedi", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void button_sistem_Click(object sender, EventArgs e)
        {
            SistemFormu sistem = new SistemFormu();
            sistem.Show();

            this.Hide();
        }

        private void button_Ilanlar_Click(object sender, EventArgs e)
        {
            IlanlarFormu ilanlar = new IlanlarFormu();
            ilanlar.Show();

            this.Hide();
        }
    }
}
