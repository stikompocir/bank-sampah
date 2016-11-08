-- phpMyAdmin SQL Dump
-- version 3.2.4
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Nov 07, 2016 at 09:47 PM
-- Server version: 5.1.41
-- PHP Version: 5.3.1

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `bank_sampah`
--

-- --------------------------------------------------------

--
-- Table structure for table `detail_beli`
--

CREATE TABLE IF NOT EXISTS `detail_beli` (
  `no_transaksi` varchar(20) DEFAULT NULL,
  `id_sampah` varchar(20) DEFAULT NULL,
  `harga` int(20) NOT NULL,
  `jumlah_beli` double DEFAULT NULL,
  `total_harga` double DEFAULT NULL,
  KEY `id_sampah` (`id_sampah`),
  KEY `no_transaksi` (`no_transaksi`),
  KEY `id_sampah_2` (`id_sampah`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `detail_beli`
--

INSERT INTO `detail_beli` (`no_transaksi`, `id_sampah`, `harga`, `jumlah_beli`, `total_harga`) VALUES
('1611020001', 'BS101', 1500, 15, 22500),
('1611020001', 'BS102', 1500, 12.5, 18750);

-- --------------------------------------------------------

--
-- Table structure for table `detail_setor`
--

CREATE TABLE IF NOT EXISTS `detail_setor` (
  `no_transaksi` varchar(20) DEFAULT NULL,
  `id_sampah` varchar(20) DEFAULT NULL,
  `harga` int(20) NOT NULL,
  `jumlah_setor` double NOT NULL,
  `total_harga_setor` int(20) DEFAULT NULL,
  KEY `id_nasabah` (`id_sampah`),
  KEY `id_nasabah_2` (`id_sampah`),
  KEY `no_transaksi` (`no_transaksi`),
  KEY `no_transaksi_2` (`no_transaksi`),
  KEY `id_sampah` (`id_sampah`),
  KEY `no_transaksi_3` (`no_transaksi`),
  KEY `id_sampah_2` (`id_sampah`),
  KEY `id_sampah_3` (`id_sampah`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `detail_setor`
--

INSERT INTO `detail_setor` (`no_transaksi`, `id_sampah`, `harga`, `jumlah_setor`, `total_harga_setor`) VALUES
('1611020001', 'BS101', 2000, 13, 26600),
('1611020001', 'BS101', 2000, 14, 27200),
('1611020002', 'BS101', 2000, 13, 25200),
('1611020003', 'BS101', 2000, 24, 48000),
('1611020004', 'BS102', 2000, 15, 30000),
('1611020005', 'BS102', 2000, 12, 24000),
('1611020006', 'BS103', 1500, 12, 18600),
('1611020007', 'BS101', 2000, 15, 30000),
('1611020008', 'BS103', 1500, 12, 18000),
('1611020008', 'BS101', 2000, 12, 24000),
('1611020009', 'BS103', 1500, 12, 18000),
('1611020010', 'BS103', 1500, 12.4, 18600),
('1611020011', 'BS103', 1500, 34.7, 52050),
('1611020012', 'BS103', 1500, 1.5, 2250),
('1611020012', 'BS102', 2000, 1.6, 3200),
('1611020012', 'BS101', 2000, 12.5, 25000),
('1611020019', 'BS101', 2000, 12, 24000),
('1611020020', 'BS101', 2000, 123.5, 247000),
('1611020021', 'BS102', 2000, 15, 30000),
('1611020022', 'BS101', 2000, 23, 46000),
('1611020023', 'BS101', 2000, 12, 24000),
('1611020024', 'BS101', 2000, 12, 24000),
('1611020027', 'BS101', 2000, 12, 24000),
('1611030001', 'BS101', 2000, 20, 40000),
('1611030002', 'BS101', 2000, 12.5, 25000),
('1611030003', 'BS103', 1500, 12.5, 18750),
('1611030008', 'BS101', 2000, 12, 24000),
('1611030009', 'BS101', 2000, 12, 24000),
('1611030010', 'BS101', 2000, 12, 24000),
('1611030011', 'BS101', 2000, 12, 24000),
('1611030012', 'BS101', 2000, 12, 24000),
('1611030013', 'BS101', 2000, 12, 24000),
('1611030014', 'BS101', 2000, 12, 24000),
('1611030015', 'BS102', 2000, 12, 24000),
('1611030016', 'BS101', 2000, 12, 24000),
('1611030017', 'BS101', 2000, 12, 24000),
('1611030018', 'BS101', 2000, 12, 24000),
('1611030019', 'BS101', 2000, 12, 24000),
('1611030020', 'bs101', 2000, 12, 24000),
('1611030021', 'bs101', 2000, 12, 24000),
('1611030022', 'bs101', 2000, 12, 24000),
('1611030023', 'bs101', 2000, 12, 24000),
('1611030024', 'bs101', 2000, 12, 24000),
('1611030025', 'bs101', 2000, 12, 24000),
('1611030026', 'bs101', 2000, 12, 24000),
('1611030027', 'bs101', 2000, 12, 24000),
('1611030028', 'bs101', 2000, 12, 24000),
('1611030029', 'bs101', 2000, 234, 468000),
('1611030030', 'bs103', 1500, 12.5, 18750),
('1611030031', 'bs101', 2000, 12, 24000),
('1611030032', 'bs101', 2000, 12, 24000),
('1611030033', 'bs103', 1500, 12, 18000),
('1611030034', 'bs103', 1500, 12, 18000),
('1611030035', 'bs102', 2000, 12, 24000),
('1611030036', 'bs101', 2000, 123, 246000),
('1611030037', 'bs101', 2000, 12, 24000),
('1611030038', 'bs101', 2000, 122, 244000),
('1611030039', 'bs101', 2000, 12, 24000),
('1611030040', 'bs101', 2000, 12, 24000),
('1611030041', 'bs101', 2000, 12, 24000),
('1611030042', 'bs101', 2000, 12, 24000),
('1611030043', 'bs101', 2000, 12, 24000),
('1611030044', 'bs101', 2000, 102, 204000),
('1611030045', 'bs101', 2000, 12, 24000),
('1611030046', 'bs101', 2000, 12, 24000),
('1611030047', 'bs102', 2000, 12, 24000),
('1611030048', 'bs101', 2000, 12, 24000),
('1611030049', 'bs101', 2000, 12, 24000),
('1611030050', 'bs101', 2000, 12, 24000),
('1611030051', 'bs101', 2000, 12, 24000),
('1611030052', 'bs101', 2000, 12, 24000),
('1611030053', 'bs103', 1500, 12, 18000),
('1611030054', 'bs101', 2000, 12, 24000),
('1611030055', 'bs101', 2000, 12, 24000),
('1611030056', 'bs101', 2000, 12, 24000),
('1611030057', 'bs103', 1500, 134, 201000),
('1611030058', 'bs101', 2000, 12, 24000),
('1611030059', 'bs103', 1500, 13, 19500),
('1611030060', 'bs103', 1500, 14, 21000),
('1611030061', 'bs103', 1500, 13, 19500),
('1611030062', 'bs102', 2000, 10, 20000),
('1611030063', 'bs101', 2000, 12, 24000),
('1611030064', 'bs102', 2000, 12, 24000);

-- --------------------------------------------------------

--
-- Table structure for table `nasabah`
--

CREATE TABLE IF NOT EXISTS `nasabah` (
  `id_nasabah` varchar(20) NOT NULL,
  `nama_nasabah` varchar(30) DEFAULT NULL,
  `alamat_nasabah` varchar(50) DEFAULT NULL,
  `saldo` double NOT NULL,
  `no_telpon` varchar(20) DEFAULT NULL,
  `status` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`id_nasabah`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `nasabah`
--

INSERT INTO `nasabah` (`id_nasabah`, `nama_nasabah`, `alamat_nasabah`, `saldo`, `no_telpon`, `status`) VALUES
('NS0001', 'Maman', 'Matangaji', 245400, '085283868252', 'aktif'),
('NS0002', 'Tina', 'Matangaji', -102722, '089678567456', 'aktif'),
('NS0003', 'Mimin', 'Matangaji', 30500, '089789678567', 'aktif');

-- --------------------------------------------------------

--
-- Table structure for table `pengambilan`
--

CREATE TABLE IF NOT EXISTS `pengambilan` (
  `id_pengambilan` varchar(20) NOT NULL,
  `tanggal` date NOT NULL,
  `id_nasabah` varchar(20) NOT NULL,
  `jumlah` double NOT NULL,
  `id_petugas` varchar(20) NOT NULL,
  PRIMARY KEY (`id_pengambilan`),
  KEY `id_nasabah` (`id_nasabah`),
  KEY `id_petugas` (`id_petugas`),
  KEY `id_petugas_2` (`id_petugas`),
  KEY `id_petugas_3` (`id_petugas`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pengambilan`
--

INSERT INTO `pengambilan` (`id_pengambilan`, `tanggal`, `id_nasabah`, `jumlah`, `id_petugas`) VALUES
('ABL161103001', '2016-11-03', 'NS0001', 200, 'A001'),
('ABL161103002', '2003-11-16', 'NS0001', 200, 'A001'),
('ABL161105001', '2016-11-05', 'NS0003', 2000, 'panel1'),
('ABL161105002', '2016-11-05', 'NS0002', 1000, 'A001');

-- --------------------------------------------------------

--
-- Table structure for table `pengepul`
--

CREATE TABLE IF NOT EXISTS `pengepul` (
  `id_pengepul` varchar(20) NOT NULL,
  `nama_pengepul` varchar(30) DEFAULT NULL,
  `alamat_pengepul` varchar(50) DEFAULT NULL,
  `no_telpon` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id_pengepul`),
  KEY `id_pengepul` (`id_pengepul`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pengepul`
--

INSERT INTO `pengepul` (`id_pengepul`, `nama_pengepul`, `alamat_pengepul`, `no_telpon`) VALUES
('BSP001', 'PT. AAAAA', 'Sumber Jaya', '089678567456'),
('BSP002', 'PT. JANGKRIK MULYA', 'SUMBER WARAS', '0879876765654');

-- --------------------------------------------------------

--
-- Table structure for table `petugas`
--

CREATE TABLE IF NOT EXISTS `petugas` (
  `id_petugas` varchar(20) NOT NULL,
  `nama_petugas` varchar(30) DEFAULT NULL,
  `password_petugas` varchar(30) DEFAULT NULL,
  `status` varchar(20) NOT NULL,
  PRIMARY KEY (`id_petugas`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `petugas`
--

INSERT INTO `petugas` (`id_petugas`, `nama_petugas`, `password_petugas`, `status`) VALUES
('A001', 'Admin', 'admin', 'Admin');

-- --------------------------------------------------------

--
-- Table structure for table `sampah`
--

CREATE TABLE IF NOT EXISTS `sampah` (
  `id_sampah` varchar(20) NOT NULL,
  `nama_sampah` varchar(20) DEFAULT NULL,
  `harga_setor` double DEFAULT NULL,
  `harga_beli` double DEFAULT NULL,
  `stok` int(20) NOT NULL,
  PRIMARY KEY (`id_sampah`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `sampah`
--

INSERT INTO `sampah` (`id_sampah`, `nama_sampah`, `harga_setor`, `harga_beli`, `stok`) VALUES
('BS101', 'Koran', 2000, 1500, 1342),
('BS102', 'Kantong Semen', 2000, 1500, 102),
('BS103', 'Kotak Dus', 1500, 1000, 309),
('BS104', 'KERTAS NASI', 2000, 1500, 15);

-- --------------------------------------------------------

--
-- Table structure for table `setor_nasabah`
--

CREATE TABLE IF NOT EXISTS `setor_nasabah` (
  `no_transaksi` varchar(20) NOT NULL,
  `tanggal` date DEFAULT NULL,
  `id_nasabah` varchar(20) DEFAULT NULL,
  `id_petugas` varchar(20) DEFAULT NULL,
  `total_barang` double NOT NULL,
  `total_harga` int(20) NOT NULL,
  PRIMARY KEY (`no_transaksi`),
  KEY `id_nasabah` (`id_nasabah`),
  KEY `id_petugas` (`id_petugas`),
  KEY `no_transaksi` (`no_transaksi`),
  KEY `id_nasabah_2` (`id_nasabah`),
  KEY `id_petugas_2` (`id_petugas`),
  KEY `no_transaksi_2` (`no_transaksi`),
  KEY `id_nasabah_3` (`id_nasabah`),
  KEY `id_petugas_3` (`id_petugas`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `setor_nasabah`
--

INSERT INTO `setor_nasabah` (`no_transaksi`, `tanggal`, `id_nasabah`, `id_petugas`, `total_barang`, `total_harga`) VALUES
('1611020001', '2016-11-02', 'NS0001', 'A001', 14, 27200),
('1611020002', '2016-11-02', 'ns0001', 'A001', 13, 25200),
('1611020003', '2016-11-02', 'NS0002', 'A001', 24, 48000),
('1611020004', '0000-00-00', 'NS0001', 'A001', 28, 55000),
('1611020005', '2016-11-02', 'NS0001', 'A001', 12, 24000),
('1611020006', '2016-11-02', 'NS0001', 'A001', 37, 68600),
('1611020007', '2016-11-02', 'NS0001', 'A001', 15, 30000),
('1611020008', '0000-00-00', 'NS0002', 'A001', 24, 42000),
('1611020009', '2016-11-02', 'NS0002', 'A001', 12, 18000),
('1611020010', '2016-11-02', 'NS0001', 'A001', 12, 18600),
('1611020011', '2016-11-02', 'NS0002', 'A001', 35, 52050),
('1611020012', '0000-00-00', 'NS0001', 'A001', 16, 30450),
('1611020013', '2016-11-02', 'NS0001', 'A001', 25, 50000),
('1611020014', '2016-11-02', 'NS0001', 'A001', 13, 25000),
('1611020015', '2016-11-02', 'NS0001', 'A001', 13, 25000),
('1611020016', '2016-11-02', 'NS0001', 'A001', 25, 50200),
('1611020017', '2016-11-02', 'NS0001', 'A001', 13, 25000),
('1611020018', '2016-11-02', 'NS0001', 'A001', 12, 24600),
('1611020019', '2016-11-02', 'NS0001', 'A001', 12, 24000),
('1611020020', '0000-00-00', 'NS0001', 'A001', 124, 247000),
('1611020021', '0000-00-00', 'NS0002', 'A001', 15, 30000),
('1611020022', '0000-00-00', 'NS0001', 'A001', 23, 46000),
('1611020023', '2016-11-02', 'NS0001', 'A001', 12, 24000),
('1611020024', '0000-00-00', 'NS0001', 'A001', 12, 24000),
('1611020025', '2016-11-02', 'NS0001', 'A001', 12, 24000),
('1611020026', '2016-11-02', 'NS0001', 'A001', 12, 24400),
('1611020027', '2016-11-02', 'NS0001', 'A001', 12, 24000),
('1611030001', '2016-11-03', 'NS0001', 'A001', 20, 40000),
('1611030002', '2016-11-03', 'NS0001', 'A001', 13, 25000),
('1611030003', '0000-00-00', 'NS0002', 'A001', 12.5, 18750),
('1611030004', '2016-11-03', 'NS0001', 'A001', 12.2, 24400),
('1611030005', '2016-11-03', 'NS0001', 'A001', 12, 24000),
('1611030006', '2016-11-03', 'NS0001', 'A001', 12, 24000),
('1611030007', '2016-11-03', 'NS0001', 'A001', 12, 24000),
('1611030008', '2016-11-03', 'NS0001', 'A001', 12, 24000),
('1611030009', '2016-11-03', 'NS0001', 'A001', 39, 71000),
('1611030010', '2016-11-03', 'NS0001', 'A001', 24, 48000),
('1611030011', '2016-11-03', 'NS0001', 'A001', 12, 24000),
('1611030012', '2016-11-03', 'NS0001', 'A001', 12, 24000),
('1611030013', '2016-11-03', 'NS0001', 'A001', 12, 24000),
('1611030014', '2016-11-03', 'NS0001', 'A001', 12, 24000),
('1611030015', '2016-11-03', 'NS0001', 'A001', 12, 24000),
('1611030016', '2016-11-03', 'NS0001', 'A001', 12, 24000),
('1611030017', '2016-11-03', 'NS0001', 'A001', 12, 24000),
('1611030018', '2016-11-03', 'NS0001', 'A001', 12, 24000),
('1611030019', '2016-11-03', 'NS0001', 'A001', 12, 24000),
('1611030020', '2016-11-03', 'ns0001', 'A001', 12, 24000),
('1611030021', '2016-11-03', 'ns0001', 'A001', 12, 24000),
('1611030022', '2016-11-03', 'ns0001', 'A001', 12, 24000),
('1611030023', '2016-11-03', 'ns0001', 'A001', 12, 24000),
('1611030024', '2016-11-03', 'ns0001', 'A001', 12, 24000),
('1611030025', '2016-11-03', 'ns0001', 'A001', 12, 24000),
('1611030026', '2016-11-03', 'ns0001', 'A001', 12, 24000),
('1611030027', '2016-11-03', 'ns0001', 'A001', 12, 24000),
('1611030028', '2016-11-03', 'ns0002', 'A001', 12, 24000),
('1611030029', '2016-11-03', 'ns0001', 'A001', 234, 468000),
('1611030030', '0000-00-00', 'ns0001', 'A001', 12.5, 18750),
('1611030031', '0000-00-00', 'ns0001', 'A001', 12, 24000),
('1611030032', '0000-00-00', 'ns0001', 'A001', 12, 24000),
('1611030033', '2016-11-03', 'ns0002', 'A001', 12, 18000),
('1611030034', '0000-00-00', 'ns0002', 'A001', 12, 18000),
('1611030035', '0000-00-00', 'ns0002', 'A001', 12, 24000),
('1611030036', '2016-11-03', 'ns0001', 'A001', 123, 246000),
('1611030037', '2016-11-03', 'ns0001', 'A001', 12, 24000),
('1611030038', '2016-11-03', 'ns0001', 'A001', 122, 244000),
('1611030039', '2016-11-03', 'ns0001', 'A001', 12, 24000),
('1611030040', '2016-11-03', 'ns0001', 'A001', 12, 24000),
('1611030041', '2016-11-03', 'ns0001', 'A001', 12, 24000),
('1611030042', '2016-11-03', 'ns0001', 'A001', 12, 24000),
('1611030043', '2016-11-03', 'ns0001', 'A001', 12, 24000),
('1611030044', '2016-11-03', 'ns0002', 'A001', 102, 204000),
('1611030045', '2016-11-03', 'ns0001', 'A001', 12, 24000),
('1611030046', '2016-11-03', 'ns0001', 'A001', 12, 24000),
('1611030047', '2016-11-03', 'ns0001', 'A001', 12, 24000),
('1611030048', '2016-11-03', 'ns0001', 'A001', 12, 24000),
('1611030049', '2016-11-03', 'ns0001', 'A001', 12, 24000),
('1611030050', '2016-11-03', 'ns0001', 'A001', 12, 24000),
('1611030051', '2016-11-03', 'ns0001', 'A001', 12, 24000),
('1611030052', '2016-11-03', 'ns0001', 'A001', 12, 24000),
('1611030053', '2016-11-03', 'ns0001', 'A001', 12, 18000),
('1611030054', '2016-11-03', 'ns0001', 'A001', 12, 24000),
('1611030055', '2016-11-03', 'ns0001', 'A001', 12, 24000),
('1611030056', '2016-11-03', 'ns0001', 'A001', 12, 24000),
('1611030057', '2016-11-03', 'ns0001', 'A001', 134, 201000),
('1611030058', '2016-11-03', 'ns0001', 'A001', 12, 24000),
('1611030059', '0000-00-00', 'ns0002', 'A001', 13, 19500),
('1611030060', '0000-00-00', 'ns0001', 'A001', 14, 21000),
('1611030061', '0000-00-00', 'ns0003', 'A001', 13, 19500),
('1611030062', '0000-00-00', 'ns0003', 'A001', 10, 20000),
('1611030063', '0000-00-00', 'ns0004', 'A001', 12, 24000),
('1611030064', '0000-00-00', 'ns0004', 'A001', 12, 24000);

-- --------------------------------------------------------

--
-- Table structure for table `setor_pengepul`
--

CREATE TABLE IF NOT EXISTS `setor_pengepul` (
  `no_transaksi` varchar(10) NOT NULL,
  `tanggal` date DEFAULT NULL,
  `id_pengepul` varchar(20) DEFAULT NULL,
  `id_petugas` varchar(20) DEFAULT NULL,
  `total_barang` double NOT NULL,
  `total_harga` double NOT NULL,
  PRIMARY KEY (`no_transaksi`),
  KEY `id_nasabah` (`id_petugas`),
  KEY `id_pengepul` (`id_pengepul`),
  KEY `no_transaksi` (`no_transaksi`),
  KEY `id_pengepul_2` (`id_pengepul`),
  KEY `id_petugas` (`id_petugas`),
  KEY `id_pengepul_3` (`id_pengepul`),
  KEY `id_petugas_2` (`id_petugas`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `setor_pengepul`
--

INSERT INTO `setor_pengepul` (`no_transaksi`, `tanggal`, `id_pengepul`, `id_petugas`, `total_barang`, `total_harga`) VALUES
('1611020001', '2016-11-02', 'BSP001', 'A001', 28, 41250);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `detail_beli`
--
ALTER TABLE `detail_beli`
  ADD CONSTRAINT `detail_beli_ibfk_1` FOREIGN KEY (`no_transaksi`) REFERENCES `setor_pengepul` (`no_transaksi`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `detail_beli_ibfk_2` FOREIGN KEY (`id_sampah`) REFERENCES `sampah` (`id_sampah`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `detail_setor`
--
ALTER TABLE `detail_setor`
  ADD CONSTRAINT `detail_setor_ibfk_1` FOREIGN KEY (`id_sampah`) REFERENCES `sampah` (`id_sampah`),
  ADD CONSTRAINT `detail_setor_ibfk_2` FOREIGN KEY (`no_transaksi`) REFERENCES `setor_nasabah` (`no_transaksi`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `pengambilan`
--
ALTER TABLE `pengambilan`
  ADD CONSTRAINT `pengambilan_ibfk_1` FOREIGN KEY (`id_nasabah`) REFERENCES `nasabah` (`id_nasabah`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `petugas`
--
ALTER TABLE `petugas`
  ADD CONSTRAINT `petugas_ibfk_1` FOREIGN KEY (`id_petugas`) REFERENCES `pengambilan` (`id_petugas`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `setor_nasabah`
--
ALTER TABLE `setor_nasabah`
  ADD CONSTRAINT `setor_nasabah_ibfk_1` FOREIGN KEY (`id_petugas`) REFERENCES `petugas` (`id_petugas`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `setor_pengepul`
--
ALTER TABLE `setor_pengepul`
  ADD CONSTRAINT `setor_pengepul_ibfk_1` FOREIGN KEY (`id_pengepul`) REFERENCES `pengepul` (`id_pengepul`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `setor_pengepul_ibfk_2` FOREIGN KEY (`id_petugas`) REFERENCES `petugas` (`id_petugas`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
