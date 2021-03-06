USE [master]
GO
/****** Object:  Database [QLKhoHang]    Script Date: 06/23/2020 22:03:20 ******/
CREATE DATABASE [QLKhoHang]
GO
USE [QLKhoHang]
GO
/****** Object:  Table [dbo].[USERS]    Script Date: 06/23/2020 22:03:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[USERS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DisplayName] [nvarchar](max) NOT NULL,
	[Username] [varchar](max) NOT NULL,
	[Password] [varchar](max) NOT NULL,
	[IdRole] [int] NOT NULL,
 CONSTRAINT [PK__USERS__3214EC07145C0A3F] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[USERS] ON
INSERT [dbo].[USERS] ([Id], [DisplayName], [Username], [Password], [IdRole]) VALUES (1, N'Thanh Tung', N'admin', N'admin', 1)
INSERT [dbo].[USERS] ([Id], [DisplayName], [Username], [Password], [IdRole]) VALUES (2, N'Chris Phan', N'test', N'test', 2)
SET IDENTITY_INSERT [dbo].[USERS] OFF
/****** Object:  Table [dbo].[USERROLES]    Script Date: 06/23/2020 22:03:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USERROLES](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DisplayName] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[USERROLES] ON
INSERT [dbo].[USERROLES] ([Id], [DisplayName]) VALUES (1, N'Admin')
INSERT [dbo].[USERROLES] ([Id], [DisplayName]) VALUES (2, N'Staff')
SET IDENTITY_INSERT [dbo].[USERROLES] OFF
/****** Object:  Table [dbo].[UNIT]    Script Date: 06/23/2020 22:03:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UNIT](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DisplayName] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK__UNIT__3214EC077F60ED59] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[UNIT] ON
INSERT [dbo].[UNIT] ([Id], [DisplayName]) VALUES (1, N'Kg')
INSERT [dbo].[UNIT] ([Id], [DisplayName]) VALUES (2, N'Thùng')
INSERT [dbo].[UNIT] ([Id], [DisplayName]) VALUES (3, N'Bao')
SET IDENTITY_INSERT [dbo].[UNIT] OFF
/****** Object:  Table [dbo].[SUPPLIER]    Script Date: 06/23/2020 22:03:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SUPPLIER](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DisplayName] [nvarchar](max) NOT NULL,
	[Address] [nvarchar](max) NULL,
	[ContactNum] [varchar](15) NULL,
	[Email] [varchar](max) NULL,
	[AddInfo] [nvarchar](max) NULL,
	[ContractDate] [datetime] NOT NULL,
 CONSTRAINT [PK__SUPPLIER__3214EC0703317E3D] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[SUPPLIER] ON
INSERT [dbo].[SUPPLIER] ([Id], [DisplayName], [Address], [ContactNum], [Email], [AddInfo], [ContractDate]) VALUES (1, N'CompanyA', N'HoangQuocViet', N'0123456789', N'hqviet@gmail.com', NULL, CAST(0x0000AB3500000000 AS DateTime))
INSERT [dbo].[SUPPLIER] ([Id], [DisplayName], [Address], [ContactNum], [Email], [AddInfo], [ContractDate]) VALUES (2, N'CompanyB', N'DuongLang', N'123456', N'dlang@gmail.com', NULL, CAST(0x0000AB3500000000 AS DateTime))
SET IDENTITY_INSERT [dbo].[SUPPLIER] OFF
/****** Object:  Table [dbo].[OUTPUTINFO]    Script Date: 06/23/2020 22:03:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OUTPUTINFO](
	[Id] [int] NOT NULL,
	[IdInputInfo] [int] NOT NULL,
	[IdCustomer] [int] NOT NULL,
	[Count] [int] NULL,
	[Status] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[OUTPUTINFO] ([Id], [IdInputInfo], [IdCustomer], [Count], [Status]) VALUES (1, 1, 1, 10, N'Đã giao')
INSERT [dbo].[OUTPUTINFO] ([Id], [IdInputInfo], [IdCustomer], [Count], [Status]) VALUES (2, 2, 1, 100, N'Chưa giao')
INSERT [dbo].[OUTPUTINFO] ([Id], [IdInputInfo], [IdCustomer], [Count], [Status]) VALUES (3, 3, 2, 50, N'Giao lần 2')
/****** Object:  Table [dbo].[OUTPUT]    Script Date: 06/23/2020 22:03:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OUTPUT](
	[Id] [int] NOT NULL,
	[OutputDate] [datetime] NOT NULL,
 CONSTRAINT [PK__OUTPUT__3214EC0724927208] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[OUTPUT] ([Id], [OutputDate]) VALUES (1, CAST(0x0000AB8201487DC0 AS DateTime))
INSERT [dbo].[OUTPUT] ([Id], [OutputDate]) VALUES (2, CAST(0x0000AB8300000000 AS DateTime))
INSERT [dbo].[OUTPUT] ([Id], [OutputDate]) VALUES (3, CAST(0x0000ABA500000000 AS DateTime))
/****** Object:  Table [dbo].[OBJECT]    Script Date: 06/23/2020 22:03:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OBJECT](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DisplayName] [nvarchar](max) NOT NULL,
	[IdUnit] [int] NOT NULL,
	[IdSupplier] [int] NOT NULL,
 CONSTRAINT [PK__OBJECT__3214EC070AD2A005] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[OBJECT] ON
INSERT [dbo].[OBJECT] ([Id], [DisplayName], [IdUnit], [IdSupplier]) VALUES (1, N'Xi măng', 3, 1)
INSERT [dbo].[OBJECT] ([Id], [DisplayName], [IdUnit], [IdSupplier]) VALUES (2, N'Gạch', 2, 1)
SET IDENTITY_INSERT [dbo].[OBJECT] OFF
/****** Object:  Table [dbo].[INPUTINFO]    Script Date: 06/23/2020 22:03:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INPUTINFO](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdObject] [int] NOT NULL,
	[IdInput] [int] NOT NULL,
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
SET IDENTITY_INSERT [dbo].[INPUTINFO] ON
INSERT [dbo].[INPUTINFO] ([Id], [IdObject], [IdInput], [Count], [InputPrice], [OutputPrice], [Status]) VALUES (1, 1, 1, 50, 200000, 400000, N'Checked')
INSERT [dbo].[INPUTINFO] ([Id], [IdObject], [IdInput], [Count], [InputPrice], [OutputPrice], [Status]) VALUES (2, 2, 1, 1000, 20000, 50000, N'Checked')
INSERT [dbo].[INPUTINFO] ([Id], [IdObject], [IdInput], [Count], [InputPrice], [OutputPrice], [Status]) VALUES (3, 1, 2, 200, 100000, 150000, N'Unchecked')
SET IDENTITY_INSERT [dbo].[INPUTINFO] OFF
/****** Object:  Table [dbo].[INPUT]    Script Date: 06/23/2020 22:03:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INPUT](
	[Id] [int] NOT NULL,
	[InputDate] [datetime] NOT NULL,
 CONSTRAINT [PK__INPUT__3214EC071920BF5C] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[INPUT] ([Id], [InputDate]) VALUES (1, CAST(0x0000AB8200B42D00 AS DateTime))
INSERT [dbo].[INPUT] ([Id], [InputDate]) VALUES (2, CAST(0x0000AB8300000000 AS DateTime))
INSERT [dbo].[INPUT] ([Id], [InputDate]) VALUES (3, CAST(0x0000ABD40118CF80 AS DateTime))
/****** Object:  Table [dbo].[CUSTOMER]    Script Date: 06/23/2020 22:03:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CUSTOMER](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DisplayName] [nvarchar](max) NOT NULL,
	[Address] [nvarchar](max) NULL,
	[ContactNum] [varchar](15) NULL,
	[Email] [varchar](max) NULL,
	[AddInfo] [nvarchar](max) NULL,
	[ContractDate] [datetime] NOT NULL,
 CONSTRAINT [PK__CUSTOMER__3214EC0707020F21] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[CUSTOMER] ON
INSERT [dbo].[CUSTOMER] ([Id], [DisplayName], [Address], [ContactNum], [Email], [AddInfo], [ContractDate]) VALUES (1, N'Chris', N'Hanoi', N'911', N'chris@gmail.com', NULL, CAST(0x0000AB3500000000 AS DateTime))
INSERT [dbo].[CUSTOMER] ([Id], [DisplayName], [Address], [ContactNum], [Email], [AddInfo], [ContractDate]) VALUES (2, N'Tung', N'HCM', N'1900', N'tung@gmail.com', NULL, CAST(0x0000AADB00000000 AS DateTime))
SET IDENTITY_INSERT [dbo].[CUSTOMER] OFF

/****** Object:  Default [DF__INPUTINFO__Input__164452B1]    Script Date: 04/23/2020 20:41:50 ******/
ALTER TABLE [dbo].[INPUTINFO] ADD  DEFAULT ((0)) FOR [InputPrice]
GO
/****** Object:  Default [DF__INPUTINFO__Outpu__173876EA]    Script Date: 04/23/2020 20:41:50 ******/
ALTER TABLE [dbo].[INPUTINFO] ADD  DEFAULT ((0)) FOR [OutputPrice]
GO
/****** Object:  ForeignKey [FK__USERS__IdRole__164452B1]    Script Date: 04/23/2020 20:41:50 ******/
ALTER TABLE [dbo].[USERS]  WITH CHECK ADD  CONSTRAINT [FK__USERS__IdRole__164452B1] FOREIGN KEY([IdRole])
REFERENCES [dbo].[USERROLES] ([Id])
GO
ALTER TABLE [dbo].[USERS] CHECK CONSTRAINT [FK__USERS__IdRole__164452B1]
GO
/****** Object:  ForeignKey [FK__OBJECT__IdSuppli__0DAF0CB0]    Script Date: 04/23/2020 20:41:50 ******/
ALTER TABLE [dbo].[OBJECT]  WITH CHECK ADD  CONSTRAINT [FK__OBJECT__IdSuppli__0DAF0CB0] FOREIGN KEY([IdSupplier])
REFERENCES [dbo].[SUPPLIER] ([Id])
GO
ALTER TABLE [dbo].[OBJECT] CHECK CONSTRAINT [FK__OBJECT__IdSuppli__0DAF0CB0]
GO
/****** Object:  ForeignKey [FK__OBJECT__IdUnit__0CBAE877]    Script Date: 04/23/2020 20:41:50 ******/
ALTER TABLE [dbo].[OBJECT]  WITH CHECK ADD  CONSTRAINT [FK__OBJECT__IdUnit__0CBAE877] FOREIGN KEY([IdUnit])
REFERENCES [dbo].[UNIT] ([Id])
GO
ALTER TABLE [dbo].[OBJECT] CHECK CONSTRAINT [FK__OBJECT__IdUnit__0CBAE877]
GO
/****** Object:  ForeignKey [FK__INPUTINFO__IdInp__21B6055D]    Script Date: 04/23/2020 20:41:50 ******/
ALTER TABLE [dbo].[INPUTINFO]  WITH CHECK ADD  CONSTRAINT [FK__INPUTINFO__IdInp__21B6055D] FOREIGN KEY([IdInput])
REFERENCES [dbo].[INPUT] ([Id])
GO
ALTER TABLE [dbo].[INPUTINFO] CHECK CONSTRAINT [FK__INPUTINFO__IdInp__21B6055D]
GO
/****** Object:  ForeignKey [FK__INPUTINFO__Statu__20C1E124]    Script Date: 04/23/2020 20:41:50 ******/
ALTER TABLE [dbo].[INPUTINFO]  WITH CHECK ADD  CONSTRAINT [FK__INPUTINFO__Statu__20C1E124] FOREIGN KEY([IdObject])
REFERENCES [dbo].[OBJECT] ([Id])
GO
ALTER TABLE [dbo].[INPUTINFO] CHECK CONSTRAINT [FK__INPUTINFO__Statu__20C1E124]
GO
/****** Object:  ForeignKey [FK__OUTPUTINF__IdInp__1DE57479]    Script Date: 04/23/2020 20:41:50 ******/
ALTER TABLE [dbo].[OUTPUTINFO]  WITH CHECK ADD FOREIGN KEY([IdInputInfo])
REFERENCES [dbo].[INPUTINFO] ([Id])
GO
/****** Object:  ForeignKey [FK_OUTPUTINFO_CUSTOMER]    Script Date: 04/23/2020 20:41:50 ******/
ALTER TABLE [dbo].[OUTPUTINFO]  WITH CHECK ADD  CONSTRAINT [FK_OUTPUTINFO_CUSTOMER] FOREIGN KEY([IdCustomer])
REFERENCES [dbo].[CUSTOMER] ([Id])
GO
ALTER TABLE [dbo].[OUTPUTINFO] CHECK CONSTRAINT [FK_OUTPUTINFO_CUSTOMER]
GO

--RESET VALUE ALL KEYS
DBCC CHECKIDENT ('CUSTOMER', RESEED,0)
DBCC CHECKIDENT ('INPUTINFO', RESEED)
DBCC CHECKIDENT ('OBJECT', RESEED,0)
DBCC CHECKIDENT ('SUPPLIER', RESEED,0)
DBCC CHECKIDENT ('UNIT', RESEED,0)
DBCC CHECKIDENT ('USERROLES', RESEED,0)
DBCC CHECKIDENT ('USERS', RESEED,0)