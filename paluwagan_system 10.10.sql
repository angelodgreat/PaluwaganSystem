CREATE DATABASE  IF NOT EXISTS `paluwagan_system` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `paluwagan_system`;
-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: localhost    Database: paluwagan_system
-- ------------------------------------------------------
-- Server version	5.7.9-log

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
-- Table structure for table `paluwagan`
--

DROP TABLE IF EXISTS `paluwagan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `paluwagan` (
  `date` date DEFAULT NULL,
  `contributor` varchar(100) DEFAULT NULL,
  `week` int(4) DEFAULT NULL,
  `amount` int(10) DEFAULT NULL,
  `day` int(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `paluwagan`
--

LOCK TABLES `paluwagan` WRITE;
/*!40000 ALTER TABLE `paluwagan` DISABLE KEYS */;
INSERT INTO `paluwagan` VALUES ('2016-07-18','Umali, Christian Angelo ',1,50,1),('2016-07-19','Umali, Christian Angelo ',1,50,2),('2016-07-20','Umali, Christian Angelo ',1,50,3),('2016-07-21','Umali, Christian Angelo ',1,50,4),('2016-07-22','Umali, Christian Angelo ',1,50,5),('2016-07-18','Dinglasan, Janisse Crizhna',1,50,1),('2016-07-19','Dinglasan, Janisse Crizhna',1,50,2),('2016-07-20','Dinglasan, Janisse Crizhna',1,50,3),('2016-07-21','Dinglasan, Janisse Crizhna',1,50,4),('2016-07-22','Dinglasan, Janisse Crizhna',1,50,5),('2016-07-25','Umali, Christian Angelo ',2,50,6),('2016-07-26','Umali, Christian Angelo ',2,50,7),('2016-07-27','Umali, Christian Angelo ',2,50,8),('2016-07-28','Umali, Christian Angelo ',2,50,9),('2016-07-25','Dinglasan, Janisse Crizhna',2,50,6),('2016-07-26','Dinglasan, Janisse Crizhna',2,50,7),('2016-07-27','Dinglasan, Janisse Crizhna',2,50,8),('2016-07-28','Dinglasan, Janisse Crizhna',2,50,9),('2016-07-29','Umali, Christian Angelo ',2,50,10),('2016-07-29','Dinglasan, Janisse Crizhna',2,50,10),('2016-08-01','Umali, Christian Angelo ',3,50,11),('2016-08-02','Umali, Christian Angelo ',3,50,12),('2016-08-03','Umali, Christian Angelo ',3,50,13),('2016-08-04','Umali, Christian Angelo ',3,50,14),('2016-08-05','Umali, Christian Angelo ',3,50,15),('2016-08-08','Umali, Christian Angelo ',4,50,16),('2016-08-09','Umali, Christian Angelo ',4,50,17),('2016-08-10','Umali, Christian Angelo ',4,50,18),('2016-08-11','Umali, Christian Angelo ',4,50,19),('2016-08-12','Umali, Christian Angelo ',4,50,20),('2016-08-15','Umali, Christian Angelo ',5,50,21),('2016-08-16','Umali, Christian Angelo ',5,50,22),('2016-08-17','Umali, Christian Angelo ',5,50,23),('2016-08-18','Umali, Christian Angelo ',5,50,24),('2016-08-19','Umali, Christian Angelo ',5,50,25),('2016-08-01','Dinglasan, Janisse Crizhna',3,50,11),('2016-08-02','Dinglasan, Janisse Crizhna',3,50,12),('2016-08-03','Dinglasan, Janisse Crizhna',3,50,13),('2016-08-04','Dinglasan, Janisse Crizhna',3,50,14),('2016-08-05','Dinglasan, Janisse Crizhna',3,50,15),('2016-08-08','Dinglasan, Janisse Crizhna',4,50,16),('2016-08-09','Dinglasan, Janisse Crizhna',4,50,17),('2016-08-10','Dinglasan, Janisse Crizhna',4,50,18),('2016-08-11','Dinglasan, Janisse Crizhna',4,50,19),('2016-08-12','Dinglasan, Janisse Crizhna',4,50,20),('2016-08-15','Dinglasan, Janisse Crizhna',5,50,21),('2016-08-16','Dinglasan, Janisse Crizhna',5,50,22),('2016-08-17','Dinglasan, Janisse Crizhna',5,50,23),('2016-08-18','Dinglasan, Janisse Crizhna',5,50,24),('2016-08-19','Dinglasan, Janisse Crizhna',5,50,25),('2016-08-22','Dinglasan, Janisse Crizhna',6,50,26),('2016-08-23','Dinglasan, Janisse Crizhna',6,50,27),('2016-08-24','Dinglasan, Janisse Crizhna',6,50,28),('2016-08-25','Dinglasan, Janisse Crizhna',6,50,29),('2016-08-26','Dinglasan, Janisse Crizhna',6,50,30),('2016-08-29','Dinglasan, Janisse Crizhna',7,50,31),('2016-08-30','Dinglasan, Janisse Crizhna',7,50,32),('2016-08-31','Dinglasan, Janisse Crizhna',7,50,33),('2016-09-01','Dinglasan, Janisse Crizhna',7,50,34),('2016-08-22','Umali, Christian Angelo ',6,50,26),('2016-08-23','Umali, Christian Angelo ',6,50,27),('2016-08-24','Umali, Christian Angelo ',6,50,28),('2016-08-25','Umali, Christian Angelo ',6,50,29),('2016-08-29','Umali, Christian Angelo ',7,50,31),('2016-08-26','Umali, Christian Angelo ',6,50,30),('2016-08-30','Umali, Christian Angelo ',7,50,32),('2016-08-31','Umali, Christian Angelo ',7,50,33),('2016-09-01','Umali, Christian Angelo ',7,50,34),('2016-09-02','Umali, Christian Angelo ',7,50,35),('2016-09-05','Umali, Christian Angelo ',8,50,36),('2016-09-06','Umali, Christian Angelo ',8,50,37),('2016-09-07','Umali, Christian Angelo ',8,50,38),('2016-09-08','Umali, Christian Angelo ',8,50,39),('2016-09-09','Umali, Christian Angelo ',8,50,40),('2016-09-12','Umali, Christian Angelo ',9,50,41),('2016-09-13','Umali, Christian Angelo ',9,50,42),('2016-09-14','Umali, Christian Angelo ',9,50,43),('2016-09-15','Umali, Christian Angelo ',9,50,44),('2016-09-16','Umali, Christian Angelo ',9,50,45),('2016-09-19','Umali, Christian Angelo ',10,50,46),('2016-09-20','Umali, Christian Angelo ',10,50,47),('2016-09-21','Umali, Christian Angelo ',10,50,48),('2016-09-22','Umali, Christian Angelo ',10,50,49),('2016-09-23','Umali, Christian Angelo ',10,50,50),('2016-09-26','Umali, Christian Angelo ',11,50,51),('2016-09-27','Umali, Christian Angelo ',11,50,52),('2016-09-27','Dinglasan, Janisse Crizhna',11,1000,52),('2016-09-28','Umali, Christian Angelo ',11,50,53),('2016-09-29','Umali, Christian Angelo ',11,50,54),('2016-09-30','Umali, Christian Angelo ',11,50,55),('2016-10-03','Umali, Christian Angelo ',12,50,56),('2016-10-04','Umali, Christian Angelo ',12,50,57),('2016-10-05','Umali, Christian Angelo ',12,50,58),('2016-10-06','Umali, Christian Angelo ',12,50,59),('2016-10-07','Umali, Christian Angelo ',12,50,60);
/*!40000 ALTER TABLE `paluwagan` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-10-10  7:39:40
