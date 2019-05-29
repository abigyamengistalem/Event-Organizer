-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 14, 2019 at 04:00 PM
-- Server version: 5.7.14
-- PHP Version: 5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pagent`
--

-- --------------------------------------------------------

--
-- Table structure for table `account`
--

CREATE TABLE `account` (
  `FirstName` text NOT NULL,
  `MiddleName` text NOT NULL,
  `UserName` varchar(20) NOT NULL,
  `Password` varchar(20) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `account`
--

INSERT INTO `account` (`FirstName`, `MiddleName`, `UserName`, `Password`) VALUES
('Elyab', 'Alemu', 'firstadmin', '@adminfirst'),
('', '', '', ''),
('Kidus', 'Zewdu', 'secondadmin', 'secondadmin'),
('Eden', 'Abdisa', 'edume', 'firstjudge');

-- --------------------------------------------------------

--
-- Table structure for table `contestants`
--

CREATE TABLE `contestants` (
  `FirstName` text,
  `MiddleName` text,
  `PhoneNumber` varchar(15) DEFAULT NULL,
  `Email` varchar(30) DEFAULT NULL,
  `HomeTown` text,
  `FirstLanguage` text,
  `Location` varchar(50) DEFAULT NULL,
  `Bust` decimal(10,0) DEFAULT NULL,
  `Waist` decimal(10,0) DEFAULT NULL,
  `Hips` decimal(10,0) DEFAULT NULL,
  `Neck` decimal(10,0) DEFAULT NULL,
  `NeckToWaist` decimal(10,0) DEFAULT NULL,
  `WaistToCrotch` decimal(10,0) DEFAULT NULL,
  `Shoulder` decimal(10,0) DEFAULT NULL,
  `Tigh` decimal(10,0) DEFAULT NULL,
  `WaistToHeel` decimal(10,0) DEFAULT NULL,
  `Height` decimal(10,0) DEFAULT NULL,
  `Weight` decimal(10,0) DEFAULT NULL,
  `DressInSize` text,
  `SwimSuit` decimal(10,0) DEFAULT NULL,
  `ShoeSize` decimal(10,0) DEFAULT NULL,
  `ColorOfHair` text,
  `ColorOfEye` text,
  `Biography` text,
  `Image` blob,
  `ContestantNumber` int(20) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `contestants`
--

INSERT INTO `contestants` (`FirstName`, `MiddleName`, `PhoneNumber`, `Email`, `HomeTown`, `FirstLanguage`, `Location`, `Bust`, `Waist`, `Hips`, `Neck`, `NeckToWaist`, `WaistToCrotch`, `Shoulder`, `Tigh`, `WaistToHeel`, `Height`, `Weight`, `DressInSize`, `SwimSuit`, `ShoeSize`, `ColorOfHair`, `ColorOfEye`, `Biography`, `Image`, `ContestantNumber`) VALUES
('Linda', 'Getachew', '0911111111', 'lindi@gmail.com', 'addis ababa', 'amharic', 'friend', '32', '35', '23', '53', '32', '34', '43', '23', '23', '2', '45', 'M', '23', '24', 'Black', 'Brown', 'this is me', '', 2),
('Bety', 'Niguse', '09878787', 'Betel@gmail.com', 'Nazret', 'Amharic', 'Through a  friend', '32', '32', '32', '32', '32', '32', '32', '32', '32', '2', '54', 'S', '13', '34', 'Black', 'Brown', 'This Is Bety', NULL, 3),
('Ement', 'Mesfin', '091111111', 'emini@gmail.com', 'Addis Ababa', 'English', 'Through a Friend', '34', '32', '32', '32', '32', '32', '32', '45', '34', '2', '45', 'M', '34', '45', 'Blue', 'Black', 'i am emnet', NULL, 4),
('Bami', 'habel', '09121212121', 'Bami@gmail.com', 'Addis Ababa', 'English', 'Advertisment', '32', '32', '32', '32', '32', '32', '32', '32', '32', '2', '45', 'M', '34', '76', 'Black', 'Brown', 'This is bami', NULL, 5),
('Meron', 'Joni', '0911111111', 'Meri@gmail.com', 'Addis Ababa', 'Amharic', 'Through a friend', '32', '40', '40', '40', '40', '40', '40', '56', '67', '2', '44', 'M', '56', '543', 'Black', 'Brown', 'This is merry', NULL, 6);

-- --------------------------------------------------------

--
-- Table structure for table `gallery`
--

CREATE TABLE `gallery` (
  `GalleryImages` blob NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `gallery`
--

INSERT INTO `gallery` (`GalleryImages`) VALUES
(0x53797374656d2e57696e646f77732e436f6e74726f6c732e496d616765),
(0x53797374656d2e57696e646f77732e436f6e74726f6c732e496d616765),
(0x53797374656d2e57696e646f77732e436f6e74726f6c732e496d616765);

-- --------------------------------------------------------

--
-- Table structure for table `image`
--

CREATE TABLE `image` (
  `Image` blob,
  `Number` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `judges`
--

CREATE TABLE `judges` (
  `FirstName` text,
  `LastName` text,
  `Email` varchar(50) DEFAULT NULL,
  `PhoneNumber` varchar(50) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `judges`
--

INSERT INTO `judges` (`FirstName`, `LastName`, `Email`, `PhoneNumber`) VALUES
('Bety', 'Kinfe', '0909090909', 'Bety@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `news`
--

CREATE TABLE `news` (
  `Article` varchar(1000) DEFAULT NULL,
  `Date` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `news`
--

INSERT INTO `news` (`Article`, `Date`) VALUES
('this is the first news article', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `sponsers`
--

CREATE TABLE `sponsers` (
  `FirstName` text NOT NULL,
  `LastName` text NOT NULL,
  `PhoneNumber` varchar(20) NOT NULL,
  `Email` varchar(20) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `sponsers`
--

INSERT INTO `sponsers` (`FirstName`, `LastName`, `PhoneNumber`, `Email`) VALUES
('', '', '', ''),
('Tibebu', 'Alemu', 'tibebu@gmail.com', '091212121212'),
('Betel', 'Alemu', 'Bety@gmail.com', '0923445555'),
('redu', 'redu', 'redu@gmail', '09878787'),
('', '', '', '');

-- --------------------------------------------------------

--
-- Table structure for table `venue`
--

CREATE TABLE `venue` (
  `Name` varchar(50) NOT NULL,
  `VenueType` text NOT NULL,
  `VenueLocation` varchar(50) NOT NULL,
  `VenueSize` decimal(20,0) NOT NULL,
  `PhoneNumber` varchar(20) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `venue`
--

INSERT INTO `venue` (`Name`, `VenueType`, `VenueLocation`, `VenueSize`, `PhoneNumber`) VALUES
('Capital Hotel', 'InDoor', 'Addis Ababa', '877', '0112343434');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `contestants`
--
ALTER TABLE `contestants`
  ADD PRIMARY KEY (`ContestantNumber`);

--
-- Indexes for table `image`
--
ALTER TABLE `image`
  ADD PRIMARY KEY (`Number`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `contestants`
--
ALTER TABLE `contestants`
  MODIFY `ContestantNumber` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT for table `image`
--
ALTER TABLE `image`
  MODIFY `Number` int(11) NOT NULL AUTO_INCREMENT;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
