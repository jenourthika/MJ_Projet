-- phpMyAdmin SQL Dump
-- version 4.1.4
-- http://www.phpmyadmin.net
--
-- Client :  127.0.0.1
-- Généré le :  Dim 17 Avril 2016 à 10:02
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
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=12 ;

--
-- Contenu de la table `entreprise`
--

INSERT INTO `entreprise` (`idEntreprise`, `raisonSociale`, `adresseVille`, `adresseRue`, `adresseCodePostal`, `telephone`, `secteur`, `Mail`) VALUES
(1, 'Les démenageurs sereins', 'Angerville', '3 rue jean jaurès', '91670', '0102030405', 'Transport', 'lds@transport.fr'),
(2, 'O Coeur de l''olivier', 'Etampes', '7 avenue de l''europe', '91150', '0109080706', 'Cosmétique', 'ocoeur@cosmetique.fr'),
(3, 'eniac', 'Malesherbes', '3 rue du chemin vert', '45001', '0201040506', 'Informatique', 'eniac@informatique.fr'),
(4, 'Manasoft', 'Evry', '7 chemin des terres cuites', '91000', '0105060704', 'Batiment', 'mana@batiment.fr'),
(5, 'ConsultingPower', 'Paris 17', '17 boulevard marignand', '75017', '0174565638', 'Services aux entreprises', 'Consulting@SE.fr'),
(6, 'Smilis', 'Bretigny', '3 boulevard haussmann', '91030', '086070456', 'Etudes et Conseils', 'smilis@ec.fr'),
(7, 'bluefree', 'Nanterre', '3 rue paul demange', '92011', '0192345983', 'Banque/Assurance', 'bluefree@banque.fr'),
(8, 'JMRestaurant', 'Moissy Cramayel', '8 rue de berlin', '77001', '0134567838', 'Agroalimentaire', 'jm@agro.fr'),
(9, 'MedericSociety', 'Malakoff', '3 avenue lafitte', '92340', '0165478932', 'Multimedia', 'ms@multimedia.fr'),
(10, 'thalatos', 'Rambouillet', '3 chemin du vieux port', '78002', '0123986745', 'Industrie pharmaceutique', 'thalatos@ip.fr'),
(11, 'spa', 'Paris', '3 rue cherche midi', '75007', '0403020105', 'soin beaute', 'spa@spa.fr');

-- --------------------------------------------------------

--
-- Structure de la table `offrestage`
--

CREATE TABLE IF NOT EXISTS `offrestage` (
  `idOffreStage` int(11) NOT NULL AUTO_INCREMENT,
  `libelle` varchar(60) NOT NULL,
  `descriptif` varchar(200) NOT NULL,
  `domaine` varchar(100) NOT NULL,
  `dateDebut` date NOT NULL,
  `durée` varchar(60) NOT NULL,
  `chemin` varchar(60) NOT NULL,
  `valide` varchar(60) NOT NULL,
  `laSociété` varchar(60) NOT NULL,
  `idEntreprise` int(11) NOT NULL,
  PRIMARY KEY (`idOffreStage`),
  KEY `idEntreprise` (`idEntreprise`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Contenu de la table `offrestage`
--

INSERT INTO `offrestage` (`idOffreStage`, `libelle`, `descriptif`, `domaine`, `dateDebut`, `durée`, `chemin`, `valide`, `laSociété`, `idEntreprise`) VALUES
(1, 'Stagiaire developpeur java j2ee', 'Mission : refonte de application pour les salariés de bluefree\nForte Connaissance en JAVA recommandée', 'Informatique', '2016-04-16', '3 mois', 'C://', 'oui', 'bluefree', 7),
(2, 'Apprenti cuisinier', 'Formation dans les patisseries', 'Agroalimentaire', '2016-04-23', '3 mois', 'C://', ' oui', 'JMRestaurant', 8);

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
('Raph', 'Raph', 'raph@raph.fr', '', 2, 1, 'JMRestaurant ');

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
  `CV` longblob NOT NULL,
  `Mail` varchar(60) NOT NULL,
  PRIMARY KEY (`User`),
  KEY `TypeProfil` (`TypeProfil`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Contenu de la table `profil`
--

INSERT INTO `profil` (`Nom`, `Prenom`, `User`, `MDP`, `TypeProfil`, `CV`, `Mail`) VALUES
('Jeyakumar', 'Jena', 'Jena', 'Jena%2016', '1', '', 'jena@admin.fr'),
('Camara', 'Magou', 'Magou', 'Magou%2016', '1', '', 'magou@admin.fr'),
('Raph', 'Raph', 'raph', 'raph%2016', '2', '', 'raph@raph.fr'),
('Sobieski', 'Seb', 'seb', 'seb%2016', '2', '', 'seb@seb.fr'),
('Ajili', 'Wass', 'WassLaMenace', 'wass%2016', '2', '', 'wass@wass.fr'),
('dscsd', 'sdcsdc', 'dscdc', 'sdcdscd', '2', 0x433a55736572736d61676f75446f776e6c6f6164736a75737469666963617469662e706466, 'csdcds'),
('Guerra', 'Marine', 'marine', 'marine%2016', '2', 0x433a55736572736d61676f75446f776e6c6f6164734356656e7472657469656e2e706466, 'marine@marine.fr');

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
