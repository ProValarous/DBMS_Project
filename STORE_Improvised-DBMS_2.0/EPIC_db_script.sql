CREATE TABLE Wallet (
  idWallet INTEGER  NOT NULL   IDENTITY ,
  Amount INTEGER      ,
PRIMARY KEY(idWallet));
GO




CREATE TABLE Users (
  idUsers INTEGER  NOT NULL   IDENTITY ,
  Wallet_idWallet INTEGER  NOT NULL  ,
  Username VARCHAR (1000)    ,
  Date_of_birth DATE    ,
  country VARCHAR (1000)    ,
  sex VARCHAR (1000)      ,
PRIMARY KEY(idUsers)  ,
  FOREIGN KEY(Wallet_idWallet)
    REFERENCES Wallet(idWallet));
GO


CREATE INDEX Users_FKIndex1 ON Users (Wallet_idWallet);
GO


CREATE INDEX IFK_Rel_01 ON Users (Wallet_idWallet);
GO


CREATE TABLE Seller (
  idSeller INTEGER  NOT NULL   IDENTITY ,
  Wallet_idWallet INTEGER  NOT NULL  ,
  Distributer_name VARCHAR(1000)    ,
  Country VARCHAR(1000)    ,
  Discription VARCHAR(1000)      ,
PRIMARY KEY(idSeller)  ,
  FOREIGN KEY(Wallet_idWallet)
    REFERENCES Wallet(idWallet));
GO


CREATE INDEX Seller_FKIndex1 ON Seller (Wallet_idWallet);
GO


CREATE INDEX IFK_Rel_02 ON Seller (Wallet_idWallet);
GO


CREATE TABLE Game (
  idGame INTEGER  NOT NULL   IDENTITY ,
  Seller_idSeller INTEGER  NOT NULL  ,
  Game_name VARCHAR (1000)   ,
  Game_description VARCHAR (1000)    ,
  Price INTEGER    ,
  Number_of_purchases INTEGER    ,
  Rating INTEGER      ,
PRIMARY KEY(idGame)  ,
  FOREIGN KEY(Seller_idSeller)
    REFERENCES Seller(idSeller));
GO


CREATE INDEX Game_FKIndex1 ON Game (Seller_idSeller);
GO


CREATE INDEX IFK_Rel_03 ON Game (Seller_idSeller);
GO


CREATE TABLE Library (
  Users_idUsers INTEGER  NOT NULL  ,
  Game_idGame INTEGER  NOT NULL  ,
  Date_purchased DATE      ,
PRIMARY KEY(Users_idUsers, Game_idGame)    ,
  FOREIGN KEY(Users_idUsers)
    REFERENCES Users(idUsers),
  FOREIGN KEY(Game_idGame)
    REFERENCES Game(idGame));
GO


CREATE INDEX Users_has_Game_FKIndex1 ON Library (Users_idUsers);
GO
CREATE INDEX Users_has_Game_FKIndex2 ON Library (Game_idGame);
GO


CREATE INDEX IFK_Rel_04 ON Library (Users_idUsers);
GO
CREATE INDEX IFK_Rel_05 ON Library (Game_idGame);
GO



CREATE PROCEDURE buygame @Username VARCHAR (1000), @idGame INTEGER
AS
insert into LIbrary (Users_idUsers, Game_idGame, Date_purchased)
VALUES ((select idUsers from Users where Username = @Username), @idGame, CAST( GETDATE() AS Date ));


CREATE PROCEDURE takemoney @Username VARCHAR (1000), @idGame INTEGER
AS
UPDATE Wallet
SET Amount = Amount - (select Price from Game where idGame = @idGame) 
WHERE idWallet = (select Wallet_idWallet from Users where Username = @Username);


CREATE PROCEDURE buy @Username VARCHAR (1000), @idGame INTEGER
AS
EXEC buygame @Username = @Username, @idGame = @idGame;
EXEC takemoney @Username = @Username, @idGame = @idGame;
