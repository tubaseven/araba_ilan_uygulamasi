-- phpMyAdmin SQL Dump
-- version 4.7.7
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 23 May 2018, 08:08:13
-- Sunucu sürümü: 10.1.30-MariaDB
-- PHP Sürümü: 7.2.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `prolab4_db`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `tbl_ilan`
--

CREATE TABLE `tbl_ilan` (
  `IlanID` int(11) NOT NULL,
  `Ilan_Adi` text NOT NULL,
  `Ilan_Fiyat` double NOT NULL,
  `Ilan_Km` double NOT NULL,
  `Ilan_Tarih` date NOT NULL,
  `Ilan_ArabaID` int(11) NOT NULL,
  `Ilan_SehirID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Tablo döküm verisi `tbl_ilan`
--

INSERT INTO `tbl_ilan` (`IlanID`, `Ilan_Adi`, `Ilan_Fiyat`, `Ilan_Km`, `Ilan_Tarih`, `Ilan_ArabaID`, `Ilan_SehirID`) VALUES
(1, 'Temiz Araba', 35000, 22222, '2018-05-23', 1, 1),
(3, 'Yeni Araba', 35000, 22222, '2018-05-23', 3, 1),
(4, 'Yeni Araba', 35000, 22222, '2018-05-23', 3, 1),
(5, 'Tertemiz', 5, 12, '2018-05-12', 1, 1);

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `tbl_ilan`
--
ALTER TABLE `tbl_ilan`
  ADD PRIMARY KEY (`IlanID`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `tbl_ilan`
--
ALTER TABLE `tbl_ilan`
  MODIFY `IlanID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
