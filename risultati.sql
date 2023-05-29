-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Creato il: Mag 29, 2023 alle 08:16
-- Versione del server: 10.4.28-MariaDB
-- Versione PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `campionato`
--

-- --------------------------------------------------------

--
-- Struttura della tabella `risultati`
--

CREATE TABLE `risultati` (
  `ID` int(11) NOT NULL,
  `data` date NOT NULL,
  `squadra_casa` varchar(40) NOT NULL,
  `squadra_ospiti` varchar(40) NOT NULL,
  `risultato` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dump dei dati per la tabella `risultati`
--

INSERT INTO `risultati` (`ID`, `data`, `squadra_casa`, `squadra_ospiti`, `risultato`) VALUES
(1, '2022-08-13', 'SAMPDORIA', 'ATALANTA', '0-2'),
(2, '2022-08-21', 'ATALANTA', 'MILAN', '1-1'),
(3, '2022-08-28', 'HELLAS VERONA', 'ATALANTA', '0-1'),
(4, '2022-09-01', 'ATALANTA', 'TORINO', '3-1'),
(5, '2022-10-05', 'MONZA', 'ATALANTA', '0-2'),
(6, '2022-08-13', 'MILAN', 'UDINESE', '4-2'),
(7, '2022-08-27', 'MILAN', 'BOLOGNA', '2-0'),
(8, '2022-08-30', 'SASSUOLO', 'MILAN', '0-0'),
(9, '2022-10-03', 'MILAN', 'INTER', '3-2'),
(10, '2022-08-15', 'HELLAS VERONA', 'NAPOLI', '2-5'),
(11, '2022-08-21', 'NAPOLI', 'MONZA', '4-0'),
(12, '2022-08-28', 'FIORENTINA', 'NAPOLI', '0-0');

--
-- Indici per le tabelle scaricate
--

--
-- Indici per le tabelle `risultati`
--
ALTER TABLE `risultati`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT per le tabelle scaricate
--

--
-- AUTO_INCREMENT per la tabella `risultati`
--
ALTER TABLE `risultati`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
