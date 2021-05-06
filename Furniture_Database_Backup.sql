-- MySQL dump 10.13  Distrib 8.0.23, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: mobilya
-- ------------------------------------------------------
-- Server version	8.0.23

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `adres`
--

DROP TABLE IF EXISTS `adres`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `adres` (
  `adres_id` int NOT NULL AUTO_INCREMENT,
  `sokak` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `mahalle` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `cadde` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `bina_no` varchar(2) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `daire_no` varchar(2) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ilce` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `il_id` int NOT NULL,
  PRIMARY KEY (`adres_id`),
  KEY `FK_ilAdres_idx` (`il_id`),
  CONSTRAINT `FK_ilAdres` FOREIGN KEY (`il_id`) REFERENCES `il` (`il_id`)
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci COMMENT='Adres tablomuz';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `adres`
--

LOCK TABLES `adres` WRITE;
/*!40000 ALTER TABLE `adres` DISABLE KEYS */;
INSERT INTO `adres` VALUES (1,'Osman Sokak','Susam Mahallesi','Bağdat Caddesi','23','10','Kağıthane',40),(2,'Elif Sokak','Gazipaşa Mahallesi','Kelaynak Caddesi','5','2','Ataşehir',40),(3,'Koza Sokak','Kırsak Mahallesi','Paşa Caddesi','55','3','Maltepe',40),(4,'Lale Sokak','Lale Mahallesi','Lale Caddesi','33','5','Pendik',40),(5,'Poyraz Sokak','Poyraz Mahallesi','Poyraz Caddesi','20','19','Pendik',40),(6,'Ekim Sokak','Kartepe Mahallesi','Ekim Caddesi','4','16','Kartal',40),(7,'Memlük Sokak','Memlük Mahallesi','Memlük Caddesi','23','10','Kadıköy',40),(8,'Üsküdar Sokak','Üsküdar Mahallesi','Üsküdar Caddesi','10','5','Üsküdar ',40),(9,'Kaçmaz Sokak','Kaçmaz Mahallesi','Kaçmaz Caddesi','30','23','Gebze',52),(10,'Şule Sokak','Şule Mahallesi','Şule Caddesi','10','30','Gebze',52),(11,'Eylül Sokak','Eylül Mahallesi','Eylül Caddesi','23','11','Gebze',52),(12,'Ocak Sokak','Ocak Mahallesi','Ocak Caddesi','30','2','Gebze',52),(13,'Poyraz Sokak','Polis Mahallesi','Pelin Caddesi','59','4','Pendik',40),(14,'Atatürk Sokak','İsmet Mahallesi','Kazım Caddesi','11','13','Tuzla',40),(15,'Kerim Sokak','Boran Mahallesi','Hakan Caddesi','22','5','Ataşehir',40),(16,'Sıla Sokak','Sıla Mahallesi','Sıla Caddesi','9','17','Ataşehir',40),(17,'Opal Sokak','Opal Mahallesi','Opal Cadde','20','11','Kadıköy',40),(18,'Namık Sokak','Kemal Mahallesi','Lüpegaz Caddesi','10','18','Kağıthane',40),(19,'Sırat Sokak','Sırat Mahallesi','Sıra Caddesi','10','21','Kağıthane',40),(20,'Lüle Sokak','Konak Mahallesi','Meyna Mahallesi','20','11','Arguvan',55),(21,'Sıla Sokak','Sıla Mahallesi','Sıla Caddesi','19','10','Güngören',25),(22,'Jule Sokak','Manisa Mahallesi','Konak Caddesi','7','20','Kartal',40),(23,'Cerman Sokak','Frank Mahallesi','Brit Caddesi','23','11','Aliağa',41),(24,'Aliağa Sokak','Çeşme Mahallesi','Çeşme Caddesi','17','4','Çeşme',41),(25,'Kurban Sokak','Osmanoğulları Mahallesi','Lale Caddesi','13','12','Bağlar',26),(26,'Karlık Sokak','Karlıktepe Mahallesi','Kaçmaz Caddesi','48','16','Kartal',40),(27,'Adıgüzel Sokak','Maltepe Mahallesi','Lale Caddesi','7','11','Maltepe',40),(28,'Salsa Sokak','Salsa Mahallesi','Salsa Caddesi','1','12','Çiğli',41);
/*!40000 ALTER TABLE `adres` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fatura`
--

DROP TABLE IF EXISTS `fatura`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `fatura` (
  `fatura_no` int NOT NULL AUTO_INCREMENT,
  `siparis_no` int NOT NULL,
  `kesim_tarih` datetime NOT NULL,
  `tutar` float unsigned DEFAULT NULL,
  PRIMARY KEY (`fatura_no`),
  UNIQUE KEY `siparis_no_UNIQUE` (`siparis_no`),
  KEY `FK_SiparisFatura_idx` (`siparis_no`),
  CONSTRAINT `FK_SiparisFatura` FOREIGN KEY (`siparis_no`) REFERENCES `siparis` (`siparis_no`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Fatura Tablomuz';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fatura`
--

LOCK TABLES `fatura` WRITE;
/*!40000 ALTER TABLE `fatura` DISABLE KEYS */;
INSERT INTO `fatura` VALUES (1,1,'2021-04-15 18:22:39',7899.89),(2,2,'2021-03-15 11:50:40',7899.89),(6,6,'2021-04-24 09:20:00',7899.89),(7,4,'2021-04-24 19:11:00',7899.89),(9,5,'2021-04-26 20:18:21',7899.89),(10,11,'2021-04-26 08:00:09',7899.89),(11,10,'2021-04-26 12:10:33',3029.96),(12,3,'2021-04-26 07:10:55',1249.99),(13,12,'2021-04-28 15:49:28',14499.9),(14,13,'2021-04-29 10:20:11',4489.96),(15,14,'2021-04-29 10:50:09',1249.95),(16,15,'2021-05-02 16:40:29',2199.99);
/*!40000 ALTER TABLE `fatura` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `il`
--

DROP TABLE IF EXISTS `il`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `il` (
  `il_id` int NOT NULL,
  `il_isim` varchar(15) NOT NULL,
  PRIMARY KEY (`il_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='il tablomuz';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `il`
--

LOCK TABLES `il` WRITE;
/*!40000 ALTER TABLE `il` DISABLE KEYS */;
INSERT INTO `il` VALUES (1,'Adana'),(2,'Adıyaman'),(3,'Afyonkarahisar'),(4,'Ağrı'),(5,'Aksaray'),(6,'Amasya'),(7,'Ankara'),(8,'Antalya'),(9,'Ardahan'),(10,'Artvin'),(11,'Aydın'),(12,'Balıkesir'),(13,'Bartın'),(14,'Batman'),(15,'Bayburt'),(16,'Bilecik'),(17,'Bingöl'),(18,'Bitlis'),(19,'Bolu'),(20,'Burdur'),(21,'Bursa'),(22,'Çanakkale'),(23,'Çankırı'),(24,'Çorum'),(25,'Denizli'),(26,'Diyarbakır'),(27,'Düzce'),(28,'Edirne'),(29,'Elazığ'),(30,'Erzincan'),(31,'Erzurum'),(32,'Eskişehir'),(33,'Gaziantep'),(34,'Giresun'),(35,'Gümüşhane'),(36,'Hakkari'),(37,'Hatay'),(38,'Iğdır'),(39,'Isparta'),(40,'İstanbul'),(41,'İzmir'),(42,'Kahramanmaraş'),(43,'Karabük'),(44,'Karaman'),(45,'Kars'),(46,'Kastamonu'),(47,'Kayseri'),(48,'Kırıkkale'),(49,'Kırklareli'),(50,'Kırşehir'),(51,'Kilis'),(52,'Kocaeli'),(53,'Konya'),(54,'Kütahya'),(55,'Malatya'),(56,'Manisa'),(57,'Mardin'),(58,'Mersin'),(59,'Muğla'),(60,'Muş'),(61,'Nevşehir'),(62,'Niğde'),(63,'Ordu'),(64,'Osmaniye'),(65,'Rize'),(66,'Sakarya'),(67,'Samsun'),(68,'Siirt'),(69,'Sinop'),(70,'Sivas'),(71,'Şanlıurfa'),(72,'Şırnak'),(73,'Tekirdağ'),(74,'Tokat'),(75,'Trabzon'),(76,'Tunceli'),(77,'Uşak'),(78,'Van'),(79,'Yalova'),(80,'Yozgat'),(81,'Zonguldak');
/*!40000 ALTER TABLE `il` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `kategori`
--

DROP TABLE IF EXISTS `kategori`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `kategori` (
  `kategori_kod` varchar(3) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `ad` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`kategori_kod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Kategori tablomuz';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kategori`
--

LOCK TABLES `kategori` WRITE;
/*!40000 ALTER TABLE `kategori` DISABLE KEYS */;
INSERT INTO `kategori` VALUES ('BHE','Bahçe Mobilyası'),('CVG','Çocuk ve Genç Odası'),('MTK','Mutfak'),('OTR','Oturma Odası'),('YMK','Yemek Odası'),('YTK','Yatak Odası');
/*!40000 ALTER TABLE `kategori` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `musteri`
--

DROP TABLE IF EXISTS `musteri`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `musteri` (
  `musteri_no` int NOT NULL AUTO_INCREMENT,
  `ad` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `soyad` varchar(25) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `email` varchar(35) NOT NULL,
  `sifre` varchar(4) NOT NULL,
  `tc_no` varchar(11) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `telefon` varchar(11) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `adres_id` int NOT NULL,
  PRIMARY KEY (`musteri_no`),
  UNIQUE KEY `tc_no_UNIQUE` (`tc_no`),
  UNIQUE KEY `telefon_UNIQUE` (`telefon`),
  UNIQUE KEY `email_UNIQUE` (`email`),
  KEY `FK_AdresMusteri_idx` (`adres_id`),
  CONSTRAINT `FK_AdresMusteri` FOREIGN KEY (`adres_id`) REFERENCES `adres` (`adres_id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Müşteri Tablomuz';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `musteri`
--

LOCK TABLES `musteri` WRITE;
/*!40000 ALTER TABLE `musteri` DISABLE KEYS */;
INSERT INTO `musteri` VALUES (1,'Serhat','Kaçmaz','serhatkacmaz@gmail.com','sk11','82194018901','10010010023',21),(2,'Hakan','Öztürk','hakanozturk@gmail.com','HK19','82918572912','20020020031',22),(3,'Cem','Çatalkaya','cemcatalkaya@outlook.com','CÇ20','47636180300','30030030043',23),(4,'Sıla','Gençoğlu','sila.gencoglu11@hotmail.com','SG99','32919002128','40040040021',24),(5,'Aslı','Demir','asli_demir@yahoo.com','AD23','29196300211','54321129211',25),(6,'Ayşegül','Korkmaz','a.korkmaz@gmail.com','AK11','91201978452','54808676221',26),(7,'Durmuş','Zeki','d.zeki@cimer.com','DA10','19237125426','29298818181',27),(8,'Ramazan','Kaplaner','r.kaplan@outlook.com','RM40','98227162626','53727717111',28);
/*!40000 ALTER TABLE `musteri` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `odeme`
--

DROP TABLE IF EXISTS `odeme`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `odeme` (
  `odeme_kod` int NOT NULL,
  `aciklama` varchar(15) NOT NULL,
  PRIMARY KEY (`odeme_kod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Ödeme Yöntemleri (Online, Kredi kartı, nakit... Vb.)';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `odeme`
--

LOCK TABLES `odeme` WRITE;
/*!40000 ALTER TABLE `odeme` DISABLE KEYS */;
INSERT INTO `odeme` VALUES (1,'Nakit'),(2,'Kredi'),(3,'EFT'),(4,'Havale'),(5,'Mobil');
/*!40000 ALTER TABLE `odeme` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `personel`
--

DROP TABLE IF EXISTS `personel`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `personel` (
  `sicil_no` int NOT NULL,
  `sube_no` int NOT NULL,
  `ad` varchar(45) NOT NULL,
  `soyad` varchar(45) NOT NULL,
  `tc_no` varchar(11) NOT NULL,
  `sifre` varchar(4) NOT NULL,
  `telefon` varchar(11) NOT NULL,
  `adres_id` int NOT NULL,
  PRIMARY KEY (`sicil_no`),
  UNIQUE KEY `tc_no_UNIQUE` (`tc_no`),
  UNIQUE KEY `telefon_UNIQUE` (`telefon`),
  KEY `FK_AdresPersonel_idx` (`adres_id`),
  KEY `FK_SubePersonel_idx` (`sube_no`),
  CONSTRAINT `FK_AdresPersonel` FOREIGN KEY (`adres_id`) REFERENCES `adres` (`adres_id`),
  CONSTRAINT `FK_SubePersonel` FOREIGN KEY (`sube_no`) REFERENCES `sube` (`sube_no`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Personel Tablomuz';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `personel`
--

LOCK TABLES `personel` WRITE;
/*!40000 ALTER TABLE `personel` DISABLE KEYS */;
INSERT INTO `personel` VALUES (1001,1,'Kerim','Adi','82718262123','ae01','12345328912',7),(1023,4,'Nur','Akdin','91827291827','ae23','12345678955',17),(1029,2,'Ömer','Kılıç','32127190021','ae29','12345678952',10),(1044,2,'Fatih','Kaçmaz','62717234232','ae44','12345678942',9),(1071,1,'Merve','Malatya','82619276631','ae71','12345678909',8),(1094,4,'Yakup','Öz','90021352352','ae94','12345678965',19),(1099,4,'Osman','Şentürk','12002300902','ae99','19245678912',20),(1324,4,'Kemalletin','Kaplaner','38381390212','ae24','12345678960',18),(2109,3,'Fatma','Orhan','80002391112','ae09','12345678950',16),(2122,1,'Barış','Adıgüzel','12345678912','ae22','12345678912',5),(2311,2,'Kemal','Yılmaz','27289918291','ae11','12345678999',11),(2678,3,'Ayşe','Karakurt','10042300256','ae78','12345678945',15),(3212,1,'Abdullah','Gün','23214653123','ae12','12345678923',6),(4032,2,'Furkan','Karakuş','17829182781','ae32','12345678930',12),(6721,3,'Salih','Korkmaz','14821009214','ae21','12345678935',13),(9821,3,'Buse','Doğan','32109271002','ae21','12345678940',14);
/*!40000 ALTER TABLE `personel` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `siparis`
--

DROP TABLE IF EXISTS `siparis`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `siparis` (
  `siparis_no` int NOT NULL AUTO_INCREMENT,
  `musteri_no` int NOT NULL,
  `sube_no` int NOT NULL,
  `sicil_no` int NOT NULL,
  `odeme_kod` int NOT NULL,
  `siparis_tarih` datetime NOT NULL,
  `teslimat_tarih` date DEFAULT NULL,
  `durum` varchar(1) NOT NULL,
  PRIMARY KEY (`siparis_no`),
  KEY `FK_PersonelSiparis_idx` (`sicil_no`),
  KEY `FK_SubeSiparis_idx` (`sube_no`),
  KEY `FK_OdemeSiparis_idx` (`odeme_kod`),
  KEY `FK_MusteriSiparis_idx` (`musteri_no`),
  KEY `FK_DurumSiparis_idx` (`durum`),
  CONSTRAINT `FK_DurumSiparis` FOREIGN KEY (`durum`) REFERENCES `siparisdurum` (`durum`),
  CONSTRAINT `FK_MusteriSiparis` FOREIGN KEY (`musteri_no`) REFERENCES `musteri` (`musteri_no`),
  CONSTRAINT `FK_OdemeSiparis` FOREIGN KEY (`odeme_kod`) REFERENCES `odeme` (`odeme_kod`),
  CONSTRAINT `FK_PersonelSiparis` FOREIGN KEY (`sicil_no`) REFERENCES `personel` (`sicil_no`),
  CONSTRAINT `FK_SubeSiparis` FOREIGN KEY (`sube_no`) REFERENCES `sube` (`sube_no`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Siparişlerin olduğu kısım';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `siparis`
--

LOCK TABLES `siparis` WRITE;
/*!40000 ALTER TABLE `siparis` DISABLE KEYS */;
INSERT INTO `siparis` VALUES (1,1,1,1001,2,'2021-04-15 13:11:38','2021-05-15','T'),(2,2,1,1001,2,'2021-03-15 19:41:19','2021-04-15','T'),(3,3,3,2678,3,'2021-03-14 22:10:22','2021-05-01','T'),(4,4,2,2311,1,'2021-04-15 14:09:12','2021-10-04','T'),(5,5,4,1099,5,'2021-04-12 09:30:21','2021-05-02','T'),(6,4,2,2311,1,'2021-04-12 09:30:21','2021-10-11','T'),(7,3,3,2678,1,'2021-04-12 09:30:21',NULL,'A'),(10,1,3,2678,1,'2021-04-26 11:48:54','2021-04-30','T'),(11,4,2,2311,3,'2021-04-26 16:12:49','2021-05-07','T'),(12,6,4,1324,2,'2021-04-28 14:09:10','2021-05-08','T'),(13,8,4,1324,4,'2021-04-29 17:29:06','2021-05-01','T'),(14,6,1,2122,3,'2021-04-29 17:29:06','2021-05-08','T'),(15,5,1,1001,1,'2021-05-01 17:38:53','2021-05-16','T'),(16,1,1,1001,1,'2021-05-01 17:42:58',NULL,'A'),(17,1,1,2122,2,'2021-05-01 20:27:47',NULL,'A'),(18,1,2,1044,1,'2021-05-02 17:30:02',NULL,'A'),(19,1,1,1001,4,'2021-05-03 15:37:28',NULL,'A'),(20,1,2,2311,1,'2021-05-03 15:38:50',NULL,'A');
/*!40000 ALTER TABLE `siparis` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `siparisdetay`
--

DROP TABLE IF EXISTS `siparisdetay`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `siparisdetay` (
  `siparis_no` int NOT NULL,
  `urun_kod` int NOT NULL,
  `adet` int NOT NULL,
  KEY `FK_SiparisDetay_idx` (`siparis_no`),
  KEY `FK_UrunSiparis_idx` (`urun_kod`),
  CONSTRAINT `FK_SiparisDetay` FOREIGN KEY (`siparis_no`) REFERENCES `siparis` (`siparis_no`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_UrunSiparisDetay` FOREIGN KEY (`urun_kod`) REFERENCES `urun` (`urun_kod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Sipariş detay tablomuz';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `siparisdetay`
--

LOCK TABLES `siparisdetay` WRITE;
/*!40000 ALTER TABLE `siparisdetay` DISABLE KEYS */;
INSERT INTO `siparisdetay` VALUES (1,10,1),(2,12,2),(3,4,1),(4,8,2),(5,7,3),(6,3,1),(6,10,2),(7,12,2),(7,21,1),(10,2,1),(10,3,2),(10,4,1),(11,1,2),(11,9,3),(11,25,3),(12,5,3),(12,8,1),(12,9,3),(13,20,1),(13,3,3),(14,12,5),(15,7,1),(16,13,1),(16,18,1),(17,4,1),(18,8,1),(19,1,1),(20,1,1);
/*!40000 ALTER TABLE `siparisdetay` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `siparisdurum`
--

DROP TABLE IF EXISTS `siparisdurum`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `siparisdurum` (
  `durum` varchar(1) NOT NULL,
  `aciklama` varchar(20) NOT NULL,
  PRIMARY KEY (`durum`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `siparisdurum`
--

LOCK TABLES `siparisdurum` WRITE;
/*!40000 ALTER TABLE `siparisdurum` DISABLE KEYS */;
INSERT INTO `siparisdurum` VALUES ('A','Alındı'),('T','Tamamlandı');
/*!40000 ALTER TABLE `siparisdurum` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `stok`
--

DROP TABLE IF EXISTS `stok`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `stok` (
  `sube_no` int NOT NULL,
  `urun_kod` int NOT NULL,
  `adet` int NOT NULL,
  KEY `FK_SubeStok_idx` (`sube_no`),
  KEY `FK_UrunStok_idx` (`urun_kod`),
  CONSTRAINT `FK_SubeStok` FOREIGN KEY (`sube_no`) REFERENCES `sube` (`sube_no`),
  CONSTRAINT `FK_UrunStok` FOREIGN KEY (`urun_kod`) REFERENCES `urun` (`urun_kod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Şube - Ürün tabloları arasındaki çoka-çok ilişkili tablomuz';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `stok`
--

LOCK TABLES `stok` WRITE;
/*!40000 ALTER TABLE `stok` DISABLE KEYS */;
INSERT INTO `stok` VALUES (1,1,10),(2,1,8),(3,1,10),(4,1,10),(1,2,10),(2,2,50),(3,2,9),(4,2,20),(1,3,10),(2,3,50),(3,3,8),(4,3,17),(1,4,10),(2,4,20),(3,4,18),(4,4,20),(1,5,0),(2,5,20),(3,5,0),(4,5,17),(1,6,0),(2,6,20),(3,6,0),(4,6,70),(1,7,49),(2,7,20),(3,7,40),(4,7,17),(1,8,10),(2,8,20),(3,8,60),(4,8,19),(1,9,0),(2,9,17),(3,9,40),(4,9,17),(1,10,0),(2,10,20),(3,10,0),(4,10,30),(1,11,0),(2,11,20),(3,11,0),(4,11,120),(1,12,45),(2,12,20),(3,12,40),(4,12,20),(1,13,15),(2,13,20),(3,13,15),(4,13,20),(1,14,0),(2,14,20),(3,14,40),(4,14,20),(1,15,0),(2,15,20),(3,15,0),(4,15,30),(1,16,0),(2,16,20),(3,16,0),(4,16,170),(1,17,50),(2,17,20),(3,17,40),(4,17,20),(1,18,20),(2,18,20),(3,18,20),(4,18,20),(1,19,0),(2,19,20),(3,19,40),(4,19,20),(1,20,0),(2,20,20),(3,20,0),(4,20,29),(1,21,0),(2,21,25),(3,21,0),(4,21,25),(1,22,50),(2,22,25),(3,22,40),(4,22,25),(1,23,25),(2,23,25),(3,23,25),(4,23,25),(1,24,0),(2,24,25),(3,24,40),(4,24,25),(1,25,0),(2,25,22),(3,25,0),(4,25,30);
/*!40000 ALTER TABLE `stok` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sube`
--

DROP TABLE IF EXISTS `sube`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sube` (
  `sube_no` int NOT NULL,
  `sicil_no` int NOT NULL,
  `ad` varchar(45) NOT NULL,
  `telefon` varchar(11) NOT NULL,
  `adres_id` int NOT NULL,
  PRIMARY KEY (`sube_no`),
  UNIQUE KEY `telefon_UNIQUE` (`telefon`),
  UNIQUE KEY `adres_id_UNIQUE` (`adres_id`),
  UNIQUE KEY `sicil_no_UNIQUE` (`sicil_no`),
  UNIQUE KEY `ad_UNIQUE` (`ad`),
  KEY `FK_PersonelSube_idx` (`sicil_no`),
  CONSTRAINT `FK_AdresSube` FOREIGN KEY (`adres_id`) REFERENCES `adres` (`adres_id`),
  CONSTRAINT `FK_PersonelSube` FOREIGN KEY (`sicil_no`) REFERENCES `personel` (`sicil_no`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Şube tablomuz';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sube`
--

LOCK TABLES `sube` WRITE;
/*!40000 ALTER TABLE `sube` DISABLE KEYS */;
INSERT INTO `sube` VALUES (1,1071,'Kaçmaz Mobilya','21620221781',1),(2,4032,'Adıgüzel Mobilya','92182921292',2),(3,2109,'Kara Mobilya','83123321821',3),(4,1099,'Yılmaz Mobilya','92812827127',4);
/*!40000 ALTER TABLE `sube` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `urun`
--

DROP TABLE IF EXISTS `urun`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `urun` (
  `urun_kod` int NOT NULL,
  `kategori_kod` varchar(3) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `ad` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `aciklama` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `fiyat` float NOT NULL,
  PRIMARY KEY (`urun_kod`),
  KEY `FK_KategoriUrun_idx` (`kategori_kod`),
  CONSTRAINT `FK_KategoriUrun` FOREIGN KEY (`kategori_kod`) REFERENCES `kategori` (`kategori_kod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci COMMENT='Ürünlerimizin tablosu';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `urun`
--

LOCK TABLES `urun` WRITE;
/*!40000 ALTER TABLE `urun` DISABLE KEYS */;
INSERT INTO `urun` VALUES (1,'MTK','TEODERES Sandalye','Sandalyeler 6 tanesi üst üste konulabildiği için kullanılmadığı zaman kolayca saklanır.',99.99),(2,'MTK','TEODERES Masa','Melamin masa tablası neme ve lekelere karşı dayanıklı, kolay temizlenen bir yüzeye sahiptir.',1674.79),(3,'MTK','Bar Taburesi','Mutfağınızda her zaman kullanılacak bir bar taburesi',829.99),(4,'MTK','Zebra Dolap','Kullanış ve kalite bu zebra dolapta',1249.99),(5,'OTR','Troy Kanepe','Salonunuza yakışacak rahat bir troy kanepe',2749.99),(6,'OTR','Luis Kanepe','Son derece rahat ve geniş bir luis kanepe',2299.99),(7,'OTR','Deri Koltuk','İster ofisinize ister evinize bu deri koltuk çok yakışacak',2199.99),(8,'OTR','Eyfel Koltuk','Kibarlık ve rahatlık bir arada eyfel koltukta',999.99),(9,'YTK','Lora Yatak ','Ortopedik ve oldukça rahat lora yatak',1749.99),(10,'YTK','Line Yatak','Bu line yatakta hiçbir yeriniz ağrımayacak',1899.99),(11,'YTK','Pandora Camlı Yatak','Bir yataktan beklediğiniz  her şey pandora camlı yatak',3999.99),(12,'YTK','Ultra Beyaz Komidin','Ultra beyaz komidin tam yatak odanıza göre ',249.99),(13,'YTK','Giyim Dolabı','Giyim dolabında bütün kıyafetlerini saklayabilirsiniz',4799.99),(14,'YMK','Altılı Kelebek Masa','Mutfağınız için uygun bir altılı masa',2999.99),(15,'YMK','Beymahome Beşli Masa','Son derece şık bir beşli masa',1999.99),(16,'YMK','Sekizli Kızılcık Masa','Tam misafirleriniz için sekizli masa',6999.99),(17,'YMK','Deri Kaplamalı Sandalye','Deri kaplamalı özel sandalye',699.99),(18,'CVG','Şimsek Mcqueen Yatağı','Her erkek çocuğunun hayali Şimşek Mcqueen yatağı',4899.99),(19,'CVG','Sinderalla Yatağı','Her kız çocuğunun hayali Sindirella yatağı',6999.99),(20,'CVG','Bebek Karyolası','Bebeğinizin rahatlığı için bebek karyolası',1999.99),(21,'CVG','Örümcek Adamlı Dolap','Oğlunuz için ideal dolap örümcek adamlı dolap',1299.99),(22,'BHE','Organik Masa','Bahçenize çok yakışacak organik masa',2999.99),(23,'BHE','Organik Sandalye','Organik masanızda oturmak için organik sandalye',149.99),(24,'BHE','Köpek Kulübesi','Köpeğiniz için ideal bir köpek kulübesi',499.99),(25,'BHE','Bahçe Cini Biblo','Bahçeniz için sevimli bir biblo',99.99);
/*!40000 ALTER TABLE `urun` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-05-03 16:49:55
