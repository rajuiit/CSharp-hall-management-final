-- phpMyAdmin SQL Dump
-- version 3.3.9
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Sep 13, 2014 at 07:26 AM
-- Server version: 5.5.8
-- PHP Version: 5.3.5

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `hallmanagement`
--

-- --------------------------------------------------------

--
-- Table structure for table `attendance`
--

CREATE TABLE IF NOT EXISTS `attendance` (
  `att_id` int(11) NOT NULL AUTO_INCREMENT,
  `hall_std_id` int(11) NOT NULL,
  `date_time` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`att_id`),
  KEY `fk_hall_std_id` (`hall_std_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Dumping data for table `attendance`
--

INSERT INTO `attendance` (`att_id`, `hall_std_id`, `date_time`) VALUES
(1, 2, '2014-08-14 20:46:16'),
(2, 3, '2014-08-16 20:24:12'),
(3, 3, '2014-08-20 09:43:21'),
(4, 2, '2014-08-20 09:43:45');

-- --------------------------------------------------------

--
-- Table structure for table `att_set`
--

CREATE TABLE IF NOT EXISTS `att_set` (
  `att_set_id` int(11) NOT NULL AUTO_INCREMENT,
  `from_date` varchar(50) NOT NULL,
  `to_date` varchar(50) NOT NULL,
  `date_time` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`att_set_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Dumping data for table `att_set`
--

INSERT INTO `att_set` (`att_set_id`, `from_date`, `to_date`, `date_time`) VALUES
(1, '2014-08-14 20:45:57', '2014-08-14 20:46:57', '2014-08-14 20:46:03'),
(2, '2014-08-14 20:46:42', '2014-08-14 20:47:42', '2014-08-14 20:46:47'),
(3, '2014-08-16 20:23:35', '2014-08-16 20:24:35', '2014-08-16 20:23:51'),
(4, '2014-08-19 09:43:57', '2014-08-20 09:44:57', '2014-08-20 09:42:16');

-- --------------------------------------------------------

--
-- Table structure for table `dept_info`
--

CREATE TABLE IF NOT EXISTS `dept_info` (
  `dept_id` int(11) NOT NULL AUTO_INCREMENT,
  `dept_name` varchar(50) NOT NULL,
  `faculty_id` int(11) NOT NULL,
  PRIMARY KEY (`dept_id`),
  UNIQUE KEY `dept_name` (`dept_name`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Dumping data for table `dept_info`
--

INSERT INTO `dept_info` (`dept_id`, `dept_name`, `faculty_id`) VALUES
(2, 'Department of Mathemetics', 1),
(3, 'Department of Statistics', 1);

-- --------------------------------------------------------

--
-- Table structure for table `faculty_info`
--

CREATE TABLE IF NOT EXISTS `faculty_info` (
  `faculty_id` int(11) NOT NULL AUTO_INCREMENT,
  `faculty_name` varchar(50) NOT NULL,
  PRIMARY KEY (`faculty_id`),
  UNIQUE KEY `faculty_name` (`faculty_name`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `faculty_info`
--

INSERT INTO `faculty_info` (`faculty_id`, `faculty_name`) VALUES
(2, 'Faculty of Commerce'),
(1, 'Faculty of Science');

-- --------------------------------------------------------

--
-- Table structure for table `hall_info`
--

CREATE TABLE IF NOT EXISTS `hall_info` (
  `hall_id` int(11) NOT NULL AUTO_INCREMENT,
  `hall_name` varchar(100) NOT NULL,
  `type` varchar(6) NOT NULL,
  PRIMARY KEY (`hall_id`),
  UNIQUE KEY `hall_name` (`hall_name`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `hall_info`
--

INSERT INTO `hall_info` (`hall_id`, `hall_name`, `type`) VALUES
(1, 'Jahanara Imam Hall', 'Female'),
(2, 'Shaheed Rafeeq Jabbar Hall', 'Male');

-- --------------------------------------------------------

--
-- Table structure for table `qouta`
--

CREATE TABLE IF NOT EXISTS `qouta` (
  `qouta_id` int(11) NOT NULL AUTO_INCREMENT,
  `qouta_name` varchar(50) NOT NULL,
  PRIMARY KEY (`qouta_id`),
  UNIQUE KEY `qouta_name` (`qouta_name`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `qouta`
--

INSERT INTO `qouta` (`qouta_id`, `qouta_name`) VALUES
(2, 'Freedom Fighter'),
(1, 'no');

-- --------------------------------------------------------

--
-- Table structure for table `remark`
--

CREATE TABLE IF NOT EXISTS `remark` (
  `remark_id` int(11) NOT NULL AUTO_INCREMENT,
  `remarks` varchar(500) NOT NULL,
  `author` varchar(50) DEFAULT NULL,
  `hall_std_id` int(11) NOT NULL,
  `date_time` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`remark_id`),
  KEY `fk_std_id` (`hall_std_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Dumping data for table `remark`
--

INSERT INTO `remark` (`remark_id`, `remarks`, `author`, `hall_std_id`, `date_time`) VALUES
(1, 'He is Good at Crickeett', 'reza', 3, '2014-08-12 21:02:20'),
(2, 'He is Good at Football', 'hasnat', 4, '2014-08-12 21:33:24'),
(3, 'adsads', 'Reza', 3, '2014-08-14 19:54:50'),
(4, 'lklklsadlakldka', 'Reza', 3, '2014-08-14 19:54:57'),
(5, 'poopopopo', 'Reza', 3, '2014-08-14 19:55:04');

-- --------------------------------------------------------

--
-- Table structure for table `seat`
--

CREATE TABLE IF NOT EXISTS `seat` (
  `room_id` int(11) NOT NULL AUTO_INCREMENT,
  `room` varchar(6) NOT NULL,
  `capacity` int(11) NOT NULL,
  `hall_id` int(11) NOT NULL,
  PRIMARY KEY (`room_id`),
  KEY `fk_hall_id` (`hall_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Dumping data for table `seat`
--

INSERT INTO `seat` (`room_id`, `room`, `capacity`, `hall_id`) VALUES
(1, '420', 3, 2),
(2, '420', 4, 1),
(3, '418', 2, 2);

-- --------------------------------------------------------

--
-- Table structure for table `settings`
--

CREATE TABLE IF NOT EXISTS `settings` (
  `settings_id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  `value` varchar(200) NOT NULL,
  PRIMARY KEY (`settings_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=9 ;

--
-- Dumping data for table `settings`
--

INSERT INTO `settings` (`settings_id`, `name`, `value`) VALUES
(1, 'hall_id', '12'),
(2, 'provost', 'Shamim Al Mamun'),
(3, 'establishment_year', '2008'),
(4, 'university', 'Jahangirnagar University'),
(5, 'location', 'Savar,Dhaka, Bangladesh.'),
(6, 'phone', 'PABX: 7791045-51'),
(7, 'ext_office', '1588'),
(8, 'fax', '88-02-7791052');

-- --------------------------------------------------------

--
-- Table structure for table `student_info`
--

CREATE TABLE IF NOT EXISTS `student_info` (
  `hall_std_id` int(11) NOT NULL AUTO_INCREMENT,
  `session` varchar(10) NOT NULL,
  `class_roll` int(11) NOT NULL,
  `registration_no` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `f_name` varchar(100) NOT NULL,
  `m_name` varchar(100) NOT NULL,
  `address` varchar(200) NOT NULL,
  `sex` varchar(6) NOT NULL,
  `religion` varchar(20) NOT NULL,
  `degree` varchar(50) NOT NULL,
  `mobile` varchar(20) NOT NULL,
  `phone` varchar(20) NOT NULL,
  `email` varchar(50) NOT NULL,
  `blood_group` varchar(5) NOT NULL,
  `alloted_room` varchar(10) NOT NULL,
  `hall_id` int(11) DEFAULT NULL,
  `dept_id` int(11) DEFAULT NULL,
  `faculty_id` int(11) DEFAULT NULL,
  `qouta_id` int(11) DEFAULT NULL,
  `added_by` int(11) DEFAULT NULL,
  `status` tinyint(1) NOT NULL,
  PRIMARY KEY (`hall_std_id`),
  KEY `fk_hall` (`hall_id`),
  KEY `fk_dept` (`dept_id`),
  KEY `fk_faculty` (`faculty_id`),
  KEY `fk_qouta` (`qouta_id`),
  KEY `fk_user` (`added_by`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Dumping data for table `student_info`
--

INSERT INTO `student_info` (`hall_std_id`, `session`, `class_roll`, `registration_no`, `name`, `f_name`, `m_name`, `address`, `sex`, `religion`, `degree`, `mobile`, `phone`, `email`, `blood_group`, `alloted_room`, `hall_id`, `dept_id`, `faculty_id`, `qouta_id`, `added_by`, `status`) VALUES
(2, '2011-12', 199, 32029, 'Sayed Mohsin Reza', 'Md. Rezaul Mostofa', 'Rowshon Ara Akhte', 'House: 84/2/c/1, Palashnagar Residential Area, Mirpur-11, Dhak', 'Female', 'Isla', 'Masters', '0181941212', '0192054637', 'smrezaiit@gmail.co', 'AB-', '420', 1, 2, 1, 2, 23, 0),
(3, '2011-12', 847, 32029, 'Md. Hasnat Parvez', '', '', '', 'Male', '', 'Honours', '01819466747', '', '', 'A+', '420', 2, 3, 2, 1, 23, 1),
(4, '2011-12', 835, 32029, 'Tanjina Akhter', '', '', '', 'Male', '', 'Honours', '12344321', '', '', 'A+', '420', 1, 2, 2, 2, 23, 0);

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE IF NOT EXISTS `user` (
  `user_id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(40) NOT NULL,
  `password` varchar(40) NOT NULL,
  `name` varchar(100) NOT NULL,
  `type` varchar(10) NOT NULL,
  PRIMARY KEY (`user_id`),
  UNIQUE KEY `userName` (`username`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=26 ;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`user_id`, `username`, `password`, `name`, `type`) VALUES
(23, 'reza', 'reza', 'Sayed Mohsin Reza', 'Admin'),
(24, 'raju', 'raju', 'Md. Mahfujur Rahman', 'Staff'),
(25, 'hasnat', 'hasnat', 'Md. Hasnat Parvez', 'Admin');

--
-- Constraints for dumped tables
--

--
-- Constraints for table `attendance`
--
ALTER TABLE `attendance`
  ADD CONSTRAINT `fk_hall_std_id` FOREIGN KEY (`hall_std_id`) REFERENCES `student_info` (`hall_std_id`);

--
-- Constraints for table `remark`
--
ALTER TABLE `remark`
  ADD CONSTRAINT `fk_std_id` FOREIGN KEY (`hall_std_id`) REFERENCES `student_info` (`hall_std_id`);

--
-- Constraints for table `seat`
--
ALTER TABLE `seat`
  ADD CONSTRAINT `fk_hall_id` FOREIGN KEY (`hall_id`) REFERENCES `hall_info` (`hall_id`);

--
-- Constraints for table `student_info`
--
ALTER TABLE `student_info`
  ADD CONSTRAINT `fk_dept` FOREIGN KEY (`dept_id`) REFERENCES `dept_info` (`dept_id`),
  ADD CONSTRAINT `fk_faculty` FOREIGN KEY (`faculty_id`) REFERENCES `faculty_info` (`faculty_id`),
  ADD CONSTRAINT `fk_hall` FOREIGN KEY (`hall_id`) REFERENCES `hall_info` (`hall_id`),
  ADD CONSTRAINT `fk_qouta` FOREIGN KEY (`qouta_id`) REFERENCES `qouta` (`qouta_id`),
  ADD CONSTRAINT `fk_user` FOREIGN KEY (`added_by`) REFERENCES `user` (`user_id`);
