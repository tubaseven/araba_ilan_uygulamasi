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
    class DB_Listele
    {
        private MySqlConnection mysqlbaglan;

        public DB_Listele()
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


        public List<Ilan> IlanListele(string kosullar)
        {
            List<Ilan> liste = null;
            try
            {
                mysqlbaglan.Open();

                string sorgu = "SELECT * FROM `tbl_ilan` WHERE "+kosullar;

                MySqlCommand komut = new MySqlCommand(sorgu, mysqlbaglan);
                MySqlDataReader oku = komut.ExecuteReader();

                liste = new List<Ilan>();
                while (oku.Read())
                {
                    Ilan nesne = new Ilan()
                    {
                        IlanID = oku.GetInt32("IlanID"),
                        Ilan_Adi = oku.GetString("Ilan_Adi"),
                        Ilan_ArabaID = oku.GetInt32("Ilan_ArabaID"),
                        Ilan_Fiyat = oku.GetDouble("Ilan_Fiyat"),
                        Ilan_Km = oku.GetDouble("Ilan_Km"),
                        Ilan_SehirID = oku.GetInt32("Ilan_SehirID"),
                        Ilan_Tarih = Convert.ToDateTime(oku.GetString("Ilan_Tarih")),
                    };

                    liste.Add(nesne);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA: " + ex.Message);
            }
            finally
            {
                mysqlbaglan.Close();
            }

            return liste;

        }



        public List<Ilan> IlanListele()
        {
            List<Ilan> liste = null;
            try
            {
                mysqlbaglan.Open();

                string sorgu = "SELECT * FROM `tbl_ilan`";

                MySqlCommand komut = new MySqlCommand(sorgu, mysqlbaglan);
                MySqlDataReader oku = komut.ExecuteReader();

                liste = new List<Ilan>();
                while (oku.Read())
                {
                    Ilan nesne = new Ilan()
                    {
                        IlanID = oku.GetInt32("IlanID"),
                        Ilan_Adi = oku.GetString("Ilan_Adi"),
                        Ilan_ArabaID = oku.GetInt32("Ilan_ArabaID"),
                        Ilan_Fiyat = oku.GetDouble("Ilan_Fiyat"),
                        Ilan_Km = oku.GetDouble("Ilan_Km"),
                        Ilan_SehirID = oku.GetInt32("Ilan_SehirID"),
                        Ilan_Tarih = Convert.ToDateTime(oku.GetString("Ilan_Tarih")),
                    };

                    liste.Add(nesne);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA: " + ex.Message);
            }
            finally
            {
                mysqlbaglan.Close();
            }

            return liste;

        }

        public List<Araba> ArabaListele()
        {
            List<Araba> liste = null;
            try
            {
                mysqlbaglan.Open();

                string sorgu = "SELECT * FROM `tbl_araba`";

                MySqlCommand komut = new MySqlCommand(sorgu, mysqlbaglan);
                MySqlDataReader oku = komut.ExecuteReader();

                liste = new List<Araba>();
                while (oku.Read())
                {
                    Araba nesne = new Araba()
                    {
                        ArabaID = oku.GetInt32("ArabaID"),
                        Araba_Marka = oku.GetString("Araba_Marka"),
                        Araba_Model = oku.GetString("Araba_Model"),
                        Araba_RenkID = oku.GetInt32("Araba_RenkID"),
                        Araba_VitesTuruID = oku.GetInt32("Araba_VitesTuruID"),
                        Araba_YakitTuruID = oku.GetInt32("Araba_YakitTuruID")
                    };

                    liste.Add(nesne);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA: " + ex.Message);
            }
            finally
            {
                mysqlbaglan.Close();
            }

            return liste;

        }

        public List<Renk> RenkListele()
        {
            List<Renk> liste = null;
            try
            {
                mysqlbaglan.Open();

                string sorgu = "SELECT * FROM `tbl_renk`";

                MySqlCommand komut = new MySqlCommand(sorgu, mysqlbaglan);
                MySqlDataReader oku = komut.ExecuteReader();

                liste = new List<Renk>();
                while (oku.Read())
                {
                    Renk nesne = new Renk()
                    {
                        RenkID = oku.GetInt32("RenkID"),
                        renk = oku.GetString("Renk")
                    };

                    liste.Add(nesne);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA: " + ex.Message);
            }
            finally
            {
                mysqlbaglan.Close();
            }

            return liste;

        }

        public List<Sehir> SehirListele()
        {
            List<Sehir> liste = null;
            try
            {
                mysqlbaglan.Open();

                string sorgu = "SELECT * FROM `tbl_sehir`";

                MySqlCommand komut = new MySqlCommand(sorgu, mysqlbaglan);
                MySqlDataReader oku = komut.ExecuteReader();

                liste = new List<Sehir>();
                while (oku.Read())
                {
                    Sehir nesne = new Sehir()
                    {
                        SehirID = oku.GetInt32("SehirID"),
                        sehir = oku.GetString("Sehir")
                    };

                    liste.Add(nesne);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA: " + ex.Message);
            }
            finally
            {
                mysqlbaglan.Close();
            }

            return liste;

        }

        public List<VitesTuru> VitesTuruListele()
        {
            List<VitesTuru> liste = null;
            try
            {
                mysqlbaglan.Open();

                string sorgu = "SELECT * FROM `tbl_vitesturu`";

                MySqlCommand komut = new MySqlCommand(sorgu, mysqlbaglan);
                MySqlDataReader oku = komut.ExecuteReader();

                liste = new List<VitesTuru>();
                while (oku.Read())
                {
                    VitesTuru nesne = new VitesTuru()
                    {
                        VitesTuruID = oku.GetInt32("VitesTuruID"),
                        Vites_Turu = oku.GetString("Vites_Turu")
                    };

                    liste.Add(nesne);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA: " + ex.Message);
            }
            finally
            {
                mysqlbaglan.Close();
            }

            return liste;

        }

        public List<YakitTuru> YakitTuruListele()
        {
            List<YakitTuru> liste = null;
            try
            {
                mysqlbaglan.Open();

                string sorgu = "SELECT * FROM `tbl_yakitturu`";

                MySqlCommand komut = new MySqlCommand(sorgu, mysqlbaglan);
                MySqlDataReader oku = komut.ExecuteReader();

                liste = new List<YakitTuru>();
                while (oku.Read())
                {
                    YakitTuru nesne = new YakitTuru()
                    {
                        YakitTuruID = oku.GetInt32("YakitTuruID"),
                        Yakit_Turu = oku.GetString("Yakit_Turu")
                    };

                    liste.Add(nesne);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA: " + ex.Message);
            }
            finally
            {
                mysqlbaglan.Close();
            }

            return liste;

        }
    }
}
