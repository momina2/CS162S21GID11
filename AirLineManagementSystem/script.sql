USE [AirlineManagement]
GO
/****** Object:  Table [dbo].[AirlineData]    Script Date: 6/4/2021 1:45:10 PM ******/
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
/****** Object:  Table [dbo].[allFlights]    Script Date: 6/4/2021 1:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[allFlights](
	[FlightCode] [nvarchar](50) NULL,
	[Source] [nvarchar](50) NULL,
	[Destination] [nvarchar](50) NULL,
	[Airline] [nvarchar](50) NULL,
	[FlightType] [nvarchar](50) NULL,
	[TimeTravel] [nvarchar](50) NULL,
	[Date] [nvarchar](50) NULL,
	[Luggage] [nvarchar](50) NULL,
	[Layover] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeInfo]    Script Date: 6/4/2021 1:45:10 PM ******/
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
/****** Object:  Table [dbo].[PassengerInfo]    Script Date: 6/4/2021 1:45:10 PM ******/
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
INSERT [dbo].[allFlights] ([FlightCode], [Source], [Destination], [Airline], [FlightType], [TimeTravel], [Date], [Luggage], [Layover]) VALUES (N'#G220', N'Norway', N'Lebanon', N'WTF       ', N'international flight', N'56000', N'22-01-2021', N'5', N'')
INSERT [dbo].[allFlights] ([FlightCode], [Source], [Destination], [Airline], [FlightType], [TimeTravel], [Date], [Luggage], [Layover]) VALUES (N'#R164', N'Turbat', N'Lahore', N'PIA       ', N'DOMESTIC FLIGHT', N'5000', N'22-01-2021', N'4', N'')
INSERT [dbo].[allFlights] ([FlightCode], [Source], [Destination], [Airline], [FlightType], [TimeTravel], [Date], [Luggage], [Layover]) VALUES (N'#M290', N'Rawalpindi', N'Peshawar', N'PIA       ', N'DOMESTIC FLIGHT', N'123', N'22-01-2021', N'3', N'')
INSERT [dbo].[allFlights] ([FlightCode], [Source], [Destination], [Airline], [FlightType], [TimeTravel], [Date], [Luggage], [Layover]) VALUES (N'#V363', N' lahore', N'karachi', N'PIA       ', N'DOMESTIC FLIGHT', N'56', N'22-01-2021', N'2', N'')
INSERT [dbo].[allFlights] ([FlightCode], [Source], [Destination], [Airline], [FlightType], [TimeTravel], [Date], [Luggage], [Layover]) VALUES (N'#Y449', N'Muzaffarabad', N'Lahore', N'PIA       ', N'DOMESTIC FLIGHT', N'2', N'22-01-2021', N'5', N'')
GO
INSERT [dbo].[EmployeeInfo] ([ID], [Name], [Phone#], [CNIC], [Password]) VALUES (N'#AMS179', N'Momina', N'03226618399', N'3520265974088', N'momina123')
INSERT [dbo].[EmployeeInfo] ([ID], [Name], [Phone#], [CNIC], [Password]) VALUES (N'#AMS194', N'Khadwa', N'03215528441', N'3520251739466', N'khadwa123')
INSERT [dbo].[EmployeeInfo] ([ID], [Name], [Phone#], [CNIC], [Password]) VALUES (N'#AMS204', N'Keeri', N'03216628465', N'3520262947104', N'keeri123')
INSERT [dbo].[EmployeeInfo] ([ID], [Name], [Phone#], [CNIC], [Password]) VALUES (N'#AMS238', N'tud', N'03217749243', N'3520262439672', N'tud007')
GO
INSERT [dbo].[PassengerInfo] ([Name], [Passport#], [CNIC], [Phone#], [Email], [Ticket#], [Payment]) VALUES (N'khadwa', N'123', N'456', N'789', N'k@gmail.com', N'#A001207', N'')
GO
