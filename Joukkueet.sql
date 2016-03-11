-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: 10.03.2016 klo 14:29
-- Palvelimen versio: 10.1.9-MariaDB
-- PHP Version: 5.6.15

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ohjelmistoprojekti`
--

-- --------------------------------------------------------

--
-- Rakenne taululle `Joukkueet`
--

CREATE TABLE `joukkueet` (
  `joukkueID` int(11) NOT NULL,
  `joukkueNimi` varchar(50) NOT NULL,
  `joukkuePisteet` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Vedos taulusta `Joukkueet`
--

INSERT INTO `Joukkueet` (`joukkueID`, `joukkueNimi`, `joukkuePisteet`) VALUES
(1, 'team1', 300),
(2, 'team2', 200),
(3, 'team3', 100),
(4, 'team4', 20);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `Joukkueet`
--
ALTER TABLE `Joukkueet`
  ADD PRIMARY KEY (`joukkueID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `Joukkueet`
--
ALTER TABLE `Joukkueet`
  MODIFY `joukkueID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
