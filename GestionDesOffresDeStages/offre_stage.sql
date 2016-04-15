-- phpMyAdmin SQL Dump
-- version 4.1.4
-- http://www.phpmyadmin.net
--
-- Client :  127.0.0.1
-- Généré le :  Jeu 14 Avril 2016 à 16:44
-- Version du serveur :  5.6.15-log
-- Version de PHP :  5.4.24

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de données :  `offre_stage`
--

-- --------------------------------------------------------

--
-- Structure de la table `entreprise`
--

CREATE TABLE IF NOT EXISTS `entreprise` (
  `idEntreprise` int(11) NOT NULL AUTO_INCREMENT,
  `raisonSociale` varchar(60) NOT NULL,
  `adresseVille` varchar(60) NOT NULL,
  `adresseRue` varchar(60) NOT NULL,
  `adresseCodePostal` varchar(60) NOT NULL,
  `telephone` varchar(60) NOT NULL,
  `secteur` varchar(60) NOT NULL,
  `Mail` varchar(60) NOT NULL,
  PRIMARY KEY (`idEntreprise`),
  UNIQUE KEY `raisonSociale_2` (`raisonSociale`),
  KEY `raisonSociale` (`raisonSociale`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=33 ;

--
-- Contenu de la table `entreprise`
--

INSERT INTO `entreprise` (`idEntreprise`, `raisonSociale`, `adresseVille`, `adresseRue`, `adresseCodePostal`, `telephone`, `secteur`, `Mail`) VALUES
(32, 'LDS', 'Evry cedex', '4 rue jean', '91000', '0102030405', 'Transport', 'lds@transport.fr');

-- --------------------------------------------------------

--
-- Structure de la table `offrestage`
--

CREATE TABLE IF NOT EXISTS `offrestage` (
  `idOffreStage` int(11) NOT NULL AUTO_INCREMENT,
  `libelle` varchar(60) NOT NULL,
  `descriptif` varchar(60) NOT NULL,
  `domaine` varchar(100) NOT NULL,
  `dateDebut` date NOT NULL,
  `durée` varchar(60) NOT NULL,
  `chemin` varchar(60) NOT NULL,
  `valide(O/N)` varchar(60) NOT NULL,
  `laSociété` varchar(60) NOT NULL,
  `idEntreprise` int(11) NOT NULL,
  PRIMARY KEY (`idOffreStage`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Contenu de la table `offrestage`
--

INSERT INTO `offrestage` (`idOffreStage`, `libelle`, `descriptif`, `domaine`, `dateDebut`, `durée`, `chemin`, `valide(O/N)`, `laSociété`, `idEntreprise`) VALUES
(1, 'Conducteur de Poid Lourd', 'Permis C obligatoire, long trajet à effectuer , ponctuelle', 'Transport', '2016-04-28', '3 mois', 'aucun', ' ', 'raisonSociale', 32),
(2, 'Secretaire du directeur', 'Remplacer la secretaire, bonne maitrise des outils bureautiq', 'Transport', '2016-04-06', '6 mois', 'aucun', ' ', 'raisonSociale', 32),
(3, 'JE RE TESTE', 'encore un test', 'Transport', '2016-04-29', '2 mois', 'aucun', ' ', 'raisonSociale', 32);

-- --------------------------------------------------------

--
-- Structure de la table `postulant`
--

CREATE TABLE IF NOT EXISTS `postulant` (
  `Nom` varchar(60) NOT NULL,
  `Prenom` varchar(60) NOT NULL,
  `Mail` varchar(60) NOT NULL,
  `CV` varchar(60) NOT NULL,
  `numeroOffre` int(11) NOT NULL,
  `idPostulant` int(11) NOT NULL AUTO_INCREMENT,
  `raisonSociale` varchar(60) NOT NULL,
  PRIMARY KEY (`idPostulant`),
  KEY `raisonSociale` (`raisonSociale`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Contenu de la table `postulant`
--

INSERT INTO `postulant` (`Nom`, `Prenom`, `Mail`, `CV`, `numeroOffre`, `idPostulant`, `raisonSociale`) VALUES
('Jeyakumar', 'Jena', '', '', 0, 1, '32');

-- --------------------------------------------------------

--
-- Structure de la table `profil`
--

CREATE TABLE IF NOT EXISTS `profil` (
  `Nom` varchar(60) NOT NULL,
  `Prenom` varchar(60) NOT NULL,
  `User` varchar(60) NOT NULL,
  `MDP` varchar(60) NOT NULL,
  `TypeProfil` varchar(60) NOT NULL,
  `CV` varchar(60) NOT NULL,
  `LetttreMotiv` varchar(60) NOT NULL,
  `Mail` varchar(60) NOT NULL,
  PRIMARY KEY (`User`),
  KEY `TypeProfil` (`TypeProfil`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Contenu de la table `profil`
--

INSERT INTO `profil` (`Nom`, `Prenom`, `User`, `MDP`, `TypeProfil`, `CV`, `LetttreMotiv`, `Mail`) VALUES
('Jeyakumar', 'Jena', 'Jena', 'Jena%2016', '1', '', '', ''),
('Camara', 'Magou', 'Magou', 'Magou%2016', '1', '', '', ''),
('Raph', 'Raph', 'raph', 'raph%2016', '2', '', '', ''),
('SObieski', 'Seb', 'seb', 'seb%2016', '2', '', '', ''),
('Ajili', 'Wass', 'WassLaMenace', 'wass%2016', '2', '', '', '');

-- --------------------------------------------------------

--
-- Structure de la table `type_profil`
--

CREATE TABLE IF NOT EXISTS `type_profil` (
  `idType` int(11) NOT NULL AUTO_INCREMENT,
  `libelle` varchar(60) NOT NULL,
  PRIMARY KEY (`idType`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Contenu de la table `type_profil`
--

INSERT INTO `type_profil` (`idType`, `libelle`) VALUES
(1, 'administrateur'),
(2, 'utilisateur');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
