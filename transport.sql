-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Июн 08 2021 г., 10:30
-- Версия сервера: 8.0.19
-- Версия PHP: 7.1.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `transport`
--

-- --------------------------------------------------------

--
-- Структура таблицы `client`
--

CREATE TABLE `client` (
  `idClient` int UNSIGNED NOT NULL,
  `SURNAME` varchar(45) DEFAULT NULL,
  `NAME` varchar(45) DEFAULT NULL,
  `ADDRESS` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `drive_vehicle`
--

CREATE TABLE `drive_vehicle` (
  `idDrive_vehicle` int NOT NULL,
  `SURNAME` varchar(45) DEFAULT NULL,
  `NAME` varchar(45) DEFAULT NULL,
  `MIDDLE_NAME` varchar(45) DEFAULT NULL,
  `PHONE_NUMBER` varchar(11) DEFAULT NULL,
  `CATEGORY` varchar(45) DEFAULT NULL,
  `WORK_EXPERIENCE` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `drive_vehicle`
--

INSERT INTO `drive_vehicle` (`idDrive_vehicle`, `SURNAME`, `NAME`, `MIDDLE_NAME`, `PHONE_NUMBER`, `CATEGORY`, `WORK_EXPERIENCE`) VALUES
(1, 'Ivanov', 'Ivan', 'Ivanovich', '89204407052', 'B', '3'),
(2, 'Denisov', 'Denis', 'Denisovich', '123', 'C', '2');

-- --------------------------------------------------------

--
-- Структура таблицы `operator`
--

CREATE TABLE `operator` (
  `idOperator` int NOT NULL,
  `SURNAME` varchar(45) DEFAULT NULL,
  `NAME` varchar(45) DEFAULT NULL,
  `MIDDLE_NAME` varchar(45) DEFAULT NULL,
  `PHONE_NUMBER` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `operator`
--

INSERT INTO `operator` (`idOperator`, `SURNAME`, `NAME`, `MIDDLE_NAME`, `PHONE_NUMBER`) VALUES
(1, 'ads', 'zcx', 'eqw', '123'),
(2, 'Kishinka', 'Nikita', 'Alex', '123');

-- --------------------------------------------------------

--
-- Структура таблицы `order1`
--

CREATE TABLE `order1` (
  `idOrder` int NOT NULL,
  `ORDER_DARE` date DEFAULT NULL,
  `DILIVERY_DARE` date DEFAULT NULL,
  `idClient` int NOT NULL,
  `idOperator` int DEFAULT NULL,
  `idPoint_delivery` int DEFAULT NULL,
  `idProduct` int DEFAULT NULL,
  `idSender` int DEFAULT NULL,
  `idTransport_vehicle` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `order1`
--

INSERT INTO `order1` (`idOrder`, `ORDER_DARE`, `DILIVERY_DARE`, `idClient`, `idOperator`, `idPoint_delivery`, `idProduct`, `idSender`, `idTransport_vehicle`) VALUES
(1, '2021-05-05', '2021-05-04', 1, 1, 1, 1, 1, 1);

-- --------------------------------------------------------

--
-- Структура таблицы `point_delivery`
--

CREATE TABLE `point_delivery` (
  `idPoint_delivery` int NOT NULL,
  `COUNTRY` varchar(45) DEFAULT NULL,
  `CITY` varchar(45) DEFAULT NULL,
  `ADDRESS` varchar(45) DEFAULT NULL,
  `INDEX` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `point_delivery`
--

INSERT INTO `point_delivery` (`idPoint_delivery`, `COUNTRY`, `CITY`, `ADDRESS`, `INDEX`) VALUES
(1, 'W', 'Mos', 'Pus', 1);

-- --------------------------------------------------------

--
-- Структура таблицы `product`
--

CREATE TABLE `product` (
  `idProduct` int NOT NULL,
  `WEIGHT` int DEFAULT NULL,
  `OVERALL_DIMENSIONS` varchar(45) DEFAULT NULL,
  `PRODUCT_CHARACTERISTICS` varchar(45) DEFAULT NULL,
  `PRICE` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `product`
--

INSERT INTO `product` (`idProduct`, `WEIGHT`, `OVERALL_DIMENSIONS`, `PRODUCT_CHARACTERISTICS`, `PRICE`) VALUES
(1, 50, '5x60x7', 'nice', '1200'),
(2, 32, '22', 'good', '300'),
(3, 32, '22', 'good', '400');

-- --------------------------------------------------------

--
-- Структура таблицы `route`
--

CREATE TABLE `route` (
  `idRoute` int NOT NULL,
  `DURATION_HOURS` double DEFAULT NULL,
  `RANGE_KM` double DEFAULT NULL,
  `ROUTE_NUMBER` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `route`
--

INSERT INTO `route` (`idRoute`, `DURATION_HOURS`, `RANGE_KM`, `ROUTE_NUMBER`) VALUES
(1, 23, 25, 'A1'),
(2, 12, 40, '23'),
(3, 55, 32, 'M5');

-- --------------------------------------------------------

--
-- Структура таблицы `sender`
--

CREATE TABLE `sender` (
  `idSender` int NOT NULL,
  `COUNTRY` varchar(45) DEFAULT NULL,
  `CITY` varchar(45) DEFAULT NULL,
  `ADDRESS` varchar(45) DEFAULT NULL,
  `INDEX` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `sender`
--

INSERT INTO `sender` (`idSender`, `COUNTRY`, `CITY`, `ADDRESS`, `INDEX`) VALUES
(1, 'Ept', 'San', 'Pus', '1'),
(2, 'W', 'Mos', 'Quk', '2'),
(3, 'W', 'Mos', 'Olha', '5');

-- --------------------------------------------------------

--
-- Структура таблицы `transport_vehicle`
--

CREATE TABLE `transport_vehicle` (
  `idTransport_vehicle` int NOT NULL,
  `idRoute` int DEFAULT NULL,
  `idDrive_vehicle` int DEFAULT NULL,
  `LOAD_CAPACITY` double DEFAULT NULL,
  `Vehicle_category` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `transport_vehicle`
--

INSERT INTO `transport_vehicle` (`idTransport_vehicle`, `idRoute`, `idDrive_vehicle`, `LOAD_CAPACITY`, `Vehicle_category`) VALUES
(1, 1, 1, 25, 'B');

-- --------------------------------------------------------

--
-- Структура таблицы `users`
--

CREATE TABLE `users` (
  `id` int UNSIGNED NOT NULL,
  `login` varchar(100) NOT NULL,
  `password` varchar(32) NOT NULL,
  `name` varchar(100) NOT NULL,
  `surname` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `users`
--

INSERT INTO `users` (`id`, `login`, `password`, `name`, `surname`) VALUES
(1, 'admin', 'root', 'nikita', 'kishinka'),
(10, 'nikita', '123', 'nikita', 'kishinka');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `client`
--
ALTER TABLE `client`
  ADD PRIMARY KEY (`idClient`);

--
-- Индексы таблицы `drive_vehicle`
--
ALTER TABLE `drive_vehicle`
  ADD PRIMARY KEY (`idDrive_vehicle`);

--
-- Индексы таблицы `operator`
--
ALTER TABLE `operator`
  ADD PRIMARY KEY (`idOperator`);

--
-- Индексы таблицы `order1`
--
ALTER TABLE `order1`
  ADD PRIMARY KEY (`idClient`),
  ADD KEY `idOperator_idx` (`idOperator`),
  ADD KEY `idPoint_delivery_idx` (`idPoint_delivery`),
  ADD KEY `idProduct_idx` (`idProduct`),
  ADD KEY `idSender_idx` (`idSender`),
  ADD KEY `idTransport_vehicle_idx` (`idTransport_vehicle`);

--
-- Индексы таблицы `point_delivery`
--
ALTER TABLE `point_delivery`
  ADD PRIMARY KEY (`idPoint_delivery`);

--
-- Индексы таблицы `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`idProduct`);

--
-- Индексы таблицы `route`
--
ALTER TABLE `route`
  ADD PRIMARY KEY (`idRoute`);

--
-- Индексы таблицы `sender`
--
ALTER TABLE `sender`
  ADD PRIMARY KEY (`idSender`);

--
-- Индексы таблицы `transport_vehicle`
--
ALTER TABLE `transport_vehicle`
  ADD PRIMARY KEY (`idTransport_vehicle`),
  ADD KEY `idRoute_idx` (`idRoute`),
  ADD KEY `idDrive_vehicle_idx` (`idDrive_vehicle`);

--
-- Индексы таблицы `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `client`
--
ALTER TABLE `client`
  MODIFY `idClient` int UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `users`
--
ALTER TABLE `users`
  MODIFY `id` int UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `order1`
--
ALTER TABLE `order1`
  ADD CONSTRAINT `idOperator` FOREIGN KEY (`idOperator`) REFERENCES `operator` (`idOperator`),
  ADD CONSTRAINT `idPoint_delivery` FOREIGN KEY (`idPoint_delivery`) REFERENCES `point_delivery` (`idPoint_delivery`),
  ADD CONSTRAINT `idProduct` FOREIGN KEY (`idProduct`) REFERENCES `product` (`idProduct`),
  ADD CONSTRAINT `idSender` FOREIGN KEY (`idSender`) REFERENCES `sender` (`idSender`),
  ADD CONSTRAINT `idTransport_vehicle` FOREIGN KEY (`idTransport_vehicle`) REFERENCES `transport_vehicle` (`idTransport_vehicle`);

--
-- Ограничения внешнего ключа таблицы `transport_vehicle`
--
ALTER TABLE `transport_vehicle`
  ADD CONSTRAINT `idDrive_vehicle` FOREIGN KEY (`idDrive_vehicle`) REFERENCES `drive_vehicle` (`idDrive_vehicle`),
  ADD CONSTRAINT `idRoute` FOREIGN KEY (`idRoute`) REFERENCES `route` (`idRoute`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
