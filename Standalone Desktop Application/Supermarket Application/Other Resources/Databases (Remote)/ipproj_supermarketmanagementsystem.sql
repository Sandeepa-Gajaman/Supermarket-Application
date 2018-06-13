-- phpMyAdmin SQL Dump
-- version 4.0.10.18
-- https://www.phpmyadmin.net
--
-- Host: localhost:3306
-- Generation Time: Feb 15, 2018 at 05:56 AM
-- Server version: 5.6.35
-- PHP Version: 5.6.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `illumip_supermarketmanagementsystem`
--

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`illumip`@`localhost` PROCEDURE `select_all_items`()
begin
select * from Item;
end$$

CREATE DEFINER=`illumip`@`localhost` PROCEDURE `select_items_by_brand`(in brand varchar(25))
begin
select * from Item where item_brand like concat ('%', brand, '%');
end$$

CREATE DEFINER=`illumip`@`localhost` PROCEDURE `select_items_by_category`(IN `category` VARCHAR(25))
begin
select * from Item where item_category 
like concat ('%', category, '%');
end$$

CREATE DEFINER=`illumip`@`localhost` PROCEDURE `select_items_by_code`(IN `code` INT(7))
begin
select * from Item where item_code like concat ('%', code, '%');
end$$

CREATE DEFINER=`illumip`@`localhost` PROCEDURE `select_items_by_name`(in name varchar(25))
begin
select * from Item where item_name like concat ('%', name, '%');
end$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `Item`
--
-- Creation: Feb 11, 2018 at 07:30 AM
-- Last update: Feb 11, 2018 at 07:32 AM
--

CREATE TABLE IF NOT EXISTS `Item` (
  `item_code` int(7) NOT NULL AUTO_INCREMENT COMMENT 'Unique identifier for the item table.',
  `item_category` varchar(25) NOT NULL,
  `item_brand` varchar(25) NOT NULL,
  `item_name` varchar(25) NOT NULL,
  `item_description` varchar(50) DEFAULT NULL,
  `item_volume` varchar(10) DEFAULT NULL,
  `item_quantity` int(6) NOT NULL,
  `item_unit_price` decimal(9,2) NOT NULL,
  PRIMARY KEY (`item_code`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 COMMENT='Contains all the items offered by the supermarket.' AUTO_INCREMENT=2 ;

--
-- Dumping data for table `Item`
--

INSERT INTO `Item` (`item_code`, `item_category`, `item_brand`, `item_name`, `item_description`, `item_volume`, `item_quantity`, `item_unit_price`) VALUES
(1, 'Soap', 'Sunlight', 'Sunlight yellow 50g', 'Sunlight yellow laundry soap', '50g', 200, '35.00');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
