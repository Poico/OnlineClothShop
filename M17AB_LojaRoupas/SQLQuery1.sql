create TABLE Roupa
(
	ID int identity(1,1) primary key,
	IDModelo int,
	Image VARBINARY(MAX),
	Nome varchar(20) check (Nome NOT like '%[^a-z]%') not null,
	Cor varchar(20) check (Cor NOT like '%[^a-z]%') not null,
	Tamanho varchar(4),
	Preco money,
	descricao varchar(max),
	Designer varchar(20),
	Data date default Getdate(),
	Promocao smallint,
	Rating smallint,
);

create Table Utilizador(
	ID int identity(1,1) primary key,
	email varchar(30),
	Nome varchar(20),
	Password varchar(20),
	IP varchar(15),
	Data date default Getdate(),
	Admin bit,
);

create Table Rating(
	ID int identity(1,1) primary key,
	IDModelo int FOREIGN KEY REFERENCES Roupa(IDModelo),
	Rating smallint,
);

create Table Compras(
	ID int identity(1,1) primary key,
	Data date default Getdate(),
	Total money,
	IDCliente int FOREIGN KEY REFERENCES Utilizador(ID),
	finalizada bit,
	estado varchar(20),
);

create Table ProdutosCompras(
	ID int identity(1,1) primary key,
	IDCompra int FOREIGN KEY REFERENCES Compras(ID),
	IDRoupa int Foreign key references Roupa(ID),
	Quantidade int,
	Preco money,
);

create Table Favoritos(
	ID int identity(1,1) primary key,
	IDCliente int FOREIGN KEY REFERENCES Utilizador(ID),
	IDRoupa int Foreign key references Roupa(ID),
);

create Table Comentarios(
	ID int identity(1,1) primary key,
	IDCliente int FOREIGN KEY REFERENCES Utilizador(ID),
	IDModelo int Foreign key references Roupa(IDModelo),
	Descrisao varchar(max),
	Data date default Getdate(),
);