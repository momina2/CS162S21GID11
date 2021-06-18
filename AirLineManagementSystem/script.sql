USE [AirlineManagement]
GO
/****** Object:  Table [dbo].[AirlineData]    Script Date: 18/06/2021 4:48:32 am ******/
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
/****** Object:  Table [dbo].[allFlights]    Script Date: 18/06/2021 4:48:33 am ******/
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
/****** Object:  Table [dbo].[EmployeeInfo]    Script Date: 18/06/2021 4:48:33 am ******/
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
/****** Object:  Table [dbo].[PassengerInfo]    Script Date: 18/06/2021 4:48:33 am ******/
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
	[Ticket] [nvarchar](50) NOT NULL,
	[Payment] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[AirlineData] ([AirlineCode], [AirlineName], [Status], [Description]) VALUES (N'#143      ', N'PIA       ', N'Active    ', N'JA JA TUR JA
                                     ')
INSERT [dbo].[AirlineData] ([AirlineCode], [AirlineName], [Status], [Description]) VALUES (N'#143      ', N'WTF       ', N'Not Active', N'pffft                                             ')
INSERT [dbo].[AirlineData] ([AirlineCode], [AirlineName], [Status], [Description]) VALUES (N'224       ', N'emirates  ', N'Active    ', N'achi hai                                          ')
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
INSERT [dbo].[PassengerInfo] ([Name], [Passport#], [CNIC], [Phone#], [Email], [Ticket], [Payment]) VALUES (N'Fiza Akram', N'09823456', N'3520276067112', N'03330605515', N'fiza@gmail.com', N'#A001617', N'')
INSERT [dbo].[PassengerInfo] ([Name], [Passport#], [CNIC], [Phone#], [Email], [Ticket], [Payment]) VALUES (N'', N'', N'', N'', N'', N'#A001552', N'7000500')
INSERT [dbo].[PassengerInfo] ([Name], [Passport#], [CNIC], [Phone#], [Email], [Ticket], [Payment]) VALUES (N'Momina', N'67345464322', N'3520276067112', N'03330505516', N'momina@gmail.com', N'#A001247', N'')
INSERT [dbo].[PassengerInfo] ([Name], [Passport#], [CNIC], [Phone#], [Email], [Ticket], [Payment]) VALUES (N'Muneeb ', N'09823455', N'3456753', N'033060', N'muneeb@gmail.com', N'#A001116', N'13000')
INSERT [dbo].[PassengerInfo] ([Name], [Passport#], [CNIC], [Phone#], [Email], [Ticket], [Payment]) VALUES (N'Rehan ', N'124567', N'3520276067112', N'0330605515', N'Rehan@gmail.com', N'#A001942', N'13000')
INSERT [dbo].[PassengerInfo] ([Name], [Passport#], [CNIC], [Phone#], [Email], [Ticket], [Payment]) VALUES (N'Ayesha ', N'1244', N'098356', N'03306065515', N'Ayesha@gmail.com', N'#A001882', N'13000')
INSERT [dbo].[PassengerInfo] ([Name], [Passport#], [CNIC], [Phone#], [Email], [Ticket], [Payment]) VALUES (N'Wajeeha ', N'1234', N'12234', N'12234', N'Wajeeha@gmail.com', N'#A001863', N'13000')
INSERT [dbo].[PassengerInfo] ([Name], [Passport#], [CNIC], [Phone#], [Email], [Ticket], [Payment]) VALUES (N'kok', N'9090', N'8087987', N'7979', N'jiji', N'#A001034', N'13000')
INSERT [dbo].[PassengerInfo] ([Name], [Passport#], [CNIC], [Phone#], [Email], [Ticket], [Payment]) VALUES (N'Naveed Dar', N'jijij', N'ijijijij', N'ijijijij', N'jijijiji', N'#A001416', N'13000')
INSERT [dbo].[PassengerInfo] ([Name], [Passport#], [CNIC], [Phone#], [Email], [Ticket], [Payment]) VALUES (N'jiji', N'jiji', N'jiji', N'jiji', N'jiji', N'#A001473', N'13000')
INSERT [dbo].[PassengerInfo] ([Name], [Passport#], [CNIC], [Phone#], [Email], [Ticket], [Payment]) VALUES (N'Billo', N'123456', N'accae434', N'23232', N'2422f', N'#A001993', N'13000')
INSERT [dbo].[PassengerInfo] ([Name], [Passport#], [CNIC], [Phone#], [Email], [Ticket], [Payment]) VALUES (N'kokok', N'ninin', N'232d2', N'd3d3d', N'2d2d44', N'#A001378', N'13000')
INSERT [dbo].[PassengerInfo] ([Name], [Passport#], [CNIC], [Phone#], [Email], [Ticket], [Payment]) VALUES (N'Khadija', N'080', N'9090jij', N'9090ji', N'90909fefef', N'#A001274', N'7004')
INSERT [dbo].[PassengerInfo] ([Name], [Passport#], [CNIC], [Phone#], [Email], [Ticket], [Payment]) VALUES (N'lplp', N'lpl', N'090', N'9090', N'099kiki', N'#A001460', N'13000')
INSERT [dbo].[PassengerInfo] ([Name], [Passport#], [CNIC], [Phone#], [Email], [Ticket], [Payment]) VALUES (N'kok', N'kok', N'koko', N'koko', N'koko', N'#A001368', N'10000')
INSERT [dbo].[PassengerInfo] ([Name], [Passport#], [CNIC], [Phone#], [Email], [Ticket], [Payment]) VALUES (N'koko', N'kokok', N'kokok', N'kokok', N'kokoko', N'#A001355', N'10000')
INSERT [dbo].[PassengerInfo] ([Name], [Passport#], [CNIC], [Phone#], [Email], [Ticket], [Payment]) VALUES (N'Dar Sahab', N'12345', N'456789', N'03330605515', N'naveed@gmail.com', N'#A001689', N'22000')
INSERT [dbo].[PassengerInfo] ([Name], [Passport#], [CNIC], [Phone#], [Email], [Ticket], [Payment]) VALUES (N'Ghouri Sahab', N'0987', N'123455', N'343434', N'momnakbaba@gmail.com', N'#A001055', N'22000')
INSERT [dbo].[PassengerInfo] ([Name], [Passport#], [CNIC], [Phone#], [Email], [Ticket], [Payment]) VALUES (N'', N'', N'', N'', N'', N'#A001108', N'22000')
GO
