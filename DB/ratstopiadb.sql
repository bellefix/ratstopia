-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Värd: 127.0.0.1
-- Tid vid skapande: 09 jan 2023 kl 19:33
-- Serverversion: 10.4.27-MariaDB
-- PHP-version: 8.1.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Databas: `ratstopiadb`
--

-- --------------------------------------------------------

--
-- Tabellstruktur `customers`
--

CREATE TABLE `customers` (
  `id` int(11) NOT NULL,
  `name` varchar(80) NOT NULL,
  `last_name` varchar(150) NOT NULL,
  `address` varchar(120) NOT NULL,
  `mail` varchar(80) NOT NULL,
  `phone_number` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumpning av Data i tabell `customers`
--

INSERT INTO `customers` (`id`, `name`, `last_name`, `address`, `mail`, `phone_number`) VALUES
(1, 'Olle', 'Hammarström', 'Valhallavägen 4b, 52493 Hudene', 'ollehammarstrom@gmail.com', '0722450088'),
(2, 'Helena', 'Rundqvist', 'Törnvägen 5, 52431 Floby', 'helena1977@live.se', '0736667821'),
(3, 'Martin', 'Warg', 'tallbarrevägen 2', 'martin@live.se', '0706556677'),
(4, 'Isabell', 'Gustafsson', 'tubbarp 8', 'isabell@gmail.com', '0722429595'),
(9, 'Oskar', 'Wigertsson', 'Leksaksgatan 3', 'oskar@live.se', '0706789844'),
(10, 'dsada', 'dsadas', 'dasdasdas', 'sdasdasas', '34423432432'),
(11, 'sdsadsa', 'dsadasdas', 'dasdasdas', 'sadsddasd', 'dasdasda'),
(12, 'sdasdas', 'dasasda', 'sdsada', 's', 'sada'),
(13, 'dfsdf', 'dsfd', 'fdsdfs', 'fsdfsd', 'fdsfsdf'),
(14, 'Krister', 'Trangius', 'göteborg', 'krister@hotmail.com', '0707585858'),
(15, 'Hasse', 'Andersson', 'Götagården 4', 'Hassebosse@gmail.com', '0708996677'),
(16, 'dsdasd', 'sffdssffsd', 'fdsfsdfsd', 'dfsfdsfsd', 'fsdfsdfsd'),
(17, 'dsadas', 'dsads', 'dasdas', 'dsadasdas', 'sdsadas');

-- --------------------------------------------------------

--
-- Tabellstruktur `members`
--

CREATE TABLE `members` (
  `id` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `last_name` varchar(100) NOT NULL,
  `address` varchar(120) NOT NULL,
  `mail` varchar(100) NOT NULL,
  `phone_number` varchar(15) NOT NULL,
  `role_id` varchar(11) NOT NULL,
  `username` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumpning av Data i tabell `members`
--

INSERT INTO `members` (`id`, `name`, `last_name`, `address`, `mail`, `phone_number`, `role_id`, `username`, `password`) VALUES
(1, 'Angelina', 'Holmqvist', 'Tåmarksgatan 4', 'angelinaholmqvist@live.se', '0737000820', '2', '', ''),
(2, 'Albin', 'Torslund', 'Tallgatan 5', 'albintors@gmail.com', '0722565695', '2', '', ''),
(3, 'Ylva', 'Haugstad', 'Torp 8', 'ylva90@hotmail.com', '0727005699', '2', '', ''),
(4, 'Isabell', 'Gustafsson', 'Tubbarp 8', 'bellefixgustafsson@outlook.com', '0722429595', '1', '', ''),
(5, 'Joel', 'Hildén', 'Västergården 2', 'jolle@gmail.com', '0706394909', '2', '', ''),
(7, 'Irene', 'Gustafsson', 'Annelund 15B', 'irene@live.se', '0706409039', '2', '', ''),
(8, 'Daniel', 'Andersson', 'Östlyckan 6', 'daniel@live.se', '0706234589', '2', '', ''),
(9, 'Elsa', 'Johansson', 'Kajakvägen 8', 'elsaj@live.se', '0737556677', '2', 'elsajohansson13', 'blomman123'),
(10, 'Izza', 'Myhre', 'Tubbetorp', 'bellefixen@live.se', '0722429595', '2', 'Bellefnuttis', 'gustafsson20'),
(11, 'Krister', 'Trangius', 'Göteborg', 'krister@live.se', '0707676767', '2', 'Trangiusarus', 'apa123');

-- --------------------------------------------------------

--
-- Tabellstruktur `orders`
--

CREATE TABLE `orders` (
  `id` int(11) NOT NULL,
  `customer_id` int(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumpning av Data i tabell `orders`
--

INSERT INTO `orders` (`id`, `customer_id`) VALUES
(1, 2),
(2, 10),
(3, 11),
(4, 12),
(5, 13),
(6, 14),
(7, 15),
(8, 16),
(9, 17);

-- --------------------------------------------------------

--
-- Tabellstruktur `products`
--

CREATE TABLE `products` (
  `id` int(11) NOT NULL,
  `product` varchar(100) NOT NULL,
  `price` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumpning av Data i tabell `products`
--

INSERT INTO `products` (`id`, `product`, `price`) VALUES
(1, 'Rat-Calendar 2023-2024', 169),
(2, 'Ratstopias Rat-Food', 219),
(3, 'Ratstopias Post-Card', 39);

-- --------------------------------------------------------

--
-- Tabellstruktur `products_to_order`
--

CREATE TABLE `products_to_order` (
  `product_id` int(11) NOT NULL,
  `order_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumpning av Data i tabell `products_to_order`
--

INSERT INTO `products_to_order` (`product_id`, `order_id`) VALUES
(0, 0),
(0, 0),
(0, 0),
(0, 0),
(0, 0),
(0, 0),
(1, 4),
(1, 6);

-- --------------------------------------------------------

--
-- Tabellstruktur `rats`
--

CREATE TABLE `rats` (
  `id` int(11) NOT NULL,
  `is_available` tinyint(1) NOT NULL,
  `member_id` varchar(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `age` varchar(50) NOT NULL,
  `details` varchar(100) NOT NULL,
  `gender` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumpning av Data i tabell `rats`
--

INSERT INTO `rats` (`id`, `is_available`, `member_id`, `name`, `age`, `details`, `gender`) VALUES
(1, 1, '', 'Rex', '5 months', 'Ears Dumbo, Color Albino', 'Male'),
(2, 1, '', 'Lola', '1 year', 'Dove: Very pale grey.', 'Female'),
(3, 1, '', 'Loke', '4 Months', 'Powder Blue: Pale blue/brown.', 'Male'),
(4, 0, '3', 'Lizzy', '7 Months', 'Champagne: Soft cream or off-white.', 'Female');

-- --------------------------------------------------------

--
-- Tabellstruktur `roles`
--

CREATE TABLE `roles` (
  `id` int(11) NOT NULL,
  `role_name` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumpning av Data i tabell `roles`
--

INSERT INTO `roles` (`id`, `role_name`) VALUES
(1, 'admin'),
(2, 'member');

--
-- Index för dumpade tabeller
--

--
-- Index för tabell `customers`
--
ALTER TABLE `customers`
  ADD PRIMARY KEY (`id`);

--
-- Index för tabell `members`
--
ALTER TABLE `members`
  ADD PRIMARY KEY (`id`),
  ADD KEY `role_id` (`role_id`);

--
-- Index för tabell `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`id`),
  ADD KEY `customer_id` (`customer_id`);

--
-- Index för tabell `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`id`);

--
-- Index för tabell `products_to_order`
--
ALTER TABLE `products_to_order`
  ADD KEY `product_id` (`product_id`,`order_id`);

--
-- Index för tabell `rats`
--
ALTER TABLE `rats`
  ADD PRIMARY KEY (`id`),
  ADD KEY `member_id` (`member_id`) USING BTREE;

--
-- Index för tabell `roles`
--
ALTER TABLE `roles`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT för dumpade tabeller
--

--
-- AUTO_INCREMENT för tabell `customers`
--
ALTER TABLE `customers`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT för tabell `members`
--
ALTER TABLE `members`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT för tabell `orders`
--
ALTER TABLE `orders`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT för tabell `products`
--
ALTER TABLE `products`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT för tabell `rats`
--
ALTER TABLE `rats`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT för tabell `roles`
--
ALTER TABLE `roles`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
