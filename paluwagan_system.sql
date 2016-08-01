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
INSERT INTO `paluwagan` VALUES ('2016-07-18','Umali, Christian Angelo ',1,50,1),('2016-07-19','Umali, Christian Angelo ',1,50,2),('2016-07-20','Umali, Christian Angelo ',1,50,3),('2016-07-21','Umali, Christian Angelo ',1,50,4),('2016-07-22','Umali, Christian Angelo ',1,50,5),('2016-07-18','Dinglasan, Janisse Crizhna',1,50,1),('2016-07-19','Dinglasan, Janisse Crizhna',1,50,2),('2016-07-20','Dinglasan, Janisse Crizhna',1,50,3),('2016-07-21','Dinglasan, Janisse Crizhna',1,50,4),('2016-07-22','Dinglasan, Janisse Crizhna',1,50,5),('2016-07-25','Umali, Christian Angelo ',2,50,6),('2016-07-26','Umali, Christian Angelo ',2,50,7),('2016-07-27','Umali, Christian Angelo ',2,50,8),('2016-07-28','Umali, Christian Angelo ',2,50,9),('2016-07-25','Dinglasan, Janisse Crizhna',2,50,6),('2016-07-26','Dinglasan, Janisse Crizhna',2,50,7),('2016-07-27','Dinglasan, Janisse Crizhna',2,50,8),('2016-07-28','Dinglasan, Janisse Crizhna',2,50,9),('2016-07-29','Dinglasan, Janisse Crizhna',2,50,10),('2016-07-29','Umali, Christian Angelo ',2,50,10),('2016-08-01','Umali, Christian Angelo ',3,50,11);
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

-- Dump completed on 2016-08-01 21:04:47
