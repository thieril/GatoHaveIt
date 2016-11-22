CREATE TABLE [dbo]. [Customer]
(
[CustomerId] int NOT NULL PRIMARY KEY IDENTITY,
[FirstName] varchar(100) NOT NULL,
[LastName] varchar(200) NOT NULL,
[Address] int NOT NULL,
[City] varchar(100) NOT NULL,
[ZipCode] varchar(20) NOT NULL,
[Telephone] varchar(20) NULL,
[Email] varchar(100) NOT NULL,
[Password] varchar(100) NOT NULL
)

CREATE TABLE [dbo]. [Order]
(
[OrderId] int NOT NULL PRIMARY KEY IDENTITY,
[OrderDate] date NOT NULL,
[Total] int NOT NULL,
[CustomerId] int NOT NULL
CONSTRAINT [FK_CustomerId] FOREIGN KEY ([CustomerId])
REFERENCES Customer([CustomerId])
)


CREATE TABLE [dbo]. [Merchandise]
(
[ItemNumber] int NOT NULL PRIMARY KEY IDENTITY,
[Price] decimal NOT NULL,
[Descrption] varchar(300) NOT NULL,
[ImageURL] varchar(500) NOT NULL
)



CREATE TABLE [dbo]. [OrderDetail]
(
[OrderDetailId] int NOT NULL PRIMARY KEY IDENTITY,
[Quantity] int NOT NULL,
[UnitPrice] decimal NOT NULL,
[ItemNumber] int NOT NULL,
[OrderId] int NOT NULL
CONSTRAINT [FK_ItemNumber] FOREIGN KEY ([ItemNumber])
REFERENCES Merchandise([ItemNumber]),
CONSTRAINT [FK_OrderId] FOREIGN KEY ([OrderId])
REFERENCES [Order]([OrderId])
)