-- phpMyAdmin SQL Dump
-- version 4.0.4.2
-- http://www.phpmyadmin.net
--
-- Máquina: localhost
-- Data de Criação: 24-Fev-2026 às 12:53
-- Versão do servidor: 5.6.13
-- versão do PHP: 5.4.17

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de Dados: `db_vittamed`
--
CREATE DATABASE IF NOT EXISTS `db_vittamed` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `db_vittamed`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_agenda`
--

CREATE TABLE IF NOT EXISTS `tb_agenda` (
  `data_horario` varchar(16) NOT NULL DEFAULT '',
  `crm` varchar(60) NOT NULL,
  `paciente` varchar(60) NOT NULL,
  `sala` varchar(3) NOT NULL,
  `atendido` tinyint(1) NOT NULL,
  PRIMARY KEY (`data_horario`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_agenda`
--

INSERT INTO `tb_agenda` (`data_horario`, `crm`, `paciente`, `sala`, `atendido`) VALUES
('23/06/2023 14:00', '842915', 'Roberto Gómes Ferraz', '2', 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_equipamentos`
--

CREATE TABLE IF NOT EXISTS `tb_equipamentos` (
  `id_item` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(60) NOT NULL,
  `categoria` varchar(60) NOT NULL,
  `sala` varchar(3) NOT NULL,
  `disponibilidade` tinyint(1) NOT NULL COMMENT 'CheckBox',
  `devolvido` tinyint(1) NOT NULL COMMENT 'CheckBox',
  `devolvido_horario` varchar(60) NOT NULL COMMENT 'Data e Hora impressa pelo Sistema',
  `pego` tinyint(1) NOT NULL COMMENT 'CheckBox',
  `pego_horario` varchar(60) NOT NULL COMMENT 'Data e Hora impressa pelo Sistema',
  PRIMARY KEY (`id_item`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_login`
--

CREATE TABLE IF NOT EXISTS `tb_login` (
  `senha` varchar(60) NOT NULL DEFAULT '',
  `nome` varchar(60) NOT NULL,
  `email` varchar(60) NOT NULL,
  `tipo` varchar(13) NOT NULL,
  `crm` varchar(60) NOT NULL,
  PRIMARY KEY (`senha`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_login`
--

INSERT INTO `tb_login` (`senha`, `nome`, `email`, `tipo`, `crm`) VALUES
('7082', 'Maria Lúcia', 'marialucia@fatec.sp.gov.br', 'gerente', ''),
('123', 'ggfipe', 'felipe.garcia2@fatec.sp.gov.br', 'medico', ''),
('1234', 'Robertinho', 'Roberto.Pequeno00@gmail.com', 'recepcionista', '');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_pacientes`
--

CREATE TABLE IF NOT EXISTS `tb_pacientes` (
  `cpf` varchar(14) NOT NULL DEFAULT '0',
  `telefone` varchar(19) NOT NULL,
  `nome` varchar(60) NOT NULL,
  `email` varchar(60) NOT NULL,
  `genero` varchar(11) NOT NULL,
  `data_nasc` varchar(10) NOT NULL,
  `idade` varchar(3) NOT NULL,
  `foto` varchar(255) NOT NULL,
  PRIMARY KEY (`cpf`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_pacientes`
--

INSERT INTO `tb_pacientes` (`cpf`, `telefone`, `nome`, `email`, `genero`, `data_nasc`, `idade`, `foto`) VALUES
('111.111.111-11', '+55 (11) 01273-9871', 'JOÃO ROSA', 'JOAO.ROSA2@GMAIL.COM', 'MASCULINO', '13/01/1972', '53', 'C:/USERS/FELIP/DOWNLOADS/PRJ_ADSVA2_25/BIN/DEBUG/IMAGE/OLNEYCAZARRE_(CROPPED).JPG'),
('222.222.222-22', '+55 (22) 99209-9281', 'MARCELA', 'MARCELA@GMAIL.COM', 'FEMININO', '20/07/2000', '24', 'C:/USERS/FELIP/DOWNLOADS/PRJ_ADSVA2_25/BIN/DEBUG/IMAGE/TUMBLR_EE461B9AD897B0670FC246C08102B91C_36AC8CEA_500.JPG'),
('333.333.333-33', '+55 (55) 96209-5698', 'KAROL VALELA', 'KAROL@GMAIL.COM', 'FEMININO', '15/04/1992', '33', 'C:/USERS/FELIP/DOWNLOADS/PRJ_ADSVA2_25/BIN/DEBUG/IMAGE/OLNEYCAZARRE_(CROPPED).JPG'),
('444.444.444-44', '+55 (11) 01928-3928', 'LÚCIO DE FREITAS', 'LUCINHO@GMAIL.COM', 'MASCULINO', '25/04/1886', '139', 'C:/USERS/FELIP/DOWNLOADS/PRJ_ADSVA2_25/BIN/DEBUG/IMAGE/OLNEYCAZARRE_(CROPPED).JPG'),
('555.555.555-55', '+55 (22) 99081-0192', 'ROBERTO GÓMEZ FERRAZ', 'CANJIRO@GMAIL.COM', 'FEMININO', '02/07/1956', '68', 'C:/USERS/FELIP/DOWNLOADS/PRJ_ADSVA2_25/BIN/DEBUG/IMAGE/A67AD70E0678CC9DE10B763EF217C089.JPG'),
('777.777.777-77', '+55 (56) 56565-7976', 'JOÃO DE LA CRUZ', 'ROBERTO@GMAIL.COM', 'MASCULINO', '16/06/2004', '21', 'C:/USERS/FELIP/DOWNLOADS/PRJ_ADSVA2_25/BIN/DEBUG/IMAGE/OLNEYCAZARRE_(CROPPED).JPG'),
('812.938.293-89', '+55 (11) 02939-9188', 'Placeholder', 'TUULI@GMAIL.COM', 'FEMININO', '25/04/1982', '43', 'C:/USERS/FELIP/DOWNLOADS/PRJ_ADSVA2_25/BIN/DEBUG/IMAGE/OLNEYCAZARRE_(CROPPED).JPG');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_prontuarios`
--

CREATE TABLE IF NOT EXISTS `tb_prontuarios` (
  `cid_11` varchar(11) NOT NULL,
  `cpf` varchar(14) NOT NULL,
  `nome` varchar(60) NOT NULL,
  `historico` varchar(255) NOT NULL,
  `anamnese` varchar(255) NOT NULL,
  `exames` varchar(255) NOT NULL,
  `diagnostico` varchar(255) NOT NULL,
  `tratamento` varchar(255) NOT NULL,
  `alta_e_trans` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
