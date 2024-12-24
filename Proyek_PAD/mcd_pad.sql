/*
SQLyog Community v13.2.1 (64 bit)
MySQL - 10.4.32-MariaDB : Database - mcd_pad
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`mcd_pad` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci */;

USE `mcd_pad`;

/*Table structure for table `checklog` */

DROP TABLE IF EXISTS `checklog`;

CREATE TABLE `checklog` (
  `log_id` int(11) NOT NULL AUTO_INCREMENT,
  `crew_id` int(11) NOT NULL,
  `start_time` datetime NOT NULL,
  `end_time` datetime NOT NULL,
  PRIMARY KEY (`log_id`),
  KEY `crew_id` (`crew_id`),
  CONSTRAINT `checklog_ibfk_1` FOREIGN KEY (`crew_id`) REFERENCES `karyawan` (`crew_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `checklog` */

/*Table structure for table `customers` */

DROP TABLE IF EXISTS `customers`;

CREATE TABLE `customers` (
  `id_customer` int(11) NOT NULL AUTO_INCREMENT,
  `nama_customer` varchar(50) NOT NULL,
  `nomor_telepon` varchar(15) DEFAULT NULL,
  `email_customer` varchar(50) DEFAULT NULL,
  `alamat_customer` text DEFAULT NULL,
  PRIMARY KEY (`id_customer`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `customers` */

/*Table structure for table `diskon` */

DROP TABLE IF EXISTS `diskon`;

CREATE TABLE `diskon` (
  `diskon_id` int(11) NOT NULL AUTO_INCREMENT,
  `diskon_kode` varchar(255) NOT NULL,
  `diskon_name` text NOT NULL,
  PRIMARY KEY (`diskon_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `diskon` */

insert  into `diskon`(`diskon_id`,`diskon_kode`,`diskon_name`) values 
(1,'DISC10','10% off'),
(2,'DISC20','20% off'),
(3,'DISC50','50% off');

/*Table structure for table `extra_charge` */

DROP TABLE IF EXISTS `extra_charge`;

CREATE TABLE `extra_charge` (
  `extra_charge_id` int(11) NOT NULL AUTO_INCREMENT,
  `extra_name` varchar(255) NOT NULL,
  PRIMARY KEY (`extra_charge_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `extra_charge` */

/*Table structure for table `extra_charge_trans` */

DROP TABLE IF EXISTS `extra_charge_trans`;

CREATE TABLE `extra_charge_trans` (
  `transaksi_id` int(11) NOT NULL,
  `extra_charge_id` int(11) NOT NULL,
  KEY `transaksi_id` (`transaksi_id`),
  KEY `extra_charge_id` (`extra_charge_id`),
  CONSTRAINT `extra_charge_trans_ibfk_1` FOREIGN KEY (`transaksi_id`) REFERENCES `transaksi` (`transaksi_id`),
  CONSTRAINT `extra_charge_trans_ibfk_2` FOREIGN KEY (`extra_charge_id`) REFERENCES `extra_charge` (`extra_charge_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `extra_charge_trans` */

/*Table structure for table `karyawan` */

DROP TABLE IF EXISTS `karyawan`;

CREATE TABLE `karyawan` (
  `crew_id` int(11) NOT NULL AUTO_INCREMENT,
  `nama` varchar(50) NOT NULL,
  `sex` enum('L','P') NOT NULL,
  `umur` int(11) NOT NULL,
  `nomor_telepon` varchar(15) NOT NULL,
  `password` varchar(10) NOT NULL,
  `role_id` int(11) NOT NULL,
  PRIMARY KEY (`crew_id`),
  KEY `role_id` (`role_id`),
  CONSTRAINT `karyawan_ibfk_1` FOREIGN KEY (`role_id`) REFERENCES `role` (`role_id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `karyawan` */

insert  into `karyawan`(`crew_id`,`nama`,`sex`,`umur`,`nomor_telepon`,`password`,`role_id`) values 
(1,'a','L',70,'081326507575','b',2),
(2,'Irvin','L',19,'085850141312','irvincs',2),
(3,'Jason','L',19,'081259136877','jasonjaj',2),
(4,'Hubert','L',19,'081232328000','hubertsw',2),
(5,'test','L',69,'081234567890','123',1);

/*Table structure for table `menu` */

DROP TABLE IF EXISTS `menu`;

CREATE TABLE `menu` (
  `id_menu` varchar(10) NOT NULL,
  `nama_menu` varchar(100) NOT NULL,
  `harga_menu` decimal(10,2) NOT NULL,
  `quantity` int(11) NOT NULL,
  `kategori` enum('Makanan','Minuman','Snack','Lainnya') NOT NULL,
  PRIMARY KEY (`id_menu`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `menu` */

insert  into `menu`(`id_menu`,`nama_menu`,`harga_menu`,`quantity`,`kategori`) values 
('MAKAN001','Big Mac',50000.00,50,'Makanan'),
('MAKAN002','Cheeseburger',30000.00,40,'Makanan'),
('MAKAN003','Quarter Pounder',45000.00,30,'Makanan'),
('MAKAN004','McChicken',35000.00,35,'Makanan'),
('MAKAN005','Filet-O-Fish',40000.00,25,'Makanan'),
('MAKAN006','Chicken Nuggets Happy Meal',25000.00,70,'Makanan'),
('MAKAN007','Cheeseburger Happy Meal',25000.00,80,'Makanan'),
('MAKAN008','Big Mac Combo',70000.00,40,'Makanan'),
('MAKAN009','Cheeseburger Combo',55000.00,60,'Makanan'),
('MAKAN010','Quarter Pounder Combo',65000.00,35,'Makanan'),
('MAKAN011','McChicken Combo',60000.00,45,'Makanan'),
('MAKAN012','Filet-O-Fish Combo',60000.00,25,'Makanan'),
('MAKAN013','Chicken Wrap',35000.00,50,'Makanan'),
('MAKAN014','Spicy Chicken Wrap',38000.00,45,'Makanan'),
('MAKAN015','Pancakes',25000.00,30,'Makanan'),
('MAKAN016','Egg McMuffin',35000.00,40,'Makanan'),
('MAKAN017','Sausage McMuffin',35000.00,35,'Makanan'),
('MAKAN018','Breakfast Burrito',30000.00,50,'Makanan'),
('MAKAN019','Breakfast Platter',40000.00,20,'Makanan'),
('MAKAN020','Double Cheeseburger',40000.00,50,'Makanan'),
('MAKAN021','Triple Cheeseburger',50000.00,40,'Makanan'),
('MAKAN022','Chicken Deluxe',45000.00,35,'Makanan'),
('MAKAN023','Deluxe Quarter Pounder',50000.00,25,'Makanan'),
('MAKAN024','Angus Beef Burger',70000.00,20,'Makanan'),
('MAKAN025','Grilled Chicken Sandwich',45000.00,30,'Makanan'),
('MAKAN026','Crispy Chicken Sandwich',40000.00,45,'Makanan'),
('MAKAN027','Grilled Wrap',38000.00,25,'Makanan'),
('MAKAN028','Classic Cheeseburger',32000.00,35,'Makanan'),
('MAKAN029','Spicy Chicken McDeluxe',45000.00,20,'Makanan'),
('MAKAN030','Chicken Fillet Spicy',42000.00,30,'Makanan'),
('MAKAN031','Fish Fillet Deluxe',42000.00,20,'Makanan'),
('MAKAN032','Vegetarian Wrap',35000.00,30,'Makanan'),
('MAKAN033','Seasonal Burger',50000.00,25,'Makanan'),
('MAKAN034','Big Tasty Burger',70000.00,15,'Makanan'),
('MINUM001','Oreo McFlurry',18000.00,65,'Minuman'),
('MINUM002','Vanilla Sundae',15000.00,55,'Minuman'),
('MINUM003','Chocolate Sundae',15000.00,50,'Minuman'),
('MINUM004','Strawberry Sundae',15000.00,40,'Minuman'),
('MINUM005','Coke Large',12000.00,100,'Minuman'),
('MINUM006','Coke Medium',10000.00,120,'Minuman'),
('MINUM007','Coke Small',8000.00,150,'Minuman'),
('MINUM008','Sprite Large',12000.00,90,'Minuman'),
('MINUM009','Sprite Medium',10000.00,110,'Minuman'),
('MINUM010','Sprite Small',8000.00,130,'Minuman'),
('MINUM011','Iced Coffee',15000.00,50,'Minuman'),
('MINUM012','Hot Coffee',15000.00,60,'Minuman'),
('MINUM013','Iced Latte',18000.00,40,'Minuman'),
('MINUM014','Hot Latte',18000.00,30,'Minuman'),
('MINUM015','Iced Chocolate',18000.00,45,'Minuman'),
('MINUM016','Hot Chocolate',18000.00,50,'Minuman'),
('MINUM017','McFlurry M&M',20000.00,50,'Minuman'),
('MINUM018','Strawberry Shake',20000.00,40,'Minuman'),
('MINUM019','Chocolate Shake',20000.00,40,'Minuman'),
('MINUM020','Vanilla Shake',20000.00,40,'Minuman'),
('MINUM021','Caramel Sundae',18000.00,50,'Minuman'),
('MINUM022','Happy Meal Drink',12000.00,70,'Minuman'),
('MINUM023','Seasonal McFlurry',22000.00,50,'Minuman'),
('MINUM024','Special Shake',25000.00,40,'Minuman'),
('MINUM025','Coke Float',18000.00,50,'Minuman'),
('MINUM026','Sprite Float',18000.00,50,'Minuman'),
('MINUM027','Mango Smoothie',25000.00,60,'Minuman'),
('MINUM028','Strawberry Smoothie',25000.00,60,'Minuman'),
('SNACK001','McNuggets 6 pcs',25000.00,60,'Snack'),
('SNACK002','McNuggets 9 pcs',35000.00,50,'Snack'),
('SNACK003','Large Fries',20000.00,70,'Snack'),
('SNACK004','Medium Fries',15000.00,80,'Snack'),
('SNACK005','Small Fries',10000.00,100,'Snack'),
('SNACK006','Apple Pie',12000.00,90,'Snack'),
('SNACK007','Chicken Tenders 3 pcs',25000.00,60,'Snack'),
('SNACK008','Chicken Tenders 5 pcs',40000.00,50,'Snack'),
('SNACK009','Hash Brown',15000.00,70,'Snack'),
('SNACK010','McNuggets Bucket',70000.00,15,'Snack'),
('SNACK011','Ice Cream Cone',8000.00,100,'Snack'),
('SNACK012','French Fries with Cheese',25000.00,40,'Snack'),
('SNACK013','French Fries with BBQ',25000.00,30,'Snack'),
('SNACK014','Happy Meal Ice Cream',15000.00,60,'Snack'),
('SNACK015','Corn Cup',12000.00,80,'Snack'),
('SNACK016','Happy Meal Fries',10000.00,90,'Snack'),
('SNACK017','Ice Cream Cup',10000.00,85,'Snack'),
('SNACK018','Chicken Nugget Deluxe',38000.00,40,'Snack'),
('SNACK019','Spicy Tenders',30000.00,60,'Snack'),
('SNACK020','BBQ Chicken Wings',40000.00,30,'Snack'),
('SNACK021','Sweet & Sour Wings',38000.00,40,'Snack'),
('SNACK022','Chicken Soup',25000.00,60,'Snack'),
('SNACK023','Choco Dip Cone',10000.00,70,'Snack'),
('SNACK024','Baked Apple Pie',15000.00,50,'Snack'),
('SNACK025','Fried Banana Pie',15000.00,40,'Snack'),
('SNACK026','Spicy Chicken McNuggets',40000.00,30,'Snack'),
('SNACK027','Seasonal Fries',25000.00,30,'Snack'),
('SNACK028','Spicy Fries',30000.00,40,'Snack');

/*Table structure for table `payment_method` */

DROP TABLE IF EXISTS `payment_method`;

CREATE TABLE `payment_method` (
  `payment_id` int(11) NOT NULL AUTO_INCREMENT,
  `nama_payment` varchar(255) NOT NULL,
  PRIMARY KEY (`payment_id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `payment_method` */

insert  into `payment_method`(`payment_id`,`nama_payment`) values 
(1,'tunai'),
(2,'gopay'),
(3,'ovo'),
(4,'bca'),
(5,'mandiri'),
(6,'bni'),
(7,'dana');

/*Table structure for table `payment_trans` */

DROP TABLE IF EXISTS `payment_trans`;

CREATE TABLE `payment_trans` (
  `transaksi_id` int(11) NOT NULL,
  `payment_method` int(11) NOT NULL,
  `total` int(11) NOT NULL,
  KEY `transaksi_id` (`transaksi_id`),
  KEY `payment_method` (`payment_method`),
  CONSTRAINT `payment_trans_ibfk_1` FOREIGN KEY (`transaksi_id`) REFERENCES `transaksi` (`transaksi_id`),
  CONSTRAINT `payment_trans_ibfk_2` FOREIGN KEY (`payment_method`) REFERENCES `payment_method` (`payment_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `payment_trans` */

/*Table structure for table `role` */

DROP TABLE IF EXISTS `role`;

CREATE TABLE `role` (
  `role_id` int(11) NOT NULL AUTO_INCREMENT,
  `role_name` varchar(255) NOT NULL,
  PRIMARY KEY (`role_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `role` */

insert  into `role`(`role_id`,`role_name`) values 
(1,'manager'),
(2,'kasir');

/*Table structure for table `transaksi` */

DROP TABLE IF EXISTS `transaksi`;

CREATE TABLE `transaksi` (
  `transaksi_id` int(11) NOT NULL AUTO_INCREMENT,
  `quantity` int(11) NOT NULL,
  `employee_id` int(11) NOT NULL,
  `menu_id` varchar(10) NOT NULL,
  `status` enum('berhasil','gagal') NOT NULL,
  `diskon_id` int(11) NOT NULL,
  `total_transaksi` int(11) NOT NULL,
  `queue` int(11) NOT NULL,
  PRIMARY KEY (`transaksi_id`),
  KEY `employee_id` (`employee_id`),
  KEY `menu_id` (`menu_id`),
  KEY `diskon_id` (`diskon_id`),
  CONSTRAINT `transaksi_ibfk_1` FOREIGN KEY (`employee_id`) REFERENCES `karyawan` (`crew_id`),
  CONSTRAINT `transaksi_ibfk_3` FOREIGN KEY (`menu_id`) REFERENCES `menu` (`id_menu`),
  CONSTRAINT `transaksi_ibfk_4` FOREIGN KEY (`diskon_id`) REFERENCES `diskon` (`diskon_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `transaksi` */

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
