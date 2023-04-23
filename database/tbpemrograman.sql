-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 23, 2023 at 08:11 AM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 7.4.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `tbpemrograman`
--

-- --------------------------------------------------------

--
-- Table structure for table `transaksi_masuk`
--

CREATE TABLE `transaksi_masuk` (
  `id_masuk` int(55) NOT NULL,
  `supplier` varchar(55) NOT NULL,
  `jenis` varchar(55) NOT NULL,
  `tanggal` varchar(55) NOT NULL,
  `jumlah_unit` int(55) NOT NULL,
  `harga` int(55) NOT NULL,
  `total` int(55) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `transaksi_masuk`
--

INSERT INTO `transaksi_masuk` (`id_masuk`, `supplier`, `jenis`, `tanggal`, `jumlah_unit`, `harga`, `total`) VALUES
(12, 'A', 'Matic', 'Friday, 13 January 2023', 2, 40000, 80000),
(13, 'B', 'Gigi', 'Friday, 13 January 2023', 3, 50000, 150000),
(14, 'C', 'Sport', 'Friday, 13 January 2023', 4, 60000, 240000);

-- --------------------------------------------------------

--
-- Table structure for table `transaksi_penjualan`
--

CREATE TABLE `transaksi_penjualan` (
  `id_penjualan` int(30) NOT NULL,
  `id_unit` int(11) NOT NULL,
  `id_pegawai` int(11) NOT NULL,
  `nama_customer` varchar(50) NOT NULL,
  `jenis` varchar(55) NOT NULL,
  `tanggal` varchar(55) NOT NULL,
  `kondisi` varchar(55) NOT NULL,
  `jumlah_unit` int(55) NOT NULL,
  `total` int(55) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `transaksi_penjualan`
--

INSERT INTO `transaksi_penjualan` (`id_penjualan`, `id_unit`, `id_pegawai`, `nama_customer`, `jenis`, `tanggal`, `kondisi`, `jumlah_unit`, `total`) VALUES
(15, 1, 1, 'Andi', '1', 'Saturday, 14 January 2023', 'Baru', 22, 880000),
(16, 2, 2, 'Beno', '2', 'Saturday, 14 January 2023', 'Baru', 22, 880000),
(17, 3, 3, 'Cadi', '3', 'Saturday, 14 January 2023', 'Baru', 22, 880000);

-- --------------------------------------------------------

--
-- Table structure for table `t_customer`
--

CREATE TABLE `t_customer` (
  `id_customer` int(30) NOT NULL,
  `nama_customer` varchar(50) NOT NULL,
  `nomor_ktp` int(50) NOT NULL,
  `alamat` varchar(50) NOT NULL,
  `jenis_motor` varchar(30) NOT NULL,
  `nomor_hp` int(50) NOT NULL,
  `tanggal_pembelian` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_customer`
--

INSERT INTO `t_customer` (`id_customer`, `nama_customer`, `nomor_ktp`, `alamat`, `jenis_motor`, `nomor_hp`, `tanggal_pembelian`) VALUES
(6, 'Maulana', 2147483647, 'Sukahaji, Majalengka', 'Matic', 2147483647, 'Friday, 13 January 2023'),
(7, 'Adam', 123456, 'Sukahaji', 'Matic', 123456, 'Saturday, 14 January 2023'),
(8, 'Firda Y', 1234567, 'Bandung', 'Matic', 853333, 'Sunday, 15 January 2023');

-- --------------------------------------------------------

--
-- Table structure for table `t_pegawai`
--

CREATE TABLE `t_pegawai` (
  `id_pegawai` int(30) NOT NULL,
  `nama_pegawai` varchar(50) NOT NULL,
  `jabatan` varchar(50) NOT NULL,
  `alamat` varchar(50) NOT NULL,
  `jenis_kelamin` varchar(30) NOT NULL,
  `umur` int(50) NOT NULL,
  `nohp` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_pegawai`
--

INSERT INTO `t_pegawai` (`id_pegawai`, `nama_pegawai`, `jabatan`, `alamat`, `jenis_kelamin`, `umur`, `nohp`) VALUES
(1, 'Ana', 'Admin', 'Majalengka', 'Perempuan', 19, '0851'),
(2, 'Bani', 'Admin', 'Majalengka', 'Laki-Laki', 20, '0852'),
(3, 'Cani', 'Admin', 'Majalengka', 'Laki-Laki', 21, '0853'),
(7, 'Dani', 'Admin', 'Bandung', 'Laki-Laki', 19, '0851234'),
(8, 'Erna', 'Admin', 'Bandung', 'Perempuan', 21, '321');

-- --------------------------------------------------------

--
-- Table structure for table `t_unit`
--

CREATE TABLE `t_unit` (
  `id_unit` int(30) NOT NULL,
  `jenis` varchar(50) NOT NULL,
  `jumlah_unit` int(50) NOT NULL,
  `harga` int(55) NOT NULL,
  `tahun_produksi` int(55) NOT NULL,
  `kondisi` varchar(55) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_unit`
--

INSERT INTO `t_unit` (`id_unit`, `jenis`, `jumlah_unit`, `harga`, `tahun_produksi`, `kondisi`) VALUES
(1, 'Matic', 11, 40000, 2021, 'Baru'),
(2, 'Gigi', 12, 50000, 2022, 'Baru'),
(3, 'Sport', 13, 60000, 2023, 'Baru');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `id` int(11) NOT NULL,
  `username` varchar(55) NOT NULL,
  `password` varchar(55) NOT NULL,
  `role` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id`, `username`, `password`, `role`) VALUES
(8, 'xx', 'xx', 'superadmin'),
(32, 'aa', 'aa', 'admin'),
(33, 'zz', 'zz', 'superadmin'),
(34, 'bb', 'bb', 'admin'),
(35, 'firda', 'firda', 'admin'),
(36, 'ahmad', 'ahmad', 'admin');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `transaksi_masuk`
--
ALTER TABLE `transaksi_masuk`
  ADD PRIMARY KEY (`id_masuk`);

--
-- Indexes for table `transaksi_penjualan`
--
ALTER TABLE `transaksi_penjualan`
  ADD PRIMARY KEY (`id_penjualan`);

--
-- Indexes for table `t_customer`
--
ALTER TABLE `t_customer`
  ADD PRIMARY KEY (`id_customer`);

--
-- Indexes for table `t_pegawai`
--
ALTER TABLE `t_pegawai`
  ADD PRIMARY KEY (`id_pegawai`);

--
-- Indexes for table `t_unit`
--
ALTER TABLE `t_unit`
  ADD PRIMARY KEY (`id_unit`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `transaksi_masuk`
--
ALTER TABLE `transaksi_masuk`
  MODIFY `id_masuk` int(55) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `transaksi_penjualan`
--
ALTER TABLE `transaksi_penjualan`
  MODIFY `id_penjualan` int(30) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT for table `t_customer`
--
ALTER TABLE `t_customer`
  MODIFY `id_customer` int(30) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `t_pegawai`
--
ALTER TABLE `t_pegawai`
  MODIFY `id_pegawai` int(30) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `t_unit`
--
ALTER TABLE `t_unit`
  MODIFY `id_unit` int(30) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
