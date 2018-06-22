
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
    class DB_Ekle
    {
        private MySqlConnection mysqlbaglan;

        public DB_Ekle()
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

        public bool IlanEkle(Ilan ilan)
        {
            bool sonuc;

            try
            {
                mysqlbaglan.Open();

                string sorgu = "INSERT INTO `tbl_ilan` (`IlanID`, `Ilan_Adi`, `Ilan_Fiyat`, `Ilan_Km`, `Ilan_Tarih`, `Ilan_ArabaID`, `Ilan_SehirID`)"
                                               + " VALUES (NULL, '" + ilan.Ilan_Adi + "', '" + ilan.Ilan_Fiyat + "', '" + ilan.Ilan_Km + "', '" + ilan.Ilan_Tarih.ToString("yyyy-MM-dd") + "', '" + ilan.Ilan_ArabaID + "', '" + ilan.Ilan_SehirID + "');";

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

        public bool ArabaEkle(Araba araba)
        {
            bool sonuc;

            try
            {
                mysqlbaglan.Open();


                string sorgu = "INSERT INTO `tbl_araba` (`ArabaID`, `Araba_Marka`, `Araba_Model`, `Araba_VitesTuruID`, `Araba_YakitTuruID`, `Araba_RenkID`)"
                                              + " VALUES (NULL, '" + araba.Araba_Marka + "', '" + araba.Araba_Model + "', '" + araba.Araba_VitesTuruID + "', '" + araba.Araba_YakitTuruID + "', '" + araba.Araba_RenkID + "')";


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

        public bool RenkEkle(Renk renk)
        {
            bool sonuc;

            try
            {
                mysqlbaglan.Open();

                string sorgu = "INSERT INTO `tbl_renk` (`RenkID`, `Renk`) VALUES (NULL, '" + renk.renk + "');";

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

        public bool SehirEkle(Sehir sehir)
        {
            bool sonuc;

            try
            {
                mysqlbaglan.Open();

                string sorgu = "INSERT INTO `tbl_sehir` (`SehirID`, `Sehir`) VALUES (NULL, '" + sehir.sehir + "');";

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

        public bool VitesTuruEkle(VitesTuru vitesTuru)
        {
            bool sonuc;

            try
            {
                mysqlbaglan.Open();

                string sorgu = "INSERT INTO `tbl_vitesturu` (`VitesTuruID`, `Vites_Turu`) VALUES (NULL, '" + vitesTuru.Vites_Turu + "');";

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

        public bool YakitTuruEkle(YakitTuru yakitTuru)
        {
            bool sonuc;

            try
            {
                mysqlbaglan.Open();

                string sorgu = "INSERT INTO `tbl_yakitturu` (`YakitTuruID`, `Yakit_Turu`) VALUES (NULL, '"+yakitTuru.Yakit_Turu+"');";

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
