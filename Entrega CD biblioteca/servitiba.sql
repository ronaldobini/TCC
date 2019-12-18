-- phpMyAdmin SQL Dump
-- version 4.7.7
-- https://www.phpmyadmin.net/
--
-- Host: 186.202.152.123
-- Generation Time: Nov 29, 2019 at 02:56 PM
-- Server version: 5.6.40-84.0-log
-- PHP Version: 5.6.40-0+deb8u7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `tccsilence`
--

-- --------------------------------------------------------

--
-- Table structure for table `categoria`
--

CREATE TABLE `categoria` (
  `id` int(11) NOT NULL,
  `descricao` varchar(20) COLLATE latin1_general_ci NOT NULL,
  `ordem` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

--
-- Dumping data for table `categoria`
--

INSERT INTO `categoria` (`id`, `descricao`, `ordem`) VALUES
(1, 'Informática', 1),
(2, 'Construção', 2),
(3, 'Jardinagem', 3),
(4, 'Marcenaria', 4),
(5, 'Alvenaria', 5),
(6, 'Floricultura', 6),
(7, 'Estetica', 7),
(8, 'Gastronomia', 8),
(9, 'Hospedagem', 8),
(10, 'Transporte', 9),
(11, 'Mobilidade', 10),
(12, 'Lazer', 11),
(13, 'Elétrica', 12),
(14, 'Mecânica', 12),
(15, 'Aulas', 13),
(16, 'Musica', 14);

-- --------------------------------------------------------

--
-- Table structure for table `chat_contrato`
--

CREATE TABLE `chat_contrato` (
  `id` int(11) NOT NULL,
  `id_servico` int(11) NOT NULL,
  `id_usuario` int(11) NOT NULL,
  `id_user_empresa` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

--
-- Dumping data for table `chat_contrato`
--

INSERT INTO `chat_contrato` (`id`, `id_servico`, `id_usuario`, `id_user_empresa`) VALUES
(12, 1, 3, 3),
(13, 2, 3, 3),
(14, 3, 1, 3),
(15, 4, 5, 1),
(16, 5, 2, 3),
(17, 6, 2, 11),
(18, 7, 12, 11),
(19, 8, 12, 6),
(20, 9, 5, 13),
(21, 10, 3, 11),
(22, 11, 12, 18),
(23, 12, 2, 3),
(24, 13, 2, 14),
(25, 14, 2, 6),
(26, 15, 2, 13),
(27, 16, 2, 18),
(28, 17, 2, 17),
(29, 18, 2, 2),
(30, 19, 20, 17),
(31, 20, 20, 2),
(32, 21, 20, 2),
(33, 22, 10, 3),
(34, 23, 1, 6),
(35, 24, 20, 21),
(36, 25, 2, 13);

-- --------------------------------------------------------

--
-- Table structure for table `chat_mensagens`
--

CREATE TABLE `chat_mensagens` (
  `id` int(11) NOT NULL,
  `id_chat_contrato` int(11) NOT NULL,
  `id_usuario` int(11) NOT NULL,
  `tempo` datetime NOT NULL,
  `mensagem` text COLLATE latin1_general_ci NOT NULL,
  `situacao` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

--
-- Dumping data for table `chat_mensagens`
--

INSERT INTO `chat_mensagens` (`id`, `id_chat_contrato`, `id_usuario`, `tempo`, `mensagem`, `situacao`) VALUES
(3, 12, 3, '2019-11-18 07:25:56', 'Aceitou o preço?', 0),
(4, 13, 3, '2019-11-17 22:00:00', 'Alguma Dúvida?', 0),
(5, 12, 2, '2019-11-18 07:33:27', 'sim!', 0),
(6, 14, 3, '2019-11-18 11:44:11', 'Obrigado pela solicitação, qualquer dúvida não hesite em perguntar!', 0),
(7, 15, 1, '2019-11-18 01:50:27', 'Obrigado pela solicitação, qualquer dúvida não hesite em perguntar!', 0),
(8, 15, 5, '2019-11-18 01:58:09', 'mano aprova ai pfv preciso do dinheiro ', 0),
(9, 15, 5, '2019-11-18 01:58:16', 'mano aprova ai pfv preciso do dinheiro ', 0),
(10, 15, 5, '2019-11-18 01:58:57', 'aprovei rlx kkkkkkkkk', 0),
(11, 15, 5, '2019-11-18 01:59:59', 'ae parceiro voce e brother', 0),
(12, 15, 5, '2019-11-18 02:20:29', 'ERA UM FARSANTE', 0),
(13, 16, 3, '2019-11-18 07:04:38', 'Obrigado pela solicitação, qualquer dúvida não hesite em perguntar!', 0),
(14, 16, 2, '2019-11-18 07:05:49', 'nao da pra fazer por 1000?', 0),
(15, 16, 3, '2019-11-18 07:07:32', 'sim!', 0),
(16, 17, 11, '2019-11-19 08:04:43', 'Obrigado pela solicitação, qualquer dúvida não hesite em perguntar!', 0),
(17, 18, 11, '2019-11-19 08:16:55', 'Obrigado pela solicitação, qualquer dúvida não hesite em perguntar!', 0),
(18, 18, 12, '2019-11-19 08:17:20', 'ok aguardo serbiço\r\n', 0),
(19, 19, 6, '2019-11-19 09:07:50', 'Obrigado pela solicitação, qualquer dúvida não hesite em perguntar!', 0),
(20, 20, 13, '2019-11-21 06:39:42', 'Obrigado pela solicitação, qualquer dúvida não hesite em perguntar!', 0),
(21, 20, 13, '2019-11-21 06:42:36', 'aumentei o preço ', 0),
(22, 20, 5, '2019-11-21 06:44:26', 'careiro', 0),
(23, 21, 11, '2019-11-26 08:02:21', 'Obrigado pela solicitação, qualquer dúvida não hesite em perguntar!', 0),
(24, 22, 18, '2019-11-27 09:21:28', 'Obrigado pela solicitação, qualquer dúvida não hesite em perguntar!', 0),
(25, 22, 12, '2019-11-27 09:23:03', 'faz por 40?', 0),
(26, 22, 18, '2019-11-27 10:08:34', 'tive que fazer po 50 mesmo', 0),
(27, 23, 3, '2019-11-27 10:28:07', 'Obrigado pela solicitação, qualquer dúvida não hesite em perguntar!', 0),
(28, 24, 14, '2019-11-27 10:28:30', 'Obrigado pela solicitação, qualquer dúvida não hesite em perguntar!', 0),
(29, 25, 6, '2019-11-27 10:29:29', 'Obrigado pela solicitação, qualquer dúvida não hesite em perguntar!', 0),
(30, 26, 13, '2019-11-27 10:29:56', 'Obrigado pela solicitação, qualquer dúvida não hesite em perguntar!', 0),
(31, 27, 18, '2019-11-27 10:30:18', 'Obrigado pela solicitação, qualquer dúvida não hesite em perguntar!', 0),
(32, 28, 17, '2019-11-27 10:30:44', 'Obrigado pela solicitação, qualquer dúvida não hesite em perguntar!', 0),
(33, 29, 2, '2019-11-27 10:31:22', 'Obrigado pela solicitação, qualquer dúvida não hesite em perguntar!', 0),
(34, 30, 17, '2019-11-27 10:32:55', 'Obrigado pela solicitação, qualquer dúvida não hesite em perguntar!', 0),
(35, 31, 2, '2019-11-27 10:33:17', 'Obrigado pela solicitação, qualquer dúvida não hesite em perguntar!', 0),
(36, 32, 2, '2019-11-27 10:33:38', 'Obrigado pela solicitação, qualquer dúvida não hesite em perguntar!', 0),
(37, 33, 3, '2019-11-28 04:53:22', 'Obrigado pela solicitação, qualquer dúvida não hesite em perguntar!', 0),
(38, 33, 10, '2019-11-28 04:53:40', 'nois', 0),
(39, 34, 6, '2019-11-28 04:59:28', 'Obrigado pela solicitação, qualquer dúvida não hesite em perguntar!', 0),
(40, 31, 2, '2019-11-28 09:16:50', 'cliente disse que desistiu no meio do serviço', 0),
(41, 35, 21, '2019-11-28 09:21:56', 'Obrigado pela solicitação, qualquer dúvida não hesite em perguntar!', 0),
(42, 36, 13, '2019-11-29 02:44:46', 'Obrigado pela solicitação, qualquer dúvida não hesite em perguntar!', 0);

-- --------------------------------------------------------

--
-- Table structure for table `cidade`
--

CREATE TABLE `cidade` (
  `id` int(11) NOT NULL,
  `nome` varchar(55) COLLATE latin1_general_ci NOT NULL,
  `id_estado` int(11) NOT NULL,
  `id_pais` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

--
-- Dumping data for table `cidade`
--

INSERT INTO `cidade` (`id`, `nome`, `id_estado`, `id_pais`) VALUES
(1, 'Curitiba', 2, 1),
(2, 'Irati', 2, 1),
(3, 'Piraquara', 2, 1),
(4, 'Pinhais', 2, 1),
(5, 'Colombo', 2, 1),
(6, 'Quatro Barras', 2, 1),
(7, 'São Jose dos Pinhais', 2, 1);

-- --------------------------------------------------------

--
-- Table structure for table `debug`
--

CREATE TABLE `debug` (
  `id` int(11) NOT NULL,
  `processo` varchar(100) COLLATE latin1_general_ci NOT NULL,
  `tempo` datetime NOT NULL,
  `resultados` text COLLATE latin1_general_ci NOT NULL,
  `info` text COLLATE latin1_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `empresa`
--

CREATE TABLE `empresa` (
  `id` int(11) NOT NULL,
  `id_diretor` int(11) DEFAULT NULL,
  `id_comercial` int(11) DEFAULT NULL,
  `id_tecnico` int(11) DEFAULT NULL,
  `cnpj` varchar(33) COLLATE latin1_general_ci NOT NULL,
  `razao_social` varchar(77) COLLATE latin1_general_ci NOT NULL,
  `telefone1` varchar(15) COLLATE latin1_general_ci NOT NULL,
  `telefone2` varchar(15) COLLATE latin1_general_ci NOT NULL,
  `endereco` varchar(80) COLLATE latin1_general_ci NOT NULL,
  `numero` varchar(12) COLLATE latin1_general_ci NOT NULL,
  `complemento` varchar(66) COLLATE latin1_general_ci NOT NULL,
  `cep` varchar(12) COLLATE latin1_general_ci NOT NULL,
  `lat` double NOT NULL,
  `lon` double NOT NULL,
  `id_cidade` int(11) NOT NULL,
  `inicio_empresa` datetime NOT NULL,
  `descricao_empresa` varchar(200) COLLATE latin1_general_ci NOT NULL,
  `qtd_funcionarios` int(11) NOT NULL,
  `reputacao_tempo` double NOT NULL,
  `reputacao_qualidade` double NOT NULL,
  `reputacao_atendimento` double NOT NULL,
  `reputacao_fiscal` double NOT NULL,
  `qtd_servicos` int(11) NOT NULL,
  `zona_atendimento` varchar(25) COLLATE latin1_general_ci NOT NULL,
  `data_cadastro` datetime NOT NULL,
  `block` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

--
-- Dumping data for table `empresa`
--

INSERT INTO `empresa` (`id`, `id_diretor`, `id_comercial`, `id_tecnico`, `cnpj`, `razao_social`, `telefone1`, `telefone2`, `endereco`, `numero`, `complemento`, `cep`, `lat`, `lon`, `id_cidade`, `inicio_empresa`, `descricao_empresa`, `qtd_funcionarios`, `reputacao_tempo`, `reputacao_qualidade`, `reputacao_atendimento`, `reputacao_fiscal`, `qtd_servicos`, `zona_atendimento`, `data_cadastro`, `block`) VALUES
(1, 2, 2, 2, '68.659.234/0001-89', 'Bini Softwares', '3027-1563', '98775-4047', 'Rua felicio zibarth', '113', 'sobrado', '', -25.4970197, -49.2145086, 1, '0000-00-00 00:00:00', 'Sistemas de qualidade', 1, 1, 1, 1, 80, 0, 'Curitiba e região', '2019-11-17 09:45:29', 0),
(2, 3, 3, 3, '18.239.637/0001-09', 'Curitiba Construções', '3025-8988', '98775-4048', 'Rua paulo setuba', '4495', 'Condo', '', -25.5154101, -49.2429852, 1, '0000-00-00 00:00:00', 'Construções em geral', 1, 1, 1, 1, 80, 0, 'Curitiba e região', '2019-11-17 09:51:51', 0),
(3, 1, 1, 1, '71.679.230/0001-77', 'ComarTec', '33868687', '992434356', 'Marechal Floriano Peixoto', '10680', 'Esquina', '', -25.5203542, -49.2287317, 1, '0000-00-00 00:00:00', 'A empresa ComarTec é especializada em manutenção de computadores.', 1, 1, 1, 1, 80, 0, 'Curitiba e região', '2019-11-17 11:36:46', 0),
(4, 5, 6, 6, '91.679.230/0001-79', 'Gametzel', '3074-9889', '9988-5654', 'rua alagoas', '2466', 'Sala 344', '80310100', -25.4716099, -49.2775488, 1, '0000-00-00 00:00:00', 'Roguelike pixelart Massa', 1, 191, 186, 181, 80, 3, 'Curitiba inteira', '0000-00-00 00:00:00', 0),
(6, 8, 8, 8, '082321845000143', 'Similar Tecnologia e Automacao', '30740344', '30740344', 'rua maj. vicente de castro', '140', 'sobrado', '', -25.4721358, -49.2783214, 1, '0000-00-00 00:00:00', 'Automaçao e sensores', 1, 1, 1, 1, 80, 0, 'Curitiba ', '2019-11-19 00:00:00', 0),
(9, 9, 10, 9, '87.900.491/0001-05', 'Forja Elaine', ' (41) 3918-5436', ' (41) 99704-766', 'Rua Ulisses Kendrick de Moraes', '556', 'casa', '', -25.483025, -49.3127678, 1, '0000-00-00 00:00:00', 'Forjo espadas escudos e armaduras, com qualquer metal', 1, 1, 1, 1, 80, 0, 'Curitiba ', '2019-11-19 00:00:00', 0),
(16, 11, 11, 11, '28.659.104/0001-89', 'Water Encanamentos', '4242-9090', '9988-1242', 'Av salgado filho', '600', 'Sem complemento', '', -25.4576959, -49.2501038, 1, '0000-00-00 00:00:00', 'Encanamentos novos e reparos.', 1, 61, 91, 81, 80, 1, 'Curitiba ', '2019-11-19 07:24:51', 0),
(18, 13, 13, 13, '82.018.157/0001-09', 'SetupNet Informatica', '987289384', '987289384', 'avenida nossa senhora aparecida', '1314', 'casa', '80310100', -25.4474659, -49.3106421, 1, '0000-00-00 00:00:00', ' planejamento, manutenção de estações de trabalho, servidores e canais de comunicação.', 1, 100, 70, 70, 80, 1, 'Curitiba e região', '0000-00-00 00:00:00', 0),
(19, 14, 14, 14, '04.394.626/0001-80', 'Carla e Yago Buffet Ltda', '98775-8757', '', ' Rua Victalina Strapasson Hecke', '543', 'casa', '', -25.479, -49.265, 1, '0000-00-00 00:00:00', 'Buffet  da Carla e Yago', 4, 0, 0, 0, 80, 0, 'Centro', '2019-11-19 08:29:50', 0),
(26, 16, 16, 16, '43.786.310/0001-96', 'Trajes Sociais Rakagan', ' (41) 3885-7153', ' (41) 98191-240', ' Rua Calixto Razolini', '411', 'Apartamento 365', ' 81070-060', -25.4779137, -49.294544, 1, '0000-00-00 00:00:00', 'Ajustamos, Consertamos e Confeccionamos trajes de gala para todo o Brasil', 124, 0, 0, 0, 80, 0, 'Todo o Brasil', '0000-00-00 00:00:00', 0),
(27, 17, 17, 17, '40.562.137/0001-54', 'Benedita Clarinetes', ' (41) 2813-0936', ' (41) 99834-031', ' Rua Tenente Waldomiro Bohatch', '343', '', ' 81210-132', -25.4289541, -49.267137, 1, '0000-00-00 00:00:00', 'Venda e reparos de todos os tipos de Clarinetes', 3, 0, 0, 0, 80, 0, 'Curitiba e regiao', '0000-00-00 00:00:00', 0),
(28, 1, 1, 1, '54.387.926/0001-00', 'Construtora Comar', '33443272', '992430499', 'Avenida Marechal Floriano Peixoto', '10688', '', '81750-190', -25.5196413, -49.2288952, 1, '0000-00-00 00:00:00', 'Realizamos seu sonho arquitetônico.', 10, 0, 0, 0, 80, 0, 'Curitiba', '2019-11-27 02:19:01', 1),
(29, 18, 18, 18, '78.659.294/2001-89', 'Marlene Pinturas', '4140405859', '4198590505', 'Rua rio amazonas', '216', '-', '81555-659', -25.3996304, -49.1956277, 1, '0000-00-00 00:00:00', 'Pinturas em panos de prato e tecidos.', 2, 0, 0, 0, 80, 0, 'Curitiba e Região', '0000-00-00 00:00:00', 0),
(30, 21, 21, 21, '99.659.234/0005-89', 'Joca Festas', '3027-1563', '41 99982832', 'Av salgado filho', '3500', '', '81580516', -25.4748192, -49.2300717, 1, '0000-00-00 00:00:00', 'Fornecemos decoração de festas para casamento, aniversario incluindo alimentação e muito mais!', 40, 0, 0, 0, 80, 0, 'Curitiba e Região', '0000-00-00 00:00:00', 0);

-- --------------------------------------------------------

--
-- Table structure for table `empresa_saldo`
--

CREATE TABLE `empresa_saldo` (
  `id` int(11) NOT NULL,
  `id_empresa` int(11) NOT NULL,
  `saldo_liberado` double NOT NULL,
  `saldo_pendente` double NOT NULL,
  `saldo_total_historico` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

--
-- Dumping data for table `empresa_saldo`
--

INSERT INTO `empresa_saldo` (`id`, `id_empresa`, `saldo_liberado`, `saldo_pendente`, `saldo_total_historico`) VALUES
(1, 1, 0, 3250, 0),
(2, 2, 0, 2500, 0),
(3, 3, 0, 0, 0),
(4, 4, 295012, -100008, 300012),
(6, 6, 0, 0, 0),
(9, 9, 0, 0, 0),
(16, 16, 200, 0, 200),
(18, 18, 70, 0, 70),
(19, 19, 0, 0, 0),
(26, 26, 0, 0, 0),
(28, 27, 0, 0, 0),
(29, 28, 0, 0, 0),
(30, 29, -50, 100, 0),
(31, 30, 0, 1500, 0);

-- --------------------------------------------------------

--
-- Table structure for table `empresa_servicos`
--

CREATE TABLE `empresa_servicos` (
  `id` int(11) NOT NULL,
  `id_empresa` int(11) NOT NULL,
  `id_categoria` int(11) NOT NULL,
  `descricao` varchar(35) COLLATE latin1_general_ci NOT NULL,
  `valor_aprox` double NOT NULL,
  `tempo_aprox` text COLLATE latin1_general_ci NOT NULL,
  `tags` varchar(200) COLLATE latin1_general_ci NOT NULL,
  `fl_ativo` tinyint(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

--
-- Dumping data for table `empresa_servicos`
--

INSERT INTO `empresa_servicos` (`id`, `id_empresa`, `id_categoria`, `descricao`, `valor_aprox`, `tempo_aprox`, `tags`, `fl_ativo`) VALUES
(1, 2, 2, ' Colocar Piso', 1500, '2 dias', 'piso', 1),
(2, 2, 2, ' Reformar telhado', 5600, '10 dias', 'telhado', 0),
(3, 2, 2, ' Reformar baheiro', 3580, '6 dias', 'banheiro', 0),
(4, 4, 1, ' Roguelike', 15000, 'milhoes de anos', 'jogo, roguelike, pixelart', 0),
(5, 4, 1, ' Pixelart', 100000, '2 minutos', 'rapido, pixelart, jogo, roguelike', 0),
(6, 16, 2, ' Reparo de cano furado', 150, '1 dia', 'cano ', 0),
(7, 19, 8, ' Pratos artesanais', 20, '1 hora', 'prato, pintura, dark souls', 0),
(8, 18, 1, ' Formatar pc', 70, '2 hroas', 'formatar', 0),
(9, 18, 1, ' Limpeza pc', 50, '1 hora', 'limpeza de computadores', 0),
(10, 27, 16, ' Conserto de Clarinete', 200, '1 semana', 'clarinete, conserto musical', 0),
(11, 27, 16, ' Clarinete BZ-Bahamur', 1500, 'clarinete, compra musical', '', 0),
(12, 29, 7, ' Pintura em tecido 2m', 50, '1 dia', 'tecido pintura', 0),
(13, 1, 1, ' Sistema Web', 5000, '1 mes', 'sistema web', 0),
(14, 1, 1, ' Site divulgação', 1500, '15 dias', 'site', 0),
(15, 1, 1, ' Sistema Porte grande', 15000, '3 meses', 'sistema gerencial', 0),
(16, 1, 1, ' Analise de segurança', 1500, '3 dias', 'segurança', 0),
(17, 1, 1, ' Implantar segurança de software', 9000, '2 meses', 'segurança', 0),
(18, 1, 1, ' Consultoria banco de dados', 2000, 'por hora', 'banco de dados', 0),
(19, 1, 1, ' Melhorias em sistemas', 2000, '1 a 6 meses', 'melhorias', 0),
(20, 30, 12, ' Casamento', 5300, '1 dia', 'casar', 0),
(21, 30, 12, ' Aniversário', 1500, '1 dia', 'niver', 0);

-- --------------------------------------------------------

--
-- Table structure for table `estado`
--

CREATE TABLE `estado` (
  `id` int(11) NOT NULL,
  `nome` varchar(55) COLLATE latin1_general_ci NOT NULL,
  `id_pais` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

--
-- Dumping data for table `estado`
--

INSERT INTO `estado` (`id`, `nome`, `id_pais`) VALUES
(2, 'Paraná', 1);

-- --------------------------------------------------------

--
-- Table structure for table `log`
--

CREATE TABLE `log` (
  `id` int(11) NOT NULL,
  `acao` varchar(50) COLLATE latin1_general_ci NOT NULL,
  `tempo` datetime NOT NULL,
  `id_user` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

--
-- Dumping data for table `log`
--

INSERT INTO `log` (`id`, `acao`, `tempo`, `id_user`) VALUES
(1, 'Login Cliente', '2019-11-17 09:42:31', 1),
(2, 'Login Empresa', '2019-11-17 09:47:01', 2),
(3, 'Login Empresa', '2019-11-17 09:53:35', 3),
(4, 'Login Cliente', '2019-11-17 09:58:03', 2),
(5, 'Login Cliente', '2019-11-17 10:03:51', 1),
(6, 'Login Empresa', '2019-11-17 10:10:40', 3),
(7, 'Login Cliente', '2019-11-17 10:30:49', 3),
(8, 'Login Empresa', '2019-11-17 10:35:11', 3),
(9, 'Login Cliente', '2019-11-17 10:40:50', 3),
(10, 'Login Cliente', '2019-11-17 11:17:18', 3),
(11, 'Login Cliente', '2019-11-17 11:29:44', 3),
(12, 'Login Empresa', '2019-11-18 07:22:22', 3),
(13, 'Login Cliente', '2019-11-18 07:32:45', 2),
(14, 'Login Cliente', '2019-11-18 11:43:17', 1),
(15, 'Login Cliente', '2019-11-18 01:40:39', 1),
(16, 'Login Empresa', '2019-11-18 01:45:13', 5),
(17, 'Login Cliente', '2019-11-18 01:45:35', 5),
(18, 'Login Empresa', '2019-11-18 01:47:29', 5),
(19, 'Login Cliente', '2019-11-18 01:50:02', 5),
(20, 'Login Empresa', '2019-11-18 01:51:10', 5),
(21, 'Login Cliente', '2019-11-18 01:52:03', 5),
(22, 'Login Empresa', '2019-11-18 01:52:23', 5),
(23, 'Login Cliente', '2019-11-18 01:58:27', 1),
(24, 'Login Cliente', '2019-11-18 01:58:36', 5),
(25, 'Login Empresa', '2019-11-18 01:59:32', 5),
(26, 'Login Cliente', '2019-11-18 02:20:49', 5),
(27, 'Login Cliente', '2019-11-18 02:59:27', 3),
(28, 'Login Empresa', '2019-11-18 06:53:38', 3),
(29, 'Login Cliente', '2019-11-18 06:59:33', 3),
(30, 'Login Empresa', '2019-11-18 07:01:35', 3),
(31, 'Login Cliente', '2019-11-18 07:03:51', 2),
(32, 'Login Empresa', '2019-11-18 07:06:42', 3),
(33, 'Login Cliente', '2019-11-18 07:34:12', 2),
(34, 'Login Cliente', '2019-11-18 07:53:54', 2),
(35, 'Login Cliente', '2019-11-18 07:58:17', 2),
(36, 'Login Cliente', '2019-11-18 08:04:56', 2),
(37, 'Login Empresa', '2019-11-19 08:43:59', 5),
(38, 'Login Empresa', '2019-11-19 09:07:48', 5),
(39, 'Login Empresa', '2019-11-19 09:43:42', 8),
(40, 'Login Empresa', '2019-11-19 09:44:40', 8),
(41, 'Login Empresa', '2019-11-19 10:30:15', 8),
(42, 'Login Empresa', '2019-11-19 10:34:51', 8),
(43, 'Login Cliente', '2019-11-19 10:38:46', 1),
(44, 'Login Cliente', '2019-11-19 11:01:17', 1),
(45, 'Login Cliente', '2019-11-19 11:08:12', 1),
(46, 'Login Empresa', '2019-11-19 11:11:02', 8),
(47, 'Login Empresa', '2019-11-19 11:16:13', 8),
(48, 'Login Empresa', '2019-11-19 11:25:22', 9),
(49, 'Login Empresa', '2019-11-19 08:01:33', 11),
(50, 'Login Cliente', '2019-11-19 08:03:22', 2),
(51, 'Login Cliente', '2019-11-19 08:13:37', 2),
(52, 'Login Cliente', '2019-11-19 08:15:53', 12),
(53, 'Login Empresa', '2019-11-19 08:17:40', 11),
(54, 'Login Cliente', '2019-11-19 08:19:24', 12),
(55, 'Login Empresa', '2019-11-19 08:19:58', 11),
(56, 'Login Cliente', '2019-11-19 08:20:28', 12),
(57, 'Login Cliente', '2019-11-19 08:41:48', 12),
(58, 'Login Cliente', '2019-11-19 08:44:13', 12),
(59, 'Login Cliente', '2019-11-19 08:46:17', 12),
(60, 'Login Cliente', '2019-11-19 08:47:20', 12),
(61, 'Login Cliente', '2019-11-19 08:48:12', 12),
(62, 'Login Cliente', '2019-11-19 08:49:40', 12),
(63, 'Login Cliente', '2019-11-19 09:06:45', 12),
(64, 'Login Cliente', '2019-11-19 09:16:56', 12),
(65, 'Login Cliente', '2019-11-19 09:18:20', 12),
(66, 'Login Cliente', '2019-11-19 09:27:01', 12),
(67, 'Login Empresa', '2019-11-19 09:27:49', 10),
(68, 'Login Empresa', '2019-11-19 09:28:00', 5),
(69, 'Login Empresa', '2019-11-19 09:30:36', 5),
(70, 'Login Empresa', '2019-11-19 09:35:20', 11),
(71, 'Login Empresa', '2019-11-19 09:38:45', 5),
(72, 'Login Cliente', '2019-11-19 09:39:58', 5),
(73, 'Login Empresa', '2019-11-19 09:42:09', 5),
(74, 'Login Empresa', '2019-11-20 02:45:14', 13),
(75, 'Login Cliente', '2019-11-20 02:45:34', 5),
(76, 'Login Cliente', '2019-11-20 02:49:54', 5),
(77, 'Login Empresa', '2019-11-20 03:15:07', 14),
(78, 'Login Cliente', '2019-11-20 03:16:15', 14),
(79, 'Login Empresa', '2019-11-20 03:19:39', 5),
(80, 'Login Empresa', '2019-11-20 03:19:48', 13),
(81, 'Login Cliente', '2019-11-20 03:56:21', 5),
(82, 'Login Cliente', '2019-11-20 04:00:12', 5),
(83, 'Login Cliente', '2019-11-20 04:05:01', 5),
(84, 'Login Cliente', '2019-11-20 04:06:29', 5),
(85, 'Login Cliente', '2019-11-20 04:54:54', 5),
(86, 'Login Cliente', '2019-11-20 05:21:44', 5),
(87, 'Login Cliente', '2019-11-20 05:28:52', 5),
(88, 'Login Cliente', '2019-11-21 11:59:10', 5),
(89, 'Login Cliente', '2019-11-21 02:27:38', 5),
(90, 'Login Empresa', '2019-11-21 03:01:37', 5),
(91, 'Login Cliente', '2019-11-21 03:01:46', 5),
(92, 'Login Empresa', '2019-11-21 03:57:12', 5),
(93, 'Login Empresa', '2019-11-21 04:06:11', 5),
(94, 'Login Empresa', '2019-11-21 04:30:35', 5),
(95, 'Login Empresa', '2019-11-21 04:33:39', 5),
(96, 'Login Empresa', '2019-11-21 04:38:31', 5),
(97, 'Login Empresa', '2019-11-21 04:43:47', 16),
(98, 'Login Cliente', '2019-11-21 04:48:05', 16),
(99, 'Login Cliente', '2019-11-21 05:47:52', 5),
(100, 'Login Cliente', '2019-11-21 05:49:34', 5),
(101, 'Login Cliente', '2019-11-21 06:38:19', 5),
(102, 'Login Empresa', '2019-11-21 06:40:51', 13),
(103, 'Login Cliente', '2019-11-21 06:43:18', 5),
(104, 'Login Empresa', '2019-11-21 06:44:55', 13),
(105, 'Login Cliente', '2019-11-21 06:46:25', 5),
(106, 'Login Empresa', '2019-11-21 06:48:32', 2),
(107, 'Login Empresa', '2019-11-21 06:48:53', 5),
(108, 'Login Empresa', '2019-11-22 09:59:51', 16),
(109, 'Login Empresa', '2019-11-22 10:07:59', 16),
(110, 'Login Empresa', '2019-11-22 10:08:26', 5),
(111, 'Login Empresa', '2019-11-22 10:29:58', 17),
(112, 'Login Empresa', '2019-11-22 10:35:11', 17),
(113, 'Login Empresa', '2019-11-22 10:38:27', 17),
(114, 'Login Empresa', '2019-11-22 10:41:38', 13),
(115, 'Login Cliente', '2019-11-24 09:15:47', 1),
(116, 'Login Cliente', '2019-11-24 09:40:13', 1),
(117, 'Login Cliente', '2019-11-24 11:27:33', 1),
(118, 'Login Cliente', '2019-11-25 05:24:20', 1),
(119, 'Login Cliente', '2019-11-25 05:32:33', 1),
(120, 'Login Cliente', '2019-11-25 05:33:52', 1),
(121, 'Login Empresa', '2019-11-25 07:09:49', 3),
(122, 'Login Empresa', '2019-11-25 07:27:22', 3),
(123, 'Login Empresa', '2019-11-25 07:53:41', 3),
(124, 'Login Empresa', '2019-11-25 07:54:03', 3),
(125, 'Login Empresa', '2019-11-25 08:26:16', 3),
(126, 'Login Empresa', '2019-11-25 08:46:04', 3),
(127, 'Login Empresa', '2019-11-25 10:58:39', 3),
(128, 'Login Empresa', '2019-11-25 11:14:00', 3),
(129, 'Login Empresa', '2019-11-25 11:56:35', 3),
(130, 'Login Empresa', '2019-11-25 11:58:18', 3),
(131, 'Login Empresa', '2019-11-26 12:03:20', 3),
(132, 'Login Empresa', '2019-11-26 12:03:20', 3),
(133, 'Login Empresa', '2019-11-26 12:12:50', 3),
(134, 'Login Empresa', '2019-11-26 12:17:02', 3),
(135, 'Login Empresa', '2019-11-26 12:22:20', 3),
(136, 'Login Empresa', '2019-11-26 12:38:21', 3),
(137, 'Login Empresa', '2019-11-26 01:24:58', 3),
(138, 'Login Empresa', '2019-11-26 01:49:54', 3),
(139, 'Login Cliente', '2019-11-26 05:48:58', 3),
(140, 'Login Empresa', '2019-11-26 05:50:09', 3),
(141, 'Login Empresa', '2019-11-26 05:55:27', 3),
(142, 'Login Empresa', '2019-11-26 07:46:25', 3),
(143, 'Login Cliente', '2019-11-26 07:51:26', 3),
(144, 'Login Cliente', '2019-11-26 08:00:47', 3),
(145, 'Login Cliente', '2019-11-26 08:01:31', 3),
(146, 'Login Empresa', '2019-11-26 11:15:18', 3),
(147, 'Login Cliente', '2019-11-27 12:51:33', 3),
(148, 'Login Cliente', '2019-11-27 01:20:56', 3),
(149, 'Login Empresa', '2019-11-27 01:57:59', 3),
(150, 'Login Empresa', '2019-11-27 02:00:36', 3),
(151, 'Login Empresa', '2019-11-27 02:15:59', 3),
(152, 'Login Empresa', '2019-11-27 02:25:04', 3),
(153, 'Login Empresa', '2019-11-27 02:27:43', 3),
(154, 'Login Cliente', '2019-11-27 05:32:26', 1),
(155, 'Login Cliente', '2019-11-27 05:39:52', 1),
(156, 'Login Cliente', '2019-11-27 05:41:46', 1),
(157, 'Login Cliente', '2019-11-27 05:47:37', 1),
(158, 'Login Cliente', '2019-11-27 05:48:59', 1),
(159, 'Login Cliente', '2019-11-27 05:50:36', 5),
(160, 'Login Cliente', '2019-11-27 05:58:09', 5),
(161, 'Login Cliente', '2019-11-27 09:08:57', 12),
(162, 'Login Cliente', '2019-11-27 09:15:28', 5),
(163, 'Login Empresa', '2019-11-27 09:17:31', 18),
(164, 'Login Cliente', '2019-11-27 09:21:03', 12),
(165, 'Login Empresa', '2019-11-27 09:23:37', 18),
(166, 'Login Cliente', '2019-11-27 09:23:55', 5),
(167, 'Login Cliente', '2019-11-27 09:32:50', 5),
(168, 'Login Cliente', '2019-11-27 09:34:38', 5),
(169, 'Login Empresa', '2019-11-27 09:51:51', 18),
(170, 'Login Empresa', '2019-11-27 10:06:59', 18),
(171, 'Login Cliente', '2019-11-27 10:07:03', 12),
(172, 'Login Empresa', '2019-11-27 10:10:08', 18),
(173, 'Login Cliente', '2019-11-27 10:13:06', 12),
(174, 'Login Empresa', '2019-11-27 10:16:39', 2),
(175, 'Login Cliente', '2019-11-27 10:27:35', 2),
(176, 'Login Cliente', '2019-11-27 10:32:30', 20),
(177, 'Login Empresa', '2019-11-27 10:34:08', 2),
(178, 'Login Empresa', '2019-11-27 10:55:03', 2),
(179, 'Login Cliente', '2019-11-27 11:02:36', 2),
(180, 'Login Empresa', '2019-11-27 11:06:10', 2),
(181, 'Login Empresa', '2019-11-27 11:08:11', 2),
(182, 'Login Empresa', '2019-11-27 11:12:53', 2),
(183, 'Login Cliente', '2019-11-28 12:16:45', 1),
(184, 'Login Empresa', '2019-11-28 12:24:35', 10),
(185, 'Login Cliente', '2019-11-28 12:27:15', 1),
(186, 'Login Cliente', '2019-11-28 11:46:13', 5),
(187, 'Login Empresa', '2019-11-28 11:56:04', 5),
(188, 'Login Cliente', '2019-11-28 04:52:31', 10),
(189, 'Login Cliente', '2019-11-28 04:59:02', 1),
(190, 'Login Empresa', '2019-11-28 05:16:40', 5),
(191, 'Login Cliente', '2019-11-28 05:17:05', 1),
(192, 'Login Empresa', '2019-11-28 05:17:53', 5),
(193, 'Login Empresa', '2019-11-28 08:33:00', 2),
(194, 'Login Empresa', '2019-11-28 09:09:53', 2),
(195, 'Login Cliente', '2019-11-28 09:10:48', 20),
(196, 'Login Empresa', '2019-11-28 09:12:30', 2),
(197, 'Login Cliente', '2019-11-28 09:17:11', 20),
(198, 'Login Empresa', '2019-11-28 09:19:57', 21),
(199, 'Login Cliente', '2019-11-28 09:21:32', 20),
(200, 'Login Empresa', '2019-11-28 09:24:33', 3),
(201, 'Login Empresa', '2019-11-28 09:25:42', 21),
(202, 'Login Cliente', '2019-11-28 09:42:03', 20),
(203, 'Login Empresa', '2019-11-28 10:04:27', 21),
(204, 'Login Cliente', '2019-11-29 12:14:18', 21),
(205, 'Login Empresa', '2019-11-29 12:14:54', 3),
(206, 'Login Cliente', '2019-11-29 12:15:05', 3),
(207, 'Login Cliente', '2019-11-29 12:31:59', 21),
(208, 'Login Empresa', '2019-11-29 02:34:06', 5),
(209, 'Login Cliente', '2019-11-29 02:38:09', 5),
(210, 'Login Empresa', '2019-11-29 02:38:28', 5),
(211, 'Login Empresa', '2019-11-29 02:41:38', 2),
(212, 'Login Cliente', '2019-11-29 02:42:13', 5),
(213, 'Login Cliente', '2019-11-29 02:42:54', 5),
(214, 'Login Cliente', '2019-11-29 02:43:27', 5),
(215, 'Login Cliente', '2019-11-29 02:44:06', 2),
(216, 'Login Empresa', '2019-11-29 02:52:36', 2),
(217, 'Login Cliente', '2019-11-29 02:52:50', 2);

-- --------------------------------------------------------

--
-- Table structure for table `pais`
--

CREATE TABLE `pais` (
  `id` int(11) NOT NULL,
  `nome` varchar(55) COLLATE latin1_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

--
-- Dumping data for table `pais`
--

INSERT INTO `pais` (`id`, `nome`) VALUES
(1, 'Brasil');

-- --------------------------------------------------------

--
-- Table structure for table `servico`
--

CREATE TABLE `servico` (
  `id` int(11) NOT NULL,
  `id_usuario` int(11) NOT NULL,
  `id_empresa` int(11) NOT NULL,
  `id_repres_empresa` int(11) NOT NULL,
  `data_inicio` datetime NOT NULL,
  `id_categoria` int(11) NOT NULL,
  `id_empresa_servico` int(11) NOT NULL,
  `descricao_usuario` text COLLATE latin1_general_ci NOT NULL,
  `prioridade` int(11) NOT NULL,
  `valor` double NOT NULL,
  `data_fim_estimada` varchar(60) COLLATE latin1_general_ci NOT NULL,
  `data_fim` datetime NOT NULL,
  `situacao` int(11) NOT NULL,
  `aceite_usuario` tinyint(1) NOT NULL,
  `aceite_empresa` tinyint(1) NOT NULL,
  `reputacao_tempo` double NOT NULL,
  `reputacao_qualidade` double NOT NULL,
  `reputacao_atendimento` double NOT NULL,
  `obs_finais_usuario` text COLLATE latin1_general_ci NOT NULL,
  `obs_finais_empresa` text COLLATE latin1_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

--
-- Dumping data for table `servico`
--

INSERT INTO `servico` (`id`, `id_usuario`, `id_empresa`, `id_repres_empresa`, `data_inicio`, `id_categoria`, `id_empresa_servico`, `descricao_usuario`, `prioridade`, `valor`, `data_fim_estimada`, `data_fim`, `situacao`, `aceite_usuario`, `aceite_empresa`, `reputacao_tempo`, `reputacao_qualidade`, `reputacao_atendimento`, `obs_finais_usuario`, `obs_finais_empresa`) VALUES
(1, 2, 2, 1, '2019-11-17 09:58:58', 2, 1, 'Piso de ceramica 50m2', 0, 1500, '2001-01-01 00:00:00', '2001-01-01 00:00:00', 2, 0, 0, 0, 0, 0, '-', '-'),
(2, 3, 2, 1, '2019-11-17 10:47:24', 2, 1, 'Instalar o piso da garagem. Metragem 10 m².', 0, 1500, '2001-01-01 00:00:00', '2001-01-01 00:00:00', 0, 0, 0, 0, 0, 0, '-', '-'),
(3, 1, 2, 3, '2019-11-18 11:44:10', 2, 2, 'Um piso muito massa na minha casa', 0, 5600, '2001-01-01 00:00:00', '2001-01-01 00:00:00', 0, 0, 0, 0, 0, 0, '-', '-'),
(4, 5, 4, 1, '2019-11-18 01:50:27', 1, 5, 'Que seja rapido mesmo e que o mattei nao apareca', 0, 100004, '2001-01-01 00:00:00', '2019-11-29 14:40:53', 4, 1, 1, 100, 70, 70, 'asdfasdf', ''),
(5, 2, 2, 3, '2019-11-18 07:04:35', 2, 1, 'piso de 10m2 para area de lavanderia', 0, 1000, '2019-11-30 00:00:00', '2001-01-01 00:00:00', 2, 0, 0, 0, 0, 0, '-', '-'),
(6, 2, 16, 11, '2019-11-19 08:04:42', 2, 6, 'cano na cozinha', 0, 150, '2001-01-01 00:00:00', '2001-01-01 00:00:00', 0, 0, 0, 0, 0, 0, '-', '-'),
(7, 12, 16, 11, '2019-11-19 08:16:54', 2, 6, 'cano no banheiro todo', 0, 200, '2019-11-20 00:00:00', '2001-01-01 00:00:00', 4, 1, 1, 60, 90, 80, 'Seviço ficou bom, demorou um pouco soh', 'tudo ok'),
(8, 12, 4, 6, '2019-11-19 09:07:49', 1, 4, 'Irei enviar detalhes por email.', 0, 15000, '2001-01-01 00:00:00', '2001-01-01 00:00:00', 0, 0, 0, 0, 0, 0, '-', '-'),
(9, 5, 18, 13, '2019-11-21 06:39:41', 1, 8, 'Que seja rapido', 0, 70, '2001-01-01 00:00:00', '2019-11-21 18:47:40', 4, 1, 1, 100, 70, 70, 'muito caro', 'cliente chato'),
(10, 3, 16, 11, '2019-11-26 08:02:21', 2, 6, 'Realizar reparos no encanamento da cozinha.', 0, 150, '2001-01-01 00:00:00', '2001-01-01 00:00:00', 0, 0, 0, 0, 0, 0, '-', '-'),
(11, 12, 29, 18, '2019-11-27 09:21:27', 7, 12, 'pintura num tecido branco de seda', 0, 50, 'a definir', '2001-01-01 00:00:00', 2, 0, 0, 0, 0, 0, '-', '-'),
(12, 2, 2, 3, '2019-11-27 10:28:07', 2, 3, 'banheiro novo', 0, 3580, 'A definir', '2001-01-01 00:00:00', 0, 0, 0, 0, 0, 0, '-', '-'),
(13, 2, 19, 14, '2019-11-27 10:28:29', 8, 7, 'prato com meu nome', 0, 20, 'A definir', '2001-01-01 00:00:00', 0, 0, 0, 0, 0, 0, '-', '-'),
(14, 2, 4, 6, '2019-11-27 10:29:29', 1, 4, 'novo dark souls', 0, 15000, 'A definir', '2001-01-01 00:00:00', 0, 0, 0, 0, 0, 0, '-', '-'),
(15, 2, 18, 13, '2019-11-27 10:29:56', 1, 9, 'pc muito sujo, craquento ', 0, 50, 'A definir', '2001-01-01 00:00:00', 0, 0, 0, 0, 0, 0, '-', '-'),
(16, 2, 29, 18, '2019-11-27 10:30:18', 7, 12, 'pano com meu nome', 0, 50, 'A definir', '2001-01-01 00:00:00', 0, 0, 0, 0, 0, 0, '-', '-'),
(17, 2, 27, 17, '2019-11-27 10:30:43', 16, 11, 'clarinete antigo', 0, 1500, 'A definir', '2001-01-01 00:00:00', 0, 0, 0, 0, 0, 0, '-', '-'),
(18, 2, 1, 2, '2019-11-27 10:31:22', 1, 17, 'favor fazer orçamento, preciso de algo barato mas bom', 0, 3000, 'A definir', '2001-01-01 00:00:00', 1, 0, 0, 0, 0, 0, '-', '-'),
(19, 20, 27, 17, '2019-11-27 10:32:54', 16, 10, 'clarinete nao emite sons', 0, 200, 'A definir', '2001-01-01 00:00:00', 0, 0, 0, 0, 0, 0, '-', '-'),
(20, 20, 1, 2, '2019-11-27 10:33:16', 1, 13, 'sistema pra estoque', 0, 3250, 'A definir', '2001-01-01 00:00:00', -2, 0, 0, 0, 0, 0, '-', '-'),
(21, 20, 1, 2, '2019-11-27 10:33:38', 1, 19, 'melhoria em meu site', 0, 2000, 'A definir', '2001-01-01 00:00:00', 0, 0, 0, 0, 0, 0, '-', '-'),
(22, 10, 2, 3, '2019-11-28 04:53:22', 2, 2, 'um telhado bonito', 0, 5600, 'A definir', '2001-01-01 00:00:00', 0, 0, 0, 0, 0, 0, '-', '-'),
(23, 1, 4, 6, '2019-11-28 04:59:27', 1, 5, 'Bem bonito tipo Dead Cells', 0, 100000, 'A definir', '2001-01-01 00:00:00', 2, 0, 0, 0, 0, 0, '-', '-'),
(24, 20, 30, 21, '2019-11-28 09:21:56', 12, 21, 'niver pro meu baby', 0, 1500, 'A definir', '2001-01-01 00:00:00', 3, 0, 1, 0, 0, 0, '-', 'Muito bom!!!!'),
(25, 2, 18, 13, '2019-11-29 02:44:46', 1, 9, 'Limpeza do meu computador pessoal', 0, 50, 'A definir', '2001-01-01 00:00:00', 0, 0, 0, 0, 0, 0, '-', '-');

-- --------------------------------------------------------

--
-- Table structure for table `servico_tecnicos`
--

CREATE TABLE `servico_tecnicos` (
  `id` int(11) NOT NULL,
  `id_servico` int(11) NOT NULL,
  `id_tecnico` int(11) NOT NULL,
  `reputacao_servico` int(11) NOT NULL,
  `obs_usuario` text COLLATE latin1_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

--
-- Dumping data for table `servico_tecnicos`
--

INSERT INTO `servico_tecnicos` (`id`, `id_servico`, `id_tecnico`, `reputacao_servico`, `obs_usuario`) VALUES
(1, 8, 5, 0, '-'),
(2, 8, 6, 0, '-'),
(3, 8, 6, 0, '-'),
(4, 8, 6, 0, '-'),
(5, 9, 13, 0, '-'),
(6, 2, 4, 0, '-'),
(7, 2, 3, 0, '-'),
(8, 2, 4, 0, '-'),
(9, 11, 18, 0, '-'),
(10, 20, 19, 0, '-');

-- --------------------------------------------------------

--
-- Table structure for table `usuario`
--

CREATE TABLE `usuario` (
  `id` int(11) NOT NULL,
  `login` varchar(25) COLLATE latin1_general_ci NOT NULL,
  `senha` varchar(25) COLLATE latin1_general_ci NOT NULL,
  `nome` varchar(45) COLLATE latin1_general_ci NOT NULL,
  `email` varchar(45) COLLATE latin1_general_ci NOT NULL,
  `cpf` varchar(25) COLLATE latin1_general_ci NOT NULL,
  `telefone1` varchar(25) COLLATE latin1_general_ci NOT NULL,
  `telefone2` varchar(25) COLLATE latin1_general_ci NOT NULL,
  `endereco` varchar(55) COLLATE latin1_general_ci NOT NULL,
  `numero` int(10) NOT NULL,
  `complemento` varchar(25) COLLATE latin1_general_ci NOT NULL,
  `cep` varchar(9) COLLATE latin1_general_ci NOT NULL,
  `id_cidade` int(11) NOT NULL,
  `reputacao` int(11) NOT NULL,
  `data_cadastro` datetime NOT NULL,
  `ultimo_login` datetime NOT NULL,
  `erros_senha` int(11) NOT NULL,
  `block` tinyint(1) NOT NULL,
  `qtd_servicos` int(11) NOT NULL,
  `fl_su` tinyint(2) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

--
-- Dumping data for table `usuario`
--

INSERT INTO `usuario` (`id`, `login`, `senha`, `nome`, `email`, `cpf`, `telefone1`, `telefone2`, `endereco`, `numero`, `complemento`, `cep`, `id_cidade`, `reputacao`, `data_cadastro`, `ultimo_login`, `erros_senha`, `block`, `qtd_servicos`, `fl_su`) VALUES
(1, 'admin', '123', 'Admistrador', 'adm@servitiba.com', '650.593.420-00', '41 55555555', '41 55555555', 'Rua felicio zibarth', 100, 'adm', '81580510', 1, 0, '2019-11-17 09:42:27', '0000-00-00 00:00:00', 0, 0, 0, 1),
(2, 'bini', '123', 'Ronaldo Bini', 'rbsbini@gmail.com', '09408721969', '3027-1563', '98775-4047', 'Rua felicio zibarth', 123, 'nada', '81580510', 1, 0, '2019-11-17 09:46:54', '0000-00-00 00:00:00', 0, 0, 0, 0),
(3, 'curitiba', '123', 'Roberto Marques', 'rob@gmail.com', '634.407.700-01', '3027-1563', '41 99982832', 'rua dos palotinos', 222, 'sobrado', '81540-056', 1, 0, '2019-11-17 09:53:18', '0000-00-00 00:00:00', 0, 0, 0, 0),
(4, 'jose', '123', 'Jose Siqueira', 'jose@gmail.com', '09887654212', '3027-1563', '98775-4047', 'rua das palmeiras', 332, '2', '81987651', 1, 0, '2019-11-17 09:57:38', '0000-00-00 00:00:00', 0, 0, 0, 0),
(5, 'gantzel', '123', 'Verkans Gantzel Daora', 'verkans@setupnet.com.br', '10539948997', '123123', '123123', 'avenida nossa senhora aparecida', 1314, 'casa', '80310100', 1, 0, '2019-11-18 01:45:07', '0000-00-00 00:00:00', 0, 0, 0, 0),
(6, 'Mattei', '123', 'Mattei Regular', 'masomenos@similar.ind.br', '123412341234', '12341234', '1234123', 'Rua alagoas', 123, '12341234', '123412341', 1, 0, '2019-11-18 01:49:42', '0000-00-00 00:00:00', 0, 0, 0, 0),
(7, 'rudinei', '123', 'Rudinei de Paula', 'rudinei@similar.ind.br', '10559446997', '30740344', '30740344', 'avenida nossa senhora aparecida', 1314, 'casa', '80310100', 1, 0, '2019-11-19 09:34:00', '0000-00-00 00:00:00', 0, 0, 0, 0),
(8, 'Rudinei', '123', 'Rudinei de Paula', 'rudinei@similar.ind.br', '86694862962', '30740344', '30740344', 'avenida nossa senhora aparecida', 1314, 'casa', '82310380', 1, 0, '2019-11-19 09:43:36', '0000-00-00 00:00:00', 0, 0, 0, 0),
(9, 'elaine', '123', ' Elaine Marli Gomes', 'eelainemarligomes@jbtc.com', '032.489.259-49', ' (41) 3918-5436', ' (41) 99704-7668', ' Rua Deputado Leoberto Leal', 556, 'casa', ' 81510-09', 1, 0, '2019-11-19 11:25:16', '0000-00-00 00:00:00', 0, 0, 0, 0),
(10, 'verkans', '123', 'Victor Rochadel Gantzel', 'victor@setupnet.com.br', '10539426997', '30740344', '41987289384', 'avenida nossa senhora aparecida', 1314, 'casa', '80310100', 1, 0, '2019-11-19 11:26:51', '0000-00-00 00:00:00', 0, 0, 0, 0),
(11, 'water', '123', 'João Almeida', 'marode@gmaill.com', '058.589.659-99', '41 988754047', '5555-0606', 'Rua dos palotinos', 154, 'asd', '81578989', 1, 10, '2019-11-19 00:00:00', '2019-11-19 00:00:00', 0, 0, 0, 0),
(12, 'juli', '123', 'Juliana de Oliveira', 'juli@gmail.com', '112445889-96', '41 3325-9696', '41 9985-6969', 'Rua felicio zibarth', 113, 'casa', '81580-510', 1, 10, '2019-11-19 08:15:45', '0000-00-00 00:00:00', 0, 0, 1, 0),
(13, 'marcelo', '123', 'Marcelo Nassife Gantzel', 'marcelo@setupnet.com.br', '446.883.739-02', ' (41) 3819-6426', ' (41) 99511-9163', 'avenida nossa senhora aparecida', 1314, 'casa', '80310100', 1, 0, '2019-11-20 02:45:08', '0000-00-00 00:00:00', 0, 0, 0, 0),
(14, 'gael', '123', ' Gael Alexandre Moraes', 'slave@knight.com', '500.230.159-26', ' (41) 3695-8098', ' (41) 99514-3275', ' Rua Victalina Strapasson Hecke', 543, '', ' 81050-68', 1, 0, '2019-11-20 03:15:01', '0000-00-00 00:00:00', 0, 0, 0, 0),
(16, 'olivia', '123', ' Olivia Sandra Isis Farias', 'olivia@gmail.com', '316.305.999-64', ' (41) 3885-7153', ' (41) 98191-2402', ' Rua Calixto Razolini', 411, 'Apartamento 1', ' 81070-06', 1, 0, '2019-11-21 04:43:22', '0000-00-00 00:00:00', 0, 0, 0, 0),
(17, 'bene', '123', 'Benedita Clarice Lima', 'beneditaclari@dpi.ig.br', '416.469.639-70', ' (41) 99834-0311', ' (41) 99834-0311', ' Rua Tenente Waldomiro Bohatch', 343, 'casa', ' 81210-13', 1, 0, '2019-11-22 10:29:36', '0000-00-00 00:00:00', 0, 0, 0, 0),
(18, 'marlene', '123', 'Marlene de oliveira', 'marlene@gmail.com', '094878262-69', '41 8877 9888', '41 9887 1145', 'Rua rio amazonas', 216, '-', '81544-966', 1, 0, '2019-11-27 09:17:23', '0000-00-00 00:00:00', 0, 0, 0, 0),
(19, 'john', '123', 'John Franks', 'jjff@gmail.com', '4888596-69', '11135-5959', '996456-444', 'Rua felicio zibarth', 113, '113', '151587-88', 1, 0, '2019-11-27 10:21:17', '0000-00-00 00:00:00', 0, 0, 0, 0),
(20, 'josecarlos', '123', 'José Carlos', 'jose@gmail.com', '084557898-69', '41 5889-9988', '99555-8880', 'Rua felicio zibarth', 113, '113', '21580-999', 1, 10, '2019-11-27 10:32:22', '0000-00-00 00:00:00', 0, 0, 0, 0),
(21, 'joca', '123', 'Joca Aloisio Mark', 'markjoca@gmail.com', '04789877774', '3027-1563', '41 99982832', 'Rua felicio zibarth', 216, '', '81580510', 1, 0, '2019-11-28 09:19:50', '0000-00-00 00:00:00', 0, 0, 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `usuario_empresa`
--

CREATE TABLE `usuario_empresa` (
  `id` int(11) NOT NULL,
  `id_usuario` int(11) NOT NULL,
  `id_empresa` int(11) NOT NULL,
  `funcao` varchar(55) COLLATE latin1_general_ci NOT NULL,
  `nivel_empresa` int(11) NOT NULL,
  `qtd_servicos` int(11) NOT NULL,
  `nivel_escolar` varchar(44) COLLATE latin1_general_ci NOT NULL,
  `formacao` varchar(66) COLLATE latin1_general_ci NOT NULL,
  `reputacao_media` double NOT NULL,
  `id_escolaridade` int(11) NOT NULL,
  `fl_ativo` tinyint(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

--
-- Dumping data for table `usuario_empresa`
--

INSERT INTO `usuario_empresa` (`id`, `id_usuario`, `id_empresa`, `funcao`, `nivel_empresa`, `qtd_servicos`, `nivel_escolar`, `formacao`, `reputacao_media`, `id_escolaridade`, `fl_ativo`) VALUES
(1, 2, 1, 'Diretor', 3, 0, 'Superior - Completo', 'Diretor', 0, 6, 0),
(2, 3, 2, 'Diretor', 3, 0, 'Mestrado - Incompleto', 'Eng. Civil', 0, 9, 0),
(3, 4, 2, 'Pedreiro', 1, 0, 'Fundamental - Incompleto', 'Pedreiro', 0, 1, 0),
(4, 5, 4, 'Programador', 3, 0, 'Fundamental - Incompleto', 'Roguelike', 0, 1, 0),
(5, 6, 4, 'Corretor de Imoveis', 3, 0, 'Fundamental - Incompleto', 'Segurança dos Imoveis', 0, 1, 0),
(7, 8, 6, 'Recursos Humanos', 3, 0, 'Doutorado - Completo', 'Recursos Humanos', 0, 12, 0),
(8, 9, 9, 'Mestre da Forja', 3, 0, 'Doutorado - Completo', 'Ferreira', 0, 12, 0),
(9, 10, 9, 'Ferreiro', 2, 0, 'Mestrado - Incompleto', 'Ferreiro', 0, 9, 0),
(10, 11, 16, 'Diretor', 3, 0, 'Mestrado - Incompleto', 'Engenheiro', 0, 9, 0),
(11, 13, 18, 'Analista de TI', 3, 0, 'Superior - Completo', 'TI', 0, 6, 0),
(12, 14, 19, 'Colecionador', 3, 0, 'Fundamental - Incompleto', 'Pintura', 0, 1, 0),
(14, 16, 26, 'Costureira', 3, 0, 'Doutorado - Completo', 'Costura', 0, 12, 0),
(22, 17, 27, 'Clarinetista', 3, 0, 'Mestrado - Completo', 'Musica', 0, 10, 0),
(23, 18, 29, 'Pintora Chefe', 3, 0, 'Fundamental - Incompleto', 'Sem formação', 0, 1, 0),
(24, 19, 1, 'Segurança', 1, 0, 'Pós-graduação - Completo', 'Segurança da info.', 0, 8, 0),
(25, 21, 30, 'Direção', 3, 0, 'Superior - Completo', 'Gestão', 0, 6, 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `categoria`
--
ALTER TABLE `categoria`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `chat_contrato`
--
ALTER TABLE `chat_contrato`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_servico` (`id_servico`),
  ADD KEY `id_usuario` (`id_usuario`),
  ADD KEY `id_user_empresa` (`id_user_empresa`);

--
-- Indexes for table `chat_mensagens`
--
ALTER TABLE `chat_mensagens`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_chat_contrato` (`id_chat_contrato`),
  ADD KEY `id_usuario` (`id_usuario`);

--
-- Indexes for table `cidade`
--
ALTER TABLE `cidade`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_estado` (`id_estado`),
  ADD KEY `id_pais` (`id_pais`);

--
-- Indexes for table `debug`
--
ALTER TABLE `debug`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `empresa`
--
ALTER TABLE `empresa`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_diretor` (`id_diretor`),
  ADD KEY `id_comercial` (`id_comercial`),
  ADD KEY `id_tecnico` (`id_tecnico`),
  ADD KEY `id_cidade` (`id_cidade`);

--
-- Indexes for table `empresa_saldo`
--
ALTER TABLE `empresa_saldo`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_empresa` (`id_empresa`);

--
-- Indexes for table `empresa_servicos`
--
ALTER TABLE `empresa_servicos`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_empresa` (`id_empresa`),
  ADD KEY `id_categoria` (`id_categoria`);

--
-- Indexes for table `estado`
--
ALTER TABLE `estado`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_pais` (`id_pais`);

--
-- Indexes for table `log`
--
ALTER TABLE `log`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_user` (`id_user`);

--
-- Indexes for table `pais`
--
ALTER TABLE `pais`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `servico`
--
ALTER TABLE `servico`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_usuario` (`id_usuario`),
  ADD KEY `id_empresa` (`id_empresa`),
  ADD KEY `id_repres_empresa` (`id_repres_empresa`),
  ADD KEY `id_categoria` (`id_categoria`),
  ADD KEY `servico_empresaServico_idx` (`id_empresa_servico`);

--
-- Indexes for table `servico_tecnicos`
--
ALTER TABLE `servico_tecnicos`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_servico` (`id_servico`),
  ADD KEY `id_tecnico` (`id_tecnico`);

--
-- Indexes for table `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`id`),
  ADD KEY `Fk_cidade_idx` (`id_cidade`);

--
-- Indexes for table `usuario_empresa`
--
ALTER TABLE `usuario_empresa`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_empresa` (`id_empresa`),
  ADD KEY `id_usuario` (`id_usuario`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `categoria`
--
ALTER TABLE `categoria`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `chat_contrato`
--
ALTER TABLE `chat_contrato`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;

--
-- AUTO_INCREMENT for table `chat_mensagens`
--
ALTER TABLE `chat_mensagens`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=43;

--
-- AUTO_INCREMENT for table `cidade`
--
ALTER TABLE `cidade`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `debug`
--
ALTER TABLE `debug`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `empresa`
--
ALTER TABLE `empresa`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT for table `empresa_saldo`
--
ALTER TABLE `empresa_saldo`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;

--
-- AUTO_INCREMENT for table `empresa_servicos`
--
ALTER TABLE `empresa_servicos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT for table `estado`
--
ALTER TABLE `estado`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `log`
--
ALTER TABLE `log`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=218;

--
-- AUTO_INCREMENT for table `pais`
--
ALTER TABLE `pais`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `servico`
--
ALTER TABLE `servico`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT for table `servico_tecnicos`
--
ALTER TABLE `servico_tecnicos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `usuario`
--
ALTER TABLE `usuario`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT for table `usuario_empresa`
--
ALTER TABLE `usuario_empresa`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `chat_contrato`
--
ALTER TABLE `chat_contrato`
  ADD CONSTRAINT `chat_contrato_ibfk_1` FOREIGN KEY (`id_servico`) REFERENCES `servico` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `chat_contrato_ibfk_2` FOREIGN KEY (`id_usuario`) REFERENCES `usuario` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `chat_contrato_ibfk_3` FOREIGN KEY (`id_user_empresa`) REFERENCES `usuario` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `chat_mensagens`
--
ALTER TABLE `chat_mensagens`
  ADD CONSTRAINT `chat_mensagens_ibfk_1` FOREIGN KEY (`id_chat_contrato`) REFERENCES `chat_contrato` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `chat_mensagens_ibfk_2` FOREIGN KEY (`id_usuario`) REFERENCES `usuario` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `cidade`
--
ALTER TABLE `cidade`
  ADD CONSTRAINT `cidade_ibfk_1` FOREIGN KEY (`id_estado`) REFERENCES `estado` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `empresa`
--
ALTER TABLE `empresa`
  ADD CONSTRAINT `empresa_ibfk_1` FOREIGN KEY (`id_cidade`) REFERENCES `cidade` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `empresa_ibfk_2` FOREIGN KEY (`id_diretor`) REFERENCES `usuario` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `empresa_ibfk_3` FOREIGN KEY (`id_comercial`) REFERENCES `usuario` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `empresa_ibfk_4` FOREIGN KEY (`id_tecnico`) REFERENCES `usuario` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `empresa_saldo`
--
ALTER TABLE `empresa_saldo`
  ADD CONSTRAINT `empresa_saldo_ibfk_1` FOREIGN KEY (`id_empresa`) REFERENCES `empresa` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `empresa_servicos`
--
ALTER TABLE `empresa_servicos`
  ADD CONSTRAINT `empresa_servicos_ibfk_1` FOREIGN KEY (`id_empresa`) REFERENCES `empresa` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `estado`
--
ALTER TABLE `estado`
  ADD CONSTRAINT `estado_ibfk_1` FOREIGN KEY (`id_pais`) REFERENCES `pais` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `log`
--
ALTER TABLE `log`
  ADD CONSTRAINT `log_ibfk_1` FOREIGN KEY (`id_user`) REFERENCES `usuario` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `servico`
--
ALTER TABLE `servico`
  ADD CONSTRAINT `fkServico` FOREIGN KEY (`id_empresa_servico`) REFERENCES `empresa_servicos` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `servico_ibfk_1` FOREIGN KEY (`id_empresa`) REFERENCES `empresa` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `servico_ibfk_2` FOREIGN KEY (`id_usuario`) REFERENCES `usuario` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `servico_ibfk_3` FOREIGN KEY (`id_repres_empresa`) REFERENCES `usuario` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `servico_ibfk_4` FOREIGN KEY (`id_categoria`) REFERENCES `categoria` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `servico_tecnicos`
--
ALTER TABLE `servico_tecnicos`
  ADD CONSTRAINT `servico_tecnicos_ibfk_1` FOREIGN KEY (`id_servico`) REFERENCES `servico` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `usuario`
--
ALTER TABLE `usuario`
  ADD CONSTRAINT `fk_cidade` FOREIGN KEY (`id_cidade`) REFERENCES `cidade` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `usuario_empresa`
--
ALTER TABLE `usuario_empresa`
  ADD CONSTRAINT `usuario_empresa_ibfk_1` FOREIGN KEY (`id_usuario`) REFERENCES `usuario` (`id`) ON DELETE CASCADE ON UPDATE NO ACTION,
  ADD CONSTRAINT `usuario_empresa_ibfk_2` FOREIGN KEY (`id_empresa`) REFERENCES `empresa` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
