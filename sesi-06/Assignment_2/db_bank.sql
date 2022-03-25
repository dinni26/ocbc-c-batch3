-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 24, 2022 at 12:42 AM
-- Server version: 10.4.13-MariaDB
-- PHP Version: 7.2.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_bank`
--

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `customerNumber` int(20) NOT NULL,
  `customerName` varchar(200) DEFAULT NULL,
  `contactLastName` varchar(100) DEFAULT NULL,
  `contactFirstName` varchar(100) DEFAULT NULL,
  `phone` int(20) DEFAULT NULL,
  `addressLine1` varchar(50) DEFAULT NULL,
  `addressLine2` varchar(50) DEFAULT NULL,
  `city` varchar(50) DEFAULT NULL,
  `state` varchar(50) DEFAULT NULL,
  `postalCode` int(20) DEFAULT NULL,
  `country` varchar(50) DEFAULT NULL,
  `employeeNumber` int(30) DEFAULT NULL,
  `creditLimit` int(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`customerNumber`, `customerName`, `contactLastName`, `contactFirstName`, `phone`, `addressLine1`, `addressLine2`, `city`, `state`, `postalCode`, `country`, `employeeNumber`, `creditLimit`) VALUES
(1, 'dafa', 'ardiansyah', 'dafa', 8567136, 'raya bogor', 'kebon pala', 'jakarta', 'timur', 45321, 'indonesia', 331, 50000),
(2, 'kavi', 'azriel', 'kavi', 8237283, 'tadho', 'kemanggisan', 'jakarta', 'selatan', 45846, 'indonesia', 332, 60000);

-- --------------------------------------------------------

--
-- Table structure for table `employees`
--

CREATE TABLE `employees` (
  `employeeNumber` int(50) NOT NULL,
  `lastName` varchar(50) DEFAULT NULL,
  `firstName` varchar(50) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `officeCode` int(20) DEFAULT NULL,
  `reportsTo` varchar(50) DEFAULT NULL,
  `jobTitle` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `employees`
--

INSERT INTO `employees` (`employeeNumber`, `lastName`, `firstName`, `email`, `officeCode`, `reportsTo`, `jobTitle`) VALUES
(236, 'dini', 'widia', 'dini@gmail.com', 238, 'CEO', 'editor'),
(239, 'azam', 'subianto', 'azam@gmail.com', 243, 'atasan', 'editor');

-- --------------------------------------------------------

--
-- Table structure for table `offices`
--

CREATE TABLE `offices` (
  `officeCode` int(50) NOT NULL,
  `cityOffice` varchar(50) DEFAULT NULL,
  `phoneOffice` int(20) DEFAULT NULL,
  `addressOffice1` varchar(100) DEFAULT NULL,
  `addressOffice2` varchar(100) DEFAULT NULL,
  `stateOffice` varchar(30) DEFAULT NULL,
  `postal_code` int(20) DEFAULT NULL,
  `territory` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `offices`
--

INSERT INTO `offices` (`officeCode`, `cityOffice`, `phoneOffice`, `addressOffice1`, `addressOffice2`, `stateOffice`, `postal_code`, `territory`) VALUES
(675, 'timur', 8347764, 'tadho', 'ciracas', 'jakarta', 36456, '200 m'),
(678, 'barat', 8935482, 'tangerang', 'kebon nanas', 'jakarta', 34522, '120 m');

-- --------------------------------------------------------

--
-- Table structure for table `orderdetail`
--

CREATE TABLE `orderdetail` (
  `OrderNumber` int(11) DEFAULT NULL,
  `productCode` int(11) DEFAULT NULL,
  `quantityOrdered` int(11) DEFAULT NULL,
  `priceEach` int(20) DEFAULT NULL,
  `orderLineNumber` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `orderdetail`
--

INSERT INTO `orderdetail` (`OrderNumber`, `productCode`, `quantityOrdered`, `priceEach`, `orderLineNumber`) VALUES
(342, 111, 10, 450000, 4),
(346, 112, 8, 460000, 6);

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE `orders` (
  `OrderNumber` int(11) NOT NULL,
  `orderDate` date DEFAULT NULL,
  `shippedDate` date DEFAULT NULL,
  `status` varchar(50) DEFAULT NULL,
  `comments` varchar(100) DEFAULT NULL,
  `customerNumber` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `orders`
--

INSERT INTO `orders` (`OrderNumber`, `orderDate`, `shippedDate`, `status`, `comments`, `customerNumber`) VALUES
(721, '2022-10-26', '2022-03-21', 'oke', 'baik', 1234),
(722, '2022-12-06', '2022-06-15', 'bagus', 'barang aman', 1456);

-- --------------------------------------------------------

--
-- Table structure for table `payment`
--

CREATE TABLE `payment` (
  `customerNumber` int(50) DEFAULT NULL,
  `checkNumber` int(50) NOT NULL,
  `paymentDate` date DEFAULT NULL,
  `amount` int(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `payment`
--

INSERT INTO `payment` (`customerNumber`, `checkNumber`, `paymentDate`, `amount`) VALUES
(1213, 832, '2022-07-12', 2300000),
(1223, 838, '2022-02-15', 2340000);

-- --------------------------------------------------------

--
-- Table structure for table `productline`
--

CREATE TABLE `productline` (
  `productLine` int(20) NOT NULL,
  `textDescription` varchar(150) DEFAULT NULL,
  `htmlDescription` varchar(200) DEFAULT NULL,
  `image` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `productline`
--

INSERT INTO `productline` (`productLine`, `textDescription`, `htmlDescription`, `image`) VALUES
(213, 'honda', 'honda.html', 'honda.jpg'),
(214, 'yamaha', 'yamaha.html', 'yamaha.jpg'),
(215, 'suzuki', 'suzuki.html', 'suzuki.jpg');

-- --------------------------------------------------------

--
-- Table structure for table `products`
--

CREATE TABLE `products` (
  `productCode` int(30) NOT NULL,
  `productName` varchar(80) DEFAULT NULL,
  `productLine` int(20) DEFAULT NULL,
  `productScale` varchar(100) DEFAULT NULL,
  `productVendor` varchar(100) DEFAULT NULL,
  `productDescription` varchar(150) DEFAULT NULL,
  `quantityInStock` int(50) DEFAULT NULL,
  `buyPrice` int(30) DEFAULT NULL,
  `MSRP` int(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `products`
--

INSERT INTO `products` (`productCode`, `productName`, `productLine`, `productScale`, `productVendor`, `productDescription`, `quantityInStock`, `buyPrice`, `MSRP`) VALUES
(401, 'jazz', 122, '2', 'honda', 'aman', 230, 170000, 28000),
(402, 'avanza', 123, '5', 'suzuki', 'oke', 250, 120000, 20000),
(403, 'avanza', 124, '4', 'suzuki', 'bagus', 220, 420000, 34000);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`customerNumber`),
  ADD KEY `employeeNumber` (`employeeNumber`);

--
-- Indexes for table `employees`
--
ALTER TABLE `employees`
  ADD PRIMARY KEY (`employeeNumber`),
  ADD KEY `officeCode` (`officeCode`);

--
-- Indexes for table `offices`
--
ALTER TABLE `offices`
  ADD PRIMARY KEY (`officeCode`);

--
-- Indexes for table `orderdetail`
--
ALTER TABLE `orderdetail`
  ADD KEY `OrderNumber` (`OrderNumber`);

--
-- Indexes for table `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`OrderNumber`),
  ADD KEY `customerNumber` (`customerNumber`);

--
-- Indexes for table `payment`
--
ALTER TABLE `payment`
  ADD PRIMARY KEY (`checkNumber`),
  ADD KEY `customerNumber` (`customerNumber`);

--
-- Indexes for table `productline`
--
ALTER TABLE `productline`
  ADD PRIMARY KEY (`productLine`);

--
-- Indexes for table `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`productCode`),
  ADD KEY `productLine` (`productLine`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
