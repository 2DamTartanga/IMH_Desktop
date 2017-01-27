-- phpMyAdmin SQL Dump
-- version 4.2.7.1
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 26-01-2017 a las 13:20:10
-- Versión del servidor: 5.5.39
-- Versión de PHP: 5.4.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de datos: `bdaimh`
--
CREATE DATABASE IF NOT EXISTS `bdaimh` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_spanish_ci;
USE `bdaimh`;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `breakdowns`
--

CREATE TABLE IF NOT EXISTS `breakdowns` (
  `codBreakdown` int(11) NOT NULL,
  `date` date NOT NULL,
  `codMachine` varchar(15) COLLATE utf8mb4_spanish_ci NOT NULL,
  `reporter` varchar(30) COLLATE utf8mb4_spanish_ci NOT NULL,
  `failureType` varchar(20) COLLATE utf8mb4_spanish_ci NOT NULL,
  `description` varchar(400) COLLATE utf8mb4_spanish_ci NOT NULL,
  `equipmentAvaiable` int(11) NOT NULL,
  `subject` varchar(40) COLLATE utf8mb4_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `groups`
--

CREATE TABLE IF NOT EXISTS `groups` (
  `id` tinyint(4) NOT NULL,
  `role` char(1) COLLATE utf8mb4_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `localizations`
--

CREATE TABLE IF NOT EXISTS `localizations` (
  `idLocalization` int(11) NOT NULL,
  `nameLocalization` varchar(50) COLLATE utf8mb4_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `machines`
--

CREATE TABLE IF NOT EXISTS `machines` (
  `codMachine` varchar(15) COLLATE utf8mb4_spanish_ci NOT NULL,
  `idType` int(11) NOT NULL,
  `serialNumber` varchar(15) COLLATE utf8mb4_spanish_ci NOT NULL,
  `status` varchar(1) COLLATE utf8mb4_spanish_ci NOT NULL,
  `idSection` varchar(2) COLLATE utf8mb4_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `maintenance`
--

CREATE TABLE IF NOT EXISTS `maintenance` (
  `username` varchar(30) COLLATE utf8mb4_spanish_ci NOT NULL,
  `idGroup` tinyint(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `others`
--

CREATE TABLE IF NOT EXISTS `others` (
  `username` varchar(30) COLLATE utf8mb4_spanish_ci NOT NULL,
  `name` varchar(15) COLLATE utf8mb4_spanish_ci NOT NULL,
  `surname` varchar(20) COLLATE utf8mb4_spanish_ci NOT NULL,
  `email` varchar(30) COLLATE utf8mb4_spanish_ci NOT NULL,
  `course` varchar(5) COLLATE utf8mb4_spanish_ci NOT NULL,
  `type` char(1) COLLATE utf8mb4_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `repairs`
--

CREATE TABLE IF NOT EXISTS `repairs` (
  `codBreakdown` int(11) NOT NULL,
  `idGroup` tinyint(4) NOT NULL,
  `repairDate` date NOT NULL,
  `time` float NOT NULL,
  `avaiabilityAfter` int(11) NOT NULL,
  `tools` varchar(30) COLLATE utf8mb4_spanish_ci NOT NULL,
  `repairProcess` varchar(400) COLLATE utf8mb4_spanish_ci NOT NULL,
  `idLocalization` int(11) NOT NULL,
  `isRepaired` tinyint(1) NOT NULL,
  `replacements` varchar(60) COLLATE utf8mb4_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `sections`
--

CREATE TABLE IF NOT EXISTS `sections` (
  `idSection` varchar(2) COLLATE utf8mb4_spanish_ci NOT NULL,
  `nameSection` varchar(20) COLLATE utf8mb4_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `types`
--

CREATE TABLE IF NOT EXISTS `types` (
  `idType` int(11) NOT NULL,
  `nameType` varchar(30) COLLATE utf8mb4_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `users`
--

CREATE TABLE IF NOT EXISTS `users` (
  `username` varchar(30) COLLATE utf8mb4_spanish_ci NOT NULL,
  `password` varchar(15) COLLATE utf8mb4_spanish_ci NOT NULL,
  `type` varchar(1) COLLATE utf8mb4_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

--
-- Volcado de datos para la tabla `users`
--

INSERT INTO `users` (`username`, `password`, `type`) VALUES
('ismael', 'ism', '');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `workorder`
--

CREATE TABLE IF NOT EXISTS `workorder` (
  `idBreakdown` int(11) NOT NULL,
  `severity` int(11) NOT NULL,
  `others` varchar(200) COLLATE utf8mb4_spanish_ci NOT NULL,
  `typeMaintence` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `breakdowns`
--
ALTER TABLE `breakdowns`
 ADD PRIMARY KEY (`codBreakdown`), ADD KEY `codMachine` (`codMachine`);

--
-- Indices de la tabla `groups`
--
ALTER TABLE `groups`
 ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `localizations`
--
ALTER TABLE `localizations`
 ADD PRIMARY KEY (`idLocalization`);

--
-- Indices de la tabla `machines`
--
ALTER TABLE `machines`
 ADD PRIMARY KEY (`codMachine`), ADD KEY `machines_fk1` (`idType`), ADD KEY `machines_fk0` (`idSection`);

--
-- Indices de la tabla `maintenance`
--
ALTER TABLE `maintenance`
 ADD PRIMARY KEY (`username`), ADD KEY `maintenance_fk1` (`idGroup`);

--
-- Indices de la tabla `others`
--
ALTER TABLE `others`
 ADD PRIMARY KEY (`username`);

--
-- Indices de la tabla `repairs`
--
ALTER TABLE `repairs`
 ADD PRIMARY KEY (`codBreakdown`,`idGroup`,`repairDate`), ADD KEY `idLocalization` (`idLocalization`), ADD KEY `idGroup` (`idGroup`);

--
-- Indices de la tabla `sections`
--
ALTER TABLE `sections`
 ADD PRIMARY KEY (`idSection`);

--
-- Indices de la tabla `types`
--
ALTER TABLE `types`
 ADD PRIMARY KEY (`idType`);

--
-- Indices de la tabla `users`
--
ALTER TABLE `users`
 ADD PRIMARY KEY (`username`);

--
-- Indices de la tabla `workorder`
--
ALTER TABLE `workorder`
 ADD PRIMARY KEY (`idBreakdown`);

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `breakdowns`
--
ALTER TABLE `breakdowns`
ADD CONSTRAINT `breakdowns_ibfk_1` FOREIGN KEY (`codMachine`) REFERENCES `machines` (`codMachine`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `machines`
--
ALTER TABLE `machines`
ADD CONSTRAINT `machines_fk0` FOREIGN KEY (`idSection`) REFERENCES `sections` (`idSection`) ON DELETE CASCADE ON UPDATE CASCADE,
ADD CONSTRAINT `machines_fk1` FOREIGN KEY (`idType`) REFERENCES `types` (`idType`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `maintenance`
--
ALTER TABLE `maintenance`
ADD CONSTRAINT `maintenance_ibfk_2` FOREIGN KEY (`idGroup`) REFERENCES `groups` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
ADD CONSTRAINT `maintenance_ibfk_1` FOREIGN KEY (`username`) REFERENCES `others` (`username`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `others`
--
ALTER TABLE `others`
ADD CONSTRAINT `FK_others_users` FOREIGN KEY (`username`) REFERENCES `users` (`username`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `repairs`
--
ALTER TABLE `repairs`
ADD CONSTRAINT `repairs_ibfk_3` FOREIGN KEY (`idLocalization`) REFERENCES `localizations` (`idLocalization`) ON DELETE CASCADE ON UPDATE CASCADE,
ADD CONSTRAINT `repairs_ibfk_1` FOREIGN KEY (`codBreakdown`) REFERENCES `workorder` (`idBreakdown`) ON DELETE CASCADE ON UPDATE CASCADE,
ADD CONSTRAINT `repairs_ibfk_2` FOREIGN KEY (`idGroup`) REFERENCES `groups` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `workorder`
--
ALTER TABLE `workorder`
ADD CONSTRAINT `workorder_ibfk_1` FOREIGN KEY (`idBreakdown`) REFERENCES `breakdowns` (`codBreakdown`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
