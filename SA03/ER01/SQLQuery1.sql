CREATE DATABASE TesteSegurancaFS1
GO

USE TesteSegurancaFS1
GO

CREATE TABLE Usuarios
(
	Id INT PRIMARY KEY IDENTITY,
	Email VARCHAR(100) UNIQUE NOT NULL,
	Senha VARCHAR(50) 
)

GO

INSERT INTO Usuarios Values ('fulano@mail.com', '1234a')
INSERT INTO Usuarios Values ('fulano_tal@mail.com', '12324a')

SELECT * FROM Usuarios

SELECT Email, HASHBYTES('MD2', Senha) AS 'Senha HASH' FROM Usuarios

SELECT Email, HASHBYTES('MD2', Senha) AS 'Senha HASH' FROM Usuarios WHERE id =2
SELECT Email, HASHBYTES('MD4', Senha) AS 'Senha HASH' FROM Usuarios WHERE id =2
SELECT Email, HASHBYTES('MD5', Senha) AS 'Senha HASH' FROM Usuarios WHERE id =2
SELECT Email, HASHBYTES('SHA', Senha) AS 'Senha HASH' FROM Usuarios WHERE id =1
SELECT Email, HASHBYTES('SHA1', Senha) AS 'Senha HASH' FROM Usuarios WHERE id =2
SELECT Email, HASHBYTES('SHA2_256', Senha) AS 'Senha HASH' FROM Usuarios WHERE id =2
SELECT Email, HASHBYTES('SHA2_512', Senha) AS 'Senha HASH' FROM Usuarios WHERE id =2
