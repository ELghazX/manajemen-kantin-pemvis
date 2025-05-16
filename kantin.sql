-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 16, 2025 at 12:38 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `kantin`
--

-- --------------------------------------------------------

--
-- Table structure for table `detail_transaksi`
--

CREATE TABLE `detail_transaksi` (
  `id` int(11) NOT NULL,
  `transaksi_id` int(11) DEFAULT NULL,
  `produk_id` int(11) DEFAULT NULL,
  `jumlah` int(11) DEFAULT NULL,
  `subtotal` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `detail_transaksi`
--

INSERT INTO `detail_transaksi` (`id`, `transaksi_id`, `produk_id`, `jumlah`, `subtotal`) VALUES
(1, 1, 1, 2, 10000.00),
(2, 2, 2, 2, 30000.00),
(3, 3, 1, 1, 5000.00),
(4, 3, 2, 1, 15000.00),
(5, 4, 1, 1, 5000.00),
(6, 4, 2, 1, 15000.00),
(7, 5, 2, 1, 15000.00),
(8, 5, 4, 1, 5000.00),
(9, 6, 2, 1, 15000.00),
(10, 7, 2, 1, 15000.00),
(11, 7, 4, 1, 5000.00),
(12, 7, 5, 1, 5000.00),
(13, 8, 2, 2, 30000.00),
(14, 9, 2, 2, 30000.00),
(15, 10, 2, 1, 15000.00),
(16, 10, 4, 4, 20000.00),
(17, 11, 5, 2, 10000.00),
(18, 11, 4, 1, 5000.00),
(19, 12, 1, 2, 10000.00),
(20, 12, 2, 3, 45000.00),
(21, 13, 5, 1, 5000.00),
(22, 13, 4, 1, 5000.00),
(23, 13, 2, 2, 30000.00),
(24, 14, 2, 3, 45000.00),
(25, 14, 4, 1, 5000.00),
(26, 15, 5, 2, 10000.00),
(27, 15, 7, 2, 10000.00);

-- --------------------------------------------------------

--
-- Table structure for table `produk`
--

CREATE TABLE `produk` (
  `id` int(11) NOT NULL,
  `nama` varchar(100) DEFAULT NULL,
  `harga` decimal(10,2) DEFAULT NULL,
  `status` enum('Aktif','Nonaktif') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `produk`
--

INSERT INTO `produk` (`id`, `nama`, `harga`, `status`) VALUES
(1, 'Es Teh', 5000.00, 'Aktif'),
(2, 'Ayam Geprek', 15000.00, 'Aktif'),
(3, 'Nutrisari', 5000.00, 'Aktif'),
(4, 'Jamur Crispy', 5000.00, 'Aktif'),
(5, 'Teh Lemon', 5000.00, 'Aktif'),
(6, 'Kentang Mustofa', 10000.00, 'Nonaktif'),
(7, 'Ampal Jagung', 5000.00, 'Aktif'),
(8, 'Es Jeruk', 5000.00, 'Aktif');

-- --------------------------------------------------------

--
-- Table structure for table `transaksi`
--

CREATE TABLE `transaksi` (
  `id` int(11) NOT NULL,
  `user_id` int(11) DEFAULT NULL,
  `tanggal` datetime DEFAULT current_timestamp(),
  `total_bayar` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `transaksi`
--

INSERT INTO `transaksi` (`id`, `user_id`, `tanggal`, `total_bayar`) VALUES
(1, 2, '2025-05-14 12:43:54', 10000.00),
(2, 2, '2025-05-14 13:13:59', 30000.00),
(3, 2, '2025-05-14 13:33:40', 20000.00),
(4, 2, '2025-05-15 02:40:38', 20000.00),
(5, 2, '2025-05-15 06:57:21', 20000.00),
(6, 2, '2025-05-15 07:05:07', 15000.00),
(7, 2, '2025-05-15 07:12:05', 25000.00),
(8, 2, '2025-05-15 07:16:21', 30000.00),
(9, 2, '2025-05-15 11:04:53', 30000.00),
(10, 2, '2025-05-15 11:07:49', 35000.00),
(11, 2, '2025-05-16 02:52:13', 15000.00),
(12, 2, '2025-05-16 02:57:18', 55000.00),
(13, 2, '2025-05-16 03:00:55', 40000.00),
(14, 2, '2025-05-16 03:02:36', 50000.00),
(15, 2, '2025-05-16 05:56:58', 20000.00);

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `id` int(11) NOT NULL,
  `nama` varchar(100) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `role` enum('admin','kasir') DEFAULT NULL,
  `is_deleted` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id`, `nama`, `email`, `password`, `role`, `is_deleted`) VALUES
(1, 'Admin Satu', 'admin@gmail.com', 'admin123', 'admin', 0),
(2, 'Kasir Satu', 'kasir@gmail.com', 'kasir123', 'kasir', 0),
(3, 'Ghazali', 'ghazali@gmail.com', '123123', 'kasir', 0),
(4, 'Aiman', 'aiman@gmail.com', '123123', 'kasir', 1),
(5, 'Arya', 'arya@gmail.com', '123123', 'kasir', 1),
(6, 'jorip', 'Jorip@gmail.com', 'ijopr1', 'kasir', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `detail_transaksi`
--
ALTER TABLE `detail_transaksi`
  ADD PRIMARY KEY (`id`),
  ADD KEY `transaksi_id` (`transaksi_id`),
  ADD KEY `produk_id` (`produk_id`);

--
-- Indexes for table `produk`
--
ALTER TABLE `produk`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `transaksi`
--
ALTER TABLE `transaksi`
  ADD PRIMARY KEY (`id`),
  ADD KEY `user_id` (`user_id`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `emaial` (`email`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `detail_transaksi`
--
ALTER TABLE `detail_transaksi`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;

--
-- AUTO_INCREMENT for table `produk`
--
ALTER TABLE `produk`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `transaksi`
--
ALTER TABLE `transaksi`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `detail_transaksi`
--
ALTER TABLE `detail_transaksi`
  ADD CONSTRAINT `detail_transaksi_ibfk_1` FOREIGN KEY (`transaksi_id`) REFERENCES `transaksi` (`id`),
  ADD CONSTRAINT `detail_transaksi_ibfk_2` FOREIGN KEY (`produk_id`) REFERENCES `produk` (`id`);

--
-- Constraints for table `transaksi`
--
ALTER TABLE `transaksi`
  ADD CONSTRAINT `transaksi_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `user` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
