USE [master]
GO
/****** Object:  Database [dbApi]    Script Date: 14/01/2021 11:10:42 ******/
CREATE DATABASE [dbApi]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbApi', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXP2016\MSSQL\DATA\dbApi.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'dbApi_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXP2016\MSSQL\DATA\dbApi_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [dbApi] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbApi].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbApi] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbApi] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbApi] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbApi] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbApi] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbApi] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dbApi] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbApi] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbApi] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbApi] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbApi] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbApi] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbApi] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbApi] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbApi] SET  DISABLE_BROKER 
GO
ALTER DATABASE [dbApi] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbApi] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbApi] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbApi] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbApi] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbApi] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbApi] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbApi] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [dbApi] SET  MULTI_USER 
GO
ALTER DATABASE [dbApi] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbApi] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbApi] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbApi] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [dbApi] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [dbApi] SET QUERY_STORE = OFF
GO
USE [dbApi]
GO
/****** Object:  Table [dbo].[ContasPagar]    Script Date: 14/01/2021 11:10:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContasPagar](
	[id_conta] [int] IDENTITY(1,1) NOT NULL,
	[nome] [nvarchar](100) NOT NULL,
	[valor_original] [numeric](18, 2) NOT NULL,
	[data_vencimento] [datetime] NOT NULL,
	[data_pagamento] [datetime] NOT NULL,
	[valor_corrigido] [numeric](18, 2) NOT NULL,
	[qtde_dias_atraso] [int] NOT NULL,
	[dias_atraso] [nvarchar](20) NULL,
	[multa] [nvarchar](5) NULL,
	[juros_dia] [nvarchar](5) NULL,
 CONSTRAINT [PK_ContasPagar] PRIMARY KEY CLUSTERED 
(
	[id_conta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ContasPagar] ON 
GO
INSERT [dbo].[ContasPagar] ([id_conta], [nome], [valor_original], [data_vencimento], [data_pagamento], [valor_corrigido], [qtde_dias_atraso], [dias_atraso], [multa], [juros_dia]) VALUES (1, N'JOSE RODRIGUES', CAST(15.00 AS Numeric(18, 2)), CAST(N'2021-02-26T00:00:00.000' AS DateTime), CAST(N'2021-03-13T00:00:00.000' AS DateTime), CAST(16.00 AS Numeric(18, 2)), 0, NULL, NULL, NULL)
GO
INSERT [dbo].[ContasPagar] ([id_conta], [nome], [valor_original], [data_vencimento], [data_pagamento], [valor_corrigido], [qtde_dias_atraso], [dias_atraso], [multa], [juros_dia]) VALUES (2, N'BARBILANE LIMA VIEIRA', CAST(55.30 AS Numeric(18, 2)), CAST(N'2021-02-14T00:00:00.000' AS DateTime), CAST(N'2021-03-14T00:00:00.000' AS DateTime), CAST(60.05 AS Numeric(18, 2)), 0, NULL, NULL, NULL)
GO
INSERT [dbo].[ContasPagar] ([id_conta], [nome], [valor_original], [data_vencimento], [data_pagamento], [valor_corrigido], [qtde_dias_atraso], [dias_atraso], [multa], [juros_dia]) VALUES (3, N'RAIMUNDO NONATO', CAST(55.30 AS Numeric(18, 2)), CAST(N'2021-02-14T00:00:00.000' AS DateTime), CAST(N'2021-03-14T00:00:00.000' AS DateTime), CAST(58.22 AS Numeric(18, 2)), 28, NULL, NULL, NULL)
GO
INSERT [dbo].[ContasPagar] ([id_conta], [nome], [valor_original], [data_vencimento], [data_pagamento], [valor_corrigido], [qtde_dias_atraso], [dias_atraso], [multa], [juros_dia]) VALUES (4, N'XXXXXXXXX', CAST(55.30 AS Numeric(18, 2)), CAST(N'2021-02-14T00:00:00.000' AS DateTime), CAST(N'2021-03-14T00:00:00.000' AS DateTime), CAST(58.22 AS Numeric(18, 2)), 28, NULL, NULL, NULL)
GO
INSERT [dbo].[ContasPagar] ([id_conta], [nome], [valor_original], [data_vencimento], [data_pagamento], [valor_corrigido], [qtde_dias_atraso], [dias_atraso], [multa], [juros_dia]) VALUES (5, N'MARIA FLOR RODRIGUES DOS SANTOS', CAST(10.30 AS Numeric(18, 2)), CAST(N'2021-02-14T00:00:00.000' AS DateTime), CAST(N'2021-03-14T00:00:00.000' AS DateTime), CAST(10.84 AS Numeric(18, 2)), 28, NULL, NULL, NULL)
GO
INSERT [dbo].[ContasPagar] ([id_conta], [nome], [valor_original], [data_vencimento], [data_pagamento], [valor_corrigido], [qtde_dias_atraso], [dias_atraso], [multa], [juros_dia]) VALUES (6, N'teste incluir regra calculo', CAST(10.30 AS Numeric(18, 2)), CAST(N'2021-02-14T00:00:00.000' AS DateTime), CAST(N'2021-04-14T00:00:00.000' AS DateTime), CAST(10.88 AS Numeric(18, 2)), 59, N'superior a 5 dias', N'2%', N'0,1%')
GO
INSERT [dbo].[ContasPagar] ([id_conta], [nome], [valor_original], [data_vencimento], [data_pagamento], [valor_corrigido], [qtde_dias_atraso], [dias_atraso], [multa], [juros_dia]) VALUES (7, N'teste incluir regra calculo teste data atraso', CAST(10.30 AS Numeric(18, 2)), CAST(N'2021-01-13T00:00:00.000' AS DateTime), CAST(N'2021-01-16T00:00:00.000' AS DateTime), CAST(10.20 AS Numeric(18, 2)), 0, NULL, NULL, NULL)
GO
INSERT [dbo].[ContasPagar] ([id_conta], [nome], [valor_original], [data_vencimento], [data_pagamento], [valor_corrigido], [qtde_dias_atraso], [dias_atraso], [multa], [juros_dia]) VALUES (8, N'teste incluir regra calculo teste data atraso1', CAST(10.30 AS Numeric(18, 2)), CAST(N'2021-01-13T00:00:00.000' AS DateTime), CAST(N'2021-01-16T00:00:00.000' AS DateTime), CAST(10.51 AS Numeric(18, 2)), 3, N'até 3 dias', N'2%', N'0,1%')
GO
INSERT [dbo].[ContasPagar] ([id_conta], [nome], [valor_original], [data_vencimento], [data_pagamento], [valor_corrigido], [qtde_dias_atraso], [dias_atraso], [multa], [juros_dia]) VALUES (9, N'teste incluir regra calculo teste data atraso1 MAIS1', CAST(10.30 AS Numeric(18, 2)), CAST(N'2021-01-13T00:00:00.000' AS DateTime), CAST(N'2021-01-16T00:00:00.000' AS DateTime), CAST(10.51 AS Numeric(18, 2)), 3, N'até 3 dias', N'2%', N'0,1%')
GO
SET IDENTITY_INSERT [dbo].[ContasPagar] OFF
GO
ALTER TABLE [dbo].[ContasPagar] ADD  CONSTRAINT [DF_ContasPagar_valor_corrigido]  DEFAULT ((0)) FOR [valor_corrigido]
GO
ALTER TABLE [dbo].[ContasPagar] ADD  CONSTRAINT [DF_ContasPagar_qtde_dias_atraso]  DEFAULT ((0)) FOR [qtde_dias_atraso]
GO
USE [master]
GO
ALTER DATABASE [dbApi] SET  READ_WRITE 
GO
