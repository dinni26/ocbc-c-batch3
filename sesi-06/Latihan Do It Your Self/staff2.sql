-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 24, 2022 at 05:38 PM
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
-- Database: `staff2`
--

-- --------------------------------------------------------

--
-- Table structure for table `data_staff`
--

CREATE TABLE `data_staff` (
  `nik` int(11) NOT NULL,
  `nama` varchar(50) DEFAULT NULL,
  `alamat` varchar(200) DEFAULT NULL,
  `handphone` varchar(15) DEFAULT NULL,
  `joindate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `data_staff`
--

INSERT INTO `data_staff` (`nik`, `nama`, `alamat`, `handphone`, `joindate`) VALUES
(23124, 'dafa', 'bandung', '0813256405', NULL),
(23431, 'kavi', 'bogor', '0813256143', NULL),
(23452, 'dini', 'jakarta', '0812153456', NULL),
(76522, 'reni', 'jakarta', '0811234405', '2019-02-10'),
(87567, 'bayu', 'kediri', '0813456143', '2020-04-10');

-- --------------------------------------------------------

--
-- Table structure for table `staff_outsource`
--

CREATE TABLE `staff_outsource` (
  `nik` int(11) NOT NULL,
  `nama` varchar(50) DEFAULT NULL,
  `alamat` varchar(200) DEFAULT NULL,
  `handphone` varchar(15) DEFAULT NULL,
  `joindate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `staff_outsource`
--

INSERT INTO `staff_outsource` (`nik`, `nama`, `alamat`, `handphone`, `joindate`) VALUES
(23124, 'dafa', 'bandung', '0813256405', NULL),
(23431, 'kavi', 'bogor', '0813256143', NULL),
(23452, 'dini', 'jakarta', '0812153456', NULL),
(35734, 'dini', 'BOGOR', '0811234456', '2019-02-10'),
(35735, 'dafa', 'JAKARTA', '0815676412', '2020-03-10'),
(35737, 'kavi', 'BOGOR', '0811234478', '2019-01-10'),
(35738, 'moza', 'JAKARTA', '0815676490', '2020-06-10'),
(35739, 'kenzie', 'BOGOR', '0811231205', '2019-07-10'),
(35740, 'dicky', 'JAKARTA', '0815673205', '2020-01-10'),
(35741, 'farid', 'BOGOR', '0811234505', '2019-02-10'),
(35742, 'via', 'JAKARTA', '0815676675', '2020-05-10'),
(35743, 'bahar', 'BOGOR', '0811238905', '2019-01-10'),
(35744, 'wiwik', 'JAKARTA', '0815670905', '2020-02-10'),
(76522, 'reni', 'jakarta', '0811234405', '2019-02-10'),
(87567, 'bayu', 'kediri', '0813456143', '2020-04-10');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `data_staff`
--
ALTER TABLE `data_staff`
  ADD PRIMARY KEY (`nik`);

--
-- Indexes for table `staff_outsource`
--
ALTER TABLE `staff_outsource`
  ADD PRIMARY KEY (`nik`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
