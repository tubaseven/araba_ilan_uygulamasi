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
    public partial class SistemFormu : Form
    {
        public SistemFormu()
        {
            InitializeComponent();
        }

        #region FormIslemleri_LOAD

        private void SistemFormu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }



        List<Ilan> ilanlar;
        List<Araba> arabalar;
        List<Sehir> sehirler;
        List<Renk> renkler;
        List<VitesTuru> vitesTurleri;
        List<YakitTuru> yakitTurleri;
        private void SistemFormu_Load(object sender, EventArgs e)
        {
            DB_Listele listele = new DB_Listele();

            ilanlar = listele.IlanListele();
            arabalar = listele.ArabaListele();
            sehirler = listele.SehirListele();
            renkler = listele.RenkListele();
            vitesTurleri = listele.VitesTuruListele();
            yakitTurleri = listele.YakitTuruListele();


            foreach (Ilan ilan in ilanlar)
                comboBox_ilanID.Items.Add(ilan.IlanID);

            foreach (Araba araba in arabalar)
                comboBox_araba_ID.Items.Add(araba.ArabaID);

            foreach (Sehir sehir in sehirler)
                comboBox_sehir_ID.Items.Add(sehir.SehirID);

            foreach (Renk renk in renkler)
                comboBox_renk_id.Items.Add(renk.RenkID);

            foreach (VitesTuru vitesturu in vitesTurleri)
                comboBox_vt_ID.Items.Add(vitesturu.VitesTuruID);

            foreach (YakitTuru yakitturu in yakitTurleri)
                comboBox_yt_ID.Items.Add(yakitturu.YakitTuruID);
        }

        #endregion


        #region Mesajlar

        public void BasaraliMesaji()
        {
            MessageBox.Show("İŞLEM BAŞARILI", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void HataMesaji()
        {
            MessageBox.Show("İŞLEM BAŞARISIZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        public void SonucGoster(bool result)
        {
            if (result)
            {
                BasaraliMesaji();
            }
            else
            {
                HataMesaji();
            }
        }

        #endregion


        #region GetirButonlari

        private void button_ilan_getir_Click(object sender, EventArgs e)
        {
            int ilanSirasi = comboBox_ilanID.SelectedIndex;

            Ilan secilenIlan = ilanlar[ilanSirasi];

            textBox_ilan_ad.Text = secilenIlan.Ilan_Adi;
            textBox_ilan_arabaID.Text = secilenIlan.Ilan_ArabaID + "";
            textBox_ilan_fiyat.Text = secilenIlan.Ilan_Fiyat + "";
            textBox_ilan_km.Text = secilenIlan.Ilan_Km + "";
            textBox_ilan_sehirID.Text = secilenIlan.Ilan_SehirID + "";
            textBox_ilan_tarih.Text = secilenIlan.Ilan_Tarih.ToShortDateString();
        }

        private void button_araba_getir_Click(object sender, EventArgs e)
        {
            int arabaSirasi = comboBox_araba_ID.SelectedIndex;

            Araba secilen = arabalar[arabaSirasi];

            textBox_araba_marka.Text = secilen.Araba_Marka;
            textBox_araba_model.Text = secilen.Araba_Model;
            textBox_araba_renkID.Text = secilen.Araba_RenkID + "";
            textBox_araba_vtID.Text = secilen.Araba_VitesTuruID + "";
            textBox_araba_ytID.Text = secilen.Araba_YakitTuruID + "";
        }

        private void button_vt_getir_Click(object sender, EventArgs e)
        {
            int sira = comboBox_vt_ID.SelectedIndex;

            VitesTuru secilen = vitesTurleri[sira];

            textBox_vt_vTuru.Text = secilen.Vites_Turu;
        }

        private void button_yt_getir_Click(object sender, EventArgs e)
        {
            int sira = comboBox_yt_ID.SelectedIndex;

            YakitTuru secilen = yakitTurleri[sira];

            textBox_yt_yTuru.Text = secilen.Yakit_Turu;
        }

        private void button_sehir_getir_Click(object sender, EventArgs e)
        {
            int sira = comboBox_sehir_ID.SelectedIndex;

            Sehir secilen = sehirler[sira];

            textBox_sehir_adi.Text = secilen.sehir;
        }

        private void button_renk_getir_Click(object sender, EventArgs e)
        {
            int sira = comboBox_renk_id.SelectedIndex;

            Renk secilen = renkler[sira];

            textBox_renk_adi.Text = secilen.renk;
        }


        #endregion


        #region Eklemeler

        private void button_ilan_ekle_Click(object sender, EventArgs e)
        {
            Ilan ilan = new Ilan()
            {
                IlanID = (comboBox_ilanID.SelectedIndex != -1) ? Convert.ToInt32(comboBox_ilanID.Text) : 1,
                Ilan_SehirID = Convert.ToInt32(textBox_ilan_sehirID.Text),
                Ilan_ArabaID = Convert.ToInt32(textBox_ilan_arabaID.Text),
                Ilan_Adi = textBox_ilan_ad.Text,
                Ilan_Fiyat = Convert.ToDouble(textBox_ilan_fiyat.Text),
                Ilan_Km = Convert.ToDouble(textBox_ilan_km.Text),
                Ilan_Tarih = Convert.ToDateTime(textBox_ilan_tarih.Text),
            };

            DB_Ekle dbIslem = new DB_Ekle();
            bool result = dbIslem.IlanEkle(ilan);
            SonucGoster(result);
        }

        private void button_araba_ekle_Click(object sender, EventArgs e)
        {
            Araba nesne = new Araba()
            {
                ArabaID = (comboBox_araba_ID.SelectedIndex != -1) ? Convert.ToInt32(comboBox_araba_ID.Text) : 1,
                Araba_Marka = textBox_araba_marka.Text,
                Araba_Model = textBox_araba_model.Text,
                Araba_RenkID = Convert.ToInt32(textBox_araba_renkID.Text),
                Araba_VitesTuruID = Convert.ToInt32(textBox_araba_vtID.Text),
                Araba_YakitTuruID = Convert.ToInt32(textBox_araba_ytID.Text),
            };

            DB_Ekle dbIslem = new DB_Ekle();
            bool result = dbIslem.ArabaEkle(nesne);
            SonucGoster(result);
        }

        #endregion


        #region Guncellemeler

        private void button_ilan_guncelle_Click(object sender, EventArgs e)
        {
            Ilan ilan = new Ilan()
            {
                IlanID = (comboBox_ilanID.SelectedIndex != -1) ? Convert.ToInt32(comboBox_ilanID.Text) : 1,
                Ilan_SehirID = Convert.ToInt32(textBox_ilan_sehirID.Text),
                Ilan_ArabaID = Convert.ToInt32(textBox_ilan_arabaID.Text),
                Ilan_Adi = textBox_ilan_ad.Text,
                Ilan_Fiyat = Convert.ToDouble(textBox_ilan_fiyat.Text),
                Ilan_Km = Convert.ToDouble(textBox_ilan_km.Text),
                Ilan_Tarih = Convert.ToDateTime(textBox_ilan_tarih.Text),
            };

            DB_Guncelle dbIslem = new DB_Guncelle();
            bool result = dbIslem.IlanGuncelle(ilan);
            SonucGoster(result);
        }

        private void button_araba_guncelle_Click(object sender, EventArgs e)
        {
            Araba nesne = new Araba()
            {
                ArabaID = (comboBox_araba_ID.SelectedIndex != -1) ? Convert.ToInt32(comboBox_araba_ID.Text) : 1,
                Araba_Marka = textBox_araba_marka.Text,
                Araba_Model = textBox_araba_model.Text,
                Araba_RenkID = Convert.ToInt32(textBox_araba_renkID.Text),
                Araba_VitesTuruID = Convert.ToInt32(textBox_araba_vtID.Text),
                Araba_YakitTuruID = Convert.ToInt32(textBox_araba_ytID.Text),
            };

            DB_Guncelle dbIslem = new DB_Guncelle();
            bool result = dbIslem.ArabaGuncelle(nesne);
            SonucGoster(result);
        }


        #endregion


        #region Silmeler

        private void button_ilan_sil_Click(object sender, EventArgs e)
        {
            Ilan ilan = new Ilan()
            {
                IlanID = (comboBox_ilanID.SelectedIndex != -1) ? Convert.ToInt32(comboBox_ilanID.Text) : 1,
            };

            DB_Sil dbIslem = new DB_Sil();
            bool result = dbIslem.IlanSil(ilan);
            SonucGoster(result);
        }

        private void button_araba_sil_Click(object sender, EventArgs e)
        {
            Araba nesne = new Araba()
            {
                ArabaID = (comboBox_araba_ID.SelectedIndex != -1) ? Convert.ToInt32(comboBox_araba_ID.Text) : 1,
            };

            DB_Sil dbIslem = new DB_Sil();
            bool result = dbIslem.ArabaSil(nesne);
            SonucGoster(result);
        }

        #endregion
    }
}
