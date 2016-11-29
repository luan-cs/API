CREATE DATABASE  IF NOT EXISTS `pos_hdt` /*!40100 DEFAULT CHARACTER SET utf8 COLLATE utf8_unicode_ci */;
USE `pos_hdt`;
-- MySQL dump 10.13  Distrib 5.7.12, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: pos_hdt
-- ------------------------------------------------------
-- Server version	5.7.16-log

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
-- Table structure for table `commoncode`
--

DROP TABLE IF EXISTS `commoncode`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `commoncode` (
  `CommonTypeId` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `CommonId` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `StrValue1` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `StrValue2` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `NumValue1` decimal(20,0) DEFAULT NULL,
  `NumValue2` decimal(20,0) DEFAULT NULL,
  `CreatedBy` varchar(256) COLLATE utf8_unicode_ci DEFAULT NULL,
  `CreatedDate` datetime DEFAULT NULL,
  `ModifiedBy` varchar(256) COLLATE utf8_unicode_ci DEFAULT NULL,
  `ModifiedDate` datetime DEFAULT NULL,
  `CanDelete` bit(1) DEFAULT b'1',
  `ParentId` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `IsBuffet` varchar(1) COLLATE utf8_unicode_ci DEFAULT '0',
  PRIMARY KEY (`CommonTypeId`,`CommonId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `commoncode`
--

LOCK TABLES `commoncode` WRITE;
/*!40000 ALTER TABLE `commoncode` DISABLE KEYS */;
INSERT INTO `commoncode` VALUES ('BankName','03','VietcomBank','',NULL,NULL,'admin','2014-11-26 13:43:44','admin','2015-01-21 16:17:05','',NULL,'0'),('BankName','04','HuBank','1',NULL,NULL,'admin','2015-01-12 10:34:37','admin','2015-01-12 10:34:47','',NULL,'0'),('BankName','05','VietcomBank05',NULL,NULL,NULL,'admin','2015-01-20 11:48:16','admin',NULL,'','03','0'),('BankName','06','ngân hang test','',NULL,NULL,'admin','2015-01-20 16:35:37','admin','2015-01-21 08:50:30','',NULL,'0'),('BankName','07','ngân hang test07',NULL,NULL,NULL,'admin','2015-01-20 16:36:06',NULL,NULL,'','05','0'),('BankName','08','ngân hàng08',NULL,NULL,NULL,'admin','2015-01-20 16:38:08',NULL,NULL,'','06','0'),('BankName','10','ngan hang 10','',NULL,NULL,'admin','2015-01-20 16:58:06','admin','2015-01-20 17:14:34','','04','0'),('CardBankType','01','Connect 24h','03',NULL,NULL,'admin','2014-11-26 13:44:26','admin',NULL,'',NULL,'0'),('CardBankType','02','Visa','02',NULL,NULL,'admin','2014-11-26 13:44:52','admin',NULL,'',NULL,'0'),('DeskId','san pham - sp','sản phẩm mặt hàng trong công tyfffffffff','Test dữ liệu',45521,NULL,'admin','2014-08-22 13:18:45','admin','2014-08-22 13:19:00','',NULL,'0'),('DeskLocation','01','Tầng trệt',NULL,NULL,NULL,'admin','2014-12-04 17:04:04','admin',NULL,'',NULL,'0'),('DeskLocation','02','Tầng 1',NULL,NULL,NULL,'admin','2014-12-04 17:04:22','admin',NULL,'',NULL,'0'),('DeskLocation','03','Tầng 2',NULL,NULL,NULL,'admin','2015-01-22 10:51:28',NULL,NULL,'',NULL,'0'),('DeskType','0','Đang sử dụng',NULL,NULL,NULL,'admin','2014-09-04 09:05:59','admin',NULL,'\0',NULL,'0'),('DeskType','1','Đang sửa chữa',NULL,NULL,NULL,'admin','2014-09-04 09:06:17','admin',NULL,'\0',NULL,'0'),('Language','de-DE','Tiếng Đức','http://msdn.microsoft.com/en-us/library/ee825488(v=cs.20).aspx',NULL,NULL,'admin','2014-06-25 10:57:20','admin',NULL,'\0',NULL,'0'),('Language','en-US','Tiếng Anh - United States','http://msdn.microsoft.com/en-us/library/ee825488(v=cs.20).aspx',1255113,NULL,'admin','2014-06-25 10:57:20','admin','2014-09-03 10:52:27','\0',NULL,'0'),('Language','es-ES','Tiếng Tay Ban Nha','http://msdn.microsoft.com/en-us/library/ee825488(v=cs.20).aspx',NULL,NULL,'admin','2014-06-25 10:57:20','admin',NULL,'\0',NULL,'0'),('Language','fr-FR','Tiếng Pháp - France','http://msdn.microsoft.com/en-us/library/ee825488(v=cs.20).aspx',NULL,NULL,'admin','2014-06-25 10:57:20','admin',NULL,'\0',NULL,'0'),('Language','id-ID','Tiếng Indonesia','http://msdn.microsoft.com/en-us/library/ee825488(v=cs.20).aspx',1234,1234,'admin','2014-06-25 10:57:20','admin','2015-01-12 10:22:20','\0',NULL,'0'),('Language','it-IT','Tiếng Italy','http://msdn.microsoft.com/en-us/library/ee825488(v=cs.20).aspx',NULL,NULL,'admin','2014-06-25 10:57:20','admin',NULL,'\0',NULL,'0'),('Language','ja-JP','Tiếng Nhật','http://msdn.microsoft.com/en-us/library/ee825488(v=cs.20).aspx',NULL,NULL,'admin','2014-06-25 10:57:20','admin',NULL,'\0',NULL,'0'),('Language','ko-KR','Tiếng Hàn','http://msdn.microsoft.com/en-us/library/ee825488(v=cs.20).aspx',123123123123,NULL,'admin','2014-06-25 10:57:20','admin','2014-07-25 10:06:55','\0',NULL,'0'),('Language','ms-MY','Tiếng Malaysia','http://msdn.microsoft.com/en-us/library/ee825488(v=cs.20).aspx',NULL,NULL,'admin','2014-06-25 10:57:20','admin',NULL,'\0',NULL,'0'),('Language','ru-RU','Tiếng Nga','http://msdn.microsoft.com/en-us/library/ee825488(v=cs.20).aspx',NULL,NULL,'admin','2014-06-25 10:57:20','admin',NULL,'\0',NULL,'0'),('Language','th-TH','Tiếng Thái','http://msdn.microsoft.com/en-us/library/ee825488(v=cs.20).aspx',NULL,NULL,'admin','2014-06-25 10:57:20','admin',NULL,'\0',NULL,'0'),('Language','vi-VN','Tiếng Việt','http://msdn.microsoft.com/en-us/library/ee825488(v=cs.20).aspx',NULL,NULL,'admin','2014-06-25 10:57:20','admin',NULL,'\0',NULL,'0'),('Language','zh-CHS','Tiếng Trung giản thể','http://msdn.microsoft.com/en-us/library/ee825488(v=cs.20).aspx',NULL,NULL,'admin','2014-06-25 10:57:20','admin',NULL,'\0',NULL,'0'),('Language','zh-CHT','Tiếng Trung phồn thể','http://msdn.microsoft.com/en-us/library/ee825488(v=cs.20).aspx',NULL,NULL,'admin','2014-06-25 10:57:20','admin',NULL,'\0',NULL,'0'),('Language','zh-CN','Tiếng Trung China','http://msdn.microsoft.com/en-us/library/ee825488(v=cs.20).aspx',NULL,NULL,'admin','2014-06-25 10:57:20','admin',NULL,'\0',NULL,'0'),('Language','zh-HK','Tiếng Trung - Hong Kong SAR','http://msdn.microsoft.com/en-us/library/ee825488(v=cs.20).aspx',NULL,NULL,'admin','2014-06-25 10:57:20','admin',NULL,'\0',NULL,'0'),('Language','zh-SG','Tiếng Trung - Singapore','http://msdn.microsoft.com/en-us/library/ee825488(v=cs.20).aspx',NULL,NULL,'admin','2014-06-25 10:57:20','admin',NULL,'\0',NULL,'0'),('Language','zh-TW','Tiếng Trung - Đài Loan','http://msdn.microsoft.com/en-us/library/ee825488(v=cs.20).aspx',NULL,NULL,'admin','2014-06-25 10:57:20','admin',NULL,'\0',NULL,'0'),('ObjectGroup','01','Nhân viên',NULL,NULL,NULL,'admin','2014-06-25 10:57:20','admin','2014-08-11 15:54:06','\0',NULL,'0'),('ObjectGroup','03','Khách hàng',NULL,NULL,NULL,'admin','2014-08-20 09:27:07','admin',NULL,'',NULL,'0'),('ObjectGroup','25','Nhà cung cấp',NULL,NULL,NULL,'admin','2014-06-25 10:57:20','admin',NULL,'\0',NULL,'0'),('ObjectGroup','45','Ngân hàng',NULL,NULL,NULL,'admin','2014-06-25 10:57:20','admin',NULL,'\0',NULL,'0'),('ObjectType','01','Cá nhân',NULL,NULL,NULL,'admin','2014-06-25 10:57:20','admin',NULL,'\0',NULL,'0'),('ObjectType','02','Tổ chức',NULL,NULL,NULL,'admin','2014-06-25 10:57:20','admin',NULL,'\0',NULL,'0'),('PositionId','01','Nhân viên lễ tân2',NULL,NULL,NULL,'admin','2014-08-12 10:10:23','admin','2014-08-20 09:13:50','',NULL,'0'),('PositionId','02','Nhân viên bảo vệ','',NULL,NULL,'admin','2014-08-12 10:10:45','admin','2015-01-21 09:37:49','',NULL,'0'),('PositionId','03','Nhân viên quản lý',NULL,NULL,NULL,'admin','2014-08-12 10:11:05','admin',NULL,'',NULL,'0'),('PositionId','04','Nhân viên kế toán',NULL,NULL,NULL,'admin','2014-08-12 12:06:21','admin',NULL,'',NULL,'0'),('ProductType','01','Thuc an',NULL,NULL,NULL,'admin','2016-11-06 15:17:27',NULL,NULL,'',NULL,'0'),('ProductType','02','Thuc uong',NULL,NULL,NULL,'admin','2016-11-06 15:18:27',NULL,NULL,'',NULL,'0'),('ProductType','03','SP Them',NULL,NULL,NULL,'admin','2016-11-06 15:18:51',NULL,NULL,'',NULL,'0'),('ProductType','04','Loai khac',NULL,NULL,NULL,'admin','2016-11-06 15:19:52',NULL,NULL,'',NULL,'0'),('RoleId','02','Quyền admin','admin',123456,123456,'admin','2014-08-04 17:28:40','admin','2014-08-04 17:28:54','\0',NULL,'0'),('RoleId','03','Quyền admin','admin',123456,123456,'admin','2014-08-04 17:29:00','admin',NULL,'\0',NULL,'0'),('VNLocation','02','TP Hồ Chí Minh',NULL,NULL,NULL,'admin','2014-07-16 15:02:44','admin',NULL,'\0',NULL,'0'),('VNLocation','25','Tỉnh Ninh Bình',NULL,NULL,NULL,'admin','2014-07-16 15:02:44','admin',NULL,'\0',NULL,'0'),('VNLocation','58','Tỉnh Bạc Liêu',NULL,NULL,NULL,'admin','2014-07-16 15:02:44','admin',NULL,'\0',NULL,'0');
/*!40000 ALTER TABLE `commoncode` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `tgInsert_CommonCode` AFTER INSERT ON `commoncode` FOR EACH ROW BEGIN
	CALL spInsert_UserActionHistory (
    NEW.`CreatedBy`,
    CONCAT(
      'Table:commoncode|CommonTypeId=' , NEW.`CommonTypeId`,'|CommonId=',NEW.`CommonId`),
    'INSERT',
    'StrValue1 | StrValue2| NumValue1 | NumValue2 | CanDelete| ParentId',
    CONCAT(
      IFNULL(NEW.`StrValue1`, ''),
      ' | ',
      IFNULL(NEW.`StrValue2`, ''),
      ' |',
      IFNULL(NEW.`NumValue1`, ''),
      ' | ',
      IFNULL(NEW.`NumValue2`, ''),
      ' | ',
      IFNULL(NEW.`CanDelete`, ''),
      '|',
      IFNULL(NEW.`ParentId`, '')
    )
  ) ;
    END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `tgUpdate_CommonCode` AFTER UPDATE ON `commoncode` FOR EACH ROW BEGIN
	CALL spInsert_UserActionHistory (
    NEW.`ModifiedBy`,
    CONCAT(
      'Table:commoncode|CommonTypeId=' , NEW.`CommonTypeId`,' | CommonId=',NEW.`CommonId`),
    'UPDATE',
    'StrValue1 | StrValue2| NumValue1 | NumValue2 | CanDelete| ParentId',
    CONCAT(
      IFNULL(NEW.`StrValue1`, ''),
      ' | ',
      IFNULL(NEW.`StrValue2`, ''),
      ' |',
      IFNULL(NEW.`NumValue1`, ''),
      ' | ',
      IFNULL(NEW.`NumValue2`, ''),
      ' | ',
      IFNULL(NEW.`CanDelete`, ''),
      '|',
      IFNULL(NEW.`ParentId`, '')
    )
  ) ;
    END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `commontype`
--

DROP TABLE IF EXISTS `commontype`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `commontype` (
  `CommonTypeId` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `Description` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Note` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `CreatedBy` varchar(256) COLLATE utf8_unicode_ci DEFAULT NULL,
  `CreatedDate` datetime DEFAULT NULL,
  `ModifiedBy` varchar(256) COLLATE utf8_unicode_ci DEFAULT NULL,
  `ModifiedDate` datetime DEFAULT NULL,
  `CanDelete` bit(1) DEFAULT b'1',
  `TableColumUser` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`CommonTypeId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `commontype`
--

LOCK TABLES `commontype` WRITE;
/*!40000 ALTER TABLE `commontype` DISABLE KEYS */;
INSERT INTO `commontype` VALUES ('BankName','Tên ngân hàng1','Hiển thị lên màn hình thanh toán bằng thẻ ngân hàng','admin','2014-11-26 13:38:44','admin','2014-12-02 10:41:04','','receiptscard,Bank'),('Card','Phát triển về card 1','Mô tả bảng CardId_1','admin','2014-09-03 11:21:12',NULL,'2014-12-24 10:12:35','',NULL),('CardBankType','Các loại thẻ của ngân hàng','Hiển thị lên màn hình thanh toán bằng thẻ ngân hàng','admin','2014-11-26 13:39:41','admin',NULL,'','receiptscard,CardType'),('CardType','Loại thẻ 1','Loại card note','admin','2014-06-29 16:55:16',NULL,'2015-01-12 10:35:57','\0',NULL),('CountryCode','Mã quốc gia','','admin','2014-07-15 16:59:37',NULL,'2014-07-22 16:08:54','\0',NULL),('DeskId','Phát triển phần mềm','Ghi chú phần mềm phát triển','admin','2014-08-11 16:35:12',NULL,'2014-08-11 16:35:20','',NULL),('DeskIDType','Phát triển phần mềm','phần mềm','admin','2014-09-03 11:02:04',NULL,NULL,'',NULL),('DeskLocation','Vị trí đặt bàn','Vị trí đặt bàn 1','admin','2014-12-04 17:03:17','admin',NULL,'','desk,DeskLocation'),('DeskType','Trạng thái bàn','80','admin','2014-06-29 16:55:16','admin','2014-08-20 09:20:44','\0','desk,Status'),('Language','Bán hàng-Thuận phát triển1','Ghi chú để phát triển','admin','2014-07-15 16:48:30',NULL,'2014-12-23 17:14:38','\0',NULL),('LanguagesIDType','Phát triển phần mềm để xem sao','Ghi chú phát triển phần mềm','admin','2014-08-11 16:40:28',NULL,'2014-08-12 14:29:01','',NULL),('MemberType','Loại thành viên','bảng Member','admin','2014-07-15 17:11:52',NULL,'2014-08-11 19:37:10','\0',NULL),('Nationality','Quốc tịch','Bảng receiptinfo','admin','2014-08-12 11:56:45',NULL,NULL,'',NULL),('ObjectGroup','Nhóm Đối tượng','Bảng Object','admin','2014-07-15 17:12:29',NULL,'2014-07-22 16:09:49','\0',NULL),('ObjectType','Loại đối tượng (cá nhân, tổ chức...)','Bảng Object','admin','2014-07-15 17:12:29',NULL,'2014-07-22 16:10:16','\0',NULL),('PositionId','Mã vị trí công việc','Bảng Employees','admin','2014-07-19 16:13:01',NULL,'2014-07-22 16:11:20','\0',NULL),('ProductType','Loại sản phẩm','Bang Products','admin','2014-06-20 13:20:15','admin','2015-01-28 15:17:14','\0','products,ProductType'),('RoleId','Quyền của người sử dụng','Bảng users','admin','2014-07-22 16:17:45',NULL,NULL,'\0',NULL),('TestCommonType','Test common type','Test common type note','admin','2014-12-18 09:03:26',NULL,NULL,'',NULL),('VNLocation','Mã tỉnh, thành phố , quận huyện ở VN','','admin','2014-07-16 14:59:46',NULL,'2014-08-12 14:01:41','\0',NULL);
/*!40000 ALTER TABLE `commontype` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `tgInsert_CommonType` AFTER INSERT ON `commontype` FOR EACH ROW BEGIN
	CALL spInsert_UserActionHistory (
    NEW.`CreatedBy`,
    CONCAT(
      'Table:commontype|CommonTypeId=' , NEW.`CommonTypeId`),
    'INSERT',
    'Description | Note | CanDelete',
    CONCAT(
      IFNULL(NEW.`Description`, ''),
      ' | ',
      IFNULL(NEW.`Note`, ''),
      ' |',
      IFNULL(NEW.`CanDelete`, '')
    )
  ) ;
    END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `spUpdate_CommonType` AFTER UPDATE ON `commontype` FOR EACH ROW BEGIN
CALL spInsert_UserActionHistory (
    NEW.`ModifiedBy`,
    CONCAT(
      'Table:commontype|CommonTypeId=' , NEW.`CommonTypeId`),
    'UPDATE',
    'Description | Note | CanDelete',
    CONCAT(
      IFNULL(NEW.`Description`, ''),
      ' | ',
      IFNULL(NEW.`Note`, ''),
      ' | ',
      IFNULL(NEW.`CanDelete`, '')
    )
  ) ;
    END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Temporary view structure for view `convert_measure_to_product`
--

DROP TABLE IF EXISTS `convert_measure_to_product`;
/*!50001 DROP VIEW IF EXISTS `convert_measure_to_product`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `convert_measure_to_product` AS SELECT 
 1 AS `IngredientId`,
 1 AS `MeasureQty`,
 1 AS `ProductId`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `dem`
--

DROP TABLE IF EXISTS `dem`;
/*!50001 DROP VIEW IF EXISTS `dem`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `dem` AS SELECT 
 1 AS `Name`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `ingredient`
--

DROP TABLE IF EXISTS `ingredient`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ingredient` (
  `IngredientId` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `IngredientName` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `IngredientMeasure` int(11) DEFAULT NULL,
  `IngredientExchange` decimal(20,0) DEFAULT NULL,
  `IngredientUnit` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `IntakeUnit` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`IngredientId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ingredient`
--

LOCK TABLES `ingredient` WRITE;
/*!40000 ALTER TABLE `ingredient` DISABLE KEYS */;
INSERT INTO `ingredient` VALUES ('992016110700001','Đương',26,156564,'thìa','ha'),('992016110700002','cafe',5,3100,'gam',NULL),('992016110700003','ơt',10,210,'trái',NULL),('992016110800001','Sugar',1,1000,'gam',NULL),('992016110800002','Cafe',1,1000,'gam',NULL),('992016112800001','Alibaba',1212,875,'GAM',NULL),('992016112800002','xxx',1,1,'yyy',NULL),('992016113000001','wefff',20,10,'w','f');
/*!40000 ALTER TABLE `ingredient` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `input`
--

DROP TABLE IF EXISTS `input`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `input` (
  `InputId` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `Ballot` varchar(10) COLLATE utf8_unicode_ci DEFAULT NULL,
  `BallotDate` date DEFAULT NULL,
  `ReceiptId` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `ReceiptDate` datetime DEFAULT NULL,
  `SupplierId` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `StoreId` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Paid` tinyint(1) DEFAULT NULL,
  `InputDiscount` decimal(5,2) DEFAULT NULL,
  `InputNote` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `InputVAT` int(11) DEFAULT NULL,
  `CreatedBy` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `CreatedDate` datetime DEFAULT NULL,
  PRIMARY KEY (`InputId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `input`
--

LOCK TABLES `input` WRITE;
/*!40000 ALTER TABLE `input` DISABLE KEYS */;
INSERT INTO `input` VALUES ('081611000001','wwww','2016-11-27','lllll','2016-11-27 00:00:00','01011407000011','1',1,11.00,'bnbm',10,'admin',NULL),('081611000002','wwww','2016-11-27','lllll','2016-11-27 00:00:00','01011407000011','1',1,11.00,'bnbm',10,'admin',NULL),('081611000003','wwww','2016-11-27','lllll','2016-11-27 00:00:00','01011407000011','1',1,11.00,'bnbm',10,'admin',NULL),('081611000004','wwww','2016-11-27','lllll','2016-11-27 00:00:00','01011407000011','1',1,11.00,'bnbm',10,'admin',NULL),('081611000005','wwww','2016-11-27','lllll','2016-11-27 00:00:00','01011407000011','1',1,11.00,'bnbm',10,'admin',NULL),('081611000006','wwww','2016-11-27','lllll','2016-11-27 00:00:00','01011407000011','1',1,11.00,'bnbm',10,'admin',NULL),('081611000007','wwww','2016-11-27','lllll','2016-11-27 00:00:00','01011407000011','1',1,11.00,'bnbm',10,'admin',NULL),('081611000008','wwww','2016-11-27','lllll','2016-11-27 00:00:00','01011407000011','1',1,11.00,'bnbm',10,'admin',NULL),('081611000009','wwww','2016-11-27','lllll','2016-11-27 00:00:00','01011407000011','1',1,11.00,'bnbm',10,'admin',NULL),('081611000010','wwww','2016-11-27','lllll','2016-11-27 00:00:00','01011407000011','1',1,11.00,'bnbm',10,'admin',NULL),('081611000011','wwww','2016-11-27','lllll','2016-11-27 00:00:00','01011407000011','1',1,11.00,'bnbm',10,'admin',NULL),('081611000012','wwww','2016-11-27','lllll','2016-11-27 00:00:00','01011407000011','1',1,11.00,'bnbm',10,'admin',NULL);
/*!40000 ALTER TABLE `input` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `inputdetail`
--

DROP TABLE IF EXISTS `inputdetail`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `inputdetail` (
  `InputId` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `IngredientId` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `IngredientExpDate` date DEFAULT NULL,
  `IngredientQty` decimal(20,0) DEFAULT NULL,
  `IngredientPrice` decimal(20,0) DEFAULT NULL,
  `IngredientVat` decimal(20,0) DEFAULT NULL,
  `IngredientDiscount` decimal(20,0) DEFAULT NULL,
  PRIMARY KEY (`InputId`,`IngredientId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `inputdetail`
--

LOCK TABLES `inputdetail` WRITE;
/*!40000 ALTER TABLE `inputdetail` DISABLE KEYS */;
INSERT INTO `inputdetail` VALUES ('081611000002','992016110700001','2016-11-07',20,200000,10,10),('081611000002','992016110700002','2016-11-26',2,15000,10,10),('081611000007','992016110800001','2016-11-08',30,150000,NULL,NULL),('081611000007','992016110800002','2016-11-08',50,90000,NULL,NULL),('081611000008','992016110800001','2016-11-08',30,20000,NULL,NULL),('081611000009','992016110700001','2016-11-23',22313,555,1,2),('081611000009','992016110800002','2016-11-17',435,3,5,NULL),('081611000010','992016110700001','2016-11-27',123,546,NULL,NULL),('081611000011','992016110700002','2016-11-28',1,1,11,1),('081611000011','992016112800001','2016-11-28',123,334,1,1),('081611000012','992016110700001','2016-11-29',NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `inputdetail` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `intake`
--

DROP TABLE IF EXISTS `intake`;
/*!50001 DROP VIEW IF EXISTS `intake`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `intake` AS SELECT 
 1 AS `IngredientId`,
 1 AS `totalBuy`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `inventory`
--

DROP TABLE IF EXISTS `inventory`;
/*!50001 DROP VIEW IF EXISTS `inventory`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `inventory` AS SELECT 
 1 AS `IngredientId`,
 1 AS `IngredientName`,
 1 AS `IngredientUnit`,
 1 AS `TotalSold`,
 1 AS `TotalBought`,
 1 AS `Inventory`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `measure`
--

DROP TABLE IF EXISTS `measure`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `measure` (
  `MeasureId` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `ProductId` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `MeasureNote` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `CreatedBy` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `CreatedDate` datetime DEFAULT NULL,
  PRIMARY KEY (`MeasureId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `measure`
--

LOCK TABLES `measure` WRITE;
/*!40000 ALTER TABLE `measure` DISABLE KEYS */;
INSERT INTO `measure` VALUES ('071611000001','031611000001',NULL,'admin',NULL),('071611000002','031611000002',NULL,'admin',NULL),('071611000003','031611000006',NULL,'admin',NULL),('071611000004','031611000005',NULL,'admin',NULL);
/*!40000 ALTER TABLE `measure` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `measuredetail`
--

DROP TABLE IF EXISTS `measuredetail`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `measuredetail` (
  `MeasureId` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `IngredientId` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `MeasureQty` decimal(20,0) DEFAULT NULL,
  PRIMARY KEY (`MeasureId`,`IngredientId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `measuredetail`
--

LOCK TABLES `measuredetail` WRITE;
/*!40000 ALTER TABLE `measuredetail` DISABLE KEYS */;
INSERT INTO `measuredetail` VALUES ('','992016110700001',1),('071611000001','992016110700001',53222352254),('071611000001','992016110700003',78),('071611000002','992016110800002',778),('071611000003','992016110700001',332),('071611000004','992016110700001',45),('071611000004','992016110700002',1),('071611000004','992016110800001',1),('071611000004','992016110800002',1),('071611000004','992016112800001',1),('071611000004','992016112800002',1);
/*!40000 ALTER TABLE `measuredetail` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `objects`
--

DROP TABLE IF EXISTS `objects`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `objects` (
  `ObjectId` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `ObjectGroup` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `ObjectType` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `FullName` varchar(200) COLLATE utf8_unicode_ci DEFAULT NULL,
  `PID` varchar(40) COLLATE utf8_unicode_ci DEFAULT NULL,
  `PIDDate` datetime DEFAULT NULL,
  `PIDIssue` varchar(150) COLLATE utf8_unicode_ci DEFAULT NULL,
  `DoB` datetime DEFAULT NULL,
  `PoB` varchar(250) COLLATE utf8_unicode_ci DEFAULT NULL,
  `PerAdd` varchar(250) COLLATE utf8_unicode_ci DEFAULT NULL,
  `TemAdd` varchar(250) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Gender` bit(1) DEFAULT NULL,
  `Image` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `ProvinceId` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Tel` varchar(150) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Fax` varchar(150) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Email` varchar(250) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Website` varchar(250) COLLATE utf8_unicode_ci DEFAULT NULL,
  `TaxCode` varchar(60) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Note` text COLLATE utf8_unicode_ci,
  `Status` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `CreatedBy` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `CreatedDate` datetime DEFAULT NULL,
  `ModifiedBy` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `ModifiedDate` datetime DEFAULT NULL,
  PRIMARY KEY (`ObjectId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `objects`
--

LOCK TABLES `objects` WRITE;
/*!40000 ALTER TABLE `objects` DISABLE KEYS */;
INSERT INTO `objects` VALUES ('01011407000002','01','01','Nguyễn Văn D_7_8','385429763','2014-06-17 18:05:46','rtrt','2014-07-17 18:05:46','sdfa','sdf','Quận Tân Bình,Hồ Chí Minh','','01011407000002_140820093430.png','25','(848) 3929 0999',NULL,'tranmanhhungcntt2@gmail.com',NULL,'b',NULL,'5','admin','2014-07-17 18:04:10','admin','2014-09-03 11:34:35'),('01011407000004','01',NULL,'Nguyễn Văn B','123','1999-05-19 16:01:05','rtrt','1989-12-13 18:20:52','Hồ Chí Minh','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ','H? Chí Minh','',NULL,'01','(848) 3929 0999',NULL,'tranmanhhungcntt@gmail.com',NULL,NULL,NULL,'5','admin','2014-07-17 18:09:05',NULL,NULL),('01011407000005','01','02','Nguyễn thị Thị','1234','1999-05-19 16:01:05','rtrtr','1989-12-13 18:20:52','Hồ Chí Minh','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ','H? Chí Minh','',NULL,'01','(848) 3929 0999',NULL,'tranmanhhungcntt@gmail.com',NULL,NULL,NULL,'5','admin','2014-07-17 18:10:19','admin','2014-09-03 11:56:34'),('01011407000006','01','01','Hùng','385429763','1999-05-19 16:01:05','rtr','1989-12-13 18:20:52','Ha Noi','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ','H? Chí Minh','\0','01011407000006_140718093722.png','02','(848) 3929 0999',NULL,'tranmanhhungcntt@gmail.com',NULL,NULL,NULL,NULL,'admin','2014-07-17 18:14:37','admin','2014-07-18 09:35:05'),('01011407000008','01','01','385429763','111','2002-06-01 16:00:43','rtrtr','1989-12-13 18:20:52','Hồ Chí Minh','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ','H? Chí Minh','\0',NULL,'58','(848) 3929 0999',NULL,'tranmanhhungcntt@gmail.com',NULL,NULL,NULL,NULL,'admin','2014-07-24 15:57:18','admin','2014-07-25 15:41:15'),('01011407000009','01','01','Trần Mạnh Hùng','385429763','2009-09-16 18:20:52','Ninh Bình','1989-12-13 18:20:52','Ninh Bình','Ninh Bình','Hồ Chí Minh','\0','01011407000009_140904180021.png','58','0949372405','0949371312','tranmanhhungcntt@gmail.com','comoiso.com.vn','385429763','','1','admin','2014-07-17 18:20:53','admin','2014-09-04 17:58:34'),('01011407000011','25','02','Nguyễn Ngọc Kim Thuận','0112232554544','2009-09-17 18:20:52','bình thu?n','1989-12-12 18:20:52','Bình Thu?n','Bình Thu?n','H? Chí Minh','','01011407000011_140725092450.png','02','01639220714','01639220714','tranmanhhungcntt@gmail.com','comoiso.com.vn','385429763','không có mô t?','1','admin','2014-07-17 18:20:53','admin','2014-09-03 11:33:25'),('01011407000012','01','01','Mai Đức Hùng','385429763','2009-09-16 18:20:52','B?c Liêu','1989-12-13 18:20:52','B?c Liêu','B?c Liêu','H? Chí Minh','\0',NULL,'58','0949372405','0949371312','tranmanhhungcntt@gmail.com','comoiso.com.vn','385429763','Hittle','1','admin','2014-07-17 18:20:53','admin','2014-09-03 11:24:04'),('01011407000013','01','01','Mai ??c Anh','385429763','2009-09-16 18:20:52','B?c Liêu','1989-12-13 18:20:52','B?c Liêu','B?c Liêu','H? Chí Minh','',NULL,'02','0949372405','0949371312','tranmanhhungcntt@gmail.com','comoiso.com.vn','385429763','','1','admin','2014-07-17 18:20:53','admin','2014-09-04 13:00:16'),('01011407000014','01','01','Mai ??c Anh','385429763','2009-09-16 18:20:52','B?c Liêu','1989-12-13 18:20:52','B?c Liêu','B?c Liêu','H? Chí Minh','\0',NULL,'58','0949372405','0949371312','tranmanhhungcntt@gmail.com','comoiso.com.vn','385429763','Hittle','1','admin','2014-07-17 18:20:53','admin','2014-07-17 18:23:59'),('01011407000015','01','01','Mai ??c Anh','385429763','2009-09-16 18:20:52','B?c Liêu','1989-12-13 18:20:52','B?c Liêu','B?c Liêu','H? Chí Minh','\0',NULL,'58','0949372405','0949371312','tranmanhhungcntt@gmail.com','comoiso.com.vn','385429763','Hittle','1','admin','2014-07-17 18:20:53','admin','2014-07-17 18:23:59'),('01011407000016','01','01','Mai ??c Anh','385429763','2009-09-16 18:20:52','B?c Liêu','1989-12-13 18:20:52','B?c Liêu','B?c Liêu','H? Chí Minh','\0',NULL,'58','0949372405','0949371312','tranmanhhungcntt@gmail.com','comoiso.com.vn','385429763','Hittle','1','admin','2014-07-17 18:20:53','admin','2014-07-17 18:23:59'),('01011407000017','01','01','Mai ??c Anh','385429763','2009-09-16 18:20:52','B?c Liêu','1989-12-13 18:20:52','B?c Liêu','B?c Liêu','H? Chí Minh','\0',NULL,'58','0949372405','0949371312','maiducanh1989@gmail.com','comoiso.com.vn','385429763','Hittle','1','admin','2014-07-17 18:20:53','admin','2014-07-17 18:23:59'),('01011407000018','01','01','Mai ??c Anh','385429763','2009-09-16 18:20:52','B?c Liêu','1989-12-13 18:20:52','B?c Liêu','B?c Liêu','H? Chí Minh','\0',NULL,'58','0949372405','0949371312','tranmanhhungcntt@gmail.com','comoiso.com.vn','385429763','Hittle','1','admin','2014-07-17 18:20:53','admin','2014-07-17 18:23:59'),('01011407000019','25','01','Hồ Ngọc Nguyên','0112232554544','1999-05-19 16:01:05','Hà Nội','1989-12-13 18:20:52','Hồ Chí Minh','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ','H? Chí Minh','\0',NULL,'25','(848) 3929 0999',NULL,'acb@acb.com.vn',NULL,NULL,NULL,'1','admin','2014-07-24 15:57:36',NULL,NULL),('01011407000021','25','02','Tạ Thành Trung','0112232554544','2009-09-19 18:20:52','Hà Nội','1990-03-16 18:20:52','Phát triển phần mềm để test-casce','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ','rrrrrr','\0',NULL,'25','rrrrrrrrrr','rrrrrrrrrr','rrrrrrrr','rrrrrrrrr','rrrrrrrrr',NULL,'1','admin','2014-07-24 15:57:46','admin','2014-08-11 17:59:48'),('01011407000023','01','01','Cao Văn Bằng','0112232554544','1999-05-19 16:01:05','Hà Nội','1989-12-13 18:20:52','Hồ Chí Minh','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ','H? Chí Minh','\0',NULL,'58','(848) 3929 0999',NULL,'acb@acb.com.vn',NULL,NULL,NULL,'1','admin','2014-07-25 09:40:26','admin','2014-07-25 09:40:50'),('01011407000024','01','01','B','0112232554544','1999-05-19 16:01:05','Hà Nội','1989-12-13 18:20:52','Hồ Chí Minh','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ','H? Chí Minh','\0',NULL,'58','(848) 3929 0999',NULL,'acb@acb.com.vn',NULL,NULL,NULL,'1','admin','2014-07-25 09:40:53','admin','2014-07-25 09:40:57'),('01011407000025','01','01','V','0112232554544','1999-05-19 16:01:05','Hà Nội','1989-12-13 18:20:52','Hồ Chí Minh','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ','H? Chí Minh','\0',NULL,'58','(848) 3929 0999',NULL,'acb@acb.com.vn',NULL,NULL,NULL,'1','admin','2014-07-25 09:40:59',NULL,NULL),('01011407000026','01','01','1','0112232554544','1999-05-19 16:01:05','Hà Nội','1989-12-13 18:20:52','Hồ Chí Minh','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ','H? Chí Minh','\0',NULL,'58','(848) 3929 0999',NULL,'acb@acb.com.vn',NULL,NULL,NULL,'1','admin','2014-07-25 09:41:01',NULL,NULL),('01011407000027','01','01','2','0112232554544','2014-07-16 09:48:19','Hà Nội','2014-07-01 09:48:19','kkkkk','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ','k','\0',NULL,'02','(848) 3929 0999',NULL,'vacb@acb.com.vn','g',NULL,'k','5','admin','2014-07-25 09:48:01','admin','2014-07-25 09:48:13'),('01011407000028','25','01','3','0112232554544','1999-05-19 16:01:05','Hà Nội','1989-12-13 18:20:52','Hồ Chí Minh','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ','H? Chí Minh',NULL,NULL,'25','(848) 3929 0999',NULL,'acb@acb.com.vn',NULL,NULL,NULL,'1','admin','2014-07-26 19:50:39','admin','2014-07-26 19:50:45'),('01011408000001','25','01','4','0112232554544','1999-05-19 16:01:05','Hà Nội','1989-12-13 18:20:52','Hồ Chí Minh','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ','H? Chí Minh',NULL,NULL,'25','(848) 3929 0999',NULL,'acb@acb.com.vn',NULL,NULL,NULL,'1','admin','2014-08-04 18:36:16','admin','2014-08-04 18:36:34'),('01011408000002','25','01','5','0112232554544','1999-05-19 16:01:05','Hồ Chí Minh','1989-12-13 18:20:52','Hồ Chí Minh','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ','H? Chí Minh',NULL,NULL,'25','(848) 3929 0999',NULL,'acb@acb.com.vn',NULL,NULL,NULL,'1','admin','2014-08-04 18:55:01','admin','2014-08-04 18:55:15'),('01011408000003','01','02','6','0112232554544','1999-05-19 16:01:05','Hồ Chí Minh','1989-12-13 18:20:52','Hồ Chí Minh','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ','H? Chí Minh',NULL,NULL,'25','(848) 3929 0999',NULL,'acb@acb.com.vn',NULL,NULL,NULL,'5','admin','2014-08-04 18:55:24','admin','2014-09-03 11:41:21'),('01011408000004','01','02','7','0112232554544','1999-05-19 16:01:05','Hồ Chí Minh','1989-12-13 18:20:52','Hồ Chí Minh','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ','H? Chí Minh',NULL,NULL,'25','(848) 3929 0999',NULL,'acb@acb.com.vn',NULL,NULL,NULL,'1','admin','2014-08-04 18:57:26',NULL,NULL),('01011408000005','01','02','x','112225554','2009-09-18 18:20:52','Hồ Chí Minh','1988-02-02 18:20:52','Bình Thuận','34, Nhất Chi Mai, Tân Bình ','34, Nhất Chi Mai, Tân Bình ',NULL,NULL,'25','ddđ','ddd','tranmanhhungcntt@gmail.com',NULL,NULL,NULL,'1','admin','2014-08-04 19:00:06','admin','2014-08-04 19:01:17'),('01011408000006','25','02','df','0112232554544','1999-05-19 16:01:05','Hồ Chí Minh','1989-12-13 18:20:52','Hồ Chí Minh','34, Nhất Chi Mai, Tân Bình ','H? Chí Minh',NULL,NULL,'5','(848) 3929 0999',NULL,'tranmanhhungcntt@gmail.com',NULL,NULL,NULL,'1','admin','2014-08-08 16:16:21',NULL,NULL),('01011408000007','25','02','sfs','0112232554544','1999-05-19 16:01:05','Hồ Chí Minh','1989-12-13 18:20:52','Hồ Chí Minh','34, Nhất Chi Mai, Tân Bình ','H? Chí Minh',NULL,NULL,'25','(848) 3929 0999',NULL,'tranmanhhungcntt@gmail.com',NULL,NULL,NULL,'1','admin','2014-08-11 17:18:35',NULL,NULL),('01011408000008','01','02','dfd','0112232554544','1999-05-19 16:01:05','Hồ Chí Minh','1989-12-13 18:20:52','Hồ Chí Minh','34, Nhất Chi Mai, Tân Bình ','H? Chí Minh',NULL,NULL,'25','(848) 3929 0999',NULL,'acb@acb.com.vn',NULL,NULL,NULL,'1','admin','2014-08-11 17:19:06','admin','2014-08-11 17:19:28'),('01011408000009','01','01','dfd','0112232554544','1999-05-19 16:01:05','Hồ Chí Minh','1989-12-13 18:20:52','Hồ Chí Minh','34, Nhất Chi Mai, Tân Bình ','H? Chí Minh',NULL,NULL,'25','(848) 3929 0999',NULL,'tranmanhhungcntt@gmail.com',NULL,NULL,NULL,'1','admin','2014-08-11 17:24:59',NULL,NULL),('01011408000010','01','01','sfsfsđf','0112232554544','1999-05-19 16:01:05','Hồ Chí Minh','1989-12-13 18:20:52','Hồ Chí Minh','34, Nhất Chi Mai, Tân Bình ','H? Chí Minh',NULL,NULL,'25','(848) 3929 0999',NULL,'tranmanhhungcntt@gmail.com',NULL,NULL,NULL,'1','admin','2014-08-11 17:25:11',NULL,NULL),('01011408000011','01','01','sfsdf','0112232554544','2014-06-02 16:44:20','Hồ Chí Minh','2014-01-24 16:44:20','Liên Hương - Tuy Phong','Test-Demo-Thuận','H? Chí Minh',NULL,NULL,'25','(848) 3929 0999',NULL,'acb@acb.com.vn',NULL,NULL,NULL,'1','admin','2014-08-11 17:34:48',NULL,NULL),('01011408000012','01','01','dfdfdg','0112232554544','2009-08-05 18:20:52','Hồ Chí Minh','1989-12-23 18:20:52','ggggggggggg','48/12 - Liên Hương - Tuy Phong - Bình Thuận','gggggggg','\0',NULL,'02','dddd','dddddd','acb@acb.com.vn','dddddd',NULL,NULL,'1','admin','2014-08-11 17:49:09','admin','2014-08-11 17:54:47'),('01011408000013','01','01','fdfdfsđfsđ','0112232554544','1999-05-19 16:01:05','Hồ Chí Minh','1989-12-13 18:20:52','Hồ Chí Minh','48/12 - Liên Hương - Tuy Phong - Bình Thuận','H? Chí Minh','\0',NULL,'25','(848) 3929 0999',NULL,'acb@acb.com.vn',NULL,NULL,NULL,'5','admin','2014-08-11 18:04:38',NULL,NULL),('01011408000014','25','02','g','b','1999-05-19 16:01:05','c','1989-12-13 18:20:52','Bình Thu?n','e','f','',NULL,'58','1','2','tranmanhhungcntt@gmail.com','4','5','pppo','5','admin','2014-08-12 14:06:37','admin','2014-08-12 14:06:51'),('01011408000015','25','02','jhgf','081582910808','2014-08-21 14:03:40','Liên Hương - Tuy Phong - Bình Thuận','2014-09-20 14:03:40','Liên Hương, tuy phong, bình thuận','48/12 - Liên Hương - Tuy Phong - Bình Thuận','H? Chí Minh',NULL,NULL,'25','(848) 3929 0999',NULL,'acb@acb.com.vn',NULL,NULL,'ffffffff',NULL,'admin','2014-08-12 14:09:11',NULL,NULL),('01011408000016','25','02','iuy','0112232554544','1999-05-19 16:01:05','Hồ Chí Minh','1989-12-13 18:20:52','Hồ Chí Minh','48/12 - Liên Hương - Tuy Phong - Bình Thuận','H? Chí Minh',NULL,NULL,'25','(848) 3929 0999',NULL,'acb@acb.com.vn',NULL,NULL,NULL,'1','admin','2014-08-12 17:09:24',NULL,NULL),('01011408000017','01','01','sf','545',NULL,'fsf',NULL,'sfsd','fsd','sfs','\0',NULL,'02','423','423','24','4234',NULL,'sfs','1','admin','2014-08-22 13:36:30',NULL,NULL),('01011408000018','01','01','Hùng','23456',NULL,'Ninh Binh',NULL,'Ninh Binh','Hà Nội','Hồ Chí Minh','\0','01011408000018_140822143459.png','02','2345','1234','tranmanhhungcntt2@gmail.com','kdjfkdjf','456','bala bala','1','admin','2014-08-22 14:32:32',NULL,NULL),('01011409000001','01','01','','147474','2014-09-24 14:07:42','','2014-10-03 14:07:42','Nơi sinh','ggd','gdgdg','\0',NULL,'25','','','','','','gdđ','1','admin','2014-09-04 14:12:27','admin','2014-09-04 14:13:27'),('01011411000001','01','01','Huỳnh Thị Ngọc Dung','273268729',NULL,'',NULL,'Đồng Nai','Long Điền, Bà Rịa Vũng Tàu','121 Hoàng Hoa Thám, P . 13, Q. Tân Bình, Tp. HCM','','01011411000001_141127124430.jpg','02','0989870091','','dung_htn@vietvang.net','Vietvang.net','000 biết','Test lần 1','1','admin','2014-11-26 13:49:20','admin','2014-11-27 12:41:01'),('01011412000001','01','01','HUynh Dung1',NULL,NULL,NULL,NULL,NULL,NULL,NULL,'','01011412000001_141202154059.jpg','02',NULL,NULL,'dung_htn@vietvang.net',NULL,NULL,NULL,'1','admin','2014-12-02 15:37:02',NULL,NULL),('01011412000002','01','01','Nguyễn Văn C',NULL,NULL,NULL,NULL,NULL,NULL,NULL,'\0','01011412000002_141203153522.jpg','02','0123456789',NULL,NULL,NULL,NULL,NULL,'1','admin','2014-12-03 15:31:39',NULL,NULL),('01011611000001','01','01','Hoang Trieu Chau',NULL,NULL,NULL,NULL,NULL,NULL,NULL,'',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'1','admin','2016-11-06 14:01:01',NULL,NULL),('01021409000001','01','02','Nguyen ngam','04','2000-08-02 16:01:05','201','1990-07-12 18:20:52','Binh_Thuan_12','1241','dd','','01021409000001_140903115326.png','25',NULL,NULL,NULL,NULL,NULL,'d','1','admin','2014-09-03 11:47:21','admin','2014-09-03 11:51:38'),('03011408000001','03','01','tdt10','01','2013-03-02 18:05:46',NULL,'2008-05-04 18:05:46','Nơi sinh 06','dccd07','dctc08','\0','03011408000001_140820094037.png','58','11','12','13@gmail.com','http://14','15','Mô tả 09','5','admin','2014-08-20 09:38:24',NULL,NULL),('03011408000002','03','01','dc_19','11','2014-08-12 13:32:35','13','2014-08-14 13:32:35','Nơi sinh_15','Dctt_16','dctr_17','',NULL,'25','1112','d','dddd','dddd','ddđ','Phát triển_18','1','admin','2014-08-22 13:35:11','admin','2014-08-22 13:36:44'),('03011408000003','03','01',NULL,'11','2009-09-12 18:20:52','Nơi cấp_13','1990-03-14 18:20:52','Nowissinh_15','dctt_16','dctt_17','\0',NULL,'02',NULL,'dđ','dddđd','d','ddđ','Mota_18',NULL,'admin','2014-08-22 13:41:09',NULL,NULL),('03011408000004','03','01','Hùng','45454','2014-01-13 14:16:59','Hà Nội','1997-06-22 14:16:59','Hà Nội','Hà Nội','Hồ Chí Minh','\0','03011408000004_140822141844.png','25','5456454','323454','tranmanhhungcntt2@gmail.com','fsdfdsf','344','Rất yêu đời!','1','admin','2014-08-22 14:16:17',NULL,NULL),('03011408000005','03','01','Thuận','3453',NULL,'Bình Thuận','1989-06-22 14:16:59','Bình Thuận','Bình Thuận','Hồ Chí Minh','\0',NULL,'02',NULL,NULL,NULL,NULL,NULL,NULL,'1','admin','2014-08-22 14:25:00',NULL,NULL),('03011408000006','03','01',NULL,NULL,'2014-04-22 14:44:35',NULL,'2014-05-05 14:44:35',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'1','admin','2014-08-22 14:42:30',NULL,NULL),('03011408000007','03','01',NULL,NULL,'2014-08-26 16:04:16',NULL,'2014-08-26 16:04:16',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'1','admin','2014-08-26 16:02:16',NULL,NULL),('03021409000001','03','02',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'\0',NULL,'58',NULL,'26666','penamkimthuan@yahoo.com','ddd',NULL,'Đang phát triển','5','admin','2014-09-04 14:14:43',NULL,NULL),('0901000001','09','01','Nguyen Tea','0112232554544','1999-05-19 16:01:05','Ninh Bình','1980-09-11 16:20:49','HCM','HCM','HCM','\0','user3.png','02','+84901254789',NULL,'test@gmail.com','',NULL,NULL,'1','admin','2014-07-14 16:22:06',NULL,NULL),('0901000002','09','01','Lý Nh??c ??ng','0112232554544','1999-05-19 16:01:05','Ninh Bình','1968-04-21 16:20:49','HK','HK','HK','','user4.png','25','+669145646472',NULL,'test@gmail.com','',NULL,NULL,'1','admin','2014-07-14 16:22:06',NULL,NULL),('09021407000001','09','02','kjh','1111111111111111111111111111111111111111','1999-05-19 16:01:05','Ninh Bình',NULL,'Hồ Chí Minh','48/12 - Liên Hương - Tuy Phong - Bình Thuận','H? Chí Minh',NULL,NULL,'25','(848) 3929 0999',NULL,'acb@acb.com.vn',NULL,NULL,NULL,NULL,'admin','2014-07-24 17:15:00',NULL,NULL),('25011611000001','25','01','CTy TNHH Hoang Hon','273225738',NULL,NULL,NULL,NULL,'1111','2222',NULL,NULL,NULL,'084381129394','84 2334 5443','email@rmail.com','abc.com','3890222002','Nha cung cap go','1','admin','2016-11-06 13:59:02',NULL,NULL),('25021407000001','25','02','uyt','0112232554544','2009-09-17 18:20:52','Ninh Bình','1989-12-12 18:20:52','Hồ Chí Minh','48/12 - Liên Hương - Tuy Phong - Bình Thuận','H? Chí Minh','',NULL,'02','(848) 3929 0999',NULL,'tranmanhhungcntt@gmail.com',NULL,NULL,NULL,'0','admin','2014-07-25 09:31:15',NULL,NULL),('25021408000001','25','02','Hùng','123456',NULL,NULL,NULL,'Hà Nội','Hà Nội','Hồ Chí Minh','\0','25021408000001_140822101756.png','25','1234567','1234567','1234567','1234567','1234567',NULL,'1','admin','2014-08-22 10:15:31',NULL,NULL),('45011408000001','45','01',NULL,'12','2009-09-13 18:20:52','Nơi Sinh','1990-03-14 18:20:52','ddđ','dddd','ddd','\0',NULL,'25',NULL,NULL,NULL,NULL,NULL,'dddđ',NULL,'admin','2014-08-22 13:43:38',NULL,NULL),('4502000001','45','02','Ngân hàng Á Châu - ACB','0112232554544','1999-05-19 16:01:05','Ninh Bình','1989-12-13 18:20:52','Hồ Chí Minh','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ',NULL,'user5.png','02','(848) 3929 0999','(848) 3839 9885','acb@acb.com.vn','http://www.acb.com.vn/',NULL,'Telex: 813158 ACB VT - SWIFT Code: ASCBVNVX','0','admin','2014-07-15 17:24:46',NULL,NULL),('4502000002','45','02','Ngân hàng Á Châu - ACB','0112232554544','1999-05-19 16:01:05','Ninh Bình','1989-12-13 18:20:52','Hồ Chí Minh','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ',NULL,'user5.png','02','(848) 3929 0999','(848) 3839 9885','tranmanhhungcntt@gmail.com','http://www.acb.com.vn/',NULL,'Telex: 813158 ACB VT - SWIFT Code: ASCBVNVX','0','admin','2014-07-15 17:24:46',NULL,NULL),('4502000003','45','02','Ngân hàng Á Châu - ACB','0112232554544','1999-05-19 16:01:05','Ninh Bình','1989-12-13 18:20:52','Hồ Chí Minh','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ','','user5.png','02','(848) 3929 0999','(848) 3839 9885','tranmanhhungcntt@gmail.com','http://www.acb.com.vn/',NULL,'Telex: 813158 ACB VT - SWIFT Code: ASCBVNVX','0','admin','2014-07-15 17:24:46','admin','2014-08-11 09:24:11'),('4502000004','45','02','Ngân hàng Á Châu - ACB','0112232554544','1999-05-19 16:01:05','Ninh Bình','1989-12-13 18:20:52','Hồ Chí Minh','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ',NULL,'user5.png','02','(848) 3929 0999','(848) 3839 9885','tranmanhhungcntt@gmail.com','http://www.acb.com.vn/',NULL,'Telex: 813158 ACB VT - SWIFT Code: ASCBVNVX','0','admin','2014-07-15 17:24:46',NULL,NULL),('4502000005','45','02','Ngân hàng Á Châu - ACB','0112232554544',NULL,'Ninh Bình','1989-12-13 18:20:52','Hồ Chí Minh','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ',NULL,'user5.png','02','(848) 3929 0999','(848) 3839 9885','tranmanhhungcntt@gmail.com','http://www.acb.com.vn/',NULL,'Telex: 813158 ACB VT - SWIFT Code: ASCBVNVX','0','admin','2014-07-15 17:24:46',NULL,NULL),('4502000006','45','02','Ngân hàng Á Châu - ACB','0112232554544','1999-05-19 16:01:05','Ninh Bình','1989-12-13 18:20:52','Hồ Chí Minh','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ',NULL,'user5.png','02','(848) 3929 0999','(848) 3839 9885','tranmanhhungcntt@gmail.com','http://www.acb.com.vn/',NULL,'Telex: 813158 ACB VT - SWIFT Code: ASCBVNVX','0','admin','2014-07-15 17:24:46',NULL,NULL),('45021407000001','45','02','d','434','1999-05-19 16:01:05','ninh bình','1989-12-13 18:20:52','sdfs','sdf','H? Chí Minh','\0','45021407000001_140723202353.png','02','(848) 3929 0999',NULL,'tranmanhhungcntt@gmail.com',NULL,NULL,NULL,'5','admin','2014-07-23 20:21:11',NULL,NULL),('admin','01','01','Huynh Dung','0112232554544','1999-05-19 16:01:05','Ninh Bình','1989-12-13 18:20:52','Hồ Chí Minh','48/12 - Liên Hương - Tuy Phong - Bình Thuận','H? Chí Minh',NULL,'admin_161105210116.jpg','58','(848) 3929 0999','','acb@acb.com.vn','','','','1','admin','2014-07-15 17:24:57','admin','2016-11-05 21:01:14');
/*!40000 ALTER TABLE `objects` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orderdetails`
--

DROP TABLE IF EXISTS `orderdetails`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `orderdetails` (
  `OrderId` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `ProductId` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `ProductName` varchar(512) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Qty` int(11) DEFAULT NULL,
  `Price` decimal(20,0) DEFAULT NULL,
  `CreatedDate` datetime DEFAULT NULL,
  `CreatedBy` varchar(256) COLLATE utf8_unicode_ci DEFAULT NULL,
  `ModifiedBy` varchar(256) COLLATE utf8_unicode_ci DEFAULT NULL,
  `ModifiedDate` datetime DEFAULT NULL,
  `IsPrint` tinyint(1) DEFAULT NULL,
  `Status` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `AmmountBeforeTax` decimal(20,0) DEFAULT NULL,
  `TaxAmmount` decimal(20,0) DEFAULT NULL,
  `TotalAmmount` decimal(20,0) DEFAULT NULL,
  `Note` varchar(250) COLLATE utf8_unicode_ci DEFAULT NULL,
  `IsBuffet` varchar(1) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`OrderId`,`ProductId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orderdetails`
--

LOCK TABLES `orderdetails` WRITE;
/*!40000 ALTER TABLE `orderdetails` DISABLE KEYS */;
INSERT INTO `orderdetails` VALUES ('102016110600001','031611000001','Com neu',1,30000,'2016-11-06 17:16:29','admin',NULL,NULL,0,'1',30000,3000,33000,NULL,'0'),('102016110600002','031611000001','Com neu',1,30000,'2016-11-06 18:03:24','admin',NULL,NULL,0,'0',30000,3000,33000,NULL,'0'),('102016110600002','031611000002','canh chua',1,20000,'2016-11-06 18:03:24','admin',NULL,NULL,0,'0',20000,2000,22000,NULL,'0'),('102016110600003','031611000001','Com neu',1,30000,'2016-11-06 18:11:19','admin',NULL,NULL,0,'0',30000,3000,33000,NULL,'0'),('102016110600003','031611000005','Tom hum baby',1,200000,'2016-11-06 18:11:19','admin',NULL,NULL,0,'0',200000,20000,220000,NULL,'0'),('102016110600004','031611000001','Com neu',1,30000,'2016-11-06 18:23:34','admin',NULL,NULL,0,'0',30000,3000,33000,NULL,'0'),('102016110600005','031611000001','Com neu',1,30000,'2016-11-06 18:32:08','admin',NULL,NULL,0,'0',30000,3000,33000,NULL,'0'),('102016110600005','031611000005','Tom hum baby',1,200000,'2016-11-06 18:32:08','admin',NULL,NULL,0,'0',200000,20000,220000,NULL,'0'),('102016110600006','031611000001','Com neu',1,30000,'2016-11-06 18:36:18','admin',NULL,NULL,0,'0',30000,3000,33000,NULL,'0'),('102016110600006','031611000005','Tom hum baby',1,200000,'2016-11-06 18:36:18','admin',NULL,NULL,0,'0',200000,20000,220000,NULL,'0'),('102016110800001','031611000001','Com neu',1,30000,'2016-11-08 14:10:35','admin',NULL,NULL,0,'1',30000,3000,33000,NULL,'0');
/*!40000 ALTER TABLE `orderdetails` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `orders` (
  `OrderId` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `DeskId` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Note` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `CreatedDate` datetime DEFAULT NULL,
  `CreatedBy` varchar(256) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Status` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `ModifiedDate` datetime DEFAULT NULL,
  `ModifiedBy` varchar(256) COLLATE utf8_unicode_ci NOT NULL,
  `TotalTax` decimal(20,0) DEFAULT NULL,
  `TotalAmmount` decimal(20,0) DEFAULT NULL,
  `TotalAmountBeforeTax` decimal(20,0) DEFAULT NULL,
  `DisCountAmount` decimal(20,0) DEFAULT NULL,
  `TotalMoney` decimal(20,0) DEFAULT NULL,
  `IsPrint` tinyint(4) DEFAULT NULL,
  `EmployeeId` int(11) DEFAULT NULL,
  PRIMARY KEY (`OrderId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
INSERT INTO `orders` VALUES ('102016110600001','0','121 hon ho th','2016-11-06 17:16:29','admin','1',NULL,'admin',3000,33000,30000,0,33000,NULL,NULL),('102016110600002','0','abc','2016-11-06 18:03:24','admin','0',NULL,'',5000,55000,50000,0,55000,NULL,NULL),('102016110600003','0','bhhjkkm','2016-11-06 18:11:19','admin','0',NULL,'',23000,253000,230000,0,253000,NULL,NULL),('102016110600004','0','hhhhh','2016-11-06 18:23:34','admin','0',NULL,'',3000,33000,30000,0,33000,NULL,NULL),('102016110600005','0','ggfgf','2016-11-06 18:32:08','admin','0',NULL,'',23000,253000,230000,0,253000,NULL,NULL),('102016110600006','0','kkkk','2016-11-06 18:36:18','admin','0',NULL,'',23000,253000,230000,0,253000,NULL,NULL),('102016110800001','0','vxfdf','2016-11-08 14:10:35','admin','1',NULL,'trieuchau',3000,33000,30000,0,33000,NULL,NULL);
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `tgInsert_Orders` AFTER INSERT ON `orders` FOR EACH ROW BEGIN
	CALL spInsert_UserActionHistory(NEW.`CreatedBy`,
	CONCAT('Table:orders|orderid=' , NEW.`OrderId`),
	'INSERT',
	'DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney',
	CONCAT(IFNULL(NEW.`DeskId`,''), ' | ', IFNULL(NEW.`Note`,''), ' | ',IFNULL(NEW.`Status`,''),'|',IFNULL(NEW.`TotalTax`,''),'|',IFNULL(NEW.`TotalAmmount`,''),'|',IFNULL(NEW.`TotalAmountBeforeTax`,''),'|',IFNULL(NEW.`DisCountAmount`,''),'|',IFNULL(NEW.`TotalMoney`,'')));
    END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `output`
--

DROP TABLE IF EXISTS `output`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `output` (
  `OutputId` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `Ballot` varchar(10) COLLATE utf8_unicode_ci DEFAULT NULL,
  `BallotDate` date DEFAULT NULL,
  `OutputReason` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `StoreId` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `OutputType` tinyint(1) DEFAULT NULL,
  `ReceiptId` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `OutputNote` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `CreatedBy` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `CreatedDate` datetime DEFAULT NULL,
  PRIMARY KEY (`OutputId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `output`
--

LOCK TABLES `output` WRITE;
/*!40000 ALTER TABLE `output` DISABLE KEYS */;
INSERT INTO `output` VALUES ('992016110600001',NULL,NULL,NULL,NULL,0,'112016110600001',NULL,'admin','2016-11-06 17:17:36'),('992016110800001',NULL,NULL,NULL,NULL,0,'112016110800001',NULL,'admin','2016-11-08 09:23:21'),('992016110800002',NULL,NULL,NULL,NULL,0,'112016110800002',NULL,'admin','2016-11-08 09:52:28'),('992016110800003',NULL,NULL,NULL,NULL,0,'112016110800003',NULL,'admin','2016-11-08 10:16:59'),('992016110800004',NULL,NULL,NULL,NULL,0,'112016110800004',NULL,'admin','2016-11-08 10:23:28'),('992016110800005',NULL,NULL,NULL,NULL,0,'112016110800005',NULL,'admin','2016-11-08 10:27:44'),('992016110800006',NULL,NULL,NULL,NULL,0,'112016110800006',NULL,'admin','2016-11-08 10:32:30'),('992016110800007',NULL,NULL,NULL,NULL,0,'112016110800007',NULL,'admin','2016-11-08 10:35:24'),('992016110800008',NULL,NULL,NULL,NULL,0,'112016110800008',NULL,'admin','2016-11-08 10:41:27'),('992016110800009',NULL,NULL,NULL,NULL,0,'112016110800009',NULL,'admin','2016-11-08 10:45:02'),('992016110800010',NULL,NULL,NULL,NULL,0,'112016110800010',NULL,'admin','2016-11-08 11:00:31'),('992016110800011',NULL,NULL,NULL,NULL,0,'112016110800011',NULL,'trieuchau','2016-11-08 17:51:03');
/*!40000 ALTER TABLE `output` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `outputdetail`
--

DROP TABLE IF EXISTS `outputdetail`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `outputdetail` (
  `Id` bigint(20) NOT NULL AUTO_INCREMENT,
  `OutputId` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `IngredientId` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `IngredientQty` decimal(20,0) DEFAULT NULL,
  `IngredientPrice` decimal(20,0) DEFAULT NULL,
  `IngredientVat` decimal(20,0) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `outputdetail`
--

LOCK TABLES `outputdetail` WRITE;
/*!40000 ALTER TABLE `outputdetail` DISABLE KEYS */;
/*!40000 ALTER TABLE `outputdetail` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productprice`
--

DROP TABLE IF EXISTS `productprice`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `productprice` (
  `ProductId` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `Time` datetime NOT NULL,
  `Price` decimal(20,2) DEFAULT NULL,
  `CreatedId` varchar(256) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`ProductId`,`Time`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productprice`
--

LOCK TABLES `productprice` WRITE;
/*!40000 ALTER TABLE `productprice` DISABLE KEYS */;
INSERT INTO `productprice` VALUES ('031611000001','2016-11-06 16:07:13',30000.00,'admin'),('031611000006','2016-11-28 23:37:23',11224.00,'admin');
/*!40000 ALTER TABLE `productprice` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `products`
--

DROP TABLE IF EXISTS `products`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `products` (
  `ProductId` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `ProductCode` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Name` varchar(512) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Price` decimal(20,2) DEFAULT NULL,
  `Unit` varchar(128) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Image` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `IsPrint` tinyint(1) DEFAULT '0',
  `Notes` text COLLATE utf8_unicode_ci,
  `CreatedDate` datetime DEFAULT NULL,
  `IsDelete` tinyint(1) DEFAULT '0',
  `CreatedBy` varchar(256) COLLATE utf8_unicode_ci DEFAULT NULL,
  `ModifiedDate` datetime DEFAULT NULL,
  `ModifiedBy` varchar(256) COLLATE utf8_unicode_ci DEFAULT NULL,
  `ProductType` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`ProductId`),
  KEY `ProductUnit` (`Unit`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `products`
--

LOCK TABLES `products` WRITE;
/*!40000 ALTER TABLE `products` DISABLE KEYS */;
INSERT INTO `products` VALUES ('031611000001',NULL,'Com neu',30000.00,'noi','031611000001_161106153501.jpg',0,'Mot noi com neu','2016-11-06 15:23:52',0,'admin','2016-11-06 16:07:14','admin','01'),('031611000002',NULL,'canh chua',20000.00,'to',NULL,0,NULL,'2016-11-06 15:37:43',0,'admin',NULL,NULL,'01'),('031611000003',NULL,'Cafe da',15000.00,'ly',NULL,0,NULL,'2016-11-06 15:38:51',0,'admin',NULL,NULL,'02'),('031611000004',NULL,'Bach tuoc nuong',50000.00,'dia',NULL,0,NULL,'2016-11-06 15:39:58',0,'admin',NULL,NULL,'03'),('031611000005',NULL,'Tom hum baby',200000.00,'con',NULL,0,NULL,'2016-11-06 15:40:53',0,'admin',NULL,NULL,'03'),('031611000006',NULL,'2231',11224.00,'ký','14368759_157844247996382_5193736473159198001_n.jpg',0,'haz','2016-11-28 23:29:46',0,'admin','2016-11-28 23:37:23','admin','02');
/*!40000 ALTER TABLE `products` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `receiptdetails`
--

DROP TABLE IF EXISTS `receiptdetails`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `receiptdetails` (
  `ODId` bigint(20) NOT NULL AUTO_INCREMENT,
  `ReceiptId` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `ProductId` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `PromotionId` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Qty` int(11) DEFAULT NULL,
  `Price` decimal(20,2) DEFAULT NULL,
  `TotalAmountBeforeTax` decimal(20,2) DEFAULT NULL,
  `TaxAmount` decimal(20,2) DEFAULT NULL,
  `TotalAmount` decimal(20,2) DEFAULT NULL,
  `Status` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `RefOrderId` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `CreatedBy` varchar(256) COLLATE utf8_unicode_ci DEFAULT NULL,
  `CreatedDate` datetime DEFAULT NULL,
  `ModifiedBy` varchar(256) COLLATE utf8_unicode_ci DEFAULT NULL,
  `ModifiedDate` datetime DEFAULT NULL,
  PRIMARY KEY (`ODId`)
) ENGINE=InnoDB AUTO_INCREMENT=32 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `receiptdetails`
--

LOCK TABLES `receiptdetails` WRITE;
/*!40000 ALTER TABLE `receiptdetails` DISABLE KEYS */;
INSERT INTO `receiptdetails` VALUES (1,'112016110600001','031611000001','',1,30000.00,30000.00,3000.00,33000.00,'1','102016110600001','admin','2016-11-06 17:17:36',NULL,NULL),(2,'112016110800001','031611000001','',1,30000.00,30000.00,3000.00,33000.00,'1','DataGridViewTextBoxC','admin','2016-11-08 09:23:22',NULL,NULL),(3,'112016110800002','031611000001','',1,30000.00,30000.00,3000.00,33000.00,'1','DataGridViewTextBoxC','admin','2016-11-08 09:52:28',NULL,NULL),(4,'112016110800003','031611000002','',1,20000.00,20000.00,2000.00,22000.00,'1','DataGridViewTextBoxC','admin','2016-11-08 10:17:00',NULL,NULL),(5,'112016110800003','031611000004','',1,50000.00,50000.00,5000.00,55000.00,'1','DataGridViewTextBoxC','admin','2016-11-08 10:17:00',NULL,NULL),(6,'112016110800003','031611000005','',1,200000.00,200000.00,20000.00,220000.00,'1','DataGridViewTextBoxC','admin','2016-11-08 10:17:00',NULL,NULL),(7,'112016110800004','031611000003','',1,15000.00,15000.00,1500.00,16500.00,'1','DataGridViewTextBoxC','admin','2016-11-08 10:23:28',NULL,NULL),(8,'112016110800004','031611000004','',1,50000.00,50000.00,5000.00,55000.00,'1','DataGridViewTextBoxC','admin','2016-11-08 10:23:28',NULL,NULL),(9,'112016110800004','031611000005','',1,200000.00,200000.00,20000.00,220000.00,'1','DataGridViewTextBoxC','admin','2016-11-08 10:23:28',NULL,NULL),(10,'112016110800004','031611000001','',1,30000.00,30000.00,3000.00,33000.00,'1','DataGridViewTextBoxC','admin','2016-11-08 10:23:28',NULL,NULL),(11,'112016110800005','031611000001','',1,30000.00,30000.00,3000.00,33000.00,'1','DataGridViewTextBoxC','admin','2016-11-08 10:27:44',NULL,NULL),(12,'112016110800005','031611000002','',1,20000.00,20000.00,2000.00,22000.00,'1','DataGridViewTextBoxC','admin','2016-11-08 10:27:44',NULL,NULL),(13,'112016110800005','031611000003','',1,15000.00,15000.00,1500.00,16500.00,'1','DataGridViewTextBoxC','admin','2016-11-08 10:27:44',NULL,NULL),(14,'112016110800005','031611000004','',1,50000.00,50000.00,5000.00,55000.00,'1','DataGridViewTextBoxC','admin','2016-11-08 10:27:44',NULL,NULL),(15,'112016110800005','031611000005','',1,200000.00,200000.00,20000.00,220000.00,'1','DataGridViewTextBoxC','admin','2016-11-08 10:27:44',NULL,NULL),(16,'112016110800006','031611000001','',1,30000.00,30000.00,3000.00,33000.00,'1','DataGridViewTextBoxC','admin','2016-11-08 10:32:30',NULL,NULL),(17,'112016110800006','031611000002','',1,20000.00,20000.00,2000.00,22000.00,'1','DataGridViewTextBoxC','admin','2016-11-08 10:32:30',NULL,NULL),(18,'112016110800006','031611000003','',1,15000.00,15000.00,1500.00,16500.00,'1','DataGridViewTextBoxC','admin','2016-11-08 10:32:30',NULL,NULL),(19,'112016110800006','031611000004','',1,50000.00,50000.00,5000.00,55000.00,'1','DataGridViewTextBoxC','admin','2016-11-08 10:32:30',NULL,NULL),(20,'112016110800007','031611000002','',1,20000.00,20000.00,2000.00,22000.00,'1','DataGridViewTextBoxC','admin','2016-11-08 10:35:24',NULL,NULL),(21,'112016110800007','031611000001','',1,30000.00,30000.00,3000.00,33000.00,'1','DataGridViewTextBoxC','admin','2016-11-08 10:35:24',NULL,NULL),(22,'112016110800007','031611000003','',1,15000.00,15000.00,1500.00,16500.00,'1','DataGridViewTextBoxC','admin','2016-11-08 10:35:24',NULL,NULL),(23,'112016110800008','031611000004','',1,50000.00,50000.00,5000.00,55000.00,'1','DataGridViewTextBoxC','admin','2016-11-08 10:41:27',NULL,NULL),(24,'112016110800008','031611000003','',1,15000.00,15000.00,1500.00,16500.00,'1','DataGridViewTextBoxC','admin','2016-11-08 10:41:27',NULL,NULL),(25,'112016110800009','031611000003','',1,15000.00,15000.00,1500.00,16500.00,'1','DataGridViewTextBoxC','admin','2016-11-08 10:45:02',NULL,NULL),(26,'112016110800009','031611000002','',1,20000.00,20000.00,2000.00,22000.00,'1','DataGridViewTextBoxC','admin','2016-11-08 10:45:02',NULL,NULL),(27,'112016110800009','031611000001','',2,30000.00,60000.00,6000.00,66000.00,'1','DataGridViewTextBoxC','admin','2016-11-08 10:45:02',NULL,NULL),(28,'112016110800010','031611000003','',1,15000.00,15000.00,1500.00,16500.00,'1','DataGridViewTextBoxC','admin','2016-11-08 11:00:32',NULL,NULL),(29,'112016110800010','031611000002','',1,20000.00,20000.00,2000.00,22000.00,'1','DataGridViewTextBoxC','admin','2016-11-08 11:00:32',NULL,NULL),(30,'112016110800010','031611000001','',1,30000.00,30000.00,3000.00,33000.00,'1','DataGridViewTextBoxC','admin','2016-11-08 11:00:32',NULL,NULL),(31,'112016110800011','031611000001','',1,30000.00,30000.00,3000.00,33000.00,'1','102016110800001','trieuchau','2016-11-08 17:51:03',NULL,NULL);
/*!40000 ALTER TABLE `receiptdetails` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `receiptinfo`
--

DROP TABLE IF EXISTS `receiptinfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `receiptinfo` (
  `ReceiptId` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `CustomerName` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Address` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Phone` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Note` text COLLATE utf8_unicode_ci,
  PRIMARY KEY (`ReceiptId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `receiptinfo`
--

LOCK TABLES `receiptinfo` WRITE;
/*!40000 ALTER TABLE `receiptinfo` DISABLE KEYS */;
/*!40000 ALTER TABLE `receiptinfo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `receiptmember`
--

DROP TABLE IF EXISTS `receiptmember`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `receiptmember` (
  `ReceiptId` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `MemberId` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `Score` bigint(20) DEFAULT '0',
  `CreatedDate` datetime DEFAULT NULL,
  `CreatedBy` varchar(256) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`ReceiptId`,`MemberId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `receiptmember`
--

LOCK TABLES `receiptmember` WRITE;
/*!40000 ALTER TABLE `receiptmember` DISABLE KEYS */;
/*!40000 ALTER TABLE `receiptmember` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `receipts`
--

DROP TABLE IF EXISTS `receipts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `receipts` (
  `ReceiptId` varchar(20) COLLATE utf8_unicode_ci NOT NULL DEFAULT '',
  `Note` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `NoOfCustumers` int(11) DEFAULT NULL,
  `Status` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `TotalAmountBeforeTax` decimal(20,2) DEFAULT NULL,
  `ServiceCostAmount` decimal(20,2) DEFAULT '0.00',
  `TotalTax` decimal(20,2) DEFAULT NULL,
  `TotalAmount` decimal(20,2) DEFAULT NULL,
  `DiscountAmount` decimal(20,2) DEFAULT NULL,
  `TotalMoney` decimal(20,2) DEFAULT NULL,
  `CashPayAmt` decimal(20,2) DEFAULT NULL,
  `CardPayAmt` decimal(20,2) DEFAULT '0.00',
  `ReturnAmt` decimal(20,2) DEFAULT NULL,
  `CreatedBy` varchar(256) COLLATE utf8_unicode_ci DEFAULT NULL,
  `CreatedDate` datetime DEFAULT NULL,
  `ModifiedBy` varchar(256) COLLATE utf8_unicode_ci DEFAULT NULL,
  `ModifiedDate` datetime DEFAULT NULL,
  PRIMARY KEY (`ReceiptId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `receipts`
--

LOCK TABLES `receipts` WRITE;
/*!40000 ALTER TABLE `receipts` DISABLE KEYS */;
INSERT INTO `receipts` VALUES ('112016110600001','',0,'1',30000.00,0.00,3000.00,33000.00,0.00,33000.00,40000.00,0.00,7000.00,'admin','2016-11-06 17:17:35',NULL,NULL),('112016110800001','',0,'1',30000.00,0.00,3000.00,33000.00,0.00,33000.00,50000.00,0.00,17000.00,'admin','2016-11-08 09:23:21',NULL,NULL),('112016110800002','',0,'1',30000.00,0.00,3000.00,33000.00,0.00,33000.00,40000.00,0.00,7000.00,'admin','2016-11-08 09:52:28',NULL,NULL),('112016110800003','',0,'1',270000.00,0.00,27000.00,297000.00,0.00,297000.00,500000.00,0.00,203000.00,'admin','2016-11-08 10:16:59',NULL,NULL),('112016110800004','',0,'1',295000.00,0.00,29500.00,324500.00,0.00,324500.00,500000.00,0.00,175500.00,'admin','2016-11-08 10:23:28',NULL,NULL),('112016110800005','',0,'1',315000.00,0.00,31500.00,346500.00,0.00,346500.00,400000.00,0.00,53500.00,'admin','2016-11-08 10:27:44',NULL,NULL),('112016110800006','',0,'1',115000.00,0.00,11500.00,126500.00,0.00,126500.00,200000.00,0.00,73500.00,'admin','2016-11-08 10:32:30',NULL,NULL),('112016110800007','',0,'1',65000.00,0.00,6500.00,71500.00,0.00,71500.00,100000.00,0.00,28500.00,'admin','2016-11-08 10:35:24',NULL,NULL),('112016110800008','',0,'1',65000.00,0.00,6500.00,71500.00,0.00,71500.00,100000.00,0.00,28500.00,'admin','2016-11-08 10:41:27',NULL,NULL),('112016110800009','',0,'1',95000.00,0.00,9500.00,104500.00,0.00,104500.00,200000.00,0.00,95500.00,'admin','2016-11-08 10:45:02',NULL,NULL),('112016110800010','',0,'1',65000.00,0.00,6500.00,71500.00,0.00,71500.00,100000.00,0.00,28500.00,'admin','2016-11-08 11:00:31',NULL,NULL),('112016110800011','',0,'1',30000.00,0.00,3000.00,33000.00,0.00,33000.00,40000.00,0.00,7000.00,'trieuchau','2016-11-08 17:51:03',NULL,NULL);
/*!40000 ALTER TABLE `receipts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `receiptscard`
--

DROP TABLE IF EXISTS `receiptscard`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `receiptscard` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `ReceiptId` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `CardNo` varchar(150) COLLATE utf8_unicode_ci DEFAULT NULL,
  `CardHolderName` varchar(200) COLLATE utf8_unicode_ci DEFAULT NULL,
  `ExpiredDate` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `CardType` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Bank` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `TotalAmount` decimal(20,2) DEFAULT NULL,
  `TerminalId` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `MerchantId` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `TransType` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `BatchNo` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `TraceNo` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `RefNo` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `AppCode` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `CreatedBy` varchar(256) COLLATE utf8_unicode_ci DEFAULT NULL,
  `CreatedDate` datetime DEFAULT NULL,
  `ModifiedBy` varchar(256) COLLATE utf8_unicode_ci DEFAULT NULL,
  `ModifiedDate` datetime DEFAULT NULL,
  `CanUpdate` bit(1) DEFAULT b'1',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `receiptscard`
--

LOCK TABLES `receiptscard` WRITE;
/*!40000 ALTER TABLE `receiptscard` DISABLE KEYS */;
/*!40000 ALTER TABLE `receiptscard` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `roles`
--

DROP TABLE IF EXISTS `roles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `roles` (
  `RoleId` varchar(128) COLLATE utf8_unicode_ci NOT NULL,
  `RoleName` varchar(256) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`RoleId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roles`
--

LOCK TABLES `roles` WRITE;
/*!40000 ALTER TABLE `roles` DISABLE KEYS */;
INSERT INTO `roles` VALUES ('admin','Quyền quản lý'),('letan','Quyền lễ tân'),('nhanvien','Quyền nhân viên'),('tablet','Quyền sử dụng tablet');
/*!40000 ALTER TABLE `roles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `supplier`
--

DROP TABLE IF EXISTS `supplier`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `supplier` (
  `SupplierId` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `SupplierName` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `SupplierAddress` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `SupplierPhone` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `SupplierEmail` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `SupplierWebsite` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`SupplierId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `supplier`
--

LOCK TABLES `supplier` WRITE;
/*!40000 ALTER TABLE `supplier` DISABLE KEYS */;
INSERT INTO `supplier` VALUES ('982016110600002','11','','111113','4','5'),('982016110600003','r1','r2','r3','r4','r5');
/*!40000 ALTER TABLE `supplier` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `table`
--

DROP TABLE IF EXISTS `table`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `table` (
  `TableID` int(11) NOT NULL AUTO_INCREMENT,
  `TableName` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`TableID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `table`
--

LOCK TABLES `table` WRITE;
/*!40000 ALTER TABLE `table` DISABLE KEYS */;
/*!40000 ALTER TABLE `table` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `total_ingredient_sold`
--

DROP TABLE IF EXISTS `total_ingredient_sold`;
/*!50001 DROP VIEW IF EXISTS `total_ingredient_sold`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `total_ingredient_sold` AS SELECT 
 1 AS `IngredientId`,
 1 AS `IngredientName`,
 1 AS `IngredientMeasure`,
 1 AS `IngredientExchange`,
 1 AS `IngredientUnit`,
 1 AS `totalSold`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `totalproductsold`
--

DROP TABLE IF EXISTS `totalproductsold`;
/*!50001 DROP VIEW IF EXISTS `totalproductsold`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `totalproductsold` AS SELECT 
 1 AS `ProductId`,
 1 AS `totalQty`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `unit`
--

DROP TABLE IF EXISTS `unit`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `unit` (
  `UnitId` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `UnitName` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `UnitQtyExchange` decimal(20,0) DEFAULT NULL,
  `UnitExchange` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`UnitId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `unit`
--

LOCK TABLES `unit` WRITE;
/*!40000 ALTER TABLE `unit` DISABLE KEYS */;
/*!40000 ALTER TABLE `unit` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `useractionhistory`
--

DROP TABLE IF EXISTS `useractionhistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `useractionhistory` (
  `Time` datetime NOT NULL,
  `UserId` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `Object` varchar(250) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Verb` text COLLATE utf8_unicode_ci,
  `Param` text COLLATE utf8_unicode_ci,
  `Value` text COLLATE utf8_unicode_ci,
  PRIMARY KEY (`Time`,`UserId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `useractionhistory`
--

LOCK TABLES `useractionhistory` WRITE;
/*!40000 ALTER TABLE `useractionhistory` DISABLE KEYS */;
INSERT INTO `useractionhistory` VALUES ('2014-06-23 10:15:48','nhanvien','Table:users | userid=nhanvien','INSERT','pwd | ObjectId | Status | RoleId','133555666 | nhanvien | 4 | nhanvien'),('2014-06-23 10:16:40','nhanvien','Table:users | userid=nhanvien','UPDATE','pwd | ObjectId | Status | RoleId','133555666 | nhanvien |  | '),('2014-06-23 10:17:10','hadmin','Table:promotions | promotionid=Promotion_L','UPDATE','PromotionName | BeginDateTime | EndDateTime ','Promtion_L | 0000-00-00 00:00:00 | 2014-06-25 17:29:38'),('2014-06-23 10:17:16','hadmin','Table:promotions | promotionid=Promotion_L','UPDATE','PromotionName | BeginDateTime | EndDateTime ','Promtion_L | 0000-00-00 00:00:00 | 0000-00-00 00:00:00'),('2014-06-23 10:18:00','nhanvien','Table:promotions | promotionid=Promotio','UPDATE','PromotionName | BeginDateTime | EndDateTime ','Prom |  | 2014-06-18 10:19:18'),('2014-06-23 10:19:18','Rec_56','Table:receipts | receiptid=REC_03','INSERT',' Note | group | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ','REC_05 | 1 | 6 | 9.00||||'),('2014-06-23 10:19:54','admin','Table:receipts | receiptid=REC_06','INSERT',' Note | group | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ','REC_45 | 1 |  | |8.00|8.00||'),('2014-06-23 10:21:21','admin','Table:receipts | receiptid=REC_06','UPDATE',' Note | group | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ','REC_45 | 1 | 8 | |8.00|8.00|9.00|'),('2014-06-23 10:38:58','quanly','Table:orders | orderid=Orderid_01','INSERT','DeskId | Note | Status | TotalTax | TotalAmmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','4 | Ghi chú | 45|12|45|||78952'),('2014-06-23 10:43:43','nhanvien','Table:orders | orderid=Orderid_04','UPDATE','DeskId | Note | Status | TotalTax | TotalAmmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','87 | Ghi chú | 45|12|45|||78952'),('2014-06-23 11:05:20','admin','Table:productprice | productprice=producti_0998|time=2014-06-26 11:06:29','INSERT','Price','456.00'),('2014-06-23 11:30:15','admin','Table:members | memberid=Member_V203','UPDATE','MemberCode | ObjectId | NumberOfVissits| MemberType| CountryId | IsLock | LockDate | IsDelete | Description | Note | Status | MemberScore','456663|Phát triển|78|63|8|7||0|||78|89'),('2014-06-23 11:37:30','admin','Table:memberscore | id=1','INSERT','MemberId | RefReceipt | TotalScore ','12|89|78.00'),('2014-06-23 11:45:35','nhanvien','Table:members | memberid=Member_V0998','INSERT','MemberCode | ObjectId | NumberOfVissits| MemberType| CountryId | IsLock | LockDate | IsDelete | Description | Note | Status | MemberScore','778992|Đang phát triển|96|56|7|0||0||||'),('2014-06-23 15:27:49','admin','Table:members | memberid=Member_V203','UPDATE','MemberCode | ObjectId | NumberOfVissits| MemberType| CountryId | IsLock | LockDate | IsDelete | Description | Note | Status | MemberScore','456663|Phát triển|78|63|8|7||0|||78|97'),('2014-06-23 15:40:09','nhanvien','Table:members | memberid=Member_V204','INSERT','MemberCode | ObjectId | NumberOfVissits| MemberType| CountryId | IsLock | LockDate | IsDelete | Description | Note | Status | MemberScore','445566|Dang phat trien|1|||0||0||||10'),('2014-06-23 15:53:06','nhanvien','Table:members | memberid=Member_V102','INSERT','MemberCode | ObjectId | NumberOfVissits| MemberType| CountryId | IsLock | LockDate | IsDelete | Description | Note | Status | MemberScore','144556|Dang phat trien|8|||0||0||||10'),('2014-06-23 15:58:42','admin','Table:members | memberid=Member_V204','UPDATE','MemberCode | ObjectId | NumberOfVissits| MemberType| CountryId | IsLock | LockDate | IsDelete | Description | Note | Status | MemberScore','445566|Dang phat trien|1|||0||0||||20'),('2014-06-23 16:01:42','quanly','Table:members | memberid=Member_V205','INSERT','MemberCode | ObjectId | NumberOfVissits| MemberType| CountryId | IsLock | LockDate | IsDelete | Description | Note | Status | MemberScore','111345|Phát triển|45|74||0||0||||10'),('2014-06-23 16:02:18','quanly','Table:members | memberid=Member_V205','UPDATE','MemberCode | ObjectId | NumberOfVissits| MemberType| CountryId | IsLock | LockDate | IsDelete | Description | Note | Status | MemberScore','111345|Phát triển|45|74||0||0||||14'),('2014-06-23 17:38:19','admin','Table:users | userid=userid','INSERT','pwd | ObjectId | Status | RoleId','23456688 | hoatdong | 1 | hoatdong'),('2014-06-24 10:48:16','admin','Table:orders | orderid=Order_01','INSERT','DeskId | Note | Status | TotalTax | TotalAmmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','Desk_01 | chu y | 15-10-2001|4556|4588|7|7899555|78'),('2014-06-24 10:49:39','admin','Table:orders | orderid=Order_089','INSERT','DeskId | Note | Status | TotalTax | TotalAmmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','Desk_089 | chu y | |4556|4588|7|7899555|78'),('2014-06-24 11:53:07','phatrien','Table:orders | orderid=Order_01','UPDATE','DeskId | Note | Status | TotalTax | TotalAmmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','DEsk_001 | Ghi chu | 15-10-2001|414|4|789|785|5'),('2014-06-24 14:24:03','admin','Table:members | memberid=Memberid_001','INSERT','MemberCode | ObjectId | NumberOfVissits| MemberType| CountryId | IsLock | LockDate | IsDelete | Description | Note | Status | MemberScore','12001|OM0122|0|1|3|0||0|mo ta ve than vien|ghi chu|23|0'),('2014-06-24 15:26:57','quanly','Table:products | productid=Produc_01','UPDATE','Name | Unit | Notes | ProductType','Nguyễn Productionr | 12 | Phát triển phần mềm_Update|chuy'),('2014-06-24 15:27:44','nhanvien','Table:productprice | productprice=Produc_02|time=0000-00-00 00:00:00','INSERT','Price','89.00'),('2014-06-24 15:36:51','admin','Table:products | productid=Product_01','INSERT','Name | Unit | Notes | ProductType','Trà sữa | ly | Ghi chu|Producttype'),('2014-06-24 16:02:25','admin','Table:products | productid=Product_01','INSERT','Name | Unit | Notes | ProductType','Trà sữa | ly | Ghi chu|Producttype'),('2014-06-24 16:12:00','admin','Table:members | memberid=Memberid_008','INSERT','MemberCode | ObjectId | NumberOfVissits| MemberType| CountryId | IsLock | LockDate | IsDelete | Description | Note | Status | MemberScore','01266577|OM0122|0|1|3|0||0|mo ta ve nguyen van A|ghi chu|23|0'),('2014-06-24 16:12:33','admin','Table:members | memberid=Memberid_012','INSERT','MemberCode | ObjectId | NumberOfVissits| MemberType| CountryId | IsLock | LockDate | IsDelete | Description | Note | Status | MemberScore','01266577|OM0122|0|1|3_45|0||0|mo ta ve nguyen van A|ghi chu ve nguyen van A|23|0'),('2014-06-24 16:38:15','quanly','Table:products | productid=Produc_01','UPDATE','Name | Unit | Notes | ProductType','Cá viên chiên | que | Ghi chu ve ca vien chien|chuy'),('2014-06-24 16:40:32','quanly_01','Table:products | productid=Produc_01','UPDATE','Name | Unit | Notes | ProductType','Cá viên chiên | que | Ghi chu ve ca vien chien|chuy'),('2014-06-24 16:42:31','quanly_01','Table:products | productid=Produc_01','UPDATE','Name | Unit | Notes | ProductType','Cá viên chiên | que | Ghi chu ve ca vien chien|Producttype_chuy'),('2014-06-24 16:52:51','admin','Table:orders | orderid=Orderid_04','UPDATE','DeskId | Note | Status | TotalTax | TotalAmmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','DEsk_001 | D0124 | 45|12|78|7|6|5'),('2014-06-24 17:06:28','admin_update','Table:members | memberid=Memberid_012','UPDATE','MemberCode | ObjectId | NumberOfVissits| MemberType| CountryId | IsLock | LockDate | IsDelete | Description | Note | Status | MemberScore','88888|OM0012|0|MemberType|1|0||0|mo ta ve nguyen van A|ghi chu ve nguyen van A|trangthai|0'),('2014-06-25 10:14:39','admin','Table:products | productid=Product_02','INSERT','Name | Unit | Notes | ProductType','Canh chua cá | Tô | Ghi chú canh chua cá lóc|1'),('2014-06-25 10:16:35','admin','Table:products | productid=1001','INSERT','Name | Unit | Notes | ProductType','Cá kho tộ | Tô | Ghi chú canh chua cá lóc|2'),('2014-06-25 10:57:49','admin','Table:productprice | productprice=Product_02|time=2014-06-27 10:58:59','INSERT','Price','91.00'),('2014-06-25 13:03:08','admin','Table:products | productid=1003','INSERT','Name | Unit | Notes | ProductType','Massage body | Lần | Ghi chú massage body|3'),('2014-06-25 13:27:37','ADMIN','Table:productprice | productprice=1001|time=2014-06-27 13:28:46','INSERT','Price','100.00'),('2014-06-25 13:51:20','admin','Table:products | productid=00000001','INSERT','Name | Unit | Notes | ProductType','Cá kho tộ | tô | Cá kho ngon|1'),('2014-06-25 13:52:44','admin','Table:products | productid=00000002','INSERT','Name | Unit | Notes | ProductType','Canh chua | tô | Cá |00'),('2014-06-25 13:55:16','admin','Table:products | productid=00000001','UPDATE','Name | Unit | Notes | ProductType','Cá kho tộ | tô | Cá kho ngon|1'),('2014-06-25 13:55:20','admin','Table:products | productid=00000002','UPDATE','Name | Unit | Notes | ProductType','Canh chua | tô | Cá |00'),('2014-06-25 13:55:30','admin','Table:products | productid=00000002','UPDATE','Name | Unit | Notes | ProductType','Canh chua | tô | Cá |00'),('2014-06-25 13:55:44','admin','Table:products | productid=00000001','UPDATE','Name | Unit | Notes | ProductType','Cá kho tộ | tô | Cá kho ngon|00'),('2014-06-25 13:57:42','admin','Table:products | productid=01000003','INSERT','Name | Unit | Notes | ProductType','Trà sữa | ly | thêm hạt trân châu |01'),('2014-06-25 13:58:21','admin','Table:products | productid=01000003','UPDATE','Name | Unit | Notes | ProductType','Trà sữa | ly | thêm hạt trân châu |01'),('2014-06-25 14:02:02','admin','Table:products | productid=01000203','INSERT','Name | Unit | Notes | ProductType','Sinh tố | ly | thêm hạt trân châu |01'),('2014-06-25 14:14:24','admin','Table:products | productid=03000001','INSERT','Name | Unit | Notes | ProductType','Massage | ly | thêm hạt trân châu |03'),('2014-06-25 14:15:23','admin','Table:products | productid=03000002','INSERT','Name | Unit | Notes | ProductType','MassageBody | suất | có thêm khuyến mãi|03'),('2014-06-25 14:16:00','admin','Table:productprice | productprice=03000002|time=2014-06-18 14:17:07','INSERT','Price','50.00'),('2014-06-25 14:16:42','admin','Table:productprice | productprice=03000003|time=2014-06-26 14:17:48','INSERT','Price','45.00'),('2014-06-25 14:17:24','admin','Table:products | productid=03000003','INSERT','Name | Unit | Notes | ProductType','MassageBody | suất | có thêm khuyến mãi|03'),('2014-06-25 14:18:28','admin','Table:productprice | productprice=03000001|time=2014-06-25 14:19:30','INSERT','Price','60.00'),('2014-06-25 14:23:58','admin','Table:products | productid=03000001','UPDATE','Name | Unit | Notes | ProductType','Massage | ly | thêm hạt trân châu |02'),('2014-06-25 14:24:06','admin','Table:products | productid=03000002','UPDATE','Name | Unit | Notes | ProductType','MassageBody | suất | có thêm khuyến mãi|02'),('2014-06-25 14:24:17','admin','Table:products | productid=03000003','UPDATE','Name | Unit | Notes | ProductType','MassageBody | suất | có thêm khuyến mãi|02'),('2014-06-25 14:24:30','admin','Table:products | productid=02000001','UPDATE','Name | Unit | Notes | ProductType','Massage | ly | thêm hạt trân châu |02'),('2014-06-25 14:24:39','admin','Table:products | productid=02000002','UPDATE','Name | Unit | Notes | ProductType','MassageBody | suất | có thêm khuyến mãi|02'),('2014-06-25 14:24:44','admin','Table:products | productid=02000003','UPDATE','Name | Unit | Notes | ProductType','MassageBody | suất | có thêm khuyến mãi|02'),('2014-06-25 14:31:18','admin','Table:products | productid=00010002','INSERT','Name | Unit | Notes | ProductType','Cơm gà ác | chén | có thêm khuyến mãi|02'),('2014-06-25 14:32:03','admin','Table:productprice | productprice=00010002|time=2014-06-25 14:33:14','INSERT','Price','12.00'),('2014-06-25 14:32:54','admin','Table:products | productid=00030006','INSERT','Name | Unit | Notes | ProductType','Mắm thịt bầm | chén | có thêm khuyến mãi|00'),('2014-06-25 14:33:27','nhanvien','Table:productprice | productprice=00030006|time=2014-06-25 14:34:30','INSERT','Price','11.00'),('2014-06-25 14:34:20','admin','Table:products | productid=00030009','INSERT','Name | Unit | Notes | ProductType','Mắm tôm | chén | thịt kho tộ|00'),('2014-06-25 14:34:45','admin','Table:productprice | productprice=00030009|time=2014-06-17 14:35:54','INSERT','Price','15.00'),('2014-06-25 14:36:26','admin','Table:products | productid=01030001','INSERT','Name | Unit | Notes | ProductType','Rượu | ly | thịt kho tộ|01'),('2014-06-25 14:36:55','nhanvien','Table:productprice | productprice=01030001|time=2014-06-25 14:38:04','INSERT','Price','49.00'),('2014-06-25 14:38:34','admin','Table:products | productid=02000004','INSERT','Name | Unit | Notes | ProductType','MagaseBody | suất | masage wellness|02'),('2014-06-25 14:39:19','quanly','Table:productprice | productprice=02000004|time=2014-06-25 14:40:21','INSERT','Price','12.75'),('2014-06-25 14:40:41','admin','Table:products | productid=02000005','INSERT','Name | Unit | Notes | ProductType','MagaseMat | suất | masage mặt|02'),('2014-06-25 14:41:53','quanly','Table:productprice | productprice=02000005|time=2014-06-25 14:42:59','INSERT','Price','96.00'),('2014-06-25 14:42:13','admin','Table:products | productid=02000006','INSERT','Name | Unit | Notes | ProductType','MagaseMat | suất | masage mặt|02'),('2014-06-25 14:42:37','quanly','Table:productprice | productprice=02000006|time=2014-06-25 14:43:50','INSERT','Price','11.00'),('2014-06-25 14:43:37','admin','Table:products | productid=02000007','INSERT','Name | Unit | Notes | ProductType','MagaseMat | suất | masage mặt|02'),('2014-06-25 14:43:58','admin','Table:productprice | productprice=02000007|time=2014-06-25 14:45:10','INSERT','Price','89.00'),('2014-06-25 15:59:46','1455','Table:orders | orderid=0120140625001','UPDATE','DeskId | Note | Status | TotalTax | TotalAmmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','Desk_089 | chu y | |4556|4588|7|7899555|78'),('2014-06-25 15:59:54','admin','Table:orders | orderid=10','UPDATE','DeskId | Note | Status | TotalTax | TotalAmmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','DEsk_001 | D0124 | 45|12|78|7|6|5'),('2014-06-25 16:00:12','1455','Table:orders | orderid=1020140625001','UPDATE','DeskId | Note | Status | TotalTax | TotalAmmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','Desk_089 | chu y | |4556|4588|7|7899555|78'),('2014-06-25 16:00:54','admin','Table:orders | orderid=1020140625002','UPDATE','DeskId | Note | Status | TotalTax | TotalAmmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','DEsk_001 | D0124 | 45|12|78|7|6|5'),('2014-06-25 16:02:05','quanly','Table:orders | orderid=1020140625003','INSERT','DeskId | Note | Status | TotalTax | TotalAmmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','Desk_002 | Ghi chú Desk | hoatdong|13||||'),('2014-06-25 16:02:42','admin','Table:orders | orderid=1020140625003','UPDATE','DeskId | Note | Status | TotalTax | TotalAmmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','Desk_002 | Ghi chú Desk | hoatdong|13|89|9|14|12'),('2014-06-25 16:03:09','admin','Table:orders | orderid=1020140626003','UPDATE','DeskId | Note | Status | TotalTax | TotalAmmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','Desk_002 | Ghi chú Desk | hoatdong|13|89|9|14|12'),('2014-06-26 15:59:43','admin','Table:orders | orderid=1020140626004','INSERT','DeskId | Note | Status | TotalTax | TotalAmmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|160|377|0|377'),('2014-06-26 16:35:14','admin','Table:orders | orderid=1020140626005','INSERT','DeskId | Note | Status | TotalTax | TotalAmmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|121|166|0|166'),('2014-06-26 16:37:30','admin','Table:orders | orderid=1020140626006','INSERT','DeskId | Note | Status | TotalTax | TotalAmmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|497|2433|0|2433'),('2014-06-26 16:38:34','admin','Table:orders | orderid=1020140626007','INSERT','DeskId | Note | Status | TotalTax | TotalAmmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|288|384|0|384'),('2014-06-26 16:38:42','admin','Table:orders | orderid=1020140626008','INSERT','DeskId | Note | Status | TotalTax | TotalAmmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|709|3441|0|3441'),('2014-06-26 16:40:56','admin','Table:orders | orderid=1020140626009','INSERT','DeskId | Note | Status | TotalTax | TotalAmmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|43|88|0|88'),('2014-06-26 16:41:04','admin','Table:orders | orderid=10201406260010','INSERT','DeskId | Note | Status | TotalTax | TotalAmmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|211|1028|0|1028'),('2014-06-26 17:06:03','admin','Table:orders | orderid=1020140626010','INSERT','DeskId | Note | Status | TotalTax | TotalAmmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|43|88|0|88'),('2014-06-26 17:06:11','admin','Table:orders | orderid=1020140626011','INSERT','DeskId | Note | Status | TotalTax | TotalAmmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|207|1024|0|1024'),('2014-06-26 18:18:29','admin','Table:orders | orderid=1020140626012','INSERT','DeskId | Note | Status | TotalTax | TotalAmmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|121|166|0|166'),('2014-06-27 13:16:02','admin','Table:orders | orderid=102014062700001','INSERT','DeskId | Note | Status | TotalTax | TotalAmmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|41|86|0|86'),('2014-06-27 16:30:14','admin','Table:orders | orderid=102014062700002','INSERT','DeskId | Note | Status | TotalTax | TotalAmmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|121|121|0|0'),('2014-06-27 16:33:50','admin','Table:orders | orderid=102014062700003','INSERT','DeskId | Note | Status | TotalTax | TotalAmmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|13|13|0|0'),('2014-06-27 16:42:28','admin','Table:orders | orderid=102014062700004','INSERT','DeskId | Note | Status | TotalTax | TotalAmmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|33|33|0|0'),('2014-06-28 17:14:59','admin','Table:orders | orderid=102014062800001','INSERT','DeskId | Note | Status | TotalTax | TotalAmmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|427|427|0|427'),('2014-06-28 17:59:47','admin','Table:orders | orderid=102014062800002','INSERT','DeskId | Note | Status | TotalTax | TotalAmmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|106|106|0|106'),('2014-06-29 10:14:14','admin','Table:orders | orderid=102014062900001','INSERT','DeskId | Note | Status | TotalTax | TotalAmmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|26|26|0|26'),('2014-06-29 10:20:12','admin','Table:orders | orderid=102014062900002','INSERT','DeskId | Note | Status | TotalTax | TotalAmmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|22|22|0|22'),('2014-06-29 10:22:29','admin','Table:orders | orderid=102014062900003','INSERT','DeskId | Note | Status | TotalTax | TotalAmmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|101|101|0|101'),('2014-06-29 10:22:48','admin','Table:orders | orderid=102014062900004','INSERT','DeskId | Note | Status | TotalTax | TotalAmmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|56|56|0|56'),('2014-06-29 10:22:53','admin','Table:orders | orderid=102014062900005','INSERT','DeskId | Note | Status | TotalTax | TotalAmmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|75|75|0|75'),('2014-06-29 14:26:32','admin','Table:orders | orderid=102014062900003','UPDATE','DeskId | Note | Status | TotalTax | TotalAmmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','1 |  | 0|0|101|101|0|101'),('2014-06-29 14:26:39','admin','Table:orders | orderid=102014062900004','UPDATE','DeskId | Note | Status | TotalTax | TotalAmmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','2 |  | 0|0|56|56|0|56'),('2014-06-29 14:26:45','admin','Table:orders | orderid=102014062900005','UPDATE','DeskId | Note | Status | TotalTax | TotalAmmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','3 |  | 0|0|75|75|0|75'),('2014-06-29 18:19:34','admin','Table:orders | orderid=102014062900006','INSERT','DeskId | Note | Status | TotalTax | TotalAmmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|10000|10000|0|10000'),('2014-06-30 11:09:22','admin','Table:orders | orderid=102014062900005','UPDATE','DeskId | Note | Status | TotalTax | TotalAmmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','3 |  | 1|0|75|75|0|75'),('2014-06-30 16:41:32','admin','Table:receipts | receiptid=1101140630000001','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 10012.00|0.00|10012.00|100000.00|10000.00'),('2014-06-30 16:41:37','','Table:orders | orderid=102014062900006','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|10000|10000|0|10000'),('2014-06-30 16:47:25','admin','Table:receipts | receiptid=1101140630000002','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 89.00|0.00|89.00|100.00|89.00'),('2014-06-30 16:47:26','admin','Table:orders | orderid=102014062900003','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','1 |  | 0|0|101|101|0|101'),('2014-06-30 16:47:27','admin','Table:orders | orderid=102014063000001','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|900000|900000|0|900000'),('2014-06-30 17:09:59','admin','Table:orders | orderid=102014062900005','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','3 |  | 0|0|75|75|0|75'),('2014-06-30 17:10:10','admin','Table:orders | orderid=102014062900006','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|10000|10000|0|10000'),('2014-06-30 17:10:15','admin','Table:orders | orderid=102014063000001','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|900000|900000|0|900000'),('2014-06-30 17:13:15','admin','Table:orders | orderid=102014062900005','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','3 |  | 0|0|75|75|0|75'),('2014-06-30 17:16:02','admin','Table:orders | orderid=102014062900005','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','3 |  | 0|0|75|75|0|75'),('2014-06-30 17:18:27','admin','Table:orders | orderid=102014062900005','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','3 |  | 1|0|75|75|0|75'),('2014-06-30 17:20:12','admin','Table:receipts | receiptid=1101140630000003','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 910000.00|0.00|910000.00|1000000.00|900000.00'),('2014-06-30 17:20:13','admin','Table:orders | orderid=102014062900006','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 1|0|10000|10000|0|10000'),('2014-06-30 17:20:16','admin','Table:orders | orderid=102014063000001','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 1|0|900000|900000|0|900000'),('2014-06-30 17:32:45','admin','Table:receipts | receiptid=1101140630000004','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 101.00|0.00|101.00|1000.00|100.00'),('2014-06-30 17:32:46','admin','Table:orders | orderid=102014062900003','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','1 |  | 1|0|101|101|0|101'),('2014-06-30 19:18:48','admin','Table:receipts | receiptid=1101140630000005','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 56.00|0.00|56.00|56.00|56.00'),('2014-06-30 19:19:27','admin','Table:orders | orderid=102014062900004','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','2 |  | 1|0|56|56|0|56'),('2014-07-01 12:55:02','admin','Table:orders | orderid=102014070100001','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|1006000|1006000|1000|1005000'),('2014-07-01 12:56:09','admin','Table:receipts | receiptid=1101140701000001','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 967000.00|0.00|967000.00|1000000.00|960000.00'),('2014-07-01 12:56:52','','Table:orders | orderid=102014070100001','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 1|0|1006000|1006000|1000|1005000'),('2014-07-01 12:56:52','admin','Table:receipts | receiptid=1101140701000002','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 39000.00|0.00|39000.00|30000.00|30000.00'),('2014-07-01 14:13:38','admin','Table:orders | orderid=102014070100002','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|1860000|1860000|0|1860000'),('2014-07-01 14:14:17','admin','Table:orders | orderid=102014070100003','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|30000|30000|0|30000'),('2014-07-01 14:41:56','admin','Table:orders | orderid=102014070100004','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|190000|190000|0|190000'),('2014-07-01 14:45:28','admin','Table:orders | orderid=102014070100005','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|30000|30000|0|30000'),('2014-07-01 14:45:38','admin','Table:orders | orderid=102014070100006','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|194000|194000|0|194000'),('2014-07-01 14:47:25','admin','Table:orders | orderid=102014070100007','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|134000|134000|0|134000'),('2014-07-01 14:48:01','admin','Table:orders | orderid=102014070100008','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|86000|86000|0|86000'),('2014-07-01 14:48:25','admin','Table:orders | orderid=102014070100009','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|22000|22000|0|22000'),('2014-07-01 14:49:41','admin','Table:orders | orderid=102014070100010','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|930000|930000|0|930000'),('2014-07-01 15:05:08','admin','Table:orders | orderid=102014070100011','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|915000|915000|0|915000'),('2014-07-01 15:15:43','admin','Table:receipts | receiptid=1101140701000003','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 134000.00|0.00|134000.00|134000.00|134000.00'),('2014-07-01 15:16:05','','Table:orders | orderid=102014070100006','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 1|0|194000|194000|0|194000'),('2014-07-01 15:16:05','admin','Table:receipts | receiptid=1101140701000004','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 60000.00|0.00|60000.00|60000.00|60000.00'),('2014-07-01 15:17:14','','Table:orders | orderid=102014070100002','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 1|0|1860000|1860000|0|1860000'),('2014-07-01 15:17:14','admin','Table:receipts | receiptid=1101140701000005','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 1860000.00|0.00|1860000.00|2000000.00|1860000.00'),('2014-07-01 15:17:40','admin','Table:receipts | receiptid=1101140701000006','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 178000.00|0.00|178000.00|200000.00|178000.00'),('2014-07-01 15:18:37','','Table:orders | orderid=102014070100004','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 1|0|190000|190000|0|190000'),('2014-07-01 15:18:37','admin','Table:receipts | receiptid=1101140701000007','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 12000.00|0.00|12000.00|15000.00|12000.00'),('2014-07-01 16:34:30','','Table:orders | orderid=102014070100011','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 1|0|915000|915000|0|915000'),('2014-07-01 16:34:30','admin','Table:receipts | receiptid=1101140701000008','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 915000.00|0.00|915000.00|1000000.00|900000.00'),('2014-07-01 16:35:16','','Table:orders | orderid=102014070100008','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 1|0|86000|86000|0|86000'),('2014-07-01 16:35:16','admin','Table:receipts | receiptid=1101140701000009','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 86000.00|0.00|86000.00|90000.00|86000.00'),('2014-07-01 16:35:29','','Table:orders | orderid=102014070100003','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 1|0|30000|30000|0|30000'),('2014-07-01 16:35:29','admin','Table:receipts | receiptid=1101140701000010','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 30000.00|0.00|30000.00|50000.00|30000.00'),('2014-07-01 16:35:35','','Table:orders | orderid=102014070100007','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 1|0|134000|134000|0|134000'),('2014-07-01 16:35:35','admin','Table:receipts | receiptid=1101140701000011','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 134000.00|0.00|134000.00|150000.00|134000.00'),('2014-07-01 16:35:41','','Table:orders | orderid=102014070100005','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 1|0|30000|30000|0|30000'),('2014-07-01 16:35:41','admin','Table:receipts | receiptid=1101140701000012','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 30000.00|0.00|30000.00|30000.00|30000.00'),('2014-07-01 16:35:47','','Table:orders | orderid=102014070100009','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 1|0|22000|22000|0|22000'),('2014-07-01 16:35:47','admin','Table:receipts | receiptid=1101140701000013','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 22000.00|0.00|22000.00|50000.00|22000.00'),('2014-07-01 16:35:53','','Table:orders | orderid=102014070100010','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 1|0|930000|930000|0|930000'),('2014-07-01 16:35:53','admin','Table:receipts | receiptid=1101140701000014','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 930000.00|0.00|930000.00|930000.00|930000.00'),('2014-07-01 16:50:56','admin','Table:orders | orderid=102014070100012','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|26000|26000|0|26000'),('2014-07-01 17:15:04','admin','Table:orders | orderid=102014070100013','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|15000|15000|0|15000'),('2014-07-01 17:24:52','admin','Table:orders | orderid=102014070100014','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|192000|192000|0|192000'),('2014-07-01 17:34:45','admin','Table:orders | orderid=102014070100015','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|24000|24000|0|24000'),('2014-07-01 17:42:33','','Table:orders | orderid=102014070100012','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 1|0|26000|26000|0|26000'),('2014-07-01 17:42:33','admin','Table:receipts | receiptid=1101140701000015','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 26000.00|0.00|26000.00|30000.00|25500.00'),('2014-07-01 17:54:08','admin','Table:receipts | receiptid=1101140701000016','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 192000.00|0.00|192000.00|200000.00|190000.00'),('2014-07-01 17:54:09','','Table:orders | orderid=102014070100014','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 1|0|192000|192000|0|192000'),('2014-07-01 18:01:12','','Table:orders | orderid=102014070100015','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 1|0|24000|24000|0|24000'),('2014-07-01 18:01:12','admin','Table:receipts | receiptid=1101140701000017','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 24000.00|0.00|24000.00|50000.00|20000.00'),('2014-07-01 18:08:00','','Table:orders | orderid=102014070100013','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 1|0|15000|15000|0|15000'),('2014-07-01 18:08:00','admin','Table:receipts | receiptid=1101140701000018','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 15000.00|0.00|15000.00|15000.00|14000.00'),('2014-07-01 18:18:34','admin','Table:orders | orderid=102014070100016','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|26000|26000|333|25667'),('2014-07-01 18:26:39','admin','Table:orders | orderid=102014070100017','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|0'),('2014-07-01 18:28:11','admin','Table:orders | orderid=102014070100018','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|0'),('2014-07-01 18:29:35','admin','Table:orders | orderid=102014070100019','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|0'),('2014-07-01 18:31:43','','Table:orders | orderid=102014070100017','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|89662'),('2014-07-01 18:35:05','admin','Table:orders | orderid=102014070100020','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|915000|915000|0|915000'),('2014-07-01 18:39:34','admin','Table:orders | orderid=102014070100021','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|23001'),('2014-07-01 18:41:30','admin','Table:orders | orderid=102014070100022','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|0'),('2014-07-01 18:42:19','admin','Table:orders | orderid=102014070100023','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|0'),('2014-07-01 18:43:37','admin','Table:orders | orderid=102014070100024','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|23001'),('2014-07-01 18:44:04','admin','Table:orders | orderid=102014070100025','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|12001'),('2014-07-01 18:50:10','admin','Table:orders | orderid=102014070100026','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|915000'),('2014-07-01 18:53:48','admin','Table:orders | orderid=102014070100027','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|26000'),('2014-07-01 18:54:48','admin','Table:orders | orderid=102014070100028','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|989000|989000|65|988935'),('2014-07-01 18:55:11','admin','Table:orders | orderid=102014070100029','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','13 |  | 0|0|12000|12000|0|12000'),('2014-07-01 18:57:32','admin','Table:orders | orderid=102014070100030','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','13 |  | 0|0|0|0|0|11000'),('2014-07-01 18:58:34','admin','Table:orders | orderid=102014070100031','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','13 |  | 0|0|0|0|0|12001'),('2014-07-01 18:59:05','admin','Table:orders | orderid=102014070100032','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','13 |  | 0|0|0|0|0|10000'),('2014-07-01 18:59:37','admin','Table:orders | orderid=102014070100033','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','2 |  | 0|0|15000|15000|0|15000'),('2014-07-01 19:01:27','admin','Table:orders | orderid=102014070100034','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','13 |  | 0|0|0|0|0|10000'),('2014-07-01 19:02:01','admin','Table:orders | orderid=102014070100035','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','13 |  | 0|0|11000|11000|0|11000'),('2014-07-01 19:02:29','admin','Table:orders | orderid=102014070100036','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','13 |  | 0|0|0|0|0|65000'),('2014-07-01 19:02:53','admin','Table:orders | orderid=102014070100037','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','13 |  | 0|0|74000|74000|0|74000'),('2014-07-01 19:03:23','admin','Table:orders | orderid=102014070100038','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','13 |  | 0|0|60000|60000|0|60000'),('2014-07-01 19:05:17','admin','Table:orders | orderid=102014070100039','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|60000|60000|0|60000'),('2014-07-01 19:07:53','admin','Table:orders | orderid=102014070100040','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|24000|24000|0|24000'),('2014-07-01 19:08:40','','Table:orders | orderid=102014070100036','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','13 |  | 1|0|0|0|0|65000'),('2014-07-01 19:08:40','admin','Table:receipts | receiptid=1101140701000019','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 65000.00|0.00|65000.00|3330.00|52590.00'),('2014-07-01 19:08:56','admin','Table:orders | orderid=102014070100041','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|14000|14000|0|14000'),('2014-07-01 19:40:13','admin','Table:orders | orderid=102014070100042','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','12 |  | 0|0|11000|11000|0|11000'),('2014-07-01 19:40:40','admin','Table:orders | orderid=102014070100043','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','12 |  | 0|0|0|0|0|10000'),('2014-07-01 19:46:44','','Table:orders | orderid=102014070100042','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','12 |  | 1|0|11000|11000|0|11000'),('2014-07-01 19:46:44','admin','Table:receipts | receiptid=1101140701000020','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 11000.00|0.00|11000.00|2555569.00|8780.00'),('2014-07-01 20:02:36','admin','Table:orders | orderid=102014070100044','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','2 |  | 0|0|915000|915000|0|915000'),('2014-07-01 20:03:26','admin','Table:orders | orderid=102014070100045','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','12 |  | 0|0|0|0|0|23000'),('2014-07-01 20:04:33','admin','Table:orders | orderid=102014070100046','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','12 |  | 0|0|26000|26000|0|26000'),('2014-07-01 20:05:47','admin','Table:receipts | receiptid=1101140701000021','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 37000.00|0.00|37000.00|37000.00|37000.00'),('2014-07-01 20:05:49','admin','Table:orders | orderid=102014070100047','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','12 |  | 0|0|0|0|0|490000'),('2014-07-01 20:06:14','','Table:orders | orderid=102014070100016','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 1|0|26000|26000|333|25667'),('2014-07-01 20:06:17','','Table:orders | orderid=102014070100017','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 1|0|0|0|0|89662'),('2014-07-01 20:08:48','admin','Table:receipts | receiptid=1101140701000022','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 1468000.00|0.00|1468000.00|1500000.00|1468000.00'),('2014-07-01 20:08:55','','Table:orders | orderid=102014070100018','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 1|0|0|0|0|0'),('2014-07-01 20:08:56','','Table:orders | orderid=102014070100020','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 1|0|915000|915000|0|915000'),('2014-07-01 20:08:57','','Table:orders | orderid=102014070100045','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','12 |  | 1|0|0|0|0|23000'),('2014-07-01 20:09:01','','Table:orders | orderid=102014070100046','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','12 |  | 1|0|26000|26000|0|26000'),('2014-07-01 20:10:10','','Table:orders | orderid=102014070100044','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','2 |  | 1|0|915000|915000|0|915000'),('2014-07-01 20:10:10','admin','Table:receipts | receiptid=1101140701000023','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 990000.00|0.00|990000.00|1000000.00|990000.00'),('2014-07-01 20:25:39','admin','Table:receipts | receiptid=1101140701000024','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 90001.00|0.00|90001.00|900000.00|90000.00'),('2014-07-01 20:25:49','','Table:orders | orderid=102014070100019','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 1|0|0|0|0|0'),('2014-07-01 20:25:59','','Table:orders | orderid=102014070100021','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 1|0|0|0|0|23001'),('2014-07-01 20:26:07','','Table:orders | orderid=102014070100022','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 1|0|0|0|0|0'),('2014-07-01 20:26:26','admin','Table:receipts | receiptid=1101140701000025','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 145000.00|0.00|145000.00|140000.00|140000.00'),('2014-07-01 20:26:29','','Table:orders | orderid=102014070100038','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','13 |  | 1|0|60000|60000|0|60000'),('2014-07-01 20:26:40','','Table:orders | orderid=102014070100037','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','13 |  | 1|0|74000|74000|0|74000'),('2014-07-01 20:26:43','','Table:orders | orderid=102014070100035','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','13 |  | 1|0|11000|11000|0|11000'),('2014-07-01 20:27:07','admin','Table:receipts | receiptid=1101140701000026','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 55001.00|0.00|55001.00|500000.00|55001.00'),('2014-07-01 20:27:10','','Table:orders | orderid=102014070100034','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','13 |  | 1|0|0|0|0|10000'),('2014-07-01 20:27:14','','Table:orders | orderid=102014070100032','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','13 |  | 1|0|0|0|0|10000'),('2014-07-01 20:27:17','','Table:orders | orderid=102014070100031','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','13 |  | 1|0|0|0|0|12001'),('2014-07-01 20:27:22','','Table:orders | orderid=102014070100030','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','13 |  | 1|0|0|0|0|11000'),('2014-07-01 20:27:25','','Table:orders | orderid=102014070100029','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','13 |  | 1|0|12000|12000|0|12000'),('2014-07-01 20:28:12','admin','Table:receipts | receiptid=1101140701000027','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 2574002.00|0.00|2574002.00|3000000.00|2574002.00'),('2014-07-01 20:28:14','','Table:orders | orderid=102014070100047','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','12 |  | 1|0|0|0|0|490000'),('2014-07-01 20:28:15','','Table:orders | orderid=102014070100043','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','12 |  | 1|0|0|0|0|10000'),('2014-07-01 20:28:17','','Table:orders | orderid=102014070100041','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 1|0|14000|14000|0|14000'),('2014-07-01 20:28:25','','Table:orders | orderid=102014070100027','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 1|0|0|0|0|26000'),('2014-07-01 20:28:36','','Table:orders | orderid=102014070100026','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 1|0|0|0|0|915000'),('2014-07-01 20:28:39','','Table:orders | orderid=102014070100025','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 1|0|0|0|0|12001'),('2014-07-01 20:28:43','','Table:orders | orderid=102014070100023','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 1|0|0|0|0|0'),('2014-07-01 20:28:50','','Table:orders | orderid=102014070100024','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 1|0|0|0|0|23001'),('2014-07-01 20:28:56','','Table:orders | orderid=102014070100028','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 1|0|989000|989000|65|988935'),('2014-07-01 20:28:59','','Table:orders | orderid=102014070100039','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 1|0|60000|60000|0|60000'),('2014-07-01 20:29:05','','Table:orders | orderid=102014070100040','UPDATE','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 1|0|24000|24000|0|24000'),('2014-07-01 20:48:35','admin','Table:orders | orderid=102014070100048','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|96000'),('2014-07-01 20:48:57','admin','Table:orders | orderid=102014070100049','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|89000'),('2014-07-01 20:49:22','admin','Table:orders | orderid=102014070100050','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','12 |  | 0|0|15000|15000|0|15000'),('2014-07-01 20:51:01','admin','Table:orders | orderid=102014070100051','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|26000|26000|0|26000'),('2014-07-01 20:53:03','admin','Table:orders | orderid=102014070100052','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|10000'),('2014-07-01 20:53:06','admin','Table:orders | orderid=102014070100053','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|11000|11000|0|11000'),('2014-07-01 20:53:30','admin','Table:orders | orderid=102014070100054','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','13 |  | 0|0|71000|71000|0|71000'),('2014-07-01 20:53:37','admin','Table:orders | orderid=102014070100055','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','13 |  | 0|0|23001|23001|0|23001'),('2014-07-01 20:54:12','admin','Table:orders | orderid=102014070100056','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','13 |  | 0|0|65000|65000|0|65000'),('2014-07-01 20:54:38','admin','Table:orders | orderid=102014070100057','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','13 |  | 0|0|60000|60000|0|60000'),('2014-07-01 20:55:20','admin','Table:orders | orderid=102014070100058','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','13 |  | 0|0|0|0|0|12000'),('2014-07-01 20:56:01','admin','Table:orders | orderid=102014070100059','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','13 |  | 0|0|0|0|0|12001'),('2014-07-01 20:56:23','admin','Table:orders | orderid=102014070100060','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','2 |  | 0|0|96000|96000|0|96000'),('2014-07-01 20:56:42','admin','Table:orders | orderid=102014070100061','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','2 |  | 0|0|156000|156000|0|156000'),('2014-07-01 20:56:59','admin','Table:orders | orderid=102014070100062','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','2 |  | 0|0|60000|60000|0|60000'),('2014-07-01 20:57:31','admin','Table:orders | orderid=102014070100063','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','13 |  | 0|0|71000|71000|0|71000'),('2014-07-01 20:58:07','admin','Table:orders | orderid=102014070100064','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','12 |  | 0|0|96000|96000|0|96000'),('2014-07-01 20:59:10','admin','Table:orders | orderid=102014070100065','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|1815000'),('2014-07-01 20:59:32','admin','Table:orders | orderid=102014070100066','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','12 |  | 0|0|15000|15000|0|15000'),('2014-07-01 20:59:48','admin','Table:orders | orderid=102014070100067','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','12 |  | 0|0|900000|900000|0|900000'),('2014-07-01 21:00:15','admin','Table:orders | orderid=102014070100068','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','12 |  | 0|0|14000|14000|0|14000'),('2014-07-01 21:00:37','admin','Table:orders | orderid=102014070100069','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','12 |  | 0|0|38000|38000|0|38000'),('2014-07-01 21:01:33','admin','Table:orders | orderid=102014070100070','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','13 |  | 0|0|24000|24000|0|24000'),('2014-07-01 21:01:46','admin','Table:orders | orderid=102014070100071','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','13 |  | 0|0|504000|504000|0|504000'),('2014-07-01 21:04:14','admin','Table:orders | orderid=102014070100072','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|915000'),('2014-07-01 21:04:22','admin','Table:orders | orderid=102014070100073','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|15000'),('2014-07-01 21:04:39','admin','Table:orders | orderid=102014070100074','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','12 |  | 0|0|15000|15000|0|15000'),('2014-07-01 21:07:58','admin','Table:orders | orderid=102014070100075','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|24001'),('2014-07-01 21:08:28','admin','Table:orders | orderid=102014070100076','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','13 |  | 0|0|5000|5000|0|5000'),('2014-07-01 21:14:34','admin','Table:receipts | receiptid=1101140701000028','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 627000.00|0.00|627000.00|969430.00|625790.00'),('2014-07-01 21:15:04','admin','Table:orders | orderid=102014070100077','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|500000'),('2014-07-01 21:15:26','admin','Table:orders | orderid=102014070100078','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','13 |  | 0|0|60000|60000|0|60000'),('2014-07-01 21:46:58','admin','Table:receipts | receiptid=1101140701000029','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 60000.00|0.00|60000.00|66666.00|59000.00'),('2014-07-01 21:48:56','admin','Table:orders | orderid=102014070100079','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','12 |  | 0|0|12001|12001|0|12001'),('2014-07-01 22:03:56','admin','Table:receipts | receiptid=1101140701000030','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 115000.00|0.00|115000.00|200000.00|110000.00'),('2014-07-02 10:17:42','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','123456 | admin | 1 | admin'),('2014-07-02 10:40:52','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-02 13:48:45','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','08158291 | admin | 1 | admin'),('2014-07-02 13:49:40','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-02 13:56:50','admin','Table:orders | orderid=102014070200001','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|915000'),('2014-07-02 13:57:19','admin','Table:orders | orderid=102014070200002','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','2 |  | 0|0|11000|11000|0|11000'),('2014-07-02 14:28:40','nhanvien','Table:users | userid=nhanvien','UPDATE','pwd | ObjectId | Status | RoleId','08158291 | nhanvien |  | '),('2014-07-02 14:29:12','kimthuan','Table:users | userid=kimthuan','UPDATE','pwd | ObjectId | Status | RoleId','08158291 | hoatdong | 1 | hoatdong'),('2014-07-02 14:32:09','nhanvien','Table:users | userid=nhanvien','UPDATE','pwd | ObjectId | Status | RoleId','08158291 | nhanvien | 1 | '),('2014-07-02 14:32:59','nhanvien','Table:users | userid=nhanvien','UPDATE','pwd | ObjectId | Status | RoleId','08158291 | nhanvien | 1 | nhanvien'),('2014-07-02 14:34:58','kimthuan','Table:users | userid=kimthuan','UPDATE','pwd | ObjectId | Status | RoleId','08158291 | nhanvien | 1 | nhanvien'),('2014-07-02 14:36:07','kimthuan','Table:users | userid=kimthuan','UPDATE','pwd | ObjectId | Status | RoleId','08158291 | nhanvien | 1 | letan'),('2014-07-02 14:36:11','nhanvien','Table:users | userid=nhanvien','UPDATE','pwd | ObjectId | Status | RoleId','08158291 | nhanvien | 1 | letan'),('2014-07-02 14:48:00','kimthuan','Table:orders | orderid=102014070200003','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|394000|394000|0|394000'),('2014-07-02 15:31:03','kimthuan','Table:orders | orderid=102014070200004','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|29000'),('2014-07-02 15:36:19','kimthuan','Table:orders | orderid=102014070200005','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','14 |  | 0|0|0|0|0|12000'),('2014-07-02 15:36:31','kimthuan','Table:orders | orderid=102014070200006','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','14 |  | 0|0|0|0|0|12000'),('2014-07-02 15:37:53','admin','Table:orders | orderid=102014070200007','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|24001'),('2014-07-02 15:40:02','kimthuan','Table:receipts | receiptid=1101140702000001','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 11000.00|0.00|11000.00|3000.00|8000.00'),('2014-07-02 15:53:32','kimthuan','Table:orders | orderid=102014070200008','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|911000'),('2014-07-02 15:55:40','kimthuan','Table:orders | orderid=102014070200009','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|108001'),('2014-07-02 15:59:49','admin','Table:receipts | receiptid=1101140702000002','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 1019001.00|0.00|1019001.00|2000.00|1017001.00'),('2014-07-02 16:05:56','admin','Table:orders | orderid=102014070200010','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|24000'),('2014-07-02 16:14:31','kimthuan','Table:orders | orderid=102014070200011','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','12 |  | 0|0|12000|12000|0|12000'),('2014-07-02 16:16:07','kimthuan','Table:orders | orderid=102014070200012','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','12 |  | 0|0|0|0|0|96000'),('2014-07-02 16:25:20','admin','Table:orders | orderid=102014070200013','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|500000'),('2014-07-02 16:27:41','admin','Table:orders | orderid=102014070200014','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','14 |  | 0|0|0|0|0|500000'),('2014-07-02 16:29:15','admin','Table:orders | orderid=102014070200015','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|915000'),('2014-07-02 16:34:34','admin','Table:orders | orderid=102014070200016','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|24000'),('2014-07-02 16:43:33','admin','Table:orders | orderid=102014070200017','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|23001'),('2014-07-02 16:46:21','admin','Table:orders | orderid=102014070200018','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|24000'),('2014-07-02 16:53:14','admin','Table:orders | orderid=102014070200019','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|500000'),('2014-07-02 16:53:45','admin','Table:orders | orderid=102014070200020','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|72001'),('2014-07-02 17:02:55','kimthuan','Table:orders | orderid=102014070200021','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','13 |  | 0|0|0|0|0|24000'),('2014-07-02 17:03:11','kimthuan','Table:orders | orderid=102014070200022','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','13 |  | 0|0|0|0|0|108001'),('2014-07-02 17:05:12','kimthuan','Table:orders | orderid=102014070200023','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','13 |  | 0|0|500000|500000|250000|250000'),('2014-07-02 17:05:40','kimthuan','Table:orders | orderid=102014070200024','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|26000|26000|8|25992'),('2014-07-02 17:13:33','kimthuan','Table:receipts | receiptid=1101140702000003','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 526000.00|0.00|526000.00|8999.00|517001.00'),('2014-07-02 17:18:32','kimthuan','Table:orders | orderid=102014070200025','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','12 |  | 0|0|134000|134000|0|134000'),('2014-07-02 17:19:41','kimthuan','Table:orders | orderid=102014070200026','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','14 |  | 0|0|0|0|0|911000'),('2014-07-02 17:19:52','kimthuan','Table:orders | orderid=102014070200027','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','14 |  | 0|0|0|0|0|101000'),('2014-07-02 17:22:47','kimthuan','Table:orders | orderid=102014070200028','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','14 |  | 0|0|0|0|0|1015001'),('2014-07-02 17:31:02','kimthuan','Table:orders | orderid=102014070200029','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|994000'),('2014-07-02 17:34:34','kimthuan','Table:orders | orderid=102014070200030','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','12 |  | 0|0|0|0|0|70000'),('2014-07-02 17:35:06','kimthuan','Table:orders | orderid=102014070200031','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','12 |  | 0|0|0|0|0|220000'),('2014-07-02 17:35:14','kimthuan','Table:orders | orderid=102014070200032','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','12 |  | 0|0|0|0|0|42001'),('2014-07-02 17:38:07','admin','Table:orders | orderid=102014070200033','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','15 |  | 0|0|12001|12001|0|12001'),('2014-07-02 17:43:11','admin','Table:orders | orderid=102014070200034','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','15 |  | 0|0|12001|12001|0|12001'),('2014-07-02 17:44:26','kimthuan','Table:receipts | receiptid=1101140702000004','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 645001.00|0.00|645001.00|2333.00|642668.00'),('2014-07-02 17:45:36','admin','Table:orders | orderid=102014070200035','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','16 |  | 0|0|0|0|0|23001'),('2014-07-02 17:48:30','kimthuan','Table:receipts | receiptid=1101140702000005','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 113002.00|0.00|113002.00|0.00|113002.00'),('2014-07-02 17:56:59','admin','Table:orders | orderid=102014070200036','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|35000|35000|0|35000'),('2014-07-02 17:58:25','admin','Table:receipts | receiptid=1101140702000006','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 407001.00|0.00|407001.00|12520.00|394481.00'),('2014-07-03 09:41:03','admin','Table:orders | orderid=102014070300001','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|72001|72001|0|72001'),('2014-07-03 09:42:28','admin','Table:orders | orderid=102014070300002','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|168001'),('2014-07-03 09:42:45','admin','Table:orders | orderid=102014070300003','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|267000'),('2014-07-03 09:43:31','admin','Table:orders | orderid=102014070300004','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|197000'),('2014-07-03 10:38:06','admin','Table:orders | orderid=102014070300005','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','23 |  | 0|0|0|0|0|86000'),('2014-07-03 10:38:20','admin','Table:orders | orderid=102014070300006','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','23 |  | 0|0|0|0|0|50000'),('2014-07-03 10:38:28','admin','Table:orders | orderid=102014070300007','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','23 |  | 0|0|0|0|0|101000'),('2014-07-03 10:38:36','admin','Table:orders | orderid=102014070300008','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','23 |  | 0|0|0|0|0|24000'),('2014-07-03 10:42:44','admin','Table:orders | orderid=102014070300009','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|195000'),('2014-07-03 10:43:24','admin','Table:orders | orderid=102014070300010','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|36000'),('2014-07-03 10:44:02','admin','Table:orders | orderid=102014070300011','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|990000'),('2014-07-03 10:44:46','admin','Table:orders | orderid=102014070300012','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|945000'),('2014-07-03 11:13:14','admin','Table:orders | orderid=102014070300013','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','21 |  | 0|0|71000|71000|30000|41000'),('2014-07-03 11:13:58','admin','Table:orders | orderid=102014070300014','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','21 |  | 0|0|41000|41000|2000|39000'),('2014-07-03 11:14:09','admin','Table:orders | orderid=102014070300015','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','21 |  | 0|0|0|0|0|55000'),('2014-07-03 11:14:41','admin','Table:orders | orderid=102014070300016','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','21 |  | 0|0|24000|24000|0|24000'),('2014-07-03 11:33:08','admin','Table:receipts | receiptid=1101140703000001','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 149000.00|0.00|149000.00|2111.00|146889.00'),('2014-07-03 12:03:33','admin','Table:receipts | receiptid=1101140703000002','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 10000.00|0.00|10000.00|0.00|10000.00'),('2014-07-03 12:03:49','admin','Table:receipts | receiptid=1101140703000003','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 1815000.00|0.00|1815000.00|0.00|1815000.00'),('2014-07-03 12:04:02','admin','Table:receipts | receiptid=1101140703000004','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 915000.00|0.00|915000.00|0.00|915000.00'),('2014-07-03 12:04:19','admin','Table:receipts | receiptid=1101140703000005','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 1454001.00|0.00|1454001.00|0.00|1454001.00'),('2014-07-03 12:04:37','admin','Table:receipts | receiptid=1101140703000006','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 971001.00|0.00|971001.00|0.00|971001.00'),('2014-07-03 12:04:59','admin','Table:receipts | receiptid=1101140703000007','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 3085004.00|0.00|3085004.00|0.00|3085004.00'),('2014-07-03 12:05:28','admin','Table:receipts | receiptid=1101140703000008','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 3941001.00|0.00|3941001.00|0.00|3941001.00'),('2014-07-03 12:05:56','admin','Table:receipts | receiptid=1101140703000009','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 1424003.00|0.00|1424003.00|0.00|1424003.00'),('2014-07-03 12:06:19','admin','Table:receipts | receiptid=1101140703000010','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 1267001.00|0.00|1267001.00|0.00|1267001.00'),('2014-07-03 13:22:04','admin','Table:orders | orderid=102014070300017','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','17 |  | 0|0|1035000|1035000|500000|535000'),('2014-07-03 13:22:20','admin','Table:orders | orderid=102014070300018','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','17 |  | 0|0|0|0|0|41000'),('2014-07-03 13:22:40','admin','Table:orders | orderid=102014070300019','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','17 |  | 0|0|0|0|0|22000'),('2014-07-03 14:30:14','admin','Table:orders | orderid=102014070300020','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|28001|28001|0|28001'),('2014-07-03 14:30:23','admin','Table:orders | orderid=102014070300021','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','15 |  | 0|0|71000|71000|0|71000'),('2014-07-03 14:31:15','admin','Table:receipts | receiptid=1101140703000011','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 99001.00|0.00|99001.00|0.00|99001.00'),('2014-07-03 14:31:44','admin','Table:receipts | receiptid=1101140703000012','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 1076000.00|0.00|1076000.00|0.00|1076000.00'),('2014-07-03 14:32:15','admin','Table:receipts | receiptid=1101140703000013','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 66000.00|0.00|66000.00|0.00|66000.00'),('2014-07-03 14:33:46','admin','Table:orders | orderid=102014070300022','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|20000|20000|0|20000'),('2014-07-03 14:33:59','admin','Table:orders | orderid=102014070300023','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|34000'),('2014-07-03 14:34:08','admin','Table:orders | orderid=102014070300024','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|504000'),('2014-07-03 14:34:50','admin','Table:receipts | receiptid=1101140703000014','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 558000.00|0.00|558000.00|0.00|558000.00'),('2014-07-04 08:49:49','admin','Table:orders | orderid=102014070400001','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','17 |  | 0|0|165000|165000|0|165000'),('2014-07-04 08:52:32','admin','Table:orders | orderid=102014070400002','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','17 |  | 0|0|512000|512000|0|512000'),('2014-07-04 08:59:16','admin','Table:orders | orderid=102014070400003','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','17 |  | 0|0|84002|84002|3000|81002'),('2014-07-04 09:01:06','admin','Table:orders | orderid=102014070400004','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|926000|926000|8900|917100'),('2014-07-04 09:01:24','admin','Table:orders | orderid=102014070400005','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','26 |  | 0|0|930000|930000|1200|928800'),('2014-07-04 09:05:22','admin','Table:receipts | receiptid=1101140704000001','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 930000.00|0.00|930000.00|1220.00|928780.00'),('2014-07-04 10:25:35','admin','Table:orders | orderid=102014070400006','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|34001|34001|0|34001'),('2014-07-04 13:28:54','admin','Table:products | productid=DISCOUNT','INSERT','Name | Unit | Notes | ProductType','Discount | lần | |99'),('2014-07-04 13:33:41','admin','Table:orders | orderid=102014070400007','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|100000|100000|7866|92134'),('2014-07-04 14:02:51','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','123456 | admin | 1 | admin'),('2014-07-04 14:03:27','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-04 14:07:29','admin','Table:orders | orderid=102014070400008','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|1004000|1004000|0|1004000'),('2014-07-04 14:07:57','admin','Table:orders | orderid=102014070400009','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|915000|915000|150|914850'),('2014-07-04 14:08:06','admin','Table:orders | orderid=102014070400010','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|26000'),('2014-07-04 14:14:20','admin','Table:orders | orderid=102014070400011','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|912000|912000|1444|910556'),('2014-07-04 14:14:44','admin','Table:orders | orderid=102014070400012','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','18 |  | 0|0|60000|60000|0|60000'),('2014-07-04 14:17:05','admin','Table:orders | orderid=102014070400013','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','18 |  | 0|0|0|0|0|56000'),('2014-07-04 14:17:25','admin','Table:orders | orderid=102014070400014','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','18 |  | 0|0|12000|12000|14|11986'),('2014-07-08 11:18:43','admin','Table:orders | orderid=102014070800001','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|1049001|1049001|1200|1047801'),('2014-07-08 11:20:25','admin','Table:receipts | receiptid=1101140708000001','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 1047801.00|0.00|1047801.00|47801.00|1000000.00'),('2014-07-08 11:23:35','admin','Table:receipts | receiptid=1101140708000002','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 758002.00|0.00|758002.00|2.00|758000.00'),('2014-07-11 19:18:45','admin','Table:receipts | receiptid=1101140711000001','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 917100.00|0.00|917100.00|17100.00|900000.00'),('2014-07-14 11:07:03','admin','Table:receipts | receiptid=1101140714000001','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 126135.00|0.00|126135.00|0.00|126135.00'),('2014-07-14 16:24:12','admin','Table:members | memberid=0901000002','INSERT','MemberCode | ObjectId | NumberOfVissits| MemberType| CountryId | IsLock | LockDate | IsDelete | Description | Note | Status | MemberScore','MB001|0901000002|0|1|VN|0||0|||1|0'),('2014-07-14 16:26:10','admin','Table:members | memberid=0901000001','INSERT','MemberCode | ObjectId | NumberOfVissits| MemberType| CountryId | IsLock | LockDate | IsDelete | Description | Note | Status | MemberScore','MB002|0901000001|0|1|HK|0||0|||1|0'),('2014-07-14 16:26:32','admin','Table:members | memberid=0901000002','UPDATE','MemberCode | ObjectId | NumberOfVissits| MemberType| CountryId | IsLock | LockDate | IsDelete | Description | Note | Status | MemberScore','MB001|0901000002|0|1|VN|0||0|||1|0'),('2014-07-14 16:31:57','admin','Table:members | memberid=0901000002','UPDATE','MemberCode | ObjectId | NumberOfVissits| MemberType| CountryId | IsLock | LockDate | IsDelete | Description | Note | Status | MemberScore','MB001|0901000002|0|1|VN|0||0|||1|0'),('2014-07-14 17:06:19','admin','Table:receipts | receiptid=1101140714000002','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 1944850.00|0.00|1944850.00|850.00|1944000.00'),('2014-07-14 17:08:15','admin','Table:receipts | receiptid=1101140714000003','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 910556.00|0.00|910556.00|556.00|910000.00'),('2014-07-15 11:42:29','admin','Table:orders | orderid=102014071500001','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','31 |  | 0|0|0|0|0|549000'),('2014-07-15 11:58:40','admin','Table:receipts | receiptid=1101140715000001','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 27000.00|0.00|27000.00|7000.00|20000.00'),('2014-07-15 12:04:20','admin','Table:receipts | receiptid=1101140715000002','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 532000.00|0.00|532000.00|2000.00|530000.00'),('2014-07-15 12:07:35','admin','Table:receipts | receiptid=1101140715000003','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 11986.00|0.00|11986.00|986.00|11000.00'),('2014-07-15 12:10:20','admin','Table:receipts | receiptid=1101140715000004','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 56000.00|0.00|56000.00|6000.00|50000.00'),('2014-07-15 15:11:57','nhanvien','Table:promotions | promotionid=771407150001','UPDATE','PromotionName | BeginDateTime | EndDateTime ','Promotion 001 | 2014-07-13 15:13:58 | 2014-06-28 10:19:18'),('2014-07-15 15:12:06','hadmin','Table:promotions | promotionid=Promotion_L','UPDATE','PromotionName | BeginDateTime | EndDateTime ','Promtion_L | 2014-07-01 15:14:10 | 2014-07-14 15:14:14'),('2014-07-15 15:12:08','nhanvien','Table:promotions | promotionid=771407150001','UPDATE','PromotionName | BeginDateTime | EndDateTime ','Promotion 001 | 2014-07-13 15:13:58 | 2014-06-28 10:19:18'),('2014-07-15 15:12:12','hadmin','Table:promotions | promotionid=Promotion_L','UPDATE','PromotionName | BeginDateTime | EndDateTime ','Promtion_L | 2014-07-01 15:14:10 | 2014-07-14 15:14:14'),('2014-07-15 15:12:19','admin','Table:promotions | promotionid=771407150001','UPDATE','PromotionName | BeginDateTime | EndDateTime ','Promotion 001 | 2014-07-13 15:13:58 | 2014-06-28 10:19:18'),('2014-07-15 15:12:27','admin','Table:promotions | promotionid=Promotion_L','UPDATE','PromotionName | BeginDateTime | EndDateTime ','Promtion_L | 2014-07-01 15:14:10 | 2014-07-14 15:14:14'),('2014-07-15 15:12:48','admin','Table:promotions | promotionid=771407150002','UPDATE','PromotionName | BeginDateTime | EndDateTime ','Promotion 002 | 2014-07-01 15:14:10 | 2014-07-14 15:14:14'),('2014-07-15 15:12:57','admin','Table:promotions | promotionid=771407150003','INSERT','PromotionName | BeginDateTime | EndDateTime ','Promotion 002 | 2014-07-01 15:14:10 | 2014-07-14 15:14:14'),('2014-07-15 15:13:09','admin','Table:promotions | promotionid=771407150003','UPDATE','PromotionName | BeginDateTime | EndDateTime ','Promotion 003 | 2014-07-14 15:14:10 | 2014-07-18 15:14:14'),('2014-07-15 15:13:48','admin','Table:promotions | promotionid=771407150001','UPDATE','PromotionName | BeginDateTime | EndDateTime ','Promotion 001 | 2014-07-13 15:13:58 | 2014-06-28 10:19:18'),('2014-07-15 15:14:58','admin','Table:promotions | promotionid=771407150003','UPDATE','PromotionName | BeginDateTime | EndDateTime ','Promotion 003 | 2014-07-14 15:14:10 | 2014-07-18 15:14:14'),('2014-07-15 15:16:59','admin','Table:promotions | promotionid=771407150002','UPDATE','PromotionName | BeginDateTime | EndDateTime ','Promotion 002 | 2014-07-01 15:14:10 | 2014-07-14 15:14:14'),('2014-07-15 15:20:02','admin','Table:promotions | promotionid=771407150004','INSERT','PromotionName | BeginDateTime | EndDateTime ','Promotion 004 | 2014-07-14 15:14:10 | 2014-08-01 15:14:14'),('2014-07-15 15:21:11','admin','Table:promotions | promotionid=771407150001','UPDATE','PromotionName | BeginDateTime | EndDateTime ','Promotion 001 | 2014-07-13 15:13:58 | 2014-07-05 10:19:18'),('2014-07-15 15:21:33','admin','Table:promotions | promotionid=771407150001','UPDATE','PromotionName | BeginDateTime | EndDateTime ','Promotion 001 | 2014-07-13 15:13:58 | 2014-08-07 10:19:18'),('2014-07-15 15:22:29','admin','Table:promotions | promotionid=771407150001','UPDATE','PromotionName | BeginDateTime | EndDateTime ','Promotion 001 | 2014-07-13 15:13:58 | 2014-08-07 10:19:18'),('2014-07-15 15:22:31','admin','Table:promotions | promotionid=771407150002','UPDATE','PromotionName | BeginDateTime | EndDateTime ','Promotion 002 | 2014-07-01 15:14:10 | 2014-07-14 15:14:14'),('2014-07-15 15:22:33','admin','Table:promotions | promotionid=771407150003','UPDATE','PromotionName | BeginDateTime | EndDateTime ','Promotion 003 | 2014-07-14 15:14:10 | 2014-07-18 15:14:14'),('2014-07-15 15:22:37','admin','Table:promotions | promotionid=771407150004','UPDATE','PromotionName | BeginDateTime | EndDateTime ','Promotion 004 | 2014-07-14 15:14:10 | 2014-08-01 15:14:14'),('2014-07-15 15:32:21','admin','Table:receipts | receiptid=1101140715000005','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 60000.00|0.00|60000.00|1000.00|59000.00'),('2014-07-15 15:37:04','admin','Table:orders | orderid=102014071500002','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|952000|952000|2000|950000'),('2014-07-15 15:37:57','admin','Table:receipts | receiptid=1101140715000006','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 950000.00|0.00|950000.00|5000.00|945000.00'),('2014-07-15 18:05:45','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1111111 | admin | 1 | admin'),('2014-07-15 18:06:20','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-15 18:13:32','admin','Table:orders | orderid=102014071500003','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|140002|140002|0|140002'),('2014-07-15 18:25:03','admin','Table:orders | orderid=102014071500004','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','19 |  | 0|0|0|0|0|915000'),('2014-07-15 18:26:26','admin','Table:orders | orderid=102014071500005','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','27 |  | 0|0|0|0|0|120000'),('2014-07-15 18:26:44','admin','Table:orders | orderid=102014071500006','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','19 |  | 0|0|15000|15000|0|15000'),('2014-07-15 19:03:14','admin','Table:receipts | receiptid=1101140715000007','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 1025003.00|12.00|1025015.00|233.00|1024782.00'),('2014-07-16 09:10:12','admin','Table:orders | orderid=102014071600001','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','20 |  | 0|0|524000|524000|0|524000'),('2014-07-16 09:10:44','admin','Table:orders | orderid=102014071600002','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','31 |  | 0|0|970000|970000|10000|960000'),('2014-07-22 15:21:00','admin','Table:orders | orderid=102014072200001','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|1841000|1841000|1000|1840000'),('2014-07-22 15:21:28','admin','Table:receipts | receiptid=1101140722000001','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 1840000.00|0.00|1840000.00|40000.00|1800000.00'),('2014-07-22 17:11:28','admin','Table:users | userid=bvcbc','INSERT','pwd | ObjectId | Status | RoleId','cccxxc | cxbxc |  | '),('2014-07-22 17:11:51','admin','Table:users | userid=zxx','INSERT','pwd | ObjectId | Status | RoleId','xzxz |  |  | '),('2014-07-22 17:13:29','admin','Table:users | userid=hung','INSERT','pwd | ObjectId | Status | RoleId','hung | 01011407000006 | 1 | '),('2014-07-22 17:14:02','admin','Table:users | userid=hung','UPDATE','pwd | ObjectId | Status | RoleId','hung | 01011407000006 | 1 | quanly'),('2014-07-22 17:14:15','admin','Table:users | userid=hung','UPDATE','pwd | ObjectId | Status | RoleId','hung | 01011407000006 | 1 | quanly'),('2014-07-22 17:14:34','admin','Table:users | userid=hung','UPDATE','pwd | ObjectId | Status | RoleId','hung | 01011407000006 | 1 | admin'),('2014-07-22 17:14:37','admin','Table:users | userid=hung','UPDATE','pwd | ObjectId | Status | RoleId','hung | 01011407000006 | 1 | admin'),('2014-07-22 17:16:41','admin','Table:users | userid=hung','UPDATE','pwd | ObjectId | Status | RoleId','hung | 01011407000006 | 1 | admin'),('2014-07-22 17:23:21','admin','Table:users | userid=hung','UPDATE','pwd | ObjectId | Status | RoleId','hung | 01011407000006 | 1 | admin'),('2014-07-22 17:23:55','hung','Table:users | userid=hung','UPDATE','pwd | ObjectId | Status | RoleId','manhhung | 01011407000006 | 1 | admin'),('2014-07-22 17:29:28','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-22 17:30:45','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','12345678 | admin | 1 | admin'),('2014-07-22 17:34:09','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','12345678 | admin | 1 | admin'),('2014-07-22 17:38:36','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','12345678 | admin | 1 | admin'),('2014-07-22 17:38:48','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-22 17:44:10','hung','Table:users | userid=hung','UPDATE','pwd | ObjectId | Status | RoleId','manhhung | 01011407000006 | 1 | admin'),('2014-07-22 17:47:39','hung','Table:users | userid=hung','UPDATE','pwd | ObjectId | Status | RoleId','manhhung | 01011407000006 | 1 | admin'),('2014-07-22 17:49:37','hung','Table:users | userid=hung','UPDATE','pwd | ObjectId | Status | RoleId','manhhung | 01011407000006 | 1 | admin'),('2014-07-22 18:18:40','hung','Table:users | userid=hung','UPDATE','pwd | ObjectId | Status | RoleId','manhhung | 01011407000006 | 1 | admin'),('2014-07-22 18:21:13','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-22 18:22:32','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-22 19:20:12','hung','Table:users | userid=hung','UPDATE','pwd | ObjectId | Status | RoleId','manhhung | 01011407000006 | 1 | admin'),('2014-07-22 19:22:35','hung','Table:users | userid=hung','UPDATE','pwd | ObjectId | Status | RoleId','manhhung | 01011407000006 | 1 | admin'),('2014-07-23 09:14:18','hung','Table:users | userid=hung','UPDATE','pwd | ObjectId | Status | RoleId','manhhung | 01011407000006 | 1 | admin'),('2014-07-23 09:37:25','admin','Table:productprice | productprice=00000001|time=2014-07-23 11:06:29','INSERT','Price','20000.00'),('2014-07-23 09:37:45','admin','Table:productprice | productprice=00000001|time=2014-07-24 11:06:29','INSERT','Price','25000.00'),('2014-07-23 10:36:26','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-23 10:37:06','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-23 10:37:36','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-23 10:38:47','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-23 11:01:56','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-23 11:17:48','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-23 11:19:04','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-23 11:23:32','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-23 11:25:32','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-23 11:35:05','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-23 11:41:00','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-23 11:41:54','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-23 11:42:48','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-23 11:48:44','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-23 11:54:46','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-23 12:32:57','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-23 15:40:57','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-23 15:48:51','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-23 16:27:39','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-23 17:11:07','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-23 17:15:59','hung','Table:users | userid=hung','UPDATE','pwd | ObjectId | Status | RoleId','manhhung | 01011407000006 | 1 | admin'),('2014-07-23 17:18:28','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-23 17:24:45','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-23 17:30:59','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-23 18:22:30','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-23 18:31:22','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-23 18:32:19','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-23 18:54:31','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-23 19:09:56','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-23 19:13:33','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-23 19:15:24','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-23 19:19:11','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-23 19:21:19','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-23 19:23:31','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-23 19:26:11','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-23 19:32:23','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-23 19:39:46','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-23 19:40:17','admin','Table:products | productid=00000002','UPDATE','Name | Unit | Notes | ProductType','Canh chua | Bát tô | Cá |00'),('2014-07-23 19:40:49','admin','Table:products | productid=011407000004','INSERT','Name | Unit | Notes | ProductType','Bánh đa cua | Bát tô | Cá |00'),('2014-07-23 19:44:38','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-23 20:16:09','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-23 20:17:15','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-23 20:56:26','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-23 21:00:25','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-24 08:37:15','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-24 08:39:59','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-24 08:44:03','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-24 08:53:26','admin','Table:products | productid=011407000004','INSERT','Name | Unit | Notes | ProductType','Canh chua | Bát tô | Cá kho|00'),('2014-07-24 10:57:46','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-24 11:11:25','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-24 12:51:43','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-24 12:52:42','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-24 12:54:12','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-24 12:55:47','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-24 13:01:20','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-24 13:59:03','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-24 14:35:58','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-24 14:48:15','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-24 15:29:22','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-24 15:48:34','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-24 15:50:44','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-24 15:54:15','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-24 15:56:41','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-24 17:10:18','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-24 17:11:11','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-24 17:47:41','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-24 17:50:58','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-24 17:52:49','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-24 17:53:55','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-24 17:56:29','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-24 18:02:03','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-24 18:09:37','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-24 18:11:02','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-24 18:15:25','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-24 18:16:38','admin','Table:products | productid=00010002','UPDATE','Name | Unit | Notes | ProductType','Cơm gà ác | chén | có thêm khuyến mãi|02'),('2014-07-24 19:11:00','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-24 19:11:39','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-24 19:12:18','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-24 19:12:47','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-24 22:31:36','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-24 22:37:06','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 08:25:35','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 08:28:52','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 08:42:54','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 08:48:36','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 08:49:00','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 08:53:47','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 08:54:54','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 08:58:14','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 08:58:25','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 09:03:24','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 09:05:30','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 09:08:51','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 09:10:54','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 09:17:59','admin','Table:orders | orderid=102014072500001','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|1000000'),('2014-07-25 09:20:34','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 09:27:32','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 09:30:27','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 09:32:32','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 09:37:53','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 09:52:33','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 09:54:33','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 09:55:54','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 09:57:51','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 10:03:05','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 10:08:34','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 10:13:12','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 10:21:07','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 10:30:43','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 10:32:45','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 10:38:11','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 10:38:59','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 10:40:56','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 10:42:13','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 10:46:10','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 10:50:04','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 10:52:59','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 10:54:43','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 11:02:19','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 11:06:00','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 11:07:41','admin','Table:users | userid=hung','UPDATE','pwd | ObjectId | Status | RoleId','manhhung | 01011407000006 | 0 | tablet'),('2014-07-25 11:11:03','admin','Table:users | userid=kimthuan','UPDATE','pwd | ObjectId | Status | RoleId','kimthuan | nhanvien | 0 | nhanvien'),('2014-07-25 11:11:06','admin','Table:users | userid=kimthuan','UPDATE','pwd | ObjectId | Status | RoleId','kimthuan | nhanvien | 0 | nhanvien'),('2014-07-25 11:25:47','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 11:30:45','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 11:45:43','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 11:56:22','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 12:00:00','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 12:03:36','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 12:50:30','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 13:00:25','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 13:03:42','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 13:08:25','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 13:19:00','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 13:29:46','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 13:31:56','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 13:40:32','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 13:44:53','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 13:49:47','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 13:51:25','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 13:52:20','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 14:03:00','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 14:08:11','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 14:16:31','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 14:41:24','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 14:49:10','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 14:50:37','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 14:54:05','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 15:08:21','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 15:11:12','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 15:14:19','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 15:27:05','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 15:35:55','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 15:37:41','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 15:39:53','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 15:45:41','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 16:11:50','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 16:33:24','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 16:37:45','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 16:41:59','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 16:47:23','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 16:49:04','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 16:55:56','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 16:57:28','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 17:20:36','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 17:21:38','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 17:31:35','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 17:33:22','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 17:39:47','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 17:41:48','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 17:47:21','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 17:50:25','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 17:54:25','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 18:02:47','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 18:07:50','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 18:09:44','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','123456789 | admin | 1 | admin'),('2014-07-25 18:10:09','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 18:13:32','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 18:18:46','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 18:28:00','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 18:35:41','admin','Table:orders | orderid=102014072500002','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','20 |  | 0|0|108000|108000|700|107300'),('2014-07-25 18:44:32','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-25 18:45:04','admin','Table:orders | orderid=102014072500003','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','29 |  | 0|0|0|0|0|180000'),('2014-07-25 18:47:41','admin','Table:orders | orderid=102014072500004','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','29 |  | 0|0|0|0|0|0'),('2014-07-25 19:17:10','admin','Table:receipts | receiptid=1101140725000001','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 0.00|0.00|0.00|0.00|0.00'),('2014-07-25 19:31:31','admin','Table:receipts | receiptid=1101140725000002','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 20000.00|0.00|20000.00|200.00|19800.00'),('2014-07-25 19:35:02','admin','Table:receipts | receiptid=1101140725000003','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 1925000.00|0.00|1925000.00|12220.00|1912780.00'),('2014-07-26 17:04:46','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 17:09:25','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 17:20:55','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 17:22:26','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 17:24:24','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 17:31:00','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 17:31:07','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 17:33:16','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 17:45:17','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 17:48:56','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 17:49:33','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 17:50:09','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 17:54:31','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 18:01:08','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 18:01:47','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 18:06:40','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 18:08:50','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 18:09:33','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 18:10:21','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 18:15:22','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 18:26:41','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 18:33:56','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 18:39:08','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 18:40:51','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 18:41:32','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 18:42:53','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 18:43:23','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 18:44:31','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 18:45:10','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 18:45:26','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 18:47:08','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 18:49:16','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 18:51:08','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 18:53:01','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 18:55:43','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 18:58:34','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 18:59:38','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 19:00:42','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 19:01:10','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 19:02:12','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 19:03:44','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 19:04:14','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 19:05:22','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 19:06:02','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 19:08:24','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 19:09:45','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 19:18:43','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 19:20:29','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 19:21:20','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 19:26:30','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 19:27:37','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 19:38:32','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 19:40:08','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 19:40:30','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 19:41:49','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 19:43:07','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 19:43:29','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 19:48:33','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 19:50:12','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 19:51:40','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 19:53:34','admin','Table:orders | orderid=102014072600001','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|15000'),('2014-07-26 20:01:37','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 20:02:23','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 20:07:10','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 20:09:55','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 20:11:04','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 20:14:19','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 20:17:21','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 20:21:42','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 20:23:37','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 20:24:06','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-26 20:31:39','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 08:27:42','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 08:30:53','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 08:34:20','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 08:39:14','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 08:42:19','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 08:46:44','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 08:47:47','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 08:50:08','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 08:52:58','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 08:55:39','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 08:56:50','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 08:57:42','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 08:58:33','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 09:12:30','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 09:14:37','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 09:17:15','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 09:21:35','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 09:24:09','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 09:25:19','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 09:27:41','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 09:28:44','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 09:41:08','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 09:42:09','admin','Table:users | userid=quanly','UPDATE','pwd | ObjectId | Status | RoleId','2345656 | quanly | 1 | quanly'),('2014-07-28 09:45:51','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 09:48:17','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 09:49:07','admin','Table:users | userid=nhanvien','UPDATE','pwd | ObjectId | Status | RoleId','08158291 | nhanvien | 1 | letan'),('2014-07-28 09:49:48','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 09:50:45','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 09:53:11','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 09:56:28','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 10:56:08','admin','Table:products | productid=011407000001','UPDATE','Name | Unit | Notes | ProductType','Cá kho tộ | tô | Cá kho ngon|00'),('2014-07-28 10:56:30','admin','Table:products | productid=011407000002','UPDATE','Name | Unit | Notes | ProductType','Canh chua | Bát tô | Cá |00'),('2014-07-28 10:56:36','admin','Table:products | productid=011407000003','UPDATE','Name | Unit | Notes | ProductType','Cơm gà ác | chén | có thêm khuyến mãi|02'),('2014-07-28 11:02:26','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 12:55:40','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 13:01:44','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 13:57:38','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 14:00:43','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 14:03:56','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 14:04:58','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 14:09:12','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 14:14:03','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 14:16:33','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 14:29:11','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 14:33:35','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 14:39:47','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 14:42:16','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 14:44:15','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 14:45:14','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 14:51:49','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 14:57:00','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 14:59:06','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 15:03:58','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 15:06:49','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 15:08:39','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 15:11:29','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 15:15:46','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 15:17:18','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 15:23:03','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 15:27:45','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 15:30:22','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 15:30:55','admin','Table:productprice | productprice=00030009|time=2014-07-28 15:30:55','INSERT','Price','26000.00'),('2014-07-28 15:46:33','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 15:47:45','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 15:49:58','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 15:54:51','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 16:30:57','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 16:43:01','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 16:48:55','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 16:52:15','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 16:54:02','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 16:55:35','admin','Table:productprice | productprice=00030009|time=2014-07-28 16:55:35','INSERT','Price','18000.00'),('2014-07-28 17:01:01','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 17:01:32','admin','Table:productprice | productprice=00030009|time=2014-07-28 17:01:32','INSERT','Price','15400.00'),('2014-07-28 17:04:06','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 17:10:47','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 17:11:26','admin','Table:productprice | productprice=00030009|time=2014-07-28 17:11:26','INSERT','Price','17000.00'),('2014-07-28 17:11:32','admin','Table:productprice | productprice=00030009|time=2014-07-28 17:11:32','INSERT','Price','17500.00'),('2014-07-28 17:11:39','admin','Table:productprice | productprice=00030009|time=2014-07-28 17:11:39','INSERT','Price','17505.00'),('2014-07-28 17:11:58','admin','Table:productprice | productprice=00030009|time=2014-07-28 17:11:58','INSERT','Price','17400.00'),('2014-07-28 17:12:03','admin','Table:productprice | productprice=00030009|time=2014-07-28 17:12:03','INSERT','Price','17440.00'),('2014-07-28 17:12:07','admin','Table:productprice | productprice=00030009|time=2014-07-28 17:12:07','INSERT','Price','17490.00'),('2014-07-28 17:14:01','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 17:51:51','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-28 18:32:51','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-29 09:19:40','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-29 10:12:07','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-29 12:36:11','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-29 12:38:22','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-29 12:39:14','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-29 12:40:15','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-29 13:06:53','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-29 13:09:35','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-29 13:47:38','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-29 13:50:29','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-29 13:51:58','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-29 13:56:33','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-29 13:57:47','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-29 14:02:34','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-29 14:04:24','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-29 14:05:24','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-29 14:06:57','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-29 14:11:00','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-29 14:13:29','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-29 14:18:24','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-29 14:21:13','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-29 14:25:21','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-29 14:29:10','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-29 15:51:51','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-29 16:11:22','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-29 16:26:49','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-29 16:33:59','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-29 16:54:14','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-30 08:39:47','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-30 09:30:32','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-30 11:36:50','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-30 11:39:33','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-30 11:45:15','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-30 11:48:22','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-30 11:53:05','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-30 11:54:58','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-30 12:02:08','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-30 12:13:33','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-30 12:42:23','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-30 12:58:05','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-30 12:58:52','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-30 13:02:59','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-30 13:06:43','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-30 13:09:25','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-30 13:13:58','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-30 13:15:08','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-30 13:19:13','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-30 13:21:31','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-30 13:24:33','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-30 13:27:21','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-30 13:32:45','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-30 13:38:55','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-30 13:47:13','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-30 13:52:01','hung','Table:receipts | receiptid=','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 1 |  | ||||'),('2014-07-30 13:57:23','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-30 14:02:08','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-30 14:04:52','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-30 14:15:08','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-30 14:29:58','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-30 14:35:43','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-30 14:36:47','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-30 14:40:03','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-30 14:45:52','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-30 15:00:45','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-30 15:03:20','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-30 15:06:43','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-30 15:21:28','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-30 16:42:55','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-30 16:45:18','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-30 17:18:58','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-30 17:20:03','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-30 17:21:22','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-30 17:25:34','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-30 17:38:58','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-30 17:51:42','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-30 17:53:45','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-30 17:55:07','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 10:18:42','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 10:33:19','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 10:35:05','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 10:35:55','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 10:36:24','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 10:37:08','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 10:37:28','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 10:38:22','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 10:38:32','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 10:40:17','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 10:42:31','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 10:43:10','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 10:43:57','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 10:49:08','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 10:51:48','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 11:10:57','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 11:16:32','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 11:25:48','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 11:30:44','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 11:31:49','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 11:36:02','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 11:38:43','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 11:43:51','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 11:50:52','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 11:55:24','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 12:00:21','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 12:03:22','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 12:34:54','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 12:38:11','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 12:39:59','admin','Table:users | userid=hung','UPDATE','pwd | ObjectId | Status | RoleId','123 | 01011407000006 | 1 | admin'),('2014-07-31 12:56:15','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 13:05:17','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 13:27:30','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 13:31:23','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 13:34:10','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 13:35:34','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 13:36:31','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 15:16:54','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 15:17:19','admin','Table:users | userid=hung','UPDATE','pwd | ObjectId | Status | RoleId','123 | 01011407000006 | 1 | admin'),('2014-07-31 15:19:51','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 15:22:12','admin','Table:users | userid=hung','UPDATE','pwd | ObjectId | Status | RoleId','123 | 01011407000006 | 1 | admin'),('2014-07-31 15:25:29','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 15:27:19','admin','Table:users | userid=hung','UPDATE','pwd | ObjectId | Status | RoleId','1234 | 01011407000006 | 1 | admin'),('2014-07-31 15:30:09','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 15:34:53','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 15:36:16','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','12345678 | admin | 1 | admin'),('2014-07-31 15:38:34','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','12345678 | admin | 1 | admin'),('2014-07-31 15:40:19','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 15:42:03','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 15:44:26','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 15:47:10','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 15:47:54','admin','Table:users | userid=hung2','INSERT','pwd | ObjectId | Status | RoleId','1234567 |  | 1 | letan'),('2014-07-31 15:48:26','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 15:50:46','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 15:51:37','admin','Table:users | userid=hung','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | 01011407000006 | 1 | letan'),('2014-07-31 15:52:41','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 15:55:00','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 15:57:40','admin','Table:users | userid=anh','INSERT','pwd | ObjectId | Status | RoleId','anh | admin | 1 | admin'),('2014-07-31 15:58:40','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 16:02:08','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 16:02:47','admin','Table:users | userid=hung3','INSERT','pwd | ObjectId | Status | RoleId','12345 |  | 1 | admin'),('2014-07-31 16:35:37','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 16:36:22','admin','Table:users | userid=011407000012','INSERT','pwd | ObjectId | Status | RoleId','anh | admin | 1 | admin'),('2014-07-31 16:39:44','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 16:40:13','admin','Table:users | userid=hung4','INSERT','pwd | ObjectId | Status | RoleId','12345 |  | 1 | admin'),('2014-07-31 16:40:24','admin','Table:users | userid=hung','UPDATE','pwd | ObjectId | Status | RoleId','12345 | 01011407000006 | 1 | admin'),('2014-07-31 16:45:35','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 16:46:22','admin','Table:users | userid=ManhHung','INSERT','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 16:49:00','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 16:55:28','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 17:01:34','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 17:08:46','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 17:11:24','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 17:18:12','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 17:26:11','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 17:31:53','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 17:35:32','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 17:40:20','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 17:41:55','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 17:52:58','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 18:03:14','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-07-31 18:03:39','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-01 08:29:40','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-01 12:59:22','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-01 13:51:57','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-01 14:30:34','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-01 14:52:08','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-01 14:54:05','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-01 15:31:37','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-01 15:36:33','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-01 15:42:57','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-01 15:43:28','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-01 15:48:38','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-01 15:49:44','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-01 16:30:54','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-04 15:07:13','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-04 15:39:29','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-04 15:42:27','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-04 15:57:13','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-04 19:18:30','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-04 19:25:20','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 08:29:03','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 08:33:02','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 08:39:51','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 08:42:46','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 09:05:51','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 09:07:09','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 09:20:23','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 09:23:52','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 09:43:35','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 09:50:53','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 09:50:59','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 09:52:47','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 09:56:36','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 10:00:53','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 10:11:11','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 10:11:37','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 10:14:55','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 10:22:13','admin','Table:users | userid=','INSERT','pwd | ObjectId | Status | RoleId',' |  |  | '),('2014-08-05 10:22:34','admin','Table:users | userid=','UPDATE','pwd | ObjectId | Status | RoleId',' |  |  | '),('2014-08-05 10:22:36','admin','Table:users | userid=','UPDATE','pwd | ObjectId | Status | RoleId',' |  |  | '),('2014-08-05 10:22:40','admin','Table:users | userid=ggggggggggg','INSERT','pwd | ObjectId | Status | RoleId',' |  |  | '),('2014-08-05 10:22:42','admin','Table:users | userid=ggggggggggg','UPDATE','pwd | ObjectId | Status | RoleId',' |  |  | '),('2014-08-05 10:22:43','admin','Table:users | userid=ggggggggggg','UPDATE','pwd | ObjectId | Status | RoleId',' |  |  | '),('2014-08-05 10:22:44','admin','Table:users | userid=ggggggggggg','UPDATE','pwd | ObjectId | Status | RoleId',' |  |  | '),('2014-08-05 10:22:45','admin','Table:users | userid=ggggggggggg','UPDATE','pwd | ObjectId | Status | RoleId',' |  |  | '),('2014-08-05 10:22:46','admin','Table:users | userid=ggggggggggg','UPDATE','pwd | ObjectId | Status | RoleId',' |  |  | '),('2014-08-05 10:22:51','admin','Table:users | userid=ggggggggggg','UPDATE','pwd | ObjectId | Status | RoleId','ffffffffff |  |  | '),('2014-08-05 10:22:52','admin','Table:users | userid=ggggggggggg','UPDATE','pwd | ObjectId | Status | RoleId','ffffffffff |  |  | '),('2014-08-05 10:22:53','admin','Table:users | userid=ggggggggggg','UPDATE','pwd | ObjectId | Status | RoleId','ffffffffff |  |  | '),('2014-08-05 10:22:59','admin','Table:users | userid=ggggggggggg','UPDATE','pwd | ObjectId | Status | RoleId','ffffffffff |  | 1 | '),('2014-08-05 10:23:00','admin','Table:users | userid=ggggggggggg','UPDATE','pwd | ObjectId | Status | RoleId','ffffffffff |  | 1 | '),('2014-08-05 10:23:04','admin','Table:users | userid=ggggggggggg','UPDATE','pwd | ObjectId | Status | RoleId','ffffffffff |  | 0 | '),('2014-08-05 10:23:13','admin','Table:users | userid=fffffffffffffffffffff','INSERT','pwd | ObjectId | Status | RoleId','fffffffffffffff |  |  | '),('2014-08-05 10:24:02','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 10:32:44','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 10:41:10','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 10:44:11','admin','Table:products | productid=011408000001','INSERT','Name | Unit | Notes | ProductType','Cá kho tộ | tô | Cá kho ngon|00'),('2014-08-05 10:49:15','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 10:54:46','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 11:00:02','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 11:04:52','admin','Table:products | productid=011407000003','UPDATE','Name | Unit | Notes | ProductType','Cơm gà ác | chén | có thêm khuyến mãi|02'),('2014-08-05 11:04:53','admin','Table:products | productid=011407000003','UPDATE','Name | Unit | Notes | ProductType','Cơm gà ác | chén | có thêm khuyến mãi|02'),('2014-08-05 11:04:54','admin','Table:products | productid=011407000003','UPDATE','Name | Unit | Notes | ProductType','Cơm gà ác | chén | có thêm khuyến mãi|02'),('2014-08-05 11:04:55','admin','Table:products | productid=011407000003','UPDATE','Name | Unit | Notes | ProductType','Cơm gà ác | chén | có thêm khuyến mãi|02'),('2014-08-05 11:04:56','admin','Table:products | productid=011407000003','UPDATE','Name | Unit | Notes | ProductType','Cơm gà ác | chén | có thêm khuyến mãi|02'),('2014-08-05 11:04:57','admin','Table:products | productid=011407000003','UPDATE','Name | Unit | Notes | ProductType','Cơm gà ác | chén | có thêm khuyến mãi|02'),('2014-08-05 11:04:58','admin','Table:products | productid=011407000003','UPDATE','Name | Unit | Notes | ProductType','Cơm gà ác | chén | có thêm khuyến mãi|02'),('2014-08-05 11:04:59','admin','Table:products | productid=011407000003','UPDATE','Name | Unit | Notes | ProductType','Cơm gà ác | chén | có thêm khuyến mãi|02'),('2014-08-05 11:05:00','admin','Table:products | productid=011407000003','UPDATE','Name | Unit | Notes | ProductType','Cơm gà ác | chén | có thêm khuyến mãi|02'),('2014-08-05 11:05:01','admin','Table:products | productid=011407000003','UPDATE','Name | Unit | Notes | ProductType','Cơm gà ác | chén | có thêm khuyến mãi|02'),('2014-08-05 11:05:02','admin','Table:products | productid=011407000003','UPDATE','Name | Unit | Notes | ProductType','Cơm gà ác | chén | có thêm khuyến mãi|02'),('2014-08-05 11:05:03','admin','Table:products | productid=011407000003','UPDATE','Name | Unit | Notes | ProductType','Cơm gà ác | chén | có thêm khuyến mãi|02'),('2014-08-05 11:05:09','admin','Table:products | productid=011407000003','UPDATE','Name | Unit | Notes | ProductType','Cơm gà ác | chén | có thêm khuyến mãikkkkkk|02'),('2014-08-05 11:05:14','admin','Table:products | productid=011407000003','UPDATE','Name | Unit | Notes | ProductType','Cơm gà ác | chén | có thêm khuyến mãikkkkkk|02'),('2014-08-05 11:11:02','admin','Table:products | productid=011407000004','UPDATE','Name | Unit | Notes | ProductType','Canh chua 2 | Bát tô | Cá kho|00'),('2014-08-05 11:11:20','admin','Table:products | productid=011407000004','UPDATE','Name | Unit | Notes | ProductType','Canh chua 2 | Bát tô2 | Cá kho|00'),('2014-08-05 11:17:20','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 11:24:39','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 11:27:16','admin','Table:productprice | productprice=|time=2014-08-05 11:27:16','INSERT','Price',''),('2014-08-05 11:31:55','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 11:33:18','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 11:36:46','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 11:43:01','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 11:46:41','admin','Table:productprice | productprice=|time=2014-08-05 11:46:41','INSERT','Price',''),('2014-08-05 11:48:08','admin','Table:productprice | productprice=00000002|time=2014-08-05 11:48:08','INSERT','Price','800000.00'),('2014-08-05 11:48:31','admin','Table:productprice | productprice=00000002|time=2014-08-05 11:48:31','INSERT','Price','800000.00'),('2014-08-05 11:49:15','admin','Table:productprice | productprice=00000002|time=2014-08-05 11:49:15','INSERT','Price','12300000.00'),('2014-08-05 11:54:16','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 11:54:50','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 11:55:13','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 11:55:43','admin','Table:productprice | productprice=|time=2014-08-05 11:55:43','INSERT','Price',''),('2014-08-05 11:56:09','admin','Table:productprice | productprice=|time=2014-08-05 11:56:09','INSERT','Price',''),('2014-08-05 12:47:44','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 12:52:26','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 12:53:36','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 13:09:42','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 13:28:42','admin','Table:orders | orderid=102014080500001','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|24000|24000|0|24000'),('2014-08-05 13:29:24','admin','Table:receipts | receiptid=1101140805000001','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 24000.00|0.00|24000.00|0.00|24000.00'),('2014-08-05 13:29:50','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 13:32:39','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 13:38:17','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 13:51:54','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 13:57:57','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 13:59:20','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 14:00:17','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 14:01:28','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 14:02:28','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 14:05:17','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 14:08:26','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 14:09:47','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 14:14:36','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 14:27:39','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 14:46:33','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 14:48:18','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 14:49:07','admin','Table:orders | orderid=102014080500002','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|12001|12001|100|11901'),('2014-08-05 14:50:22','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 14:52:02','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 14:53:53','admin','Table:orders | orderid=102014080500003','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|220000|220000|0|220000'),('2014-08-05 14:57:04','admin','Table:receipts | receiptid=1101140805000002','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 185000.00|0.00|185000.00|1693.00|183307.00'),('2014-08-05 15:06:47','admin','Table:receipts | receiptid=1101140805000003','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 15000.00|0.00|15000.00|0.00|15000.00'),('2014-08-05 15:18:37','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 15:23:36','admin','Table:receipts | receiptid=1101140805000004','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 1374000.00|55.00|1374055.00|0.00|1374055.00'),('2014-08-05 15:51:41','admin','Table:receipts | receiptid=1101140805000005','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 122300.00|0.00|122300.00|0.00|122300.00'),('2014-08-05 15:52:41','admin','Table:receipts | receiptid=1101140805000006','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 46901.00|0.00|46901.00|0.00|46901.00'),('2014-08-05 16:37:32','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 16:45:41','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 16:52:43','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 16:57:09','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 17:01:13','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 17:03:21','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 17:08:12','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 17:11:37','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 17:33:36','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 17:42:00','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 17:51:19','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 17:52:39','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 17:55:18','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 17:57:06','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 18:02:12','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 18:04:34','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 18:10:08','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 18:13:08','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 18:17:00','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 18:21:58','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 18:27:55','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 18:33:47','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 18:37:32','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-05 18:42:32','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 08:23:19','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 08:37:55','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 08:39:19','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 08:45:55','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 08:47:25','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 08:49:17','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 08:51:10','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 08:52:46','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 08:54:18','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 09:02:16','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 09:05:54','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 09:15:14','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 09:18:35','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 09:19:53','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 09:21:24','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 09:22:44','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 09:24:23','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 09:26:15','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 09:27:30','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 09:29:24','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 09:32:58','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 09:36:21','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 09:40:07','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 09:40:35','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 09:43:42','admin','Table:orders | orderid=102014080600001','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|323001|323001|1|323000'),('2014-08-06 09:44:16','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 09:46:14','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 09:46:54','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 09:49:12','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 09:51:14','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 09:52:41','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 10:01:43','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 10:06:15','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 10:11:38','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 10:14:01','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 10:19:04','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 10:34:09','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 10:48:34','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 11:06:01','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 11:07:22','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 11:08:37','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 11:23:09','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 11:27:03','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 11:32:09','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 11:34:40','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 11:37:12','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 11:39:36','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 11:42:35','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 11:45:00','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 12:05:38','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 13:06:28','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 13:11:08','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 13:19:17','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 13:28:20','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 13:38:01','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 13:59:44','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 14:02:00','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 14:03:48','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 14:12:49','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 14:22:31','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 14:24:12','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 14:26:57','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 14:33:17','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 14:53:35','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 14:56:13','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 15:01:47','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 15:03:27','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 15:05:48','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 15:17:55','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 15:22:04','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 15:24:53','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 15:26:33','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 15:29:09','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 15:30:12','admin','Table:receipts | receiptid=1101140806000001','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 323000.00|0.00|323000.00|0.00|323000.00'),('2014-08-06 15:31:18','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 15:49:03','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 15:53:14','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 15:55:03','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 15:56:57','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 15:58:41','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 16:00:15','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 16:06:48','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 16:08:25','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 16:13:09','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 16:16:50','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 16:17:49','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 16:36:51','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 16:46:31','admin','Table:orders | orderid=102014080600002','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|240004|240004|8999|231005'),('2014-08-06 16:50:04','admin','Table:orders | orderid=102014080600003','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|120000|120000|0|119999'),('2014-08-06 16:55:34','admin','Table:orders | orderid=102014080600004','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','33 |  | 0|0|12001|12001|0|12001'),('2014-08-06 16:56:03','admin','Table:orders | orderid=102014080600005','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','33 |  | 0|0|5000|5000|89|4911'),('2014-08-06 17:05:18','admin','Table:receipts | receiptid=1101140806000002','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 37001.00|44.00|37045.00|988.00|36057.00'),('2014-08-06 17:05:19','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 17:12:45','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 17:15:12','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 17:15:23','admin','Table:receipts | receiptid=1101140806000003','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 351005.00|0.00|351005.00|0.00|351005.00'),('2014-08-06 17:16:27','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 17:34:32','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 17:36:36','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 17:43:57','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 17:51:27','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 17:55:34','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 18:02:12','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 18:04:49','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 18:08:46','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 18:10:48','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 18:13:10','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 18:15:12','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 18:27:00','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 18:29:31','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 18:31:48','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 18:33:28','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 18:49:50','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 18:56:53','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 19:07:22','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 19:14:47','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 19:19:24','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 19:25:09','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 19:27:29','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 19:28:21','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 19:34:01','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 19:37:11','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 19:43:37','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 20:21:37','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-06 20:43:05','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 08:40:52','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 08:43:43','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 08:50:00','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 08:53:29','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 09:07:27','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 09:09:02','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 09:09:41','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 09:10:33','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 09:19:27','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 09:22:42','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 09:26:54','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 09:28:15','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 09:34:54','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 09:38:47','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 09:39:40','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 09:41:13','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 09:47:27','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 09:49:12','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 09:51:01','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 10:13:28','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 10:25:05','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 10:30:11','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 10:32:18','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 10:35:38','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 10:58:23','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 11:00:45','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 11:03:21','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 11:04:26','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 11:11:35','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 11:15:22','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 11:37:06','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 11:41:59','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 11:54:15','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 11:58:42','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 13:19:41','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 13:25:30','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 13:37:46','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 13:43:04','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 13:46:56','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 13:49:40','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 13:57:41','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 14:29:43','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 14:40:35','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 15:01:22','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 15:03:34','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 15:06:19','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 15:47:58','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 16:02:41','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 16:08:02','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 16:25:59','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 17:03:47','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 17:09:43','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 17:11:11','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 17:15:05','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 17:17:53','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 17:24:30','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 17:30:08','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 17:32:52','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 17:35:04','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 17:41:03','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 17:48:05','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 17:50:14','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 17:54:12','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 18:01:06','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 18:04:05','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 18:11:07','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 18:16:46','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 18:37:05','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 18:44:00','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 18:46:34','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 18:52:29','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 19:01:28','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 19:08:21','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 19:13:52','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-07 19:19:24','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 08:25:28','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 08:29:23','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 08:50:42','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 08:52:30','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 08:55:13','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 08:57:26','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 09:00:23','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 09:06:40','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 09:21:39','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 09:32:22','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 09:41:05','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 09:48:52','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 10:00:07','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 10:08:37','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 10:13:02','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 10:15:18','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 10:20:29','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 10:22:04','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 10:24:44','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 10:28:05','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 10:29:57','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 10:36:26','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 10:38:05','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 10:41:23','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 10:42:04','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 10:42:47','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 11:55:51','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 12:47:18','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 13:18:10','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 13:19:40','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 13:24:46','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 13:28:35','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 13:30:43','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 13:32:57','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 13:44:02','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 13:50:50','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 14:01:25','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 14:26:16','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 14:49:38','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 14:53:28','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 15:00:14','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 15:04:41','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 15:06:44','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 15:07:27','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 15:09:16','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 15:13:20','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 15:16:06','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 15:16:53','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 15:18:15','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 15:19:58','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 15:21:45','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 15:24:42','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 15:28:00','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 15:30:19','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 15:30:50','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 15:31:56','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 15:32:39','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 15:33:33','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 15:35:02','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 15:36:23','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 15:36:51','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 15:58:56','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 16:25:42','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 16:26:37','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 16:28:01','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 16:29:33','admin','Table:users | userid=','UPDATE','pwd | ObjectId | Status | RoleId',' |  | 1 | admin'),('2014-08-08 16:29:44','admin','Table:users | userid=','UPDATE','pwd | ObjectId | Status | RoleId',' |  | 1 | admin'),('2014-08-08 16:31:18','admin','Table:users | userid=01140700001uuu','INSERT','pwd | ObjectId | Status | RoleId','anh | admin | 1 | admin'),('2014-08-08 16:36:31','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 16:37:43','admin','Table:users | userid=ggggggggggg','UPDATE','pwd | ObjectId | Status | RoleId','ffffffffff |  | 0 | '),('2014-08-08 16:38:07','admin','Table:users | userid=ggggggggggg','UPDATE','pwd | ObjectId | Status | RoleId','ffffffffff |  | 0 | '),('2014-08-08 16:40:38','admin','Table:products | productid=011408000001','INSERT','Name | Unit | Notes | ProductType','Cá kho tộ | tô | Cá kho ngon|00'),('2014-08-08 16:41:10','admin','Table:products | productid=011408000001','INSERT','Name | Unit | Notes | ProductType','Cá kho tộ | tô | Cá kho ngon|01'),('2014-08-08 16:41:13','admin','Table:products | productid=011408000001','UPDATE','Name | Unit | Notes | ProductType','Cá kho tộ | tô | Cá kho ngon|01'),('2014-08-08 16:41:15','admin','Table:products | productid=011408000001','UPDATE','Name | Unit | Notes | ProductType','Cá kho tộ | tô | Cá kho ngon|01'),('2014-08-08 16:41:27','admin','Table:products | productid=011408000001','UPDATE','Name | Unit | Notes | ProductType','Cá kho tộggggg | tô | Cá kho ngon|01'),('2014-08-08 16:41:29','admin','Table:products | productid=011408000001','UPDATE','Name | Unit | Notes | ProductType','Cá kho tộggggg | tô | Cá kho ngon|01'),('2014-08-08 17:15:25','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 17:25:13','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 17:33:06','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 18:17:01','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 18:25:30','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 18:32:20','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 18:33:13','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 18:38:22','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 18:45:59','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 18:57:39','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-08 19:10:12','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 09:10:53','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 09:20:58','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 09:31:01','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 09:32:21','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 09:40:38','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 09:43:38','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 09:53:46','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 09:58:57','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 10:00:00','admin','Table:users | userid=011407000012','UPDATE','pwd | ObjectId | Status | RoleId','anh | admin | 1 | admin'),('2014-08-11 10:05:36','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 10:05:43','admin','Table:products | productid=02000003','UPDATE','Name | Unit | Notes | ProductType','MassageBody | suất | có thêm khuyến mãi|02'),('2014-08-11 10:09:15','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 10:09:29','admin','Table:products | productid=02000003','UPDATE','Name | Unit | Notes | ProductType','MassageBody | suất | có thêm khuyến mãi|02'),('2014-08-11 10:09:50','admin','Table:products | productid=011408000001','UPDATE','Name | Unit | Notes | ProductType','Cá kho tộggggg | tô | Cá kho ngon|01'),('2014-08-11 10:10:31','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 10:10:41','admin','Table:products | productid=02000003','UPDATE','Name | Unit | Notes | ProductType','MassageBody | suất | có thêm khuyến mãi|02'),('2014-08-11 10:32:37','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 10:34:14','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 10:35:18','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 10:59:34','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 11:02:28','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 11:03:58','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 11:05:40','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 11:06:31','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 11:18:12','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 11:19:55','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 11:31:47','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 11:34:56','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 11:38:39','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 11:46:45','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 11:58:08','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 12:01:07','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 12:03:51','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 12:53:52','admin','Table:products | productid=02000003','UPDATE','Name | Unit | Notes | ProductType','MassageBody | suất | có thêm khuyến mãi|02'),('2014-08-11 12:54:25','admin','Table:products | productid=011408000001','UPDATE','Name | Unit | Notes | ProductType','Cá kho tộggggg | tô | Cá kho ngon|01'),('2014-08-11 12:55:09','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 12:55:22','admin','Table:products | productid=011408000001','UPDATE','Name | Unit | Notes | ProductType','Cá kho tộggggg | tô | Cá kho ngon|01'),('2014-08-11 12:57:14','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 13:07:00','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 13:07:47','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 13:10:08','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 13:11:00','admin','Table:products | productid=011408000001','UPDATE','Name | Unit | Notes | ProductType','Cá kho tộggggg | tô | Cá kho ngon|01'),('2014-08-11 13:11:03','admin','Table:products | productid=011408000001','UPDATE','Name | Unit | Notes | ProductType','Cá kho tộggggg | tô | Cá kho ngon|01'),('2014-08-11 13:11:45','admin','Table:products | productid=011408000001','UPDATE','Name | Unit | Notes | ProductType','Cá kho tộggggg | tô | Cá kho ngon|01'),('2014-08-11 13:15:59','admin','Table:products | productid=011408000001','UPDATE','Name | Unit | Notes | ProductType','Cá kho tộg1 | tô | Cá kho ngon|01'),('2014-08-11 13:24:33','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 13:43:36','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 13:46:19','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 13:48:04','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 13:56:21','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 14:17:53','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 14:20:38','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 14:32:01','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 14:33:02','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 14:34:14','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 14:38:55','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 14:42:20','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 14:53:43','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 15:14:12','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 15:16:55','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 15:24:35','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 15:48:55','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 16:30:55','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 16:35:32','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 16:36:48','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 16:49:42','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 16:58:35','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 16:59:35','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 17:01:30','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 17:10:22','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 17:20:44','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 17:46:49','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 17:50:29','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 17:55:14','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 17:57:56','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 18:05:06','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 18:11:40','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 18:14:29','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 18:18:59','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 18:19:32','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 18:22:50','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 18:26:21','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 18:26:55','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 18:29:42','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 18:38:57','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 18:47:05','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 18:50:26','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 19:10:27','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 19:12:26','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 19:14:40','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 19:17:38','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 19:18:56','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 19:19:59','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 19:22:22','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 19:25:09','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 19:26:28','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 19:27:45','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 19:35:50','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 19:40:23','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 19:42:12','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 19:45:34','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 19:46:53','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 19:47:33','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 19:48:49','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 19:49:59','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 19:50:43','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-11 19:51:36','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 08:24:50','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 08:26:53','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 08:30:49','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 08:32:44','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 08:34:15','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 08:37:14','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 08:38:10','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 08:46:09','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 08:53:42','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 08:55:15','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 08:56:52','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 08:57:54','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 08:59:13','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 09:00:59','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 09:02:10','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 09:05:10','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 09:06:17','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 09:06:59','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 09:09:37','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 09:13:33','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 09:23:18','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 09:24:32','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 09:26:23','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 09:33:47','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 09:40:25','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 09:42:03','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 09:44:16','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 09:48:40','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 09:52:12','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 09:59:26','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 10:09:40','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 10:21:49','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 10:26:42','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 10:35:58','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 10:44:11','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 10:45:44','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 10:46:25','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 10:48:49','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 10:50:08','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 10:53:35','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 10:56:40','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 10:57:24','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 11:02:15','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 11:03:26','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 11:10:29','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 11:30:41','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 11:35:59','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 11:39:17','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 11:41:39','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 11:47:23','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 11:49:30','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 11:51:05','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 12:01:16','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 12:05:22','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 12:58:07','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 12:59:01','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 13:00:17','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 13:02:28','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 13:22:35','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 13:25:45','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 13:26:24','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 13:26:56','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 13:29:59','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 13:31:21','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 13:32:34','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 13:35:34','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 13:36:39','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 13:38:33','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 13:41:16','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 13:49:59','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 13:52:09','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 13:55:40','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 14:08:54','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 14:10:35','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 14:14:54','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 14:15:29','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 14:15:36','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 14:28:46','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 14:30:54','admin','Table:users | userid=011407000012','UPDATE','pwd | ObjectId | Status | RoleId','anh | admin | 1 | admin'),('2014-08-12 14:31:20','admin','Table:products | productid=02000003','UPDATE','Name | Unit | Notes | ProductType','MassageBody | suất | có thêm khuyến mãi|02'),('2014-08-12 14:34:42','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 14:41:07','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 14:42:37','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 14:45:05','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 14:51:43','admin','Table:products | productid=011408000002','INSERT','Name | Unit | Notes | ProductType','Thịt khi tàu | nồi | |00'),('2014-08-12 14:52:42','admin','Table:products | productid=011408000002','UPDATE','Name | Unit | Notes | ProductType','Thịt khi tàu | nồi | |00'),('2014-08-12 14:52:56','admin','Table:products | productid=011408000002','UPDATE','Name | Unit | Notes | ProductType','Thịt khi tàu | Bát | |00'),('2014-08-12 14:55:01','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 15:08:22','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 15:08:59','admin','Table:products | productid=011408000003','INSERT','Name | Unit | Notes | ProductType','Thịt kho tàu | Nồi | Thơm ngon bổ dưỡng|00'),('2014-08-12 15:12:18','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 15:15:38','admin','Table:users | userid=11111111111','INSERT','pwd | ObjectId | Status | RoleId','1111111111 |  |  | '),('2014-08-12 15:23:03','admin','Table:users | userid=11111222001241','INSERT','pwd | ObjectId | Status | RoleId','112233 |  | 1 | admin'),('2014-08-12 15:23:07','admin','Table:users | userid=11111222001241','UPDATE','pwd | ObjectId | Status | RoleId','112233 |  | 1 | admin'),('2014-08-12 15:23:08','admin','Table:users | userid=11111222001241','UPDATE','pwd | ObjectId | Status | RoleId','112233 |  | 1 | admin'),('2014-08-12 15:23:09','admin','Table:users | userid=11111222001241','UPDATE','pwd | ObjectId | Status | RoleId','112233 |  | 1 | admin'),('2014-08-12 15:23:10','admin','Table:users | userid=11111222001241','UPDATE','pwd | ObjectId | Status | RoleId','112233 |  | 1 | admin'),('2014-08-12 15:23:11','admin','Table:users | userid=11111222001241','UPDATE','pwd | ObjectId | Status | RoleId','112233 |  | 1 | admin'),('2014-08-12 15:23:12','admin','Table:users | userid=11111222001241','UPDATE','pwd | ObjectId | Status | RoleId','112233 |  | 1 | admin'),('2014-08-12 15:23:13','admin','Table:users | userid=11111222001241','UPDATE','pwd | ObjectId | Status | RoleId','112233 |  | 1 | admin'),('2014-08-12 15:23:14','admin','Table:users | userid=11111222001241','UPDATE','pwd | ObjectId | Status | RoleId','112233 |  | 1 | admin'),('2014-08-12 15:36:59','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 15:40:05','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 15:56:58','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 16:07:49','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 16:14:58','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 16:21:04','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 16:23:14','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 16:28:43','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 16:39:52','admin','Table:products | productid=011408000002','INSERT','Name | Unit | Notes | ProductType','Thịt khi tàu_Thuan | Bát_Thuan | |00'),('2014-08-12 16:40:32','admin','Table:products | productid=011408000002','INSERT','Name | Unit | Notes | ProductType','Thịt khi tàu_Thuan | Bát_Thuan | |00'),('2014-08-12 16:40:37','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 16:40:50','admin','Table:products | productid=011408000002','INSERT','Name | Unit | Notes | ProductType','Thịt khi tàu_Thuan | Bát_Thuan | |00'),('2014-08-12 16:43:50','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 16:44:14','admin','Table:users | userid=','UPDATE','pwd | ObjectId | Status | RoleId',' |  | 5 | admin'),('2014-08-12 16:44:49','admin','Table:products | productid=011408000002','INSERT','Name | Unit | Notes | ProductType','Thịt khi tàu_Thuan | Bát_Thuan | |00'),('2014-08-12 16:46:53','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 16:54:26','admin','Table:products | productid=011408000002','INSERT','Name | Unit | Notes | ProductType','cá kho |  | |'),('2014-08-12 16:55:42','admin','Table:products | productid=011408000002','UPDATE','Name | Unit | Notes | ProductType','cá kho |  | |02'),('2014-08-12 16:57:19','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 17:03:19','admin','Table:products | productid=011408000002','UPDATE','Name | Unit | Notes | ProductType','Trứng kho - Cơm chiên trứng | bát | dddd|01'),('2014-08-12 17:07:46','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 17:08:42','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 17:12:25','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 17:13:35','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 17:13:42','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 17:14:56','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 17:15:22','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 17:17:29','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 17:17:54','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 17:18:56','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 17:19:08','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 17:20:11','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 17:22:13','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 17:22:49','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 17:23:28','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 17:23:58','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 17:24:31','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 17:24:57','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 17:34:59','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 17:50:00','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 17:51:54','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 17:56:15','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 18:04:58','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 18:16:20','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 18:19:12','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 18:21:44','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 18:32:50','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 18:34:25','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 18:49:09','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 18:51:11','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 18:52:26','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 18:53:48','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 19:02:34','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 19:07:14','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-12 19:11:40','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-13 08:29:56','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-13 08:34:53','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-13 08:46:34','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-13 08:56:28','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-13 08:57:56','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-13 09:02:21','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-13 09:09:24','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-13 09:14:33','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-13 09:18:18','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-13 09:52:07','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-13 09:54:15','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-13 09:55:23','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-13 09:59:44','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-13 10:02:02','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-13 10:07:08','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-13 10:51:53','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-13 10:53:37','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-13 10:54:40','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-13 11:24:30','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-13 11:28:23','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-13 11:39:45','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-13 11:44:37','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-13 11:52:29','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-13 11:58:53','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-13 12:00:13','admin','Table:users | userid=quanly','UPDATE','pwd | ObjectId | Status | RoleId','2345656 | quanly | 0 | quanly'),('2014-08-13 12:01:06','admin','Table:users | userid=011407000012','UPDATE','pwd | ObjectId | Status | RoleId','anh | admin | 0 | admin'),('2014-08-13 12:02:13','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-13 12:56:44','admin','Table:users | userid=nhanvien','UPDATE','pwd | ObjectId | Status | RoleId','08158291 | nhanvien | 2 | letan'),('2014-08-13 12:59:20','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-13 18:04:02','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-14 08:24:00','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-14 08:44:21','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-14 08:50:38','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-14 08:53:13','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-14 08:59:14','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-14 10:55:10','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-14 11:17:25','admin','Table:productprice | productprice=00000002|time=2014-08-14 11:17:25','INSERT','Price','12000.00'),('2014-08-14 11:23:50','CreatedId_admin','Table:productprice | productprice=011406000002|time=2014-07-06 22:38:32','INSERT','Price','5124000.00'),('2014-08-14 11:23:50','CreatedId_hung','Table:productprice | productprice=011406000000|time=2014-07-18 01:15:08','INSERT','Price','500000.00'),('2014-08-14 11:23:50','CreatedId_kimthuan','Table:productprice | productprice=011406000005|time=2014-07-23 06:10:27','INSERT','Price','4383000.00'),('2014-08-14 11:23:51','CreatedId_hung','Table:productprice | productprice=011406000019|time=2014-07-15 20:49:55','INSERT','Price','8958000.00'),('2014-08-14 11:23:51','CreatedId_kimthuan','Table:productprice | productprice=011406000016|time=2014-07-16 22:15:12','INSERT','Price','8303000.00'),('2014-08-14 11:24:37','CreatedId_hung','Table:productprice | productprice=011407000000|time=2014-07-20 06:50:02','INSERT','Price','6425000.00'),('2014-08-14 11:24:37','CreatedId_kimthuan','Table:productprice | productprice=011407000001|time=2014-07-03 22:16:51','INSERT','Price','8361000.00'),('2014-08-14 11:24:38','CreatedId_admin','Table:productprice | productprice=011407000015|time=2014-07-21 22:00:16','INSERT','Price','2209000.00'),('2014-08-14 11:24:38','CreatedId_hung','Table:productprice | productprice=011407000005|time=2014-07-04 20:28:45','INSERT','Price','6760000.00'),('2014-08-14 11:24:38','CreatedId_kimthuan','Table:productprice | productprice=011407000003|time=2014-07-09 10:11:33','INSERT','Price','6982000.00'),('2014-08-14 11:25:29','CreatedId_admin','Table:productprice | productprice=011408000000|time=2014-07-05 12:21:50','INSERT','Price','5143000.00'),('2014-08-14 11:25:29','CreatedId_hung','Table:productprice | productprice=011408000001|time=2014-07-26 12:53:45','INSERT','Price','5470000.00'),('2014-08-14 11:25:29','CreatedId_kimthuan','Table:productprice | productprice=011408000003|time=2014-07-05 02:50:43','INSERT','Price','7023000.00'),('2014-08-14 11:25:30','CreatedId_admin','Table:productprice | productprice=011408000006|time=2014-07-12 00:33:48','INSERT','Price','3714000.00'),('2014-08-14 11:25:30','CreatedId_hung','Table:productprice | productprice=011408000005|time=2014-07-04 03:48:45','INSERT','Price','4367000.00'),('2014-08-14 11:25:30','CreatedId_kimthuan','Table:productprice | productprice=011408000007|time=2014-07-09 02:31:38','INSERT','Price','3460000.00'),('2014-08-14 11:26:07','CreatedId_admin','Table:productprice | productprice=011408000000|time=2014-07-23 22:23:05','INSERT','Price','9008000.00'),('2014-08-14 11:26:07','CreatedId_hung','Table:productprice | productprice=011408000002|time=2014-07-19 05:22:01','INSERT','Price','461000.00'),('2014-08-14 11:26:07','CreatedId_kimthuan','Table:productprice | productprice=011408000001|time=2014-07-24 15:15:28','INSERT','Price','4096000.00'),('2014-08-14 11:26:08','CreatedId_admin','Table:productprice | productprice=011408000003|time=2014-07-21 14:02:54','INSERT','Price','6663000.00'),('2014-08-14 11:26:08','CreatedId_hung','Table:productprice | productprice=011408000006|time=2014-07-03 02:55:37','INSERT','Price','8845000.00'),('2014-08-14 11:26:08','CreatedId_kimthuan','Table:productprice | productprice=011408000007|time=2014-07-24 14:12:06','INSERT','Price','8694000.00'),('2014-08-14 11:26:09','CreatedId_admin','Table:productprice | productprice=011408000020|time=2014-07-16 15:53:01','INSERT','Price','4875000.00'),('2014-08-14 11:26:09','CreatedId_hung','Table:productprice | productprice=011408000022|time=2014-07-28 07:46:58','INSERT','Price','974000.00'),('2014-08-14 11:26:09','CreatedId_kimthuan','Table:productprice | productprice=011408000021|time=2014-07-27 20:26:16','INSERT','Price','9893000.00'),('2014-08-14 11:26:10','CreatedId_admin','Table:productprice | productprice=011408000047|time=2014-07-03 07:04:31','INSERT','Price','5441000.00'),('2014-08-14 11:26:10','CreatedId_hung','Table:productprice | productprice=011408000044|time=2014-07-05 12:14:28','INSERT','Price','4559000.00'),('2014-08-14 11:26:10','CreatedId_kimthuan','Table:productprice | productprice=011408000043|time=2014-07-05 08:18:36','INSERT','Price','9642000.00'),('2014-08-14 11:26:11','CreatedId_admin','Table:productprice | productprice=011408000068|time=2014-07-23 18:05:11','INSERT','Price','6053000.00'),('2014-08-14 11:26:11','CreatedId_hung','Table:productprice | productprice=011408000069|time=2014-07-29 11:54:22','INSERT','Price','8963000.00'),('2014-08-14 11:26:11','CreatedId_kimthuan','Table:productprice | productprice=011408000065|time=2014-07-25 02:27:28','INSERT','Price','9597000.00'),('2014-08-14 11:26:12','CreatedId_admin','Table:productprice | productprice=011408000091|time=2014-07-14 00:33:22','INSERT','Price','6493000.00'),('2014-08-14 11:26:12','CreatedId_hung','Table:productprice | productprice=011408000090|time=2014-07-18 03:26:01','INSERT','Price','1288000.00'),('2014-08-14 11:26:12','CreatedId_kimthuan','Table:productprice | productprice=011408000093|time=2014-07-24 22:33:50','INSERT','Price','7778000.00'),('2014-08-14 11:26:19','CreatedId_admin','Table:productprice | productprice=011408000000|time=2014-07-26 21:31:38','INSERT','Price','2904000.00'),('2014-08-14 11:26:19','CreatedId_hung','Table:productprice | productprice=011408000005|time=2014-07-07 09:05:39','INSERT','Price','8025000.00'),('2014-08-14 11:26:19','CreatedId_kimthuan','Table:productprice | productprice=011408000001|time=2014-07-10 11:02:19','INSERT','Price','758000.00'),('2014-08-14 11:26:20','CreatedId_admin','Table:productprice | productprice=011408000016|time=2014-07-19 16:34:17','INSERT','Price','7013000.00'),('2014-08-14 11:26:20','CreatedId_hung','Table:productprice | productprice=011408000014|time=2014-07-26 19:08:06','INSERT','Price','7511000.00'),('2014-08-14 11:26:20','CreatedId_kimthuan','Table:productprice | productprice=011408000013|time=2014-07-30 14:15:25','INSERT','Price','2571000.00'),('2014-08-14 11:26:21','CreatedId_admin','Table:productprice | productprice=011408000036|time=2014-07-08 00:02:14','INSERT','Price','361000.00'),('2014-08-14 11:26:21','CreatedId_hung','Table:productprice | productprice=011408000044|time=2014-07-13 13:04:05','INSERT','Price','4859000.00'),('2014-08-14 11:26:21','CreatedId_kimthuan','Table:productprice | productprice=011408000037|time=2014-07-14 09:09:32','INSERT','Price','1785000.00'),('2014-08-14 11:26:22','CreatedId_admin','Table:productprice | productprice=011408000058|time=2014-07-05 06:56:13','INSERT','Price','2634000.00'),('2014-08-14 11:26:22','CreatedId_hung','Table:productprice | productprice=011408000060|time=2014-07-28 00:56:57','INSERT','Price','9482000.00'),('2014-08-14 11:26:22','CreatedId_kimthuan','Table:productprice | productprice=011408000059|time=2014-07-15 10:58:57','INSERT','Price','9858000.00'),('2014-08-14 11:26:23','CreatedId_admin','Table:productprice | productprice=011408000081|time=2014-07-15 08:00:04','INSERT','Price','192000.00'),('2014-08-14 11:26:23','CreatedId_hung','Table:productprice | productprice=011408000084|time=2014-07-13 17:21:04','INSERT','Price','5819000.00'),('2014-08-14 11:26:23','CreatedId_kimthuan','Table:productprice | productprice=011408000082|time=2014-07-27 06:13:12','INSERT','Price','3114000.00'),('2014-08-14 11:46:48','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-14 13:02:12','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-14 13:06:03','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-14 13:54:02','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-14 13:59:23','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-14 14:00:18','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-14 14:10:23','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-14 14:59:36','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-14 15:11:30','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-14 15:12:26','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-14 15:19:46','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-14 15:21:43','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-14 15:23:20','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-14 15:37:47','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-14 15:48:23','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-14 15:51:30','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-14 16:18:05','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-14 16:22:32','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-14 16:56:02','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-14 16:57:22','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-14 16:58:24','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-14 17:03:04','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-14 17:04:30','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-14 17:07:58','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-14 17:10:07','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-14 17:17:57','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-14 17:18:50','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-14 17:28:19','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-14 17:29:37','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-14 17:33:00','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-14 17:39:07','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-14 17:41:34','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-14 17:55:12','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-14 17:56:29','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-14 17:58:28','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-14 18:00:03','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-14 18:25:09','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-14 18:53:06','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-14 19:15:26','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-15 08:32:37','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-15 08:44:11','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-15 08:52:25','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-15 09:08:57','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-15 09:51:24','admin','Table:productprice | productprice=00000022|time=2014-08-14 11:17:25','INSERT','Price','12000.00'),('2014-08-15 09:52:05','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-15 09:55:00','admin','Table:productprice | productprice=011408000001|time=2014-08-15 09:55:00','INSERT','Price','15000.00'),('2014-08-15 09:55:36','admin','Table:productprice | productprice=011408000002|time=2014-08-15 09:55:36','INSERT','Price','900000.00'),('2014-08-15 09:56:34','admin','Table:productprice | productprice=011408000003|time=2014-08-15 09:56:34','INSERT','Price','12000.00'),('2014-08-15 09:57:06','admin','Table:productprice | productprice=011408000005|time=2014-08-15 09:57:06','INSERT','Price','89000.00'),('2014-08-15 09:57:32','admin','Table:productprice | productprice=011408000006|time=2014-08-15 09:57:32','INSERT','Price','10000.00'),('2014-08-15 09:58:15','admin','Table:productprice | productprice=011408000007|time=2014-08-15 09:58:15','INSERT','Price','60000.00'),('2014-08-15 09:58:38','admin','Table:productprice | productprice=011408000008|time=2014-08-15 09:58:38','INSERT','Price','14000.00'),('2014-08-15 09:59:03','admin','Table:productprice | productprice=011408000009|time=2014-08-15 09:59:03','INSERT','Price','45000.00'),('2014-08-15 09:59:43','admin','Table:productprice | productprice=011408000010|time=2014-08-15 09:59:43','INSERT','Price','12000.00'),('2014-08-15 10:00:08','admin','Table:productprice | productprice=011408000011|time=2014-08-15 10:00:08','INSERT','Price','490000.00'),('2014-08-15 10:00:35','admin','Table:productprice | productprice=011408000012|time=2014-08-15 10:00:35','INSERT','Price','15000.00'),('2014-08-15 10:00:56','admin','Table:productprice | productprice=011408000013|time=2014-08-15 10:00:56','INSERT','Price','11000.00'),('2014-08-15 10:01:13','admin','Table:productprice | productprice=011408000014|time=2014-08-15 10:01:13','INSERT','Price','96000.00'),('2014-08-15 10:01:31','admin','Table:productprice | productprice=011408000015|time=2014-08-15 10:01:31','INSERT','Price','5000.00'),('2014-08-15 10:09:14','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-15 10:10:22','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-15 10:12:35','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-15 10:13:06','admin','Table:productprice | productprice=011408000001|time=2014-08-15 10:13:06','INSERT','Price','16000.00'),('2014-08-15 10:16:50','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-15 10:18:44','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-15 10:45:13','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-15 10:54:22','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-15 11:03:19','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-15 11:31:29','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-15 11:40:16','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-15 11:43:20','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-15 11:48:34','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-15 11:51:45','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-15 12:55:57','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-15 12:58:31','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-15 13:15:07','admin','Table:receipts | receiptid=1101140630000001','UPDATE',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 10 | 1 | 10012.00|0.00|10012.00|100000.00|10000.00'),('2014-08-15 13:15:28','admin','Table:receipts | receiptid=1101140630000004','UPDATE',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 17 | 1 | 101.00|0.00|101.00|1000.00|100.00'),('2014-08-15 13:15:52','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-15 13:34:56','hung','Table:receipts | receiptid=1101140701000009','UPDATE',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 5 | 1 | 86000.00|0.00|86000.00|90000.00|86000.00'),('2014-08-15 15:05:27','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-15 15:32:55','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-15 15:35:54','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-15 15:58:03','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-15 17:13:22','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-15 17:16:51','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-15 17:18:14','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-15 17:25:35','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-15 17:28:43','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-15 18:07:19','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-15 18:12:58','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-15 18:21:35','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-15 18:25:53','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-15 18:31:35','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-15 18:35:40','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-15 18:40:31','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-15 18:45:25','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-15 18:46:59','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-15 18:48:14','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-15 18:51:05','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-18 08:28:31','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-18 08:37:00','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-18 08:42:02','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-18 08:43:57','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-18 08:46:44','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-18 09:22:22','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-18 09:24:25','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-18 09:26:55','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-18 09:28:58','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-18 09:31:45','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-18 09:33:38','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-18 10:47:35','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-18 11:25:16','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-18 11:25:52','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-18 11:32:00','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-18 11:36:01','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-18 11:39:06','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-18 11:40:44','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-18 11:44:38','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-18 11:47:07','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-18 13:02:44','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-18 15:33:30','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-18 15:34:12','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-18 15:35:00','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-18 15:35:49','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 08:32:50','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 08:41:11','admin','Table:receipts | receiptid=1101140703000013','UPDATE',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 66000.00|0.00|66000.00|0.00|66000.00'),('2014-08-19 08:41:19','admin','Table:receipts | receiptid=1101140708000001','UPDATE',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 1047801.00|0.00|1047801.00|47801.00|1000000.00'),('2014-08-19 08:41:28','admin','Table:receipts | receiptid=1101140714000003','UPDATE',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 910556.00|0.00|910556.00|556.00|910000.00'),('2014-08-19 09:13:25','admin','Table:orders | orderid=102014081900001','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|56000|56000|0|56000'),('2014-08-19 09:14:45','admin','Table:receipts | receiptid=1101140819000001','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 56000.00|0.00|56000.00|0.00|56000.00'),('2014-08-19 09:47:25','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 09:49:51','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 09:55:18','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 10:14:08','admin','Table:orders | orderid=102014081900002','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|42000|42000|0|42000'),('2014-08-19 10:14:34','admin','Table:receipts | receiptid=1101140819000002','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 42000.00|0.00|42000.00|2000.00|40000.00'),('2014-08-19 10:27:54','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 10:45:27','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 10:57:51','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 11:00:58','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 11:04:35','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 11:07:37','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 11:09:45','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 11:11:18','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 11:14:53','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 11:26:18','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 11:34:52','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 11:46:47','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 11:51:24','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 11:54:26','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 12:01:30','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 12:03:58','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 12:05:12','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 12:06:35','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 12:56:14','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 13:06:47','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 13:10:35','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 13:12:10','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 13:14:56','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 13:16:41','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 13:25:02','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 13:40:51','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 13:47:39','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 13:48:29','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 13:48:37','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 13:49:34','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 13:52:35','admin','Table:users | userid=hung','UPDATE','pwd | ObjectId | Status | RoleId','12345 | 01011407000006 | 1 | admin'),('2014-08-19 13:57:56','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 14:04:35','admin','Table:users | userid=hung','UPDATE','pwd | ObjectId | Status | RoleId','12345 | 01011407000006 | 1 | admin'),('2014-08-19 14:29:42','admin','Table:users | userid=hung','UPDATE','pwd | ObjectId | Status | RoleId','12345 | 01011407000006 | 1 | admin'),('2014-08-19 14:50:35','admin','Table:users | userid=hung','UPDATE','pwd | ObjectId | Status | RoleId','12345 | 01011407000006 | 1 | admin'),('2014-08-19 14:53:38','admin','Table:users | userid=hung','UPDATE','pwd | ObjectId | Status | RoleId','12345 | 01011407000006 | 1 | admin'),('2014-08-19 14:54:46','admin','Table:users | userid=hung','UPDATE','pwd | ObjectId | Status | RoleId','12345 | 01011407000006 | 1 | admin'),('2014-08-19 14:56:36','admin','Table:users | userid=hung','UPDATE','pwd | ObjectId | Status | RoleId','12345 | 01011407000006 | 1 | admin'),('2014-08-19 14:56:37','admin','Table:users | userid=hung','UPDATE','pwd | ObjectId | Status | RoleId','12345 | 01011407000006 | 1 | admin'),('2014-08-19 14:57:07','admin','Table:users | userid=hung','UPDATE','pwd | ObjectId | Status | RoleId','12345 | 01011407000006 | 1 | admin'),('2014-08-19 14:58:40','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 15:21:40','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 15:24:30','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 15:27:01','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 15:29:34','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 15:31:24','admin','Table:users | userid=hung','UPDATE','pwd | ObjectId | Status | RoleId','12345 | 01011407000006 | 1 | admin'),('2014-08-19 15:51:52','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 15:53:07','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 16:06:15','admin','Table:orders | orderid=102014081900003','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|516000|516000|100000|416000'),('2014-08-19 16:07:33','admin','Table:receipts | receiptid=1101140819000003','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 416000.00|0.00|416000.00|16000.00|400000.00'),('2014-08-19 16:11:59','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 16:17:01','admin','Table:orders | orderid=102014081900004','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|31000|31000|1000|30000'),('2014-08-19 16:17:19','admin','Table:receipts | receiptid=1101140819000004','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 30000.00|0.00|30000.00|0.00|30000.00'),('2014-08-19 16:18:42','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 16:20:51','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 16:33:00','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 16:36:39','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 16:37:47','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 16:42:47','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 16:42:52','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 16:46:47','admin','Table:orders | orderid=102014081900005','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|61000|61000|1000|60000'),('2014-08-19 16:47:01','admin','Table:users | userid=hung','UPDATE','pwd | ObjectId | Status | RoleId','12345 | 01011407000006 | 1 | admin'),('2014-08-19 16:47:02','admin','Table:orders | orderid=102014081900006','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|101000|101000|11000|90000'),('2014-08-19 16:47:26','admin','Table:receipts | receiptid=1101140819000005','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 150000.00|0.00|150000.00|10000.00|140000.00'),('2014-08-19 16:47:32','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 16:50:32','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 17:03:29','admin','Table:orders | orderid=102014081900007','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|61000|61000|1000|60000'),('2014-08-19 17:03:39','admin','Table:orders | orderid=102014081900008','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|65000|65000|5000|60000'),('2014-08-19 17:04:00','admin','Table:receipts | receiptid=1101140819000006','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 120000.00|0.00|120000.00|20000.00|100000.00'),('2014-08-19 17:08:40','admin','Table:orders | orderid=102014081900009','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|61000|61000|1000|60000'),('2014-08-19 17:08:49','admin','Table:orders | orderid=102014081900010','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|65000|65000|5000|60000'),('2014-08-19 17:09:11','admin','Table:receipts | receiptid=1101140819000007','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 120000.00|0.00|120000.00|20000.00|100000.00'),('2014-08-19 17:10:22','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-19 17:11:41','admin','Table:orders | orderid=102014081900011','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|145000|145000|5000|140000'),('2014-08-19 17:11:59','admin','Table:orders | orderid=102014081900012','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|1390000|1390000|90000|1300000'),('2014-08-19 17:12:15','admin','Table:receipts | receiptid=1101140819000008','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 1440000.00|0.00|1440000.00|40000.00|1400000.00'),('2014-08-19 17:32:44','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-20 08:31:08','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-20 08:38:04','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-20 08:41:26','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-20 08:48:09','admin','Table:receipts | receiptid=1101140702000001','UPDATE',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 11000.00|0.00|11000.00|3000.00|8000.00'),('2014-08-20 08:48:18','admin','Table:receipts | receiptid=1101140702000003','UPDATE',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 526000.00|0.00|526000.00|8999.00|517001.00'),('2014-08-20 08:48:24','admin','Table:receipts | receiptid=1101140702000004','UPDATE',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 645001.00|0.00|645001.00|2333.00|642668.00'),('2014-08-20 08:48:33','admin','Table:receipts | receiptid=1101140702000005','UPDATE',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 113002.00|0.00|113002.00|0.00|113002.00'),('2014-08-20 09:03:27','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-20 10:03:46','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-20 10:48:52','admin','Table:orders | orderid=102014082000001','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|905000|905000|5000|900000'),('2014-08-20 11:24:31','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-20 11:25:39','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-20 11:26:53','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-20 11:30:01','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-20 11:47:59','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-20 13:07:44','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-20 13:12:46','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-20 13:15:31','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-20 13:18:54','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-20 13:23:44','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-20 13:31:54','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-20 13:38:00','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-20 13:39:00','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-20 14:25:14','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-20 14:45:10','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-20 14:47:24','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','123456789 | admin | 1 | admin'),('2014-08-20 14:51:55','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','123456789 | admin | 1 | admin'),('2014-08-20 14:52:09','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-20 14:58:29','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-20 14:58:50','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','123456789 | admin | 1 | admin'),('2014-08-20 14:59:35','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-20 15:00:57','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','123456789 | admin | 1 | admin'),('2014-08-20 15:01:06','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-20 15:01:15','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-20 15:16:26','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-20 15:17:13','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','123456789 | admin | 1 | admin'),('2014-08-20 15:17:30','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-20 17:18:06','admin','Table:users | userid=hung','UPDATE','pwd | ObjectId | Status | RoleId','DKRPPRJUWU | 01011407000006 | 1 | admin'),('2014-08-20 17:18:12','admin','Table:users | userid=hung','UPDATE','pwd | ObjectId | Status | RoleId','GDKXUAUMMM | 01011407000006 | 1 | admin'),('2014-08-20 17:18:13','admin','Table:users | userid=hung','UPDATE','pwd | ObjectId | Status | RoleId','ROKJHXWEFG | 01011407000006 | 1 | admin'),('2014-08-20 17:22:07','admin','Table:users | userid=hung','UPDATE','pwd | ObjectId | Status | RoleId','LFCSRYEEUJ | 01011407000006 | 1 | admin'),('2014-08-20 17:23:02','admin','Table:users | userid=011407000012','UPDATE','pwd | ObjectId | Status | RoleId','UERONDYBTU | admin | 0 | admin'),('2014-08-20 17:23:03','admin','Table:users | userid=ManhHung','UPDATE','pwd | ObjectId | Status | RoleId','RGTJXHDQBE | admin | 1 | admin'),('2014-08-20 17:23:04','admin','Table:users | userid=ManhHung','UPDATE','pwd | ObjectId | Status | RoleId','QLPWQHGXPG | admin | 1 | admin'),('2014-08-20 17:23:05','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','JOYZOKIHUC | admin | 1 | admin'),('2014-08-20 17:23:06','admin','Table:users | userid=anh','UPDATE','pwd | ObjectId | Status | RoleId','LHTAUIFYNY | admin | 1 | admin'),('2014-08-20 17:23:07','admin','Table:users | userid=ManhHung','UPDATE','pwd | ObjectId | Status | RoleId','DVFUBBIMPX | admin | 1 | admin'),('2014-08-20 17:23:08','admin','Table:users | userid=011407000012','UPDATE','pwd | ObjectId | Status | RoleId','HCSXUDIIYL | admin | 0 | admin'),('2014-08-20 17:23:09','admin','Table:users | userid=011407000012','UPDATE','pwd | ObjectId | Status | RoleId','KWIRVUJHFC | admin | 0 | admin'),('2014-08-20 17:23:10','admin','Table:users | userid=01140700001uuu','UPDATE','pwd | ObjectId | Status | RoleId','TTJOTTQOSB | admin | 1 | admin'),('2014-08-20 17:29:53','admin','Table:users | userid=01011407000002','UPDATE','pwd | ObjectId | Status | RoleId','KWIRVUJHFC | admin | 0 | admin'),('2014-08-20 17:32:39','admin','Table:users | userid=01011407000002','UPDATE','pwd | ObjectId | Status | RoleId','KWIRVUJHFC | 01011407000002 | 0 | admin'),('2014-08-20 17:33:08','admin','Table:users | userid=01011407000002','UPDATE','pwd | ObjectId | Status | RoleId','SZAJYTJUVM | 01011407000002 | 0 | admin'),('2014-08-20 17:34:03','admin','Table:users | userid=01011407000002','UPDATE','pwd | ObjectId | Status | RoleId','JFZIHVRSWX | 01011407000002 | 0 | admin'),('2014-08-20 17:36:29','admin','Table:users | userid=01011407000002','UPDATE','pwd | ObjectId | Status | RoleId','CAVTHKWRRS | 01011407000002 | 0 | admin'),('2014-08-20 17:37:05','admin','Table:users | userid=01011407000002','UPDATE','pwd | ObjectId | Status | RoleId','HOKDFUCXGZ | 01011407000002 | 0 | admin'),('2014-08-20 17:38:04','admin','Table:users | userid=01011407000002','UPDATE','pwd | ObjectId | Status | RoleId','LJRFKVFRGF | 01011407000002 | 0 | admin'),('2014-08-20 17:39:13','admin','Table:users | userid=01011407000002','UPDATE','pwd | ObjectId | Status | RoleId','UGWTXTDXSB | 01011407000002 | 0 | admin'),('2014-08-21 08:33:52','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 08:34:06','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 08:56:08','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 08:59:50','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 09:00:50','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 09:24:01','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 09:27:40','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 09:51:06','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 10:19:48','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 10:20:08','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 10:20:22','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 10:25:49','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 10:27:40','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 10:29:56','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 10:31:41','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 10:33:37','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 10:37:35','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 10:38:29','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 10:39:37','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 10:40:06','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 10:40:55','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 10:43:38','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 10:50:31','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 10:53:40','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 10:56:43','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 10:57:59','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 11:12:20','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 11:14:03','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 11:21:38','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 13:29:29','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 13:29:51','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 13:34:11','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 13:34:49','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 13:36:07','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 13:36:36','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 13:50:01','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 13:50:28','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 13:50:47','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 13:54:55','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 14:34:12','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 14:35:55','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 14:36:28','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 14:37:20','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 14:39:39','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 14:48:50','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 14:50:34','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 14:52:42','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 14:53:04','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 14:59:19','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 14:59:37','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 15:01:05','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 15:02:25','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 15:03:14','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 15:03:48','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 15:05:00','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 15:06:31','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 15:37:19','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 15:37:31','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 15:39:34','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 15:41:48','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 15:52:08','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 15:55:34','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 15:56:14','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 16:55:41','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 17:02:24','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 17:03:50','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 17:09:28','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 17:11:39','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 17:16:51','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 17:39:10','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 17:40:32','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 17:41:52','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 17:42:59','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 17:44:03','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 17:45:24','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 17:53:09','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 18:18:50','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 18:27:49','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 18:35:14','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 18:56:45','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 18:59:24','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 19:02:21','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 19:07:58','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 19:10:57','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 19:24:23','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-21 19:44:54','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-22 08:31:05','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-22 09:49:11','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-22 10:06:53','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-22 10:13:21','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-22 10:17:36','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-22 10:19:20','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-22 10:20:08','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-22 10:22:56','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-22 10:24:09','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-22 10:27:25','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-22 10:31:40','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-22 10:35:47','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-22 10:37:14','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-22 10:43:17','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-22 10:54:04','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-22 10:59:45','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-22 11:00:59','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-22 11:01:06','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-22 11:04:54','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-22 11:06:01','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-22 11:09:10','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-22 11:14:37','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-22 11:21:34','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-22 11:23:43','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-22 12:02:55','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-22 13:06:15','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-22 13:29:59','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-22 13:35:15','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-22 13:48:37','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-22 13:56:19','admin','Table:receipts | receiptid=1101140630000002','UPDATE',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 8 | 1 | 89.00|0.00|89.00|100.00|89.00'),('2014-08-22 13:56:36','admin','Table:receipts | receiptid=1101140630000003','UPDATE',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 3 | 1 | 910000.00|0.00|910000.00|1000000.00|900000.00'),('2014-08-22 13:56:58','admin','Table:receipts | receiptid=1101140630000005','UPDATE',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 4 | 1 | 56.00|0.00|56.00|56.00|56.00'),('2014-08-22 13:57:33','admin','Table:receipts | receiptid=1101140701000022','UPDATE',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 4 | 1 | 1468000.00|0.00|1468000.00|1500000.00|1468000.00'),('2014-08-22 13:57:58','admin','Table:receipts | receiptid=1101140701000025','UPDATE',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 5 | 1 | 145000.00|0.00|145000.00|140000.00|140000.00'),('2014-08-22 14:00:52','admin','Table:productprice | productprice=011408000003|time=2014-08-22 14:00:52','INSERT','Price',''),('2014-08-22 14:01:16','admin','Table:productprice | productprice=011408000003|time=2014-08-22 14:01:16','INSERT','Price',''),('2014-08-22 14:01:33','admin','Table:productprice | productprice=011408000001|time=2014-08-22 14:01:33','INSERT','Price',''),('2014-08-22 14:02:32','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-22 14:03:54','admin','Table:productprice | productprice=011408000002|time=2014-08-22 14:03:54','INSERT','Price',''),('2014-08-22 14:04:12','admin','Table:productprice | productprice=011408000003|time=2014-08-22 14:04:12','INSERT','Price',''),('2014-08-22 14:06:15','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-22 14:07:28','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-22 14:12:18','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-22 14:14:30','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-22 14:42:00','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-22 15:27:35','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-22 15:31:16','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-22 15:33:49','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-22 15:49:20','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-22 15:50:34','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-22 15:51:18','admin','Table:users | userid=test','INSERT','pwd | ObjectId | Status | RoleId','1234567 |  | 0 | letan'),('2014-08-22 15:52:20','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-22 15:53:30','admin','Table:users | userid=test','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | quanly | 0 | letan'),('2014-08-22 15:53:41','admin','Table:users | userid=test','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | quanly | 0 | letan'),('2014-08-22 15:53:59','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-22 15:54:46','admin','Table:users | userid=test','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | quanly | 1 | letan'),('2014-08-22 15:54:49','admin','Table:users | userid=test','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | quanly | 1 | letan'),('2014-08-22 15:55:23','admin','Table:users | userid=test','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | quanly | 1 | letan'),('2014-08-22 15:57:26','admin','Table:users | userid=test','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | quanly | 1 | letan'),('2014-08-22 15:58:29','admin','Table:users | userid=test','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | letan'),('2014-08-22 15:58:57','admin','Table:users | userid=test','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | letan'),('2014-08-22 16:13:00','admin','Table:users | userid=test','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | letan'),('2014-08-22 16:21:48','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-22 16:22:11','admin','Table:users | userid=test','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | letan'),('2014-08-22 16:23:29','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-22 16:30:51','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-22 16:33:57','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-22 16:39:53','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-22 16:43:03','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-22 16:45:31','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-22 16:55:32','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-22 16:56:36','admin','Table:productprice | productprice=011408000015|time=2014-08-22 16:56:36','INSERT','Price','3434.00'),('2014-08-22 16:57:28','admin','Table:productprice | productprice=011408000014|time=2014-08-22 16:57:28','INSERT','Price','454666666.00'),('2014-08-25 08:34:25','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 08:43:16','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 09:57:51','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 10:18:37','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 10:23:36','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 10:27:58','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 10:31:17','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 10:36:35','admin','Table:productprice | productprice=011408000003|time=2014-08-25 10:36:35','INSERT','Price','80000.00'),('2014-08-25 10:37:28','admin','Table:productprice | productprice=011408000017|time=2014-08-25 10:37:28','INSERT','Price','80000.00'),('2014-08-25 10:42:17','admin','Table:productprice | productprice=011408000005|time=2014-08-25 10:42:17','INSERT','Price','60000.00'),('2014-08-25 10:52:50','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 10:53:19','admin','Table:productprice | productprice=011408000002|time=2014-08-25 10:53:19','INSERT','Price','70000.00'),('2014-08-25 10:55:13','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 11:01:40','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 11:12:56','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 11:14:29','admin','Table:productprice | productprice=011408000013|time=2014-08-25 11:14:29','INSERT','Price','70000.00'),('2014-08-25 11:34:17','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 11:34:57','admin','Table:productprice | productprice=011408000012|time=2014-08-25 11:34:57','INSERT','Price','45000.00'),('2014-08-25 11:39:38','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 11:42:51','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 11:48:16','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 11:50:42','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 11:51:48','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 11:54:43','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 13:37:10','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 13:41:17','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 13:43:58','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 14:06:18','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 14:08:06','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 14:10:00','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 14:12:40','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 14:22:02','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 14:32:18','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 15:09:28','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 15:10:03','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 15:12:33','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 15:17:39','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 15:23:39','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 15:26:51','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 15:28:08','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 15:42:02','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 16:09:25','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 16:15:57','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 16:24:44','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 16:29:38','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 16:35:24','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 16:41:30','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 16:43:02','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 16:46:36','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 16:49:57','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 17:00:28','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 17:09:23','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 17:12:04','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 17:20:40','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 17:36:00','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 17:45:32','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 17:47:50','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 17:49:35','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 17:50:37','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 17:52:10','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 17:55:00','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 17:56:31','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 18:01:06','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 18:04:18','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 18:08:20','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 18:09:21','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 18:17:54','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 18:35:16','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-25 18:36:48','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-26 08:30:49','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-26 08:43:39','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-26 08:46:43','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-26 09:56:46','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-26 10:03:59','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-26 10:09:44','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-26 10:11:10','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-26 10:13:47','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-26 10:17:51','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-26 10:22:41','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-26 10:26:10','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-26 10:33:55','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-26 11:00:06','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-26 11:19:01','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-26 11:31:14','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-26 11:42:54','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-26 13:12:06','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-26 13:38:27','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-26 15:01:23','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-26 15:07:42','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-26 15:19:44','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-26 15:32:42','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-26 15:54:06','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-26 16:01:13','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-26 16:49:47','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-26 16:52:13','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-26 16:54:50','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-26 16:56:48','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-26 17:01:02','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-26 17:05:26','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-26 17:29:47','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-26 17:35:55','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-26 17:36:43','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-26 17:43:37','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-26 17:48:23','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-26 18:03:35','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-26 18:08:47','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-26 18:12:43','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-26 18:15:25','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-26 18:17:08','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-26 18:26:03','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-26 18:27:59','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-26 18:36:01','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-27 08:41:36','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-27 09:28:21','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-27 09:38:32','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-27 09:42:10','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-27 10:06:53','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-27 10:30:41','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-27 10:33:30','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-27 11:04:30','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-27 13:17:56','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-27 17:09:32','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-27 18:24:53','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-27 18:26:53','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-28 08:37:04','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-28 08:46:15','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-28 08:50:43','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-28 08:59:07','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-28 09:14:34','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-28 09:36:27','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-28 09:42:01','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-28 09:42:53','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-28 09:44:15','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-28 09:46:14','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-28 09:52:15','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-28 09:56:18','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-28 09:58:04','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-28 10:29:38','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-28 10:31:59','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-28 10:34:38','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-28 10:59:54','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-28 11:10:03','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-28 11:23:21','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-28 11:47:24','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-28 11:51:09','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-28 11:55:23','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-28 12:01:39','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-28 13:07:16','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-28 13:08:46','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-28 13:10:37','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-28 13:12:41','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-28 13:16:19','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-28 16:32:38','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-28 16:52:52','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-28 17:27:13','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-28 17:40:45','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-28 17:45:21','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-28 17:46:14','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-29 09:26:41','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-29 10:51:12','admin','Table:orders | orderid=102014082900001','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','34 |  | 0|0|15000|15000|0|15000'),('2014-08-29 10:57:54','admin','Table:orders | orderid=102014082900002','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|86000|86000|0|86000'),('2014-08-29 11:06:33','admin','Table:orders | orderid=102014082900003','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','34 |  | 0|0|74000|74000|0|74000'),('2014-08-29 11:20:20','admin','Table:orders | orderid=102014082900004','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','34 |  | 0|0|0|0|0|3255000'),('2014-08-29 14:35:31','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-29 14:36:07','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-29 14:47:20','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-29 14:50:48','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-29 14:55:55','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-29 14:58:22','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-29 15:03:29','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-29 15:05:52','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-29 15:08:35','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-29 15:11:27','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-29 15:16:43','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-29 15:17:38','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-29 15:19:33','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-29 15:20:28','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-29 15:21:44','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-29 15:23:50','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-29 15:25:22','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-29 15:26:03','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-29 15:42:59','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-29 17:33:35','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-08-29 17:36:25','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 10:35:30','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 11:01:54','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 11:02:33','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','123456 | admin | 1 | admin'),('2014-09-03 11:02:44','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','123456 | admin | 1 | admin'),('2014-09-03 11:03:02','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 11:03:32','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 11:04:25','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 11:08:20','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 11:24:29','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 13:06:25','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 13:09:35','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 13:20:37','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 13:32:00','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 13:52:10','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 13:58:27','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 14:08:23','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 14:24:17','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 14:26:56','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 14:29:44','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 14:32:15','admin','Table:productprice | productprice=011408000002|time=2014-09-03 14:32:15','INSERT','Price','0.00'),('2014-09-03 14:32:46','admin','Table:productprice | productprice=011408000002|time=2014-09-03 14:32:46','INSERT','Price','1.20'),('2014-09-03 14:33:39','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 14:35:55','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 14:36:06','admin','Table:productprice | productprice=011408000002|time=2014-09-03 14:36:06','INSERT','Price','45000.00'),('2014-09-03 14:36:25','admin','Table:productprice | productprice=011408000002|time=2014-09-03 14:36:25','INSERT','Price','4600.00'),('2014-09-03 14:40:20','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 14:40:56','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 14:42:58','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 14:43:36','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 14:58:55','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 15:01:25','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 15:08:21','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 15:09:55','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 15:14:50','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 15:17:18','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 15:21:37','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 15:25:30','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 15:28:08','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 15:34:07','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 15:38:47','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 15:43:44','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 15:47:04','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 15:58:43','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 15:59:57','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 16:02:20','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 16:04:21','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 16:07:33','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 16:09:02','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 16:11:37','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 16:17:51','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 16:19:56','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 16:29:16','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 16:59:14','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 17:05:45','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 17:12:55','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 17:14:11','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 17:17:54','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 17:19:31','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 17:27:50','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 17:28:39','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','123456 | admin | 1 | admin'),('2014-09-03 17:28:49','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','123456 | admin | 1 | admin'),('2014-09-03 17:29:10','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','123456 | admin | 1 | admin'),('2014-09-03 17:29:32','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 17:29:46','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 17:41:21','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 17:45:16','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 17:48:03','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 18:02:04','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 18:12:55','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 18:24:34','admin','Table:orders | orderid=102014090300001','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','21 |  | 0|0|0|0|0|48000'),('2014-09-03 18:27:54','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-03 18:47:19','admin','Table:orders | orderid=102014090300002','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','22 |  | 0|0|0|0|0|31000'),('2014-09-03 18:47:47','admin','Table:orders | orderid=102014090300003','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','14 |  | 0|0|0|0|0|44000'),('2014-09-04 08:43:26','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-04 09:04:07','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-04 09:05:26','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-04 09:09:54','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-04 09:18:39','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-04 09:24:26','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-04 09:31:34','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-04 10:15:12','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-04 10:25:12','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-04 10:28:35','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-04 10:29:21','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-04 10:34:18','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-04 10:37:13','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-04 10:40:56','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-04 10:58:27','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-04 10:58:49','admin','Table:receipts | receiptid=1101140904000001','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 76600.00|11.00|76611.00|2324.00|74287.00'),('2014-09-04 11:02:32','admin','Table:receipts | receiptid=1101140904000002','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 48000.00|0.00|48000.00|127.00|47873.00'),('2014-09-04 11:14:59','admin','Table:receipts | receiptid=1101140904000003','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 1001000.00|0.00|1001000.00|0.00|1001000.00'),('2014-09-04 11:28:04','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-04 11:32:16','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-04 11:38:58','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-04 13:05:34','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-04 13:08:09','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-04 13:10:58','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-04 13:12:09','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-04 13:21:11','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-04 13:25:02','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-04 13:31:22','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-04 13:31:42','admin','Table:orders | orderid=102014090400001','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|0'),('2014-09-04 13:32:01','admin','Table:orders | orderid=102014090400002','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|88000|88000|32|87968'),('2014-09-04 13:33:26','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-04 13:36:54','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-04 13:46:39','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-04 13:56:25','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-04 14:00:11','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-04 14:02:00','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-04 14:05:58','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-04 14:19:37','admin','Table:users | userid=ggggggg','INSERT','pwd | ObjectId | Status | RoleId','gggggg | 03011408000004 | 1 | nhanvien'),('2014-09-04 14:19:45','admin','Table:users | userid=ggggggg','UPDATE','pwd | ObjectId | Status | RoleId','gggggg | 03011408000004 | 0 | tablet'),('2014-09-04 14:20:05','admin','Table:users | userid=ggggggg','UPDATE','pwd | ObjectId | Status | RoleId','444 | 03011408000004 | 0 | tablet'),('2014-09-04 14:22:06','admin','Table:users | userid=01011407000002','UPDATE','pwd | ObjectId | Status | RoleId','UGWTXTDXSB | 01011407000002 | 0 | nhanvien'),('2014-09-04 14:22:11','admin','Table:users | userid=01011407000002','UPDATE','pwd | ObjectId | Status | RoleId','UGWTXTDXSB | 01011407000002 | 1 | nhanvien'),('2014-09-04 14:29:17','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-04 14:30:24','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-04 14:33:24','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-04 14:34:34','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-04 14:35:10','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-04 14:35:14','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-04 14:35:26','admin','Table:productprice | productprice=011408000003|time=2014-09-04 14:35:26','INSERT','Price','434343434.00'),('2014-09-04 14:38:58','admin','Table:orders | orderid=102014090400003','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','22 |  | 0|0|75000|75000|120|74880'),('2014-09-04 14:39:27','admin','Table:orders | orderid=102014090400004','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|28000'),('2014-09-04 14:39:59','admin','Table:orders | orderid=102014090400005','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|45000|45000|0|45000'),('2014-09-04 14:47:20','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-04 14:48:27','admin','Table:productprice | productprice=011408000003|time=2014-09-04 14:48:27','INSERT','Price','12000.00'),('2014-09-04 14:48:59','admin','Table:productprice | productprice=011408000012|time=2014-09-04 14:48:59','INSERT','Price','121100.00'),('2014-09-04 14:49:25','admin','Table:productprice | productprice=011408000012|time=2014-09-04 14:49:25','INSERT','Price','45000.00'),('2014-09-04 15:14:00','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-04 15:15:39','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-04 15:19:36','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-04 15:38:33','admin','Table:orders | orderid=102014090400006','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|76000|76000|12000|64000'),('2014-09-04 15:41:34','admin','Table:receipts | receiptid=1101140904000004','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 76000.00|0.00|76000.00|0.00|76000.00'),('2014-09-04 15:42:48','admin','Table:orders | orderid=102014090400007','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|60000|60000|0|60000'),('2014-09-04 15:44:32','admin','Table:orders | orderid=102014090400008','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|71000'),('2014-09-04 15:46:28','admin','Table:receipts | receiptid=1101140904000005','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 131000.00|0.00|131000.00|0.00|131000.00'),('2014-09-04 15:47:24','admin','Table:orders | orderid=102014090400009','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|12000'),('2014-09-04 15:47:51','admin','Table:orders | orderid=102014090400010','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|490000'),('2014-09-04 15:52:29','admin','Table:orders | orderid=102014090400011','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','34 |  | 0|0|0|0|0|12000'),('2014-09-04 15:52:52','admin','Table:orders | orderid=102014090400012','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','34 |  | 0|0|0|0|0|0'),('2014-09-04 15:53:32','admin','Table:receipts | receiptid=1101140904000006','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 0.00|0.00|0.00|0.00|0.00'),('2014-09-04 15:57:16','admin','Table:orders | orderid=102014090400013','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','34 |  | 0|0|14|14|0|14'),('2014-09-04 15:57:23','admin','Table:orders | orderid=102014090400014','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|60000'),('2014-09-04 15:57:49','admin','Table:orders | orderid=102014090400015','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|0'),('2014-09-04 17:06:00','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-04 17:55:20','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-04 18:27:35','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-04 19:07:40','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-04 19:15:31','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-04 19:18:35','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-04 19:21:03','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-04 19:23:50','admin','Table:orders | orderid=102014090400016','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|59000'),('2014-09-04 19:34:06','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-05 08:41:50','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-05 08:48:36','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-05 10:13:22','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-05 10:19:02','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-05 10:31:31','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-05 10:42:12','admin','Table:orders | orderid=102014090500001','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|12000'),('2014-09-05 10:53:49','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-05 11:29:07','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-05 12:58:17','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-06 10:14:21','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-06 10:57:57','admin','Table:orders | orderid=102014090600001','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|26000|26000|0|26000'),('2014-09-06 12:17:04','admin','Table:orders | orderid=102014090600002','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|45000|45000|0|45000'),('2014-09-06 12:17:27','admin','Table:orders | orderid=102014090600003','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|12000|12000|0|12000'),('2014-09-06 12:17:56','admin','Table:orders | orderid=102014090600004','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|12000|12000|0|12000'),('2014-09-06 13:10:10','admin','Table:orders | orderid=102014090600005','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|45000|45000|0|45000'),('2014-09-06 14:20:52','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-06 14:25:33','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-06 14:27:30','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-06 14:28:49','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-06 14:32:40','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-06 14:34:36','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-06 14:56:41','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-06 14:59:18','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-06 15:02:02','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-06 15:07:14','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-06 15:10:37','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-06 15:12:04','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-06 15:13:48','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-06 15:15:52','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-06 15:17:49','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-06 15:22:55','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-06 15:25:48','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-06 15:27:23','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-06 15:32:48','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-06 15:35:17','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-06 15:37:26','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-06 15:49:57','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-06 16:27:32','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-06 16:32:31','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-06 16:57:56','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-06 17:00:35','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-06 17:02:58','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-06 17:04:40','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-06 17:09:27','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-06 17:19:07','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-06 17:44:25','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-06 17:45:58','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-06 17:52:00','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-07 08:57:41','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-07 09:08:13','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-07 09:24:48','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-07 09:27:58','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-07 09:36:32','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-07 09:41:52','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-07 10:55:29','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-07 10:57:41','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-07 10:59:19','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-07 11:00:44','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-07 11:08:18','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-07 11:09:42','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-07 11:12:23','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-07 11:13:48','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-07 11:16:11','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-07 11:19:44','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-07 11:22:05','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-07 11:40:29','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-07 11:41:23','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-07 11:42:54','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-07 11:44:32','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-07 11:49:01','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 08:25:13','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 08:29:12','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 08:32:50','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 09:23:43','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 09:32:39','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 09:35:05','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 09:37:37','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 09:41:12','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 09:59:49','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 10:04:25','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 10:05:29','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 10:24:35','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 10:27:02','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 10:29:43','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 10:42:37','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 11:47:35','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 11:50:42','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 11:59:57','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 12:03:15','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 12:07:19','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 12:53:53','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 12:57:22','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 13:23:38','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 13:27:41','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 13:35:53','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 13:40:20','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 13:43:29','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 14:05:13','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 14:07:26','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 14:27:35','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 14:32:40','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 14:40:50','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 14:46:00','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 14:47:03','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 14:50:26','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 14:52:39','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 14:57:09','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 15:00:58','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 15:04:42','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 15:11:42','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 15:43:27','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 15:50:22','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 15:52:57','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 15:56:07','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 16:01:18','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 16:05:03','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 16:07:07','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 16:25:11','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 16:29:06','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 16:33:39','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 17:00:47','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 17:03:35','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 17:14:54','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 17:20:46','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 17:29:52','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 17:31:02','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 17:35:22','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 17:40:00','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-08 17:46:39','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-09 17:00:30','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-09 17:55:01','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-09 18:04:15','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-09 18:05:16','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-09 18:06:24','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-09 18:18:48','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-09 18:19:46','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-09 18:29:05','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-09 19:02:18','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-09 19:09:01','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-09 19:12:20','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-09 19:14:52','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-09 19:17:06','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-09 19:22:11','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-10 13:20:30','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-10 13:51:50','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-10 13:53:33','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-10 13:57:34','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-10 14:10:24','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-10 14:12:13','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-10 14:21:29','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-10 14:23:20','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-10 14:24:57','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-10 16:19:43','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-12 11:16:18','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-12 11:28:17','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-12 11:34:50','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-17 09:21:53','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-17 14:45:39','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-17 16:01:19','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-17 16:03:14','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-17 16:42:46','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-17 18:01:32','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-17 18:21:47','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-19 08:37:32','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-19 08:50:09','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-19 09:33:49','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-19 18:30:49','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-20 11:57:44','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-20 11:58:17','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-20 11:58:37','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-20 12:02:10','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-20 12:05:03','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-22 10:38:06','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-22 10:40:09','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-22 13:01:46','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-22 13:10:20','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-23 10:05:00','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-23 10:26:09','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-23 10:33:10','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-23 10:33:33','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-23 10:39:27','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-23 10:44:43','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-23 10:49:41','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-23 10:55:24','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-23 11:01:24','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-23 11:03:26','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-23 11:07:58','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-23 11:11:51','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-23 11:17:05','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-23 11:18:09','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-23 11:23:24','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-23 11:36:00','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-23 14:45:59','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-23 17:48:26','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-24 10:42:11','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-24 10:48:13','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-24 11:06:03','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-24 11:42:12','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-24 11:43:44','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-24 11:44:35','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-24 12:52:52','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-09-24 13:10:14','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-11-20 09:34:00','admin','Table:orders | orderid=102014112000001','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','22 |  | 0|0|0|0|0|90000'),('2014-11-20 09:34:33','admin','Table:receipts | receiptid=1101141120000001','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 90000.00|0.00|90000.00|10000.00|80000.00'),('2014-11-24 17:03:36','admin','Table:orders | orderid=102014112400001','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','15 |  | 0|0|0|0|0|22000'),('2014-11-24 17:16:32','admin','Table:receipts | receiptid=1101141124000001','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 22000.00|0.00|22000.00|10000.00|12000.00'),('2014-11-25 10:13:27','admin','Table:orders | orderid=102014112500001','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','26 |  | 0|0|545000|545000|1000|544000'),('2014-11-25 10:34:48','admin','Table:orders | orderid=102014112500002','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','25 |  | 0|0|90000|90000|10000|80000'),('2014-11-25 10:35:17','admin','Table:receipts | receiptid=1101141125000001','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 80000.00|0.00|80000.00|10000.00|70000.00'),('2014-11-26 10:07:16','admin','Table:receipts | receiptid=1101141126000001','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 74000.00|0.00|74000.00|0.00|74000.00'),('2014-11-26 13:29:01','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-11-26 13:29:25','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-11-26 14:00:52','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-11-26 14:05:35','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-11-26 14:12:57','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-11-26 14:38:54','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-11-26 14:47:40','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-11-26 14:49:32','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-11-26 14:55:41','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-11-26 14:57:37','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-11-26 15:39:51','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-11-26 15:44:15','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-11-26 15:50:32','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-11-26 15:52:30','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-11-26 15:54:10','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-11-26 15:57:05','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-11-26 16:02:45','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-11-26 16:07:34','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-11-26 16:13:14','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-11-26 16:16:45','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-11-26 16:34:24','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-11-26 16:35:50','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-11-26 17:04:10','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-11-27 10:00:49','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-11-27 10:21:49','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-11-27 10:41:34','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-11-27 10:44:40','admin','Table:users | userid=quay1casang','INSERT','pwd | ObjectId | Status | RoleId','1234567 | 01011411000001 | 0 | admin'),('2014-11-27 10:50:49','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-11-27 11:08:14','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | admin | 1 | admin'),('2014-11-27 11:08:33','admin','Table:users | userid=quay1casang','UPDATE','pwd | ObjectId | Status | RoleId','1234567 | 01011411000001 | 1 | admin'),('2014-11-27 11:23:28','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-11-27 11:25:16','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-11-27 11:25:41','admin','Table:users | userid=quay1casang','UPDATE','pwd | ObjectId | Status | RoleId','25f9e794323b453885f5181f1b624d0b | 01011411000001 | 1 | admin'),('2014-11-27 12:22:07','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-11-27 12:36:20','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-11-27 12:40:32','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-11-27 13:19:28','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-11-27 13:22:19','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-11-27 13:23:04','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-11-27 13:51:03','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-11-27 14:07:12','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-11-28 15:35:31','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-11-28 15:37:32','admin','Table:productprice | productprice=Trứng kho - |time=2014-11-28 15:37:32','INSERT','Price','20000.00'),('2014-11-29 10:56:55','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-11-29 11:12:11','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-11-29 11:16:55','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-11-29 11:17:25','admin','Table:productprice | productprice=Trứng kho - |time=2014-11-29 11:17:25','INSERT','Price','100.00'),('2014-11-29 13:54:55','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-11-29 13:57:52','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-11-29 13:58:06','admin','Table:productprice | productprice=011408000002|time=2014-11-29 13:58:06','INSERT','Price','10.00'),('2014-11-29 14:09:33','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-11-29 14:09:45','admin','Table:productprice | productprice=011408000003|time=2014-11-29 14:09:45','INSERT','Price','20.00'),('2014-11-29 14:13:38','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-11-29 14:13:55','admin','Table:productprice | productprice=011408000003|time=2014-11-29 14:13:55','INSERT','Price','20000.00'),('2014-11-29 14:19:26','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-11-29 14:19:41','admin','Table:productprice | productprice=011408000006|time=2014-11-29 14:19:41','INSERT','Price','50000.00'),('2014-11-29 14:21:53','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-11-29 14:41:31','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-11-29 14:59:41','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-11-29 15:05:59','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-11-29 15:07:23','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-11-29 15:26:11','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-11-29 15:28:26','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-11-29 15:36:53','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-11-29 15:43:24','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-11-29 15:51:33','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-11-29 15:56:22','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-11-29 15:59:02','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-11-29 16:01:23','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-11-29 16:05:57','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-11-29 16:12:57','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-11-29 16:13:50','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-11-29 16:16:29','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-11-29 16:19:53','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-11-29 16:30:40','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-11-29 16:32:21','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-11-29 16:34:07','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-11-29 16:36:34','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-01 08:39:45','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-01 08:48:29','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-01 10:03:00','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-01 10:05:22','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-01 10:05:45','admin','Table:productprice | productprice=011408000002|time=2014-12-01 10:05:45','INSERT','Price','100000.00'),('2014-12-01 10:17:21','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-01 10:20:31','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-01 10:36:46','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-01 10:38:58','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-01 10:48:00','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-01 10:50:47','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-01 13:17:10','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-01 13:23:41','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-01 13:26:27','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-01 13:31:36','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-01 13:33:45','admin','Table:orders | orderid=102014120100001','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','34 |  | 0|0|130000|130000|0|130000'),('2014-12-01 13:35:20','admin','Table:receipts | receiptid=1101141201000001','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 130000.00|0.00|130000.00|10.00|117000.00'),('2014-12-01 13:35:41','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-01 13:40:46','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-01 13:50:49','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-01 13:55:45','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-01 13:56:02','admin','Table:productprice | productprice=011408000002|time=2014-12-01 13:56:02','INSERT','Price','999999999999999999.99'),('2014-12-01 14:05:43','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-01 14:18:12','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-01 14:18:57','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-01 14:20:12','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-01 14:21:12','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-01 14:31:53','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-01 14:36:37','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-01 14:54:42','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-01 15:00:04','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-01 15:19:44','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-01 15:22:19','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-01 15:24:14','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-01 15:30:05','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-01 15:34:06','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-01 15:56:16','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-01 16:03:05','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-01 16:14:23','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-01 16:17:29','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-01 16:47:52','admin','Table:orders | orderid=102014120100002','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|120000|120000|1000|119000'),('2014-12-01 16:53:43','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-02 08:51:25','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-02 08:54:19','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-02 09:03:29','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-02 09:06:32','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-02 09:18:33','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-02 09:20:11','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-02 09:20:52','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-02 09:35:08','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-02 09:38:55','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-02 10:01:24','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-02 10:05:06','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-02 10:10:18','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-02 10:17:07','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-02 10:30:19','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-02 10:38:48','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-02 10:39:52','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-02 10:58:14','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-02 11:12:12','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-02 11:30:02','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-02 11:31:52','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-02 11:34:15','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-02 11:35:18','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-02 11:37:20','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-02 11:42:36','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-02 11:44:54','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-02 13:09:50','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-02 14:33:23','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-02 14:59:22','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-02 15:32:44','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-02 15:35:58','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-02 16:07:07','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-02 16:09:39','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-02 16:13:09','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-02 16:14:50','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-02 16:15:55','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-02 16:16:36','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-02 16:17:33','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-02 16:37:13','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-02 17:05:50','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-03 08:44:40','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-03 08:51:42','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-03 10:52:24','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-03 13:05:31','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-03 13:07:51','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-03 13:38:29','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-03 13:48:21','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-03 13:56:21','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-03 13:58:37','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-03 13:59:00','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-03 14:13:11','admin','Table:orders | orderid=102014120300001','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','14 |  | 0|0|0|0|10000|80000'),('2014-12-03 14:14:11','admin','Table:orders | orderid=102014120300002','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','14 |  | 0|0|70000|70000|0|70000'),('2014-12-03 14:15:16','admin','Table:receipts | receiptid=1101141203000001','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 74880.00|0.00|74880.00|7488.00|67392.00'),('2014-12-03 14:17:25','admin','Table:receipts | receiptid=1101141203000002','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 115968.00|0.00|115968.00|11596.00|104371.00'),('2014-12-03 14:32:58','admin','Table:orders | orderid=102014120300003','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','35 |  | 0|0|0|0|10000|357000'),('2014-12-03 14:33:19','admin','Table:orders | orderid=102014120300004','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','36 |  | 0|0|140000|140000|0|140000'),('2014-12-03 14:38:11','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-03 14:42:11','admin','Table:orders | orderid=102014120300005','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','35 |  | 0|0|135000|135000|0|135000'),('2014-12-03 14:48:26','admin','Table:receipts | receiptid=1101141203000003','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 90000.00|0.00|90000.00|0.00|90000.00'),('2014-12-03 14:48:58','admin','Table:receipts | receiptid=1101141203000004','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 135000.00|0.00|135000.00|0.00|135000.00'),('2014-12-03 14:53:03','admin','Table:receipts | receiptid=1101141203000005','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 267000.00|0.00|267000.00|0.00|267000.00'),('2014-12-03 14:54:20','admin','Table:receipts | receiptid=1101141203000006','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 80000.00|0.00|80000.00|0.00|80000.00'),('2014-12-03 15:14:31','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-03 15:35:54','admin','Table:users | userid=UserC','INSERT','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | 01011412000002 | 1 | admin'),('2014-12-03 19:03:40','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-03 19:03:51','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-03 19:05:22','admin','Table:orders | orderid=102014120300006','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','36 |  | 0|0|34000|34000|10000|24000'),('2014-12-03 19:10:55','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-03 19:12:37','admin','Table:orders | orderid=102014120300007','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','35 |  | 0|0|90000|90000|0|90000'),('2014-12-03 19:23:25','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-03 19:29:04','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-03 19:29:37','admin','Table:productprice | productprice=011408000002|time=2014-12-03 19:29:37','INSERT','Price','100000.00'),('2014-12-03 19:31:42','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-03 19:44:02','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-03 20:09:19','admin','Table:orders | orderid=102014120300008','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|676000|676000|100000|576000'),('2014-12-03 20:22:07','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2014-12-03 20:28:36','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2016-10-25 19:40:10','admin','Table:orders|orderid=102016102500001','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|0'),('2016-10-25 19:48:59','admin','Table:orders|orderid=102016102500001','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|0'),('2016-10-25 19:50:00','admin','Table:orders|orderid=102016102500002','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|0|0|0|0|0'),('2016-10-25 20:01:04','admin','Table:orders|orderid=102016102500003','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|26400|290400|264000|0|290400'),('2016-10-25 21:57:38','admin','Table:receipts|receiptid=1101161025000001','INSERT',' Note | NoOfCustumers | Status | TotalAmountBeforeTax | TotalTax | TotalAmmount | DiscountAmmmount | TotalMoney ',' | 0 | 1 | 132000.00|13200.00|145200.00|0.00|145200.00'),('2016-10-27 04:23:03','admin','Table:orders|orderid=102016102700001','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|13200|145200|132000|0|145200'),('2016-10-27 04:25:12','admin','Table:orders|orderid=102016102700002','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|13200|145200|132000|0|145200'),('2016-10-27 04:35:33','admin','Table:orders|orderid=102016102700003','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|13200|145200|132000|0|145200'),('2016-10-27 04:40:58','admin','Table:orders|orderid=102016102700004','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|26400|290400|264000|0|290400'),('2016-10-27 04:43:25','admin','Table:orders|orderid=102016102700005','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|13200|145200|132000|0|145200'),('2016-10-27 04:46:58','admin','Table:orders|orderid=102016102700006','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|26400|290400|264000|0|290400'),('2016-10-27 06:11:27','admin','Table:orders|orderid=102016102700007','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|13200|145200|132000|0|145200'),('2016-10-29 05:38:39','admin','Table:users | userid=UserC','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | 01011412000002 | 1 | admin'),('2016-10-29 13:22:16','admin','Table:orders|orderid=102016102900001','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|1000|11000|10000|0|11000'),('2016-11-05 13:32:16','admin','Table:orders|orderid=102016110500001','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 |  | 0|1000|11000|10000|0|11000'),('2016-11-05 16:48:37','admin','Table:orders|orderid=102016110500002','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 | 115 Nguyen Hue | 0|1000|11000|10000|0|11000'),('2016-11-05 17:12:50','admin','Table:orders|orderid=102016110500003','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 | 336 Nguyen trai | 0|1000|11000|10000|0|11000'),('2016-11-05 18:19:26','admin','Table:orders|orderid=102016110500004','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 | 121 Hoang Hoa tha | 0|1000|11000|10000|0|11000'),('2016-11-06 08:44:09','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2016-11-06 08:48:13','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2016-11-06 08:49:19','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2016-11-06 08:52:40','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','508df4cb2f4d8f80519256258cfb975f | admin | 1 | admin'),('2016-11-06 08:54:11','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2016-11-06 08:55:35','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','508df4cb2f4d8f80519256258cfb975f | admin | 1 | admin'),('2016-11-06 09:00:30','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2016-11-06 09:01:17','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2016-11-06 09:01:53','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2016-11-06 09:02:36','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2016-11-06 09:04:58','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2016-11-06 14:02:36','admin','Table:users | userid=trieuchau','INSERT','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | 01011611000001 | 1 | admin'),('2016-11-06 14:03:13','admin','Table:users | userid=trieuchau','UPDATE','pwd | ObjectId | Status | RoleId','f1887d3f9e6ee7a32fe5e76f4ab80d63 | 01011611000001 | 1 | admin'),('2016-11-06 15:07:09','admin','Table:users | userid=admin','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | admin | 1 | admin'),('2016-11-06 15:17:27','admin','Table:commoncode|CommonTypeId=ProductType|CommonId=01','INSERT','StrValue1 | StrValue2| NumValue1 | NumValue2 | CanDelete| ParentId','Thuc an |  | |  | |'),('2016-11-06 15:18:27','admin','Table:commoncode|CommonTypeId=ProductType|CommonId=02','INSERT','StrValue1 | StrValue2| NumValue1 | NumValue2 | CanDelete| ParentId','Thuc uong |  | |  | |'),('2016-11-06 15:18:51','admin','Table:commoncode|CommonTypeId=ProductType|CommonId=03','INSERT','StrValue1 | StrValue2| NumValue1 | NumValue2 | CanDelete| ParentId','SP Them |  | |  | |'),('2016-11-06 15:19:52','admin','Table:commoncode|CommonTypeId=ProductType|CommonId=04','INSERT','StrValue1 | StrValue2| NumValue1 | NumValue2 | CanDelete| ParentId','Loai khac |  | |  | |'),('2016-11-06 15:20:40','admin','Table:commoncode|CommonTypeId=ProductType|CommonId=0401','INSERT','StrValue1 | StrValue2| NumValue1 | NumValue2 | CanDelete| ParentId','Loai khac 1 | Loai khac rat khac | |  | |04'),('2016-11-06 15:21:26','admin','Table:commoncode|CommonTypeId=ProductType|CommonId=0402','INSERT','StrValue1 | StrValue2| NumValue1 | NumValue2 | CanDelete| ParentId','Loai khac 2 | Rat rat khac | |  | |04'),('2016-11-06 17:16:29','admin','Table:orders|orderid=102016110600001','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 | 121 hon ho th | 0|3000|33000|30000|0|33000'),('2016-11-06 18:03:24','admin','Table:orders|orderid=102016110600002','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 | abc | 0|5000|55000|50000|0|55000'),('2016-11-06 18:11:19','admin','Table:orders|orderid=102016110600003','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 | bhhjkkm | 0|23000|253000|230000|0|253000'),('2016-11-06 18:23:34','admin','Table:orders|orderid=102016110600004','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 | hhhhh | 0|3000|33000|30000|0|33000'),('2016-11-06 18:32:08','admin','Table:orders|orderid=102016110600005','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 | ggfgf | 0|23000|253000|230000|0|253000'),('2016-11-06 18:36:18','admin','Table:orders|orderid=102016110600006','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 | kkkk | 0|23000|253000|230000|0|253000'),('2016-11-08 14:10:35','admin','Table:orders|orderid=102016110800001','INSERT','DeskId | Note | Status | TotalTax | TotalAmount | TotalAmountBeforeTax | DisCountAmount|TotalMoney','0 | vxfdf | 0|3000|33000|30000|0|33000'),('2016-11-08 17:49:57','admin','Table:users | userid=trieuchau','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | 01011611000001 | 1 | admin'),('2016-11-08 17:50:35','admin','Table:users | userid=trieuchau','UPDATE','pwd | ObjectId | Status | RoleId','e10adc3949ba59abbe56e057f20f883e | 01011611000001 | 1 | admin');
/*!40000 ALTER TABLE `useractionhistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `users` (
  `UserId` varchar(100) NOT NULL,
  `Pwd` varchar(500) DEFAULT NULL,
  `ObjectId` varchar(20) DEFAULT NULL,
  `LastLogin` datetime DEFAULT NULL,
  `Status` varchar(20) DEFAULT NULL,
  `CreatedBy` varchar(20) DEFAULT NULL,
  `CreatedDate` datetime DEFAULT NULL,
  `ModifiedBy` varchar(20) DEFAULT NULL,
  `ModifiedDate` datetime DEFAULT NULL,
  `RoleId` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`UserId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES ('admin','e10adc3949ba59abbe56e057f20f883e','admin','2016-11-06 15:07:09','1','admin','2014-06-20 14:59:20','admin','2016-11-06 09:00:30','admin'),('trieuchau','e10adc3949ba59abbe56e057f20f883e','01011611000001','2016-11-08 17:50:35','1','admin','2016-11-06 14:02:36','admin','2016-11-08 17:49:57','admin');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `tgInsert_Users` AFTER INSERT ON `users` FOR EACH ROW BEGIN
	CALL spInsert_UserActionHistory(NEW.`CreatedBy`,
	CONCAT('Table:users | userid=' , NEW.`UserId`),'INSERT','pwd | ObjectId | Status | RoleId',
	CONCAT(IFNULL(NEW.`Pwd`,''), ' | ',IFNULL(NEW.`ObjectId`,''), ' | ',IFNULL(NEW.`Status`,''), ' | ',IFNULL(NEW.`RoleId`,''))); 
	
	 /*UPDATE  `actions`
	 SET  `Status`= NEW.`Status`,
	  `UpdaterID` =NEW.`CreatorID`,
	  `UpdatedDate` = NOW()
	 WHERE `ActionsID`=NEW.`ActionID`;*/
    END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `tgUpdate_Users` AFTER UPDATE ON `users` FOR EACH ROW BEGIN
	CALL spInsert_UserActionHistory(NEW.`ModifiedBy`,
	CONCAT('Table:users | userid=' , NEW.`UserId`),'UPDATE','pwd | ObjectId | Status | RoleId',
	CONCAT(IFNULL(NEW.`Pwd`,''), ' | ',IFNULL(NEW.`ObjectId`,''), ' | ',IFNULL(NEW.`Status`,''), ' | ',IFNULL(NEW.`RoleId`,''))); 
    END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Dumping events for database 'pos_hdt'
--

--
-- Dumping routines for database 'pos_hdt'
--
/*!50003 DROP PROCEDURE IF EXISTS `spCancelReceipts` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spCancelReceipts`(
	p_Id varchar(255),
	p_Notes text,
	p_User varchar(255)
    )
BEGIN
	select r.*, p.`Name` from `receiptdetails` as r left join `products` as p on r. `ProductId` = p.`ProductId` where r.`ReceiptId` = p_Id;
	UPDATE `receipts` set `Status` = 2, `Note` = p_Notes, `ModifiedBy` = p_User, `ModifiedDate` = NOW() where `ReceiptId` = p_Id;
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spChangePassword_User` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spChangePassword_User`(
	p_UserId varchar(100),
	p_Pwd varchar(500)
    )
BEGIN
	UPDATE `users`
	set `Pwd` = p_Pwd,`ModifiedDate` = now()
	where `UserId` = p_UserId;
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spDelete_Desk` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spDelete_Desk`(
	p_DeskId int(11)
    )
BEGIN
	delete from `desk`
	where `DeskId` = p_DeskId;
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spDelete_OrderDetail` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spDelete_OrderDetail`(
	order_id  VARCHAR(20),
	product_id varchar(20)
    )
BEGIN
	DELETE 
	FROM `orderdetails`
	WHERE `OrderId` = order_id
	and `ProductId` = product_id;
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spDelete_Orders` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spDelete_Orders`(
	p_OrderId varchar(20),
	p_Status varchar(20)
	)
BEGIN
	update `orders` set `Status` = p_Status	where `OrderId` = p_OrderId;
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spGetMenu` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spGetMenu`(
	p_Level		VARCHAR(255),
	p_CommonType 	VARCHAR(20),
	p_NoStart       INT(11),
	p_NoEnd         INT(11)
    )
BEGIN
	SET @a = 'SELECT * FROM `commoncode` where 1=1 ';
	SET @a1 = 'SELECT count(*) as `Total` FROM `commoncode` where 1=1 ';
	/*`ProductId`*/
	IF p_CommonType IS NOT NULL 
	THEN
		SET @a = CONCAT(@a, ' and `CommonTypeId` = \'',p_CommonType, '\'' );	
		SET @a1 = CONCAT(@a1, ' and `CommonTypeId` = \'' ,p_CommonType, '\'' );
	END IF;
	if p_Level is not null 
	then 
		SET @a = CONCAT(@a, ' and `ParentId` = \'',p_Level,'\'');
		SET @a1 = CONCAT(@a1, ' and `ParentId` = \'',p_Level,'\'');
	else 
		SET @a = CONCAT(@a, ' and `ParentId` IS NULL');
		SET @a1 = CONCAT(@a1, ' and `ParentId` IS NULL');
	end if;
	SET @a = CONCAT(@a,' LIMIT ',p_NoStart,', ',p_NoEnd);
	
	PREPARE stmt1 FROM @a;
	EXECUTE stmt1 ;
	
	PREPARE stmt2 FROM @a1;
	EXECUTE stmt2 ;
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spGetProducts` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spGetProducts`(
	p_ProductType	text,
	p_NoStart       INT(11),
	p_NoEnd         INT(11)
    )
BEGIN
	SET @a = 'SELECT * FROM `products` WHERE IsDelete = 0';
	SET @a1 = 'SELECT count(*) as `Total` FROM `products` where IsDelete = 0';
	
	IF p_ProductType IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' AND `ProductType` IN (',p_ProductType,')');
		SET @a1 = CONCAT(@a1, ' AND `ProductType` IN (',p_ProductType,')');
	END IF;
	
	SET @a = CONCAT(@a,' LIMIT ',p_NoStart,', ',p_NoEnd);
	
	PREPARE stmt1 FROM @a;
	EXECUTE stmt1 ;
	
	PREPARE stmt2 FROM @a1;
	EXECUTE stmt2 ;
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spGetProductsNotBuffet` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spGetProductsNotBuffet`(
	p_ProductType	TEXT,
	p_NoStart       INT(11),
	p_NoEnd         INT(11)
    )
BEGIN
	SET @a = 'SELECT * FROM `products` WHERE IsDelete = 0';
	SET @a1 = 'SELECT count(*) as `Total` FROM `products` where IsDelete = 0';
	
	IF p_ProductType IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' AND `ProductType` NOT IN (',p_ProductType,')');
		SET @a1 = CONCAT(@a1, ' AND `ProductType` NOT IN (',p_ProductType,')');
	END IF;
	
	SET @a = CONCAT(@a,' LIMIT ',p_NoStart,', ',p_NoEnd);
	
	PREPARE stmt1 FROM @a;
	EXECUTE stmt1 ;
	
	PREPARE stmt2 FROM @a1;
	EXECUTE stmt2 ;
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spGet_Desk_By_IsUsing` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spGet_Desk_By_IsUsing`(
	p_IsUsing int(11)
    )
BEGIN
	select *
	from `desk`
	where `IsUsing` = p_IsUsing;
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spGet_ReceiptDetail_Infomation_By_ReceiptId` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spGet_ReceiptDetail_Infomation_By_ReceiptId`(
    p_ReceiptId varchar(20)
    )
BEGIN
	select rd.`Qty`, rd.`Price`, rd.`TotalAmount`, rd.`CreatedDate`, pd.`Name`, pd.`Unit`
	from `receiptdetails` rd, `products` pd
	where rd.`ProductId` = pd.`ProductId` and `ReceiptId` = p_ReceiptId;
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spGet_ReceiptID` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spGet_ReceiptID`(
	p_ID 	 VARCHAR(20)
    )
BEGIN
	SELECT `ReceiptId` AS `Code` 
	FROM  `receipts`
	WHERE LEFT(`ReceiptId`,10)= p_ID
	ORDER BY `ReceiptId`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spGet_Receipt_Infomation_By_ReceiptId` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spGet_Receipt_Infomation_By_ReceiptId`(
    p_ReceiptId varchar(20)
    )
BEGIN
	select *
	from `receipts`
	where `ReceiptId` = p_ReceiptId;
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spGet_TotalAmount_ByProduct_Time` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spGet_TotalAmount_ByProduct_Time`(
	p_ListProduct VARCHAR(512),
	p_CreatedDateFrom	DATETIME,
	p_CreatedDateTo	DATETIME
	
    )
BEGIN
	
	SET @a = 'SELECT `Total`.`ProductId`,`Total`.`Name`, SUM(`Total`.`Qty`) AS TotalAmount ';
	set @a = concat(@a, 'FROM ( ');
	set @a = concat(@a, 'SELECT `receiptdetails`.`ProductId`,`receiptdetails`.`ReceiptId`,`products`.`Name`,`receiptdetails`.`TotalAmount`,`receiptdetails`.`CreatedDate`,`receiptdetails`.`Qty` ');
	SET @a = CONCAT(@a, 'FROM `products` INNER JOIN `receiptdetails` ON `products`.`ProductId` = `receiptdetails`.`ProductId` ');
	if p_ListProduct is not null
	then
		set @a = concat(@a, 'WHERE ');
		set @a = concat(@a, p_ListProduct);
	end if;
	/*`CreatedDate`*/
	IF p_CreatedDateFrom IS NOT NULL 
	THEN
		
		SET @a = CONCAT(@a, ' and Date(`receiptdetails`.`CreatedDate`) between ''' , p_CreatedDateFrom , ''' and ''' , p_CreatedDateTo , '''');
	END IF;
	SET @a = CONCAT(@a, ') AS `Total` WHERE TRUE ');
	/*`Name`*/
	/*
	IF p_ProductId IS NOT NULL 
	THEN
		SET @a = CONCAT(@a, 'AND `Total`.`ProductId` = ''' ,p_ProductId , ''' ');	
	END IF;
	*/
	SET @a = CONCAT(@a, 'GROUP BY `Total`.`ProductId`');
	
	PREPARE stmt1 FROM @a;
	EXECUTE stmt1 ;
	
	/*show cau SQL*/
	SELECT @a AS 'SQLString';
	
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spGet_TotalAmount_ByProduct_Time1` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spGet_TotalAmount_ByProduct_Time1`(
	p_ListProduct text,
	p_CreatedDateFrom	DATETIME,
	p_CreatedDateTo	DATETIME
	
    )
BEGIN
	
	SET @a = 'SELECT `Total`.`ProductId`,`Total`.`Name`, SUM(`Total`.`Qty`) AS TotalAmount ';
	SET @a = CONCAT(@a, 'FROM ( ');
	SET @a = CONCAT(@a, 'SELECT `receiptdetails`.`ProductId`,`receiptdetails`.`ReceiptId`,`products`.`Name`,`receiptdetails`.`TotalAmount`,`receiptdetails`.`CreatedDate`,`receiptdetails`.`Qty` ');
	SET @a = CONCAT(@a, 'FROM `products` INNER JOIN `receiptdetails` ON `products`.`ProductId` = `receiptdetails`.`ProductId` ');
	SET @a = CONCAT(@a, 'WHERE 1=1 ');
	IF p_ListProduct IS NOT NULL
	THEN
		SET @a = CONCAT(@a, 'AND ');
		SET @a = CONCAT(@a, ' `products`.`ProductId` IN (''',p_ListProduct,''')');
	END IF;
	/*`CreatedDate`*/
	IF p_CreatedDateFrom IS NOT NULL 
	THEN
		
		SET @a = CONCAT(@a, ' and Date(`receiptdetails`.`CreatedDate`) between ''' , p_CreatedDateFrom , ''' and ''' , p_CreatedDateTo , '''');
	END IF;
	SET @a = CONCAT(@a, ') AS `Total` WHERE TRUE ');
	/*`Name`*/
	/*
	IF p_ProductId IS NOT NULL 
	THEN
		SET @a = CONCAT(@a, 'AND `Total`.`ProductId` IN( ''' ,p_ProductId , ''') ');	
	END IF;
	*/
	SET @a = CONCAT(@a, 'GROUP BY `Total`.`ProductId`');
	
	PREPARE stmt1 FROM @a;
	EXECUTE stmt1 ;
	
	/*show cau SQL*/
	SELECT @a AS 'SQLString';
	
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spInsert_Desk` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spInsert_Desk`(
	desk_no   varchar(512),
	description_s varchar(512),
	status_s     varchar(20),
	desk_location  varchar(255),
	no_of_seat      int(11)
    )
BEGIN
	insert into `desk`(`DeskNo`,`Description`,`Status`,`DeskLocation`,`NoOfSeat`,`IsUsing`)
	values(desk_no,description_s,status_s,desk_location,no_of_seat, 0);
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spInsert_Objects` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spInsert_Objects`(
	object_id  	varchar(20),
	object_group 	varchar(20),
	object_type     varchar(20),
	fullname_s   	varchar(200),
	dob_s          	datetime,
	pob_s          	datetime,
	preAdd_s       	varchar(250),
	TemAdd_s      	varchar(250),
	gender_s       	bit(1),
	province_id    	varchar(20),
	tel_s          	varchar(150),
	fax_s            varchar(150),
	email            varchar(250),
	website_s        varchar(250),
	tax_code         varchar(20),
	note_s           text,
	status_s         varchar(20),
	create_by         varchar(20)
    )
BEGIN
	START TRANSACTION;
	INSERT INTO `objects`(`ObjectId`,`ObjectGroup`,`ObjectType`,`FullName`,`DoB`,`PoB`,`PerAdd`,`TemAdd`,`Gender`,`ProvinceId`,`Tel`,`Fax`,`Email`,`Website`,`TaxCode`,`Note`,`Status`,`CreatedBy`,`CreatedDate`)
	VALUES(object_id,object_group,object_type,fullname_s,member_type,dob_s,pob_s,preAdd_s,TemAdd_s,gender_s,province_id,tel_s,fax_s,website_s,tax_code,note_s,status_s,now(),create_by);
	COMMIT;
	ROLLBACK;
	
	SET @objectid = object_id;
	SELECT  @objectid AS objectid;
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spInsert_OrderDetail` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spInsert_OrderDetail`(
	order_id  varchar(20),
	product_id varchar(20),
	ProductName varchar(512),
	qty_s       int(11),
	price_s        decimal(20.0),
	create_by   varchar(256),
	status_s   varchar(20),
	ammount_before_tax  decimal(20.0),
	tax_ammount  decimal(20.0),
	total_ammount decimal(20.0),
	Note VARCHAR(250),
	IsBuffet VARCHAR(1)
    )
BEGIN
	INSERT INTO `orderdetails`(`OrderId`,`ProductId`,`ProductName`,`Qty`,`Price`,`CreatedDate`,`CreatedBy`,`IsPrint`,`Status`,`AmmountBeforeTax`,`TaxAmmount`,`TotalAmmount`,`Note`,`IsBuffet`)
	VALUES(order_id,product_id, ProductName, qty_s,price_s,NOW(),create_by,0,status_s,ammount_before_tax,tax_ammount,total_ammount,Note,IsBuffet);
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spInsert_Orders` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spInsert_Orders`(
	order_id 	 VARCHAR(20),
	desk_id 	 VARCHAR(20),
	note_s  	 VARCHAR(255),
	create_by     	VARCHAR(256),
	status_s     	VARCHAR(20),
	total_tax    	DECIMAL(20.0),
	total_ammount  	DECIMAL(20.0),
	total_ammount_before_tax   DECIMAL(20.0),
	dis_count_amount DECIMAL(20.0),
	tolal_Money  DECIMAL(20.0)
    )
BEGIN
	INSERT INTO `orders`(`OrderId`,`DeskId`,`Note`,`CreatedDate`,`CreatedBy`,`Status`,`TotalTax`,`TotalAmmount`,`TotalAmountBeforeTax`,`DisCountAmount`,`TotalMoney`)
	VALUES(order_id,desk_id,note_s,now(),create_by,status_s,total_tax,total_ammount,total_ammount_before_tax,dis_count_amount,tolal_Money);
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spInsert_Output` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spInsert_Output`(
	p_ReceiptId	VARCHAR(20),
	p_OutputId 	VARCHAR(20),
	p_CreatedBy	VARCHAR(20)
    )
BEGIN
	INSERT INTO `output`(
	`OutputId`,
	`Ballot`,
	`BallotDate`,
	`OutputReason`,
	`StoreId`,
	`OutputType`,
	`ReceiptId`,
	`OutputNote`,
	`CreatedBy`,
	`CreatedDate`
	)
	VALUES(
		p_OutputId,
		null,
		null,
		null,
		null,
		'0',
		p_ReceiptId,
		null,
		IFNULL(p_CreatedBy,'admin'),
		NOW()	
	);
	
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spInsert_Output_Detail` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spInsert_Output_Detail`(
	p_OutputId	varchar(20),
	p_IngredientId	VARCHAR(20),
	p_IngredientQty decimal(20,0)
    )
BEGIN
	INSERT INTO `outputdetail`(
	`OutputId`,
	`IngredientId`,
	`IngredientQty`,
	`IngredientPrice`,
	`IngredientVat`,
	`CreatedDate`
	)
	VALUES(
		p_OutputId,
		p_IngredientId,
		p_IngredientQty,
		null,
		null,
		now()
	);
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spInsert_Products` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spInsert_Products`(
	product_id  varchar(20),
	name_s      varchar(512),
	unit_s      varchar(128),
	image_s     text,
	notes_s     text,
	create_by   varchar(255),
	product_type varchar(50)
    )
BEGIN
	insert into `products`(`ProductId`,`Name`,`Unit`,`Image`,`IsPrint`,`Notes`,`CreatedDate`,`IsDelete`,`CreatedBy`,`ProductType`)
	values(product_id,name_s,unit_s,image_s,0,notes_s,now(),0,create_by,product_type);
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spInsert_Receipt` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spInsert_Receipt`(
	p_ReceiptId 	 VARCHAR(20),
	p_Note 	 VARCHAR(255),
	p_NoOfCustumers  	 int(11),
	p_Status     	VARCHAR(20),
	p_TotalAmountBeforeTax     	decimal(20,2),
	p_ServiceCostAmount     	DECIMAL(20,2),
	p_TotalTax    	DECIMAL(20,0),
	p_TotalAmount  	DECIMAL(20,0),
	p_DiscountAmount   DECIMAL(20,0),
	p_TotalMoney DECIMAL(20,0),
	p_CashPayAmt  DECIMAL(20,0),
	p_CardPayAmt  DECIMAL(20,0),
	p_ReturnAmt  DECIMAL(20,0),
	p_CreatedBy 	 VARCHAR(256)	
    )
BEGIN
	INSERT INTO `receipts`(
	`ReceiptId`,
	`Note`,
	`NoOfCustumers`,
	`Status`,
	`TotalAmountBeforeTax`,
	`ServiceCostAmount`,
	`TotalTax`,
	`TotalAmount`,
	`DiscountAmount`,
	`TotalMoney`,
	`CashPayAmt`,
	`CardPayAmt`,
	`ReturnAmt`,
	`CreatedBy`,
	`CreatedDate`
	)
	VALUES(
		p_ReceiptId 	,
		p_Note 	,
		IFNULL(p_NoOfCustumers,'1'),
		IFNULL(p_Status,'1'),
		IFNULL(p_TotalAmountBeforeTax,'0'),
		IFNULL(p_ServiceCostAmount,'0'),
		IFNULL(p_TotalTax,'0'),
		IFNULL(p_TotalAmount,'0'),
		IFNULL(p_DiscountAmount,'0'),
		IFNULL(p_TotalMoney,'0'),
		IFNULL(p_CashPayAmt,'0'),
		IFNULL(p_CardPayAmt,'0'),
		IFNULL(p_ReturnAmt,'0'),
		IFNULL(p_CreatedBy,'admin'),
		NOW()	
	);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spInsert_ReceiptCard` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spInsert_ReceiptCard`(
	p_ReceiptId 	 VARCHAR(20),
	p_CardNo 	 VARCHAR(150),
	p_CardHolderName	 VARCHAR(200),
	p_ExpiredDate     	VARCHAR(50),
	p_CardType	 VARCHAR(20),
	p_Bank	 VARCHAR(20),
	p_TotalAmount  	DECIMAL(20,2),
	
	p_TerminalId	 VARCHAR(100),
	p_MerchantId 	 VARCHAR(100),
	p_TransType 	 VARCHAR(100),
	p_BatchNo	 VARCHAR(50),
	p_TraceNo 	 VARCHAR(20),
	p_RefNo	 VARCHAR(50),
	p_AppCode	 VARCHAR(50),
	p_CreatedBy 	 VARCHAR(20)	
    )
BEGIN
	INSERT INTO `receiptscard`(
	`ReceiptId`,
	`CardNo`,
	`CardHolderName`,
	`ExpiredDate`,
	`CardType`,
	`Bank`,
	`TotalAmount`,
	
	`TerminalId`,
	`MerchantId`,
	`TransType`,
	`BatchNo`,
	`TraceNo`,
	`RefNo`,
	`AppCode`,
	`CreatedBy`,
	`CreatedDate`
	)
	VALUES(
		p_ReceiptId 	,
		IFNULL(p_CardNo,''),
		IFNULL(p_CardHolderName,''),
		IFNULL(p_ExpiredDate,''),
		IFNULL(p_CardType,''),
		IFNULL(p_Bank,''),
		IFNULL(p_TotalAmount,'0'),
		
		IFNULL(p_TerminalId,''),
		IFNULL(p_MerchantId,''),
		IFNULL(p_TransType,''),
		IFNULL(p_BatchNo,''),
		IFNULL(p_TraceNo,''),
		IFNULL(p_RefNo,''),
		IFNULL(p_AppCode,''),
		IFNULL(p_CreatedBy,'admin'),
		NOW()	
	);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spInsert_ReceiptDetail` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spInsert_ReceiptDetail`(
	p_ReceiptId 	 VARCHAR(20),
	p_ProductId 	 VARCHAR(20),
	p_PromotionId  	 VARCHAR(20),
	p_Qty     	int(11),
	p_Price  DECIMAL(20,2),	
	p_TotalAmountBeforeTax     	decimal(20,2),
	p_TaxAmount    	DECIMAL(20,2),
	p_TotalAmount  	DECIMAL(20,2),
	p_Status  	 VARCHAR(20),
	p_RefOrderId  	 VARCHAR(20),	
	p_CreatedBy 	 VARCHAR(20)	
    )
BEGIN
	INSERT INTO `receiptdetails`(
	`ReceiptId`,
	`ProductId`,
	`PromotionId`,
	`Qty`,
	`Price`,
	`TotalAmountBeforeTax`,
	`TaxAmount`,
	`TotalAmount`,	
	`Status`,
	`RefOrderId`,	
	`CreatedBy`,
	`CreatedDate`
	)
	VALUES(
		p_ReceiptId,
		p_ProductId,
		p_PromotionId,
		IFNULL(p_Qty,'0'),
		IFNULL(p_Price,'0'),
		IFNULL(p_TotalAmountBeforeTax ,'0'),
		IFNULL(p_TaxAmount,'0'),
		IFNULL(p_TotalAmount,'0'),
		IFNULL(p_Status,'1'),
		p_RefOrderId,	
		IFNULL(p_CreatedBy,'admin'),
		NOW()	
	);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spInsert_ReceiptInfo` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spInsert_ReceiptInfo`(
	p_ReceiptId 	 VARCHAR(20),
	p_CustomerName 	 VARCHAR(255),
	p_Address	 VARCHAR(255),
	p_Phone    	VARCHAR(50),
	p_Note	 TEXT
    )
BEGIN
	INSERT INTO `receiptinfo`(
	`ReceiptId`,
	`CustomerName`,
	`Address`,
	`Phone`,
	`Note`
	)
	VALUES(
		p_ReceiptId,
		p_CustomerName,
		p_Address,
		p_Phone,
		p_Note	
	);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spInsert_ReceiptMember` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spInsert_ReceiptMember`(
	p_ReceiptId 	 VARCHAR(20),
	p_MemberId    	VARCHAR(50),
	p_Score bigint(20),
	p_CreatedBy	 VARCHAR(20)
    )
BEGIN
	INSERT INTO `receiptmember`(
	`ReceiptId`,`MemberId`, `Score`,`CreatedDate`,`CreatedBy`
	)
	VALUES(
		p_ReceiptId,
		p_MemberId,
		ifnull(p_Score, 0),		
		NOW(),
		p_CreatedBy	
	);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spInsert_UserActionHistory` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spInsert_UserActionHistory`(	
	uid varchar(20),
	obj varchar(250),
	verb VArchar(1000),
	prm varchar(1000),
	val varchar(1000)
    )
BEGIN
	INSERT into `useractionhistory`(`Time`,`UserId`,`Object`,`Verb`,`Param`,`Value`)
	values(Now(),uid,obj,verb,prm,val);
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spSearchInputL` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spSearchInputL`(
	p_InputId 	VARCHAR(20)  ,
	p_Ballot 		 VARCHAR(10),
	p_BallotDate    	VARCHAR(50),
	p_ReceiptId	VARCHAR(20),
	p_ReceiptDate	VARCHAR(50),
	p_SupplierId	varchar(20),
	p_Paid		varchar(1),
	p_InputDiscount	varchar(5),
	p_inputNote	varchar(255),
	p_inputVAT 	varchar(11),
	
	p_NoStart       INT(11),
	p_NoEnd          INT(11) 
	)
BEGIN
	
	SET @a = 'SELECT * FROM `input` where 1=1 ';
	SET @a1 = 'SELECT count(*) as `Total` FROM `input` where 1=1 ';
	/*`p_InputId`*/
	IF p_InputId IS NOT NULL 
	THEN
		SET @a = CONCAT(@a, ' and `InputId` like ''%' ,p_InputId , '%'' ');	
		SET @a1 = CONCAT(@a1, ' and `InputId` like ''%' ,p_InputId , '%'' ');
	END IF;
	
	/*`Name`*/
	IF p_Ballot IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and `Ballot` like ''%' ,p_Ballot , '%'' ');	
		SET @a1 = CONCAT(@a1, ' and `Ballot` like ''%' ,p_Ballot , '%'' ');	
	END IF;
	
	
	
	
	
	/*ProductType*/
	IF p_BallotDate IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and `BallotDate` = ''', p_BallotDate , ''' ');
		SET @a1 = CONCAT(@a1, ' and `BallotDate` = ''', p_BallotDate , ''' ');
	END IF;
	
	IF p_ReceiptId IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and `ReceiptId` like ''%', p_ReceiptId , '%'' ');
		SET @a1 = CONCAT(@a1, ' and `ReceiptId` like ''%', p_ReceiptId ,  '%'' ');
	END IF;
	
	IF p_ReceiptDate IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and `ReceiptDate` like ''', p_ReceiptDate , '%'' ');
		SET @a1 = CONCAT(@a1, ' and `ReceiptDate` like ''', p_ReceiptDate , '%'' ');
	END IF;	
	
	IF p_SupplierId IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and `SupplierId` like ''%', p_SupplierId , '%'' ');
		SET @a1 = CONCAT(@a1, ' and `SupplierId` like ''%', p_SupplierId ,  '%'' ');
	END IF;
	
	IF p_Paid IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and `Paid` = ''', p_Paid , ''' ');
		SET @a1 = CONCAT(@a1, ' and `Paid` = ''', p_Paid ,  ''' ');
	END IF;
	
	IF p_InputDiscount IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and `InputDiscount` like ''%', p_InputDiscount , '%'' ');
		SET @a1 = CONCAT(@a1, ' and `InputDiscount` like ''%', p_InputDiscount ,  '%'' ');
	END IF;
	
	IF p_inputNote IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and `InputNote` like ''%', p_inputNote , '%'' ');
		SET @a1 = CONCAT(@a1, ' and `InputNote` like ''%', p_inputNote ,  '%'' ');
	END IF;
	
	IF p_inputVAT IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and `InputVAT` like ''%', p_inputVAT , '%'' ');
		SET @a1 = CONCAT(@a1, ' and `InputVAT` like ''%', p_inputVAT ,  '%'' ');
	END IF;
	
	SET @a = CONCAT(@a,' LIMIT ',p_NoStart,', ',p_NoEnd);
	
	
		
	PREPARE stmt1 FROM @a;
	EXECUTE stmt1 ;
	
	PREPARE stmt2 FROM @a1;
	EXECUTE stmt2 ;
	/*select @a as bien;*/
	SELECT @a AS 'SQLString';
	-- SELECT p_DoB AS 'DoB';
	
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spSearchMeasureL` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spSearchMeasureL`(
	p_ProductId 	VARCHAR(20)  ,
	p_MeasureId     VARCHAR(20),
	p_Note          VARCHAR(255),
	p_NoStart       INT(11),
	p_NoEnd          INT(11) 
	)
BEGIN
	
	SET @a = 'SELECT m.*, p.`Name` FROM measure AS m LEFT JOIN products AS p ON m.`ProductId` = p.`ProductId` where 1=1 ';
	SET @a1 = 'SELECT count(*) as `Total` FROM measure AS m LEFT JOIN products AS p ON m.`ProductId` = p.`ProductId` where 1=1 ';
	/*`ProductId`*/
	IF p_ProductId IS NOT NULL 
	THEN
		SET @a = CONCAT(@a, ' and m.`ProductId` like ''%' ,p_ProductId , '%'' ');	
		SET @a1 = CONCAT(@a1, ' and m.`ProductId` like ''%' ,p_ProductId , '%'' ');
	END IF;
	
	
	/*`Name`*/
	IF p_MeasureId IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and m.`MeasureId` like ''%' ,p_MeasureId , '%'' ');	
		SET @a1 = CONCAT(@a1, ' and m.`MeasureId` like ''%' ,p_MeasureId , '%'' ');	
	END IF;
	
	IF p_Note IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and m.`MeasureNote` like ''%' ,p_Note , '%'' ');	
		SET @a1 = CONCAT(@a1, ' and m.`MeasureNote` like ''%' ,p_Note , '%'' ');	
	END IF;
	
	SET @a = CONCAT(@a,' LIMIT ',p_NoStart,', ',p_NoEnd);
	
	
		
	PREPARE stmt1 FROM @a;
	EXECUTE stmt1 ;
	
	PREPARE stmt2 FROM @a1;
	EXECUTE stmt2 ;
	/*select @a as bien;*/
	SELECT @a AS 'SQLString';
	-- SELECT p_DoB AS 'DoB';
	
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spSearchProductGroupL` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spSearchProductGroupL`(
	p_ProductGroupId 	VARCHAR(20)  ,
	p_Name 		 VARCHAR(512),
	
	p_NoStart       INT(11),
	p_NoEnd          INT(11) 
	)
BEGIN
	
	SET @a = 'SELECT * FROM `productgroup` where 1=1 ';
	SET @a1 = 'SELECT count(*) as `Total` FROM `productgroup` where 1=1 ';
	/*`ProductId`*/
	IF p_ProductGroupId IS NOT NULL 
	THEN
		SET @a = CONCAT(@a, ' and `ProductGroupId` like ''%' ,p_ProductGroupId , '%'' ');	
		SET @a1 = CONCAT(@a1, ' and `ProductGroupId` like ''%' ,p_ProductGroupId , '%'' ');
	END IF;
	
	/*`Name`*/
	IF p_Name IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and `ProductGroupName` like ''%' ,p_Name , '%'' ');	
		SET @a1 = CONCAT(@a1, ' and `ProductGroupName` like ''%' ,p_Name , '%'' ');	
	END IF;
	
	
	
	
	SET @a = CONCAT(@a,' LIMIT ',p_NoStart,', ',p_NoEnd);
	
	
		
	PREPARE stmt1 FROM @a;
	EXECUTE stmt1 ;
	
	PREPARE stmt2 FROM @a1;
	EXECUTE stmt2 ;
	/*select @a as bien;*/
	SELECT @a AS 'SQLString';
	-- SELECT p_DoB AS 'DoB';
	
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spSearchProductL` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spSearchProductL`(
	p_ProductId 	VARCHAR(20)  ,
	p_Name 		 VARCHAR(512),
	p_ProductType     	VARCHAR(50),
	
	p_NoStart       INT(11),
	p_NoEnd          INT(11) 
	)
BEGIN
	
	SET @a = 'SELECT * FROM `product` where 1=1 ';
	SET @a1 = 'SELECT count(*) as `Total` FROM `product` where 1=1 ';
	/*`ProductId`*/
	IF p_ProductId IS NOT NULL 
	THEN
		SET @a = CONCAT(@a, ' and `ProductId` like ''%' ,p_ProductId , '%'' ');	
		SET @a1 = CONCAT(@a1, ' and `ProductId` like ''%' ,p_ProductId , '%'' ');
	END IF;
	
	/*`Name`*/
	IF p_Name IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and `ProductName` like ''%' ,p_Name , '%'' ');	
		SET @a1 = CONCAT(@a1, ' and `ProductName` like ''%' ,p_Name , '%'' ');	
	END IF;
	
	
	
	
	
	/*ProductType*/
	IF p_ProductType IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and `ProductGroupId` like ''%', p_ProductType , '%'' ');
		SET @a1 = CONCAT(@a1, ' and `ProductGroupId` like ''%', p_ProductType , '%'' ');
	END IF;
	
	
	
	SET @a = CONCAT(@a,' LIMIT ',p_NoStart,', ',p_NoEnd);
	
	
		
	PREPARE stmt1 FROM @a;
	EXECUTE stmt1 ;
	
	PREPARE stmt2 FROM @a1;
	EXECUTE stmt2 ;
	/*select @a as bien;*/
	SELECT @a AS 'SQLString';
	-- SELECT p_DoB AS 'DoB';
	
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spSearch_CommonCode` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spSearch_CommonCode`(
	p_CommonTypeId 	VARCHAR(20),
	p_CommonId  	VARCHAR(20),
	p_ParentId  	VARCHAR(255),
	p_IsBuffet  	varchar(1),
	
	p_StrValue1   	VARCHAR(255),
	p_StrValue2   	VARCHAR(255),
	p_NumValue1   	DECIMAL(20,0),
	p_NumValue2   	DECIMAL(20,0),
	
	p_CreatedBy  	VARCHAR(20),
	p_CreatedDate	DATETIME,
	p_ModifiedBy	VARCHAR(20),
	p_ModifiedDate	DATETIME, 
	
	p_NoStart       INT(11),
	p_NoEnd          INT(11) 
	)
BEGIN
	
	SET @a = 'SELECT * FROM `commoncode` where 1=1 ';
	SET @a1 = 'SELECT count(*) as `Total` FROM `commoncode` where 1=1 ';
	
	/*`CommonTypeId`*/
	IF p_CommonTypeId IS NOT NULL 
	THEN
		SET @a = CONCAT(@a, ' and `CommonTypeId` like ''%' ,p_CommonTypeId , '%'' ');	
		SET @a1 = CONCAT(@a1, ' and `CommonTypeId` like ''%' ,p_CommonTypeId , '%'' ');
	END IF;
	
	/*`CommonId`*/
	IF p_CommonId IS NOT NULL 
	THEN
		SET @a = CONCAT(@a, ' and `CommonId` like ''%' ,p_CommonId , '%'' ');	
		SET @a1 = CONCAT(@a1, ' and `CommonId` like ''%' ,p_CommonId , '%'' ');
	END IF;
	
	/*`ParentId`*/
	IF p_ParentId IS NOT NULL 
	THEN
		SET @a = CONCAT(@a, ' and `ParentId` like ''%' ,p_ParentId , '%'' ');	
		SET @a1 = CONCAT(@a1, ' and `ParentId` like ''%' ,p_ParentId , '%'' ');
	END IF;
	
	/*`IsBuffet`*/
	IF p_IsBuffet IS NOT NULL 
	THEN
		SET @a = CONCAT(@a, ' and `IsBuffet` = ''' ,p_IsBuffet , ''' ');	
		SET @a1 = CONCAT(@a1, ' and `IsBuffet` = ''' ,p_IsBuffet , ''' ');
	END IF;
	/*`StrValue1`*/
	IF p_StrValue1 IS NOT NULL 
	THEN
		SET @a = CONCAT(@a, ' and `StrValue1` like ''%' ,p_StrValue1 , '%'' ');	
		SET @a1 = CONCAT(@a1, ' and `StrValue1` like ''%' ,p_StrValue1 , '%'' ');
	END IF;
	
	/*`StrValue2`*/
	IF p_StrValue2 IS NOT NULL 
	THEN
		SET @a = CONCAT(@a, ' and `StrValue2` like ''%' ,p_StrValue2 , '%'' ');	
		SET @a1 = CONCAT(@a1, ' and `StrValue2` like ''%' ,p_StrValue2 , '%'' ');
	END IF;
	
	/*`NumValue1`*/
	IF p_NumValue1 IS NOT NULL 
	THEN
		SET @a = CONCAT(@a, ' and `NumValue1` like ''%' ,p_NumValue1 , '%'' ');	
		SET @a1 = CONCAT(@a1, ' and `NumValue1` like ''%' ,p_NumValue1 , '%'' ');
	END IF;
	
	/*`NumValue2`*/
	IF p_NumValue2 IS NOT NULL 
	THEN
		SET @a = CONCAT(@a, ' and `NumValue2` like ''%' ,p_NumValue2 , '%'' ');	
		SET @a1 = CONCAT(@a1, ' and `NumValue2` like ''%' ,p_NumValue2 , '%'' ');
	END IF;
		
	/*CreatedBy*/
	IF p_CreatedBy IS NOT NULL
	THEN
		SET @a= CONCAT(@a, ' and `CreatedBy` like ''%', p_CreatedBy, '%'' ');
		SET @a1= CONCAT(@a1, ' and `CreatedBy` like ''%', p_CreatedBy, '%'' ');
	END IF;
	
	/*CreatedDate*/
	IF p_CreatedDate IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and DAY(`CreatedDate`) = ''' , DAY(p_CreatedDate) , ''' ');	
		SET @a = CONCAT(@a, ' and MONTH(`CreatedDate`) = ''' , MONTH(p_CreatedDate) , ''' ');	
		SET @a = CONCAT(@a, ' and YEAR(`CreatedDate`) = ''' , YEAR(p_CreatedDate) , ''' ');	
		
		SET @a1 = CONCAT(@a1, ' and DAY(`CreatedDate`) = ''' , DAY(p_CreatedDate) , ''' ');	
		SET @a1 = CONCAT(@a1, ' and MONTH(`CreatedDate`) = ''' , MONTH(p_CreatedDate) , ''' ');	
		SET @a1= CONCAT(@a1, ' and YEAR(`CreatedDate`) = ''' , YEAR(p_CreatedDate) , ''' ');	
	END IF;
	
	/*ModifitedBy*/
	IF p_ModifiedBy IS NOT NULL
	THEN
		SET @a= CONCAT(@a, ' and `ModifiedBy` like ''%', p_ModifiedBy, '%'' ');
		SET @a1= CONCAT(@a1, ' and `ModifiedBy` like ''%', p_ModifiedBy, '%'' ');
	END IF;
	
	/*ModifiedDate*/
	IF p_ModifiedDate IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and DAY(`ModifiedDate`) = ''' , DAY(p_ModifiedDate) , ''' ');	
		SET @a = CONCAT(@a, ' and MONTH(`ModifiedDate`) = ''' , MONTH(p_ModifiedDate) , ''' ');	
		SET @a = CONCAT(@a, ' and YEAR(`ModifiedDate`) = ''' , YEAR(p_ModifiedDate) , ''' ');	
		
		SET @a1 = CONCAT(@a1, ' and DAY(`ModifiedDate`) = ''' , DAY(p_ModifiedDate) , ''' ');	
		SET @a1 = CONCAT(@a1, ' and MONTH(`ModifiedDate`) = ''' , MONTH(p_ModifiedDate) , ''' ');	
		SET @a1 = CONCAT(@a1, ' and YEAR(`ModifiedDate`) = ''' , YEAR(p_ModifiedDate) , ''' ');	
	END IF;
	
	
	SET @a = CONCAT(@a,' LIMIT ',p_NoStart,', ',p_NoEnd);
	
	
		
	PREPARE stmt1 FROM @a;
	EXECUTE stmt1 ;
	
	PREPARE stmt2 FROM @a1;
	EXECUTE stmt2 ;
	/*select @a as bien;*/
	SELECT @a AS 'SQLString';
	
	
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spSearch_CommonType` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spSearch_CommonType`(
	p_CommonTypeId 	varchar(20)  ,
	p_Description  	varchar(255),
	
	p_Note   	varchar(255),
	p_CreatedBy  	varchar(20),
	p_CreatedDate	datetime,
	p_ModifiedBy	varchar(20),
	p_ModifiedDate	datetime, 
	
	p_NoStart       INT(11),
	p_NoEnd          INT(11) 
	)
BEGIN
	
	SET @a = 'SELECT * FROM `commontype` where 1=1 ';
	SET @a1 = 'SELECT count(*) as `Total` FROM `commontype` where 1=1 ';
	
	/*`CommonTypeId`*/
	if p_CommonTypeId is not null 
	then
		SET @a = concat(@a, ' and `CommonTypeId` like ''%' ,p_CommonTypeId , '%'' ');	
		SET @a1 = CONCAT(@a1, ' and `CommonTypeId` like ''%' ,p_CommonTypeId , '%'' ');
	end if;
	
	/*`Description`*/
	IF p_Description IS NOT NULL 
	THEN
		SET @a = CONCAT(@a, ' and `Description` like ''%' ,p_Description , '%'' ');	
		SET @a1 = CONCAT(@a1, ' and `Description` like ''%' ,p_Description , '%'' ');
	END IF;
	
	/*`Note`*/
	IF p_Note IS NOT NULL 
	THEN
		SET @a = CONCAT(@a, ' and `Note` like ''%' ,p_Note , '%'' ');	
		SET @a1 = CONCAT(@a1, ' and `Note` like ''%' ,p_Note , '%'' ');
	END IF;
		
	/*CreatedBy*/
	IF p_CreatedBy IS NOT NULL
	THEN
		SET @a= CONCAT(@a, ' and `CreatedBy` like ''%', p_CreatedBy, '%'' ');
		SET @a1= CONCAT(@a1, ' and `CreatedBy` like ''%', p_CreatedBy, '%'' ');
	END IF;
	
	/*CreatedDate*/
	IF p_CreatedDate IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and DAY(`CreatedDate`) = ''' , DAY(p_CreatedDate) , ''' ');	
		SET @a = CONCAT(@a, ' and MONTH(`CreatedDate`) = ''' , MONTH(p_CreatedDate) , ''' ');	
		SET @a = CONCAT(@a, ' and YEAR(`CreatedDate`) = ''' , YEAR(p_CreatedDate) , ''' ');	
		
		SET @a1 = CONCAT(@a1, ' and DAY(`CreatedDate`) = ''' , DAY(p_CreatedDate) , ''' ');	
		SET @a1 = CONCAT(@a1, ' and MONTH(`CreatedDate`) = ''' , MONTH(p_CreatedDate) , ''' ');	
		SET @a1= CONCAT(@a1, ' and YEAR(`CreatedDate`) = ''' , YEAR(p_CreatedDate) , ''' ');	
	END IF;
	
	/*ModifitedBy*/
	IF p_ModifiedBy IS NOT NULL
	THEN
		SET @a= CONCAT(@a, ' and `ModifiedBy` like ''%', p_ModifiedBy, '%'' ');
		SET @a1= CONCAT(@a1, ' and `ModifiedBy` like ''%', p_ModifiedBy, '%'' ');
	END IF;
	
	/*ModifiedDate*/
	IF p_ModifiedDate IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and DAY(`ModifiedDate`) = ''' , DAY(p_ModifiedDate) , ''' ');	
		SET @a = CONCAT(@a, ' and MONTH(`ModifiedDate`) = ''' , MONTH(p_ModifiedDate) , ''' ');	
		SET @a = CONCAT(@a, ' and YEAR(`ModifiedDate`) = ''' , YEAR(p_ModifiedDate) , ''' ');	
		
		SET @a1 = CONCAT(@a1, ' and DAY(`ModifiedDate`) = ''' , DAY(p_ModifiedDate) , ''' ');	
		SET @a1 = CONCAT(@a1, ' and MONTH(`ModifiedDate`) = ''' , MONTH(p_ModifiedDate) , ''' ');	
		SET @a1 = CONCAT(@a1, ' and YEAR(`ModifiedDate`) = ''' , YEAR(p_ModifiedDate) , ''' ');	
	END IF;
	
	
	SET @a = concat(@a,' LIMIT ',p_NoStart,', ',p_NoEnd);
	
	
		
	PREPARE stmt1 FROM @a;
	EXECUTE stmt1 ;
	
	PREPARE stmt2 FROM @a1;
	EXECUTE stmt2 ;
	/*select @a as bien;*/
	select @a as 'SQLString';
	
	
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spSearch_Desk` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spSearch_Desk`(
	p_DeskNo varchar(10)  ,
	p_Description  varchar(512),
	p_Status   varchar(20),
	p_DeskLocation  varchar(255),
	p_NoOfSeat       int(11),
	p_NoStart       int(11),
	p_NoEnd          int(11)  
	)
BEGIN
	
	SET @a = 'SELECT * FROM `desk` where 1=1 ';
	if p_DeskNo is not null 
	then
	SET @a = concat(@a, ' and `DeskNo` like ''%' ,p_DeskNo , '%'' ');	
	end if;
	
	IF p_Description IS NOT NULL
	THEN
	SET @a = CONCAT(@a, ' and `Description` like ''%' ,p_Description , '%'' ');	
	END IF;
	
	IF p_Status IS NOT NULL
	THEN
	SET @a = CONCAT(@a, ' and `Status` like ''%' ,p_Status , '%'' ');	
	END IF;
	
	IF p_DeskLocation IS NOT NULL
	THEN
	SET @a = CONCAT(@a, ' and `DeskLocation` like ''%' ,p_DeskLocation , '%'' ');	
	END IF;
	
	IF p_NoOfSeat <> '0'
	THEN
	SET @a = CONCAT(@a, ' and `NoOfSeat` =' ,p_NoOfSeat);	
	END IF;
	
	SET @a = concat(@a,' LIMIT ',p_NoStart,', ',p_NoEnd);
	PREPARE stmt1 FROM @a;
	EXECUTE stmt1 ;
	/*select @a as bien;*/
	
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spSearch_Desk_Count` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spSearch_Desk_Count`(
	p_DeskNo VARCHAR(10)  ,
	p_Description  VARCHAR(512),
	p_Status   VARCHAR(20),
	p_DeskLocation  VARCHAR(255),
	p_NoOfSeat       INT(11)
	
    )
BEGIN
	SET @a = 'SELECT * FROM `desk` where 1=1 ';
	IF p_DeskNo IS NOT NULL 
	THEN
	SET @a = CONCAT(@a, ' and `DeskNo` like ''%' ,p_DeskNo , '%'' ');	
	END IF;
	
	IF p_Description IS NOT NULL
	THEN
	SET @a = CONCAT(@a, ' and `Description` like ''%' ,p_Description , '%'' ');	
	END IF;
	
	IF p_Status IS NOT NULL
	THEN
	SET @a = CONCAT(@a, ' and `Status` like ''%' ,p_Status , '%'' ');	
	END IF;
	
	IF p_DeskLocation IS NOT NULL
	THEN
	SET @a = CONCAT(@a, ' and `DeskLocation` like ''%' ,p_DeskLocation , '%'' ');	
	END IF;
	
	IF p_NoOfSeat <> '0'
	THEN
	SET @a = CONCAT(@a, ' and `NoOfSeat` =' ,p_NoOfSeat);	
	END IF;
		
	PREPARE stmt1 FROM @a;
	EXECUTE stmt1 ;
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spSearch_Ingredients` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spSearch_Ingredients`(
	p_IngredientId 	VARCHAR(20)  ,
	p_IngredientName 		 VARCHAR(255),
	p_IngredientMeasure     	Int(11),
	p_IngredientExchange	decimal(20),
	p_IngredientUnit	varchar(100),
	p_NoStart       INT(11),
	p_NoEnd          INT(11) 
	)
BEGIN
	
	SET @a = 'SELECT * FROM `ingredient` where 1=1 ';
	SET @a1 = 'SELECT count(*) as `Total` FROM `ingredient` where 1=1 ';
	/*`ProductId`*/
	IF p_IngredientId IS NOT NULL 
	THEN
		SET @a = CONCAT(@a, ' and `IngredientId` like ''%' ,p_IngredientId , '%'' ');	
		SET @a1 = CONCAT(@a1, ' and `IngredientId` like ''%' ,p_IngredientId , '%'' ');
	END IF;
	
	/*`Name`*/
	IF p_IngredientName IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and `IngredientName` like ''%' ,p_IngredientName , '%'' ');	
		SET @a1 = CONCAT(@a1, ' and `IngredientName` like ''%' ,p_IngredientName , '%'' ');	
	END IF;
	/*ProductType*/
	IF p_IngredientMeasure IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and `IngredientMeasure` = ''', p_IngredientMeasure , ''' ');
		SET @a1 = CONCAT(@a1, ' and `IngredientMeasure` = ''', p_IngredientMeasure , ''' ');
	END IF;
	IF p_IngredientExchange IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and `IngredientExchange` = ''', p_IngredientExchange , ''' ');
		SET @a1 = CONCAT(@a1, ' and `IngredientExchange` = ''', p_IngredientExchange , ''' ');
	END IF;
	IF p_IngredientUnit IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and `IngredientUnit` like ''%' ,p_IngredientUnit , '%'' ');	
		SET @a1 = CONCAT(@a1, ' and `IngredientUnit` like ''%' ,p_IngredientUnit , '%'' ');	
	END IF;
	
	SET @a = CONCAT(@a,' LIMIT ',p_NoStart,', ',p_NoEnd);
	
	
		
	PREPARE stmt1 FROM @a;
	EXECUTE stmt1 ;
	
	PREPARE stmt2 FROM @a1;
	EXECUTE stmt2 ;
	/*select @a as bien;*/
	SELECT @a AS 'SQLString';
	-- SELECT p_DoB AS 'DoB';
	
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spSearch_Objects` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spSearch_Objects`(
	p_ObjectId varchar(20)  ,
	p_ObjectGroup  varchar(20),
	p_ObjectType   varchar(20),
	p_FullName  varchar(200),
	p_PID       VARCHAR(40),
	p_PIDDate      datetime,
	p_PIDIssue          VARCHAR(150), 
	p_DoB		DATETIME,
	p_PoB	varchar(250),
	p_PerAdd	VARCHAR(250),
	p_TemAdd	VARCHAR(250),
	p_Gender	varchar(1),
	
	p_ProvinceId	VARCHAR(20),
	p_Tel	VARCHAR(150),
	p_Fax	VARCHAR(150),
	p_Email		VARCHAR(250),
	p_Website	VARCHAR(250),
	p_TaxCode	VARCHAR(60),
	p_Note		text,
	p_Status	VARCHAR(20),	
	p_CreatedBy	VARCHAR(20),
	p_CreatedDate	datetime,
	p_ModifiedBy	VARCHAR(20),
	p_ModifiedDate		datetime,
	p_NoStart       INT(11),
	p_NoEnd          INT(11) 
	)
BEGIN
	
	SET @a = 'SELECT * FROM `objects` where 1=1 and `Status` != 5';
	SET @a1 = 'SELECT count(*) as `Total` FROM `objects` where 1=1 and `Status` != 5';
	/*`ObjectId`*/
	if p_ObjectId is not null 
	then
		SET @a = concat(@a, ' and `ObjectId`like ''%' ,p_ObjectId , '%'' ');	
		SET @a1 = CONCAT(@a1, ' and `ObjectId`like ''%' ,p_ObjectId , '%'' ');
	end if;
	
	/*`ObjectGroup`*/
	IF p_ObjectGroup IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and `ObjectGroup` = ''' ,p_ObjectGroup , ''' ');	
		SET @a1 = CONCAT(@a1, ' and `ObjectGroup` = ''' ,p_ObjectGroup , ''' ');	
	END IF;
	
	/*`ObjectType`*/
	IF p_ObjectType IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and `ObjectType` = ''' ,p_ObjectType , ''' ');	
		SET @a1 = CONCAT(@a1, ' and `ObjectType` = ''' ,p_ObjectType , ''' ');	
	END IF;
	
	IF p_FullName IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and `FullName` like ''%' ,p_FullName , '%'' ');	
		SET @a1 = CONCAT(@a1, ' and `FullName` like ''%' ,p_FullName , '%'' ');	
	END IF;
	
	/*`PID`*/
	IF p_PID IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and `PID` = ''' ,p_PID , ''' ');	
		SET @a1 = CONCAT(@a1, ' and `PID` = ''' ,p_PID , ''' ');
	END IF;
	
	/*`PIDDate`*/
	IF p_PIDDate IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and DAY(`PIDDate`) = ''' , DaY(p_PIDDate) , ''' ');	
		SET @a = CONCAT(@a, ' and MONTH(`PIDDate`) = ''' , MONTH(p_PIDDate) , ''' ');	
		SET @a = CONCAT(@a, ' and YEAR(`PIDDate`) = ''' , YEAR(p_PIDDate) , ''' ');	
		
		SET @a1 = CONCAT(@a1, ' and DAY(`PIDDate`) = ''' , DAY(p_PIDDate) , ''' ');	
		SET @a1 = CONCAT(@a1, ' and MONTH(`PIDDate`) = ''' , MONTH(p_PIDDate) , ''' ');	
		SET @a1 = CONCAT(@a1, ' and YEAR(`PIDDate`) = ''' , YEAR(p_PIDDate) , ''' ');	
	END IF;
	
	
	/*`PIDIssue`*/
	IF p_PIDIssue IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and `PIDIssue` like ''%' ,p_PIDIssue , '%'' ');	
		SET @a1 = CONCAT(@a1, ' and `PIDIssue` like ''%' ,p_PIDIssue , '%'' ');	
	END IF;
	
	/*``DoB``*/
	IF p_DoB IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and DAY(`DoB`) = ''' , DAY(p_DoB) , ''' ');	
		SET @a = CONCAT(@a, ' and MONTH(`DoB`) = ''' , MONTH(p_DoB) , ''' ');	
		SET @a = CONCAT(@a, ' and YEAR(`DoB`) = ''' , YEAR(p_DoB) , ''' ');	
		
		SET @a1 = CONCAT(@a1, ' and DAY(`DoB`) = ''' , DAY(p_DoB) , ''' ');	
		SET @a1 = CONCAT(@a1, ' and MONTH(`DoB`) = ''' , MONTH(p_DoB) , ''' ');	
		SET @a1 = CONCAT(@a1, ' and YEAR(`DoB`) = ''' , YEAR(p_DoB) , ''' ');
	END IF;
	
	/*PoB*/
	IF p_PoB IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and `PoB` like ''%', p_PoB , '%'' ');
		SET @a1 = CONCAT(@a1, ' and `PoB` like ''%', p_PoB , '%'' ');
	END IF;
	
	/*PerAdd*/
	IF p_PerAdd IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and `PerAdd` like ''%', p_PerAdd, '%'' ');
		SET @a1 = CONCAT(@a1, ' and `PerAdd` like ''%', p_PerAdd, '%'' ');
	END IF;
	
	/*TemAdd*/
	IF p_TemAdd IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and `TemAdd` like ''%', p_TemAdd, '%'' ');
		SET @a1 = CONCAT(@a1, ' and `TemAdd` like ''%', p_TemAdd, '%'' ');
	END IF;
	
	/*Gender*/
	IF p_Gender IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and `Gender` = b''', p_Gender,  ''' ');
		SET @a1 = CONCAT(@a1, ' and `Gender` = b''', p_Gender,  ''' ');
	END IF;
	
	/*ProviceId*/
	IF p_ProvinceId IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and `ProvinceId` = ''', p_ProvinceId, ''' ');
		SET @a1 = CONCAT(@a1, ' and `ProvinceId` = ''', p_ProvinceId, ''' ');
	END IF;
	
	/*Tel*/
	IF p_Tel IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and `Tel` like ''%', p_Tel, '%'' ');
		SET @a1 = CONCAT(@a1, ' and `Tel` like ''%', p_Tel, '%'' ');
	END IF;
	
	/*Fax*/
	IF p_Fax IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and `Fax` like ''%', p_Fax, '%'' ');
		SET @a1 = CONCAT(@a1, ' and `Fax` like ''%', p_Fax, '%'' ');
	END IF;
	
	/*Email*/
	IF p_Email IS NOT NULL
	THEN
		SET @a = CONCAT(@a ,' and `Email` like ''%', p_Email, '%'' ');
		SET @a1 = CONCAT(@a1 ,' and `Email` like ''%', p_Email, '%'' ');
	END IF;
	
	/*Website*/
	IF p_Website IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and `Website` like ''%', p_Website, '%'' ');
		SET @a1 = CONCAT(@a1, ' and `Website` like ''%', p_Website, '%'' ');
	END IF;
	
	/*TaxCode*/
	IF p_TaxCode IS NOT NULL
	THEN
		SET @a = CONCAT (@a, ' and `TaxCode` like ''%', p_TaxCode, '%'' ');
		SET @a1 = CONCAT (@a1, ' and `TaxCode` like ''%', p_TaxCode, '%'' ');
	END IF;
	
	/*Note*/
	IF p_Note IS NOT NULL
	THEN
		SET @a =CONCAT (@a, ' and `Note` like ''%', p_Note, '%'' ');
		SET @a1 =CONCAT (@a1, ' and `Note` like ''%', p_Note, '%'' ');
	END IF;
	
	/*Status*/
	IF p_Status IS NOT NULL
	THEN
		SET @a =CONCAT(@a, ' and `Status` = ''', p_Status, ''' ');
		SET @a1 =CONCAT(@a1, ' and `Status` = ''', p_Status, ''' ');
	END IF;
	
	/*CreatedBy*/
	IF p_CreatedBy IS NOT NULL
	THEN
		SET @a= CONCAT(@a, ' and `CreatedBy` like ''%', p_CreatedBy, '%'' ');
		SET @a1= CONCAT(@a1, ' and `CreatedBy` like ''%', p_CreatedBy, '%'' ');
	END IF;
	
	/*CreatedDate*/
	IF p_CreatedDate IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and DAY(`CreatedDate`) = ''' , DAY(p_CreatedDate) , ''' ');	
		SET @a = CONCAT(@a, ' and MONTH(`CreatedDate`) = ''' , MONTH(p_CreatedDate) , ''' ');	
		SET @a = CONCAT(@a, ' and YEAR(`CreatedDate`) = ''' , YEAR(p_CreatedDate) , ''' ');	
		
		SET @a1 = CONCAT(@a1, ' and DAY(`CreatedDate`) = ''' , DAY(p_CreatedDate) , ''' ');	
		SET @a1 = CONCAT(@a1, ' and MONTH(`CreatedDate`) = ''' , MONTH(p_CreatedDate) , ''' ');	
		SET @a1= CONCAT(@a1, ' and YEAR(`CreatedDate`) = ''' , YEAR(p_CreatedDate) , ''' ');	
	END IF;
	
	/*ModifitedBy*/
	IF p_ModifiedBy IS NOT NULL
	THEN
		SET @a= CONCAT(@a, ' and `ModifiedBy` like ''%', p_ModifiedBy, '%'' ');
		SET @a1= CONCAT(@a1, ' and `ModifiedBy` like ''%', p_ModifiedBy, '%'' ');
	END IF;
	
	/*ModifiedDate*/
	IF p_ModifiedDate IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and DAY(`ModifiedDate`) = ''' , DAY(p_ModifiedDate) , ''' ');	
		SET @a = CONCAT(@a, ' and MONTH(`ModifiedDate`) = ''' , MONTH(p_ModifiedDate) , ''' ');	
		SET @a = CONCAT(@a, ' and YEAR(`ModifiedDate`) = ''' , YEAR(p_ModifiedDate) , ''' ');	
		
		SET @a1 = CONCAT(@a1, ' and DAY(`ModifiedDate`) = ''' , DAY(p_ModifiedDate) , ''' ');	
		SET @a1 = CONCAT(@a1, ' and MONTH(`ModifiedDate`) = ''' , MONTH(p_ModifiedDate) , ''' ');	
		SET @a1 = CONCAT(@a1, ' and YEAR(`ModifiedDate`) = ''' , YEAR(p_ModifiedDate) , ''' ');	
	END IF;
	
	
	SET @a = concat(@a,' LIMIT ',p_NoStart,', ',p_NoEnd);
	
	
		
	PREPARE stmt1 FROM @a;
	EXECUTE stmt1 ;
	
	PREPARE stmt2 FROM @a1;
	EXECUTE stmt2 ;
	/*select @a as bien;*/
	select @a as 'SQLString';
	select p_DoB as 'DoB';
	
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spSearch_Order` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spSearch_Order`(
	p_OrderId 	VARCHAR(20),
	p_DeskId  	VARCHAR(20),
	
	p_Note   	VARCHAR(255),
	p_Status   	VARCHAR(20),
	
	p_TotalTax   	DECIMAL(20),
	p_TotalAmmount   	DECIMAL(20),
	p_TotalAmountBeforeTax   	DECIMAL(20),
	p_DisCountAmount   	DECIMAL(20),
	p_TotalMoney   	DECIMAL(20),
	
	p_CreatedBy  	VARCHAR(20),
	p_CreatedDateFrom	DATETIME,
	p_CreatedDateTo	DATETIME,
	
	p_IsPrint TINYINT(4),
		
	p_NoStart       INT(11),
	p_NoEnd          INT(11) 
	)
BEGIN
	
	SET @a = 'SELECT a.*, b.`DeskNo` FROM `orders` a INNER JOIN `desk` b ON a.`DeskId`=b.`DeskId` where 1=1 ';
	SET @a1 = 'SELECT count(*) as `Total` FROM `orders` a INNER JOIN `desk` b ON a.`DeskId`=b.`DeskId`  where 1=1 ';
	
	/*`OrderId`*/
	IF p_OrderId IS NOT NULL 
	THEN
		SET @a = CONCAT(@a, ' and a.`OrderId` like ''%' ,p_OrderId , '%'' ');	
		SET @a1 = CONCAT(@a1, ' and a.`OrderId` like ''%' ,p_OrderId , '%'' ');
	END IF;
	
	/*`DeskId`*/
	IF p_DeskId IS NOT NULL 
	THEN
		SET @a = CONCAT(@a, ' and a.`DeskId` = ' ,p_DeskId);	
		SET @a1 = CONCAT(@a1, ' and a.`DeskId` = ' ,p_DeskId);
	END IF;
	
	/*`Note`*/
	IF p_Note IS NOT NULL 
	THEN
		SET @a = CONCAT(@a, ' and a.`Note` like ''%' ,p_Note , '%'' ');	
		SET @a1 = CONCAT(@a1, ' and a.`Note` like ''%' ,p_Note , '%'' ');
	END IF;
	
	/*`Status`*/
	IF p_Status IS NOT NULL 
	THEN
		SET @a = CONCAT(@a, ' and a.`Status` like ''%' ,p_Status , '%'' ');	
		SET @a1 = CONCAT(@a1, ' and a.`Status` like ''%' ,p_Status , '%'' ');
	END IF;
	
	/*`TotalTax`*/
	IF p_TotalTax IS NOT NULL 
	THEN
		SET @a = CONCAT(@a, ' and a.`TotalTax` like ''%' ,p_TotalTax , '%'' ' );	
		SET @a1 = CONCAT(@a1, ' and a.`TotalTax` = ''%' ,p_TotalTax ,'%'' ');
	END IF;
	
	/*`TotalAmmount`*/
	IF p_TotalAmmount IS NOT NULL 
	THEN
		SET @a = CONCAT(@a, ' and a.`TotalAmmount` like ''%' ,p_TotalAmmount,'%'' ');	
		SET @a1 = CONCAT(@a1, ' and a.`TotalAmmount` like ''%' ,p_TotalAmmount,'%'' ');
	END IF;
	
	/*`TotalAmountBeforeTax`*/
	IF p_TotalAmountBeforeTax IS NOT NULL 
	THEN
		SET @a = CONCAT(@a, ' and a.`TotalAmountBeforeTax` like ''%' ,p_TotalAmountBeforeTax,'%'' ' );	
		SET @a1 = CONCAT(@a1, ' and a.`TotalAmountBeforeTax` like ''%' ,p_TotalAmountBeforeTax,'%'' ');
	END IF;
	
	/*`TotalMoney`*/
	IF p_TotalMoney IS NOT NULL 
	THEN
		SET @a = CONCAT(@a, ' and a.`TotalMoney` like ''%',p_TotalMoney,'%'' ');	
		SET @a1 = CONCAT(@a1, ' and a.`TotalMoney` like ''%',p_TotalMoney,'%'' ');
	END IF;
	
	
	/*`DisCountAmount`*/
	IF p_DisCountAmount IS NOT NULL 
	THEN
		SET @a = CONCAT(@a, ' and a.`DisCountAmount` like ''%',p_DisCountAmount,'%'' ' );	
		SET @a1 = CONCAT(@a1, ' and a.`DisCountAmount` like ''%',p_DisCountAmount,'%'' ');
	END IF;
	
	/*`IsPrint`*/
	IF p_IsPrint IS NOT NULL 
	THEN
		SET @a = CONCAT(@a, ' and a.`IsPrint` = ',p_IsPrint);	
		SET @a1 = CONCAT(@a1, ' and a.`IsPrint` = ',p_IsPrint);
	END IF;
		
	/*CreatedBy*/
	IF p_CreatedBy IS NOT NULL
	THEN
		SET @a= CONCAT(@a, ' and a.`CreatedBy` like ''%', p_CreatedBy, '%'' ');
		SET @a1= CONCAT(@a1, ' and a.`CreatedBy` like ''%', p_CreatedBy, '%'' ');
	END IF;
	
	/*CreatedDate*/
	IF p_CreatedDateFrom IS NOT NULL
	THEN
		set @a = concat(@a, 'and Date(a.`CreatedDate`) between ''' , p_CreatedDateFrom , ''' and ''' , p_CreatedDateTo , '''');
		SET @a1 = CONCAT(@a1, 'and Date(a.`CreatedDate`) between ''' , p_CreatedDateFrom , ''' and ''' , p_CreatedDateTo , '''');
		
	END IF;
	
	SET @a = CONCAT(@a,' LIMIT ',p_NoStart,', ',p_NoEnd);
	
	
		
	PREPARE stmt1 FROM @a;
	EXECUTE stmt1 ;
	
	PREPARE stmt2 FROM @a1;
	EXECUTE stmt2 ;
	/*select @a as bien;*/
	SELECT @a AS 'SQLString';
	
	
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spSearch_ProductById` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spSearch_ProductById`(
	p_ProductId VARCHAR(20)  
			
	)
BEGIN
	
	SET @a = 'SELECT *  FROM `receiptdetails` a INNER JOIN `products` b ON a.`ProductId` = b.`ProductId`  where 1=1 ';
	
	/*`ProductId`*/
	IF p_ProductId IS NOT NULL 
	THEN
		SET @a = CONCAT(@a, ' and `ProductId` like ''%' ,p_ProductId, '%'' ');	
		
	END IF;
	
	
	
	
	
	
	PREPARE stmt1 FROM @a;
	EXECUTE stmt1 ;
	
	
	/*select @a as bien;*/
	SELECT @a AS 'SQLString';	
	
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spSearch_ProductNoOfCustomersDay` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spSearch_ProductNoOfCustomersDay`(
	p_ProductId varchar(20),
	sDate       datetime
    )
BEGIN
    
	SET @a = 'SELECT a.`ProductId`, b.`Name`,                              
                                SUM(a.`TotalAmount`) AS `Revenue`,
                                SUM(c.`NoOfCustumers`) AS TotalCustomer
                            FROM `receiptdetails` a INNER JOIN `products` b ON a.`ProductId` = b.`ProductId`
                                      INNER JOIN `receipts` c ON a.`ReceiptId`=c.`ReceiptId`              
                            WHERE';
         if sDate is not null
         then
         set @a = concat(@a,'DATE_FORMAT( a.`CreatedDate`,  ''%Y-%m-%d'' ) = ',sDate); 
         end if;
         
         if p_ProductId is not null
         then 
         SET @a = concat(@a,'AND `a`.`ProductId` =',p_ProductId,'GROUP BY `a`.`ProductId`');
         end if;
         
         	
	PREPARE stmt1 FROM @a;
	EXECUTE stmt1 ;
	/*select @a as bien;*/
	SELECT @a AS 'SQLString';
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spSearch_ProductRPHourDetail` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spSearch_ProductRPHourDetail`(
    p_From datetime,
    p_To datetime,
    p_ProductID varchar(20),
    p_TimeF varchar (20)
    
    )
BEGIN
	SET @a = 'SELECT a.`ProductId`, b.`Name`,SUM(a.`TotalAmount`) AS `DoanhThu`,COUNT(a.`ReceiptId`) AS TotalCustomer
	 FROM `receiptdetails` a INNER JOIN `products` b ON a.`ProductId` = b.`ProductId`
                                                    INNER JOIN `receipts` c ON a.`ReceiptId`=c.`ReceiptId` where 1=1 AND a.`Status` = ''1'' ';
          if p_From is not null
          then 
          SET @a = CONCAT(@a, ' and DATE_FORMAT( a.`CreatedDate`,  ''%Y-%m-%d'' ) >= ''' ,p_From , ''' ');
	end if;
	
	IF p_To IS NOT NULL
          THEN 
          SET @a = CONCAT(@a, ' and DATE_FORMAT( a.`CreatedDate`,  ''%Y-%m-%d'' ) <=  ''' ,p_To , ''' ');
	END IF;
	
	IF p_TimeF IS NOT NULL
          THEN 
          SET @a = CONCAT(@a, '  AND HOUR(a.`CreatedDate`) = ''' ,p_TimeF , ''' ');
	END IF;
	
	IF p_ProductID IS NOT NULL
          THEN 
          SET @a = CONCAT(@a, ' AND a.`ProductId` =  ''' ,p_ProductID , ''' ');
          
	END IF;
	
	
          SET @a = CONCAT(@a, ' GROUP BY a.`ProductId`');
          
		
	PREPARE stmt1 FROM @a;
	EXECUTE stmt1 ;
	/*select @a as bien;*/
	SELECT @a AS 'SQLString';
	/*SELECT p_DoB AS 'DoB';*/
	
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spSearch_Products` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spSearch_Products`(
	p_ProductId 	VARCHAR(20)  ,
	p_Name 		 VARCHAR(512),
	p_Unit   	VARCHAR(128),	
	p_Notes		TEXT,
	p_ProductType     	VARCHAR(50),
	
	
	p_CreateBy	VARCHAR(20),
	p_CreatedDate	DATETIME,
	p_ModifiedBy	VARCHAR(20),
	
	p_NoStart       INT(11),
	p_NoEnd          INT(11) 
	)
BEGIN
	
	SET @a = 'SELECT * FROM `products` where 1=1 ';
	SET @a1 = 'SELECT count(*) as `Total` FROM `products` where 1=1 ';
	/*`ProductId`*/
	IF p_ProductId IS NOT NULL 
	THEN
		SET @a = CONCAT(@a, ' and `ProductId` like ''%' ,p_ProductId , '%'' ');	
		SET @a1 = CONCAT(@a1, ' and `ProductId` like ''%' ,p_ProductId , '%'' ');
	END IF;
	
	/*`Name`*/
	IF p_Name IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and `Name` like ''%' ,p_Name , '%'' ');	
		SET @a1 = CONCAT(@a1, ' and `NAME` like ''%' ,p_Name , '%'' ');	
	END IF;
	
	/*`Unit`*/
	IF p_Unit IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and `Unit` = ''' ,p_Unit , ''' ');	
		SET @a1 = CONCAT(@a1, ' and `Unit` = ''' ,p_Unit , ''' ');	
	END IF;
	
	
	/*Note*/
	IF p_Notes IS NOT NULL
	THEN
		SET @a =CONCAT (@a, ' and `Notes` like ''%', p_Notes, '%'' ');
		SET @a1 =CONCAT (@a1, ' and `Notes` like ''%', p_Notes, '%'' ');
	END IF;
	
	
	
	
	
	
	/*CreateBy*/
	IF p_CreateBy IS NOT NULL
	THEN
		SET @a= CONCAT(@a, ' and `CreatedBy` like ''%', p_CreatedBy, '%'' ');
		SET @a1= CONCAT(@a1, ' and `CreatedBy` like ''%', p_CreatedBy, '%'' ');
	END IF;
	
	/*CreatedDate*/
	IF p_CreatedDate IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and DAY(`CreatedDate`) = ''' , DAY(p_CreatedDate) , ''' ');	
		SET @a = CONCAT(@a, ' and MONTH(`CreatedDate`) = ''' , MONTH(p_CreatedDate) , ''' ');	
		SET @a = CONCAT(@a, ' and YEAR(`CreatedDate`) = ''' , YEAR(p_CreatedDate) , ''' ');	
		
		SET @a1 = CONCAT(@a1, ' and DAY(`CreatedDate`) = ''' , DAY(p_CreatedDate) , ''' ');	
		SET @a1 = CONCAT(@a1, ' and MONTH(`CreatedDate`) = ''' , MONTH(p_CreatedDate) , ''' ');	
		SET @a1= CONCAT(@a1, ' and YEAR(`CreatedDate`) = ''' , YEAR(p_CreatedDate) , ''' ');	
	END IF;
	
	/*ModifitedBy*/
	IF p_ModifiedBy IS NOT NULL
	THEN
		SET @a= CONCAT(@a, ' and `ModifiedBy` like ''%', p_ModifiedBy, '%'' ');
		SET @a1= CONCAT(@a1, ' and `ModifiedBy` like ''%', p_ModifiedBy, '%'' ');
	END IF;
	
	
	
	/*ProductType*/
	IF p_ProductType IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and `ProductType` like ''%', p_ProductType , '%'' ');
		SET @a1 = CONCAT(@a1, ' and `ProductType` like ''%', p_ProductType , '%'' ');
	END IF;
	
	
	
	SET @a = CONCAT(@a,' LIMIT ',p_NoStart,', ',p_NoEnd);
	
	
		
	PREPARE stmt1 FROM @a;
	EXECUTE stmt1 ;
	
	PREPARE stmt2 FROM @a1;
	EXECUTE stmt2 ;
	/*select @a as bien;*/
	SELECT @a AS 'SQLString';
	-- SELECT p_DoB AS 'DoB';
	
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spSearch_ProPrice` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spSearch_ProPrice`(
	p_ProductId VARCHAR(20)  ,
	p_Time datetime,
	p_Price decimal(20,2),
	p_CreatedId varchar(20),
	p_NoStart       INT(11),
	p_NoEnd          INT(11) 
	
	)
BEGIN
	
	SET @a = 'SELECT * FROM `productprice` where 1=1 ';
	SET @a1 = 'SELECT count(*) as `Total` FROM `productprice` where 1=1 ';
	/*`ProductId`*/
	IF p_ProductId IS NOT NULL 
	THEN
		SET @a = CONCAT(@a, ' and `ProductId` like ''%' ,p_ProductId, '%'' ');	
		SET @a1 = CONCAT(@a1, ' and `ProductId` like ''%' ,p_ProductId, '%'' ');
	END IF;
	
	/*`Price`*/
	IF p_Price IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and `Price` like ''%' ,p_Price, '%'' ');	
		SET @a1 = CONCAT(@a1, ' and `Price` like ''%' ,p_Price , '%'' ');	
	END IF;
	
	
	
	SET @a = CONCAT(@a,' LIMIT ',p_NoStart,', ',p_NoEnd);
	
	PREPARE stmt1 FROM @a;
	EXECUTE stmt1 ;
	
	PREPARE stmt2 FROM @a1;
	EXECUTE stmt2 ;
	/*select @a as bien;*/
	SELECT @a AS 'SQLString';	
	
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spSearch_ReceiptCard` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spSearch_ReceiptCard`(
	p_id		BIGINT(20),
	p_ReceiptId 	VARCHAR(20)  ,
	p_CardNo   	VARCHAR(20),
	p_CardHolderName   VARCHAR(200),
	p_ExpiredDate   VARCHAR(50),
	p_CardType      VARCHAR(40),
	p_Bank         VARCHAR(20),
	p_TotalAmount   DECIMAL(20,2), 
	p_TerminalId	VARCHAR(100),
	p_MerchantId	VARCHAR(100),
	p_TransType	VARCHAR(100),
	p_BatchNo	VARCHAR(50),
	p_TraceNo	VARCHAR(20),
	p_RefNo		VARCHAR(20),
	p_Appcode	VARCHAR(50),
	p_CreatedBy	VARCHAR(20),
	p_CreatedDate	DATETIME,
	p_ModifiedBy	VARCHAR(20),
	p_ModifiedDate	DATETIME,
	p_NoStart        INT(11),
	p_NoEnd          INT(11) 
	)
BEGIN
	
	SET @a = 'SELECT * FROM receiptscard where 1=1 and `CanUpdate` = 1 and `TotalAmount`>0' ;
	SET @a1 = 'SELECT count(*) as `Total` FROM receiptscard where 1=1 and `CanUpdate` = 1 and `TotalAmount`>0';
	/*`ReceiptId`*/
	IF p_id IS NOT NULL 
	THEN
		SET @a = CONCAT(@a, ' and `id` = ''' ,p_id , ''' ');	
		SET @a1 = CONCAT(@a1, ' and `id` = ''' ,p_id , ''' ');
	END IF;
	
	IF p_ReceiptId IS NOT NULL 
	THEN
		SET @a = CONCAT(@a, ' and `ReceiptId` like ''%' ,p_ReceiptId , '%'' ');	
		SET @a1 = CONCAT(@a1, ' and `ReceiptId` like ''%' ,p_ReceiptId , '%'' ');
	END IF;
	
	/*`CardNo `*/
	IF p_CardNo IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and `CardNo` like ''%' ,p_CardNo , '%'' ');	
		SET @a1 = CONCAT(@a1, ' and `CardNo` like ''%' ,p_CardNo , '%'' ');	
	END IF;
	
	/*`CardHolderName`*/
	IF p_CardHolderName IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and `CardHolderName` like ''%' ,p_CardHolderName , '%'' ');	
		SET @a1 = CONCAT(@a1, ' and `CardHolderName` like ''%' ,p_CardHolderName , '%'' ');	
	END IF;
	/*ExpiredDate*/
	IF p_ExpiredDate IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and `ExpiredDate` like ''%' ,p_ExpiredDate , '%'' ');	
		SET @a1 = CONCAT(@a1, ' and `ExpiredDate` like ''%' ,p_ExpiredDate , '%'' ');	
	END IF;
	
	/*`CardType`*/
	IF p_CardType IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and `CardType` = ''' ,p_CardType , ''' ');	
		SET @a1 = CONCAT(@a1, ' and `CardType` = ''' ,p_CardType , ''' ');
	END IF;
	
	
	/*`Bank`*/
	
	IF p_Bank IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and `Bank` = ''' ,p_Bank , ''' ');	
		SET @a1 = CONCAT(@a1, ' and `Bank` = ''' ,p_Bank , ''' ');	
	END IF;
	
	
	/*terminalId*/
	IF p_TerminalId IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and `TerminalId` like ''%', p_TerminalId , '%'' ');
		SET @a1 = CONCAT(@a1, ' and `TerminalId` like ''%', p_TerminalId, '%'' ');
	END IF;
	
	/*MerchantId*/
	IF p_MerchantId IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and `MerchantId` like ''%', p_MerchantId, '%'' ');
		SET @a1 = CONCAT(@a1, ' and `MerchantId` like ''%', p_MerchantId, '%'' ');
	END IF;
	
	/*TransType*/
	IF p_TransType IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and `TransType` like ''%', p_TransType, '%'' ');
		SET @a1 = CONCAT(@a1, ' and `TransType` like ''%', p_TransType, '%'' ');
	END IF;
	
	
	
	/*BatchNo*/
	IF p_BatchNo IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and `BatchNo` like ''%', p_BatchNo, '%'' ');
		SET @a1 = CONCAT(@a1, ' and `BatchNo` like ''%', p_BatchNo, '%'' ');
	END IF;
	
	/*TraceNo*/
	IF p_TraceNo IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and `TraceNo` like  ''%', p_TraceNo, '%'' ');
		SET @a1 = CONCAT(@a1, ' and `TraceNo` like ''%', p_TraceNo, '%'' ');
	END IF;
	
	/*RefNo*/
	IF p_RefNo IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and `RefNo` like ''%', p_RefNo, '%'' ');
		SET @a1 = CONCAT(@a1, ' and `RefNo` like ''%', p_RefNo, '%'' ');
	END IF;
	
	/*Appcode*/
	IF p_Appcode IS NOT NULL
	THEN
		SET @a = CONCAT(@a ,' and `Appcode` like ''%', p_Appcode, '%'' ');
		SET @a1 = CONCAT(@a1 ,' and `Appcode` like ''%', p_Appcode, '%'' ');
	END IF;
	
	
	
	/*CreatedBy*/
	IF p_CreatedBy IS NOT NULL
	THEN
		SET @a= CONCAT(@a, ' and `CreatedBy` like ''%', p_CreatedBy, '%'' ');
		SET @a1= CONCAT(@a1, ' and `CreatedBy` like ''%', p_CreatedBy, '%'' ');
	END IF;
	
	/*CreatedDate*/
	IF p_CreatedDate IS NOT NULL 
	THEN
		SET @a = CONCAT(@a, ' and DAY(`CreatedDate`) = ''' , DAY(p_CreatedDate) , ''' ');	
		SET @a = CONCAT(@a, ' and MONTH(`CreatedDate`) = ''' , MONTH(p_CreatedDate) , ''' ');	
		SET @a = CONCAT(@a, ' and YEAR(`CreatedDate`) = ''' , YEAR(p_CreatedDate) , ''' ');	
		
		SET @a1 = CONCAT(@a1, ' and DAY(`CreatedDate`) = ''' , DAY(p_CreatedDate) , ''' ');	
		SET @a1 = CONCAT(@a1, ' and MONTH(`CreatedDate`) = ''' , MONTH(p_CreatedDate) , ''' ');	
		SET @a1= CONCAT(@a1, ' and YEAR(`CreatedDate`) = ''' , YEAR(p_CreatedDate) , ''' ');	
	END IF;
	
	/*ModifitedBy*/
	IF p_ModifiedBy IS NOT NULL  
	THEN
		SET @a= CONCAT(@a, ' and `ModifiedBy` like ''%', p_ModifiedBy, '%'' ');
		SET @a1= CONCAT(@a1, ' and `ModifiedBy` like ''%', p_ModifiedBy, '%'' ');
	END IF;
	
	/*ModifiedDate*/
	IF p_ModifiedDate IS NOT NULL && p_CreatedBy != '0000-00-00 00:00:00'
	THEN
		SET @a = CONCAT(@a, ' and DAY(`ModifiedDate`) = ''' , DAY(p_ModifiedDate) , ''' ');	
		SET @a = CONCAT(@a, ' and MONTH(`ModifiedDate`) = ''' , MONTH(p_ModifiedDate) , ''' ');	
		SET @a = CONCAT(@a, ' and YEAR(`ModifiedDate`) = ''' , YEAR(p_ModifiedDate) , ''' ');	
		
		SET @a1 = CONCAT(@a1, ' and DAY(`ModifiedDate`) = ''' , DAY(p_ModifiedDate) , ''' ');	
		SET @a1 = CONCAT(@a1, ' and MONTH(`ModifiedDate`) = ''' , MONTH(p_ModifiedDate) , ''' ');	
		SET @a1 = CONCAT(@a1, ' and YEAR(`ModifiedDate`) = ''' , YEAR(p_ModifiedDate) , ''' ');	
	END IF;
	
	
	SET @a = CONCAT(@a,' LIMIT ',p_NoStart,', ',p_NoEnd);
	
	
		
	PREPARE stmt1 FROM @a;
	EXECUTE stmt1 ;
	
	PREPARE stmt2 FROM @a1;
	EXECUTE stmt2 ;
	/*select @a as bien;*/
	SELECT @a AS 'SQLString';
	/*SELECT p_DoB AS 'DoB';*/
	
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spSearch_Receipts` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spSearch_Receipts`(
	p_ReceiptId   VARCHAR(20),
	p_TotalMoney DECIMAL (20,2),
	p_CreatedBy	VARCHAR (50),
	p_CreatedDateTu 	DATETIME,
	p_CreatedDateDen 	DATETIME,
	p_NoStart       INT(11),
	p_NoEnd          INT(11)
)
BEGIN
SET @a = 'SELECT * FROM `receipts` where 1=1 ';
	SET @a1 = 'SELECT count(*) as `Total` FROM `receipts` where 1=1 ';
	
IF p_ReceiptId IS NOT NULL 
	THEN
		SET @a = CONCAT(@a, ' and `ReceiptId` like ''%' ,p_ReceiptId  , '%'' ');	
		SET @a1 = CONCAT(@a1, ' and `ReceiptId` like ''%' ,p_ReceiptId  , '%'' ');
	END IF;
	
IF p_TotalMoney IS NOT NULL 
	THEN
		SET @a = CONCAT(@a, ' and `TotalMoney` = ''' ,p_TotalMoney, ''' ');	
		SET @a1 = CONCAT(@a1, ' and `TotalMoney` = ''' ,p_TotalMoney  , ''' ');
	END IF;
IF p_CreatedBy IS NOT NULL 
	THEN
		SET @a = CONCAT(@a, ' and `CreatedBy` like ''%' ,p_CreatedBy, '%'' ');	
		SET @a1 = CONCAT(@a1, ' and `CreatedBy` like ''%' ,p_CreatedBy  , '%'' ');
	END IF;	
/*`CreateDateTu`*/
	IF p_CreatedDateTu  IS NOT NULL
	THEN
	
		SET @a = CONCAT(@a, ' and Date(`CreatedDate`) between ''' , p_CreatedDateTu , ''' and ''' , p_CreatedDateDen , '''');
		SET @a1 = CONCAT(@a1, ' and Date(`CreatedDate`) between ''' , p_CreatedDateTu , ''' and ''' , p_CreatedDateDen , '''');
	END IF;
	
	SET @a = CONCAT(@a,' LIMIT ',p_NoStart,', ',p_NoEnd);
	
	PREPARE stmt1 FROM @a;
	EXECUTE stmt1;
	
	PREPARE stmt2 FROM @a1;
	EXECUTE stmt2 ;
	SELECT @a AS 'SQLString';
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spSearch_Receipts_1` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spSearch_Receipts_1`(
	p_Id   VARCHAR(50),
	p_CreatedDateTu 	DATETIME,
	p_CreatedDateDen 	DATETIME,
	p_NoStart       INT(11),
	p_NoEnd          INT(11)
)
BEGIN
 SET @a = 'SELECT b.* FROM `receiptmember` a INNER JOIN `receipts` b ON a.`ReceiptId`=b.`ReceiptId` where 1=1 ';
 SET @a1 = 'SELECT count(*) as `Total` FROM `receiptmember` a LEFT JOIN `receipts` b ON a.`ReceiptId`=b.`ReceiptId` where 1=1 ';
 
IF p_Id IS NOT NULL 
 THEN
  SET @a = CONCAT(@a, ' and a.`MemberId` like ''%' ,p_Id  , '%'' '); 
  SET @a1 = CONCAT(@a1, ' and a.`MemberId` like ''%' ,p_Id  , '%'' ');
 END IF;
 
/*`CreateDateTu`*/
 IF p_CreatedDateTu  IS NOT NULL
 THEN
 
  SET @a = CONCAT(@a, ' and Date(b.`CreatedDate`) between ''' , p_CreatedDateTu , ''' and ''' , p_CreatedDateDen , '''');
  SET @a1 = CONCAT(@a1, ' and Date(b.`CreatedDate`) between ''' , p_CreatedDateTu , ''' and ''' , p_CreatedDateDen , '''');
 END IF;
 
 SET @a = CONCAT(@a,' LIMIT ',p_NoStart,', ',p_NoEnd);
 
 PREPARE stmt1 FROM @a;
 EXECUTE stmt1;
 
 PREPARE stmt2 FROM @a1;
 EXECUTE stmt2 ;
 SELECT @a AS 'SQLString';
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spSearch_Receipts_2` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spSearch_Receipts_2`(
	p_Id   VARCHAR(50),
	p_CreatedDateTu 	DATETIME,
	p_CreatedDateDen 	DATETIME,
	p_NoStart       INT(11),
	p_NoEnd          INT(11)
)
BEGIN
SET @a = 'SELECT b.* FROM `receiptscard` a INNER JOIN `receipts` b ON a.`ReceiptId`=b.`ReceiptId` where 1=1 ';
	SET @a1 = 'SELECT count(*) as `Total` FROM `receiptscard` a LEFT JOIN `receipts` b ON a.`ReceiptId`=b.`ReceiptId` where 1=1 ';
	
IF p_Id IS NOT NULL 
	THEN
		SET @a = CONCAT(@a, ' and a.`CardNo` like ''%' ,p_Id  , '%'' ');	
		SET @a1 = CONCAT(@a1, ' and a.`CardNo` like ''%' ,p_Id  , '%'' ');
	END IF;
	
/*`CreateDateTu`*/
	IF p_CreatedDateTu  IS NOT NULL
	THEN
	
		SET @a = CONCAT(@a, ' and Date(b.`CreatedDate`) between ''' , p_CreatedDateTu , ''' and ''' , p_CreatedDateDen , '''');
		SET @a1 = CONCAT(@a1, ' and Date(b.`CreatedDate`) between ''' , p_CreatedDateTu , ''' and ''' , p_CreatedDateDen , '''');
	END IF;
	
	SET @a = CONCAT(@a,' LIMIT ',p_NoStart,', ',p_NoEnd);
	
	PREPARE stmt1 FROM @a;
	EXECUTE stmt1;
	
	PREPARE stmt2 FROM @a1;
	EXECUTE stmt2 ;
	SELECT @a AS 'SQLString';
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spSearch_Suppliers` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spSearch_Suppliers`(
	p_SupplierId 		VARCHAR(20)  ,
	p_SupplierName 		VARCHAR(255),
	p_SupplierAddress   	VARCHAR(255),	
	p_SupplierPhone		VARCHAR(20),
	p_SupplierEmail     	VARCHAR(255),
	p_SupplierWebsite	VARCHAR(255),
	
	p_NoStart       INT(11),
	p_NoEnd          INT(11) 
	)
BEGIN
	
	SET @a = 'SELECT * FROM `supplier` where 1=1 ';
	SET @a1 = 'SELECT count(*) as `Total` FROM `supplier` where 1=1 ';
	/*`ProductId`*/
	IF p_SupplierId IS NOT NULL 
	THEN
		SET @a = CONCAT(@a, ' and `SupplierId` like ''%' ,p_SupplierId , '%'' ');	
		SET @a1 = CONCAT(@a1, ' and `SupplierId`like ''%' ,p_SupplierId , '%'' ');
	END IF;
	
	/*`Name`*/
	IF p_SupplierName IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and `SupplierName` like ''%' ,p_SupplierName , '%'' ');	
		SET @a1 = CONCAT(@a1, ' and `SupplierName` like ''%' ,p_SupplierName , '%'' ');	
	END IF;
	
	/*`Unit`*/
	IF p_SupplierAddress IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and `SupplierAddress` = ''' ,p_SupplierAddress , ''' ');	
		SET @a1 = CONCAT(@a1, ' and `SupplierAddress` = ''' ,p_SupplierAddress , ''' ');	
	END IF;
	
	
	/*Note*/
	IF p_SupplierPhone IS NOT NULL
	THEN
		SET @a =CONCAT (@a, ' and `SupplierPhone` = ''', p_SupplierPhone, ''' ');
		SET @a1 =CONCAT (@a1, ' and `SupplierPhone` = ''', p_SupplierPhone, ''' ');
	END IF;
	
	
	/*ProductType*/
	IF p_SupplierEmail IS NOT NULL
	THEN
		SET @a =CONCAT (@a, ' and `SupplierEmail` = ''', p_SupplierEmail, ''' ');
		SET @a1 =CONCAT (@a1, ' and `SupplierEmail` = ''', p_SupplierEmail, ''' ');
	END IF;
	
	IF p_SupplierWebsite IS NOT NULL
	THEN
		SET @a =CONCAT (@a, ' and `SupplierWebsite` = ''', p_SupplierWebsite, ''' ');
		SET @a1 =CONCAT (@a1, ' and `SupplierWebsite` = ''', p_SupplierWebsite, ''' ');
	END IF;
	
	
	
	SET @a = CONCAT(@a,' LIMIT ',p_NoStart,', ',p_NoEnd);
	
	
		
	PREPARE stmt1 FROM @a;
	EXECUTE stmt1 ;
	
	PREPARE stmt2 FROM @a1;
	EXECUTE stmt2 ;
	/*select @a as bien;*/
	SELECT @a AS 'SQLString';
	-- SELECT p_DoB AS 'DoB';
	
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spSearch_Users` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spSearch_Users`(
	p_UserId VARCHAR(100)  ,
	p_Pwd VARCHAR(500),
	p_ObjectId   VARCHAR(20),
	p_LastLogin   datetime,
	p_Status	VARCHAR(20),
	p_CreatedBy	VARCHAR(20),
	p_CreatedDate	DATETIME,
	p_ModifiedBy	VARCHAR(20),
	p_ModifiedDate		DATETIME,
	p_RoleId	VARCHAR (20),
	p_NoStart int(11),
	p_NoEnd          INT(11) 
	
	)
BEGIN
	
	SET @a = 'SELECT * FROM `users` where 1=1 and `Status` != 5';
	SET @a1 = 'SELECT count(*) as `Total` FROM `users` where 1=1 and `Status` != 5';
	/*`EmployeeId`*/
	IF p_UserId IS NOT NULL 
	THEN
		SET @a = CONCAT(@a, ' and `UserId` like ''%' ,p_UserId, '%'' ');	
		SET @a1 = CONCAT(@a1, ' and `UserId` like ''%' ,p_UserId , '%'' ');
	END IF;
	
	/*`EmployeeCode`*/
	IF p_Pwd IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and `Pwd` like ''%' ,p_Pwd , '%'' ');	
		SET @a1 = CONCAT(@a1, ' and `Pwd` like ''%' ,p_Pwd , '%'' ');	
	END IF;
	
	/*`ObjectId`*/
	IF p_ObjectId IS NOT NULL 
	THEN
		SET @a = CONCAT(@a, ' and `ObjectId` like ''%' ,p_ObjectId , '%'' ');	
		SET @a1 = CONCAT(@a1, ' and `ObjectId` like ''%' ,p_ObjectId , '%'' ');
	END IF;
	
	/*LastLogin*/
	IF p_LastLogin IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and DAY(`LastLogin`) = ''' , DAY(p_LastLogin) , ''' ');	
		SET @a = CONCAT(@a, ' and MONTH(`LastLogin`) = ''' , MONTH(p_LastLogin) , ''' ');	
		SET @a = CONCAT(@a, ' and YEAR(`LastLogin`) = ''' , YEAR(p_LastLogin) , ''' ');	
		
		SET @a1 = CONCAT(@a1, ' and DAY(`LastLogin`) = ''' , DAY(p_LastLogin) , ''' ');	
		SET @a1 = CONCAT(@a1, ' and MONTH(`LastLogin`) = ''' , MONTH(p_LastLogin) , ''' ');	
		SET @a1= CONCAT(@a1, ' and YEAR(`LastLogin`) = ''' , YEAR(p_LastLogin) , ''' ');	
	END IF;
	
	/*Status*/
	IF p_Status IS NOT NULL
	THEN
		SET @a =CONCAT(@a, ' and `Status` = ''', p_Status, ''' ');
		SET @a1 =CONCAT(@a1, ' and `Status` = ''', p_Status, ''' ');
	END IF;
	
	/*CreatedBy*/
	IF p_CreatedBy IS NOT NULL
	THEN
		SET @a= CONCAT(@a, ' and `CreatedBy` like ''%', p_CreatedBy, '%'' ');
		SET @a1= CONCAT(@a1, ' and `CreatedBy` like ''%', p_CreatedBy, '%'' ');
	END IF;
	
	/*CreatedDate*/
	IF p_CreatedDate IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and DAY(`CreatedDate`) = ''' , DAY(p_CreatedDate) , ''' ');	
		SET @a = CONCAT(@a, ' and MONTH(`CreatedDate`) = ''' , MONTH(p_CreatedDate) , ''' ');	
		SET @a = CONCAT(@a, ' and YEAR(`CreatedDate`) = ''' , YEAR(p_CreatedDate) , ''' ');	
		
		SET @a1 = CONCAT(@a1, ' and DAY(`CreatedDate`) = ''' , DAY(p_CreatedDate) , ''' ');	
		SET @a1 = CONCAT(@a1, ' and MONTH(`CreatedDate`) = ''' , MONTH(p_CreatedDate) , ''' ');	
		SET @a1= CONCAT(@a1, ' and YEAR(`CreatedDate`) = ''' , YEAR(p_CreatedDate) , ''' ');	
	END IF;
	
	/*ModifitedBy*/
	IF p_ModifiedBy IS NOT NULL
	THEN
		SET @a= CONCAT(@a, ' and `ModifiedBy` like ''%', p_ModifiedBy, '%'' ');
		SET @a1= CONCAT(@a1, ' and `ModifiedBy` like ''%', p_ModifiedBy, '%'' ');
	END IF;
	
	/*ModifiedDate*/
	IF p_ModifiedDate IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and DAY(`ModifiedDate`) = ''' , DAY(p_ModifiedDate) , ''' ');	
		SET @a = CONCAT(@a, ' and MONTH(`ModifiedDate`) = ''' , MONTH(p_ModifiedDate) , ''' ');	
		SET @a = CONCAT(@a, ' and YEAR(`ModifiedDate`) = ''' , YEAR(p_ModifiedDate) , ''' ');	
		
		SET @a1 = CONCAT(@a1, ' and DAY(`ModifiedDate`) = ''' , DAY(p_ModifiedDate) , ''' ');	
		SET @a1 = CONCAT(@a1, ' and MONTH(`ModifiedDate`) = ''' , MONTH(p_ModifiedDate) , ''' ');	
		SET @a1 = CONCAT(@a1, ' and YEAR(`ModifiedDate`) = ''' , YEAR(p_ModifiedDate) , ''' ');	
	END IF;
	
	/*RoleId*/
	
	IF p_RoleId IS NOT NULL
	THEN
		SET @a = CONCAT(@a, ' and `RoleId` = ''' ,p_RoleId, ''' ');	
		SET @a1 = CONCAT(@a1, ' and `RoleId` = ''' ,p_RoleId, ''' ');	
	END IF;
	
	SET @a = CONCAT(@a,' LIMIT ',p_NoStart,', ',p_NoEnd);
	
	PREPARE stmt1 FROM @a;
	EXECUTE stmt1 ;
	
	PREPARE stmt2 FROM @a1;
	EXECUTE stmt2 ;
	/*select @a as bien;*/
	SELECT @a AS 'SQLString';	
	
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spSelect_CommonCode_By_CommonTypeId` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spSelect_CommonCode_By_CommonTypeId`(
	_CommonTypeId varchar(20)
    )
BEGIN
	SELECT *
	FROM `commoncode`
	where `CommonTypeId` = _CommonTypeId;
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spSelect_Count_Order_By_Status` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spSelect_Count_Order_By_Status`(
	p_Status varchar(20)
    )
BEGIN
	select  count(*) as TotalRecord
	from orders
	where `Status` = p_Status;
	
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spSelect_Desk_ById` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spSelect_Desk_ById`(
	_DeskId int(11)
    )
BEGIN
	select *
	from `desk`
	where `DeskId` = _DeskId;
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spSelect_Desk_Status_StrValues` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spSelect_Desk_Status_StrValues`(
    _CommonTypeId VARCHAR(20),
    _CommonId varchar(20)
    )
BEGIN
	SELECT *
	FROM `commoncode`
	WHERE `CommonTypeId` = _CommonTypeId and `CommonId` = _CommonId
	limit 0,1;
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spSelect_Employ_By_EmployId` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spSelect_Employ_By_EmployId`(
	p_EmployeeId VARCHAR(20)
    )
BEGIN
	SELECT *
	FROM `employees`
	WHERE `EmployeeId` = p_EmployeeId;
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spSelect_ObjectId_By_UserId` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spSelect_ObjectId_By_UserId`(
	p_UserId varchar(100)
    )
BEGIN
	select `ObjectId`
	from users
	where `UserId` = p_UserId;
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spSelect_ObjectId_By_UserId1` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spSelect_ObjectId_By_UserId1`(
	p_UserId varchar(100)
    )
BEGIN
	select a.*
	from `objects` a inner join `users` b on a.`ObjectId`=b.`ObjectId`
	where b.`UserId` = p_UserId;
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spSelect_Object_By_ObjectId` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spSelect_Object_By_ObjectId`(
	p_ObjectId varchar(20)
    )
BEGIN
	select *
	from objects
	where `ObjectId` = p_ObjectId;
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spSelect_Orders` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spSelect_Orders`()
BEGIN
	select `OrderId`
	from `orders`
	where SUBSTRING(`OrderId`,3,8) = /*REPLACE(CURDATE(),'-','')*/CURDATE() + 0
	order by `OrderId` Desc
	limit 0,1;
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spSelect_Orders_For_Payment` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spSelect_Orders_For_Payment`()
BEGIN
	select *
	from `orders`
	where `Status`='0'
	order by  `CreatedDate`,`DeskId`;	
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spSelect_Order_AllInfo` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spSelect_Order_AllInfo`(
	p_OrderId 	 VARCHAR(20)	
    )
BEGIN
	SELECt * from `orders` where `OrderId`=p_OrderId;
	SELECT * FROM `orderdetails` WHERE `OrderId`=p_OrderId;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spSelect_PaymentOfOrder` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spSelect_PaymentOfOrder`(
  p_OrderId VARCHAR (20)
)
BEGIN  
	set @totPay =0;
	set @totNotPay=0;
 
  SELECT SUM(`TotalAmmount`) into @totPay FROM `orderdetails` WHERE `OrderId` = p_OrderId and `Status` = '1'  GROUP BY `OrderId`;
  SELECT SUM(`TotalAmmount`) INTO @totNotPay FROM `orderdetails` WHERE `OrderId` = p_OrderId AND `Status` = '0'  GROUP BY `OrderId`;
  
	select @totPay as totalPaid, @totNotPay AS totalNotPaid;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spSelect_Receipts` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spSelect_Receipts`()
BEGIN
	SELECT *
	FROM `receipts`
	WHERE SUBSTRING(`ReceiptId`,3,8) = /*REPLACE(CURDATE(),'-','')*/CURDATE() + 0
	ORDER BY `ReceiptId` DESC
	LIMIT 0,1;
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spSelect_Receipt_AllInfo` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spSelect_Receipt_AllInfo`(
	p_ReceiptId 	 VARCHAR(20)	
    )
BEGIN
	SELECt * from `receipts` where `ReceiptId`=p_ReceiptId;
	SELECT * FROM `receiptdetails` WHERE `ReceiptId`=p_ReceiptId;
	SELECT * FROM `receiptscard` WHERE `ReceiptId`=p_ReceiptId;
	SELECT * FROM `receiptinfo` WHERE `ReceiptId`=p_ReceiptId;
	SELECT * FROM `receiptmember` WHERE `ReceiptId`=p_ReceiptId;	
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spSelect_Role_By_RoleId` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spSelect_Role_By_RoleId`(
	p_RoleId VARCHAR(128)
    )
BEGIN
	SELECT *
	FROM `roles`
	WHERE `RoleId` = p_RoleId;
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spUpdate_Desks` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spUpdate_Desks`(
	_DeskId 	int(11),
	_DeskNo 	varchar(10),
	_Descripton 	varchar(512),
	_DeskLocation 	varchar(255),
	_Status         varchar(255),
	_NoOfSeat     	int(11),
	/* _sCondition = 0, khong ton tai DeskNo; = 1 ton tai DeskNo */
	_sCondition int(1)
    
    )
BEGIN
	update `desk`
	set `DeskNo` = _DeskNo ,`Description` = _Descripton,`Status` = _Status, `DeskLocation` = _DeskLocation, `NoOfSeat` = _NoOfSeat
	where CASE WHEN (_sCondition = 0) THEN `DeskId` = _DeskId ELSE `DeskNo` = _DeskNo END;
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spUpdate_Desk_IsUsing` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spUpdate_Desk_IsUsing`(
	_DeskId int(11),
	_IsUsing int(11)
    )
BEGIN
	update desk
	set `IsUsing` = _IsUsing
	where `DeskId` = _DeskId;
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spUpdate_EmployeeId_Order` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spUpdate_EmployeeId_Order`(
	p_OrderId varchar(20),
	p_EmployeeId int(11),
	p_ModifiedBy varchar(256),
	p_Note varchar(255),
	p_DisCountAmount decimal(20,0)
    )
BEGIN
	update `orders` set `EmployeeId` = p_EmployeeId, `ModifiedBy` = p_ModifiedBy, `ModifiedDate` = now(), `Note` = p_Note, `DisCountAmount` =  p_DisCountAmount where `OrderId` = p_OrderId;
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spUpdate_OrderDetail` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spUpdate_OrderDetail`(
	p_OrderId  VARCHAR(20),
	p_ProductId VARCHAR(20),
	p_Qty       INT(11),
	p_Price        DECIMAL(20.0),
	p_ModifiedBy   VARCHAR(256),
	p_Status   VARCHAR(20),
	p_AmmountBeforeTax  DECIMAL(20.0),
	p_TaxAmmount  DECIMAL(20.0),
	p_TotalAmmount DECIMAL(20.0),
	p_Note varchar(250)
    )
BEGIN
	UPDATE `orderdetails`
	SET  `Qty`= p_Qty,`Price` = p_Price,`ModifiedDate` = NOW(),
	     `ModifiedBy` = p_ModifiedBy,`Status` = p_Status, `AmmountBeforeTax` = p_AmmountBeforeTax ,
	     `TaxAmmount` = p_TaxAmmount,`TotalAmmount` = p_TotalAmmount, `Note` = p_Note
	 WHERE `OrderId` = p_OrderId and  `ProductId` = p_ProductId ;
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spUpdate_OrderDetail_Status` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spUpdate_OrderDetail_Status`(
	order_id  VARCHAR(20),
	product_id VARCHAR(20),	
	modified_by   VARCHAR(256),
	status_s   VARCHAR(20)
    )
BEGIN
	UPDATE `orderdetails`
	SET  `ModifiedDate` =NOW(),
	     `ModifiedBy` = modified_by,`Status` = status_s
	 WHERE `OrderId` = order_id and  `ProductId` = product_id ;
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spUpdate_Orders` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spUpdate_Orders`(
	order_id  	varchar(20),
	desk_id  	varchar(20),
	note_s          varchar(255),
	status_s      	varchar(20),
	modified_by    	varchar(256),
	total_tax      	decimal(20.0),
	total_Ammount   decimal(20.0),
	total_Ammount_Before_tax  decimal(20.0),
	disCountAmount   decimal(20.0),
	totalMoney      decimal(20.0)
    
    )
BEGIN
	update `orders`
	set  `DeskId` = ifnull(desk_id,''),`Note` = ifnull(note_s,''),`ModifiedDate` =now(),
	     `ModifiedBy` = ifnull(modified_by,''),`TotalTax` = ifnull(total_tax,''),
	     `TotalAmmount` = ifnull(total_Ammount,''),`TotalAmountBeforeTax` = ifnull(total_Ammount_Before_tax,''),
	     `DisCountAmount` = Ifnull(disCountAmount,''),`TotalMoney` = ifnull(totalMoney,'')
	 where `OrderId` = order_id;
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spUpdate_OutPut_By_Reciept` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spUpdate_OutPut_By_Reciept`(
	p_OutputId 	VARCHAR(20),
	p_ReceiptId	VARCHAR(20),
	p_ProductId	VARCHAR(20),
	p_CreatedBy	VARCHAR(20)
    )
BEGIN
	DECLARE MeasureId VARCHAR(20);
		
	/*Get MeasureId*/
	SELECT `MeasureId` FROM `measure` WHERE `ProductId` = p_ProductId INTO MeasureId;
	
	CALL spUpdate_Update_OutputDetail_By_Measure(p_OutputId, MeasureId);
	
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spUpdate_Products` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spUpdate_Products`(
	product_id  VARCHAR(20),
	name_s      VARCHAR(512),
	unit_s      VARCHAR(128),
	image_s     LONGBLOB,
	notes_s     TEXT,
	modified_by   VARCHAR(255),
	product_type VARCHAR(50)
    )
BEGIN
	update `products`
	set `Name` = name_s,`Unit` = unit_s,`Image` = image_s,`Notes` = notes_s,`ModifiedBy` = modified_by,`ModifiedDate` = now(), `ProductType` = product_type
	where `ProductId` = product_id;
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spUpdate_Status_OrderDetail` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spUpdate_Status_OrderDetail`(
  p_OrderId VARCHAR (20),
  p_ProductId VARCHAR (20),
  p_DeskId VARCHAR (20),
  p_ModifiedBy VARCHAR(256)
)
BEGIN
  update `orderdetails` set `Status` = '1' where `OrderId` = p_OrderId  and `ProductId` = p_ProductId ;
  
  SELECT count(*) into @tot from `orderdetails` where `OrderId` = p_OrderId ;
  SELECT COUNT(*) into @totStatus FROM `orderdetails` WHERE `OrderId` = p_OrderId and `Status` = '1' ;
  
  if @tot = @totStatus 
  THEN 
	UPDATE `orders` 
	SET `Status` = '1', `ModifiedBy` = p_ModifiedBy
	WHERE `OrderId` = p_OrderId ;
	
	if p_DeskId is not null
	then
		UPDATE `desk`
		SET `IsUsing`  = '0' 
		WHERE `DeskId` = p_DeskId ;		
	end if;
	
  end IF ;
	select @tot as total, @totStatus AS total_with_1;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spUpdate_Update_OutputDetail_By_Measure` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spUpdate_Update_OutputDetail_By_Measure`(
	p_OutputId	varchar(20),
	p_MeasureId	VARCHAR(20)
    )
BEGIN
	DECLARE p_IngredientId VARCHAR(20);
	DECLARE p_MeasureQty DECIMAL(20,0);
	DECLARE no_more_rows INTEGER DEFAULT 0; 
	
	/*Select measuredetail*/
	DECLARE cur1 CURSOR FOR SELECT IngredientId, MeasureQty FROM measuredetail WHERE MeasureId = p_MeasureId;
	DECLARE CONTINUE HANDLER FOR NOT FOUND SET no_more_rows = 1;
	
	OPEN cur1;
	read_loop: LOOP
	FETCH cur1 INTO p_IngredientId, p_MeasureQty;
		IF no_more_rows = 1 THEN
			LEAVE read_loop;
		END IF;
		CALL spInsert_Output_Detail(p_OutputId, p_IngredientId, p_MeasureQty);
	END LOOP read_loop;
	CLOSE cur1;
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Final view structure for view `convert_measure_to_product`
--

/*!50001 DROP VIEW IF EXISTS `convert_measure_to_product`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `convert_measure_to_product` AS select `a`.`IngredientId` AS `IngredientId`,`a`.`MeasureQty` AS `MeasureQty`,`b`.`ProductId` AS `ProductId` from (`measuredetail` `a` join `measure` `b` on((`a`.`MeasureId` = `b`.`MeasureId`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `dem`
--

/*!50001 DROP VIEW IF EXISTS `dem`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `dem` AS select `products`.`Name` AS `Name` from (`products` join `receiptdetails`) where (`products`.`ProductId` = `receiptdetails`.`ProductId`) group by `products`.`Name` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `intake`
--

/*!50001 DROP VIEW IF EXISTS `intake`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `intake` AS select `inputdetail`.`IngredientId` AS `IngredientId`,sum(`inputdetail`.`IngredientQty`) AS `totalBuy` from `inputdetail` group by `inputdetail`.`IngredientId` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `inventory`
--

/*!50001 DROP VIEW IF EXISTS `inventory`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `inventory` AS select `a`.`IngredientId` AS `IngredientId`,`a`.`IngredientName` AS `IngredientName`,`a`.`IngredientUnit` AS `IngredientUnit`,`a`.`totalSold` AS `TotalSold`,(case when isnull(`b`.`totalBuy`) then 0 else `b`.`totalBuy` end) AS `TotalBought`,(case when isnull(`b`.`totalBuy`) then (0 - `a`.`totalSold`) else (`b`.`totalBuy` - `a`.`totalSold`) end) AS `Inventory` from (`total_ingredient_sold` `a` left join `intake` `b` on((`a`.`IngredientId` = `b`.`IngredientId`))) group by `a`.`IngredientId` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `total_ingredient_sold`
--

/*!50001 DROP VIEW IF EXISTS `total_ingredient_sold`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `total_ingredient_sold` AS select `c`.`IngredientId` AS `IngredientId`,`c`.`IngredientName` AS `IngredientName`,`c`.`IngredientMeasure` AS `IngredientMeasure`,`c`.`IngredientExchange` AS `IngredientExchange`,`c`.`IngredientUnit` AS `IngredientUnit`,(case when isnull(`a`.`totalQty`) then 0 else sum((`b`.`MeasureQty` * `a`.`totalQty`)) end) AS `totalSold` from (`ingredient` `c` left join (`totalproductsold` `a` join `convert_measure_to_product` `b` on((`a`.`ProductId` = `b`.`ProductId`))) on((`c`.`IngredientId` = `b`.`IngredientId`))) group by `c`.`IngredientId` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `totalproductsold`
--

/*!50001 DROP VIEW IF EXISTS `totalproductsold`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `totalproductsold` AS select `a`.`ProductId` AS `ProductId`,sum(`b`.`Qty`) AS `totalQty` from (`products` `a` join `receiptdetails` `b`) where (`a`.`ProductId` = `b`.`ProductId`) group by `a`.`ProductId` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-11-30  0:18:15
