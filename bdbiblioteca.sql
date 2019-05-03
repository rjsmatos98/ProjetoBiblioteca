
CREATE DATABASE `bdbiblioteca`;

USE `bdbiblioteca`;

CREATE TABLE `devolucao` (
  `Id_Devolucao` int(11) NOT NULL AUTO_INCREMENT,
  `Id_Emprestimo` int(11) NOT NULL,
  `Id_Leitor` int(11) NOT NULL,
  `Id_Livro` int(11) NOT NULL,
  `Leitor` varchar(50) NOT NULL,
  `Livro` varchar(50) NOT NULL,
  `Retirada` varchar(50) NOT NULL,
  `Devolucao` varchar(50) NOT NULL
);

CREATE TABLE `emprestimo` (
  `Id_Emprestimo` int(11) NOT NULL AUTO_INCREMENT,
  `Id_Leitor` int(11) NOT NULL,
  `Id_Livro` int(11) NOT NULL,
  `Leitor` varchar(50) NOT NULL,
  `Livro` varchar(50) DEFAULT NULL,
  `Retirada` varchar(50) NOT NULL,
  `Devolucao` varchar(50) NOT NULL
);

CREATE TABLE `leitor` (
  `Id_Leitor` int(11) NOT NULL AUTO_INCREMENT,
  `Nome` varchar(50) NOT NULL,
  `Endereco` varchar(50) NOT NULL,
  `Numero` varchar(50) NOT NULL,
  `Telefone` varchar(50) NOT NULL,
  `CPF` varchar(50) NOT NULL
);

CREATE TABLE `livro` (
  `Id_Livro` int(11) NOT NULL AUTO_INCREMENT,
  `Nome` varchar(50) NOT NULL,
  `Autor` varchar(50) NOT NULL,
  `Genero` varchar(50) NOT NULL,
  `Paginas` varchar(50) NOT NULL,
  `Quantidade` int(11) NOT NULL
);

ALTER TABLE `devolucao`
  ADD PRIMARY KEY (`Id_Devolucao`);

ALTER TABLE `emprestimo`
  ADD PRIMARY KEY (`Id_Emprestimo`),
  ADD KEY `fk_id_leitor` (`Id_Leitor`),
  ADD KEY `fk_id_livro` (`Id_Livro`),
  ADD CONSTRAINT `fk_id_leitor` FOREIGN KEY (`Id_Leitor`) REFERENCES `leitor` (`Id_Leitor`),
  ADD CONSTRAINT `fk_id_livro` FOREIGN KEY (`Id_Livro`) REFERENCES `livro` (`Id_Livro`);
  
ALTER TABLE `leitor`
  ADD PRIMARY KEY (`Id_Leitor`);

ALTER TABLE `livro`
  ADD PRIMARY KEY (`Id_Livro`);

