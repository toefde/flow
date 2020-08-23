-- --------------------------------------------------------
-- Host:                         192.168.0.26
-- Server Version:               10.3.22-MariaDB-1ubuntu1 - Ubuntu 20.04
-- Server Betriebssystem:        debian-linux-gnu
-- HeidiSQL Version:             11.0.0.5919
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Exportiere Datenbank Struktur für flow
CREATE DATABASE IF NOT EXISTS `flow` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;
USE `flow`;

-- Exportiere Struktur von Tabelle flow.aufgaben
CREATE TABLE IF NOT EXISTS `aufgaben` (
  `aid` int(11) NOT NULL AUTO_INCREMENT,
  `titel` varchar(50) NOT NULL,
  `beschreibung` varchar(50) NOT NULL,
  `status` varchar(50) NOT NULL,
  `prio` varchar(50) NOT NULL,
  `kategorie` int(11) NOT NULL DEFAULT 1,
  `bearbeiter` int(11) NOT NULL,
  `ticketnr` varchar(50) DEFAULT NULL,
  `erstellt` timestamp NOT NULL DEFAULT current_timestamp(),
  `bearbeitet` timestamp NOT NULL DEFAULT current_timestamp(),
  PRIMARY KEY (`aid`),
  KEY `FK_aufgaben_benutzer` (`bearbeiter`),
  KEY `FK_aufgaben_kategorien` (`kategorie`),
  CONSTRAINT `FK_aufgaben_benutzer` FOREIGN KEY (`bearbeiter`) REFERENCES `benutzer` (`bid`),
  CONSTRAINT `FK_aufgaben_kategorien` FOREIGN KEY (`kategorie`) REFERENCES `kategorien` (`kid`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4;

-- Daten Export vom Benutzer nicht ausgewählt

-- Exportiere Struktur von Tabelle flow.benutzer
CREATE TABLE IF NOT EXISTS `benutzer` (
  `bid` int(11) NOT NULL AUTO_INCREMENT,
  `benutzername` varchar(50) NOT NULL DEFAULT '',
  `vorname` varchar(50) NOT NULL DEFAULT '',
  `nachname` varchar(50) NOT NULL DEFAULT '',
  `passwort` varchar(50) NOT NULL DEFAULT '',
  `rechte` int(11) DEFAULT 2,
  PRIMARY KEY (`bid`),
  KEY `FK_benutzer_rechte` (`rechte`),
  CONSTRAINT `FK_benutzer_rechte` FOREIGN KEY (`rechte`) REFERENCES `rechte` (`rid`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4;

-- Daten Export vom Benutzer nicht ausgewählt

-- Exportiere Struktur von Tabelle flow.kategorien
CREATE TABLE IF NOT EXISTS `kategorien` (
  `kid` int(11) NOT NULL AUTO_INCREMENT,
  `kategorie` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`kid`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4;

-- Daten Export vom Benutzer nicht ausgewählt

-- Exportiere Struktur von Tabelle flow.prio
CREATE TABLE IF NOT EXISTS `prio` (
  `pid` int(11) NOT NULL,
  `prioritaet` varchar(50) NOT NULL DEFAULT '0',
  PRIMARY KEY (`pid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Daten Export vom Benutzer nicht ausgewählt

-- Exportiere Struktur von Tabelle flow.rechte
CREATE TABLE IF NOT EXISTS `rechte` (
  `rid` int(11) NOT NULL AUTO_INCREMENT,
  `rechte` varchar(50) NOT NULL DEFAULT 'USER',
  PRIMARY KEY (`rid`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4;

-- Daten Export vom Benutzer nicht ausgewählt

-- Exportiere Struktur von Tabelle flow.staende
CREATE TABLE IF NOT EXISTS `staende` (
  `sid` int(11) NOT NULL AUTO_INCREMENT,
  `stand` varchar(50) DEFAULT NULL,
  `aufgabe` int(11) NOT NULL,
  `bearbeiter` int(11) NOT NULL,
  `erstellt` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  PRIMARY KEY (`sid`),
  KEY `FK_staende_aufgaben` (`aufgabe`),
  KEY `FK_staende_benutzer` (`bearbeiter`),
  CONSTRAINT `FK_staende_aufgaben` FOREIGN KEY (`aufgabe`) REFERENCES `aufgaben` (`aid`),
  CONSTRAINT `FK_staende_benutzer` FOREIGN KEY (`bearbeiter`) REFERENCES `benutzer` (`bid`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4;

-- Daten Export vom Benutzer nicht ausgewählt

-- Exportiere Struktur von Tabelle flow.status
CREATE TABLE IF NOT EXISTS `status` (
  `sid` int(11) NOT NULL AUTO_INCREMENT,
  `status` varchar(50) NOT NULL DEFAULT '0',
  PRIMARY KEY (`sid`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4;

-- Daten Export vom Benutzer nicht ausgewählt

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
