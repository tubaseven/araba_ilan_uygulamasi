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
    class DB_Sil
    {
        private MySqlConnection mysqlbaglan;

        public DB_Sil()
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

        public bool IlanSil(Ilan ilan)
        {
            bool sonuc;

            try
            {
                mysqlbaglan.Open();

                string sorgu = "DELETE FROM `tbl_ilan` WHERE `tbl_ilan`.`IlanID` =" + ilan.IlanID;

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

        public bool ArabaSil(Araba araba)
        {
            bool sonuc;

            try
            {
                mysqlbaglan.Open();

                string sorgu = "DELETE FROM `tbl_araba` WHERE `tbl_araba`.`ArabaID` =" + araba.ArabaID;

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

        public bool RenkSil(Renk renk)
        {
            bool sonuc;

            try
            {
                mysqlbaglan.Open();

                string sorgu = "DELETE FROM `tbl_renk` WHERE `tbl_renk`.`RenkID` =" + renk.RenkID;

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

        public bool SehirSil(Sehir sehir)
        {
            bool sonuc;

            try
            {
                mysqlbaglan.Open();


                string sorgu = "DELETE FROM `tbl_sehir` WHERE `tbl_sehir`.`SehirID` =" + sehir.SehirID;

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

        public bool VitesTuruSil(VitesTuru vitesTuru)
        {
            bool sonuc;

            try
            {
                mysqlbaglan.Open();


                string sorgu = "DELETE FROM `tbl_vitesturu` WHERE `tbl_vitesturu`.`VitesTuruID` =" + vitesTuru.VitesTuruID;

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

        public bool YakitTuruSil(YakitTuru yakitTuru)
        {
            bool sonuc;

            try
            {
                mysqlbaglan.Open();


                string sorgu = "DELETE FROM `tbl_yakitturu` WHERE `tbl_yakitturu`.`YakitTuruID` =" + yakitTuru.YakitTuruID;

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
