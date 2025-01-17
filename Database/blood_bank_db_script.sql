USE [BloodBankDB]
GO
/****** Object:  Schema [bloodbank]    Script Date: 5/6/2020 8:09:46 PM ******/
CREATE SCHEMA [bloodbank]
GO
/****** Object:  Table [bloodbank].[Address]    Script Date: 5/6/2020 8:09:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [bloodbank].[Address](
	[addressId] [int] IDENTITY(1,1) NOT NULL,
	[streetNumber] [int] NOT NULL,
	[streetName] [nvarchar](30) NOT NULL,
	[city] [nvarchar](30) NOT NULL,
	[province] [nvarchar](30) NOT NULL,
	[country] [nvarchar](30) NOT NULL,
	[postalCode] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[addressId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [bloodbank].[BloodRequestPatientDetails]    Script Date: 5/6/2020 8:09:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [bloodbank].[BloodRequestPatientDetails](
	[patientId] [int] IDENTITY(1,1) NOT NULL,
	[firstName] [nvarchar](50) NOT NULL,
	[lastName] [nvarchar](50) NOT NULL,
	[bloodGroup] [nvarchar](20) NOT NULL,
	[age] [int] NOT NULL,
	[bloodUnit] [int] NOT NULL,
	[reasonOfNeed] [nvarchar](50) NOT NULL,
	[purpose] [nvarchar](200) NOT NULL,
	[phoneNo] [nvarchar](20) NOT NULL,
	[hospital] [nvarchar](50) NOT NULL,
	[addressId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[patientId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [bloodbank].[BloodStock]    Script Date: 5/6/2020 8:09:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [bloodbank].[BloodStock](
	[bloodStockId] [int] IDENTITY(1,1) NOT NULL,
	[bloodBank] [nvarchar](50) NOT NULL,
	[bloodGroup] [nvarchar](20) NOT NULL,
	[numberOfBottles] [int] NOT NULL,
	[city] [nvarchar](30) NOT NULL,
	[phoneNo] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[bloodStockId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [bloodbank].[DonorDetails]    Script Date: 5/6/2020 8:09:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [bloodbank].[DonorDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[firstName] [nvarchar](50) NOT NULL,
	[lastName] [nvarchar](50) NOT NULL,
	[bloodGroup] [nvarchar](20) NOT NULL,
	[age] [int] NOT NULL,
	[gender] [nvarchar](6) NOT NULL,
	[addressId] [int] NOT NULL,
	[phoneNo] [nvarchar](20) NOT NULL,
	[email] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [bloodbank].[BloodRequestPatientDetails]  WITH CHECK ADD  CONSTRAINT [FK_BloodRequestPatientDetails_ToAddress] FOREIGN KEY([addressId])
REFERENCES [bloodbank].[Address] ([addressId])
GO
ALTER TABLE [bloodbank].[BloodRequestPatientDetails] CHECK CONSTRAINT [FK_BloodRequestPatientDetails_ToAddress]
GO
ALTER TABLE [bloodbank].[DonorDetails]  WITH CHECK ADD  CONSTRAINT [FK_DonorDetails_ToDonorAddress] FOREIGN KEY([addressId])
REFERENCES [bloodbank].[Address] ([addressId])
GO
ALTER TABLE [bloodbank].[DonorDetails] CHECK CONSTRAINT [FK_DonorDetails_ToDonorAddress]
GO
