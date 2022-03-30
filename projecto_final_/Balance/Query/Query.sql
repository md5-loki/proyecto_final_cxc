create database DB_Balances

use DB_Balances

CREATE TABLE [dbo].[Balances](
  [IdentificadorCliente] [int] IDENTITY(1,1) NOT NULL,
  [FechaCorte] [date] NOT NULL,
  [AntigüedadPromedioSaldos] [nvarchar](50) NOT NULL,
  [Monto] [int] NOT NULL,
 CONSTRAINT [PK_Balances] PRIMARY KEY CLUSTERED 
(
  [IdentificadorCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

select * from Balances

drop table Balances

create table Balances
(
Id int primary key not null,
IdentificadorCliente int not null,
FechaCorte date not null,
AntigüedadPromedioSaldos nvarchar (50) not null,
Monto int not null
)

CREATE TABLE [dbo].[Clientes_](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombres] [varchar](max) NULL,
	[cedula] [varchar](25) NULL,
	[limite_credito] [int] NULL,
	[estado] [varchar](100) NULL,
 CONSTRAINT [PK_Clientes_] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

insert into Clientes_ (nombres, cedula, limite_credito, estado) values
('Luis IX', '001-12345-5', 1500, 'Activo'), 
('Lebron James', '001-12545-5', 2000, 'Activo'),
('Tatis Jr', '001-12785-5', 3000, 'Activo')

select * from Clientes_


Create Proc Mostrar_Balance_Cliente
as
Select C.nombres, C.cedula, B.FechaCorte, B.AntigüedadPromedioSaldos, B.Monto
From Balances B
inner join Clientes_ C on (B.IdentificadorCliente = C.id)

exec Mostrar_Balance_Cliente