﻿SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Baskets](
	[Id] [uniqueidentifier] NOT NULL,
	[CreatedAt] [datetimeoffset](7) NOT NULL,
	[CreatedBy] [nvarchar](200) NOT NULL,
	[UpdatedAt] [datetimeoffset](7) NOT NULL,
	[UpdatedBy] [nvarchar](200) NOT NULL,
	[DeletedAt] [datetimeoffset](7) NULL,
	[Title] [nvarchar](120) NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[Count] [int] NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Photo] [nvarchar](max) NULL,
	[PersonId] [uniqueidentifier] NOT NULL,
	[StatusBy] [int] NOT NULL,
 CONSTRAINT [PK_Baskets] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cards]    Script Date: 20.12.2023 0:42:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cards](
	[Id] [uniqueidentifier] NOT NULL,
	[CreatedAt] [datetimeoffset](7) NOT NULL,
	[CreatedBy] [nvarchar](200) NOT NULL,
	[UpdatedAt] [datetimeoffset](7) NOT NULL,
	[UpdatedBy] [nvarchar](200) NOT NULL,
	[DeletedAt] [datetimeoffset](7) NULL,
	[Nomer] [nvarchar](40) NOT NULL,
	[CSCCode] [int] NOT NULL,
	[DateEnd] [nvarchar](max) NOT NULL,
	[Balance] [decimal](18, 2) NOT NULL,
	[PinCode] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_Cards] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DBBanks]    Script Date: 20.12.2023 0:42:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DBBanks](
	[Id] [uniqueidentifier] NOT NULL,
	[CreatedAt] [datetimeoffset](7) NOT NULL,
	[CreatedBy] [nvarchar](200) NOT NULL,
	[UpdatedAt] [datetimeoffset](7) NOT NULL,
	[UpdatedBy] [nvarchar](200) NOT NULL,
	[DeletedAt] [datetimeoffset](7) NULL,
	[Login] [nvarchar](80) NOT NULL,
	[Password] [nvarchar](300) NOT NULL,
	[Role] [int] NOT NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_DBBanks] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Persons]    Script Date: 20.12.2023 0:42:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persons](
	[Id] [uniqueidentifier] NOT NULL,
	[CreatedAt] [datetimeoffset](7) NOT NULL,
	[CreatedBy] [nvarchar](200) NOT NULL,
	[UpdatedAt] [datetimeoffset](7) NOT NULL,
	[UpdatedBy] [nvarchar](200) NOT NULL,
	[DeletedAt] [datetimeoffset](7) NULL,
	[Surname] [nvarchar](80) NOT NULL,
	[Name] [nvarchar](80) NOT NULL,
	[Phone] [nvarchar](450) NOT NULL,
	[Gender] [int] NOT NULL,
	[CardName] [nvarchar](max) NULL,
 CONSTRAINT [PK_Persons] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tovars]    Script Date: 20.12.2023 0:42:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tovars](
	[Id] [uniqueidentifier] NOT NULL,
	[CreatedAt] [datetimeoffset](7) NOT NULL,
	[CreatedBy] [nvarchar](200) NOT NULL,
	[UpdatedAt] [datetimeoffset](7) NOT NULL,
	[UpdatedBy] [nvarchar](200) NOT NULL,
	[DeletedAt] [datetimeoffset](7) NULL,
	[Title] [nvarchar](120) NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[MaxCount] [int] NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Photo] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tovars] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Baskets] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [Title], [Price], [Count], [Description], [Photo], [PersonId], [StatusBy]) VALUES (N'67cb089c-0828-4a66-a3cd-11e86af6c76e', CAST(N'2023-12-16T21:33:06.0923290+00:00' AS DateTimeOffset), N'Admin_Admin', CAST(N'2023-12-16T21:33:13.4503262+00:00' AS DateTimeOffset), N'Анонимный', NULL, N'32', CAST(34.00 AS Decimal(18, 2)), 1, N'234', N'C:\Users\Николаев Вячеслав\Downloads\Users.png', N'78687fa7-9982-4712-b477-18adc7933d54', 1)
INSERT [dbo].[Baskets] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [Title], [Price], [Count], [Description], [Photo], [PersonId], [StatusBy]) VALUES (N'6a67c09c-06e7-474a-8cfb-2efe886b98f4', CAST(N'2023-12-16T00:37:18.9393790+00:00' AS DateTimeOffset), N'Admin_Admin', CAST(N'2023-12-16T00:37:18.9393790+00:00' AS DateTimeOffset), N'Admin_Admin', CAST(N'2023-12-16T00:45:09.5428671+00:00' AS DateTimeOffset), N'kjgh', CAST(4234.00 AS Decimal(18, 2)), 2, N'', N'', N'78687fa7-9982-4712-b477-18adc7933d54', 0)
INSERT [dbo].[Baskets] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [Title], [Price], [Count], [Description], [Photo], [PersonId], [StatusBy]) VALUES (N'42914208-d5e5-47db-a407-468178d0b0b2', CAST(N'2023-12-16T00:45:26.7712251+00:00' AS DateTimeOffset), N'Admin_Admin', CAST(N'2023-12-16T00:45:26.7712251+00:00' AS DateTimeOffset), N'Admin_Admin', CAST(N'2023-12-16T00:45:44.1498539+00:00' AS DateTimeOffset), N'kjgh', CAST(4234.00 AS Decimal(18, 2)), 1, N'sdfsefsewrt2w3', N'', N'78687fa7-9982-4712-b477-18adc7933d54', 0)
INSERT [dbo].[Baskets] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [Title], [Price], [Count], [Description], [Photo], [PersonId], [StatusBy]) VALUES (N'00867de0-619e-4d8a-aae1-4c04573f8876', CAST(N'2023-12-16T01:04:24.9577385+00:00' AS DateTimeOffset), N'Admin_Admin', CAST(N'2023-12-16T01:04:29.4327356+00:00' AS DateTimeOffset), N'Анонимный', NULL, N'Game', CAST(123.00 AS Decimal(18, 2)), 1, N'123', N'C:\Users\Николаев Вячеслав\Downloads\Game.png', N'78687fa7-9982-4712-b477-18adc7933d54', 1)
INSERT [dbo].[Baskets] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [Title], [Price], [Count], [Description], [Photo], [PersonId], [StatusBy]) VALUES (N'30610a0f-b1c5-4598-aeb3-68c161e4efc2', CAST(N'2023-12-16T21:57:34.6397591+00:00' AS DateTimeOffset), N'1_1', CAST(N'2023-12-16T21:57:34.6397591+00:00' AS DateTimeOffset), N'1_1', CAST(N'2023-12-16T21:57:42.4284095+00:00' AS DateTimeOffset), N'32', CAST(34.00 AS Decimal(18, 2)), 6, N'234', N'C:\Users\Николаев Вячеслав\Downloads\Users.png', N'ea7c33a5-c372-4e59-b40e-31112d347df7', 0)
INSERT [dbo].[Baskets] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [Title], [Price], [Count], [Description], [Photo], [PersonId], [StatusBy]) VALUES (N'9cfbd6b3-2e8f-4d52-b3ae-77872addccaa', CAST(N'2023-12-16T21:57:47.8500984+00:00' AS DateTimeOffset), N'1_1', CAST(N'2023-12-16T21:57:58.6381645+00:00' AS DateTimeOffset), N'Анонимный', NULL, N'32', CAST(34.00 AS Decimal(18, 2)), 10, N'234', N'C:\Users\Николаев Вячеслав\Downloads\Users.png', N'ea7c33a5-c372-4e59-b40e-31112d347df7', 1)
INSERT [dbo].[Baskets] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [Title], [Price], [Count], [Description], [Photo], [PersonId], [StatusBy]) VALUES (N'b77aabd4-dc8a-480e-8de6-7b1715d36703', CAST(N'2023-12-16T01:03:47.7963552+00:00' AS DateTimeOffset), N'Admin_Admin', CAST(N'2023-12-16T01:03:47.7963552+00:00' AS DateTimeOffset), N'Admin_Admin', CAST(N'2023-12-16T01:04:21.2352091+00:00' AS DateTimeOffset), N'Game', CAST(123.00 AS Decimal(18, 2)), 1, N'123', N'C:\Users\Николаев Вячеслав\Downloads\Game.png', N'78687fa7-9982-4712-b477-18adc7933d54', 0)
INSERT [dbo].[Baskets] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [Title], [Price], [Count], [Description], [Photo], [PersonId], [StatusBy]) VALUES (N'ca15d54c-68a3-46e7-afb2-819aa9b38cbc', CAST(N'2023-12-16T20:46:49.1691606+00:00' AS DateTimeOffset), N'Admin_Admin', CAST(N'2023-12-16T21:02:40.1702183+00:00' AS DateTimeOffset), N'Анонимный', NULL, N'123', CAST(123.00 AS Decimal(18, 2)), 1, N'123', N'', N'78687fa7-9982-4712-b477-18adc7933d54', 1)
INSERT [dbo].[Baskets] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [Title], [Price], [Count], [Description], [Photo], [PersonId], [StatusBy]) VALUES (N'89b98e2f-df76-4284-8008-a3f1914ab3a4', CAST(N'2023-12-16T00:07:33.1246901+00:00' AS DateTimeOffset), N'Admin_Admin', CAST(N'2023-12-16T21:02:45.6452155+00:00' AS DateTimeOffset), N'Анонимный', NULL, N'Группа', CAST(123.00 AS Decimal(18, 2)), 2, N'', N'C:\Users\Николаев Вячеслав\Downloads\Users.png', N'78687fa7-9982-4712-b477-18adc7933d54', 1)
INSERT [dbo].[Baskets] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [Title], [Price], [Count], [Description], [Photo], [PersonId], [StatusBy]) VALUES (N'88ae187e-0da6-4dee-9390-b96ad2ae7edc', CAST(N'2023-12-16T00:36:33.9144291+00:00' AS DateTimeOffset), N'Admin_Admin', CAST(N'2023-12-16T00:36:33.9144291+00:00' AS DateTimeOffset), N'Admin_Admin', CAST(N'2023-12-16T00:45:35.9580975+00:00' AS DateTimeOffset), N'kjgh', CAST(4234.00 AS Decimal(18, 2)), 2, N'', N'', N'78687fa7-9982-4712-b477-18adc7933d54', 0)
INSERT [dbo].[Baskets] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [Title], [Price], [Count], [Description], [Photo], [PersonId], [StatusBy]) VALUES (N'185ee6be-17d9-4fd4-995e-beb7c8861d38', CAST(N'2023-12-16T21:02:53.7402166+00:00' AS DateTimeOffset), N'Admin_Admin', CAST(N'2023-12-16T21:02:53.7402166+00:00' AS DateTimeOffset), N'Admin_Admin', NULL, N'123', CAST(123.00 AS Decimal(18, 2)), 1, N'12312313', N'', N'78687fa7-9982-4712-b477-18adc7933d54', 0)
INSERT [dbo].[Baskets] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [Title], [Price], [Count], [Description], [Photo], [PersonId], [StatusBy]) VALUES (N'b833be74-90d5-454c-a062-c2e09e167ac7', CAST(N'2023-12-16T00:37:29.2357363+00:00' AS DateTimeOffset), N'Admin_Admin', CAST(N'2023-12-16T00:37:29.2357363+00:00' AS DateTimeOffset), N'Admin_Admin', CAST(N'2023-12-16T00:44:05.8070462+00:00' AS DateTimeOffset), N'kjgh', CAST(4234.00 AS Decimal(18, 2)), 3, N'', N'', N'78687fa7-9982-4712-b477-18adc7933d54', 0)
INSERT [dbo].[Baskets] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [Title], [Price], [Count], [Description], [Photo], [PersonId], [StatusBy]) VALUES (N'22d9a0d8-11fb-4abd-ba5a-cf6dc4cda3ef', CAST(N'2023-12-16T00:22:12.3022158+00:00' AS DateTimeOffset), N'Admin_Admin', CAST(N'2023-12-16T00:45:55.7982816+00:00' AS DateTimeOffset), N'Анонимный', NULL, N'kjgh', CAST(4234.00 AS Decimal(18, 2)), 3, N'', N'', N'78687fa7-9982-4712-b477-18adc7933d54', 1)
INSERT [dbo].[Baskets] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [Title], [Price], [Count], [Description], [Photo], [PersonId], [StatusBy]) VALUES (N'df09af08-79cd-4434-818d-f0aa3a93c603', CAST(N'2023-12-16T00:07:26.7541663+00:00' AS DateTimeOffset), N'Admin_Admin', CAST(N'2023-12-16T00:07:26.7541663+00:00' AS DateTimeOffset), N'Admin_Admin', CAST(N'2023-12-16T00:07:46.1954958+00:00' AS DateTimeOffset), N'Группа', CAST(123.00 AS Decimal(18, 2)), 3, N'', N'C:\Users\Николаев Вячеслав\Downloads\Users.png', N'78687fa7-9982-4712-b477-18adc7933d54', 0)
GO
INSERT [dbo].[Cards] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [Nomer], [CSCCode], [DateEnd], [Balance], [PinCode]) VALUES (N'd54269aa-5ace-41ec-b748-91e546d21aca', CAST(N'2023-12-16T00:07:09.0821042+00:00' AS DateTimeOffset), N'Admin_Admin', CAST(N'2023-12-16T22:00:18.0844212+00:00' AS DateTimeOffset), N'Анонимный', NULL, N'0000-0000-0000-0000', 111, N'12.27', CAST(10000.00 AS Decimal(18, 2)), N'0-0-0-0')
INSERT [dbo].[Cards] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [Nomer], [CSCCode], [DateEnd], [Balance], [PinCode]) VALUES (N'fb19bfdb-e8b5-4613-8bc4-a11e164c3612', CAST(N'2023-12-16T20:17:03.6550582+00:00' AS DateTimeOffset), N'23432_Teset213', CAST(N'2023-12-16T22:00:18.0804210+00:00' AS DateTimeOffset), N'Анонимный', NULL, N'3333-3333-3333-3333', 111, N'12.27', CAST(10.00 AS Decimal(18, 2)), N'3-3-3-3')
INSERT [dbo].[Cards] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [Nomer], [CSCCode], [DateEnd], [Balance], [PinCode]) VALUES (N'cce6d33b-e936-4f8f-b62b-b8ef78b808fd', CAST(N'2023-12-16T21:25:40.9139777+00:00' AS DateTimeOffset), N'1_1', CAST(N'2023-12-16T21:38:26.0633418+00:00' AS DateTimeOffset), N'Анонимный', NULL, N'1111-1111-1111-1111', 111, N'12.27', CAST(123.00 AS Decimal(18, 2)), N'1-1-1-1')
GO
INSERT [dbo].[DBBanks] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [Login], [Password], [Role], [Status]) VALUES (N'ea0f3edb-5aa4-4223-a182-0ab53dea4153', CAST(N'2023-12-16T21:25:18.8003874+00:00' AS DateTimeOffset), N'1_1', CAST(N'2023-12-18T17:20:37.4502621+00:00' AS DateTimeOffset), N'1_1', NULL, N'(111)-111-11-11', N'ef3e7940545e0633345b71ef4fb38e579d574986173174d9cfa43c79539d2912', 0, 1)
INSERT [dbo].[DBBanks] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [Login], [Password], [Role], [Status]) VALUES (N'e0c05fcd-4ee2-474a-999e-7a8cdc01c5c8', CAST(N'2023-12-16T00:06:26.3986111+00:00' AS DateTimeOffset), N'Admin_Admin', CAST(N'2023-12-18T17:20:08.6417152+00:00' AS DateTimeOffset), N'Admin_Admin', NULL, N'(000)-000-00-00', N'bd54a99509b099e85c1b019015cea2aa7b233543928776b9d19c990200ab86c6', 1, 1)
INSERT [dbo].[DBBanks] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [Login], [Password], [Role], [Status]) VALUES (N'b0724ca5-ff1b-408f-9b16-8b6e3955e6d2', CAST(N'2023-12-16T20:12:07.0567309+00:00' AS DateTimeOffset), N'23432_Teset213', CAST(N'2023-12-18T15:29:43.2323650+00:00' AS DateTimeOffset), N'Анонимный', NULL, N'(222)-222-22-22', N'9778db4157cf93224ad45ca69ce49684af8fa94a6dabd7a502bcd5b634d73f5e', 0, 0)
INSERT [dbo].[DBBanks] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [Login], [Password], [Role], [Status]) VALUES (N'283b72c0-0b57-4dec-9499-f657a7c4005c', CAST(N'2023-12-16T16:34:00.9908432+00:00' AS DateTimeOffset), N'Вячеслав_Николаев', CAST(N'2023-12-16T20:33:51.4397213+00:00' AS DateTimeOffset), N'Вячеслав_Николаев', CAST(N'2023-12-16T20:36:01.8417444+00:00' AS DateTimeOffset), N'(111)-111-11-11', N'ef3e7940545e0633345b71ef4fb38e579d574986173174d9cfa43c79539d2912', 0, 1)
GO
INSERT [dbo].[Persons] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [Surname], [Name], [Phone], [Gender], [CardName]) VALUES (N'78687fa7-9982-4712-b477-18adc7933d54', CAST(N'2023-12-16T00:06:26.2015674+00:00' AS DateTimeOffset), N'Admin_Admin', CAST(N'2023-12-16T00:07:09.1291147+00:00' AS DateTimeOffset), N'Admin_Admin', NULL, N'Admin', N'Admin', N'(000)-000-00-00', 0, N'0000-0000-0000-0000')
INSERT [dbo].[Persons] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [Surname], [Name], [Phone], [Gender], [CardName]) VALUES (N'ea7c33a5-c372-4e59-b40e-31112d347df7', CAST(N'2023-12-16T21:25:18.7763823+00:00' AS DateTimeOffset), N'1_1', CAST(N'2023-12-16T21:57:25.5764147+00:00' AS DateTimeOffset), N'1_1', NULL, N'1', N'1', N'(111)-111-11-11', 0, N'1111-1111-1111-1111')
GO
INSERT [dbo].[Tovars] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [Title], [Price], [MaxCount], [Description], [Photo]) VALUES (N'2e9127bf-a8e9-4629-bb72-09ffbca7db80', CAST(N'2023-12-16T22:02:02.8646976+00:00' AS DateTimeOffset), N'Admin_Admin', CAST(N'2023-12-16T22:02:02.8646976+00:00' AS DateTimeOffset), N'Admin_Admin', NULL, N'Броня Саши', CAST(100.00 AS Decimal(18, 2)), 2, N'123', N'C:\Users\Николаев Вячеслав\Downloads\DefenseUpdate.png')
INSERT [dbo].[Tovars] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [Title], [Price], [MaxCount], [Description], [Photo]) VALUES (N'f6348672-b3f8-490e-9044-465ae1fdea36', CAST(N'2023-12-16T01:04:21.2482122+00:00' AS DateTimeOffset), N'Admin_Admin', CAST(N'2023-12-16T01:04:24.9547377+00:00' AS DateTimeOffset), N'Анонимный', CAST(N'2023-12-16T01:04:24.9567394+00:00' AS DateTimeOffset), N'Game', CAST(123.00 AS Decimal(18, 2)), 0, N'123', N'C:\Users\Николаев Вячеслав\Downloads\Game.png')
INSERT [dbo].[Tovars] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [Title], [Price], [MaxCount], [Description], [Photo]) VALUES (N'80fe15f5-583a-4bcc-b046-846b4b959faf', CAST(N'2023-12-16T00:07:23.7191022+00:00' AS DateTimeOffset), N'Admin_Admin', CAST(N'2023-12-16T00:07:23.7191022+00:00' AS DateTimeOffset), N'Admin_Admin', CAST(N'2023-12-16T00:07:41.5844265+00:00' AS DateTimeOffset), N'Группа', CAST(123.00 AS Decimal(18, 2)), 4, N'', N'C:\Users\Николаев Вячеслав\Downloads\Users.png')
INSERT [dbo].[Tovars] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [Title], [Price], [MaxCount], [Description], [Photo]) VALUES (N'1fe8b2ca-9d9b-49d1-9222-8d7ba7972c9b', CAST(N'2023-12-16T20:46:26.7191569+00:00' AS DateTimeOffset), N'Admin_Admin', CAST(N'2023-12-16T20:46:49.1661597+00:00' AS DateTimeOffset), N'Анонимный', CAST(N'2023-12-16T20:46:49.1691606+00:00' AS DateTimeOffset), N'123', CAST(123.00 AS Decimal(18, 2)), 0, N'123', N'')
INSERT [dbo].[Tovars] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [Title], [Price], [MaxCount], [Description], [Photo]) VALUES (N'c1747fd8-c10b-4557-b43c-911701cdfa36', CAST(N'2023-12-16T21:02:30.4462133+00:00' AS DateTimeOffset), N'Admin_Admin', CAST(N'2023-12-16T21:02:53.7382167+00:00' AS DateTimeOffset), N'Анонимный', CAST(N'2023-12-16T21:24:43.8603406+00:00' AS DateTimeOffset), N'123', CAST(123.00 AS Decimal(18, 2)), 119, N'12312313', N'')
INSERT [dbo].[Tovars] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [Title], [Price], [MaxCount], [Description], [Photo]) VALUES (N'80305234-1b8f-4a95-a390-93748dccc0da', CAST(N'2023-12-16T00:22:07.0762203+00:00' AS DateTimeOffset), N'Admin_Admin', CAST(N'2023-12-16T00:37:29.2337362+00:00' AS DateTimeOffset), N'Анонимный', CAST(N'2023-12-16T00:37:29.2357363+00:00' AS DateTimeOffset), N'kjgh', CAST(4234.00 AS Decimal(18, 2)), 0, N'', N'')
INSERT [dbo].[Tovars] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [Title], [Price], [MaxCount], [Description], [Photo]) VALUES (N'd88b550a-aa32-44d5-9512-d3171e694767', CAST(N'0001-01-01T00:00:00.0000000+00:00' AS DateTimeOffset), N'', CAST(N'2023-12-16T21:57:47.8490979+00:00' AS DateTimeOffset), N'Анонимный', NULL, N'32', CAST(34.00 AS Decimal(18, 2)), 39, N'234', N'C:\Users\Николаев Вячеслав\Downloads\Users.png')
INSERT [dbo].[Tovars] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [Title], [Price], [MaxCount], [Description], [Photo]) VALUES (N'b9d0e0d0-df84-4ee7-ba27-edf9c064e1b9', CAST(N'0001-01-01T00:00:00.0000000+00:00' AS DateTimeOffset), N'', CAST(N'2023-12-16T20:19:59.3180634+00:00' AS DateTimeOffset), N'Admin_Admin', CAST(N'2023-12-16T20:56:23.8036661+00:00' AS DateTimeOffset), N'kjgh', CAST(4234.00 AS Decimal(18, 2)), 4, N'sdfsefsewrt2w3', N'C:\Users\Николаев Вячеслав\Downloads\Users.png')
INSERT [dbo].[Tovars] ([Id], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [DeletedAt], [Title], [Price], [MaxCount], [Description], [Photo]) VALUES (N'e085a925-cff0-4681-8648-f142a99509cb', CAST(N'2023-12-16T00:08:55.9816726+00:00' AS DateTimeOffset), N'Admin_Admin', CAST(N'2023-12-16T01:03:47.7646421+00:00' AS DateTimeOffset), N'Анонимный', CAST(N'2023-12-16T01:03:47.7943548+00:00' AS DateTimeOffset), N'Game', CAST(123.00 AS Decimal(18, 2)), 0, N'123', N'C:\Users\Николаев Вячеслав\Downloads\Game.png')
GO
/****** Object:  Index [IX_Baskets_PersonId]    Script Date: 20.12.2023 0:42:35 ******/
CREATE NONCLUSTERED INDEX [IX_Baskets_PersonId] ON [dbo].[Baskets]
(
	[PersonId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Card_Nomer]    Script Date: 20.12.2023 0:42:35 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Card_Nomer] ON [dbo].[Cards]
(
	[Nomer] ASC
)
WHERE ([DeletedAt] IS NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_DBBank_Login]    Script Date: 20.12.2023 0:42:35 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_DBBank_Login] ON [dbo].[DBBanks]
(
	[Login] ASC
)
WHERE ([DeletedAt] IS NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DBBank_Status]    Script Date: 20.12.2023 0:42:35 ******/
CREATE NONCLUSTERED INDEX [IX_DBBank_Status] ON [dbo].[DBBanks]
(
	[Status] ASC
)
WHERE ([DeletedAt] IS NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Person_Phone]    Script Date: 20.12.2023 0:42:35 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Person_Phone] ON [dbo].[Persons]
(
	[Phone] ASC
)
WHERE ([DeletedAt] IS NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Tovar_Title]    Script Date: 20.12.2023 0:42:35 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Tovar_Title] ON [dbo].[Tovars]
(
	[Title] ASC
)
WHERE ([DeletedAt] IS NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Baskets]  WITH CHECK ADD  CONSTRAINT [FK_Baskets_Persons_PersonId] FOREIGN KEY([PersonId])
REFERENCES [dbo].[Persons] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Baskets] CHECK CONSTRAINT [FK_Baskets_Persons_PersonId]
GO
USE [master]
GO
ALTER DATABASE [OOO_Bank_NVA] SET  READ_WRITE 
GO
