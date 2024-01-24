-- --------------------------------------------------------
-- Verkkotietokone:              127.0.0.1
-- Palvelinversio:               10.6.11-MariaDB - mariadb.org binary distribution
-- Server OS:                    Win64
-- HeidiSQL Versio:              11.3.0.6295
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

-- Dumping data for table vn.alue: ~4 rows (suunnilleen)
/*!40000 ALTER TABLE `alue` DISABLE KEYS */;
INSERT INTO `alue` (`alue_id`, `nimi`) VALUES
	(2, 'Helsinki'),
	(3, 'Joensuu'),
	(1, 'Kuopio'),
	(4, 'Oulu');
/*!40000 ALTER TABLE `alue` ENABLE KEYS */;

-- Dumping data for table vn.asiakas: ~4 rows (suunnilleen)
/*!40000 ALTER TABLE `asiakas` DISABLE KEYS */;
INSERT INTO `asiakas` (`asiakas_id`, `postinro`, `etunimi`, `sukunimi`, `lahiosoite`, `email`, `puhelinnro`) VALUES
	(1, '70100', 'Tommi', 'Makkonen', 'Kauppakatu 3', 'tommi.makko@gmail.com', '0401258565'),
	(2, '80100', 'Tanja', 'Korhonen', 'Savonkatu 16', 'tanja.ko@gmail.com', ''),
	(3, '70100', 'Pekka', 'Nieminen', 'Ravitie 2', '', '0402215788'),
	(4, '00100', 'Sari', 'Heikkinen', 'Harjutie 11', 'sari.heik@gmail.com', '0441366271');
/*!40000 ALTER TABLE `asiakas` ENABLE KEYS */;

-- Dumping data for table vn.lasku: ~2 rows (suunnilleen)
/*!40000 ALTER TABLE `lasku` DISABLE KEYS */;
INSERT INTO `lasku` (`lasku_id`, `varaus_id`, `summa`, `alv`) VALUES
	(1, 1, 410.00, 80.00),
	(2, 2, 1390.00, 270.00);
/*!40000 ALTER TABLE `lasku` ENABLE KEYS */;

-- Dumping data for table vn.mokki: ~6 rows (suunnilleen)
/*!40000 ALTER TABLE `mokki` DISABLE KEYS */;
INSERT INTO `mokki` (`mokki_id`, `alue_id`, `postinro`, `mokkinimi`, `katuosoite`, `hinta`, `kuvaus`, `henkilomaara`, `varustelu`) VALUES
	(1, 1, '70100', 'Kontio', 'Tahkovuorentie 1', 350.00, 'Korkeatasoinen mökki. Tilava ja tyylikäs olohuone/keittiö. Talon päädyssä hieno terassi.', 4, '2 suihkua, 2 makuuhuonetta, vuodesohva, taulutelevisio.'),
	(2, 1, '70100', 'VIP', 'Tahkotie 4', 700.00, 'VIP luokan varusteet. Teatteritila + high quality äänentoisto. 3 autokatosta.', 12, 'Oma teatteri, 6 makuuhuonetta, 5 vessaa, 20 jääkaappia.'),
	(3, 3, '80100', 'Kivikulta', 'Kivijoenkatu 12', 550.00, 'Lapsiperheen suosikki. 8 sänkyä ja 4 vessaa. Minibaari ja pallogrilli terassilla.', 8, '8 makuuhuonetta, 6 suihkua, pieni takka, monta sänkyä, hieno maisema.'),
	(4, 2, '00100', 'Lux de vintti', 'Helsinkikuja 3', 280.00, 'Pienehkö vintti lasikatolla. Hyvä tuuletus mutta eksoottinen haju.', 1, 'Puujakkara, 1 sänky, vanha raamattu, edellisen asiakkaan housut, villakoiria.'),
	(5, 4, '90100', 'Villa q', 'Peltokatu 9', 300.00, 'Kahdelle kävijälle täydellinen paketti. Hieno sauna + maisemat. Kotoisa tunnelma.', 2, '2 makuuhuonetta, hieno nojatuoli, 2 suihkua, 1 keittiö, sauna, pieni parveke. '),
	(6, 1, '70100', 'Mi casa', 'Keskitie 1', 1200.00, 'Bilemökki isommalle porukalle. Kaksi iso paljua ja minibaareja ympäri taloa. Oma pelihuone.', 22, '10 makuuhuonetta, 2 paljua, 6 jääkaappia, 5 pelikonetta, biljardipöytä, iso sauna.');
/*!40000 ALTER TABLE `mokki` ENABLE KEYS */;

-- Dumping data for table vn.palvelu: ~5 rows (suunnilleen)
/*!40000 ALTER TABLE `palvelu` DISABLE KEYS */;
INSERT INTO `palvelu` (`palvelu_id`, `alue_id`, `nimi`, `tyyppi`, `kuvaus`, `hinta`, `alv`) VALUES
	(1, 1, 'Aamiaspaketti', 1, 'Jättimättö aamupala, porsaanleikettä, rasvasta pekonia, ranskalaislautanen.', 50.00, 10.00),
	(2, 1, 'Palju', 2, 'Jättipalju tuodaan haluaamaanne paikkaan, täyttö ja lämmitys kuuluu palveluun.', 150.00, 40.00),
	(3, 4, 'Poron metsästys', 3, 'Pääset kokemaan kuinka ammutaan oikea poro kiväärillä. Kaikki varusteet kuuluu palveluun.', 250.00, 0.00),
	(4, 3, 'Auto', 4, 'Tuomme vuorokaudeksi auton käyttöönne, polttoainekulut ei kuulu hintaan.', 500.00, 0.00),
	(5, 2, 'Avustaja', 5, 'Avustaja tulee auttamaan missä vain tehtävässä vuorokauden ajaksi.', 1000.00, 20.00);
/*!40000 ALTER TABLE `palvelu` ENABLE KEYS */;

-- Dumping data for table vn.posti: ~4 rows (suunnilleen)
/*!40000 ALTER TABLE `posti` DISABLE KEYS */;
INSERT INTO `posti` (`postinro`, `toimipaikka`) VALUES
	('00100', 'Helsinki'),
	('70100', 'Kuopio'),
	('80100', 'Joensuu'),
	('90100', 'Oulu');
/*!40000 ALTER TABLE `posti` ENABLE KEYS */;

-- Dumping data for table vn.varauksen_palvelut: ~2 rows (suunnilleen)
/*!40000 ALTER TABLE `varauksen_palvelut` DISABLE KEYS */;
INSERT INTO `varauksen_palvelut` (`varaus_id`, `palvelu_id`, `lkm`) VALUES
	(1, 1, 1),
	(2, 2, 1);
/*!40000 ALTER TABLE `varauksen_palvelut` ENABLE KEYS */;

-- Dumping data for table vn.varaus: ~2 rows (suunnilleen)
/*!40000 ALTER TABLE `varaus` DISABLE KEYS */;
INSERT INTO `varaus` (`varaus_id`, `asiakas_id`, `mokki_mokki_id`, `varattu_pvm`, `vahvistus_pvm`, `varattu_alkupvm`, `varattu_loppupvm`) VALUES
	(1, 3, 1, '2023-03-29 16:51:09', '2023-03-29 17:04:21', '2023-04-10 16:49:43', '2023-04-20 16:51:51'),
	(2, 1, 6, '2023-04-10 16:52:39', '2023-04-10 17:00:45', '2023-04-15 16:53:56', '2023-04-19 16:53:09');
/*!40000 ALTER TABLE `varaus` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
