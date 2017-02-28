-- MySQL dump 10.13  Distrib 5.6.26, for Win32 (x86)
--
-- Host: localhost    Database: clubdb
-- ------------------------------------------------------
-- Server version	5.6.26-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Current Database: `clubdb`
--

DROP DATABASE IF EXISTS `clubdb`;

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `clubdb` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `clubdb`;

--
-- Table structure for table `checkouts`
--

DROP TABLE IF EXISTS `checkouts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `checkouts` (
  `dateId` int(10) unsigned NOT NULL,
  `userId` int(10) unsigned NOT NULL,
  KEY `dateId` (`dateId`),
  KEY `userId` (`userId`),
  CONSTRAINT `checkouts_ibfk_1` FOREIGN KEY (`dateId`) REFERENCES `dates` (`id`) ON UPDATE CASCADE,
  CONSTRAINT `checkouts_ibfk_2` FOREIGN KEY (`userId`) REFERENCES `users` (`id`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `checkouts`
--

LOCK TABLES `checkouts` WRITE;
/*!40000 ALTER TABLE `checkouts` DISABLE KEYS */;
INSERT INTO `checkouts` VALUES (14,1),(15,1),(16,1),(14,3),(15,3);
/*!40000 ALTER TABLE `checkouts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dates`
--

DROP TABLE IF EXISTS `dates`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dates` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `date` int(10) unsigned NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dates`
--

LOCK TABLES `dates` WRITE;
/*!40000 ALTER TABLE `dates` DISABLE KEYS */;
INSERT INTO `dates` VALUES (11,1445814000),(12,1446418800),(13,1447023600),(14,1447628400),(15,1448233200),(16,1448838000),(17,1449442800),(18,1450047600),(19,1450652400);
/*!40000 ALTER TABLE `dates` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `uinfo`
--

DROP TABLE IF EXISTS `uinfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `uinfo` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `f_name` char(25) NOT NULL,
  `l_name` char(25) NOT NULL,
  `email` char(50) NOT NULL DEFAULT '-',
  `uid` int(10) unsigned NOT NULL,
  PRIMARY KEY (`id`),
  KEY `uid` (`uid`),
  CONSTRAINT `uinfo_ibfk_1` FOREIGN KEY (`uid`) REFERENCES `users` (`id`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `uinfo`
--

LOCK TABLES `uinfo` WRITE;
/*!40000 ALTER TABLE `uinfo` DISABLE KEYS */;
INSERT INTO `uinfo` VALUES (1,'Will','','-',1),(2,'Mackie','','',2),(3,'Anand','','',3),(4,'Peter','','',4),(5,'Andy','','',5),(6,'Joshua','','',6),(7,'Greg','','',7),(8,'Patrick','','',8),(9,'Kent','','',9),(10,'Tim','','',10),(11,'Hunter','','',11),(12,'Jeffrey','','',12);
/*!40000 ALTER TABLE `uinfo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `users` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `username` varchar(10) NOT NULL,
  `password` varchar(50) NOT NULL,
  `admin` int(10) unsigned NOT NULL DEFAULT '0',
  `superadmin` int(10) unsigned NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'Will','d033e22ae348aeb5660fc2140aec35850c4da997',1,1),(2,'Mackie','41f05f73b9b52430dc4051793026bf499a978c10',0,0),(3,'Anand','69814da605f59882f287965e82f04aac57445d90',0,0),(4,'Peter','64ca93f83bb29b51d8cbd6f3e6a8daff2e08d3ec',0,0),(5,'Andy','ab5a000e88b5d9d0fa2575f5c6263eb93452405d',0,0),(6,'Joshua','a9a2e8456bf9d58e91fe91cbfe10cad5211216c2',0,0),(7,'Greg','bc65ce8cc316901614469d203ed8eb95ff62d502',0,0),(8,'Patrick','57ad79649b677cf8f889ba6dc5fb4f98ada2767e',0,0),(9,'Kent','4e168a993c2a9a160b1273e3ff68301bc9640862',0,0),(10,'Tim','14e4f66c63dec110b448e011dcb0b57f70ec20c6',0,0),(11,'Hunter','147847d73ee819cfcbfaf4e907ce7370654b8248',0,0),(12,'Jeffrey','72886a8e7d21c637750593e98faf71cf54e683d1',0,0);
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2015-11-11  9:56:41
