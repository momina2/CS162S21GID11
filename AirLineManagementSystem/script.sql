USE [AirlineManagement]
GO
/****** Object:  Table [dbo].[AirlineData]    Script Date: 20/06/2021 9:52:28 am ******/
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
/****** Object:  Table [dbo].[allFlights]    Script Date: 20/06/2021 9:52:28 am ******/
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
	[Date] [date] NULL,
	[Luggage] [nvarchar](50) NULL,
	[Layover] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeInfo]    Script Date: 20/06/2021 9:52:28 am ******/
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
/****** Object:  Table [dbo].[PassengerInfo]    Script Date: 20/06/2021 9:52:28 am ******/
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
INSERT [dbo].[AirlineData] ([AirlineCode], [AirlineName], [Status], [Description]) VALUES (N'#228      ', N'PIA       ', N'Active    ', N'Domestic Flights Only                             ')
INSERT [dbo].[AirlineData] ([AirlineCode], [AirlineName], [Status], [Description]) VALUES (N'#425      ', N'QATAE     ', N'Active    ', N'international                                     ')
INSERT [dbo].[AirlineData] ([AirlineCode], [AirlineName], [Status], [Description]) VALUES (N'#144      ', N'EMIRATES  ', N'Active    ', N'international                                     ')
GO
INSERT [dbo].[allFlights] ([FlightCode], [Source], [Destination], [Airline], [FlightType], [TimeTravel], [Date], [Luggage], [Layover]) VALUES (N'#F356', N'Turkey', N'Australia', N'emirates  ', N'international flight', N'593Hours', CAST(N'2021-06-22' AS Date), N'5', N'')
INSERT [dbo].[allFlights] ([FlightCode], [Source], [Destination], [Airline], [FlightType], [TimeTravel], [Date], [Luggage], [Layover]) VALUES (N'#K214', N'Lahore', N'Karachi', N'PIA       ', N'DOMESTIC FLIGHT', N'593Hours', CAST(N'2021-06-23' AS Date), N'5', N'')
INSERT [dbo].[allFlights] ([FlightCode], [Source], [Destination], [Airline], [FlightType], [TimeTravel], [Date], [Luggage], [Layover]) VALUES (N'#M442', N'Karachi', N'Faisalabad', N'PIA       ', N'DOMESTIC FLIGHT', N'140Hours', CAST(N'2021-09-06' AS Date), N'4', N'')
INSERT [dbo].[allFlights] ([FlightCode], [Source], [Destination], [Airline], [FlightType], [TimeTravel], [Date], [Luggage], [Layover]) VALUES (N'#I188', N'Australia', N'Zimbabwe', N'QATAE     ', N'international flight', N'25917Hours', CAST(N'2021-06-24' AS Date), N'4', N'')
GO
INSERT [dbo].[EmployeeInfo] ([ID], [Name], [Phone#], [CNIC], [Password]) VALUES (N'#AMS371', N'Khadija Dar', N'03004411255', N'35202-4357453-4', N'Khadija123')
INSERT [dbo].[EmployeeInfo] ([ID], [Name], [Phone#], [CNIC], [Password]) VALUES (N'#AMS493', N'Momina Ghauri', N'03217732457', N'35202-6597408-8', N'Momina123')
GO
INSERT [dbo].[PassengerInfo] ([Name], [Passport#], [CNIC], [Phone#], [Email], [Ticket], [Payment]) VALUES (N'Fiza Akram', N'678954321', N'35202-7606711-4', N'0330605513', N'fiza@gmail.com', N'#A001325', N'1225')
INSERT [dbo].[PassengerInfo] ([Name], [Passport#], [CNIC], [Phone#], [Email], [Ticket], [Payment]) VALUES (N'Talha Ramzan', N'123456789', N'35202-7607611-2', N'03330605515', N'Talha@gmail.com', N'#A001299', N'1000')
INSERT [dbo].[PassengerInfo] ([Name], [Passport#], [CNIC], [Phone#], [Email], [Ticket], [Payment]) VALUES (N'Muneeb ', N'234567890', N'35202-7606711-8', N'03330605513', N'Muneeb@gmail.com', N'#A001667', N'1000')
INSERT [dbo].[PassengerInfo] ([Name], [Passport#], [CNIC], [Phone#], [Email], [Ticket], [Payment]) VALUES (N'Bilal', N'098765432', N'35202-6706711-2', N'03330605514', N'bilal@gmail.com', N'#A001918', N'1180')
GO
