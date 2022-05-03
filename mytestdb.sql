DROP DATABASE mytestdb;
CREATE DATABASE  IF NOT EXISTS `mytestdb` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `mytestdb`;

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



DROP TABLE IF EXISTS `Car`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Car` (
  `CarId` int NOT NULL AUTO_INCREMENT,
  `CarBrand` varchar(1000) NOT NULL,
  `CarType` varchar(1000) NOT NULL,
  `CarColor` varchar(1000) NOT NULL,
  `Ready` varchar(20) NOT NULL,
  PRIMARY KEY (`CarId`),
  UNIQUE KEY `CarId_UNIQUE` (`CarId`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;



LOCK TABLES `Car` WRITE;
/*!40000 ALTER TABLE `Car` DISABLE KEYS */;
INSERT INTO `Car` VALUES (1,'Toyota','Supra','Red','Yes'),(2,'Honda','NSX','Blue','No'),(3,'BMW','M3','Purple','No'),(4,'Lamborghini','Aventador','Black','No'),(5,'Corvette','Z06','Red','Yes'),(6,'Nissan','R34','Blue','No'),(7,'BMW','M4','Alpine White','Yes'),(8,'Nissan','370z','Silver','No');
/*!40000 ALTER TABLE `Car` ENABLE KEYS */;
UNLOCK TABLES;



DROP TABLE IF EXISTS `Customer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Customer` (
  `CustomerId` int NOT NULL AUTO_INCREMENT,
  `FirstName` varchar(20) NOT NULL,
  `LastName` varchar(30) NOT NULL,
  `CustomerPhone` varchar(15) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `CarId` int NOT NULL,
  PRIMARY KEY (`CarId`),
  UNIQUE KEY `CustomerId_UNIQUE` (`CustomerId`),
  UNIQUE KEY `CarId_UNIQUE` (`CarId`),
  KEY `CarId_idx` (`CarId`),
  CONSTRAINT `FK_CustomerCar` FOREIGN KEY (`CustomerId`) REFERENCES `Car` (`CarId`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;



LOCK TABLES `Customer` WRITE;
/*!40000 ALTER TABLE `Customer` DISABLE KEYS */;
INSERT INTO `Customer` VALUES (1,'Tom','Jerry','123456789','Tom@CatchJerry.com',1),(2,'Barack','Obama','781234334','BarackObama@gmail.com',2),(3,'Light','Yagami','981346781','WritingYourNameI@DeathNote.com',3),(4,'Ryan','Reynolds','324566723','BlakeIsMySecondWife@BettyWhite.org',4),(5,'Ken','Kaneki','322472993','Kaneki@TokyoGhoul.edu',5),(6,'ODESZA','Foreign','2342347181','foreignfamily@gmail.com',6),(7,'Bruce','Wayne','238723023','brucewayne@wayneenterprises.com',7),(8,'Captain','America','2342352323','CaptainAmerica@avengers.com',8);
/*!40000 ALTER TABLE `Customer` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

CREATE USER 'Welcome'@'host' IDENTIFIED  BY 'Password12';

