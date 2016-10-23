/*
SQLyog Ultimate v11.11 (64 bit)
MySQL - 5.6.16 : Database - vvpos
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`vvpos` /*!40100 DEFAULT CHARACTER SET utf8 COLLATE utf8_unicode_ci */;

USE `vvpos`;

/*Table structure for table `objects` */

DROP TABLE IF EXISTS `objects`;

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

/*Data for the table `objects` */

insert  into `objects`(`ObjectId`,`ObjectGroup`,`ObjectType`,`FullName`,`PID`,`PIDDate`,`PIDIssue`,`DoB`,`PoB`,`PerAdd`,`TemAdd`,`Gender`,`Image`,`ProvinceId`,`Tel`,`Fax`,`Email`,`Website`,`TaxCode`,`Note`,`Status`,`CreatedBy`,`CreatedDate`,`ModifiedBy`,`ModifiedDate`) values ('01011407000002','01','01','Nguyễn Văn D_7_8','385429763','2014-06-17 18:05:46','rtrt','2014-07-17 18:05:46','sdfa','sdf','Quận Tân Bình,Hồ Chí Minh','','01011407000002_140820093430.png','25','(848) 3929 0999',NULL,'tranmanhhungcntt2@gmail.com',NULL,'b',NULL,'5','admin','2014-07-17 18:04:10','admin','2014-09-03 11:34:35'),('01011407000004','01',NULL,'Nguyễn Văn B','123','1999-05-19 16:01:05','rtrt','1989-12-13 18:20:52','Hồ Chí Minh','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ','H? Chí Minh','',NULL,'01','(848) 3929 0999',NULL,'tranmanhhungcntt@gmail.com',NULL,NULL,NULL,'5','admin','2014-07-17 18:09:05',NULL,NULL),('01011407000005','01','02','Nguyễn thị Thị','1234','1999-05-19 16:01:05','rtrtr','1989-12-13 18:20:52','Hồ Chí Minh','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ','H? Chí Minh','',NULL,'01','(848) 3929 0999',NULL,'tranmanhhungcntt@gmail.com',NULL,NULL,NULL,'5','admin','2014-07-17 18:10:19','admin','2014-09-03 11:56:34'),('01011407000006','01','01','Hùng','385429763','1999-05-19 16:01:05','rtr','1989-12-13 18:20:52','Ha Noi','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ','H? Chí Minh','\0','01011407000006_140718093722.png','02','(848) 3929 0999',NULL,'tranmanhhungcntt@gmail.com',NULL,NULL,NULL,NULL,'admin','2014-07-17 18:14:37','admin','2014-07-18 09:35:05'),('01011407000008','01','01','385429763','111','2002-06-01 16:00:43','rtrtr','1989-12-13 18:20:52','Hồ Chí Minh','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ','H? Chí Minh','\0',NULL,'58','(848) 3929 0999',NULL,'tranmanhhungcntt@gmail.com',NULL,NULL,NULL,NULL,'admin','2014-07-24 15:57:18','admin','2014-07-25 15:41:15'),('01011407000009','01','01','Trần Mạnh Hùng','385429763','2009-09-16 18:20:52','Ninh Bình','1989-12-13 18:20:52','Ninh Bình','Ninh Bình','Hồ Chí Minh','\0','01011407000009_140904180021.png','58','0949372405','0949371312','tranmanhhungcntt@gmail.com','comoiso.com.vn','385429763','','1','admin','2014-07-17 18:20:53','admin','2014-09-04 17:58:34'),('01011407000011','25','02','Nguyễn Ngọc Kim Thuận','0112232554544','2009-09-17 18:20:52','bình thu?n','1989-12-12 18:20:52','Bình Thu?n','Bình Thu?n','H? Chí Minh','','01011407000011_140725092450.png','02','01639220714','01639220714','tranmanhhungcntt@gmail.com','comoiso.com.vn','385429763','không có mô t?','1','admin','2014-07-17 18:20:53','admin','2014-09-03 11:33:25'),('01011407000012','01','01','Mai Đức Hùng','385429763','2009-09-16 18:20:52','B?c Liêu','1989-12-13 18:20:52','B?c Liêu','B?c Liêu','H? Chí Minh','\0',NULL,'58','0949372405','0949371312','tranmanhhungcntt@gmail.com','comoiso.com.vn','385429763','Hittle','1','admin','2014-07-17 18:20:53','admin','2014-09-03 11:24:04'),('01011407000013','01','01','Mai ??c Anh','385429763','2009-09-16 18:20:52','B?c Liêu','1989-12-13 18:20:52','B?c Liêu','B?c Liêu','H? Chí Minh','',NULL,'02','0949372405','0949371312','tranmanhhungcntt@gmail.com','comoiso.com.vn','385429763','','1','admin','2014-07-17 18:20:53','admin','2014-09-04 13:00:16'),('01011407000014','01','01','Mai ??c Anh','385429763','2009-09-16 18:20:52','B?c Liêu','1989-12-13 18:20:52','B?c Liêu','B?c Liêu','H? Chí Minh','\0',NULL,'58','0949372405','0949371312','tranmanhhungcntt@gmail.com','comoiso.com.vn','385429763','Hittle','1','admin','2014-07-17 18:20:53','admin','2014-07-17 18:23:59'),('01011407000015','01','01','Mai ??c Anh','385429763','2009-09-16 18:20:52','B?c Liêu','1989-12-13 18:20:52','B?c Liêu','B?c Liêu','H? Chí Minh','\0',NULL,'58','0949372405','0949371312','tranmanhhungcntt@gmail.com','comoiso.com.vn','385429763','Hittle','1','admin','2014-07-17 18:20:53','admin','2014-07-17 18:23:59'),('01011407000016','01','01','Mai ??c Anh','385429763','2009-09-16 18:20:52','B?c Liêu','1989-12-13 18:20:52','B?c Liêu','B?c Liêu','H? Chí Minh','\0',NULL,'58','0949372405','0949371312','tranmanhhungcntt@gmail.com','comoiso.com.vn','385429763','Hittle','1','admin','2014-07-17 18:20:53','admin','2014-07-17 18:23:59'),('01011407000017','01','01','Mai ??c Anh','385429763','2009-09-16 18:20:52','B?c Liêu','1989-12-13 18:20:52','B?c Liêu','B?c Liêu','H? Chí Minh','\0',NULL,'58','0949372405','0949371312','maiducanh1989@gmail.com','comoiso.com.vn','385429763','Hittle','1','admin','2014-07-17 18:20:53','admin','2014-07-17 18:23:59'),('01011407000018','01','01','Mai ??c Anh','385429763','2009-09-16 18:20:52','B?c Liêu','1989-12-13 18:20:52','B?c Liêu','B?c Liêu','H? Chí Minh','\0',NULL,'58','0949372405','0949371312','tranmanhhungcntt@gmail.com','comoiso.com.vn','385429763','Hittle','1','admin','2014-07-17 18:20:53','admin','2014-07-17 18:23:59'),('01011407000019','25','01','Hồ Ngọc Nguyên','0112232554544','1999-05-19 16:01:05','Hà Nội','1989-12-13 18:20:52','Hồ Chí Minh','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ','H? Chí Minh','\0',NULL,'25','(848) 3929 0999',NULL,'acb@acb.com.vn',NULL,NULL,NULL,'1','admin','2014-07-24 15:57:36',NULL,NULL),('01011407000021','25','02','Tạ Thành Trung','0112232554544','2009-09-19 18:20:52','Hà Nội','1990-03-16 18:20:52','Phát triển phần mềm để test-casce','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ','rrrrrr','\0',NULL,'25','rrrrrrrrrr','rrrrrrrrrr','rrrrrrrr','rrrrrrrrr','rrrrrrrrr',NULL,'1','admin','2014-07-24 15:57:46','admin','2014-08-11 17:59:48'),('01011407000023','01','01','Cao Văn Bằng','0112232554544','1999-05-19 16:01:05','Hà Nội','1989-12-13 18:20:52','Hồ Chí Minh','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ','H? Chí Minh','\0',NULL,'58','(848) 3929 0999',NULL,'acb@acb.com.vn',NULL,NULL,NULL,'1','admin','2014-07-25 09:40:26','admin','2014-07-25 09:40:50'),('01011407000024','01','01','B','0112232554544','1999-05-19 16:01:05','Hà Nội','1989-12-13 18:20:52','Hồ Chí Minh','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ','H? Chí Minh','\0',NULL,'58','(848) 3929 0999',NULL,'acb@acb.com.vn',NULL,NULL,NULL,'1','admin','2014-07-25 09:40:53','admin','2014-07-25 09:40:57'),('01011407000025','01','01','V','0112232554544','1999-05-19 16:01:05','Hà Nội','1989-12-13 18:20:52','Hồ Chí Minh','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ','H? Chí Minh','\0',NULL,'58','(848) 3929 0999',NULL,'acb@acb.com.vn',NULL,NULL,NULL,'1','admin','2014-07-25 09:40:59',NULL,NULL),('01011407000026','01','01','1','0112232554544','1999-05-19 16:01:05','Hà Nội','1989-12-13 18:20:52','Hồ Chí Minh','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ','H? Chí Minh','\0',NULL,'58','(848) 3929 0999',NULL,'acb@acb.com.vn',NULL,NULL,NULL,'1','admin','2014-07-25 09:41:01',NULL,NULL),('01011407000027','01','01','2','0112232554544','2014-07-16 09:48:19','Hà Nội','2014-07-01 09:48:19','kkkkk','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ','k','\0',NULL,'02','(848) 3929 0999',NULL,'vacb@acb.com.vn','g',NULL,'k','5','admin','2014-07-25 09:48:01','admin','2014-07-25 09:48:13'),('01011407000028','25','01','3','0112232554544','1999-05-19 16:01:05','Hà Nội','1989-12-13 18:20:52','Hồ Chí Minh','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ','H? Chí Minh',NULL,NULL,'25','(848) 3929 0999',NULL,'acb@acb.com.vn',NULL,NULL,NULL,'1','admin','2014-07-26 19:50:39','admin','2014-07-26 19:50:45'),('01011408000001','25','01','4','0112232554544','1999-05-19 16:01:05','Hà Nội','1989-12-13 18:20:52','Hồ Chí Minh','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ','H? Chí Minh',NULL,NULL,'25','(848) 3929 0999',NULL,'acb@acb.com.vn',NULL,NULL,NULL,'1','admin','2014-08-04 18:36:16','admin','2014-08-04 18:36:34'),('01011408000002','25','01','5','0112232554544','1999-05-19 16:01:05','Hồ Chí Minh','1989-12-13 18:20:52','Hồ Chí Minh','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ','H? Chí Minh',NULL,NULL,'25','(848) 3929 0999',NULL,'acb@acb.com.vn',NULL,NULL,NULL,'1','admin','2014-08-04 18:55:01','admin','2014-08-04 18:55:15'),('01011408000003','01','02','6','0112232554544','1999-05-19 16:01:05','Hồ Chí Minh','1989-12-13 18:20:52','Hồ Chí Minh','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ','H? Chí Minh',NULL,NULL,'25','(848) 3929 0999',NULL,'acb@acb.com.vn',NULL,NULL,NULL,'5','admin','2014-08-04 18:55:24','admin','2014-09-03 11:41:21'),('01011408000004','01','02','7','0112232554544','1999-05-19 16:01:05','Hồ Chí Minh','1989-12-13 18:20:52','Hồ Chí Minh','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ','H? Chí Minh',NULL,NULL,'25','(848) 3929 0999',NULL,'acb@acb.com.vn',NULL,NULL,NULL,'1','admin','2014-08-04 18:57:26',NULL,NULL),('01011408000005','01','02','x','112225554','2009-09-18 18:20:52','Hồ Chí Minh','1988-02-02 18:20:52','Bình Thuận','34, Nhất Chi Mai, Tân Bình ','34, Nhất Chi Mai, Tân Bình ',NULL,NULL,'25','ddđ','ddd','tranmanhhungcntt@gmail.com',NULL,NULL,NULL,'1','admin','2014-08-04 19:00:06','admin','2014-08-04 19:01:17'),('01011408000006','25','02','df','0112232554544','1999-05-19 16:01:05','Hồ Chí Minh','1989-12-13 18:20:52','Hồ Chí Minh','34, Nhất Chi Mai, Tân Bình ','H? Chí Minh',NULL,NULL,'5','(848) 3929 0999',NULL,'tranmanhhungcntt@gmail.com',NULL,NULL,NULL,'1','admin','2014-08-08 16:16:21',NULL,NULL),('01011408000007','25','02','sfs','0112232554544','1999-05-19 16:01:05','Hồ Chí Minh','1989-12-13 18:20:52','Hồ Chí Minh','34, Nhất Chi Mai, Tân Bình ','H? Chí Minh',NULL,NULL,'25','(848) 3929 0999',NULL,'tranmanhhungcntt@gmail.com',NULL,NULL,NULL,'1','admin','2014-08-11 17:18:35',NULL,NULL),('01011408000008','01','02','dfd','0112232554544','1999-05-19 16:01:05','Hồ Chí Minh','1989-12-13 18:20:52','Hồ Chí Minh','34, Nhất Chi Mai, Tân Bình ','H? Chí Minh',NULL,NULL,'25','(848) 3929 0999',NULL,'acb@acb.com.vn',NULL,NULL,NULL,'1','admin','2014-08-11 17:19:06','admin','2014-08-11 17:19:28'),('01011408000009','01','01','dfd','0112232554544','1999-05-19 16:01:05','Hồ Chí Minh','1989-12-13 18:20:52','Hồ Chí Minh','34, Nhất Chi Mai, Tân Bình ','H? Chí Minh',NULL,NULL,'25','(848) 3929 0999',NULL,'tranmanhhungcntt@gmail.com',NULL,NULL,NULL,'1','admin','2014-08-11 17:24:59',NULL,NULL),('01011408000010','01','01','sfsfsđf','0112232554544','1999-05-19 16:01:05','Hồ Chí Minh','1989-12-13 18:20:52','Hồ Chí Minh','34, Nhất Chi Mai, Tân Bình ','H? Chí Minh',NULL,NULL,'25','(848) 3929 0999',NULL,'tranmanhhungcntt@gmail.com',NULL,NULL,NULL,'1','admin','2014-08-11 17:25:11',NULL,NULL),('01011408000011','01','01','sfsdf','0112232554544','2014-06-02 16:44:20','Hồ Chí Minh','2014-01-24 16:44:20','Liên Hương - Tuy Phong','Test-Demo-Thuận','H? Chí Minh',NULL,NULL,'25','(848) 3929 0999',NULL,'acb@acb.com.vn',NULL,NULL,NULL,'1','admin','2014-08-11 17:34:48',NULL,NULL),('01011408000012','01','01','dfdfdg','0112232554544','2009-08-05 18:20:52','Hồ Chí Minh','1989-12-23 18:20:52','ggggggggggg','48/12 - Liên Hương - Tuy Phong - Bình Thuận','gggggggg','\0',NULL,'02','dddd','dddddd','acb@acb.com.vn','dddddd',NULL,NULL,'1','admin','2014-08-11 17:49:09','admin','2014-08-11 17:54:47'),('01011408000013','01','01','fdfdfsđfsđ','0112232554544','1999-05-19 16:01:05','Hồ Chí Minh','1989-12-13 18:20:52','Hồ Chí Minh','48/12 - Liên Hương - Tuy Phong - Bình Thuận','H? Chí Minh','\0',NULL,'25','(848) 3929 0999',NULL,'acb@acb.com.vn',NULL,NULL,NULL,'5','admin','2014-08-11 18:04:38',NULL,NULL),('01011408000014','25','02','g','b','1999-05-19 16:01:05','c','1989-12-13 18:20:52','Bình Thu?n','e','f','',NULL,'58','1','2','tranmanhhungcntt@gmail.com','4','5','pppo','5','admin','2014-08-12 14:06:37','admin','2014-08-12 14:06:51'),('01011408000015','25','02','jhgf','081582910808','2014-08-21 14:03:40','Liên Hương - Tuy Phong - Bình Thuận','2014-09-20 14:03:40','Liên Hương, tuy phong, bình thuận','48/12 - Liên Hương - Tuy Phong - Bình Thuận','H? Chí Minh',NULL,NULL,'25','(848) 3929 0999',NULL,'acb@acb.com.vn',NULL,NULL,'ffffffff',NULL,'admin','2014-08-12 14:09:11',NULL,NULL),('01011408000016','25','02','iuy','0112232554544','1999-05-19 16:01:05','Hồ Chí Minh','1989-12-13 18:20:52','Hồ Chí Minh','48/12 - Liên Hương - Tuy Phong - Bình Thuận','H? Chí Minh',NULL,NULL,'25','(848) 3929 0999',NULL,'acb@acb.com.vn',NULL,NULL,NULL,'1','admin','2014-08-12 17:09:24',NULL,NULL),('01011408000017','01','01','sf','545',NULL,'fsf',NULL,'sfsd','fsd','sfs','\0',NULL,'02','423','423','24','4234',NULL,'sfs','1','admin','2014-08-22 13:36:30',NULL,NULL),('01011408000018','01','01','Hùng','23456',NULL,'Ninh Binh',NULL,'Ninh Binh','Hà Nội','Hồ Chí Minh','\0','01011408000018_140822143459.png','02','2345','1234','tranmanhhungcntt2@gmail.com','kdjfkdjf','456','bala bala','1','admin','2014-08-22 14:32:32',NULL,NULL),('01011409000001','01','01','','147474','2014-09-24 14:07:42','','2014-10-03 14:07:42','Nơi sinh','ggd','gdgdg','\0',NULL,'25','','','','','','gdđ','1','admin','2014-09-04 14:12:27','admin','2014-09-04 14:13:27'),('01011411000001','01','01','Huỳnh Thị Ngọc Dung','273268729',NULL,'',NULL,'Đồng Nai','Long Điền, Bà Rịa Vũng Tàu','121 Hoàng Hoa Thám, P . 13, Q. Tân Bình, Tp. HCM','','01011411000001_141127124430.jpg','02','0989870091','','dung_htn@vietvang.net','Vietvang.net','000 biết','Test lần 1','1','admin','2014-11-26 13:49:20','admin','2014-11-27 12:41:01'),('01011412000001','01','01','HUynh Dung1',NULL,NULL,NULL,NULL,NULL,NULL,NULL,'','01011412000001_141202154059.jpg','02',NULL,NULL,'dung_htn@vietvang.net',NULL,NULL,NULL,'1','admin','2014-12-02 15:37:02',NULL,NULL),('01011412000002','01','01','Nguyễn Văn C',NULL,NULL,NULL,NULL,NULL,NULL,NULL,'\0','01011412000002_141203153522.jpg','02','0123456789',NULL,NULL,NULL,NULL,NULL,'1','admin','2014-12-03 15:31:39',NULL,NULL),('01021409000001','01','02','Nguyen ngam','04','2000-08-02 16:01:05','201','1990-07-12 18:20:52','Binh_Thuan_12','1241','dd','','01021409000001_140903115326.png','25',NULL,NULL,NULL,NULL,NULL,'d','1','admin','2014-09-03 11:47:21','admin','2014-09-03 11:51:38'),('03011408000001','03','01','tdt10','01','2013-03-02 18:05:46',NULL,'2008-05-04 18:05:46','Nơi sinh 06','dccd07','dctc08','\0','03011408000001_140820094037.png','58','11','12','13@gmail.com','http://14','15','Mô tả 09','5','admin','2014-08-20 09:38:24',NULL,NULL),('03011408000002','03','01','dc_19','11','2014-08-12 13:32:35','13','2014-08-14 13:32:35','Nơi sinh_15','Dctt_16','dctr_17','',NULL,'25','1112','d','dddd','dddd','ddđ','Phát triển_18','1','admin','2014-08-22 13:35:11','admin','2014-08-22 13:36:44'),('03011408000003','03','01',NULL,'11','2009-09-12 18:20:52','Nơi cấp_13','1990-03-14 18:20:52','Nowissinh_15','dctt_16','dctt_17','\0',NULL,'02',NULL,'dđ','dddđd','d','ddđ','Mota_18',NULL,'admin','2014-08-22 13:41:09',NULL,NULL),('03011408000004','03','01','Hùng','45454','2014-01-13 14:16:59','Hà Nội','1997-06-22 14:16:59','Hà Nội','Hà Nội','Hồ Chí Minh','\0','03011408000004_140822141844.png','25','5456454','323454','tranmanhhungcntt2@gmail.com','fsdfdsf','344','Rất yêu đời!','1','admin','2014-08-22 14:16:17',NULL,NULL),('03011408000005','03','01','Thuận','3453',NULL,'Bình Thuận','1989-06-22 14:16:59','Bình Thuận','Bình Thuận','Hồ Chí Minh','\0',NULL,'02',NULL,NULL,NULL,NULL,NULL,NULL,'1','admin','2014-08-22 14:25:00',NULL,NULL),('03011408000006','03','01',NULL,NULL,'2014-04-22 14:44:35',NULL,'2014-05-05 14:44:35',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'1','admin','2014-08-22 14:42:30',NULL,NULL),('03011408000007','03','01',NULL,NULL,'2014-08-26 16:04:16',NULL,'2014-08-26 16:04:16',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'1','admin','2014-08-26 16:02:16',NULL,NULL),('03021409000001','03','02',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'\0',NULL,'58',NULL,'26666','penamkimthuan@yahoo.com','ddd',NULL,'Đang phát triển','5','admin','2014-09-04 14:14:43',NULL,NULL),('0901000001','09','01','Nguyen Tea','0112232554544','1999-05-19 16:01:05','Ninh Bình','1980-09-11 16:20:49','HCM','HCM','HCM','\0','user3.png','02','+84901254789',NULL,'test@gmail.com','',NULL,NULL,'1','admin','2014-07-14 16:22:06',NULL,NULL),('0901000002','09','01','Lý Nh??c ??ng','0112232554544','1999-05-19 16:01:05','Ninh Bình','1968-04-21 16:20:49','HK','HK','HK','','user4.png','25','+669145646472',NULL,'test@gmail.com','',NULL,NULL,'1','admin','2014-07-14 16:22:06',NULL,NULL),('09021407000001','09','02','kjh','1111111111111111111111111111111111111111','1999-05-19 16:01:05','Ninh Bình',NULL,'Hồ Chí Minh','48/12 - Liên Hương - Tuy Phong - Bình Thuận','H? Chí Minh',NULL,NULL,'25','(848) 3929 0999',NULL,'acb@acb.com.vn',NULL,NULL,NULL,NULL,'admin','2014-07-24 17:15:00',NULL,NULL),('25021407000001','25','02','uyt','0112232554544','2009-09-17 18:20:52','Ninh Bình','1989-12-12 18:20:52','Hồ Chí Minh','48/12 - Liên Hương - Tuy Phong - Bình Thuận','H? Chí Minh','',NULL,'02','(848) 3929 0999',NULL,'tranmanhhungcntt@gmail.com',NULL,NULL,NULL,'0','admin','2014-07-25 09:31:15',NULL,NULL),('25021408000001','25','02','Hùng','123456',NULL,NULL,NULL,'Hà Nội','Hà Nội','Hồ Chí Minh','\0','25021408000001_140822101756.png','25','1234567','1234567','1234567','1234567','1234567',NULL,'1','admin','2014-08-22 10:15:31',NULL,NULL),('45011408000001','45','01',NULL,'12','2009-09-13 18:20:52','Nơi Sinh','1990-03-14 18:20:52','ddđ','dddd','ddd','\0',NULL,'25',NULL,NULL,NULL,NULL,NULL,'dddđ',NULL,'admin','2014-08-22 13:43:38',NULL,NULL),('4502000001','45','02','Ngân hàng Á Châu - ACB','0112232554544','1999-05-19 16:01:05','Ninh Bình','1989-12-13 18:20:52','Hồ Chí Minh','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ',NULL,'user5.png','02','(848) 3929 0999','(848) 3839 9885','acb@acb.com.vn','http://www.acb.com.vn/',NULL,'Telex: 813158 ACB VT - SWIFT Code: ASCBVNVX','0','admin','2014-07-15 17:24:46',NULL,NULL),('4502000002','45','02','Ngân hàng Á Châu - ACB','0112232554544','1999-05-19 16:01:05','Ninh Bình','1989-12-13 18:20:52','Hồ Chí Minh','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ',NULL,'user5.png','02','(848) 3929 0999','(848) 3839 9885','tranmanhhungcntt@gmail.com','http://www.acb.com.vn/',NULL,'Telex: 813158 ACB VT - SWIFT Code: ASCBVNVX','0','admin','2014-07-15 17:24:46',NULL,NULL),('4502000003','45','02','Ngân hàng Á Châu - ACB','0112232554544','1999-05-19 16:01:05','Ninh Bình','1989-12-13 18:20:52','Hồ Chí Minh','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ','','user5.png','02','(848) 3929 0999','(848) 3839 9885','tranmanhhungcntt@gmail.com','http://www.acb.com.vn/',NULL,'Telex: 813158 ACB VT - SWIFT Code: ASCBVNVX','0','admin','2014-07-15 17:24:46','admin','2014-08-11 09:24:11'),('4502000004','45','02','Ngân hàng Á Châu - ACB','0112232554544','1999-05-19 16:01:05','Ninh Bình','1989-12-13 18:20:52','Hồ Chí Minh','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ',NULL,'user5.png','02','(848) 3929 0999','(848) 3839 9885','tranmanhhungcntt@gmail.com','http://www.acb.com.vn/',NULL,'Telex: 813158 ACB VT - SWIFT Code: ASCBVNVX','0','admin','2014-07-15 17:24:46',NULL,NULL),('4502000005','45','02','Ngân hàng Á Châu - ACB','0112232554544',NULL,'Ninh Bình','1989-12-13 18:20:52','Hồ Chí Minh','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ',NULL,'user5.png','02','(848) 3929 0999','(848) 3839 9885','tranmanhhungcntt@gmail.com','http://www.acb.com.vn/',NULL,'Telex: 813158 ACB VT - SWIFT Code: ASCBVNVX','0','admin','2014-07-15 17:24:46',NULL,NULL),('4502000006','45','02','Ngân hàng Á Châu - ACB','0112232554544','1999-05-19 16:01:05','Ninh Bình','1989-12-13 18:20:52','Hồ Chí Minh','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ','442 Nguy?n Th? Minh Khai, Q.3, TP HCM ',NULL,'user5.png','02','(848) 3929 0999','(848) 3839 9885','tranmanhhungcntt@gmail.com','http://www.acb.com.vn/',NULL,'Telex: 813158 ACB VT - SWIFT Code: ASCBVNVX','0','admin','2014-07-15 17:24:46',NULL,NULL),('45021407000001','45','02','d','434','1999-05-19 16:01:05','ninh bình','1989-12-13 18:20:52','sdfs','sdf','H? Chí Minh','\0','45021407000001_140723202353.png','02','(848) 3929 0999',NULL,'tranmanhhungcntt@gmail.com',NULL,NULL,NULL,'5','admin','2014-07-23 20:21:11',NULL,NULL),('admin','01','01','Huynh Dung','0112232554544','1999-05-19 16:01:05','Ninh Bình','1989-12-13 18:20:52','Hồ Chí Minh','48/12 - Liên Hương - Tuy Phong - Bình Thuận','H? Chí Minh',NULL,'xuka.png','58','(848) 3929 0999',NULL,'acb@acb.com.vn',NULL,NULL,NULL,'1','admin','2014-07-15 17:24:57',NULL,NULL);

/* Procedure structure for procedure `spInsert_Objects` */

/*!50003 DROP PROCEDURE IF EXISTS  `spInsert_Objects` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`admin`@`%` PROCEDURE `spInsert_Objects`(
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
    END */$$
DELIMITER ;

/* Procedure structure for procedure `spSelect_Object_By_ObjectId` */

/*!50003 DROP PROCEDURE IF EXISTS  `spSelect_Object_By_ObjectId` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`admin`@`%` PROCEDURE `spSelect_Object_By_ObjectId`(
	p_ObjectId varchar(20)
    )
BEGIN
	select *
	from objects
	where `ObjectId` = p_ObjectId;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `spSelect_ObjectId_By_UserId` */

/*!50003 DROP PROCEDURE IF EXISTS  `spSelect_ObjectId_By_UserId` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`admin`@`%` PROCEDURE `spSelect_ObjectId_By_UserId`(
	p_UserId varchar(100)
    )
BEGIN
	select `ObjectId`
	from users
	where `UserId` = p_UserId;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `spSelect_ObjectId_By_UserId1` */

/*!50003 DROP PROCEDURE IF EXISTS  `spSelect_ObjectId_By_UserId1` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`admin`@`%` PROCEDURE `spSelect_ObjectId_By_UserId1`(
	p_UserId varchar(100)
    )
BEGIN
	select a.*
	from `objects` a inner join `users` b on a.`ObjectId`=b.`ObjectId`
	where b.`UserId` = p_UserId;
    END */$$
DELIMITER ;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
