create table categories (
	Nom VARCHAR(100),
	CONSTRAINT PK_Categories PRIMARY KEY (Nom),
);
create table productes (
	Codi VARCHAR(100) NOT NULL,
	Nom VARCHAR(100) NOT NULL,
	Refrigerat BIT NOT NULL,
	PreuVenta FLOAT NOT NULL,
	CONSTRAINT PK_Productes PRIMARY KEY (Codi),
);

create table clients (
	NIF varchar(9) NOT NULL,
	Nom VARCHAR(100) UNIQUE NOT NULL,
	eMail VARCHAR(100) NOT NULL,
	CONSTRAINT PK_Clients PRIMARY KEY (NIF),
);

create table factures(
	AnyFiscal INT NOT NULL,
	Serie VARCHAR(250) NOT NULL,
	Numero INT IDENTITY(1,1) NOT NULL,
	Descripcio VARCHAR(400),
	Total FLOAT NOT NULL,
	Data DATETIME DEFAULT GETDATE(),
	Cobrada BIT,
	Client VARCHAR(100) NOT NULL,
	CONSTRAINT PK_Factures PRIMARY KEY (AnyFiscal,Serie,Numero),
	CONSTRAINT FK_Factures_Client FOREIGN KEY (Client) REFERENCES clients(Nom),
);

create table liniaDeFactura(
	AnyFiscal INT NOT NULL,
	Serie VARCHAR(250) NOT NULL,
	Numero INT NOT NULL,
	Producte VARCHAR(100) NOT NULL,
	Quantitat INT NOT NULL,
	CONSTRAINT PK_LiniaDeFactura PRIMARY KEY (AnyFiscal,Serie,Numero,Producte),
	CONSTRAINT FK_LiniaDeFactura_Factures FOREIGN KEY (AnyFiscal,Serie,Numero) REFERENCES factures(AnyFiscal,Serie,Numero),
	CONSTRAINT FK_LiniaDeFactura_Productes FOREIGN KEY (Producte) REFERENCES productes(Codi),
);

select * from factures;

select * from productes;

insert into productes (Codi,Nom,Refrigerat,PreuVenta) values ('ABC','Llet',1,5);
insert into productes (Codi,Nom,Refrigerat,PreuVenta) values ('DEF','Galetes',1,7);
insert into productes (Codi,Nom,Refrigerat,PreuVenta) values ('GHI','Macarrons',1,10);

select * from clients;

insert into clients (NIF, Nom, eMail) values ('40440841X','Jan','janbonaterra@gmail.com');
insert into clients (NIF, Nom, eMail) values ('50451842G','Anas','abenayad@gmail.com');

select * from factures;

insert into factures (AnyFiscal,Serie,Descripcio,Total,Cobrada,Client) values (2026,'ABC','aaaa',400,400,'Jan');
insert into factures (AnyFiscal,Serie,Descripcio,Total,Cobrada,Client) values (2026,'bbb','aaaa',200,200,'Anas');
insert into factures (AnyFiscal,Serie,Descripcio,Total,Cobrada,Client) values (2026,'ccc','aaaa',10,10,'Jan');

select * from LiniaDeFactura;

insert into LiniaDeFactura (AnyFiscal,Serie,Numero,Producte,Quantitat) values (2026,'ABC',3,'ABC',4);
insert into LiniaDeFactura (AnyFiscal,Serie,Numero,Producte,Quantitat) values (2026,'ccc',4,'DEF',2);
insert into LiniaDeFactura (AnyFiscal,Serie,Numero,Producte,Quantitat) values (2026,'ccc',5,'GHI',1);

delete from clients where Nom='Jan';
