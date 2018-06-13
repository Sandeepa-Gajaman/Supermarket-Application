-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 25, 2018 at 11:14 AM
-- Server version: 10.1.26-MariaDB
-- PHP Version: 7.1.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `illumip_supermarketmanagementsystem`
--

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `add_quantity` (IN `param_item_code` INT(7), IN `param_item_quantity` INT(6))  begin 
update item set item_quantity= item_quantity+ param_item_quantity where item_code= param_item_code;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `get_details` (IN `parameter_mobile_number` VARCHAR(13), OUT `parameter_total_purchase_value` DECIMAL(9,2))  BEGIN
select total_purchase_value into parameter_total_purchase_value from customer where mobile_number=parameter_mobile_number;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `get_item_inventory_quantity` (IN `param_item_code` INT(7), OUT `quantity` INT(6))  begin select count(item_code) into quantity from Item where item_code= param_item_code; end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `select_all_items` ()  begin
select * from Item;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `select_items_by_brand` (IN `brand` VARCHAR(25))  begin
select * from Item where item_brand like concat ('%', brand, '%');
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `select_items_by_category` (IN `category` VARCHAR(25))  begin
select * from Item where item_category 
like concat ('%', category, '%');
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `select_items_by_code` (IN `code` INT(7))  begin
select * from Item where item_code like concat ('%', code, '%');
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `select_items_by_name` (IN `name` VARCHAR(25))  begin
select * from Item where item_name like concat ('%', name, '%');
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `set_item_inventory_quantity` (IN `param_item_code` INT(7), IN `param_item_quantity` INT(6))  begin update Item set item_quantity= param_item_quantity where item_code= param_item_code; end$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `customer_id` int(10) NOT NULL COMMENT 'Unique identifier for the Customer table.',
  `first_name` varchar(25) NOT NULL,
  `last_name` varchar(25) DEFAULT NULL,
  `mobile_number` varchar(13) NOT NULL,
  `date_of_registration` date NOT NULL,
  `shop_count` int(10) NOT NULL DEFAULT '0',
  `total_purchase_value` decimal(9,2) NOT NULL DEFAULT '0.00'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`customer_id`, `first_name`, `last_name`, `mobile_number`, `date_of_registration`, `shop_count`, `total_purchase_value`) VALUES
(1, 'Hitan', 'Sirisena', '0772729729', '2018-02-22', 0, '14.50'),
(2, 'None', 'None', '0771234567', '2018-02-01', 0, '0.00');

-- --------------------------------------------------------

--
-- Table structure for table `item`
--

CREATE TABLE `item` (
  `item_code` int(7) NOT NULL COMMENT 'Unique identifier for the item table.',
  `item_category` varchar(25) NOT NULL,
  `item_brand` varchar(25) NOT NULL,
  `item_name` varchar(25) NOT NULL,
  `item_description` varchar(50) DEFAULT NULL,
  `item_volume` varchar(10) DEFAULT NULL,
  `item_quantity` int(6) NOT NULL,
  `item_unit_price` decimal(9,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Contains all the items offered by the supermarket.';

--
-- Dumping data for table `item`
--

INSERT INTO `item` (`item_code`, `item_category`, `item_brand`, `item_name`, `item_description`, `item_volume`, `item_quantity`, `item_unit_price`) VALUES
(1, 'Soap', 'Sunlight', 'Sunlight yellow 50g', 'Sunlight yellow laundry soap', '50g', 39, '35.00'),
(2, 'Soap', 'Pears', 'Pears baby blue', 'Pears baby blue with extra softness', '50g', 22, '45.00'),
(3, 'Exercise Book', 'Atlas', 'Atlas CR-3 Single 80', 'Atlas CR-3 Single 80 page premium', '80 pages', 1, '75.00'),
(4, 'Exercise Book', 'Promate', 'A4 80 pages Single', 'Single ruled, 80 page CR exercise book.', '80 pages', 16, '110.00');

-- --------------------------------------------------------

--
-- Table structure for table `order_item_table`
--

CREATE TABLE `order_item_table` (
  `order_id` int(10) NOT NULL,
  `item_code` int(7) NOT NULL,
  `quantity` int(6) NOT NULL,
  `price` decimal(9,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `order_item_table`
--

INSERT INTO `order_item_table` (`order_id`, `item_code`, `quantity`, `price`) VALUES
(1, 1, 2, '70.00'),
(1, 4, 3, '330.00');

-- --------------------------------------------------------

--
-- Table structure for table `order_table`
--

CREATE TABLE `order_table` (
  `order_id` int(10) NOT NULL COMMENT 'Unique identifier for the Order table.',
  `date` date NOT NULL,
  `time` time NOT NULL,
  `employee_id` int(5) DEFAULT '0',
  `customer_id` int(10) DEFAULT '0',
  `total_price` decimal(9,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `order_table`
--

INSERT INTO `order_table` (`order_id`, `date`, `time`, `employee_id`, `customer_id`, `total_price`) VALUES
(1, '2018-02-17', '21:26:00', 0, 1, '400.00');

-- --------------------------------------------------------

--
-- Table structure for table `payment`
--

CREATE TABLE `payment` (
  `order_id` int(10) NOT NULL,
  `payment_type` varchar(10) NOT NULL,
  `total_price_after_discount` decimal(9,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `payment`
--

INSERT INTO `payment` (`order_id`, `payment_type`, `total_price_after_discount`) VALUES
(1, 'cash', '400.00');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`customer_id`);

--
-- Indexes for table `item`
--
ALTER TABLE `item`
  ADD PRIMARY KEY (`item_code`);

--
-- Indexes for table `order_item_table`
--
ALTER TABLE `order_item_table`
  ADD PRIMARY KEY (`order_id`,`item_code`),
  ADD KEY `fk_item_order_item` (`item_code`);

--
-- Indexes for table `order_table`
--
ALTER TABLE `order_table`
  ADD PRIMARY KEY (`order_id`),
  ADD KEY `employee_id` (`employee_id`),
  ADD KEY `customer_id` (`customer_id`);

--
-- Indexes for table `payment`
--
ALTER TABLE `payment`
  ADD UNIQUE KEY `order_id` (`order_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `customer`
--
ALTER TABLE `customer`
  MODIFY `customer_id` int(10) NOT NULL AUTO_INCREMENT COMMENT 'Unique identifier for the Customer table.', AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `item`
--
ALTER TABLE `item`
  MODIFY `item_code` int(7) NOT NULL AUTO_INCREMENT COMMENT 'Unique identifier for the item table.', AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `order_table`
--
ALTER TABLE `order_table`
  MODIFY `order_id` int(10) NOT NULL AUTO_INCREMENT COMMENT 'Unique identifier for the Order table.', AUTO_INCREMENT=2;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `order_item_table`
--
ALTER TABLE `order_item_table`
  ADD CONSTRAINT `fk_item_order_item` FOREIGN KEY (`item_code`) REFERENCES `item` (`item_code`),
  ADD CONSTRAINT `fk_order_order_item` FOREIGN KEY (`order_id`) REFERENCES `order_table` (`order_id`) ON DELETE CASCADE;

--
-- Constraints for table `order_table`
--
ALTER TABLE `order_table`
  ADD CONSTRAINT `fk_order_customer` FOREIGN KEY (`customer_id`) REFERENCES `customer` (`customer_id`) ON DELETE SET NULL;

--
-- Constraints for table `payment`
--
ALTER TABLE `payment`
  ADD CONSTRAINT `fk_order_payment_dependent` FOREIGN KEY (`order_id`) REFERENCES `order_table` (`order_id`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
