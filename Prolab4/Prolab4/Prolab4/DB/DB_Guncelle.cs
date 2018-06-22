using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prolab4
{
    class DB_Guncelle
    {
        private MySqlConnection mysqlbaglan;

        public DB_Guncelle()
        {
            mysqlbaglan = new MySqlConnection("Server=localhost;Database=prolab4_db;Uid=root;Pwd='';Encrypt=false;AllowUserVariables=True;UseCompression=True");

            try
            {
                mysqlbaglan.Open();
                if (mysqlbaglan.State != ConnectionState.Closed)
                {
                    //MessageBox.Show("Bağlantı Başarılı Bir Şekilde Gerçekleşti");
                }
                else
                {
                    //MessageBox.Show("Maalesef Bağlantı Yapılamadı...!");
                }
                mysqlbaglan.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Hata! " + err.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool IlanGuncelle(Ilan ilan)
        {
            bool sonuc;

            try
            {
                mysqlbaglan.Open();

                string sorgu = "UPDATE `tbl_ilan` SET `Ilan_Adi`='" + ilan.Ilan_Adi + "',`Ilan_Fiyat`='" + ilan.Ilan_Fiyat + "',  `Ilan_Km`='" + ilan.Ilan_Km + "', `Ilan_Tarih`='" + ilan.Ilan_Tarih.ToString("yyyy-MM-dd") + "', `Ilan_ArabaID`='" + ilan.Ilan_ArabaID + "', `Ilan_SehirID`='" + ilan.Ilan_SehirID + "' WHERE IlanID='" + ilan.IlanID + "';";

                MySqlCommand komut = new MySqlCommand(sorgu, mysqlbaglan);

                int islemSonucu = komut.ExecuteNonQuery();
                if (islemSonucu == 1)
                    sonuc = true;
                else
                    sonuc = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA: " + ex.Message);
                sonuc = false;
            }
            finally
            {
                mysqlbaglan.Close();
            }

            return sonuc;
        }

        public bool ArabaGuncelle(Araba araba)
        {
            bool sonuc;

            try
            {
                mysqlbaglan.Open();

                string sorgu = "UPDATE `tbl_araba` SET `Araba_Marka`='" + araba.Araba_Marka + "', `Araba_Model`='" + araba.Araba_Model + "',  `Araba_VitesTuruID`='" + araba.Araba_VitesTuruID + "', `Araba_YakitTuruID`='" + araba.Araba_YakitTuruID + "', `Araba_RenkID`='" + araba.Araba_RenkID + "' WHERE  `ArabaID`='" + araba.ArabaID + "'";

                MySqlCommand komut = new MySqlCommand(sorgu, mysqlbaglan);

                int islemSonucu = komut.ExecuteNonQuery();
                if (islemSonucu == 1)
                    sonuc = true;
                else
                    sonuc = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA: " + ex.Message);
                sonuc = false;
            }
            finally
            {
                mysqlbaglan.Close();
            }

            return sonuc;
        }

        public bool RenkGuncelle(Renk renk)
        {
            bool sonuc;

            try
            {
                mysqlbaglan.Open();

                string sorgu = "UPDATE `tbl_renk` SET `Renk`='" + renk.renk + " 'WHERE  `RenkID`='" + renk.RenkID + "';";

                MySqlCommand komut = new MySqlCommand(sorgu, mysqlbaglan);

                int islemSonucu = komut.ExecuteNonQuery();
                if (islemSonucu == 1)
                    sonuc = true;
                else
                    sonuc = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA: " + ex.Message);
                sonuc = false;
            }
            finally
            {
                mysqlbaglan.Close();
            }

            return sonuc;
        }

        public bool SehirGuncelle(Sehir sehir)
        {
            bool sonuc;

            try
            {
                mysqlbaglan.Open();

                string sorgu = "UPDATE `tbl_sehir` SET `Sehir`='" + sehir.sehir + "' WHERE `SehirID`='" + sehir.SehirID + "';";

                MySqlCommand komut = new MySqlCommand(sorgu, mysqlbaglan);

                int islemSonucu = komut.ExecuteNonQuery();
                if (islemSonucu == 1)
                    sonuc = true;
                else
                    sonuc = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA: " + ex.Message);
                sonuc = false;
            }
            finally
            {
                mysqlbaglan.Close();
            }

            return sonuc;
        }

        public bool VitesTuruGuncelle(VitesTuru vitesTuru)
        {
            bool sonuc;

            try
            {
                mysqlbaglan.Open();

                string sorgu = "UPDATE `tbl_vitesturu` SET  `Vites_Turu`='" + vitesTuru.Vites_Turu + "' WHERE `VitesTuruID`='" + vitesTuru.VitesTuruID + "';";

                MySqlCommand komut = new MySqlCommand(sorgu, mysqlbaglan);

                int islemSonucu = komut.ExecuteNonQuery();
                if (islemSonucu == 1)
                    sonuc = true;
                else
                    sonuc = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA: " + ex.Message);
                sonuc = false;
            }
            finally
            {
                mysqlbaglan.Close();
            }

            return sonuc;
        }

        public bool YakitTuruGuncelle(YakitTuru yakitTuru)
        {
            bool sonuc;

            try
            {
                mysqlbaglan.Open();

                string sorgu = "UPDATE `tbl_yakitturu` SET  `Yakit_Turu`='" + yakitTuru.Yakit_Turu + "' WHERE `YakitTuruID`='" + yakitTuru.YakitTuruID + "';";

                MySqlCommand komut = new MySqlCommand(sorgu, mysqlbaglan);

                int islemSonucu = komut.ExecuteNonQuery();
                if (islemSonucu == 1)
                    sonuc = true;
                else
                    sonuc = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA: " + ex.Message);
                sonuc = false;
            }
            finally
            {
                mysqlbaglan.Close();
            }

            return sonuc;
        }
    }
}
