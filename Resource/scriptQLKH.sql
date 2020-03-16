USE [master]
GO
/****** Object:  Database [QLKhoHang]    Script Date: 02/05/2020 21:42:58 ******/
CREATE DATABASE [QLKhoHang] 
GO
USE [QLKhoHang]
GO
/****** Object:  Table [dbo].[INPUT]    Script Date: 02/05/2020 21:42:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INPUT](
	[Id] [nvarchar](128) NOT NULL,
	[InputDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CUSTOMER]    Script Date: 02/05/2020 21:42:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CUSTOMER](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DisplayName] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[ContactNum] [nvarchar](11) NULL,
	[Email] [nvarchar](max) NULL,
	[AddInfo] [nvarchar](max) NULL,
	[ContractDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OUTPUT]    Script Date: 02/05/2020 21:42:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OUTPUT](
	[Id] [nvarchar](128) NOT NULL,
	[OutputDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USERROLES]    Script Date: 02/05/2020 21:42:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USERROLES](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DisplayName] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[USERROLES] ON
INSERT [dbo].[USERROLES] ([Id], [DisplayName]) VALUES (1, N'Admin')
INSERT [dbo].[USERROLES] ([Id], [DisplayName]) VALUES (3, N'Staff')
SET IDENTITY_INSERT [dbo].[USERROLES] OFF
/****** Object:  Table [dbo].[UNIT]    Script Date: 02/05/2020 21:42:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UNIT](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DisplayName] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SUPPLIER]    Script Date: 02/05/2020 21:42:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SUPPLIER](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DisplayName] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[ContactNum] [nvarchar](20) NULL,
	[Email] [nvarchar](max) NULL,
	[AddInfo] [nvarchar](max) NULL,
	[ContractDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USERS]    Script Date: 02/05/2020 21:42:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USERS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DisplayName] [nvarchar](max) NULL,
	[Username] [nvarchar](100) NULL,
	[Password] [nvarchar](max) NULL,
	[IdRole] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[USERS] ON
INSERT [dbo].[USERS] ([Id], [DisplayName], [Username], [Password], [IdRole]) VALUES (1, N'Thanh Tung', N'admin', N'abcdef123456', 1)
INSERT [dbo].[USERS] ([Id], [DisplayName], [Username], [Password], [IdRole]) VALUES (2, N'Chris', N'test1', N'654321fedcba', 3)
SET IDENTITY_INSERT [dbo].[USERS] OFF
/****** Object:  Table [dbo].[OBJECT]    Script Date: 02/05/2020 21:42:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OBJECT](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DisplayName] [nvarchar](max) NULL,
	[IdUnit] [int] NOT NULL,
	[IdSupplier] [int] NOT NULL,
	[QRCode] [nvarchar](max) NULL,
	[BarCode] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[INPUTINFO]    Script Date: 02/05/2020 21:42:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INPUTINFO](
	[Id] [nvarchar](128) NOT NULL,
	[IdObject] [int] NOT NULL,
	[IdInput] [nvarchar](128) NOT NULL,
	[Count] [int] NULL,
	[InputPrice] [float] NULL,
	[OutputPrice] [float] NULL,
	[Status] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OUTPUTINFO]    Script Date: 02/05/2020 21:42:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OUTPUTINFO](
	[Id] [nvarchar](128) NOT NULL,
	[IdObject] [int] NOT NULL,
	[IdInputInfo] [nvarchar](128) NOT NULL,
	[IdCustomer] [int] NOT NULL,
	[Count] [int] NULL,
	[Status] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Default [DF__INPUTINFO__Input__1ED998B2]    Script Date: 02/05/2020 21:42:58 ******/
ALTER TABLE [dbo].[INPUTINFO] ADD  DEFAULT ((0)) FOR [InputPrice]
GO
/****** Object:  Default [DF__INPUTINFO__Outpu__1FCDBCEB]    Script Date: 02/05/2020 21:42:58 ******/
ALTER TABLE [dbo].[INPUTINFO] ADD  DEFAULT ((0)) FOR [OutputPrice]
GO
/****** Object:  ForeignKey [FK__USERS__IdRole__164452B1]    Script Date: 02/05/2020 21:42:58 ******/
ALTER TABLE [dbo].[USERS]  WITH CHECK ADD FOREIGN KEY([IdRole])
REFERENCES [dbo].[USERROLES] ([Id])
GO
/****** Object:  ForeignKey [FK__OBJECT__IdSuppli__0DAF0CB0]    Script Date: 02/05/2020 21:42:58 ******/
ALTER TABLE [dbo].[OBJECT]  WITH CHECK ADD FOREIGN KEY([IdSupplier])
REFERENCES [dbo].[SUPPLIER] ([Id])
GO
/****** Object:  ForeignKey [FK__OBJECT__IdUnit__0CBAE877]    Script Date: 02/05/2020 21:42:58 ******/
ALTER TABLE [dbo].[OBJECT]  WITH CHECK ADD FOREIGN KEY([IdUnit])
REFERENCES [dbo].[UNIT] ([Id])
GO
/****** Object:  ForeignKey [FK__INPUTINFO__IdInp__21B6055D]    Script Date: 02/05/2020 21:42:58 ******/
ALTER TABLE [dbo].[INPUTINFO]  WITH CHECK ADD FOREIGN KEY([IdInput])
REFERENCES [dbo].[INPUT] ([Id])
GO
/****** Object:  ForeignKey [FK__INPUTINFO__Statu__20C1E124]    Script Date: 02/05/2020 21:42:58 ******/
ALTER TABLE [dbo].[INPUTINFO]  WITH CHECK ADD FOREIGN KEY([IdObject])
REFERENCES [dbo].[OBJECT] ([Id])
GO
/****** Object:  ForeignKey [FK__OUTPUTINF__IdCus__2C3393D0]    Script Date: 02/05/2020 21:42:58 ******/
ALTER TABLE [dbo].[OUTPUTINFO]  WITH CHECK ADD FOREIGN KEY([IdCustomer])
REFERENCES [dbo].[CUSTOMER] ([Id])
GO
/****** Object:  ForeignKey [FK__OUTPUTINF__IdInp__2B3F6F97]    Script Date: 02/05/2020 21:42:58 ******/
ALTER TABLE [dbo].[OUTPUTINFO]  WITH CHECK ADD FOREIGN KEY([IdInputInfo])
REFERENCES [dbo].[INPUTINFO] ([Id])
GO
/****** Object:  ForeignKey [FK__OUTPUTINF__Statu__2A4B4B5E]    Script Date: 02/05/2020 21:42:58 ******/
ALTER TABLE [dbo].[OUTPUTINFO]  WITH CHECK ADD FOREIGN KEY([IdObject])
REFERENCES [dbo].[OBJECT] ([Id])
GO
