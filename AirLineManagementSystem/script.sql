USE [AirlineManagement]
GO
/****** Object:  Table [dbo].[AirlineData]    Script Date: 6/4/2021 10:01:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AirlineData](
	[AirlineCode] [nchar](10) NULL,
	[AirlineName] [nchar](10) NULL,
	[Status] [nchar](10) NULL,
	[Description] [nchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[allFlights]    Script Date: 6/4/2021 10:01:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[allFlights](
	[FlightCode] [nchar](10) NOT NULL,
	[Source] [nchar](10) NOT NULL,
	[Destination] [nchar](10) NOT NULL,
	[AirLine] [nchar](10) NOT NULL,
	[FlightType] [nchar](10) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeInfo]    Script Date: 6/4/2021 10:01:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeInfo](
	[ID] [nvarchar](50) NULL,
	[Name] [nvarchar](50) NULL,
	[Phone#] [nvarchar](50) NULL,
	[CNIC] [nvarchar](50) NULL,
	[Password] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PassengerInfo]    Script Date: 6/4/2021 10:01:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PassengerInfo](
	[Name] [nvarchar](50) NOT NULL,
	[Passport#] [nvarchar](50) NOT NULL,
	[CNIC] [nvarchar](50) NOT NULL,
	[Phone#] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Ticket#] [nvarchar](50) NOT NULL,
	[Payment] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[AirlineData] ([AirlineCode], [AirlineName], [Status], [Description]) VALUES (N'#143      ', N'PIA       ', N'Active    ', N'JA JA TUR JA
                                     ')
INSERT [dbo].[AirlineData] ([AirlineCode], [AirlineName], [Status], [Description]) VALUES (N'#143      ', N'WTF       ', N'Not Active', N'pffft                                             ')
GO
INSERT [dbo].[allFlights] ([FlightCode], [Source], [Destination], [AirLine], [FlightType]) VALUES (N'#123H436  ', N'Skardu    ', N'Rawalpindi', N'PIA       ', N'Domestic  ')
GO
INSERT [dbo].[EmployeeInfo] ([ID], [Name], [Phone#], [CNIC], [Password]) VALUES (N'#AMS179', N'Momina', N'03226618399', N'3520265974088', N'momina123')
INSERT [dbo].[EmployeeInfo] ([ID], [Name], [Phone#], [CNIC], [Password]) VALUES (N'#AMS194', N'Khadwa', N'03215528441', N'3520251739466', N'khadwa123')
INSERT [dbo].[EmployeeInfo] ([ID], [Name], [Phone#], [CNIC], [Password]) VALUES (N'#AMS204', N'Keeri', N'03216628465', N'3520262947104', N'keeri123')
INSERT [dbo].[EmployeeInfo] ([ID], [Name], [Phone#], [CNIC], [Password]) VALUES (N'#AMS238', N'tud', N'03217749243', N'3520262439672', N'tud007')
GO
INSERT [dbo].[PassengerInfo] ([Name], [Passport#], [CNIC], [Phone#], [Email], [Ticket#], [Payment]) VALUES (N'khadwa', N'123', N'456', N'789', N'k@gmail.com', N'#A001207', N'')
GO
